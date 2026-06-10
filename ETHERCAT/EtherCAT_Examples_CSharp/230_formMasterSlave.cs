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
    public partial class formMasterSlave : Form
    {
        public formMasterSlave()
        {
            InitializeComponent();
            UpdateAxisList();
        }

    #region base

        int netID = 5;
        int masterAxisID = 0;
        int axisID = 0;
        double posRatio = 1;
        int errorCode = 0;
        byte[] axisList = new byte[32];
        bool isEnable = false;

        private void UpdateAxisList()
        {
            cbxAxis_Master.Items.Clear();
            cbxAxis.Items.Clear();

            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, (byte)axisList.Length, ref errorCode);
            if (errorCode != 0) //Error 처리
                AddLog(errorCode);

            for (int i = 0; i < axisCount; i++)
            {
                cbxAxis_Master.Items.Add(string.Format("Axis {0:00}", axisList[i]));
                cbxAxis.Items.Add(string.Format("Axis {0:00}", axisList[i]));
            }
            
            if (axisCount > 0)
                cbxAxis_Master.SelectedIndex = 0;

            if (axisCount > 1)
                cbxAxis_Master.SelectedIndex = 1;           
        }


        private void cbxAxis_Master_SelectedIndexChanged(object sender, EventArgs e)
        {
            int masterIndex = cbxAxis_Master.SelectedIndex;
            masterAxisID = axisList[masterIndex];         
        }


        private void cbxAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            int slaveIndex = cbxAxis.SelectedIndex;
            axisID = axisList[slaveIndex];

            UpdateForm();
        }


        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

    #endregion

        private void UpdateForm()
        {
            // Slave 축의 Master/Slave 기능이 활성화 되어 있는지 확인한다.
            ec.ecmMsSt_IsSlvStarted(netID, axisID, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // Slave 축의 Master/Slave 환경 설정 값을 확인한다.
            ec.ecmMsCfg_GetSlvEnv(netID, axisID, ref masterAxisID, ref posRatio, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            //UI 처리
            btnEnable.BackColor = isEnable ? SystemColors.Highlight : SystemColors.Control;

            int masterIndex = axisList.First(x => x.Equals(masterAxisID));
            cbxAxis_Master.SelectedIndex = masterIndex;
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            // PosRatio 값을 확인한다.
            // PosRatio는 마스터 축 이송거리와 슬레이브 축 이송거리의 비율
            // PosRatio 가 0.5 면 마스터축의 이송량이 1000 일때 슬레이브축의 이송량은 500
            double.TryParse(tbxRatio.Text, out posRatio);

            // Master / Slave 환경 설정
            ec.ecmMsCfg_SetSlvEnv(netID, axisID, masterAxisID, posRatio, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // Master/Slave 기능 활성화
            ec.ecmMsCtl_StartSlv(netID, axisID, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // Master/Slave 기능이 정상적으로 활성화 되었는지 확인
            bool isSlaveStarted = ec.ecmMsSt_IsSlvStarted(netID, axisID, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            if (!isSlaveStarted) //에러처리
            {
                MessageBox.Show("Slave Enable Failed");
                return;
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            // Master/Slave 기능 비활성화
            ec.ecmMsCtl_StopSlv(netID, axisID, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnSyncSlave_Click(object sender, EventArgs e)
        {
            // Slave 로 등록된 축을 마스터의 현재 위치와 같은 위치로 이송

            // 마스터축 기준으로 offset을 설정. 0인 경우 마스터축과 같은 위치로 이송
            double posOffset = 0;
            double.TryParse(tbxPosOffset.Text, out posOffset);

            // 해당 기능에 의한 이송이 완료될 때까지 대기
            bool isWaitCompt = chkIsWaitCompt.Checked;

            ec.ecmMsCtl_SynchSlv(netID, axisID, posOffset, isWaitCompt, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }            
        }

        
    }
}
