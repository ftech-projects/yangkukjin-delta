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
    public partial class formSD : Form
    {
        public formSD()
        {
            InitializeComponent();
            UpdateAxisList();

            cbxOffsetMode.Items.AddRange(Enum.GetNames(typeof(ec.EEcmSdOfsMode)));
        }

    #region base

        int netID = 5;
        int axisID = 0;
        int errorCode = 0;
        byte[] axisList = new byte[32];

        private void UpdateAxisList()
        {
            cbxAxisList.Items.Clear();

            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, (byte)axisList.Length, ref errorCode);
            if (errorCode != 0) //Error 처리
                AddLog(errorCode);

            for (int i = 0; i < axisCount; i++)
                cbxAxisList.Items.Add(string.Format("Axis {0:00}", axisList[i]));

            if (axisCount > 0)
                cbxAxisList.SelectedIndex = 0;
        }

        private void cbxAxisList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int axisIndex = cbxAxisList.SelectedIndex;
            axisID = axisList[axisIndex];

            UpdateForm();
        }


        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

    #endregion

        private void UpdateForm()
        {
                                  

            // SD 신호의 환경 설정값을 확인한다.
            ec.ecmSxSD_GetInputEnv(netID, axisID, ref logBitAddr, ref isInvertLogic, ref filterCount, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            switch(chType)
            {
                case 0: // Global Channel을 사용하는 경우
                    channel = ec.ecdiLogBitAddr_ToGlobalChannel(netID, logBitAddr, ref errorCode);
                    break;

                case 1: // OnBoard Channel을 사용하는 경우
                    channel = ec.ecdiLogBitAddr_ToOnboardChannel(netID, logBitAddr, ref errorCode);
                    break;
            }

            // 래치 모드를 확인한다.
            // false : 래치모드 사용안함. SD센서 감지 후 SD Speed로 동작하다가 센서 감지가 off되면 원래 속도로 복귀한다.
            // true : 래치모드 사용. SD센서 감지 후 SD Speed로 동작하다가 센서 감지가 off되어도 SD Speed를 유지한다.
            isLatchMode = ec.ecmSxSD_GetLatchMode(netID, axisID, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // OffsetMode와 offset을 확인한다.
            // offsetMOde는 EEcmSdOfsMode 참조
            // 0 (ecmSD_OFS_NONE): OFFSET을 사용하지 않음
            // 1 (ecmSD_OFS_TIME): OFFSET을 msec 단위의 시간으로 설정 
            // 2 (ecmSD_OFS_CMDPOS): OFFSET을 지령위치 기준의 위치값으로 설정
            // 3 (ecmSD_OFS_FEEDPOS): OFFSET을 궤환위치 기준의 위치값으로 설정
            // offset값의 단위는 offsetMode에 따라 달라진다.

            ec.ecmSxSD_GetOffset(netID, axisID, ref offsetMode,ref offset, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // SD 신호의 입력 여부를 확인한다.            

            sdSpeed = ec.ecmSxSD_GetSpeed(netID, axisID, ref errorCode);

            //UI 처리           

            if (channel < cbxCh.Items.Count)
                cbxCh.SelectedIndex = channel;
            else
            {
                //에러처리 (Invaild Channel 등)
            }

            chkInvertLogic.Checked = isInvertLogic;
            tbxFilterCount.Text = filterCount.ToString();
            tbxOffset.Text = offset.ToString();
            cbxOffsetMode.SelectedIndex = offsetMode;
            cbxLatchMode.SelectedIndex = isLatchMode ? 1 : 0;
            tbxSpeed.Text = sdSpeed.ToString();
        }

        int chType = 0;
        int channel = 0;
        int offsetMode = 0;
        double offset = 0;
        bool isLatchMode = false;
        double sdSpeed = 0;
        int filterCount = 0;
        bool isInvertLogic = false;
        bool isEnable = false;
        uint logBitAddr = 0;
        bool isInput = false;
        bool isAct = false;

        private void cbxChType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Di Channel에 대해 세 가지 방식으로 설정 가능하다.
            // Global Channel / Local Channel / OnBoard (Master Board에 포함된 DI 채널)
            // 본 예제에서는 local channel 에 대한 방법은 생략한다.

            chType = cbxChType.SelectedIndex;
            switch(cbxChType.SelectedIndex)
            {
                case 0: //Global
                    cbxCh.Items.Clear();
                    int chCount = ec.ecdiGetNumChannels(netID, ref errorCode);
                    for (int i = 0; i < chCount; i++)
                        cbxCh.Items.Add(string.Format("{0:00}", i));

                    if (channel < chCount)
                        cbxCh.SelectedIndex = channel;
                    break;

                case 2: //onBoard
                    // onBoard DI는 6채널이 제공된다.                    
                    for (int i = 0; i < 6; i++)
                        cbxCh.Items.Add(string.Format("{0:00}", i));

                    channel = 0;
                    cbxCh.SelectedIndex = channel;
                    break;
            }            
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            // UI 값을 확인한다.
            channel = cbxCh.SelectedIndex;
            switch (chType)
            {
                case 0: //Global Channel인 경우
                    logBitAddr = ec.ecdiLogBitAddr_FromGlobalChannel(netID, channel, ref errorCode);
                    break;

                case 1: //OnBoard Channel인 경우
                    logBitAddr = ec.ecdiLogBitAddr_FromOnboardChannel(netID, channel, ref errorCode);
                    break;
            }
            
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            isInvertLogic = chkInvertLogic.Checked;
            int.TryParse(tbxFilterCount.Text, out filterCount);
            offsetMode = cbxOffsetMode.SelectedIndex;
            double.TryParse(tbxOffset.Text, out offset);
            isLatchMode = cbxLatchMode.SelectedIndex == 1;
            double.TryParse(tbxSpeed.Text, out sdSpeed);

            // SD 입력에 대한 환경 설정
            ec.ecmSxSD_SetInputEnv(netID, axisID, logBitAddr, isInvertLogic, filterCount, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 래치모드 설정
            ec.ecmSxSD_SetLatchMode(netID, axisID, isLatchMode, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // Offset 설정
            ec.ecmSxSD_SetOffset(netID, axisID, offsetMode, offset, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // SD 신호 입력 시 적용할 속도 설정
            ec.ecmSxSD_SetSpeed(netID, axisID, sdSpeed, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // SD 기능 활성화
            ec.ecmSxSD_SetEnable(netID, axisID, true, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            // SD 기능 비활성화
            ec.ecmSxSD_SetEnable(netID, axisID, false, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnRestoreSpeed_Click(object sender, EventArgs e)
        {
            // 현재 SD 속도로 진행이면 원래의 속도로 복귀한다.
            ec.ecmSxSD_RestoreSpeed(netID, axisID, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void t_SD_Tick(object sender, EventArgs e)
        {
            // 선택된 축의 SD 기능이 활성화 되어 있는지 확인한다.
            // 비활성화 되어 있는 경우, SD 신호가 입력되어도 동작하지 않는다.

            isEnable = ec.ecmSxSD_GetEnable(netID, axisID, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            isInput = ec.ecmSxSD_GetInputStatus(netID, axisID, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 현재 SD Speed 로 동작 중인지 확인한다.
            isAct = ec.ecmSxSD_GetActStatus(netID, axisID, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            //UI 처리            
            btnEnable.BackColor = isEnable ? SystemColors.Highlight : SystemColors.Control;
            btnIsInput.BackColor = isInput ? Color.DarkOrange : SystemColors.Control;
            btnIsAct.BackColor = isAct ? Color.DarkOrange : SystemColors.Control;
        }
    }
}
