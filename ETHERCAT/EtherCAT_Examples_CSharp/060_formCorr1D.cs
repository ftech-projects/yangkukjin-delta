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
    public partial class formCorr1D : Form
    {
        public formCorr1D()
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            // 파일에서 TableData를 불러온다.            
            string filePath = @"C:\test.txt";

            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("File not exist");
                return;
            }
            ec.ecmSxCfg_PosCorr_ClearTable(netID, axisID, ref errorCode);
            if (errorCode != 0) 
            {
                AddLog(errorCode);
                return;
            }
            ec.ecmSxCfg_PosCorr_SetTableFromFile(netID, axisID, filePath, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }

            // Table 적용 여부 확인용, 본 코드와 무관
            double refCmdPos = 0;
            double refActPos = 0;
            ec.ecmSxCfg_PosCorr_GetTableData(netID, axisID, 0, ref refCmdPos, ref refActPos, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Table이 비어있을때 enable을 하면, 에러는 리턴되지 않지만, enable도 되지 않는다.
            // 반드시 table을 먼저 만들고 enable을 해줘야 함
            ec.ecmSxCfg_PosCorr_SetEnable(netID, axisID, true, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }
            bool isEnable = ec.ecmSxCfg_PosCorr_GetEnable(netID, axisID, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ec.ecmSxCfg_PosCorr_SetEnable(netID, axisID, false, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }
            bool isEnable = ec.ecmSxCfg_PosCorr_GetEnable(netID, axisID, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            ec.ecmSxCfg_PosCorr_ClearTable(netID, axisID, ref errorCode);
        }
    }
}
