using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

using ec = ComiLib.EtherCAT.SafeNativeMethods;
using ComiLib.EtherCAT.Slave;

namespace EtherCAT_Examples_CSharp
{
    public partial class formMC02P : Form
    {
        public formMC02P()
        {
            InitializeComponent();
            InitDevice();
            InitForm();
            Init_MC02P();
        }

        int netID = 5;
        int errorCode = 0;

        IntPtr[] inPdoPtr = new IntPtr[2] { IntPtr.Zero, IntPtr.Zero }; // TxData 위치
        IntPtr[] outPdoPtr = new IntPtr[2] { IntPtr.Zero, IntPtr.Zero }; // RxData 위치

        private ETS_MC02P.InPDO[] inPDO = new ETS_MC02P.InPDO[2]; // TxData
        private ETS_MC02P.OutPDO[] outPDO = new ETS_MC02P.OutPDO[2]; // RxData

        int pdoEntryOffset = 0x800;
        int pdoIndexOffset = 0x10;

        ushort slaveAddr = 0x0;
                
        public int connectState = 1; // 통신 연결 상태에 대해서는 본 예제에서 다루지 않는다.
        bool isReady = false;

        void InitDevice()
        {
            if (!ec.ecGn_IsDevLoaded(0, ref errorCode))
                ec.ecGn_LoadDevice(ref errorCode);
        }

        void InitForm()
        {
            rdoJog.Checked = true;
            InitHome();
            InitConfig();
        }

        public enum MoveMode
        {
            Jog,
            Relative,
            Absolute,
            Velocity
        }
        MoveMode moveMode = MoveMode.Jog;


        private void Init_MC02P()
        {
            // MC02P 모듈의 존재 여부와 SlavePhysAddress를 확인하는 코드이다.
            // 예제를 위한 코드이며, 하나의 모듈만 체크한다.
            uint slaveCount = ec.ecNet_ScanSlaves(netID, ref errorCode);
            for (int s = 0; s < slaveCount; s++)
            {
                ec.TEcSlaveCfg slaveCfg = new ec.TEcSlaveCfg();
                ec.ecCfg_GetSlaveConfig(netID, s, ref slaveCfg, ref errorCode);
                if (slaveCfg.ProdCode == 0x5032D752)
                {
                    slaveAddr = slaveCfg.PhysAddr;
                    break;
                }
            }

            if (slaveAddr == 0)
                return;

            //InPDO Data의 시작위치를 확인한다.
            //메모리에 복사된 Slave Data 중 MC02P Axis0의 Data 위치를 찾는 과정이다.
            inPdoPtr[0] = ec.ecSlv_InPDO_GetBufPtr(netID, slaveAddr, 0, ref errorCode);
            if (inPdoPtr[0] == IntPtr.Zero)
                return;

            // Axis 1의 위치는 Axis 0의 위치에서 Axis_0 Data Size만큼 Offset하여 구할 수 있다.
            inPdoPtr[1] = inPdoPtr[0] + Marshal.SizeOf(inPDO[0]);

            //OutPDO Data의 시작위치를 확인한다
            //EtherCAT Frame에 포함될 Data 중 MC02P의 위치를 확인하는 과정이다.
            outPdoPtr[0] = ec.ecSlv_OutPDO_GetBufPtr(netID, slaveAddr, 0, ref errorCode);
            if (outPdoPtr[0] == IntPtr.Zero)
                return;

            outPdoPtr[1] = outPdoPtr[0] + Marshal.SizeOf(outPDO[0]);

            //OutPDO 초기값
            int tempVal = 0;
            for (int i = 0; i < 2; i++) 
            {
                ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x06040 + i * pdoEntryOffset, 0, 0, 2, ref tempVal, ref errorCode);    //Control_Word
                outPDO[i].Control_Word = (short)tempVal;
                ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x06060 + i * pdoEntryOffset, 0, 0, 1, ref tempVal, ref errorCode);    //Modes_of_Operation
                outPDO[i].Modes_of_Operation = (byte)tempVal;                
            }

            isReady = true;
            cbxAxis.SelectedIndex = 0;
        }

        #region Read/Wrtie InPDO

        public void WriteOutPDO()
        {
            if (!isReady || connectState == 0) // EtherCAT 통신이 끊겼을 경우등의 에러처리
                return;

            Marshal.StructureToPtr(outPDO[axisID], outPdoPtr[axisID], false);
        }

        public void ReadInPDO()
        {
            if (!isReady || connectState == 0) // EtherCAT 통신이 끊겼을 경우등의 에러처리
                return;

            inPDO[axisID] = (ETS_MC02P.InPDO)(Marshal.PtrToStructure(inPdoPtr[axisID], typeof(ETS_MC02P.InPDO)));
        }

        #endregion

        int axisID = 0;
        void UpdateForm()
        {
            axisID = cbxAxis.SelectedIndex;
            switch (tabMenu.SelectedIndex)
            {
                case 0:
                    GetSpeed();
                    break;

                case 1:
                    UpdateHomingInfo();
                    break;

                case 2:
                    UpdateConfig();
                    break;

                case 3:
                    IxGetSpeed();
                    break;
            }

        }
        private void cbxAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void btnServoOn_Click(object sender, EventArgs e)
        {
            bool isServoOn = GetServoOn();
            SetServoOn(!isServoOn);
        }

        bool GetServoOn()
        {
            ReadInPDO();
            //return ((inPDO[axisID].Status_Word >> 2) & 1) == 1;
            return ((inPDO[axisID].Digital_Input >> 16) & 1) == 1;
        }

        void SetServoOn(bool isOn)
        {
            // ServoOn 전에 Command Position 에 Feedback Position을 overwrite 한다.            
            outPDO[axisID].Target_Position = inPDO[axisID].Position_Actual_Value;
            outPDO[axisID].Control_Word |= (1 << 8);

            if (isOn)
            {
                outPDO[axisID].Control_Word |= (1 << 0);
                outPDO[axisID].Control_Word |= (1 << 3);
            }
            else
            {
                outPDO[axisID].Control_Word = (short)(outPDO[axisID].Control_Word & ~(1 << 3));
            }

            WriteOutPDO();
        }

        private void rdoJog_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = sender as RadioButton;
            if (!rdo.Checked)
                return;

            moveMode = (MoveMode)Enum.Parse(typeof(MoveMode), rdo.Text);

            switch (moveMode)
            {
                case MoveMode.Jog:
                case MoveMode.Velocity:
                    lblDist1.Text = string.Empty;
                    lblDist2.Text = string.Empty;
                    tbxDist0.Enabled = false;
                    tbxDist1.Enabled = false;
                    break;

                case MoveMode.Relative:
                    lblDist1.Text = "Distance(-)";
                    lblDist2.Text = "Distance(+)";
                    tbxDist0.Enabled = true;
                    tbxDist1.Enabled = true;
                    break;

                case MoveMode.Absolute:
                    lblDist1.Text = "Position 1";
                    lblDist2.Text = "Position 2";
                    tbxDist0.Enabled = true;
                    tbxDist1.Enabled = true;
                    break;
            }
        }


        private void btnMoveN_MouseDown(object sender, MouseEventArgs e)
        {
            SetSpeed();

            if (IsIxMode)
                IsIxMode = false;

            switch (moveMode)
            {
                case MoveMode.Jog:
                    VMoveStart(0);
                    break;

                default:
                    break;
            }
        }

        void VMoveStart(int direction)
        {
            if (inPDO[axisID].Modes_of_Operation_Display != 1)
            {
                outPDO[axisID].Modes_of_Operation = 1;
                WriteOutPDO();
            }

            outPDO[axisID].Control_Word &= ~(1 << 4);
            outPDO[axisID].Control_Word |= (1 << 6);
            outPDO[axisID].Control_Word &= ~(1 << 8); //Halt
            outPDO[axisID].Target_Position = (float)(direction == 1 ? 1147483467 : -1147483647);
            // unistDistance를 설정하는 경우 
            // outPDO[axisID].Target_Position = (float)(direction == 1 ? 1147483467 / UnitDistance : -1147483647 / UnitDistance);

            WriteOutPDO();
            Thread.Sleep(2);

            outPDO[axisID].Control_Word |= (1 << 4);
            WriteOutPDO();
        }


        void MoveStart(int distance)
        {   
            ReadInPDO();
            if (inPDO[axisID].Modes_of_Operation_Display != 1)
            {
                outPDO[axisID].Modes_of_Operation = 1;
                WriteOutPDO();
            }

            outPDO[axisID].Control_Word &= ~(1 << 4);
            outPDO[axisID].Control_Word |= (1 << 6); //Rel
            outPDO[axisID].Control_Word &= ~(1 << 8); //Halt
            outPDO[axisID].Target_Position = (float)distance;

            WriteOutPDO();
            Thread.Sleep(2);

            outPDO[axisID].Control_Word |= (1 << 4); //NewSetPoint
            WriteOutPDO();
        }


        void MoveToStart(int position)
        {
            if (inPDO[axisID].Modes_of_Operation_Display != 1)
            {
                outPDO[axisID].Modes_of_Operation = 1;
                WriteOutPDO();
            }

            outPDO[axisID].Control_Word &= ~(1 << 4);
            outPDO[axisID].Control_Word &= ~(1 << 6);
            outPDO[axisID].Control_Word &= ~(1 << 8); //Halt
            outPDO[axisID].Target_Position = (float)position;

            WriteOutPDO();
            Thread.Sleep(2);

            outPDO[axisID].Control_Word |= (1 << 4);
            WriteOutPDO();
        }

        void Stop()
        {
            int value = 0;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x605D, 0, 0, 2, ref value, ref errorCode);

            if (inPDO[axisID].Modes_of_Operation_Display != 1)
            {
                outPDO[axisID].Modes_of_Operation = 1;
                WriteOutPDO();
            }

            outPDO[axisID].Control_Word |= (1 << 8);
            WriteOutPDO();
        }

        void StopEmg()
        {
            int value = 1;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x605D, 0, 0, 2, ref value, ref errorCode);
            //halt option code 변경

            if (inPDO[axisID].Modes_of_Operation_Display != 1)
            {
                outPDO[axisID].Modes_of_Operation = 1;
                WriteOutPDO();
            }

            Thread.Sleep(1);

            outPDO[axisID].Control_Word |= (1 << 8);
            WriteOutPDO();

            Thread.Sleep(1);

            value = 1;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x605D, 0, 0, 2, ref value, ref errorCode);
        }


        private void btnMoveP_MouseDown(object sender, MouseEventArgs e)
        {
            SetSpeed();

            switch (moveMode)
            {
                case MoveMode.Jog:
                    VMoveStart(1);
                    break;

                default:
                    break;
            }
        }


        private void btnMoveN_MouseUp(object sender, MouseEventArgs e)
        {
            switch (moveMode)
            {
                case MoveMode.Jog:
                    Stop();
                    break;

                case MoveMode.Relative: // 현재 위치에서 입력된 거리만큼 이송한다.
                    int dist;
                    int.TryParse(tbxDist0.Text, out dist);
                    MoveStart(dist);
                    break;

                case MoveMode.Absolute: // 입력된 위치로 이송한다.
                    int pos;
                    int.TryParse(tbxDist0.Text, out pos);
                    MoveToStart(pos);
                    break;

                case MoveMode.Velocity: // Stop 명령이 입력될 때까지 이송한다.
                    VMoveStart(0);
                    break;
            }

            // Move 와 MoveTo 함수는 실행 후 바로 반환된다.
            // 이송이 끝난 후 다음 이송으로 연계하기 위해서는 끝날때까지 대기하는 것이 좋다.
            // 030_formSxMove.cs 참조

        }


        private void btnMoveP_MouseUp(object sender, MouseEventArgs e)
        {
            switch (moveMode)
            {
                case MoveMode.Jog:
                    Stop();
                    break;

                case MoveMode.Relative:
                    int dist;
                    int.TryParse(tbxDist1.Text, out dist);
                    MoveStart(dist);
                    break;

                case MoveMode.Absolute:
                    int pos;
                    int.TryParse(tbxDist1.Text, out pos);
                    MoveToStart(pos);
                    break;

                case MoveMode.Velocity:
                    VMoveStart(1);
                    break;
            }
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }


        private void btnStopEmg_Click(object sender, EventArgs e)
        {
            StopEmg();
        }

        bool IsDone()
        {
            int isDone = ((inPDO[axisID].Status_Word >> 10) & 1);
            if (isDone == 1)
                outPDO[axisID].Control_Word = 15;

            return isDone == 1;
        }


        #region SpeedSetup

        float workSpeed = 1000;
        float accel = 10000;
        float decel = 10000;
        float max = 0;
        int speedMode = 2;

        private void SetSpeed()
        {
            // 속도는 해당 함수가 적용되기 전에는 이전 값이 적용된다.
            // 즉 명시적으로 속도를 변경하지 않으면 한번 설정한 속도가 계속 유지되므로,
            // 이송시마다 속도 설정을 할 필요는 없다.

            workSpeed = 0;
            accel = 0;
            decel = 0;

            speedMode = cbxSpeedMode.SelectedIndex;
            float.TryParse(tbxWorkSpeed.Text, out workSpeed);
            float.TryParse(tbxAccel.Text, out accel);
            float.TryParse(tbxDecel.Text, out decel);
            float.TryParse(tbxMax.Text, out max);

            ec.ecSlv_WriteCoeSdo_Float(netID, slaveAddr, 0x06081 + axisID * pdoEntryOffset, 0, 0, 4, ref workSpeed, ref errorCode); //workSpeed
            ec.ecSlv_WriteCoeSdo_Float(netID, slaveAddr, 0x06083 + axisID * pdoEntryOffset, 0, 0, 4, ref accel, ref errorCode); //accel
            ec.ecSlv_WriteCoeSdo_Float(netID, slaveAddr, 0x06084 + axisID * pdoEntryOffset, 0, 0, 4, ref decel, ref errorCode); //decel
            ec.ecSlv_WriteCoeSdo_Float(netID, slaveAddr, 0x0607F + axisID * pdoEntryOffset, 0, 0, 4, ref max, ref errorCode);  //maxSpeed
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x06086 + axisID * pdoEntryOffset, 0, 0, 2, ref speedMode, ref errorCode);   //speedMode
        }

        void GetSpeed()
        {
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x06081 + axisID * pdoEntryOffset, 0, 0, 4, ref workSpeed, ref errorCode);  //workSpeed 
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x06083 + axisID * pdoEntryOffset, 0, 0, 4, ref accel, ref errorCode);  //accel 
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x06084 + axisID * pdoEntryOffset, 0, 0, 4, ref decel, ref errorCode);  //decel 
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x0607F + axisID * pdoEntryOffset, 0, 0, 4, ref max, ref errorCode);   //maxSpeed
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x06086 + axisID * pdoEntryOffset, 0, 0, 2, ref speedMode, ref errorCode);    //speedMode

            cbxSpeedMode.SelectedIndex = speedMode;
            tbxWorkSpeed.Text = workSpeed.ToString();
            tbxAccel.Text = accel.ToString();
            tbxDecel.Text = decel.ToString();
            tbxMax.Text = max.ToString();
        }

        void UpdateData()
        {
            // 그 외 신호는 다음과 같다.
            // 설정시에는 WriteCoeSdo 명령 실행

            int iVal = 0;
            float fVal = 0;
            //unitDistance
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x2001 + axisID * pdoIndexOffset, 1, 0, 4, ref fVal, ref errorCode);
            //unitSpeed
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x2001 + axisID * pdoIndexOffset, 2, 0, 4, ref fVal, ref errorCode);
            //Alarm Logic
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 1, 0, 1, ref iVal, ref errorCode);
            //EL Logic
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 2, 0, 1, ref iVal, ref errorCode);
            //EZ Logic
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 4, 0, 1, ref iVal, ref errorCode);
            //ORG Logic
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 3, 0, 1, ref iVal, ref errorCode);
            //SoftLimit Enable
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 10, 0, 1, ref iVal, ref errorCode);
            //SoftLimit Value (-)
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x607D + axisID * pdoIndexOffset, 1, 0, 4, ref fVal, ref errorCode);
            //SoftLimit Value (+)
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x607D + axisID * pdoIndexOffset, 2, 0, 4, ref fVal, ref errorCode);            
            //inputMode
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 7, 0, 1, ref iVal, ref errorCode);
            //inputMode - isReverse
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 9, 0, 1, ref iVal, ref errorCode);
            //outputMode
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 6, 0, 1, ref iVal, ref errorCode);
            
        }


        #endregion

        private void t_MC02P_Tick(object sender, EventArgs e)
        {
            btnServoOn.BackColor = GetServoOn() ? Color.DarkOrange : Color.White;
            btnServoOn.ForeColor = GetServoOn() ? Color.White: Color.Black;

            UpdateMioState();
        }

        void UpdateMioState()
        {
            lblCmdPos.Text = outPDO[axisID].Target_Position.ToString();
            lblFdbPos.Text = inPDO[axisID].Position_Actual_Value.ToString();

            bool isReady = ((inPDO[axisID].Digital_Input >> 0) & 1) == 1;
            bool isAlarm = ((inPDO[axisID].Digital_Input >> 1) & 1) == 1;
            bool isNEL = ((inPDO[axisID].Digital_Input >> 2) & 1) == 1;
            bool isPEL = ((inPDO[axisID].Digital_Input >> 3) & 1) == 1;
            bool isOrigin = ((inPDO[axisID].Digital_Input >> 4) & 1) == 1;
            bool isInposition = ((inPDO[axisID].Digital_Input >> 9) & 1) == 1;
            ChangeState(lblRDY, isReady);
            ChangeState(lblAlarm, isAlarm);
            ChangeState(lblNEL, isNEL);
            ChangeState(lblPEL, isPEL);
            ChangeState(lblORG, isOrigin);
            ChangeState(lblINP, isInposition);
        }

        void ChangeState(Label lbl, bool isOn)
        {
            if (isOn)
            {
                lbl.ForeColor = Color.White;
                lbl.BackColor = Color.DarkOrange;
            }
            else
            {
                lbl.ForeColor = Color.Gray;
                lbl.BackColor = Color.White;
            }
        }

        // ========================================================
        //                        Homing 
        // ========================================================

        public string[] homeMode_MC02P = new string[14] {
            "MODE -6 : (+)ORG ON → STOP → Vr 이송 → ORG OFF → V 이송 → ORG ON → index pulse ON → Stop",
            "MODE -5 : (-)ORG ON → STOP → Vr 이송 → ORG OFF → V 이송 → ORG ON → index pulse ON → Stop",
            "MODE -4 : (+)ORG ON → STOP → Vr 이송 → ORG OFF → V 이송 → ORG ON → Stop",
            "MODE -3 : (-)ORG ON → STOP → Vr 이송 → ORG OFF → V 이송 → ORG ON → Stop",
            "MODE 1 : (-)EL ON → STOP → Vr 이송 → Index pulse ON → Stop",
            "MODE 2 : (+)EL ON → STOP → Vr 이송 → Index pulse ON → Stop",
            "MODE 7 : (+)ORG ON → STOP → Vr 이송 → Index pulse ON → Stop",
            "MODE 8 : (+)ORG ON → Index pulse ON → Stop",
            "MODE 11 : (-)ORG ON → STOP → Vr 이송 → Index pulse ON → Stop",
            "MODE 12 : (-)ORG ON → Index pulse ON → Stop",
            "MODE 17 : (-)EL ON → STOP → Vr 이송 → (-)EL OFF → Stop",
            "MODE 18 : (+)EL ON → STOP → Vr 이송 → (+)EL OFF → Stop",
            "MODE 24 : (+)ORG ON → Stop",
            "MODE 28 : (-)ORG ON → Stop",
        };

        void InitHome()
        {
            cbxHomeMode.DataSource = homeMode_MC02P;
            UpdateHomingInfo();
        }

        void UpdateHomingInfo()
        {
            int iVal = 0;
            float fVal = 0;
            //homeMode
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x06098 + axisID * pdoEntryOffset, 0, 0, 1, ref iVal, ref errorCode);
            var mode = homeMode_MC02P.FirstOrDefault(x => x.Contains(iVal.ToString()));            
            if (mode != null)
            {
                var modeIndex = Array.FindIndex(homeMode_MC02P, x => x.Equals(mode));
                cbxHomeMode.SelectedIndex = modeIndex;
            }
                               
            //homeOffset
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x0607C + axisID * pdoEntryOffset, 0, 0, 4, ref fVal, ref errorCode);
            tbxHomeOffset.Text = fVal.ToString();
            //HomeSpeedMode
            iVal = 0;
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x06086 + axisID * pdoEntryOffset, 0, 0, 2, ref iVal, ref errorCode);
            cbxHomeSpeedMode.SelectedIndex = iVal;
            //homeWorkSpeed
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x06099 + axisID * pdoEntryOffset, 1, 0, 4, ref fVal, ref errorCode);
            tbxHomeWorkSpeed.Text = fVal.ToString();
            //homeSpecSpeed            
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x06099 + axisID * pdoEntryOffset, 2, 0, 4, ref fVal, ref errorCode);
            tbxHomeSpecSpeed.Text = fVal.ToString();            
            //homeAccel / homeDecel
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x0609A + axisID * pdoEntryOffset, 0, 0, 4, ref fVal, ref errorCode);
            tbxHomeAccel.Text = fVal.ToString();
        }

        bool CheckHomingInfo()
        {
            int iVal = 0;
            float fVal = 0;
            if (!int.TryParse(tbxHomeOffset.Text, out iVal))
                return false;
            if (!float.TryParse(tbxHomeWorkSpeed.Text, out fVal))
                return false;
            if (!float.TryParse(tbxHomeSpecSpeed.Text, out fVal))
                return false;
            if (!float.TryParse(tbxHomeAccel.Text, out fVal))
                return false;

            return true;
        }

        private void btnHomeStart_Click(object sender, EventArgs e)
        {
            if (!CheckHomingInfo())
            {
                MessageBox.Show("Check TextBox");
                return;
            }

            SetHomingInfo();
            HomeMoveStart();
        }

        void SetHomingInfo()
        {
            //homeMode
            //var mode = homeMode_MC02P[cbxHomeMode.SelectedIndex];
            var mode = homeMode_MC02P[10].Substring(0,10);
            var output = System.Text.RegularExpressions.Regex.Replace(mode, @"[^\d-]", string.Empty);
            int homeMode = 0;
            if (!int.TryParse(output, out homeMode)) 
            {
                MessageBox.Show("Check HomeMode");
                return;
            }
            
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x06098 + axisID * pdoEntryOffset, 0, 0, 1, ref homeMode, ref errorCode);
            //homeOffset
            float fVal = float.Parse(tbxHomeOffset.Text);
            ec.ecSlv_WriteCoeSdo_Float(netID, slaveAddr, 0x0607C + axisID * pdoEntryOffset, 0, 0, 4, ref fVal, ref errorCode);
            //HomeSpeedMode
            int iVal = cbxHomeSpeedMode.SelectedIndex;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x06086 + axisID * pdoEntryOffset, 0, 0, 2, ref iVal, ref errorCode);
            cbxHomeSpeedMode.SelectedIndex = iVal;
            //homeWorkSpeed
            fVal = float.Parse(tbxHomeWorkSpeed.Text);
            ec.ecSlv_WriteCoeSdo_Float(netID, slaveAddr, 0x06099 + axisID * pdoEntryOffset, 1, 0, 4, ref fVal, ref errorCode);
            //homeSpecSpeed            
            fVal = float.Parse(tbxHomeSpecSpeed.Text);
            ec.ecSlv_WriteCoeSdo_Float(netID, slaveAddr, 0x06099 + axisID * pdoEntryOffset, 2, 0, 4, ref fVal, ref errorCode);
            //homeAccel / homeDecel
            fVal = float.Parse(tbxHomeAccel.Text);
            ec.ecSlv_WriteCoeSdo_Float(netID, slaveAddr, 0x0609A + axisID * pdoEntryOffset, 0, 0, 4, ref fVal, ref errorCode);
        }

        void HomeMoveStart()
        {
            if (inPDO[axisID].Modes_of_Operation_Display != 6)
            {
                // OperationMode를 Homing으로 변경
                outPDO[axisID].Modes_of_Operation = 6;
                WriteOutPDO();
            }

            outPDO[axisID].Control_Word &= ~(1 << 4);
            outPDO[axisID].Control_Word &= ~(1 << 8); //Halt
            WriteOutPDO();

            Thread.Sleep(3);
            outPDO[axisID].Control_Word |= (1 << 4);
            WriteOutPDO();
        }


        private void btnHomeStop_Click(object sender, EventArgs e)
        {
            // 이송 명령의 Stop과 같다.
            Stop();
        }



        // ========================================================
        //                        Setup 
        // ========================================================

        public string[] outputMode = new string[10] {
            "0 : Pulse & Direction 1",
            "1 : Pulse & Direction 2",
            "2 : Pulse & Direction 3",
            "3 : Pulse & Direction 4",
            "4 : CW & CCW 1",
            "5 : CW & CCW 2",
            "6 : CW & CCW 3",
            "7 : CW & CCW 4",
            "8 : A / B Phase 1",
            "9 : A / B Phase 2" };

        public string[] inputMode = new string[5] {
            "0 : 1x A/B Phase",
            "1 : 2x A/B Phase",
            "2 : 4x A/B Phase",
            "3 : CW/CCW",
            "4 : Step Mode" };

        void InitConfig()
        {
            cbxInputMode.DataSource = inputMode;
            cbxOutputMode.DataSource = outputMode;
        }

        void UpdateConfig()
        {
            int iVal = 0;
            float fVal = 0;

            //Alarm Logic
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 1, 0, 1, ref iVal, ref errorCode);
            cbxAlarmLogic.SelectedIndex = iVal;
            //EL Logic
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 2, 0, 1, ref iVal, ref errorCode);
            cbxElLogic.SelectedIndex = iVal;
            //EZ Logic
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 4, 0, 1, ref iVal, ref errorCode);
            cbxEzLogic.SelectedIndex = iVal;
            //ORG Logic
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 3, 0, 1, ref iVal, ref errorCode);
            cbxOrgLogic.SelectedIndex = iVal;
            //outputMode
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 6, 0, 1, ref iVal, ref errorCode);
            cbxOutputMode.SelectedIndex = iVal;
            //inputMode
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 7, 0, 1, ref iVal, ref errorCode);
            cbxInputMode.SelectedIndex = iVal;
            //inputMode - isReverse
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 9, 0, 1, ref iVal, ref errorCode);
            chkInputReverse.Checked = iVal == 1;


            ////unitDistance
            //ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x2001 + axisID * pdoIndexOffset, 1, 0, 4, ref fVal, ref errorCode);
            ////unitSpeed
            //ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x2001 + axisID * pdoIndexOffset, 2, 0, 4, ref fVal, ref errorCode);            
            ////SoftLimit Enable
            //ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 10, 0, 1, ref iVal, ref errorCode);
            ////SoftLimit Value (-)
            //ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x607D + axisID * pdoIndexOffset, 1, 0, 4, ref fVal, ref errorCode);
            ////SoftLimit Value (+)
            //ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x607D + axisID * pdoIndexOffset, 2, 0, 4, ref fVal, ref errorCode);
        }

        void SetupConfig()
        {
            // 가독성을 위해 한번에 처리한다.
            // 코드 적용 시에는 변경되는 값만 Write 한다
            int iVal = 0;

            //Alarm Logic
            iVal = cbxAlarmLogic.SelectedIndex;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 1, 0, 1, ref iVal, ref errorCode);
            //EL Logic
            iVal = cbxElLogic.SelectedIndex;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 2, 0, 1, ref iVal, ref errorCode);
            //EZ Logic
            iVal = cbxEzLogic.SelectedIndex;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 4, 0, 1, ref iVal, ref errorCode);
            //ORG Logic
            iVal = cbxOrgLogic.SelectedIndex;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 3, 0, 1, ref iVal, ref errorCode);
            //outputMode
            iVal = cbxOutputMode.SelectedIndex;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 6, 0, 1, ref iVal, ref errorCode);
            //inputMode
            iVal = cbxInputMode.SelectedIndex;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 7, 0, 1, ref iVal, ref errorCode);
            //inputMode - isReverse
            iVal = chkInputReverse.Checked ? 1 : 0;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x2000 + axisID * pdoIndexOffset, 9, 0, 1, ref iVal, ref errorCode);
        }

        private void Config_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupConfig();
        }

        private void chkInputReverse_CheckedChanged(object sender, EventArgs e)
        {
            SetupConfig();
        }

        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        bool IsDone(int axisID)
        {
            ReadInPDO();
            // 이송이 완료되면 Status word (0x6041) 의 10번 bit (Target reached)가 1로 Set 됨            
            bool isDone = ((inPDO[axisID].Status_Word >> 10) & 1) == 1;
            return isDone;
        }


        // ========================================================
        //                        IxLine 
        // ========================================================

            

        bool CheckIxPossible()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 2; i++)
                outPDO[i].Modes_of_Operation = 1;

            Thread.Sleep(5);
            for (int i = 0; i < 2; i++)
            {
                if (inPDO[i].Modes_of_Operation_Display != 1)
                    return false;
            }
            return true;
        }
        
        bool GetPosition()
        {
            float pos = 0;

            if (float.TryParse(tbxAxis0Pos.Text, out pos))
                outPDO[0].Target_Position = pos;
            else
            {
                // 에러처리
                return false;
            }

            if (float.TryParse(tbxAxis1Pos.Text, out pos))
                outPDO[1].Target_Position = pos;
            else
            {
                // 에러처리
                return false;                
            }            
            
            return true;
        }

        private void btnIxLineStart_Click(object sender, EventArgs e)
        {
            if (!GetPosition())
                return; //에러처리

            if (!IxSetSpeed())
                return; //에러처리

            if (!IsIxMode)
                IsIxMode = true;
            outPDO[0].Control_Word &= ~(1 << 4);
            outPDO[0].Control_Word |= (1 << 6); //Relative Distance
            outPDO[0].Control_Word &= ~(1 << 8);
            WriteOutPDO();
            Thread.Sleep(2);
            
            outPDO[0].Control_Word |= (1 << 4);
            WriteOutPDO();
        }

        private void btnIxLineToStart_Click(object sender, EventArgs e)
        {
            if (!CheckIxPossible())
                return; //에러처리

            if (!GetPosition())
                return; //에러처리

            if (!IxSetSpeed())
                return; //에러처리

            if (!IsIxMode)
                IsIxMode = true;

            int ixMode = 1;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x2100, 0, 0, 2, ref ixMode, ref errorCode);

            outPDO[0].Control_Word &= ~(1 << 4);
            outPDO[0].Control_Word &= ~(1 << 6); //Absolute Distance
            outPDO[0].Control_Word &= ~(1 << 8);
            WriteOutPDO();
            Thread.Sleep(2);

            outPDO[0].Control_Word |= (1 << 4);
            WriteOutPDO();
        }

        int ixSpeedMode = 1;
        float ixWorkSpeed;
        float ixAccel;
        float ixDecel;
        bool isIxMode = false;
        int ixMode = 1;
        public bool IsIxMode
        {
            get
            {
                // 반환값이 1이면 IxMode, 0이면 SxMode
                ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2100, 0, 0, 2, ref ixMode, ref errorCode);
                isIxMode = ixMode == 1;
                return isIxMode;
            }
            set
            {
                if (isIxMode == value)
                    return;

                // 설정값이 1이면 IxMode, 0이면 SxMode
                isIxMode = value;
                ixMode = isIxMode ? 1 : 0;
                ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x2100, 0, 0, 2, ref ixMode, ref errorCode);
            }
        }

        private void btnIxStop_Click(object sender, EventArgs e)
        {            
            Stop();
        }

        private void btnIxStopEmg_Click(object sender, EventArgs e)
        {
            StopEmg();
        }

        void IxGetSpeed()
        {
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, 0x2101, 1, 0, 2, ref ixSpeedMode, ref errorCode);
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x2101, 2, 0, 4, ref ixWorkSpeed, ref errorCode);
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x2101, 3, 0, 4, ref ixAccel, ref errorCode);
            ec.ecSlv_ReadCoeSdo_Float(netID, slaveAddr, 0x2101, 4, 0, 4, ref ixDecel, ref errorCode);

            cbxIxSpeedMode.SelectedIndex = ixSpeedMode;
            tbxIxWorkSpeed.Text = ixWorkSpeed.ToString();
            tbxIxAccel.Text = ixAccel.ToString();
            tbxIxDecel.Text = ixDecel.ToString();
        }

        bool IxSetSpeed()
        {
            ixSpeedMode = cbxIxSpeedMode.SelectedIndex;
            if (!float.TryParse(tbxIxWorkSpeed.Text, out ixWorkSpeed))
                return false; // 에러처리

            if (!float.TryParse(tbxIxAccel.Text, out ixAccel))
                return false; // 에러처리

            if (!float.TryParse(tbxIxDecel.Text, out ixDecel))
                return false; // 에러처리

            
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, 0x2101, 1, 0, 2, ref ixSpeedMode, ref errorCode);
            if (errorCode != 0)
                return false; // 에러처리
            ec.ecSlv_WriteCoeSdo_Float(netID, slaveAddr, 0x2101, 2, 0, 4, ref ixWorkSpeed, ref errorCode);
            if (errorCode != 0)
                return false; // 에러처리
            ec.ecSlv_WriteCoeSdo_Float(netID, slaveAddr, 0x2101, 3, 0, 4, ref ixAccel, ref errorCode);
            if (errorCode != 0)
                return false; // 에러처리
            ec.ecSlv_WriteCoeSdo_Float(netID, slaveAddr, 0x2101, 4, 0, 4, ref ixDecel, ref errorCode);
            if (errorCode != 0)
                return false; // 에러처리

            return true;
        }

        public short SetBit(short data, int bit, bool isSet)
        {
            if (isSet)
                data |= (short)(1 << bit);
            else
                data &= (short)(~(1 << bit));

            return data;
        }
    }
}
