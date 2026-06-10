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
    public partial class formTouchProbe : Form
    {
        // 터치프로브는 일부 서보 드라이버에서 제공하는 기능으로,
        // 터치프로브 센서 또는 Index Pulse(Z상) 입력 시의 위치를 래치하는 기능
        public formTouchProbe()
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

        // TouchProbe Index 
        // 일반적으로 드라이버당 2개의 ToubhProbe 가 제공된다.
        byte tpIndex = 0;
        byte[] tpFunc = new byte[2];
        bool isEnable = false;

        private void UpdateForm()
        {
            // CiA402 프로파일의 0x60B8 오브젝트에 해당하는 터치프로브 기능 설정값,
            // 0x60B8 오브젝트는 2바이트 값으로 2채널의 터치프로브 속성을 정의 / 확인하지만,
            // ecmSxCfg_GetTouchProbeFunc() 함수는 tpIndex로 설정 된 터치프로브 채널에 대해 1바이트 값으로 속성을 확인
                        
            tpFunc[tpIndex] = ec.ecmSxCfg_GetTouchProbeFunc(netID, axisID, tpIndex, ref errorCode);

            // 각 비트의 의미는 드라이버 별로 다를 수 있으나 일반적으로 다음의 의미를 
            // Bit_0 : TouchProbe Enable
            // Bit_1 : EventMode (0 : Single / 1 : Continuous)
            // Bit_2 : TirggerSignal (0 : TouchProbe Signal / 1 : Encoder Z-Pulse)
            // Bit_4 ~ Bit_7 : Edge (0 : Undefined / 1 : Falling / 2 : Rising) // 파나소닉

            //터치프로브 기능의 활성화 여부를 확인한다.
            isEnable = (tpFunc[tpIndex] & 1) == 1;

            // EventMode를 확인한다.
            cbxEventMode.SelectedIndex = (tpFunc[tpIndex] >> 1) & 1;

            // TirggerSignal을 확인한다.
            cbxTriggerSignal.SelectedIndex = (tpFunc[tpIndex] >> 2) & 1;

            // Edge를 확인한다.
            // 지원하지 않는 드라이버도 있다.
            cbxEdge.SelectedIndex = (tpFunc[tpIndex] >> 4) & 3;            
        }

        private void cbxTpIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            tpIndex = (byte)cbxTpIndex.SelectedIndex;
            UpdateForm();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // 선택된 축이 TouchProbe 기능을 지원하는지 확인한다.
            // axisInPDOType == 0 이면, PDO Data에 터치프로브 관련 오브젝트가 빠진 경우이다.
            // https://winoar.com/dokuwiki/platform:ethercat:2_config:guide:processdata 참조
            
            int axisInPDOType = ec.ecmSxCfg_GetMioProp(netID, axisID, ec.EEcmMioPropId.ecmMPID_INPUTPDO_TYPE, ref errorCode);
            if(axisInPDOType == 0)
            {
                MessageBox.Show("터치프로브 관련 오브젝트가 ProcessData에 포함되어 있는지 확인하세요.");
                return;
            }

            int eventMode = cbxEventMode.SelectedIndex;
            int triggerSignal = cbxTriggerSignal.SelectedIndex;
            int triggerEdge = cbxEdge.SelectedIndex;

            tpFunc[tpIndex] |= (1 << 0);
            tpFunc[tpIndex] |= (byte)(eventMode << 1);
            tpFunc[tpIndex] |= (byte)(triggerSignal << 2);
            tpFunc[tpIndex] |= (byte)(1 << (3 + triggerEdge));

            // 터치프로브 기능을 설정한다.
            ec.ecmSxCfg_SetTouchProbeFunc(netID, axisID, tpIndex, tpFunc[tpIndex], ref errorCode);
            if(errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            tpFunc[tpIndex] = 0;

            // 터치프로브 기능을 설정한다.
            ec.ecmSxCfg_SetTouchProbeFunc(netID, axisID, tpIndex, tpFunc[tpIndex], ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
            }
        }


        bool RisingEdgeReset = false;
        bool FallingEdgeReset = false;
        double tpPosition_prv = 0;
        private void t_TP_Tick(object sender, EventArgs e)
        {
            // 터치프로브 입력 상태를 확인한다.
            // tpState의 각 비트의 의미는 다음과 같다.
            // Bit_0 : TouchProbe enable (0 : Stop / 1 : enable)
            // Bit_1 : Positive(rising) edge value stored (0 : no / 1 : stored)
            // Bit_2 : Negative(falling) edge value stored (0 : no / 1 : stored)
            int tpState = ec.ecmSxSt_GetTouchProbeSts(netID, axisID, tpIndex, ref errorCode);

            isEnable = (tpState & 1) == 1;
            btnStart.BackColor = isEnable ? SystemColors.Highlight : SystemColors.Control;

            // RisingEdge 감지 여부를 확인한다.
            // 본 예제에서는 해당값이 0으로 바뀐 후 최초 트리거 되는 시점만 로깅한다.

            if (((tpState >> 1) & 1) == 0)
                RisingEdgeReset = true;
            else if (RisingEdgeReset) 
                lbxMonitor.Items.Add(string.Format("{0} RisingEdgeStored", GetDateTime()));

            // FallingEdge 감지 여부를 확인한다.
            if (((tpState >> 2) & 1) == 0)
                FallingEdgeReset = true;
            else if (FallingEdgeReset)
                lbxMonitor.Items.Add(string.Format("{0} FallingEdgeStored", GetDateTime()));
            
            // Edge가 감지된 시점의 위치를 확인한다.
            double tpPosition = ec.ecmSxSt_GetTouchProbePos(netID, axisID, tpIndex, ref errorCode);
            if (tpPosition != tpPosition_prv)
            {
                lbxMonitor.Items.Add(string.Format("{0} Position : {1}", GetDateTime(), tpPosition));
                tpPosition_prv = tpPosition;
            }

            lbxMonitor.SelectedIndex = lbxMonitor.Items.Count - 1;
        }

        public string GetDateTime()
        {
            DateTime NowDate = DateTime.Now;
            string time = string.Format("[{0}:{1:000}]", NowDate.ToString("hh:mm:ss"), NowDate.Millisecond);
            return time;
        }
    }
}
