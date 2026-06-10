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
    public partial class formAutoTorque : Form
    {
        public formAutoTorque()
        {
            InitializeComponent();
            lvwItem.SmallImageList = new ImageList() { ImageSize = new Size(1, 25) };
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
                

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // UI 처리            
            double torque = 0;
            double duration = 0;

            double.TryParse(tbxTorque.Text, out torque);
            double.TryParse(tbxDuration.Text, out duration);

            var item = new ListViewItem(torque.ToString());
            item.SubItems.Add(duration.ToString());

            lvwItem.Items.Add(item);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvwItem.Items.Clear();
        }
               

        private void btnStartSingle_Click(object sender, EventArgs e)
        {
            int valMode = 0; // 0 : single Mode
            int numMultiVal = 1; // 토크 출력 수, 단일 출력이므로 1

            // 출력모드를 단일출력모드로 설정한다.
            ec.ecmSxCfg_AutoTorq_SetValMode(netID, axisID, valMode, numMultiVal, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 출력 토크값.(단위는 0.1%)
            int outTorqueVal = 0;
            int.TryParse(lvwItem.Items[0].SubItems[0].Text, out outTorqueVal);

            // 단일 출력 시 duration은 설정하지 않는다. 제한 조건의 time으로 설정 가능

            // 출력 토크값을 설정한다.
            ec.ecmSxCfg_AutoTorq_SetValue(netID, axisID, outTorqueVal, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 적용하고자 하는 완료 조건의 종류를 비트별로 설정한다.
            // 0으로 설정 시 자동완료 조건을 설정하지 않는다. mask로 입력되므로, 여러개의 조건을 함께 입력 할 수 있다.
            // 각 비트값의 의미는 다음과 같다.
            // bit_0 : HighSpeedLimit (이송속도의 최대값을 설정한다. 모터의 이송속도(피드백속도)가 이 값보다 크거나 같으면 토크 출력모드를 종료한다.
            // bit_1 : LowSpeedLimit (이송속도의 최소값을 설정한다. 모터의 이송속도(피드백속도)가 이 값보다 작거나 같으면 토크 출력모드를 종료한다.
            // bit_2 : Time (토크 출력 모드의 최대 유지시간. ms)

            int limitMask = 0;
            limitMask |= chkhighSpeed.Checked ? (1 << 0) : 0;
            limitMask |= chkLowSpeed.Checked ? (1 << 0) : 0;
            limitMask |= chkTime.Checked ? (1 << 0) : 0;

            double highSpeedLimit = 0;
            double lowSpeedLimit = 0;
            int timeLimit = 0;

            double.TryParse(tbxHighSpeed.Text, out highSpeedLimit);
            double.TryParse(tbxLowSpeed.Text, out lowSpeedLimit);
            int.TryParse(tbxTime.Text, out timeLimit);

            // 토크출력 제한 조건을 설정한다.
            // 제한 조건 달성 시 토크 출력 모드를 자동으로 완료한다.
            ec.ecmSxCfg_AutoTorq_SetLimit(netID, axisID, (uint)limitMask, highSpeedLimit, lowSpeedLimit, timeLimit, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }
            
            // 단일출력인지에 대한 옵션
            bool isOneShot = true;
            bool isEnable = true;
            ec.ecmSxCfg_AutoTorq_SetEnable(netID, axisID, isEnable, isOneShot, ref errorCode);

            btnStartSingle.BackColor = SystemColors.Highlight;
            btnStartMulti.BackColor = SystemColors.Control;
        }

        private void btnStartMulti_Click(object sender, EventArgs e)
        {            
            // 다중 토크값 지정 시 다단으로 적용되며 첫번째 토크 출력을 첫번째 duration 만큼 유지한 후 다음 토크값이 다음 duration만큼 유지된다.            
            int valMode = 1; // 1 : multi Mode
            int numMultiVal = lvwItem.Items.Count; // 토크 출력 수, 등록된 ListViewItem의 수

            // 출력모드를 다중출력모드로 설정한다.
            ec.ecmSxCfg_AutoTorq_SetValMode(netID, axisID, valMode, numMultiVal, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            int outTorqueVal = 0; // 출력 토크값
            int duration = 0; // 출력 유지시간
            for (int i = 0; i < numMultiVal; i++)
            {
                int.TryParse(lvwItem.Items[i].SubItems[0].Text, out outTorqueVal);
                int.TryParse(lvwItem.Items[i].SubItems[1].Text, out duration);

                // 출력 토크값을 설정한다.
                ec.ecmSxCfg_AutoTorq_SetMultiVal(netID, axisID, i, outTorqueVal, duration, ref errorCode);
                if (errorCode != 0) // 에러처리
                {
                    AddLog(errorCode);
                    return;
                }
            }

            // 적용하고자 하는 완료 조건의 종류를 비트별로 설정한다.
            // 0으로 설정 시 자동완료 조건을 설정하지 않는다. mask로 입력되므로, 여러개의 조건을 함께 입력 할 수 있다.
            // 각 비트값의 의미는 다음과 같다.
            // bit_0 : HighSpeedLimit (이송속도의 최대값을 설정한다. 모터의 이송속도(피드백속도)가 이 값보다 크거나 같으면 토크 출력모드를 종료한다.
            // bit_1 : LowSpeedLimit (이송속도의 최소값을 설정한다. 모터의 이송속도(피드백속도)가 이 값보다 작거나 같으면 토크 출력모드를 종료한다.
            // bit_2 : Time (토크 출력 모드의 최대 유지시간. ms)

            int limitMask = 0;
            limitMask |= chkhighSpeed.Checked ? (1 << 0) : 0;
            limitMask |= chkLowSpeed.Checked ? (1 << 0) : 0;
            limitMask |= chkTime.Checked ? (1 << 0) : 0;

            double highSpeedLimit = 0;
            double lowSpeedLimit = 0;
            int timeLimit = 0;

            double.TryParse(tbxHighSpeed.Text, out highSpeedLimit);
            double.TryParse(tbxLowSpeed.Text, out lowSpeedLimit);
            int.TryParse(tbxTime.Text, out timeLimit);

            // 토크출력 제한 조건을 설정한다.
            // 제한 조건 달성 시 토크 출력 모드를 자동으로 완료한다.
            ec.ecmSxCfg_AutoTorq_SetLimit(netID, axisID, (uint)limitMask, highSpeedLimit, lowSpeedLimit, timeLimit, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 단일출력인지에 대한 옵션        
            // numMultiVal > 1 인 경우에도, isOneShot == true 라면, 단일 출력으로 처리된다.
            bool isOneShot = false;
            bool isEnable = true;
            ec.ecmSxCfg_AutoTorq_SetEnable(netID, axisID, isEnable, isOneShot, ref errorCode);

            btnStartSingle.BackColor = SystemColors.Control;
            btnStartMulti.BackColor = SystemColors.Highlight;
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            // 오토토크 모드를 종료한다.
            bool isEnable = false;
            ec.ecmSxCfg_AutoTorq_SetEnable(netID, axisID, isEnable, false, ref errorCode);

            btnStartSingle.BackColor = SystemColors.Control;
            btnStartMulti.BackColor = SystemColors.Control;
        }


        private void UpdateForm()
        {
            lvwItem.Items.Clear();

            // 선택된 축의 오토토크 모드 적용 여부와 단일 출력 여부를 확인한다.
            bool isOneShot = false;
            bool isEnable = ec.ecmSxCfg_AutoTorq_GetEnable(netID, axisID, ref isOneShot, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            // Enable 시 UI 처리
            btnStartSingle.BackColor = SystemColors.Control;
            btnStartMulti.BackColor = SystemColors.Control;

            if (!isEnable)
                return;

            if (isOneShot)
                btnStartSingle.BackColor = SystemColors.Highlight;
            else
                btnStartMulti.BackColor = SystemColors.Highlight;

            // 다중 출력인 경우 출력 토크수를 확인한다.
            // 다중 출력인데, IsOneShot 옵션이 true일 수 있다.
            int numMultiVals = 0;
            ec.ecmSxCfg_AutoTorq_GetValMode(netID, axisID, ref numMultiVals, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            int torq = 0;
            if(isOneShot)
            {
                // 단일 출력인 경우 출력토크값을 확인한다.
                torq = ec.ecmSxCfg_AutoTorq_GetValue(netID, axisID, ref errorCode);
                lvwItem.Items.Add(torq.ToString());
            }
            else
            {
                int duration = 0;
                for (int i = 0; i < numMultiVals; i++) 
                {
                    //다중 출력인 경우 출력값과 출력시간을 확인한다.
                    ec.ecmSxCfg_AutoTorq_GetMultiVal(netID, axisID, i, ref torq, ref duration, ref errorCode);

                    // UI 처리
                    var item = new ListViewItem(torq.ToString());
                    item.SubItems.Add(duration.ToString());
                    lvwItem.Items.Add(item);
                }                
            }

            uint limitMask = 0;
            double highSpeedLimit = 0;
            double lowSpeedLimit = 0;
            int timeLimit = 0;
            ec.ecmSxCfg_AutoTorq_GetLimit(netID, axisID, ref limitMask, ref highSpeedLimit, ref lowSpeedLimit, ref timeLimit, ref errorCode);
            //에러 처리 생략

            chkhighSpeed.Checked = (limitMask & 1) == 1;
            chkLowSpeed.Checked = ((limitMask >> 1) & 1) == 1;
            chkLowSpeed.Checked = ((limitMask >> 2) & 1) == 1;

            tbxHighSpeed.Text = highSpeedLimit.ToString();
            tbxLowSpeed.Text = lowSpeedLimit.ToString();
            tbxTime.Text = timeLimit.ToString();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            double position = 0;
            double.TryParse(tbxPosition.Text, out position);
            ec.ecmSxMot_MoveToStart(netID, axisID, position, ref errorCode);
        }
    }
}
