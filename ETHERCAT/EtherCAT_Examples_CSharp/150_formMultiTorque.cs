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
    public partial class formMultiTorque : Form
    {
        // MultiTorque 예제. 다음의 과정으로 진행된다.
        // 기준 축 (Ref Axis)과 위치와 제어축 (Target Axis)의 목표 토크를 리스트로 등록
        // 기능 시작 시 제어축은 Initial Torque로 토크 제어
        // 기준 축 이송 시 정해진 위치 조건이 충족되면 제어축의 토크가 리스트로 등록 된 토크로 변경
        // 기능 정지 시 제어축은 Stop Torque로 변경

        public formMultiTorque()
        {
            InitializeComponent();
            lvwItem.SmallImageList = new ImageList() { ImageSize = new Size(1, 25) };

            UpdateAxisList();
        }

    #region base

        int netID = 5;
        int errorCode = 0;
        byte[] axisList = new byte[32];

        private void UpdateAxisList()
        {
            cbxRefAxis.Items.Clear();

            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, (byte)axisList.Length, ref errorCode);
            if (errorCode != 0) //Error 처리
                AddLog(errorCode);

            for (int i = 0; i < axisCount; i++)
            {
                cbxRefAxis.Items.Add(string.Format("{0:00}", axisList[i]));
                cbxTargetAxis.Items.Add(string.Format("{0:00}", axisList[i]));
            }                

            if (axisCount > 0)
                cbxRefAxis.SelectedIndex = 0;

            if (axisCount > 1)
                cbxTargetAxis.SelectedIndex = 0;
        }


        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

    #endregion


        int targetAxis = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // NextTorqList[] 를 구성하는 항목
            // ListView에 UI로 표시한 후 Start 시 TEcmMTQ1Item 항목으로 등록

            double pos = 0;
            short torq = 0; 
            double.TryParse(tbxRefPos.Text, out pos);
            short.TryParse(tbxTargetTorq.Text, out torq);

            var item = new ListViewItem(pos.ToString());
            item.SubItems.Add(torq.ToString());

            lvwItem.Items.Add(item);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            lvwItem.Items.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {   
            // 기준 축 : Ref Axis
            // 기준 축의 위치를 조건으로 제어축의 토크가 변경된다.
            int refAxisIndex = cbxRefAxis.SelectedIndex;            
            int refAxisID = axisList[refAxisIndex];

            // 제어 축 : 토크 제어를 위한 축이다.
            int targetAxisIndex = cbxTargetAxis.SelectedIndex;
            targetAxis = axisList[targetAxisIndex];

            // Init Torque : 기능 시작 시 제어축의 토크 출력 값
            short initTorq = 0;
            short.TryParse(tbxInitTorq.Text, out initTorq);

            // 조건 만족을 판단하는 방법. 기준 축의 위치가 이 조건을 만족하면 제어축의 토크가 변경된다.
            // 이 값에 적용 가능한 값의 종류는 다음과 같다.
            // 0 : LT (Target Pos < Ref Pos)
            // 1 : GT (Target Pos > Ref Pos)
            // 2 : LE (Target Pos <= Ref Pos)
            // 3 : GE (Target Pos >= Ref Pos)

            int cmpMode = cbxCmpMode.SelectedIndex;

            // 리스트의 아이템은 TEcmMTQ1Item 구조체로 등록된다.
            // 각 아이템의 세부 항목들은 모두 다른 값으로 설정 가능하나, 본 예제에서는 position과 torque만 변경한다.
            // 출력 토크의 단위는 0.1%
            List<ec.TEcmMTQ1Item> items = new List<ec.TEcmMTQ1Item>();
            for (int i = 0; i < lvwItem.Items.Count; i++)
            {
                var item = new ec.TEcmMTQ1Item();
                item.RefAxis = (ushort)refAxisID;
                item.RefCmpMode = cmpMode;
                
                double.TryParse(lvwItem.Items[i].SubItems[0].Text, out item.RefPos);
                short.TryParse(lvwItem.Items[i].SubItems[1].Text, out item.TorqVal);

                items.Add(item);
            }

            ec.ecmSxMulTorq1_Start(netID, targetAxis, initTorq, items.ToArray(), (ushort)items.Count, ref errorCode);
            if(errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // stop Torque : 기능 정지 시 제어축의 토크 출력 값
            short stopTorq = 0;
            short.TryParse(tbxInitTorq.Text, out stopTorq);
            
            // Stop Torque 적용 여부
            // 미적용 시 마지막 토크값이 유지된다.
            bool isApplyStopTorquie = true;
            ec.ecmSxMulTorq1_Stop(netID, targetAxis, stopTorq, isApplyStopTorquie, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
            }
        }
    }
}
