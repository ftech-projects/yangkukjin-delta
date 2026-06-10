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
    // Hardware 방식의 비상정지 예제
    // 다수의 OnBoard 또는 범용 DI 채널을 비상정지 입력으로 할당할 수 있다.
    // 본 예제는 3개의 범용 DI 채널을 비상정지 입력으로 할당하는 예제이다.
    // 할당 된 채널 중 1개의 채널이라도 입력이 되면 비상정지 된다.

    public partial class formHEmg : Form
    {        
        public formHEmg()
        {
            InitializeComponent();

            UpdateForm();
        }

    #region base

        int netID = 5;
        int errorCode = 0;
        int inputCount = 3;

        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

        private void UpdateForm()
        {
            // DI Channel 확인. 본 기능과 무관
            int chCount = ec.ecdiGetNumChannels(netID, ref errorCode);
            for (int i = 0; i < chCount; i++)
            {
                cbxCh0.Items.Add(string.Format("Ch {0:00}", i));
                cbxCh1.Items.Add(string.Format("Ch {0:00}", i));
                cbxCh2.Items.Add(string.Format("Ch {0:00}", i));
            }
            if (chCount > 2)
            {
                cbxCh0.SelectedIndex = 0;
                cbxCh1.SelectedIndex = 1;
                cbxCh2.SelectedIndex = 2;
            }            

            // 감속 정지 여부 확인
            bool isDecelStop = ec.ecmHEMG_GetStopMode(netID, ref errorCode);
            chkIsDecelStop.Checked = isDecelStop;
        }

    #endregion

        private void btnEnable_Click(object sender, EventArgs e)
        {   
            // 첫번째 DI 채널을 확인하여 논리비트주소로 변환한다.
            // ecdiLogBitAddr_FromGlobalChannel() 함수는 Global Channel을 논리비트주소로 변환한다
            // Local 채널로 입력시에는 ecdiLogBitAddr_FromLocalChannel() 함수를 사용한다.

            int ch0 = cbxCh0.SelectedIndex;
            uint logicBitAddr0 = ec.ecdiLogBitAddr_FromGlobalChannel(netID, ch0, ref errorCode);

            // 두번째 DI 채널을 확인하여 논리비트주소로 변환한다.
            int ch1 = cbxCh0.SelectedIndex;
            uint logicBitAddr1 = ec.ecdiLogBitAddr_FromGlobalChannel(netID, ch1, ref errorCode);

            // 세번째 DI 채널을 확인하여 논리비트주소로 변환한다.
            int ch2 = cbxCh0.SelectedIndex;
            uint logicBitAddr2 = ec.ecdiLogBitAddr_FromGlobalChannel(netID, ch2, ref errorCode);

            // isInvertLogic : Input 신호 로직의 반전 여부
            // false : Low Active / true : High Active
            bool isInvertLogic = chkIsInvertLogic.Checked;
                        
            ec.TEcmEmgInputEnv[] emgEnv = new ec.TEcmEmgInputEnv[inputCount];
            emgEnv[0].InvertLogic = isInvertLogic;
            emgEnv[0].LogBitAddr = logicBitAddr0;
            emgEnv[1].InvertLogic = isInvertLogic;
            emgEnv[1].LogBitAddr = logicBitAddr1;
            emgEnv[2].InvertLogic = isInvertLogic;
            emgEnv[2].LogBitAddr = logicBitAddr2;

            // filterCount : 입력신호 필터적용 사이클 사운트
            // 입력신호가 filterCount 이상 상태 바뀜이 유지되면 유효로 판단. 
            // 0 입력 시 필터 적용 안함.
            int filterCount = 0;
            int.TryParse(tbxFilterCount.Text, out filterCount);

            // 비상정지용 다중 Input 신호 환경을 설정한다.
            // 단일 Input 신호 설정 시 ecmHEMG_SetInputEnv() 함수 이용
            ec.ecmHEMG_SetInputEnv_Multi(netID, inputCount, emgEnv, filterCount, ref errorCode);
            if(errorCode != 0 ) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            // isDecelStop : 비상정지 신호 입력 시 감속 정지 여부
            // false : 급정지 / true : 감속 후 정지
            bool isDecelStop = chkIsDecelStop.Checked;

            // 신호 입력 시 정지 모드를 설정한다.
            ec.ecmHEMG_SetStopMode(netID, isDecelStop, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 하드웨어 비상정지 기능을 활성화 한다.
            bool isEnable = true;
            ec.ecmHEMG_SetEnable(netID, isEnable, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            // 하드웨어 비상정지 기능을 비활성화 한다.
            bool isEnable = false;
            ec.ecmHEMG_SetEnable(netID, isEnable, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void t_HEmg_Tick(object sender, EventArgs e)
        {
            bool isEnable = ec.ecmHEMG_GetState(netID, ref errorCode);
            lblHEmgState.Text = isEnable ? "Software Emergency!" : "-";
        }
    }
}
