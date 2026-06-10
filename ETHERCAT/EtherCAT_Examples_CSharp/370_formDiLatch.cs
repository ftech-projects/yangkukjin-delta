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
    // 래치모드 활성화시 마스터는 지속적으로 해당 채널을 감시하여 OFF에서 ON으로 바뀐 횟수를 기록한다.
    // 따라서 본 기능은 유저가 채널에 대한 감시 없이 특정 시점에 신호가 들어온 횟수를 카운트 할때 사용한다.
    // 다른 IO 함수군과 마찬가지로, Global Channel 함수군과 Local Channel 함수군을 함께 제공하며, 
    // 본 예제에서는 Local Channel 예제만 다룬다.

    public partial class formDiLatch : Form
    {
        public formDiLatch()
        {
            InitializeComponent();
        }

    #region base

        int netID = 5;
        int errorCode = 0;
       

        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

    #endregion


        ushort slaveAddr = 0;
        int localCh = 0;
        bool isInvertLogic = false;
        int filterCycle = 0;


        private void btnStart_Click(object sender, EventArgs e)
        {
            ushort.TryParse(tbxSlaveAddr.Text, out slaveAddr);
            int.TryParse(tbxLocalCh.Text, out localCh);
            isInvertLogic = cbxInvertLogic.SelectedIndex == 1;
            int.TryParse(tbxFilterCycle.Text, out filterCycle);
                       

            // 노이즈와 같은 잘못된 신호 입력을 필터링 하기 위해 Filter를 설정한다.
            // 마스터는 filterCycle 이하의 유지시간 동안만 신호가 유지되면 ON으로 인식하지 않는다.
            // e) filterCycle == 1 일때, 통신주기(Cycle)가 1ms 라면, 2ms 이상 (2 Cycle) 동안 ON 신호가 유지되어야 래치 카운트가 1 증가한다.
            // 이 값을 0으로 하면 필터는 적용되지 않는다.
            // 래치모드로 새로 등록되면 filterCycle 은 0으로 초기화된다.
            ec.ecdiLtc_SetFilter_L(netID, slaveAddr, localCh, filterCycle, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 래치 입력 로직의 반전 속성을 설정한다.
            // 해당값이 true일 경우, 입력 신호 값이 ON → OFF가 될 때 래치 카운트도 증가한다.
            
            ec.ecdiLtc_SetLogicInvert_L(netID, slaveAddr, localCh, isInvertLogic, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 지정한 채널의 래치 카운트 값을 0으로 리셋한다.
            // 특히, 입력 신호가 OFF인 상태에서 IsInverLogic이 true로 적용되면 그 순간 래치카운트가 1 증가할 수 있으므로, 클리어 해주는 것이 좋다.
            
            ec.ecdiLtc_ResetOnCount_L(netID, slaveAddr, localCh, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 감시할 채널을 등록한다. 등록되면 바로 감시가 시작된다.
            // 감시할 채널은 여러개 등록이 가능하며, 본 예제에서는 하나의 채널만 감시한다.
            ec.ecdiLtc_AddChannel_L(netID, slaveAddr, localCh, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            t_DiLatch.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ushort.TryParse(tbxSlaveAddr.Text, out slaveAddr);
            int.TryParse(tbxLocalCh.Text, out localCh);

            // 래치 모드로 등록된 채널을 감시 대상 리스트에서 제거한다.
            // 프로그램이 종료될때도 감시 대상 리스트는 초기화된다.
            ec.ecdiLtc_DelChannel_L(netID, slaveAddr, localCh, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            t_DiLatch.Stop();
        }

        private void t_DiLatch_Tick(object sender, EventArgs e)
        {
            ushort.TryParse(tbxSlaveAddr.Text, out slaveAddr);
            int.TryParse(tbxLocalCh.Text, out localCh);

            // isResetOnCount : 래치 카운트를 읽은 후 마스터에서 관리하는 래치 카운트를 0으로 초기화할 것인지 설정하는 파라미터
            bool isResetOnCount = false;
            int latchCount = ec.ecdiLtc_GetOnCount_L(netID, slaveAddr, localCh, isResetOnCount, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            tbxLatchCount.Text = latchCount.ToString();
        }

        private void UpdateForm()
        {
            ushort.TryParse(tbxSlaveAddr.Text, out slaveAddr);
            int.TryParse(tbxLocalCh.Text, out localCh);

            // 현재 설정되어 있는 래치 모드 필터의 사이클 카운트값을 확인한다.
            filterCycle = ec.ecdiLtc_GetFilter_L(netID, slaveAddr, localCh, ref errorCode);

            // 현재 설정되어 있는 입력 신호 반전 여부를 확인한다.
            isInvertLogic = ec.ecdiLtc_GetLogicInvert_L(netID, slaveAddr, localCh, ref errorCode);
                        
            tbxFilterCycle.Text = filterCycle.ToString();
            cbxInvertLogic.SelectedIndex = isInvertLogic ? 1 : 0;
        }

        private void tbxSlaveAddr_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void tbxLocalCh_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
