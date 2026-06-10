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
    public partial class formIxArc : Form
    {
        public formIxArc()
        {
            InitializeComponent();

            UpdateAxisList();
        }

        int netID = 5;
        int axisX = 0;
        int axisY = 0;
        int errorCode = 0;
        byte[] axisList = new byte[32];
        int ixMapIndex = 0;

        public enum ArcMode
        {
            ARCMODE_CENTERPOINT_ANGLE = 0,
            ARCMODE_CENTERPOINT_ENDPOINT = 1,
            ARCMODE_3POINT = 2,
        }

        ArcMode arcMode = 0;

        private void rdoArcMode_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = sender as RadioButton;
            if (!rdo.Checked)
                return;

            arcMode = (ArcMode)rdo.Tag;

            switch (arcMode)
            {
                case ArcMode.ARCMODE_CENTERPOINT_ANGLE:
                    lblP0_X.Text = "Center Point X";
                    lblP0_Y.Text = "Center Point Y";
                    lblP1_X.Visible = false;
                    lblP1_Y.Visible = false;
                    tbxP1_X.Visible = false;
                    tbxP1_Y.Visible = false;
                    lblAngle.Visible = true;
                    tbxAngle.Visible = true;
                    lblDir.Visible = false;
                    cbxDir.Visible = false;
                    break;

                case ArcMode.ARCMODE_CENTERPOINT_ENDPOINT:
                    tbxP0_X.Text = "Center Point X";
                    tbxP0_Y.Text = "Center Point Y";
                    lblP1_X.Visible = true;
                    lblP1_Y.Visible = true;
                    tbxP1_X.Visible = true;
                    tbxP1_Y.Visible = true;
                    lblAngle.Visible = false;
                    tbxAngle.Visible = false;
                    lblDir.Visible = true;
                    cbxDir.Visible = true;
                    break;

                    case ArcMode.ARCMODE_3POINT:
                    tbxP0_X.Text = "Point2 X";
                    tbxP0_Y.Text = "Point2 Y";
                    lblP1_X.Visible = true;
                    lblP1_Y.Visible = true;
                    tbxP1_X.Visible = true;
                    tbxP1_Y.Visible = true;
                    tbxP1_X.Text = "Point3 X";
                    tbxP1_Y.Text = "Point3 Y";
                    lblAngle.Visible = true;
                    tbxAngle.Visible = true;
                    lblDir.Visible = false;
                    cbxDir.Visible = false;
                    break;            
            }
        }


        private void UpdateAxisList()
        {
            cbxAxisX.Items.Clear();
            cbxAxisY.Items.Clear();

            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, (byte)axisList.Length, ref errorCode);
            for (int i = 0; i < axisCount; i++)
            {
                cbxAxisX.Items.Add(string.Format("{0:00}", axisList[i]));
                cbxAxisY.Items.Add(string.Format("{0:00}", axisList[i]));
            }


            if (axisCount > 1)
            {
                cbxAxisX.SelectedIndex = 0;
                cbxAxisY.SelectedIndex = 1;
            }
                
            cbxSpeedType.SelectedIndex = 1;
            cbxSpeedMode.SelectedIndex = 2;

            rdoArcMode0.Checked = true;
        }
        

        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }


        List<int> ixAxisList = new List<int>();        
        List<double> ixDistList = new List<double>();
            

        private void btnMoveStart_Click(object sender, EventArgs e)
        {
            axisX = axisList[cbxAxisX.SelectedIndex];
            axisY = axisList[cbxAxisY.SelectedIndex];

            if(axisX == axisY)
            {
                MessageBox.Show("Select two axis");
                return;
            }

            //보간에 포함되는 축 리스트를 설정한다.            
            ixAxisList.Clear();
            ixAxisList.Add(axisX);
            ixAxisList.Add(axisY);
            
            ec.ecmIxCfg_MapAxes(netID, ixMapIndex, ixAxisList.Count, ixAxisList.ToArray(), ref errorCode);

            //보간 속도를 설정한다.
            IxSetSpeed(ixMapIndex);


            // 각 축이 현재 위치에서 정해진 거리만큼 이송한다
            // 모든 축의 시작시점과 종료시점이 동기화 되어, 동시에 출발하고, 동시에 완료된다.
            // 각 축의 속도는 SpeedType에 따라 자동 조정된다.
            // 자세한 내용은 ecmIxCfg_SetSpeedPatt 함수 참조

            double p0_X = 0, p0_Y = 0, p1_X = 0, p1_Y = 0, angle = 0;

            double.TryParse(tbxP0_X.Text, out p0_X);
            double.TryParse(tbxP0_Y.Text, out p0_Y);
            double.TryParse(tbxP1_X.Text, out p1_X);
            double.TryParse(tbxP1_Y.Text, out p1_Y);
            double.TryParse(tbxAngle.Text, out angle);
            int dir = cbxDir.SelectedIndex;


            switch (arcMode)
            {                    
                case ArcMode.ARCMODE_CENTERPOINT_ANGLE:                    
                    // 현재 위치에서 중점(CenterPoint)까지의 거리(offset)를 반지름 삼아 angle만큼 회전
                    ec.ecmIxMot_ArcAng_R_Start(netID, ixMapIndex, p0_X, p0_Y, angle, ref errorCode);
                    break;

                case ArcMode.ARCMODE_CENTERPOINT_ENDPOINT:
                    // 현재 위치에서 중점(CenterPoint)까지의 거리(offset)를 반지름 삼아 종점(EndPoint offset)까지 회전                    
                    ec.ecmIxMot_ArcPos_R_Start(netID, ixMapIndex, p0_X, p0_Y, p1_X, p1_Y, dir, ref errorCode);
                    break;

                case ArcMode.ARCMODE_3POINT:
                    // 현재위치와 두 점의 상대 위치(거리)를 이용하여 angle만큼 회전
                    ec.ecmIxMot_Arc3P_R_Start(netID, ixMapIndex, p0_X, p0_Y, p1_X, p1_Y, angle, ref errorCode);
                    break;
            }

            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }

            ec.ecmIxSt_WaitCompt(netID, ixMapIndex, ref errorCode);
            //WaitCompt 명령 실행 시 이송에 포함된 모든 축이 정지할 때까지 기다린다.
        }

        
        private void btnMoveToStart_Click(object sender, EventArgs e)
        {
            axisX = axisList[cbxAxisX.SelectedIndex];
            axisY = axisList[cbxAxisY.SelectedIndex];

            if (axisX == axisY)
            {
                MessageBox.Show("Select two axis");
                return;
            }

            //보간에 포함되는 축 리스트를 설정한다.            
            ixAxisList.Clear();
            ixAxisList.Add(axisX);
            ixAxisList.Add(axisY);
                        
            ec.ecmIxCfg_MapAxes(netID, ixMapIndex, ixAxisList.Count, ixAxisList.ToArray(), ref errorCode);

            //보간 속도를 설정한다.
            IxSetSpeed(ixMapIndex);


            // 각 축이 현재 위치에서 정해진 위치로 이송한다
            // 모든 축의 시작시점과 종료시점이 동기화 되어, 동시에 출발하고, 동시에 완료된다.
            // 각 축의 속도는 SpeedType에 따라 자동 조정된다.
            // 자세한 내용은 ecmIxCfg_SetSpeedPatt 함수 참조

            double p0_X = 0, p0_Y = 0, p1_X = 0, p1_Y = 0, angle = 0;

            double.TryParse(tbxP0_X.Text, out p0_X);
            double.TryParse(tbxP0_Y.Text, out p0_Y);
            double.TryParse(tbxP1_X.Text, out p1_X);
            double.TryParse(tbxP1_Y.Text, out p1_Y);
            double.TryParse(tbxAngle.Text, out angle);
            int dir = cbxDir.SelectedIndex;


            switch (arcMode)
            {
                case ArcMode.ARCMODE_CENTERPOINT_ANGLE:
                    // 현재 위치에서 중점(CenterPoint)의 위치를 반지름 삼아 angle만큼 회전
                    ec.ecmIxMot_ArcAng_A_Start(netID, ixMapIndex, p0_X, p0_Y, angle, ref errorCode);
                    break;

                case ArcMode.ARCMODE_CENTERPOINT_ENDPOINT:
                    // 현재 위치에서 중점(CenterPoint)의 위치를 반지름 삼아 종점(EndPoint offset) 위치까지 회전                    
                    ec.ecmIxMot_ArcPos_A_Start(netID, ixMapIndex, p0_X, p0_Y, p1_X, p1_Y, dir, ref errorCode);
                    break;

                case ArcMode.ARCMODE_3POINT:
                    // 현재위치와 두 점의 위치를 이용하여 angle만큼 회전
                    ec.ecmIxMot_Arc3P_A_Start(netID, ixMapIndex, p0_X, p0_Y, p1_X, p1_Y, angle, ref errorCode);
                    break;
            }

            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }

            // Thread를 이용한 처리
            Thread thIsAbsDone = new Thread(new ThreadStart(() =>
            {
                while (ec.ecmMxSt_IsBusy(netID, ixAxisList.Count, ixAxisList.ToArray(), ref errorCode))
                {
                    Thread.Sleep(100);
                }
            }));
            thIsAbsDone.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ec.ecmIxMot_Stop(netID, ixMapIndex, 1, 1, ref errorCode);
            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }
        }

        private void IxSetSpeed(int ixMapIndex)
        {
            // 속도는 해당 함수가 적용되기 전에는 이전 값이 적용된다.
            // 즉 명시적으로 속도를 변경하지 않으면 한번 설정한 속도가 계속 유지되므로,
            // 이송시마다 속도 설정을 할 필요는 없다.

            int speedType = cbxSpeedType.SelectedIndex;
            int speedMode = cbxSpeedMode.SelectedIndex;
            double init = 0, end = 0, work = 0, accel = 0, decel = 0, jerk = 0;

            double.TryParse(tbxInit.Text, out init);
            double.TryParse(tbxEnd.Text, out end);
            double.TryParse(tbxWork.Text, out work);
            double.TryParse(tbxAccel.Text, out accel);
            double.TryParse(tbxDecel.Text, out decel);
            double.TryParse(tbxJerk.Text, out jerk);

            ec.ecmIxCfg_SetSpeedPatt(netID, ixMapIndex, speedType, speedMode, init, end, work, accel, decel, ref errorCode);
            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }

            // Jerk 미설정 시 0.66이 기본으로 설정된다.            
            ec.ecmIxCfg_SetJerkRatio(netID, ixMapIndex, jerk, ref errorCode);
            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }
        }
    }
}
