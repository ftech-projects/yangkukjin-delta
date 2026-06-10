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
    public partial class FormZVIS : Form
    {
        public FormZVIS()
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
            cbxAxisList.Items.Clear();

            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, (byte)axisList.Length, ref errorCode);
            if (errorCode != 0) //Error 처리
                AddLog(errorCode);

            for (int i = 0; i < axisCount; i++)
                cbxAxisList.Items.Add(string.Format("{0:00}", axisList[i]));

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
            // 선택된 축에 진동억제 기능이 적용되어 있는지 확인한다.
            bool isEnable = ec.ecmSxCfg_GetZVISEnable(netID, axisID, ref errorCode);
            
            // 진동억제 기능을 위한 파라미터를 확인한다.
            // Natural Frequency : 고유 진동수 (Hz, 1 ~ 100Hz 사이의 값)
            // Damping Ratio : 감쇄비 (0 ~ 1.0 사이의 값)
            // ZVIS Mode : mode 번호가 상승할 수록 진동 억제 성능은 향상되지만, Frequency가 맞지 않을 경우 모션 완료 시간이 지연될 수 있다.
            //  0 : 2 Pulse Mode
            //  1 : 3 Pulse Mode
            //  2 : 4 Pulse Mode

            // 선택된 축의 진동억제 파라미터를 확인한다.
            ec.ecmSxCfg_GetZVISParam(netID, axisID, ref frequency, ref dampingRatio, ref zvisMode, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

            btnEnable.BackColor = isEnable ? SystemColors.Highlight : SystemColors.Control;
            tbxFrequency.Text = frequency.ToString();
            tbxDampingRatio.Text = dampingRatio.ToString();
            cbxZvisMode.SelectedIndex = zvisMode;
        }

        double frequency = 0;
        double dampingRatio = 0;
        int zvisMode = 0;
        
        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(tbxFrequency.Text, out frequency))
            {
                frequency = 1;
                tbxFrequency.Text = frequency.ToString();
            }

            double.TryParse(tbxDampingRatio.Text, out dampingRatio);
            zvisMode = cbxZvisMode.SelectedIndex;
                        
            // 진동억제 기능 관련 파라미터를 설정한다.
            ec.ecmSxCfg_SetZVISParam(netID, axisID, frequency, dampingRatio, zvisMode, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

            // 진동억제 기능을 활성화 한다.
            // ServoOn 상태에서는 설정이 적용되지 않는다.
            bool isEnable = true;
            ec.ecmSxCfg_SetZVISEnable(netID, axisID, isEnable, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

            // UI 처리
            btnEnable.BackColor = SystemColors.Highlight;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            // 진동억제 기능을 비활성화 한다.
            // ServoOn 상태에서는 설정이 적용되지 않는다.
            bool isEnable = false;
            ec.ecmSxCfg_SetZVISEnable(netID, axisID, isEnable, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }
        }
    }
}
