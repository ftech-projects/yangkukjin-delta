using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using ec = ComiLib.EtherCAT.SafeNativeMethods;

namespace EtherCAT_Examples_CSharp
{
    public partial class formCmpOne : Form
    {
        public formCmpOne()
        {
            InitializeComponent();

            // DeviceLoad 전이면 DeviceLoad를 먼저 실행한다.
            int devIndex = 0;
            if (!ec.ecGn_IsDevLoaded(devIndex, ref errorCode))
                if (!ec.ecGn_LoadDevice(ref errorCode))
                    AddLog(string.Format("DeviceLoad Failed : {0}", errorCode));
            
            UpdateAxisList();

        }

        int netID = 5;
        int axisID = 0;
        int errorCode = 0;
        byte[] axisList = new byte[32];


        private void UpdateAxisList()
        {
            cbxAxisList.Items.Clear();

            // 축 리스트를 확인한다.
            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, (byte)axisList.Length, ref errorCode);
            for (int i = 0; i < axisCount; i++)
                cbxAxisList.Items.Add(string.Format("Axis {0:00}", axisList[i]));

            if (axisCount > 0)
                cbxAxisList.SelectedIndex = 0;

            // DO 전역채널 수를 확인한다.
            int doChCount = ec.ecdoGetNumChannels(netID, ref errorCode);
            for (int i = 0; i < doChCount; i++)
                cbxOut_Global.Items.Add(string.Format("Ch {0:00}", i));

            cbxOut_OnBoard.SelectedIndex = 0;

            if (doChCount > 0)
            {
                cbxOut_Global.SelectedIndex = 0;
            }
            else
            {
                rdoOut_Global.Enabled = false;
                cbxOut_Global.Enabled = false;
            }
        }

        private void cbxAxisList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int axisIndex = cbxAxisList.SelectedIndex;
            axisID = axisList[axisIndex];
                        
            UpdateCmp();
        }

        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

        void AddLog(string errorString)
        {
            MessageBox.Show(errorString);
        }


        #region CMP_UI

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double pos = 0;
            if (double.TryParse(tbxPosition.Text, out pos))
                lbxPosition.Items.Add(pos.ToString());

            tbxPosition.Text = string.Empty;
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbxPosition.Items.RemoveAt(lbxPosition.SelectedIndex);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxPosition.Items.Clear();
        }


        private void btnAddList_Click(object sender, EventArgs e)
        {
            lbxPosition.Items.Clear();

            for (int i = 1; i < 10; i++)
                lbxPosition.Items.Add((i * 10000).ToString());
        }

        private void rdoOut_OnBoard_CheckedChanged(object sender, EventArgs e)
        {
            cbxOut_OnBoard.Enabled = true;
            cbxOut_Global.Enabled = false;
        }


        private void rdoOut_Global_CheckedChanged(object sender, EventArgs e)
        {
            cbxOut_OnBoard.Enabled = false;
            cbxOut_Global.Enabled = true;
        }

        
        #endregion


        #region CMP_One

        uint logBitAddr = 0; // 출력 채널에 대한 LogicBitAddress
        int method = 0; // CMP 출력 조건
        int cntrType = 0; // CMP 위치 조건. Command / Feedback
        int logic = 0; // CMP 출력 로직. 
        int duration = 10; // CMP 출력 유지 시간. 단위 ms. 
        
        double cmpPosition = 0;
        static ec.CallbackFunc callBackFunc;

        //CMP의 포지션은 두가지 방식으로 등록 가능하다.
        //ecmSxCmpOne_ 으로 시작하는 함수군은 Position 한개씩 등록해서 사용한다.

        private void btnCmpOneStart_Click(object sender, EventArgs e)
        {
            if (lbxPosition.Items.Count == 0)
                return;

            //예제용 UI 처리코드. 
            foreach (Control con in tlpCMP.Controls)
                if (con.Tag == null)
                    con.Enabled = false;

            // 출력 환경을 설정한다.
            SetCondition();

            // CMP 출력조건을 설정한다.
            cmpPosition = Convert.ToDouble(lbxPosition.Items[0]);
            method = cbxMethod.SelectedIndex; // CMP 출력 조건
            cntrType = cbxCntrType.SelectedIndex; // CMP 위치 조건. Command / Feedback
                        
            ec.ecmSxCmpOne_SetCondition(netID, axisID, cntrType, method, cmpPosition, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(string.Format("ecmSxCmpOne_SetCondition failed. errorCode : {0}", errorCode));
                return;
            }

            
            //이하 코드는 CMP Notify 관련 기능이다. 해당 기능을 사용하지 않는다면 생략.
            //CMP Notify : 출력 결과를 소프트웨어적으로 통지받고자 할때 사용하며, 단일 출력(ecmSxCmpOne_ )일때만 사용 가능하다.
            //본 예제에서는 message 방식과 CallBack 방식을 다룬다.
            switch (cbxTypeSel.SelectedIndex)
            {
                case 0:
                    if (!ec.ecmSxCmpOne_SetHandler_MSG(netID, axisID, (int)ec.EEcmHandlerType.ecmHT_MESSAGE, this.Handle, WMU_CMPMESSAGE, this.Handle, ref errorCode)) // CMP Message 등록
                    {
                        AddLog(string.Format("ecmSxCmpOne_SetHandler_MSG failed. errorCode : {0}", errorCode));
                        return;
                    }
                    break;

                case 1:
                    callBackFunc = new ec.CallbackFunc(CallBackFunc);
                    if (!ec.ecmSxCmpOne_SetHandler_CLB(netID, axisID, (int)ec.EEcmHandlerType.ecmHT_CALLBACK, callBackFunc, 0, this.Handle, ref errorCode)) // CMP Message 등록
                    {
                        AddLog(string.Format("ecmSxCmpOne_SetHandler_CLB failed. errorCode : {0}", errorCode));
                        return;
                    }
                    break;
            }

            //CMP 시작
            bool isEnable = true;
            if (!ec.ecmSxCmpOne_SetEnable(netID, axisID, isEnable, ref errorCode)) // CMP Enable
            {
                AddLog(string.Format("ecmSxCmpOne_SetEnable failed. errorCode : {0}", errorCode));
            }
        }

        private void SetCondition() 
        {
            // CMP 출력 채널을 확인하여 LogicBitAddress로 변환
            // Local 채널도 사용 가능하지만, 본 예제에서는 다루지 않는다.
            if (rdoOut_Global.Checked) // 범용 Output 채널 사용 시
            {
                int ch = cbxOut_Global.SelectedIndex;
                logBitAddr = ec.ecdoLogBitAddr_FromGlobalChannel(netID, ch, ref errorCode);
                if (errorCode != 0) // 에러처리
                {
                    AddLog(string.Format("ecdoLogBitAddr_FromGlobalChannel failed. errorCode : {0}", errorCode));
                    return;
                }
            }
            else // OnBoard(마스터 보드) DO 사용 시
            {
                int ch = cbxOut_OnBoard.SelectedIndex;
                logBitAddr = ec.ecdoLogBitAddr_FromOnboardChannel(netID, ch, ref errorCode);
                if (errorCode != 0) // 에러처리
                {
                    AddLog(string.Format("ecdoLogBitAddr_FromOnboardChannel failed. errorCode : {0}", errorCode));
                    return;
                }
            }

            // 이전 출력 결과를 초기화한다.
            ec.ecmSxCmpOne_ClearOutResult(netID, axisID, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(string.Format("ecmSxCmpOne_SetCondition failed. errorCode : {0}", errorCode));
                return;
            }

            cmpCount = 0;
            logic = cbxLogic.SelectedIndex; // CMP 출력 로직. 
            duration = Convert.ToInt32(tbxDuration.Text); // CMP 출력 유지 시간. 단위 ms.             

            // CMP 출력채널 정보를 설정한다.            
            ec.ecmSxCmpOne_SetChannel(netID, axisID, logBitAddr, logic, duration, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(string.Format("ecmSxCmpOne_SetChannel failed. errorCode : {0}", errorCode));
                return;
            }           
        }


        private void btnCmpOneStop_Click(object sender, EventArgs e)
        {
            foreach (Control con in tlpCMP.Controls)
                con.Enabled = true;

            //CMP Notify 관련 설정이 되어 있다면 해당 설정을 먼저 해제한다.
            switch (cbxTypeSel.SelectedIndex)
            {
                case 0:
                    if (!ec.ecmSxCmpOne_SetHandler_MSG(netID, axisID, (int)ec.EEcmHandlerType.ecmHT_DISABLE, this.Handle, WMU_CMPMESSAGE, this.Handle, ref errorCode))
                    {
                        AddLog(string.Format("ecmSxCmpOne_SetHandler_MSG failed. errorCode : {0}", errorCode));
                        return;
                    }

                    break;

                case 1:
                    if (!ec.ecmSxCmpOne_SetHandler_CLB(netID, axisID, (int)ec.EEcmHandlerType.ecmHT_DISABLE, callBackFunc, 0, this.Handle, ref errorCode))
                    {
                        AddLog(string.Format("ecmSxCmpOne_SetHandler_CLB failed. errorCode : {0}", errorCode));
                        return;
                    }
                    break;
            }

            // CMP 기능 비활성화
            bool isEnable = false;
            if (!ec.ecmSxCmpOne_SetEnable(netID, axisID, isEnable, ref errorCode))
            {
                AddLog(string.Format("ecmSxCmpOne_SetEnable failed. errorCode : {0}", errorCode));
                return;
            }
        }


        private void btnCmpMove_Click(object sender, EventArgs e)
        {
            double dist = 0;
            double.TryParse(tbxCmpDist.Text, out dist);
            ec.ecmSxMot_MoveStart(netID, axisID, dist, ref errorCode);
        }


        private void UpdateCmp()
        {
            // 마지막 입력된 값에 대한 설정값을 불러온다.
            // CmpOne 과 CmpCont 는 다른 함수를 사용한다
            
            // 채널 관련 정보를 확인한다.
            
            ec.ecmSxCmpOne_GetChannel(netID, axisID, ref logBitAddr, ref logic, ref duration, ref errorCode);
            
            // UI 처리            
            if (rdoOut_Global.Checked) // Global Ch 사용 시
            {
                // LogicBitAddress 를 Global Channel 로 변경한다.
                int ch = ec.ecdiLogBitAddr_ToGlobalChannel(netID, logBitAddr, ref errorCode);
                cbxOut_Global.SelectedIndex = ch;
            }
            else // OnBoard DO 사용 시
            {
                int ch = ec.ecdiLogBitAddr_ToOnboardChannel(netID, logBitAddr, ref errorCode);
                cbxOut_OnBoard.SelectedIndex = ch;
            }

            cbxLogic.SelectedIndex = logic;

            // 출력 조건을 확인한다.
            ec.ecmSxCmpOne_GetCondition(netID, axisID, ref cntrType, ref method, ref cmpPosition, ref errorCode);
            
            // UI 처리
            cbxCntrType.SelectedIndex = cntrType;
            cbxMethod.SelectedIndex = method;
            tbxDuration.Text = duration.ToString();
                        
            cbxTypeSel.SelectedIndex = 2;

        }


        

        private void t_CmpOne_Tick(object sender, EventArgs e)
        {
            GetOutResult();

            // CMP 활성화 여부를 확인한다.
            bool isEnable = ec.ecmSxCmpOne_GetEnable(netID, axisID, ref errorCode);
            btnCmpOneStart.BackColor = isEnable ? Color.DarkOrange : Color.Transparent;
        }

        private void GetOutResult()
        {
            // CMP 출력 결과를 확인한다.

            int outCount = 0;
            double outPos = 0;
            ec.ecmSxCmpOne_GetOutResult(netID, axisID, ref outCount, ref outPos, ref errorCode);

            lblOutCount.Text = outCount.ToString();
            lblOutPosition.Text = outPos.ToString();

            // 출력 채널의 출력상태를 확인한다.
            bool isOn = ec.ecmSxCmpOne_GetOutputState(netID, axisID, ref errorCode);
            lblOutState.BackColor = isOn ? Color.DarkOrange : Color.Transparent;
        }

        #endregion


        #region CmpNotify


        internal const int WM_APP = 0x8000;
        internal const int WMU_CMPMESSAGE = WM_APP + 1;
        

        void CallBackFunc(IntPtr lParam)
        {
            //////////////////////////////////////////////////////////////////////////////////////////
            // 주의: 쓰레드내에서 GUI 관련작업을 수행하면 에러를 발생시키는 것과 마찬가지로 CALLBACK
            // 함수내에서 GUI 관련작업을 수행하면 예기치않은 에러를 발생시킬 수 있으므로, 가급적 
            // GUI 관련작업은 피하는 것이 좋다. 단, GUI의 속성을 참조하는 것은 상관없다.
            CmpMessageHandler(lParam);
        }



        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WMU_CMPMESSAGE:
                    CmpMessageHandler(this.Handle);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        
        int cmpCount = 0; //Callback 등을 위한 변수. 본 기능과 무관
        private void CmpMessageHandler(IntPtr lParam)
        {
            AddLog(string.Format("CMP Triggered. FeedbackPosition : {0}", ec.ecmSxSt_GetPosition(netID, axisID, 1, ref errorCode)));

            cmpCount++;

            int limit = 0;

            if (lbxPosition.InvokeRequired)
                lbxPosition.Invoke(new Action(() => limit = lbxPosition.Items.Count));
            else
                limit = lbxPosition.Items.Count;

            if (cmpCount >= limit)
                return;

            double nextPosition = 0;

            if (lbxPosition.InvokeRequired)
                lbxPosition.Invoke(new Action(() => nextPosition = Convert.ToDouble(lbxPosition.Items[cmpCount])));
            else
                nextPosition = Convert.ToDouble(lbxPosition.Items[cmpCount]);

            // ec.ecmSxCmpOne_SetChannel(netID, axisID, logBitAddr, logic, duration, ref errorCode);

            // CMP 출력조건을 설정한다.
            ec.ecmSxCmpOne_SetCondition(netID, axisID, cntrType, method, nextPosition, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(string.Format("ecmSxCmpOne_SetCondition failed. errorCode : {0}", errorCode));
                return;
            }
            ec.ecmSxCmpOne_SetEnable(netID, axisID, true, ref errorCode);            
        }

        #endregion

        
        private void btnManualTrg_Click(object sender, EventArgs e)
        {
            SetCondition();

            // 트리거 신호를 수동 출력한다. (OutSigLogic, OutSignalOnTime 반영)
            // OnBoard 채널에만 적용된다.
            // GetOutResult() 의 함수의 경우, DO 출력을 Enable 시킨다.

            ec.ecmSxCmpOne_ManualTrgOut(netID, axisID, ref errorCode);
            GetOutResult();
        }

        private void btnStateToggle_Click(object sender, EventArgs e)
        {
            // CMP Output 채널의 출력 상태를 확인한다.
            // OnBoard 채널에만 적용된다.
            bool isOn = ec.ecmSxCmpOne_GetOutputState(netID, axisID, ref errorCode);
            
            // CMP Output 채널의 출력 상태를 설정한다.
            // ecmSxCmpOne_SetOutputState() 함수는 CMP가 비활성화 된 상태에서만 설정 가능하다.
            // OutSigLogic, OutSignalOnTime 등이 설정되지 않아도 된다는 점에서 ecmSxCmpOne_ManualTrgOut() 함수와 차이가 있다.
            isOn = !isOn;
            ec.ecmSxCmpOne_SetOutputState(netID, axisID, isOn, ref errorCode);

        }
    }
}
