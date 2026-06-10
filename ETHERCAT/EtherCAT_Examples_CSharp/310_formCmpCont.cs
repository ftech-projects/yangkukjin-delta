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
    public partial class formCmpCont : Form
    {
        // 마스터보드에서 지원하는 CMP (위치 비교 트리거 출력) 중 연속 출력에 대한 기능이다.
        public formCmpCont()
        {
            InitializeComponent();

            // DeviceLoad 전이면 DeviceLoad를 먼저 실행한다.
            int devIndex = 0;
            if (!ec.ecGn_IsDevLoaded(devIndex, ref errorCode))
                if (!ec.ecGn_LoadDevice(ref errorCode))
                    AddLog(string.Format("DeviceLoad Failed : {0}", errorCode));

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
                cbxAxisList.SelectedIndex = 0;

            // DO 전역채널 수를 확인한다.
            int doChCount = ec.ecdoGetNumChannels(netID, ref errorCode);
            for (int i = 0; i < doChCount; i++)
                cbxOut_Global.Items.Add(string.Format("Ch {0:00}", i));

            cbxOut_OnBoard.SelectedIndex = 0;

            if (doChCount > 0)
            {
                cbxOut_Global.SelectedIndex = 0;
            }
            else
            {
                rdoOut_Global.Enabled = false;
                cbxOut_Global.Enabled = false;
            }
        }

        private void cbxAxisList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int axisIndex = cbxAxisList.SelectedIndex;
            axisID = axisList[axisIndex];                        
            
            UpdateCmp();
        }

        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

        void AddLog(string errorString)
        {
            MessageBox.Show(errorString);
        }


        #region CMP_UI

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double pos = 0;
            if (double.TryParse(tbxPosition.Text, out pos))
                lbxPosition.Items.Add(pos.ToString());

            tbxPosition.Text = string.Empty;
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbxPosition.Items.RemoveAt(lbxPosition.SelectedIndex);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxPosition.Items.Clear();
        }


        private void btnAddList_Click(object sender, EventArgs e)
        {
            lbxPosition.Items.Clear();

            for (int i = 1; i < 10; i++)
                lbxPosition.Items.Add((i * 10000).ToString());
        }


        private void rdoOut_OnBoard_CheckedChanged(object sender, EventArgs e)
        {
            cbxOut_OnBoard.Enabled = true;
            cbxOut_Global.Enabled = false;
        }

        private void rdoOut_Global_CheckedChanged(object sender, EventArgs e)
        {
            cbxOut_OnBoard.Enabled = false;
            cbxOut_Global.Enabled = true;
        }

        #endregion


        #region CMP_Continuous

        uint logBitAddr = 0; // 출력 채널에 대한 LogicBitAddress
        int method = 0; // CMP 출력 조건. 상세 내용은 cbxMethods의 items 참조
        int cntrType = 0; // CMP 위치 조건. 0 : Command / 1 : Feedback
        int logic = 0; // CMP 출력 로직.  0 : Logic A / 1 : Logic B
        int duration = 10; // CMP 출력 유지 시간. 단위 ms. 

        double cmpPosition = 0;
        

        private void btnCmpContStart_Click(object sender, EventArgs e)
        {
            if (lbxPosition.Items.Count == 0)
                return;

            // 출력 환경 및 조건을 설정한다.
            SetCondition();

            method = cbxMethod.SelectedIndex; // CMP 출력 조건
            cntrType = cbxCntrType.SelectedIndex; // CMP 위치 조건. Command / Feedback
                        
            int cmpCount = lbxPosition.Items.Count;

            // PositionData를 파일에서 불러오는 방식도 있으니 참고하자.
            // 본 예제는 테이블에 하나씩 등록하는 방식이다.

            // 포지션을 등록할 테이블 크기를 설정한다.
            ec.ecmSxCmpCont_SetTableSize(netID, axisID, cmpCount, ref errorCode);

            for (int i = 0; i < cmpCount; i++)
            {
                // 위치 및 출력 조건을 설정한다.
                // 각각의 테이블에 대해 조건을 달리할 수 있다.
                cmpPosition = Convert.ToDouble(lbxPosition.Items[i]);
                ec.ecmSxCmpCont_SetTableData(netID, axisID, i, cntrType, method, cmpPosition, ref errorCode);
            }

            // 시작시 등록할 Position이다. 0이면 첫번째 등록된 Position
            ec.ecmSxCmpCont_SetActTblIdx(netID, axisID, 0, ref errorCode);
            
            // CMP 기능 활성화
            bool isEnable = true;
            ec.ecmSxCmpCont_SetEnable(netID, axisID, isEnable, ref errorCode);
        }


        private void SetCondition()
        {
            // CMP 출력 채널을 확인하여 LogicBitAddress로 변환
            // Local 채널도 사용 가능하지만, 본 예제에서는 다루지 않는다.
            if (rdoOut_Global.Checked) // 범용 Output 채널 사용 시
            {
                int ch = cbxOut_Global.SelectedIndex;
                logBitAddr = ec.ecdoLogBitAddr_FromGlobalChannel(netID, ch, ref errorCode);
                if (errorCode != 0) // 에러처리
                {
                    AddLog(string.Format("ecdoLogBitAddr_FromGlobalChannel failed. errorCode : {0}", errorCode));
                    return;
                }
            }
            else // OnBoard(마스터 보드) DO 사용 시
            {
                int ch = cbxOut_OnBoard.SelectedIndex;
                logBitAddr = ec.ecdoLogBitAddr_FromOnboardChannel(netID, ch, ref errorCode);
                if (errorCode != 0) // 에러처리
                {
                    AddLog(string.Format("ecdoLogBitAddr_FromOnboardChannel failed. errorCode : {0}", errorCode));
                    return;
                }
            }

            // 이전 출력 결과를 초기화한다.
            ec.ecmSxCmpCont_ClearOutResult(netID, axisID, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(string.Format("ecmSxCmpCont_ClearOutResult failed. errorCode : {0}", errorCode));
                return;
            }

            logic = cbxLogic.SelectedIndex; // CMP 출력 로직. 
            duration = Convert.ToInt32(tbxDuration.Text); // CMP 출력 유지 시간. 단위 ms.             

            // CMP 출력채널 정보를 설정한다.
            ec.ecmSxCmpCont_SetChannel(netID, axisID, logBitAddr, logic, duration, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(string.Format("ecmSxCmpCont_SetChannel failed. errorCode : {0}", errorCode));
                return;
            }
        }


        private void btnCmpContStop_Click(object sender, EventArgs e)
        {
            // CMP 기능 비활성화
            bool isEnable = false;
            ec.ecmSxCmpCont_SetEnable(netID, axisID, isEnable, ref errorCode);
        }


        private void UpdateCmp()
        {
            // 채널 관련 정보를 확인한다.
            ec.ecmSxCmpCont_GetChannel(netID, axisID, ref logBitAddr, ref logic, ref duration, ref errorCode);

            // UI 처리            
            if (rdoOut_Global.Checked) // Global Ch 사용 시
            {
                // LogicBitAddress 를 Global Channel 로 변경한다.
                int ch = ec.ecdiLogBitAddr_ToGlobalChannel(netID, logBitAddr, ref errorCode);
                cbxOut_Global.SelectedIndex = ch;
            }
            else // OnBoard DO 사용 시
            {
                int ch = ec.ecdiLogBitAddr_ToOnboardChannel(netID, logBitAddr, ref errorCode);
                cbxOut_OnBoard.SelectedIndex = ch;
            }

            cbxLogic.SelectedIndex = logic;

            // 출력 조건을 확인한다. UI 처리용으로 첫번째 테이블에 입력된 값에 대한 설정을 불러온다.
            ec.ecmSxCmpCont_GetTableData(netID, axisID, 0, ref cntrType, ref method, ref cmpPosition, ref errorCode);

            // UI 처리            
            cbxCntrType.SelectedIndex = cntrType;
            cbxMethod.SelectedIndex = method;
            tbxDuration.Text = duration.ToString();
        }

        private void t_CMP_Tick(object sender, EventArgs e)
        {
            GetOutResult();

            // CMP 활성화 여부를 확인한다.
            bool isEnable = ec.ecmSxCmpCont_GetEnable(netID, axisID, ref errorCode);
            btnCmpContStart.BackColor = isEnable ? Color.DarkOrange : Color.Transparent;
        }

        private void GetOutResult()
        {
            // CMP 출력 결과를 확인한다.

            int outCount = 0; //outCount : 출력된 트리거 수
            double outPos = 0;  // lastOutPos : 마지막 출력된 위치
            ec.ecmSxCmpCont_GetOutResult(netID, axisID, ref outCount, ref outPos, ref errorCode);

            lblOutCount.Text = outCount.ToString();
            lblOutPosition.Text = outPos.ToString();

            // 출력 채널의 출력상태를 확인한다.
            bool isOn = ec.ecmSxCmpCont_GetOutputState(netID, axisID, ref errorCode);
            lblOutState.BackColor = isOn ? Color.DarkOrange : Color.Transparent;
        }
        
        #endregion


        private void btnCmpMove_Click(object sender, EventArgs e)
        {
            double dist = 0;
            double.TryParse(tbxCmpDist.Text, out dist);
            ec.ecmSxMot_MoveStart(netID, axisID, dist, ref errorCode);
        }

        private void btnManualTrg_Click(object sender, EventArgs e)
        {
            SetCondition();

            // 트리거 신호를 수동 출력한다. 
            // OnBoard 채널에만 적용된다.
            // OutSigLogic, OutSignalOnTime 값을 반영하므로, CMP 기능이 활성화 된 상황에서 사용한다.
            ec.ecmSxCmpCont_ManualTrgOut(netID, axisID, ref errorCode);
            GetOutResult();
        }

        private void btnStateToggle_Click(object sender, EventArgs e)
        {
            // CMP Output 채널의 출력 상태를 확인한다.
            // OnBoard 채널에만 적용된다.
            bool isOn = ec.ecmSxCmpCont_GetOutputState(netID, axisID, ref errorCode);

            // CMP Output 채널의 출력 상태를 설정한다.
            // ecmSxCmpCont_SetOutputState() 함수는 CMP가 비활성화 된 상태에서만 설정 가능하다.
            // OutSigLogic, OutSignalOnTime 등이 설정되지 않아도 된다는 점에서 ecmSxCmpCont_ManualTrgOut() 함수와 차이가 있다.
            isOn = !isOn;
            ec.ecmSxCmpCont_SetOutputState(netID, axisID, isOn, ref errorCode);
        }

        

    }
}
