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
    public partial class formSxMove : Form
    {
        public formSxMove()
        {
            InitializeComponent();

            UpdateAxisList();
            rdoJog.Checked = true;
        }
        
        int netID = 5;
        int axisID = 0;
        int errorCode = 0;
        byte[] axisList = new byte[32];

        //VMoveStart : Stop 명령 시까지 이송
        //MoveStart : 현재위치에서 정해진 거리만큼 이송
        //MoveToStart : 정해진 위치로 이송

        //Move : 모션 완료시까지 반환되지 않음
        //MoveStart : 함수 실행 후 바로 반환, 완료까지 대기해야 하는 경우 별도 처리해야 한다.

        private void UpdateAxisList()
        {
            cbxAxisList.Items.Clear();
            
            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, (byte)axisList.Length, ref errorCode);
            for (int i = 0; i < axisCount; i++)
                cbxAxisList.Items.Add(string.Format("Axis {0:00}", axisList[i]));

            if (axisCount > 0)
                cbxAxisList.SelectedIndex = 0;                
        }

        private void cbxAxisList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int axisIndex = cbxAxisList.SelectedIndex;
            axisID = axisList[axisIndex];

            GetSpeed();
        }


        public enum MoveMode
        {
            Jog,
            Relative,
            Absolute,
            Velocity
        }
        MoveMode moveMode = MoveMode.Jog;


        private void rdoJog_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = sender as RadioButton;
            if (!rdo.Checked)
                return;

            moveMode = (MoveMode)Enum.Parse(typeof(MoveMode), rdo.Text);

            switch(moveMode)
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

            switch (moveMode)
            {
                case MoveMode.Jog:
                    ec.ecmSxMot_VMoveStart(netID, axisID, 0, ref errorCode);
                    if (errorCode != 0)
                        AddLog(errorCode);

                    break;

                default:
                    break;
            }
        }


        private void btnMoveP_MouseDown(object sender, MouseEventArgs e)
        {
            SetSpeed();

            switch (moveMode)
            {
                case MoveMode.Jog:
                    ec.ecmSxMot_VMoveStart(netID, axisID, 1, ref errorCode);
                    if (errorCode != 0)
                        AddLog(errorCode);

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
                    ec.ecmSxMot_Stop(netID, axisID, 1, 0, ref errorCode);
                    if (errorCode != 0)
                        AddLog(errorCode);

                    break;

                case MoveMode.Relative: // 현재 위치에서 입력된 거리만큼 이송한다.
                    double dist;
                    double.TryParse(tbxDist0.Text, out dist);
                    ec.ecmSxMot_MoveStart(netID, axisID, dist, ref errorCode);
                    if (errorCode != 0)
                        AddLog(errorCode);


                    // 해당 함수는 실행 후 바로 반환된다.
                    // 이송이 끝난 후 다음 이송으로 연계하기 위해서는 끝날때까지 대기하는 것이 좋다.
                    // 예제에서는 함수 소개를 위해 간단한 코드로 작성하였으나
                    // 본 프로그램에는 Task 나 Async/Awit 등을 이용하여 비동기 처리하는 것이 좋다.


#if true

                    // 모션 완료시까지 대기한다.
                    ec.ecmSxSt_WaitCompt(netID, axisID, ref errorCode);

#else
                    //Thread나 Task를 이용한 것과 같다.
                    Thread thIsDone = new Thread(new ThreadStart(() =>
                    {
                        while (ec.ecmSxSt_IsBusy(netID, axisID, ref errorCode) == 1)
                        {
                            Thread.Sleep(100);
                        }
                    }));
                    thIsDone.Start();

#endif
                    break;

                case MoveMode.Absolute: // 입력된 위치로 이송한다.
                    double pos;
                    double.TryParse(tbxDist0.Text, out pos);
                    ec.ecmSxMot_MoveToStart(netID, axisID, pos, ref errorCode);
                    if (errorCode != 0)
                        AddLog(errorCode);

                    Thread thIsAbsDone = new Thread(new ThreadStart(() =>
                    {
                        while (ec.ecmSxSt_IsBusy(netID, axisID, ref errorCode) == 1)
                        {
                            Thread.Sleep(100);
                        }
                    }));
                    thIsAbsDone.Start();

                    break;

                case MoveMode.Velocity: // Stop 명령이 입력될 때까지 이송한다.
                    ec.ecmSxMot_VMoveStart(netID, axisID, 1, ref errorCode);
                    if (errorCode != 0)
                        AddLog(errorCode);

                    break;
            }
        }


        private void btnMoveP_MouseUp(object sender, MouseEventArgs e)
        {
            switch (moveMode)
            {
                case MoveMode.Jog:
                    ec.ecmSxMot_Stop(netID, axisID, 1, 0, ref errorCode);
                    if (errorCode != 0)
                        AddLog(errorCode);

                    break;

                case MoveMode.Relative:
                    double dist;
                    double.TryParse(tbxDist1.Text, out dist);
                    ec.ecmSxMot_MoveStart(netID, axisID, dist, ref errorCode);
                    if (errorCode != 0)
                        AddLog(errorCode);

                    foreach (Control con in tlpMove.Controls)
                        if (!con.Text.Contains("Stop"))
                            con.Enabled = false;

                    Thread thIsDone = new Thread(new ThreadStart(() =>
                    {
                        while (ec.ecmSxSt_IsBusy(netID, axisID, ref errorCode) == 1)
                        {
                            Thread.Sleep(100);
                        }

                        foreach (Control con in tlpMove.Controls)
                            con.Invoke(new Action(() => con.Enabled = true));
                    }));
                    thIsDone.Start();

                    break;

                case MoveMode.Absolute:
                    double pos;
                    double.TryParse(tbxDist1.Text, out pos);
                    ec.ecmSxMot_MoveToStart(netID, axisID, pos, ref errorCode);
                    if (errorCode != 0)
                        AddLog(errorCode);

                    foreach (Control con in tlpMove.Controls)
                        if (!con.Text.Contains("Stop"))
                            con.Enabled = false;
                                        
                    Thread thIsAbsDone = new Thread(new ThreadStart(() =>
                    {
                        while (ec.ecmSxSt_IsBusy(netID, axisID, ref errorCode) == 1)
                        {
                            Thread.Sleep(100);
                        }

                        foreach (Control con in tlpMove.Controls)
                            con.Invoke(new Action(() => con.Enabled = true));
                    }));
                    thIsAbsDone.Start();

                    break;

                case MoveMode.Velocity:
                    ec.ecmSxMot_VMoveStart(netID, axisID, 1, ref errorCode);
                    if (errorCode != 0)
                        AddLog(errorCode);

                    break;
            }
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            //속도 설정에서 입력된 감속도만큼 감속 후 정지한다.
            ec.ecmSxMot_Stop(netID, axisID, 1, 0, ref errorCode);
            if (errorCode != 0)
                AddLog(errorCode);
        }


        private void btnStopEmg_Click(object sender, EventArgs e)
        {
            //감속 없이 급정지한다.
            ec.ecmSxMot_Stop(netID, axisID, 0, 0, ref errorCode);
            if (errorCode != 0)
                AddLog(errorCode);
        }


        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }


        #region SpeedSetup

        private void SetSpeed()
        {
            // 속도는 해당 함수가 적용되기 전에는 이전 값이 적용된다.
            // 즉 명시적으로 속도를 변경하지 않으면 한번 설정한 속도가 계속 유지되므로,
            // 이송시마다 속도 설정을 할 필요는 없다.

            int speedMode = 0;
            double workSpeed = 0;
            double accel = 0;
            double decel = 0;
            double init = 0;
            double end = 0;
            double jerk = 0;
            double ratio = 0;

            speedMode = cbxSpeedMode.SelectedIndex;
            double.TryParse(tbxWorkSpeed.Text, out workSpeed);
            double.TryParse(tbxAccel.Text, out accel);
            double.TryParse(tbxDecel.Text, out decel);
            double.TryParse(tbxInit.Text, out init);
            double.TryParse(tbxEnd.Text, out end);
            double.TryParse(tbxJerk.Text, out jerk);
            ratio = (double)trbRatio.Value / 100;

            //Speed와 Jerk를 설정한다.            
            //한번 설정하면 다시 함수를 호출하기 전에는 해당값이 유지된다.
            //따라서 속도가 변경되지 않는다면, 최초 1회만 함수를 호출하여 속도를 설정하면 된다.
            ec.ecmSxCfg_SetSpeedPatt(netID, axisID, speedMode, init, end, workSpeed, accel, decel, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

            //Jerk는 가감속 구간에서 직선이 아닌 부분의 비율이다. Jerk = 1 이면 완전한 S-Curve. Jerk = 0 이면 사다리꼴의 속도 프로파일이 생성된다.            
            ec.ecmSxCfg_SetJerkRatio(netID, axisID, jerk, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

            //기본값은 1이며, 입력된 속도로 동작하므로, 테스트 용도가 아닌경우 아래 함수는 호출하지 않아도 된다.
            ec.ecmSxCfg_SetSpeedRatio(netID, axisID, ratio, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }
        }


        private void GetSpeed()
        {
            int speedMode = 0;
            double workSpeed = 0;
            double accel = 0;
            double decel = 0;
            double init = 0;
            double end = 0;
            double jerk = 0;
            double ratio = 0;

            //현재 축의 속도를 확인한다.
            ec.ecmSxCfg_GetSpeedPatt(netID, axisID, ref speedMode, ref init, ref end, ref workSpeed, ref accel, ref decel, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

            //현재 축의 Jerk를 확인한다.            
            jerk = ec.ecmSxCfg_GetJerkRatio(netID, axisID, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

            ratio = ec.ecmSxCfg_GetSpeedRatio(netID, axisID, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

            //폼에 반영한다.
            cbxSpeedMode.SelectedIndex = speedMode;
            tbxWorkSpeed.Text = workSpeed.ToString();
            tbxAccel.Text = accel.ToString();
            tbxDecel.Text = decel.ToString();
            tbxInit.Text = init.ToString();
            tbxEnd.Text = end.ToString();
            tbxJerk.Text = jerk.ToString();
            trbRatio.Value = (int)(ratio * 100);
        }

        #endregion

        private void chkSetRpm_CheckedChanged(object sender, EventArgs e)
        {
            bool isEnable = chkSetRpm.Checked;

            // ppr은 모터의 회전당 Pulse 수.
            // 드라이버에 따라 다르므로, 드라이버의 설정값을 반드시 확인 후 적용
            // 예제에서는 360,000 으로 가정한다.
           
            double ppr = 0;
            if (!double.TryParse(tbxPPR.Text, out ppr))
                ppr = 360000;

            ec.ecmSxCfg_SetRpmMode(netID, axisID, isEnable, ppr, ref errorCode);
        }
    }
}
