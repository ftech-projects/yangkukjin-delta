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
    public partial class formRingCounter : Form
    {
        public formRingCounter()
        {
            InitializeComponent();

            // DeviceLoad 전이면 DeviceLoad를 먼저 실행한다.
            int devIndex = 0;
            if (!ec.ecGn_IsDevLoaded(devIndex, ref errorCode))
                if (!ec.ecGn_LoadDevice(ref errorCode))
                    AddLog(errorCode);

            UpdateAxisList();

            cbxDirMode.Items.AddRange(Enum.GetNames(typeof(RingCounterDirection)));
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
            GetRingCounterInfo();
        }

        public enum RingCounterDirection
        {
            Negative,
            Positive,
            Near,
            Far,
            Invalid
        }

        bool isEnable = false;
        double range = 0;
        int dirMode = 0;

        
        private void btnEnable_Click(object sender, EventArgs e)
        {
            ec.ecmSxCfg_Ring_SetEnable(netID, axisID, true, ref errorCode);
            if (errorCode != 0) //Error 처리
            {
                AddLog(errorCode);
                return;
            }

            double.TryParse(tbxRange.Text, out range);
            dirMode = cbxDirMode.SelectedIndex;

            // RingCounter 설정 시 position 은 0 ~ range 사이에서만 표시된다.
            // 즉 position == range 가 되면 0으로 표시된다.
            // 일반적으로 각도 제어 시 사용된다. 0 ~ 359.9 등으로 표시
            
            ec.ecmSxCfg_Ring_SetPosRange(netID, axisID, range, ref errorCode);
            if (errorCode != 0) //Error 처리
            {
                AddLog(errorCode);
                return;
            }

            // DirMode 는 이송 시 어느방향으로 이송할지에 대한 옵션이다.
            // ex) 회전체에 0 ~ 359.9 설정 후, 0 위치에서 90 위치로 이송시
            // +방향으로 / - 방향으로 / 가까운 방향으로 / 먼 방향으로 이송할지에 대한 선택

            ec.ecmSxCfg_Ring_SetDirMode(netID, axisID, dirMode, ref errorCode);
            if (errorCode != 0) //Error 처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            ec.ecmSxCfg_Ring_SetEnable(netID, axisID, false, ref errorCode);
            if (errorCode != 0) //Error 처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void GetRingCounterInfo()
        {
            isEnable = ec.ecmSxCfg_Ring_GetEnable(netID, axisID, ref errorCode);
            if (errorCode != 0) //Error 처리
            {
                AddLog(errorCode);
                return;
            }

            if (isEnable)
            {
                btnEnable.BackColor = SystemColors.Highlight;
                btnDisable.BackColor = SystemColors.Control;
            }
            else
            {
                btnEnable.BackColor = SystemColors.Control;
                btnDisable.BackColor = SystemColors.Highlight;
            }

            range = ec.ecmSxCfg_Ring_GetPosRange(netID, axisID, ref errorCode);
            if (errorCode != 0) //Error 처리
            {
                AddLog(errorCode);
                return;
            }

            tbxRange.Text = range.ToString();


            dirMode = ec.ecmSxCfg_Ring_GetDirMode(netID, axisID, ref errorCode);
            if (errorCode != 0) //Error 처리
            {
                AddLog(errorCode);
                return;
            }

            cbxDirMode.SelectedIndex = dirMode;
        }
    }
}
