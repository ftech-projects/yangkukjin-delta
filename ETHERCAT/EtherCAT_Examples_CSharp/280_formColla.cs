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
 
    // 충돌 방지 기능에 대한 예제
    public partial class formColla : Form
    {
        public formColla()
        {
            InitializeComponent();
            UpdateAxisList();
        }

    #region base

        int netID = 5;
        int errorCode = 0;
        byte[] axisList = new byte[32];

        private void UpdateAxisList()
        {
            cbxAxisList.Items.Clear();
            cbxAxis_Slave.Items.Clear();

            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, (byte)axisList.Length, ref errorCode);
            if (errorCode != 0) //Error 처리
                AddLog(errorCode);

            for (int i = 0; i < axisCount; i++)
            {
                cbxAxisList.Items.Add(string.Format("{0:00}", axisList[i]));
                cbxAxis_Slave.Items.Add(string.Format("{0:00}", axisList[i]));
            }
                

            if (axisCount > 1)
            {
                cbxAxisList.SelectedIndex = 0;
                cbxAxis_Slave.SelectedIndex = 1;
            }
        }

        private void cbxAxisList_SelectedIndexChanged(object sender, EventArgs e)
        {
        } 


        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

    #endregion


        int collaIndex = 0;
        int masterAxis = 0;
        int slaveAxis = 0;
        int subOrAdd = 0;
        int lessOrGreater = 0;
        double limit = 0;
        bool isEnable = false;

        private void btnEnable_Click(object sender, EventArgs e)
        {
            //collaIndex : 환경 설정 index 값. 16개의 충돌방지 기능을 설정할 수 있다. (0 ~ 15)

            // masterAxis : 충돌방지 기능을 적용할 마스터 축
            masterAxis = axisList[cbxAxisList.SelectedIndex];

            // slaveAxis : 충돌방지 기능을 적용할 슬레이브 축
            slaveAxis = axisList[cbxAxis_Slave.SelectedIndex];

            // subOrAdd : masterAxis 와 slaveAxis의 위치관계
            // 0 (sub) : sumPos = masterAxis Position - slaveAxisPosition
            // 1 (add) : sumPos = masterAxis Position + slaveAxisPosition
            // sumPos 를 limit과 비교하여 출돌 여부를 확인한다.
            subOrAdd = cbxSubOrAdd.SelectedIndex;

            // lessOrGreater : sumPos를 limit과 비교하는 방식
            // 0 (less) : sumPos < limit 이면 충돌 상태로 판단 (즉시 정지)
            // 1 (greater) : sumPos > limit 이면 충돌 상태로 판단 (즉시 정지)
            lessOrGreater = cbxLessOrGreater.SelectedIndex;

            // limit : sumPos(두 축의 위치 관계) 의 한계값
            double.TryParse(tbxLimit.Text, out limit);

            // 충돌방지 환경을 설정한다.
            ec.ecmCollA_SetEnv(netID, collaIndex, masterAxis, slaveAxis, subOrAdd, lessOrGreater, limit, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 충돌방지 기능을 활성화 한다.
            ec.ecmCollA_SetEnable(netID, collaIndex, true, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            // 충돌방지 기능을 비활성화 한다.
            ec.ecmCollA_SetEnable(netID, collaIndex, false, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }
        }


        private void UpdateForm()
        {
            //충돌방지 환경 설정을 확인한다.
            ec.ecmCollA_GetEnv(netID, collaIndex, ref masterAxis, ref slaveAxis, ref subOrAdd, ref lessOrGreater, ref limit, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            //UI 처리            
            int masterIndex = axisList.ToList().Find(x => x == masterAxis);
            cbxAxisList.SelectedIndex = masterAxis;
            int slaveIndex = axisList.ToList().Find(x => x == slaveAxis);
            cbxAxis_Slave.SelectedIndex = slaveIndex;

            cbxSubOrAdd.SelectedIndex = subOrAdd;
            cbxLessOrGreater.SelectedIndex = lessOrGreater;
            tbxLimit.Text = limit.ToString();
        }

        private void tbxIndex_TextChanged(object sender, EventArgs e)
        {
            
            if (!int.TryParse(tbxIndex.Text, out collaIndex))
                tbxIndex.Text = collaIndex.ToString();

            UpdateForm();
        }

        private void t_Colla_Tick(object sender, EventArgs e)
        {
            isEnable = ec.ecmCollA_GetEnable(netID, collaIndex, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            btnEnable.BackColor = isEnable ? SystemColors.Highlight : SystemColors.Control;
        }               
    }
}
