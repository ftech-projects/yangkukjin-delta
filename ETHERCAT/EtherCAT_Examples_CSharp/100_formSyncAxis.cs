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
    public partial class formSyncAxis : Form
    {
        public formSyncAxis()
        {
            InitializeComponent();
            UpdateAxisList();
        }

    #region base

        int netID = 5;
        int axisID = 0;
        int errorCode = 0;
        byte[] axisList = new byte[32];

        private void UpdateAxisList()
        {
            cbxAxis.Items.Clear();

            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, (byte)axisList.Length, ref errorCode);
            if (errorCode != 0) //Error 처리
                AddLog(errorCode);

            for (int i = 0; i < axisCount; i++)
                cbxAxis.Items.Add(string.Format("{0:00}", axisList[i]));

            if (axisCount > 0)
                cbxAxis.SelectedIndex = 0;
        }

        private void cbxAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            int axisIndex = cbxAxis.SelectedIndex;
            axisID = axisList[axisIndex];

            UpdateForm();
        }


        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

    #endregion


        int syncAxisID = 0;
        int method = 0;
        int type = 0;
        double position = 0;

        
        private void btnStart_Click(object sender, EventArgs e)
        {
            //SyncAxis : 동기화할 대상 축

            syncAxisID = axisList[cbxSyncAxis.SelectedIndex];

            // SyncType : 동기화 타입 (EEcmSyncOtherType 참조)
            // 0 : ecmSYNC_OTHER_START : SyncAxis가 이송 시작 시 시작
            // 1 : ecmSYNC_OTHER_ACC_INI : SyncAxis가 가속 시작 시 시작
            // 2 : ecmSYNC_OTHER_ACC_END : SyncAxis가 가속 완료 시 시작
            // 3 : ecmSYNC_OTHER_DEC_INI : SyncAxis가 감속 시작 시 시작
            // 4 : ecmSYNC_OTHER_DEC_END : SyncAxis가 감속 완료 시 시작
            // 5 : ecmSYNC_OTHER_POSITION : SyncAxis가 특정 위치 도달 시 시작
            // 6 : ecmSYNC_OTHER_INVALID

            type = cbxType.SelectedIndex;

            // SyncMethod : SyncType == ecmSYNC_OTHER_POSITION 일 때 위치 비교 방법 (EEcmPosSyncMethod 참조)
            // 0 : ecmPOS_SYNC_GT, // position이 syncAxis의 position보다 큰(Greater Than) 경우.
            // 1 : ecmPOS_SYNC_GE, // position이 syncAxis의 position보다 크거나 같은(Greater or Equal) 경우.
            // 2 : ecmPOS_SYNC_LT, // position이 syncAxis의 position보다 작은(Less Than) 경우.
            // 3 : ecmPOS_SYNC_LE, // position이 syncAxis의 position보다 크거나 같은(Less or Equal) 경우.
            // 4 : ecmPOS_SYNC_POS_CROSS, // position이 syncAxis의 position보다 작은 값에서 큰 값으로 변하는 경우.
            // 5 : ecmPOS_SYNC_NEG_CROSS, // position이 syncAxis의 position보다 큰 값에서 작은 값으로 변하는 경우.
            // 6 : ecmPOS_SYNC_INVALID

            method = cbxMethods.SelectedIndex;

            // SyncPosition : SyncType == ecmSYNC_OTHER_POSITION 일때 SyncAxis 기준 위치

            double.TryParse(tbxPosition.Text, out position);

            ec.ecmSxCfg_SetSyncOtherEnv(netID, axisID, syncAxisID, type, method, position, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 최초 조건 만족시에만 동작할지에 대한 설정
            bool isOneShot = chkIsOneShot.Checked;

            // Sync 기능 활성화
            bool isEnable = true;
            ec.ecmSxCfg_SetSyncOtherEnable(netID, axisID, isEnable, isOneShot, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Sync 기능 비활성화
            bool isEnable = false;
            ec.ecmSxCfg_SetSyncOtherEnable(netID, axisID, isEnable, false, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }
        }


        private void UpdateForm()
        {
            // isEnable : SyncAxis 기능의 활성화 여부 확인
            bool isEnable = false;
            // isOneShot : OneShot 기능 활성화 여부 확인.
            // 활성화 시 최초 조건 조건 성립시에만 동작한다.
            bool isOneShot = false;
            ec.ecmSxCfg_GetSyncOtherEnable(netID, axisID, ref isEnable, ref isOneShot, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            ec.ecmSxCfg_GetSyncOtherEnv(netID, axisID, ref syncAxisID, ref type, ref method, ref position, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            cbxSyncAxis.SelectedIndex = axisList.ToList().FindIndex(x => x == syncAxisID);
            cbxMethods.SelectedIndex = method;
            cbxType.SelectedIndex = type;
            tbxPosition.Text = position.ToString();
        }
    }
}
