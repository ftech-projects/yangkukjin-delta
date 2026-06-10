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
    public partial class formIxLine : Form
    {
        public formIxLine()
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

            cbxSpeedType.SelectedIndex = 1;
            cbxSpeedMode.SelectedIndex = 2;
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

        int ixMapIndex = 0;
        List<int> ixAxisList = new List<int>();        
        List<double> ixDistList = new List<double>();
            
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double dist = 0;
            double.TryParse(tbxDist.Text, out dist);

            // axisID 가 아직 등록되지 않은 경우 axisID와 Distance를 추가한다
            if (!ixAxisList.Exists(x => x == axisID)) 
            {
                ixAxisList.Add(axisID);
                ixDistList.Add(dist);
                lvwItem.Items.Add(new ListViewItem(new string[] { axisID.ToString(), dist.ToString() }));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ixAxisList.Clear();
            ixDistList.Clear();            
            lvwItem.Items.Clear();
        }

        private void btnMoveStart_Click(object sender, EventArgs e)
        {
            //보간에 포함되는 축 리스트를 설정한다.                        
            ec.ecmIxCfg_MapAxes(netID, ixMapIndex, ixAxisList.Count, ixAxisList.ToArray(), ref errorCode);

            //보간 속도를 설정한다.
            IxSetSpeed(ixMapIndex);


            // 각 축이 현재 위치에서 정해진 거리만큼 이송한다
            // 모든 축의 시작시점과 종료시점이 동기화 되어, 동시에 출발하고, 동시에 완료된다.
            // 각 축의 속도는 SpeedType에 따라 자동 조정된다.
            // 자세한 내용은 ecmIxCfg_SetSpeedPatt 함수 매뉴얼 참조
            
            ec.ecmIxMot_LineStart(netID, ixMapIndex, ixDistList.ToArray(), ref errorCode);
            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }

            ec.ecmIxSt_WaitCompt(netID, ixMapIndex, ref errorCode);
            //WaitCompt 명령 실행 시 이송에 포함된 모든 축이 정지할 때까지 기다린다.
        }

        
        private void btnMoveToStart_Click(object sender, EventArgs e)
        {
            //보간에 포함되는 축 리스트를 설정한다.            
            
            ec.ecmIxCfg_MapAxes(netID, ixMapIndex, ixAxisList.Count, ixAxisList.ToArray(), ref errorCode);

            //보간 속도를 설정한다.
            IxSetSpeed(ixMapIndex);


            // 각 축이 현재 위치에서 정해진 위치로 이송한다 (본 예제에서는 ixDistList 값을 위치값으로 간주한다)
            // 모든 축의 시작시점과 종료시점이 동기화 되어, 동시에 출발하고, 동시에 완료된다.
            // 각 축의 속도는 SpeedType에 따라 자동 조정된다.
            // 자세한 내용은 ecmIxCfg_SetSpeedPatt 함수 매뉴얼 참조

            ec.ecmIxMot_LineToStart(netID, ixMapIndex, ixDistList.ToArray(), ref errorCode);
            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }

            // Thread를 이용한 처리
            Thread thIsAbsDone = new Thread(new ThreadStart(() =>
            {
                while (ec.ecmIxSt_IsBusy(netID, ixMapIndex, ref errorCode))
                {
                    Thread.Sleep(100);
                }
            }));
            thIsAbsDone.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ec.ecmIxMot_Stop(netID, ixMapIndex, 1, 1, ref errorCode);
            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }
        }

        private void IxSetSpeed(int ixMapIndex)
        {
            // 속도는 해당 함수가 적용되기 전에는 이전 값이 적용된다.
            // 즉 명시적으로 속도를 변경하지 않으면 한번 설정한 속도가 계속 유지되므로,
            // 이송시마다 속도 설정을 할 필요는 없다.

            int speedType = cbxSpeedType.SelectedIndex;
            int speedMode = cbxSpeedMode.SelectedIndex;
            double init = 0, end = 0, work = 0, accel = 0, decel = 0, jerk = 0;

            double.TryParse(tbxInit.Text, out init);
            double.TryParse(tbxEnd.Text, out end);
            double.TryParse(tbxWork.Text, out work);
            double.TryParse(tbxAccel.Text, out accel);
            double.TryParse(tbxDecel.Text, out decel);
            double.TryParse(tbxJerk.Text, out jerk);

            ec.ecmIxCfg_SetSpeedPatt(netID, ixMapIndex, speedType, speedMode, init, end, work, accel, decel, ref errorCode);
            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }

            // Jerk 미설정 시 0.66이 기본으로 설정된다.            
            ec.ecmIxCfg_SetJerkRatio(netID, ixMapIndex, jerk, ref errorCode);
            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }
        }
    }
}
