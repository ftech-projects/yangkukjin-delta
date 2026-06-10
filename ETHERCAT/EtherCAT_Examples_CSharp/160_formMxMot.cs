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
    public partial class formMxMot : Form
    {
        public formMxMot()
        {
            InitializeComponent();

            lvwItem.SmallImageList = new ImageList() { ImageSize = new Size(1, 25) };

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
                cbxAxisList.Items.Add(string.Format("{0:00}", axisList[i]));

            if (axisCount > 0)
                cbxAxisList.SelectedIndex = 0;
        }

        private void cbxAxisList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int axisIndex = cbxAxisList.SelectedIndex;
            axisID = axisList[axisIndex];
        }

        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }


        List<int> mxAxisList = new List<int>();
        List<int> mxDirList = new List<int>();
        List<double> mxDistList = new List<double>();
            
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double dist = 0;
            double.TryParse(tbxDist.Text, out dist);

            // axisID 가 아직 등록되지 않은 경우 axisID와 Distance를 추가한다
            if (!mxAxisList.Exists(x => x == axisID)) 
            {
                mxAxisList.Add(axisID);
                mxDistList.Add(dist);
                lvwItem.Items.Add(new ListViewItem(axisID.ToString(), dist.ToString()));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mxAxisList.Clear();
            mxDistList.Clear();            
            lvwItem.Items.Clear();
        }

        private void btnMoveN_Click(object sender, EventArgs e)
        {
            // MxStop 명령이 수행될때까지 이송한다.
            // 각 축의 속도는 별도로 설정 가능하지만 본 예제에서는 생략한다.            
            // 각 축의 방향은 설정가능하지만 해당 함수에서는 모두 (-) 방향으로 이송한다.
            mxDirList.Clear();
            mxAxisList.ForEach(x=> mxDirList.Add(0));

            ec.ecmMxMot_VMoveStart(netID, mxAxisList.Count, mxAxisList.ToArray(), mxDirList.ToArray(), ref errorCode);
            if (errorCode != 0) 
            {
                //에러처리
                AddLog(errorCode);
            }
        }

        private void btnVMoveP_Click(object sender, EventArgs e)
        {
            // MxStop 명령이 수행될때까지 이송한다.
            // 각 축의 속도는 별도로 설정 가능하지만 본 예제에서는 생략한다.            
            // 각 축의 방향은 설정가능하지만 해당 함수에서는 모두 (+) 방향으로 이송한다.

            mxDirList.Clear();
            mxAxisList.ForEach(x => mxDirList.Add(1));

            ec.ecmMxMot_VMoveStart(netID, mxAxisList.Count, mxAxisList.ToArray(), mxDirList.ToArray(), ref errorCode);
            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }
        }

        private void btnMoveStart_Click(object sender, EventArgs e)
        {
            // 각 축이 현재 위치에서 정해진 거리만큼 이송한다
            // Start 만 동기화되며, 각 축의 속도와 이송 거리에 따라 정지 시점은 달라진다.
            ec.ecmMxMot_MoveStart(netID, mxAxisList.Count, mxAxisList.ToArray(), mxDistList.ToArray(), ref errorCode);
            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }

            ec.ecmMxSt_WaitCompt(netID, mxAxisList.Count, mxAxisList.ToArray(), ref errorCode);
            //WaitCompt 명령 실행 시 이송에 포함된 모든 축이 정지할 때까지 기다린다.
        }

        private void btnMoveToStart_Click(object sender, EventArgs e)
        {
            // 각 축이 현재 위치에서 정해진 위치로 이송한다 (mxDistList 값은 각 축의 position)
            // Start 만 동기화되며, 각 축의 속도와 이송 거리에 따라 정지 시점은 달라진다.
            ec.ecmMxMot_MoveToStart(netID, mxAxisList.Count, mxAxisList.ToArray(), mxDistList.ToArray(), ref errorCode);
            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }

            // Thread를 이용한 처리
            Thread thIsAbsDone = new Thread(new ThreadStart(() =>
            {
                while (ec.ecmMxSt_IsBusy(netID, mxAxisList.Count, mxAxisList.ToArray(), ref errorCode))
                {
                    Thread.Sleep(100);
                }
            }));
            thIsAbsDone.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ec.ecmMxMot_Stop(netID, mxAxisList.Count, mxAxisList.ToArray(), 1, 1, ref errorCode);
        }
    }
}
