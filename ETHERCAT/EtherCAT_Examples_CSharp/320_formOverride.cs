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
    public partial class formOverride : Form
    {
        public formOverride()
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

        }

        private void btnOverrideMove_Click(object sender, EventArgs e)
        {
            // 이송중인 축에 대해 현재 위치에서의 상대 좌표값으로 목표거리값을 변경한다.
            // 기존 이송 방식에 상관없이 동작한다.

            lblIsIgnored.Text = "-";

            // 새로운 목표 거리값
            double newDistance = 0;
            double.TryParse(tbxNewDist.Text, out newDistance);

            // 오버라이드 결과 (성공 / 실패)
            bool isIgnored = false;
            
            // 오버라이드를 수행한다. (newPosition 으로 상대 거리 변경)
            ec.ecmSxMot_OverrideMove(netID, axisID, newDistance, ref isIgnored, ref errorCode);
            if(errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

            // UI처리 : 수행결과를 확인한다.
            lblIsIgnored.Text = isIgnored ? "Ignored" : "Success";
        }


        private void btnOverrideMoveTo_Click(object sender, EventArgs e)
        {
            // 이송중인 축에 대해 절대 좌표값으로 목표위치를 변경한다.
            // 기존 이송 방식에 상관없이 동작한다.

            lblIsIgnored.Text = "-";

            // 새로운 목표 위치값
            double newPosition = 0;
            double.TryParse(tbxNewPos.Text, out newPosition);

            // 오버라이드 결과 (성공 / 실패)
            bool isIgnored = false;

            // 오버라이드를 수행한다.
            ec.ecmSxMot_OverrideMoveTo(netID, axisID, newPosition, ref isIgnored, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

            // UI처리 : 수행결과를 확인한다.

            lblIsIgnored.Text = isIgnored ? "Ignored" : "Success";
        }

        private void btnOverrideSpeed_Click(object sender, EventArgs e)
        {
            // 이송중인 축에 대해 속도를 변경한다.
            // ecmSxCfg_SetSpeedPatt() 함수를 통해 변경하고자 하는 속도 또는 가감속 값을 설정하고 해당 함수를 수행한다.
            // 본 예제에서는 WorkSpeed 만 변경해본다.
                        
            lblIsIgnored.Text = "-";

            int speedMode = 0;
            double workSpeed = 0;
            double accel = 0;
            double decel = 0;
            double init = 0;
            double end = 0;

            // 현재 속도 조건에서 workSpeed 만 변경하기 위한 구문으로
            // 해당 기능 수행과 무관하다.
            ec.ecmSxCfg_GetSpeedPatt(netID, axisID, ref speedMode, ref init, ref end, ref workSpeed, ref accel, ref decel, ref errorCode);

            // 새로운 WorkSpeed를 확인한다.
            double.TryParse(tbxNewSpeed.Text, out workSpeed);

            // 새로운 속도패턴으로 남은 이송 진행
            ec.ecmSxMot_OverrideSpeed(netID, axisID, ref errorCode);
            
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }
        }
    }
}
