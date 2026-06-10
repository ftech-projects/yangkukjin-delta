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
    public partial class formTorque : Form
    {
        public formTorque()
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
            // Operation Mode를 확인한다. ec.EEcmOperMode 참조
            // 5 : HomingMode
            // 8 : Cyclic Position (CP)
            // 9 : Cyclic Velocity (CV)
            // 10 : Cyclic Torque (CT)

            int operMode = ec.ecmSxCfg_GetOperMode(netID, axisID, ref errorCode);
            switch (operMode)
            {
                case 5: //ec.EEcmOperMode.ecmOPMODE_HM
                    rdoHoming.Checked = true;
                    break;

                case 8: //ec.EEcmOperMode.ecmOPMODE_CP
                    rdoPosition.Checked = true;
                    break;

                case 9: //ec.EEcmOperMode.ecmOPMODE_CV
                    rdoVelocity.Checked = true;
                    break;

                case 10: //ec.EEcmOperMode.ecmOPMODE_CT
                    rdoTorque.Checked = true;
                    break;
            }            
        }

        private void rdoHoming_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as RadioButton).Checked)
                return;

            // 홈복귀 모드이다.
            // 홈복귀에 대한 내용은 formHoming 예제 참조
        }

        private void rdoPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as RadioButton).Checked)
                return;

            // OperationMode 를 Cyclic Position(CP) Mode로 변경한다.
            // OperationMode 변경은 0x6060 : Modes of Operation 을 통해 변경되므로
            // PDO의 ProcessData 에 0x6060 이 포함되어 있지 않다면, Mode는 변경되지 않는다.
            // https://winoar.com/dokuwiki/platform:ethercat:2_config:guide:processdata 참조
            
            ec.ecmSxCfg_SetOperMode(netID, axisID, ec.EEcmOperMode.ecmOPMODE_CP, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }                        

            gbxTorque.Enabled = false;
            gbxVelocity.Enabled = false;
        }

        private void rdoVelocity_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as RadioButton).Checked)
                return;

            // OperationMode 를 Cyclic Velocity(CV) Mode로 변경한다.
            ec.ecmSxCfg_SetOperMode(netID, axisID, ec.EEcmOperMode.ecmOPMODE_CV, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 속도제어시의 최대토크 조건을 확인한다.
            ushort maxTorque = ec.ecmSxCfg_GetMaxTorqOfCV(netID, axisID, ref errorCode);
            tbxMaxTorque.Text = maxTorque.ToString();

            // 속도제어시의 목표속도를 확인한다.
            double targetVel = ec.ecmSxMot_GetTargVel(netID, axisID, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            tbxTargetVel.Text = targetVel.ToString();

            gbxTorque.Enabled = false;
            gbxVelocity.Enabled = true;
        }

        private void rdoTorque_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as RadioButton).Checked)
                return;

            // OperationMode 를 Cyclic Torque(CT) Mode로 변경한다.
            ec.ecmSxCfg_SetOperMode(netID, axisID, ec.EEcmOperMode.ecmOPMODE_CT, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

#if true
            // 토크제어시의 최대속도 조건을 확인한다.
            double maxVel = ec.ecmSxCfg_GetMaxSpdOfCT(netID, axisID, ref errorCode);
            tbxMaxVel.Text = maxVel.ToString();

#else

            // 드라이버에 따라 0x607F(최대 프로파일 속도)가 토크제어시의 최대속도로 설정되는 경우가 있다. (ex : 옴론 등)
            // 이 경우 ecmSxCfg_GetMaxProfSpdOfCT() 사용
            double maxVel = ec.ecmSxCfg_GetMaxProfSpdOfCT(netID, axisID, ref errorCode);
            tbxMaxVel.Text = maxVel.ToString();

#endif
            // 토크제어시의 목표토크를 확인한다.
            int targetTorque = ec.ecmSxMot_GetTargTorq(netID, axisID, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            tbxTargetTorque.Text = targetTorque.ToString();

            gbxTorque.Enabled = true;
            gbxVelocity.Enabled = false;
        }

        private void btnVel_Click(object sender, EventArgs e)
        {
            // 속도 제어 모드에서는 최대토크값을 제한 조건으로 설정할 수 있다.            
            // 토크값의 단위는 0.1%
            ushort maxTorque = 0;
            ushort.TryParse(tbxMaxTorque.Text, out maxTorque);

            // 최대 토크값을 속도제어의 제한 조건으로 설정한다.
            ec.ecmSxCfg_SetMaxTorqOfCV(netID, axisID, maxTorque, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            double targetVel = 0;
            double.TryParse(tbxTargetVel.Text, out targetVel);

            // 목표속도를 설정한다.
            ec.ecmSxMot_SetTargVel(netID, axisID, targetVel, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnTorque_Click(object sender, EventArgs e)
        {
            // 토크 제어 모드에서는 최대속도값을 제한 조건으로 설정할 수 있다.            
            // 속도값의 단위는 드라이버에 따라 다르지만, 일반적으로 rpm을 사용
            ushort maxVel = 0;
            ushort.TryParse(tbxMaxVel.Text, out maxVel);


            // 최대 속도값을 토크제어의 제한 조건으로 설정한다.

#if true
            //ec.ecmSxCfg_SetMaxSpdOfCT(netID, axisID, maxVel, ref errorCode);
            ec.ecmSxCfg_SetMaxProfSpdOfCT(netID, axisID, maxVel, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

#else
            // 드라이버에 따라 0x607F(최대 프로파일 속도)가 토크제어시의 최대속도로 설정되는 경우가 있다. (ex : 옴론 등)
            // 이 경우 ecmSxCfg_SetMaxProfSpdOfCT() 사용

            ec.ecmSxCfg_SetMaxProfSpdOfCT(netID, axisID, maxVel, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }
#endif
            ushort targetTorque = 0;
            ushort.TryParse(tbxTargetTorque.Text, out targetTorque);

            // 목표토크를 설정한다.
            ec.ecmSxMot_SetTargTorq(netID, axisID, targetTorque, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }           
        }
    }
}
