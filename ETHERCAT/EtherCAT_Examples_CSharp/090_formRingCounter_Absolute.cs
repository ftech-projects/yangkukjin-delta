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
    // 파나소닉 서보의 절대치 모터로 무한 회전을 하는 경우에 대한 예제이다.
    // 기능 사용에 앞서 다음 파라미터 값에 대한 설정이 선행되어야 한다.
    // 0.15 (앱솔루트 인코더 설정) : 4
    // 6.88 (앱솔루트 다회전 데이터 상한값 : 모터 1회전당 360도 제어할 시 0. 감속기 사용시에는 감속비
    public partial class formRingCounter_Absolute : Form
    {
        public formRingCounter_Absolute()
        {
            InitializeComponent();

            // DeviceLoad 전이면 DeviceLoad를 먼저 실행한다.
            int devIndex = 0;
            if (!ec.ecGn_IsDevLoaded(devIndex, ref errorCode))
                if (!ec.ecGn_LoadDevice(ref errorCode))
                    AddLog(errorCode);

            cbxDirMode.Items.AddRange(Enum.GetNames(typeof(RingCounterDirection)));

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
            // MaxPosition Lange Limit 을 확인한다.
            // 0.15 파라메터(앱솔루트 인코더 설정) 설정값이 4일때, MaxPosition Lange는 전자기어비에 의해 재설정된 Range가 자동 적용된다.
            // 다만 모터의 분해능등을 이유로 유저가 설정한 값과 일치하지 않을 수 있다.
            // 반드시 해당값을 확인하고, RingCounter Range를 MaxPosition 값과 같으로 설정해야 한다.

            int isComptAccess = 0;
            int pBuf = 0;
            ec.ecSlv_ReadCoeSdo(netID, (ushort)(axisID + 1), 0x607b, 2, isComptAccess, 4, ref pBuf, ref errorCode);
            if (errorCode != 0) //Error 처리
            {
                AddLog(errorCode);
                return;
            }

            bool isAbsEnable = false;
            range = ec.ecmSxCfg_Ring_GetPosRangeEx(netID, axisID, ref isAbsEnable, ref errorCode);

            tbxRange.Text = range.ToString();
            tbxRangeLimit.Text = pBuf.ToString();

            // 링카운터 이송 방향 조건을 확인한다.
            dirMode = ec.ecmSxCfg_Ring_GetDirMode(netID, axisID, ref errorCode);
            if (errorCode != 0) //Error 처리
            {
                AddLog(errorCode);
                return;
            }

            cbxDirMode.SelectedIndex = dirMode;
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
            double.TryParse(tbxRange.Text, out range);
            dirMode = cbxDirMode.SelectedIndex;

            // 링카운터 설정 시 position 은 0 ~ range 사이에서만 표시된다.
            // 즉 position == range 가 되면 0으로 표시된다.
            // 일반적으로 각도 제어 시 사용된다. 0 ~ 359.9 등으로 표시

            bool isAbsMode = true;
            ec.ecmSxCfg_Ring_SetPosRangeEx(netID, axisID, range, isAbsMode, ref errorCode);
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

            // 링카운터 기능을 활성화 한다.
            ec.ecmSxCfg_Ring_SetEnable(netID, axisID, true, ref errorCode);
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


        private void t_Ring_Tick(object sender, EventArgs e)
        {
            // 링카운터 활성화 여부를 확인한다.
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

            // 링카운터 절대치 적용 여부와 범위를 확인한다.
            bool isAbsEnable = false;
            range = ec.ecmSxCfg_Ring_GetPosRangeEx(netID, axisID, ref isAbsEnable, ref errorCode);
            if (errorCode != 0) //Error 처리
            {
                AddLog(errorCode);
                return;
            }

            
            lblAbsEnable.Text = isEnable ? "Enable" : "Disable";
        }
    }
}
