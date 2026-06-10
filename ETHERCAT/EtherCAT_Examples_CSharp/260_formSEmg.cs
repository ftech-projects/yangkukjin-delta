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
    //Software 방식의 비상정지 예제

    public partial class formSEmg : Form
    {        
        public formSEmg()
        {
            InitializeComponent();

            // 비상정지 활성화시 감속정지 여부를 확인한다.
            bool isDecelStop = ec.ecmSEMG_GetStopMode(netID, ref errorCode);
            chkIsDecelStop.Checked = isDecelStop;
        }

    #region base

        int netID = 5;
        int errorCode = 0;


        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

    #endregion

        private void btnEnable_Click(object sender, EventArgs e)
        {
            // isDecelStop : 비상정지 시 감속정지 여부
            // 0 : 급정지 / 1 : 감속정지
            bool isDecelStop = chkIsDecelStop.Checked;
            ec.ecmSEMG_SetStopMode(netID, isDecelStop, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }
            
            // 소프트웨어 비상정지 활성화

            bool state = true; // 활성화 여부
            ec.ecmSEMG_SetState(netID, state, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            // 소프트웨어 비상정지 비활성화
            bool state = false; // 활성화 여부
            ec.ecmSEMG_SetState(netID, state, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void t_SEmg_Tick(object sender, EventArgs e)
        {
            bool isEnable = ec.ecmSEMG_GetState(netID, ref errorCode);
            lblSEmgState.Text = isEnable ? "Software Emergency!" : "-";
        }
    }
}
