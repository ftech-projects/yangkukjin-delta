using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ec = ComiLib.EtherCAT.SafeNativeMethods;

namespace EtherCAT_Examples_CSharp
{
    public partial class formSxStatus : Form
    {
        public formSxStatus()
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
            {
                cbxAxisList.SelectedIndex = 0;                
                t_SxStatus.Start();
            }            
        }


        private void cbxAxisList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int axisIndex = cbxAxisList.SelectedIndex;
            axisID = axisList[axisIndex]; 
        }



        public void GetSxStatus(int axisID)
        {
            bool isServoOn = ec.ecmSxCtl_GetSvon(netID, axisID, ref errorCode);
            btnServoOn.BackColor = isServoOn ? Color.SteelBlue : Color.White;
            btnServoOn.ForeColor = isServoOn ? Color.White : Color.Black;


            //현재 축의 AlState를 확인한다.
            //AlState가 OP가 아니면 정상구동하지 않는다.
            
            //axisID를 통해서 slaveIndex 를 알 수 있다.
            //_A 가 붙은 함수는 slaveIndex를 매개변수로 가진다. (slaveIndex는 연결순서)
            
            int slaveIndex = ec.ecmGn_AxisToSlaveIndex(netID, axisID, ref errorCode);
            ec.EEcAlState alState = ec.ecSlv_GetAlState_A(netID, slaveIndex, ref errorCode);
            lblAlState.Text = alState.ToString();
            
            //현재 축의 모터 상태를 확인한다.
            //반환값의 의미는 EEcmMotStateId 를 참조한다.
            //반환값이 0보다 작으면 에러코드를 의미한다.
            int motorState = ec.ecmSxSt_GetMotState(netID, axisID, ref errorCode);
            if (motorState >= 0)
                lblMotorState.Text = ((ec.EEcmMotStateId)motorState).ToString();
            else
                lblMotorState.Text = motorState.ToString();
            
            //현재 축의 Command Position을 확인한다.
            double cmdPos = ec.ecmSxSt_GetPosition(netID, axisID, 0, ref errorCode);
            lblCmdPos.Text = cmdPos.ToString();

            //현재 축의 Current Position (Actual Position 또는 Feedback Position) 을 확인한다.
            //해당값이 올라오지 않는다면 PDO맵에 0x6064 (Position Actual Value)가 포함되지 않은 것이다.
            double curPos = ec.ecmSxSt_GetPosition(netID, axisID, 1, ref errorCode);
            lblCurPos.Text = curPos.ToString();

            //현재 축의 Command Speed을 확인한다.
            double cmdSpeed = ec.ecmSxSt_GetCurSpeed(netID, axisID, 0, ref errorCode);
            lblCmdSpeed.Text = cmdSpeed.ToString();

            //현재 축의 Current Position (Actual Position 또는 Feedback Position) 을 확인한다.
            //해당값이 올라오지 않는다면 PDO맵에 0x606C (Velocity Actual Value)가 포함되지 않은 것이다.
            double curSpeed = ec.ecmSxSt_GetCurSpeed(netID, axisID, 1, ref errorCode);
            lblCurSpeed.Text = curSpeed.ToString();

            //현재 축의 Torque를 확인한다.
            //해당값이 올라오지 않는다면 PDO맵에 0x6077 (Torque Actual Value)가 포함되지 않은 것이다.
            double torque = ec.ecmSxSt_GetCurTorque(netID, axisID, ref errorCode);
            lblTorque.Text = torque.ToString();

            //PDO맵핑은 https://winoar.com/dokuwiki/platform:ethercat:2_config:guide:processdata 참조

            //Servo에 입력된 Digital Input 값을 확인한다.
            ec.TEcmSxSt_DI mioState = new ec.TEcmSxSt_DI();
            mioState.word = ec.ecmSxSt_GetDI(netID, axisID, ref errorCode);

            //Negative Limit을 확인한다.            
            bool isNel = mioState.NOT == 1;
            SetState(lblNEL, isNel);

            //Positive Limit을 확인한다.
            SetState(lblPEL, mioState.POT == 1);

            //Origin을 확인한다.
            SetState(lblORG, mioState.HOME == 1);

            //EtherCAT Driver의 경우 INP를 PDO에 포함시킬 수 없는 Driver도 있는데, 이 경우 마스터는 INP 감지 여부를 알 수 없다.
            //INP를 PDO에 포함시키지 못하는 드라이버의 경우 MasterInp 기능을 사용 하면 동일한 결과를 얻을 수 있다.
            //Inposition을 확인한다.
            SetState(lblInposition, mioState.INP == 1);


            ec.TEcmSxSt_Flags motFlag = new ec.TEcmSxSt_Flags();
            motFlag.word = ec.ecmSxSt_GetFlags(netID, axisID, ref errorCode);

            //Ready를 확인한다
            SetState(lblReady, motFlag.RdyToSwOn == 1);

            //Warning을 확인한다.
            SetState(lblWarning, motFlag.ServoWarn == 1);

            //Alarm을 확인한다.
            SetState(lblAlarm, motFlag.ServoFault == 1);

        }


        private void SetState(Label sender, bool isOn)
        {
            sender.BackColor = isOn ? Color.DarkOrange : Color.White;
            sender.ForeColor = isOn ? Color.White : Color.Black;
        }

        private void t_SxStatus_Tick(object sender, EventArgs e)
        {
            GetSxStatus(axisID);
        }

        private void btnServoOn_Click(object sender, EventArgs e)
        {
            //현재 Servo-On 여부를 확인한다.
            bool isServoOn = ec.ecmSxCtl_GetSvon(netID, axisID, ref errorCode);
            if (errorCode != 0)
            {
                MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
                return;
            }

            // 현재값과 반대값을 입력한다.
            // ex) isServoOn == false 면 1 입력, isServoOn == true 면 0입력
            ec.ecmSxCtl_SetSvon(netID, axisID, isServoOn ? 0 : 1, ref errorCode);
            if (errorCode != 0)
                MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

        private void btnAlarmReset_Click(object sender, EventArgs e)
        {
            // 서보의 알람을 초기화한다.
            // 해당명령으로 초기화 되지 않는 알람일 경우 서보의 전원을 재투입한다.
            ec.ecmSxCtl_ResetAlm(netID, axisID, ref errorCode);
            if (errorCode != 0)
                MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

        private void btnResetPosition_Click(object sender, EventArgs e)
        {
            // Position을 입력한 값으로 변경한다.
            // New Position에 0을 입력하면 초기화와 같다.
            ec.ecmSxSt_SetPosition(netID, axisID, 0, ref errorCode);

            if (errorCode != 0)
                MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }        
    }    
}
