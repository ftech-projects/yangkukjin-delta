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
    public partial class formIxVia : Form
    {
        // 경유 이송에 대한 예제
        // 속도의 연속성을 유지하면서 현재 위치로부터 어느 한점을 경유하여 목표 위치로 보간 이송
        // 원호보간 이송이 자동으로 삽입, 
        // 커맨드 기준으로 지정된 경유점을 반드시 지나감


        public formIxVia()
        {
            InitializeComponent();
            UpdateAxisList();
        }

    #region base

        int netID = 5;
        int errorCode = 0;
        byte[] axisList = new byte[32];

        private void UpdateAxisList()
        {
            cbxAxisX.Items.Clear();

            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, (byte)axisList.Length, ref errorCode);
            if (errorCode != 0) //Error 처리
                AddLog(errorCode);

            for (int i = 0; i < axisCount; i++)
            {
                cbxAxisX.Items.Add(string.Format("{0:00}", axisList[i]));
                cbxAxisY.Items.Add(string.Format("{0:00}", axisList[i]));
            }
                
            if (axisCount > 0)
                cbxAxisX.SelectedIndex = 0;

            if (axisCount > 1)
                cbxAxisY.SelectedIndex = 1;

            cbxRoundType.SelectedIndex = 0;
        }

        private void cbxAxisList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

    #endregion

        int axisX = 0;
        int axisY = 0;
        int ixMapIndex = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            // 시작점
            double[] p1 = new double[2] { 0, 0 };

            // 경유점 좌표 포인트 [x, y]
            double[] p2 = new double[2];

            // 경유점 좌표 포인트 [x, y]
            double[] p3 = new double[2];

            // 자동으로 삽입되는 라운드의 크기 (원호의 반지름)            
            double normalRadius = 0;

            // P1이 자동삽입되는 원의 외부에 있을때는 NormalRadius 가 적용되지만, 
            // 원의 내부에 있을 때는 P1의 위치에 따라서 원의 크기가 자동 조정됨
            // 이때 조정할 수 있는 원의 최소 크기(반지름)
            double minRadius = 0;

            // 삽입되는 라운드와 경유점과의 위치 관계를 나타내는 변수
            // 0 (Start) : 경유점이 자동 삽입되는 원의 시작점
            // 1 (End) : 경유점이 자동 삽입되는 원의 종점
            int roundType = cbxRoundType.SelectedIndex;

            // 좌표데이터가 상대좌표인지 절대좌표인지 나타내는 플래그
            bool isAbsPos = chkIsAbsPos.Checked;                        
            
            double.TryParse(tbxP2_X.Text, out p2[0]);
            double.TryParse(tbxP2_Y.Text, out p2[1]);
            double.TryParse(tbxP3_X.Text, out p3[0]);
            double.TryParse(tbxP3_Y.Text, out p3[1]);

            double.TryParse(tbxNormalRadius.Text, out normalRadius);
            double.TryParse(tbxMinRadius.Text, out minRadius);
                       

            axisX = axisList[cbxAxisX.SelectedIndex];
            axisY = axisList[cbxAxisX.SelectedIndex];

            // 보간 축 설정
            ec.ecmIxCfg_MapAxes(netID, ixMapIndex, 2, new int[2] { axisX, axisY }, ref errorCode);
            if (errorCode != 0)// 에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 보간 속도 설정
            int speedType = 1; //VectorSpeed;
            int speedMode = (int)ec.EEcmSpeedMode.ecmSMODE_TRAPE;
            ec.ecmIxCfg_SetSpeedPatt(0, ixMapIndex, speedType, speedMode, 0, 0, 500000, 2500000, 2500000, ref errorCode);
            if (errorCode != 0)// 에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 시작점으로 이송
            ec.ecmIxMot_LineTo(netID, ixMapIndex, p1, ref errorCode);
            if (errorCode != 0)// 에러처리
            {
                AddLog(errorCode);
                return;
            }

            ec.ecmIxMot_MoveVia2X_Start(netID, (ushort)ixMapIndex, p2, p3, isAbsPos, roundType, normalRadius, minRadius, ref errorCode);
            if (errorCode != 0)// 에러처리
            {
                AddLog(errorCode);
                return;
            }

            ec.ecmIxSt_WaitCompt(netID, ixMapIndex, ref errorCode);
            if (errorCode != 0)// 에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            int isDecelStop = 1;
            int isWaitCompt = 1;
            ec.ecmIxMot_Stop(netID, ixMapIndex, isDecelStop, isWaitCompt, ref errorCode);
            if (errorCode != 0)// 에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnOverride_Click(object sender, EventArgs e)
        {
            // 목표좌표를 수정
            // 속도의 연속성을 위해 좌표 변경 시 원호 자동 삽입

            // 오버라이드할 새로운 목표좌표
            double[] newP3 = new double[2];

            // 자동으로 삽입되는 원호의 반지름
            // normalRadius, minRadius 와 별개
            double newRadius = 0;

            // 오버라이드가 무시되었는지에 대한 플래그
            bool isIgnored = false;

            double.TryParse(tbxNewPosX.Text, out newP3[0]);
            double.TryParse(tbxNewPosY.Text, out newP3[1]);
            double.TryParse(tbxNewRadius.Text, out newRadius);

            ec.ecmIxMot_MoveVia2X_OverrideTP(netID, (ushort)ixMapIndex, newP3, newRadius, ref isIgnored, ref errorCode);
            if (errorCode != 0)// 에러처리
            {
                AddLog(errorCode);
                return;
            }

            if (isIgnored)
            {
                // 에러처리
                return;
            }
        }
    }
}
