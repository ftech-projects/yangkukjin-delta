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
    public partial class formHoming : Form
    {
        public formHoming()
        {
            InitializeComponent();

            UpdateAxisList();
        }

        int netID = 5;
        int axisID = 0;
        int errorCode = 0;
        byte[] axisList = new byte[32];


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

            UpdateHoming();
            HomeGetSpeed();
        }

        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }



        #region homing

        private void btnHomeStart_Click(object sender, EventArgs e)
        {
            int homeMode = 0;
            double homeOffset = 0;
            int dir = 0;
            int touchProbeEdge = 0;
            if (!int.TryParse(tbxHomeMode.Text, out homeMode))
            {
                homeMode = 114;
                tbxHomeMode.Text = homeMode.ToString();
            }

            dir = cbxHomeDir.SelectedIndex;
            touchProbeEdge = cbxHomeTpEdge.SelectedIndex;
            double.TryParse(tbxOffDis.Text, out homeOffset);

            //Offset을 설정하는 경우 홈복귀 완료 후 Offset만큼 이송하는 것이 아닌, 완료 위치를 Offset을 반영한 값으로 표시한다.
            //예를 들어 Offset = 10000 을 설정하는 경우, 완료 위치가 3000이면, 완료 후 현재위치를 13000으로 표시한다.
            //Offset은 옵션이므로 사용하지 않을 경우 함수를 호출하지 않아도 된다.
            //Offset만큼의 이송을 원하는 경우 ecmHomeCfg_SetOffsetEx 함수를 호출한다

#if true
            ec.ecmHomeCfg_SetOffset(netID, axisID, homeOffset, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

#else

            ec.ecmHomeCfg_SetOffsetEx(netID, axisID, homeOffset, false, 1, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }


#endif

            //이더캣의 홈복귀 명령은 서보 주관 / 마스터 주관 2가지로 구분된다.
            //해당 제품에서 100번 미만의 homeMode는 서보가 주관하는 명령이며, 100번 이상은 마스터가 주관하는 homeMode이다.            
            ec.ecmHomeCfg_SetMode(netID, axisID, homeMode, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

            //홈복귀 속도는 단축 이송 속도와 별개로 취급된다.
            HomeSetSpeed();


            //TouchProbe를 사용하는 Mode는 TouchProbe의 동작엣지를 설정해줘야 한다.
            //HomeMode가 110번 이상이거나, IndexPulse(Z상)을 이용하는 경우는 해당사항 없음.
            //해당 입력 핀이 LogicA 인경우 엣지 값은 (1)Rising 이다.            
            ec.ecmHomeCfg_SetOption(netID, axisID, ec.EEcmHomeOptID.ecmHOID_TPROB_EDGE_SEL, touchProbeEdge, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

            ec.ecmHomeMot_MoveStart(netID, axisID, dir, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }


            //HomeCheck

            Thread thHomeCheck = new Thread(new ThreadStart(() =>
            {
                bool isBusy = true;
                int isSuccess = 0;

                //함수 소개용 코드이므로 간단한 thread로 작성하지만 Task등을 이용해 비동기 처리하는 것이 좋다.
                //System.Threading.Tasks.Task.WaitAll 등

                btnHommingState.Invoke(new Action(() => btnHommingState.Text = "Homing"));
                while (isBusy)
                {
                    Thread.Sleep(200);
                    isBusy = ec.ecmHomeSt_IsBusy(netID, axisID, ref errorCode);
                }

                //isBusy가 false 이면 일단 홈복귀는 종료된 상태이지만, 성공한 경우와 실패한 경우를 구분해야 한다.

                ec.TEcmHomeSt_Flags homeFlag = new ec.TEcmHomeSt_Flags();
                homeFlag.word = ec.ecmHomeSt_GetFlags(netID, axisID, ref errorCode);
                isSuccess = (homeFlag.word >> 2) & 1;

                btnHommingState.Invoke(new Action(() => btnHommingState.Text = isSuccess == 1 ? "Success" : "Failed"));

                //홈복귀가 실패한 경우, 대부분은 현재 축의 상태가 홈복귀 불가능 상태이며, 이는 motState로 확인 가능하다.
                //MotState == 0 인 경우, Stop 명령에 의해 정지한 건 아닌지 확인하자.
                if (isSuccess == 0)
                {
                    int motState = ec.ecmSxSt_GetMotState(netID, axisID, ref errorCode);
                    AddLog(errorCode);
                }
            }));
            thHomeCheck.Start();
        }


        private void btnHomeStop_Click(object sender, EventArgs e)
        {
            ec.ecmSxMot_Stop(netID, axisID, 1, 0, ref errorCode);
        }



        private void UpdateHoming()
        {
            int homeMode = ec.ecmHomeCfg_GetMode(netID, axisID, ref errorCode);
            tbxHomeMode.Text = homeMode.ToString();

            double homeOffset = ec.ecmHomeCfg_GetOffset(netID, axisID, ref errorCode);
            tbxOffDis.Text = homeOffset.ToString();

            int tpEdge = ec.ecmHomeCfg_GetOption(netID, axisID, ec.EEcmHomeOptID.ecmHOID_TPROB_EDGE_SEL, ref errorCode);
            cbxHomeTpEdge.SelectedIndex = tpEdge;

            HomeGetSpeed();

        }


        #endregion


        #region HomeSpeedSetup


        private void HomeSetSpeed()
        {
            int speedMode = 0;
            double workSpeed = 0;
            double accel = 0;
            double decel = 0;
            double specVel = 0;

            speedMode = cbxSpeedMode.SelectedIndex;
            double.TryParse(tbxHomeWorkSpeed.Text, out workSpeed);
            double.TryParse(tbxHomeAccel.Text, out accel);
            double.TryParse(tbxHomeDecel.Text, out decel);
            double.TryParse(tbxHomeSpec.Text, out specVel);

            //SpecVel은 2단계 속도이다.
            //1차 센서감지 후 빠지는 속도 또는 재진입 속도이며, 해당 값이 낮을 수록 센서 위치에서 가깝게 정지한다.
            ec.ecmHomeCfg_SetSpeedPatt(netID, axisID, speedMode, workSpeed, accel, decel, specVel, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }
        }


        private void HomeGetSpeed()
        {
            int speedMode = 0;
            double workSpeed = 0;
            double accel = 0;
            double decel = 0;
            double specVel = 0;

            //현재 축의 속도를 확인한다.
            ec.ecmHomeCfg_GetSpeedPatt(netID, axisID, ref speedMode, ref workSpeed, ref accel, ref decel, ref specVel, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

            //폼에 반영한다.
            cbxSpeedMode.SelectedIndex = speedMode;
            tbxHomeWorkSpeed.Text = workSpeed.ToString();
            tbxHomeAccel.Text = accel.ToString();
            tbxHomeDecel.Text = decel.ToString();
            tbxHomeSpec.Text = specVel.ToString();
        }

        #endregion
    }
}
