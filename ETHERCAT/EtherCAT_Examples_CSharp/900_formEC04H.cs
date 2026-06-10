using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

using ec = ComiLib.EtherCAT.SafeNativeMethods;
using ComiLib.EtherCAT.Slave;

namespace EtherCAT_Examples_CSharp
{
    public partial class formEC04H : Form
    {
        public formEC04H()
        {
            InitializeComponent();
        }

        int netID = 5;
        int errorCode = 0;

        void AddLog(int errorCode)
        {
            if (errorCode != 0)
                MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

        IntPtr inPdoPtr = IntPtr.Zero;
        IntPtr outPdoPtr = IntPtr.Zero;
        int outPdoSize = 0;

        private ETS_EC04H.InPDO inPDO = new ETS_EC04H.InPDO();
        private ETS_EC04H.OutPDO outPDO = new ETS_EC04H.OutPDO();

        ushort slaveAddr = 0x0;
        bool isValid = false;
        const int chCount = 4;
        
        bool isExist_EC04H = false;

        int counterIndex = 0;
        bool isCounterInfoUpdate = false;
        private int counterCh = 0;



        private void Init_EC04H()
        {
            // EC04H 모듈의 존재 여부와 SlavePhysAddress를 확인하는 코드이다.
            // 예제를 위한 코드이며, 하나의 모듈만 체크한다.
            uint slaveCount = ec.ecNet_ScanSlaves(netID, ref errorCode);
            for (int s = 0; s < slaveCount; s++)
            {
                ec.TEcSlaveCfg slaveCfg = new ec.TEcSlaveCfg();
                ec.ecCfg_GetSlaveConfig(netID, s, ref slaveCfg, ref errorCode);
                if (slaveCfg.ProdCode == 0x5032D5C4)
                {
                    isExist_EC04H = true;
                    slaveAddr = slaveCfg.PhysAddr;
                    break;
                }
            }

            for (int i = 0; i < 10; i++)
                dgvCmp.Rows.Add(new string[] { string.Format("{0}", i), "0" });

            if (!isExist_EC04H)
                return;

            inPDO.InPDOs = new ComiLib.EtherCAT.Slave.EC04H_InPDO[4];
            outPDO.OutPDOs = new ComiLib.EtherCAT.Slave.EC04H_OutPDO[4];

            for (int i = 0; i < 4; i++)
                outPDO.OutPDOs[i].CMP_Couter = new int[10];

            //InPDO Data의 시작위치를 확인한다
            inPdoPtr = ec.ecSlv_InPDO_GetBufPtr(netID, slaveAddr, 0, ref errorCode);

            //OutPDO Data의 시작위치를 확인한다
            outPdoPtr = ec.ecSlv_OutPDO_GetBufPtr(netID, slaveAddr, 0, ref errorCode);
            outPdoSize = Marshal.SizeOf(typeof(ETS_EC04H.OutPDO));
        }

        private void t_EC04H_Tick(object sender, EventArgs e)
        {
            //InPDO Data를 시작위치를 기준으로 구조체로 변경하여 가져온다.
            inPDO = (ETS_EC04H.InPDO)(Marshal.PtrToStructure(inPdoPtr, typeof(ETS_EC04H.InPDO)));

            // 구조체의 Data를 확인하여 Counter 관련 정보를 UI에 표시한다.
            lblDefault_AB.Text = inPDO.InPDOs[counterCh].Counter_DisplayDefaultAB.ToString();
            lblRead_AB.Text = inPDO.InPDOs[counterCh].Counter_ReadAB.ToString();
            lbDefault_Z.Text = inPDO.InPDOs[counterCh].Counter_DisplayDefaultZ.ToString();
            lblRead_Z.Text = inPDO.InPDOs[counterCh].Counter_ReadZ.ToString();


            // Latch 관련 정보를 UI에 표시한다.
            // 예제에서는, isLatchMode_Manual == 0 일 경우 Thread에서 처리한다.
            lblLatchIndex.Text = inPDO.InPDOs[counterCh].Latch_LatchIndex.ToString();
            lblLatchCounter.Text = inPDO.InPDOs[counterCh].Latch_LatchCounter.ToString();


            if (chkEnable_CMP.Checked)
            {
                // CMP 관련 정보를 UI에 표시한다.  
                lblCmpIndex.Text = inPDO.InPDOs[cmpCh].CMP_Index.ToString();

                // CMP_Value는 OutPDO의 StartAddress (메모리 주소)에 해당하는 Value값을 보여준다.
                // InPDO의 CMP_Index 또한 메모리 주소를 나타내므로, OutPDO에 CMP_Index을 다시 써주면 다음 Value (CMP Target Count)를 확인할 수 있다.
                Marshal.WriteInt16(outPdoPtr, outPdoOffset, (short)inPDO.InPDOs[cmpCh].CMP_Index);
            }
        }

        //============================================================= Counter =============================================================

        #region EC04H_Counter

        int counterEnable = 0;
        private void cbxCounterChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isCounterInfoUpdate)
                return;

            counterCh = cbxCounterChannel.SelectedIndex;

            UpdateCounterInfo(counterCh);
        }


        private void chkAB_Enable_CheckedChanged(object sender, EventArgs e)
        {
            if (isCounterInfoUpdate)
                return;

            counterEnable = chkAB_Enable.Checked ? 1 : 0;
            int subIndex = 1;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref counterEnable, ref errorCode);
        }

        private void btnClear_AB_Click(object sender, EventArgs e)
        {
            if (isCounterInfoUpdate)
                return;

            int isClear = 1;
            int subIndex = 2;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref isClear, ref errorCode);

            Thread.Sleep(10);

            //Clear 값이 1로 유지될 경우, Clear를 반복한다. 결과적으로 Counter값은 누적되지 않으며, 항상 0으로 표시된다.

            isClear = 0;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref isClear, ref errorCode);
        }

        private void btnClear_Z_Click(object sender, EventArgs e)
        {
            if (isCounterInfoUpdate)
                return;

            int isClear = 1;
            int subIndex = 3;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref isClear, ref errorCode);

            Thread.Sleep(10);

            //Clear 값이 1로 유지될 경우, Clear를 반복한다. 결과적으로 Counter값은 누적되지 않으며, 항상 0으로 표시된다.

            isClear = 0;
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref isClear, ref errorCode);
        }

        private void rdoUp_CheckedChanged(object sender, EventArgs e)
        {
            if (isCounterInfoUpdate)
                return;

            RadioButton rdo = sender as RadioButton;
            if (!rdo.Checked)
                return;


            int isDown = 0; // Positive Direction
            int subIndex = 4;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref isDown, ref errorCode);
        }


        private void rdoDown_CheckedChanged(object sender, EventArgs e)
        {
            if (isCounterInfoUpdate)
                return;

            RadioButton rdo = sender as RadioButton;
            if (!rdo.Checked)
                return;

            int isDown = 1; // Negative Direction
            int subIndex = 4;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref isDown, ref errorCode);
        }


        private void chkFilterEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (isCounterInfoUpdate)
                return;

            int filterEnable = chkFilterEnable.Checked ? 1 : 0;
            int subIndex = 0x5;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref filterEnable, ref errorCode);
        }


        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isCounterInfoUpdate)
                return;

            int filterInterval = cbxFilter.SelectedIndex;
            int subIndex = 0x7;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref filterInterval, ref errorCode);
        }


        private void chkInverse_A_CheckedChanged(object sender, EventArgs e)
        {
            if (isCounterInfoUpdate)
                return;

            CheckBox chk = sender as CheckBox;

            int isInverse = chk.Checked ? 1 : 0;
            int subIndex = 0x9;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref isInverse, ref errorCode);
        }


        private void chkInverse_B_CheckedChanged(object sender, EventArgs e)
        {
            if (isCounterInfoUpdate)
                return;

            CheckBox chk = sender as CheckBox;

            int isInverse = chk.Checked ? 1 : 0;
            int subIndex = 0xA;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref isInverse, ref errorCode);
        }


        private void chkInverse_Z_CheckedChanged(object sender, EventArgs e)
        {
            if (isCounterInfoUpdate)
                return;

            CheckBox chk = sender as CheckBox;

            int isInverse = chk.Checked ? 1 : 0;
            int subIndex = 0xB;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref isInverse, ref errorCode);
        }


        private void cbxInputMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isCounterInfoUpdate)
                return;

            int inputMode = cbxInputMode.SelectedIndex;
            int subIndex = 0xD;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref inputMode, ref errorCode);
        }

        private void tbxDefault_AB_TextChanged(object sender, EventArgs e)
        {
            if (isCounterInfoUpdate)
                return;

            TextBox tbx = sender as TextBox;
            int defaultVal = 0;
            if (!int.TryParse(tbx.Text, out defaultVal))
            {
                //입력값이 정수가 아닐때의 에러처리
                tbx.Text = defaultVal.ToString();
                return;
            }

            int cmdIndex = 0x7000 + 0x10 * counterCh;
            int subIndex = 0x1;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, cmdIndex, subIndex, 0, 1, ref defaultVal, ref errorCode);
        }

        private void tbxDefault_Z_TextChanged(object sender, EventArgs e)
        {
            if (isCounterInfoUpdate)
                return;

            TextBox tbx = sender as TextBox;
            int defaultVal = 0;
            if (!int.TryParse(tbx.Text, out defaultVal))
            {
                //입력값이 정수가 아닐때의 에러처리
                tbx.Text = defaultVal.ToString();
                return;
            }

            int cmdIndex = 0x7000 + 0x10 * counterCh;
            int subIndex = 0x2;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, cmdIndex, subIndex, 0, 1, ref defaultVal, ref errorCode);
        }


        private void UpdateCounterInfo(int channel)
        {
            isCounterInfoUpdate = true;

            //Counter
            cbxCounterChannel.SelectedIndex = channel;
            int subIndex = 0;

            //Counter Enable 확인
            //SDO에 접근하기 위한 Index 는 80n0 으로, n이 채널번호가 된다.
            counterIndex = 0x8000 + 0x10 * channel;
            subIndex = 0x1;
            int counterEnable = 0;
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref counterEnable, ref errorCode);
            chkAB_Enable.Checked = counterEnable == 1;

            //Counter Direction 확인
            subIndex = 0x4;
            int isDirectionDown = 0;
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref isDirectionDown, ref errorCode);

            rdoUp.Checked = isDirectionDown == 0;
            rdoDown.Checked = isDirectionDown == 1;

            //FilterEnable 확인
            subIndex = 0x5;
            int isFilterEnable = 0;
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref isFilterEnable, ref errorCode);
            chkFilterEnable.Checked = isFilterEnable == 1;

            //FilterInterval 확인
            subIndex = 0x7;
            int filterInterval = 0;
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref filterInterval, ref errorCode);
            cbxFilter.SelectedIndex = filterInterval;

            //A Phase Inverse 확인
            subIndex = 0x9;
            int isInverse = 0;
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref isInverse, ref errorCode);
            chkInverse_A.Checked = isInverse == 1;

            //B Phase Inverse 확인
            subIndex = 0xA;
            isInverse = 0;
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref isInverse, ref errorCode);
            chkInverse_B.Checked = isInverse == 1;

            //A Phase Inverse 확인
            subIndex = 0xB;
            isInverse = 0;
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref isInverse, ref errorCode);
            chkInverse_Z.Checked = isInverse == 1;

            //InputMode 확인
            subIndex = 0xD;
            int inputMode = 0;
            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, counterIndex, subIndex, 0, 1, ref inputMode, ref errorCode);
            cbxInputMode.SelectedIndex = inputMode;

            tbxDefault_AB.Text = "0";
            tbxDefault_Z.Text = "0";

            isCounterInfoUpdate = false;
        }


        #endregion



        //============================================================= LATCH =============================================================

        #region Latch

        int latchCh = 0;
        int isLatchMode_Manual = 0;
        int latchIndex_prv = -1;
        bool isLatchInfoUpdate = false;

        private void cbxLatchChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLatchInfoUpdate)
                return;

            latchCh = cbxLatchChannel.SelectedIndex;
            UpdateLatchInfo(latchCh);
        }

        private void chkLatch_CheckedChanged(object sender, EventArgs e)
        {
            if (isLatchInfoUpdate)
                return;

            int latchEnable = chkLatch.Checked ? 1 : 0;

            int index = 0x8001 + 0x10 * latchCh;
            int subIndex = 0x1;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref latchEnable, ref errorCode);
        }


        private void btnLatchClear_Click(object sender, EventArgs e)
        {
            if (isLatchInfoUpdate)
                return;

            int isClear = 1;

            int index = 0x8001 + 0x10 * latchCh;
            int subIndex = 0x2;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref isClear, ref errorCode);

            //Clear 값이 1로 유지될 경우, Clear를 반복한다. 결과적으로 LATCH값은 남지 않으며, 항상 0으로 표시된다.
            isClear = 0;
            Thread.Sleep(10);

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref isClear, ref errorCode);

            lvwLatch.Items.Clear();
            latchIndex_prv = -1;
        }


        private void rdoReadMode_Auto_CheckedChanged(object sender, EventArgs e)
        {
            if (isLatchInfoUpdate)
                return;

            RadioButton rdo = sender as RadioButton;

            if (!rdo.Checked)
                return;

            //래치 기능의 동작 모드를 설정합니다.
            //Auto 인 경우, 래치 카운터 값이 RAM에 자동으로 저장이 됩니다.

            int index = 0x8001 + 0x10 * latchCh;
            int subIndex = 0x3;
            isLatchMode_Manual = 0;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref isLatchMode_Manual, ref errorCode);

            //Thread thLatch = new Thread(new ThreadStart(() =>
            //    {
            //        while (isLatchMode_Manual == 0)
            //        {
            //            if (inPDO.InPDOs[latchCh].Latch_LatchIndex == latchIndex_prv)
            //            {
            //                Thread.Sleep(10);
            //                continue;
            //            }

            //            //Latch_Index가 증가 했는지 확인한다.
            //            //이를 통해 새로운 Latch값이 저장되었는지 알 수 있다.
            //            latchIndex_prv = inPDO.InPDOs[latchCh].Latch_LatchIndex;
            //            outPDO.OutPDOs[latchCh].Latch_ReadLatchIndex = (ushort)(latchIndex_prv + 1);
            //            Marshal.StructureToPtr(outPDO, outPdoPtr, false);

            //            //ListView에 LatchIndex 와 LatchCounter를 추가한다.                        
            //            ListViewItem item = new ListViewItem(latchIndex_prv.ToString());
            //            item.SubItems.Add(inPDO.InPDOs[latchCh].Latch_LatchCounter.ToString());

            //            lvwLatch.Invoke(new Action(() => lvwLatch.Items.Add(item)));
            //            Thread.Sleep(10);
            //        }
            //    }));

            //thLatch.Start();
        }


        private void rdoReadMode_Manual_CheckedChanged(object sender, EventArgs e)
        {
            if (isLatchInfoUpdate)
                return;

            RadioButton rdo = sender as RadioButton;

            if (!rdo.Checked)
                return;

            //래치 기능의 동작 모드를 설정합니다.
            //Manual인 경우 입력된 LatchIndex에 해당하는 LatchCounter값을 확인할 수 있습니다.            

            int index = 0x8001 + 0x10 * latchCh;
            int subIndex = 0x3;
            isLatchMode_Manual = 1;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref isLatchMode_Manual, ref errorCode);
        }


        private void cbxEdge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLatchInfoUpdate)
                return;

            // EdgeMode를 설정합니다.
            // 0 : None - 신호를 무시합니다. 래치 카운터 값이 저장되지 않습니다.
            // 1 : FallingEdge - 신호가 High에서 Low로 전이 될 때 카운터 값이 저장됩니다.
            // 2 : RisingEdge - 신호가 Low에서 High로 전이 될 때 카운터 값이 저장됩니다.
            // 3 : Edge - 신호가 Low 또는 High로 전이 될 때 카운터 값이 저장됩니다.

            int edgeMode = cbxEdge.SelectedIndex;
            int index = 0x8001 + 0x10 * latchCh;
            int subIndex = 0x5;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref edgeMode, ref errorCode);
        }

        private void tbxLatchIndex_TextChanged(object sender, EventArgs e)
        {
            ushort readIndex = 0;
            if (!ushort.TryParse(tbxLatchIndex.Text, out readIndex))
            {
                tbxLatchIndex.Text = readIndex.ToString();
                return;
            }

            outPDO.OutPDOs[latchCh].Latch_ReadLatchIndex = readIndex;

            //OutPDO에 기록한다.
            Marshal.StructureToPtr(outPDO, outPdoPtr, false);
        }

        private void UpdateLatchInfo(int latchChannel)
        {
            isLatchInfoUpdate = true;

            cbxLatchChannel.SelectedIndex = latchChannel;
            //Latch Enable 상태를 확인한다.
            int index = 0x8001 + 0x10 * latchChannel;
            int subIndex = 0x1;
            int latchEnable = 0;

            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref latchEnable, ref errorCode);
            chkLatch.Checked = latchEnable == 1;

            //Read Mode를 확인한다.

            subIndex = 0x3;
            int isReadModeManual = 0;

            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref isReadModeManual, ref errorCode);
            rdoReadMode_Manual.Checked = isReadModeManual == 1;
            rdoReadMode_Auto.Checked = isReadModeManual == 0;

            //Edge Mode를 확인한다.

            subIndex = 0x5;
            int edgeMode = 0;

            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref edgeMode, ref errorCode);
            cbxEdge.SelectedIndex = edgeMode;

            tbxLatchIndex.Text = "0";
            lvwLatch.Items.Clear();

            isLatchInfoUpdate = false;
        }

        #endregion


        //============================================================= CMP =============================================================

        #region CMP


        int cmpCh = 0;
        bool isCmpInfoUpdate = false;
        int outPdoOffset = 0;

        private void cbxChannel_CMP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isCmpInfoUpdate)
                return;

            cmpCh = cbxChannel_CMP.SelectedIndex;
            UpdateCmpInfo(cmpCh);
        }

        private void chkEnable_CMP_CheckedChanged(object sender, EventArgs e)
        {
            if (isCmpInfoUpdate)
                return;

            //CMP 기능의 사용여부를 설정
            // CMP관련 설정값이 변경될 때 Enable은 false 여야함.

            Marshal.StructureToPtr(outPDO, outPdoPtr, false);

            Thread.Sleep(1);

            int index = 0x8002 + 0x10 * cmpCh;
            int subIndex = 0x1;
            int isCmpEnable = chkEnable_CMP.Checked ? 1 : 0;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref isCmpEnable, ref errorCode);
        }

        private void btnCmpClear_Click(object sender, EventArgs e)
        {
            if (isCmpInfoUpdate)
                return;

            // CMP 카운터 값에 대한 RAM에 저장된 설정을 초기화
            // CmpEnable은 false 일때만 유효

            int index = 0x8002 + 0x10 * cmpCh;
            int subIndex = 0x2;
            int isClear = 1;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref isClear, ref errorCode);

            isClear = 0;

            //Clear 값이 1로 유지될 경우, Clear를 반복한다. 결과적으로 CMP Counter 는 기록되지 않는다.
            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref isClear, ref errorCode);
        }

        private void chkCmpRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (isCmpInfoUpdate)
                return;

            // 해당 값이 0인 경우 지정된 카운터에 대한 CMP 출력이 1회만 동작 된다.
            int index = 0x8002 + 0x10 * cmpCh;
            int subIndex = 0x3;
            int isRepeat = chkCmpRepeat.Checked ? 1 : 0;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref isRepeat, ref errorCode);
        }

        private void cbxLogic_CMP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isCmpInfoUpdate)
                return;

            // CMP 신호의 출력 방식을 설정
            // High인 경우 Low 상태에서 트리거 시점에 High로 올라갔다가 Low로 떨어짐
            // Low인 경우, High 상태에서 Low로 떨어졌다가 다시 high로 올라감.

            int index = 0x8002 + 0x10 * cmpCh;
            int subIndex = 0x7;
            int cmpLogic = cbxLogic_CMP.SelectedIndex;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref cmpLogic, ref errorCode);
        }

        private void tbxPulseWidth_TextChanged(object sender, EventArgs e)
        {
            if (isCmpInfoUpdate)
                return;

            TextBox tbx = sender as TextBox;

            // CMP 출력 시 펄스의 길이를 설정한다.
            // 펄스의 길이는 설정값 * 200ns 이다.
            // 설정 시 CmpEnable = false 여야 한다.

            int index = 0x8002 + 0x10 * cmpCh;
            int subIndex = 0x9;
            int cmpLogic = cbxLogic_CMP.SelectedIndex;

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref cmpLogic, ref errorCode);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {

            // 1또는 0이 유효하며, 이전값과 다를 경우 cmp 관련 값을 메모리에 기록한다.
            // 설정 시 CmpEnable = false 여야 한다.
            outPDO.OutPDOs[cmpCh].CMP_ListUpTrigger = (ushort)(outPDO.OutPDOs[cmpCh].CMP_ListUpTrigger == 0 ? 1 : 0);

            // 시작주소를 설정한다.
            if (!ushort.TryParse(tbxStartAddress.Text, out outPDO.OutPDOs[cmpCh].CMP_StartAddress))
                tbxStartAddress.Text = outPDO.OutPDOs[cmpCh].CMP_StartAddress.ToString();

            // 등록할 CMP 개수를 설정한다.
            if (!ushort.TryParse(tbxCmpNumber.Text, out outPDO.OutPDOs[cmpCh].CMP_ListNumber))
                tbxCmpNumber.Text = outPDO.OutPDOs[cmpCh].CMP_ListNumber.ToString();

            // 등록할 CMP 좌표를 설정한다.
            int val = 0;
            for (int i = 0; i < 10; i++)
            {
                int.TryParse(dgvCmp.Rows[i].Cells[1].Value.ToString(), out val);
                outPDO.OutPDOs[cmpCh].CMP_Couter[i] = val;
            }

            Marshal.StructureToPtr(outPDO, outPdoPtr, false);
        }

        private void UpdateCmpInfo(int cmpCh)
        {
            isCmpInfoUpdate = true;

            //Cmp Enable 을 확인한다.

            cbxChannel_CMP.SelectedIndex = cmpCh;

            int index = 0x8002 + 0x10 * cmpCh;
            int subIndex = 0x1;
            int isCmpEnable = 0;

            outPdoOffset = outPdoSize * cmpCh + 8;

            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref isCmpEnable, ref errorCode);
            chkEnable_CMP.Checked = isCmpEnable == 1;

            //Cmp Repeat를 확인한다.

            subIndex = 0x3;
            int isRepeat = 0;

            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref isRepeat, ref errorCode);
            chkCmpRepeat.Checked = isRepeat == 1;

            //Cmp Logic을 확인한다.

            subIndex = 0x7;
            int cmpLogic = 0;

            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref cmpLogic, ref errorCode);
            cbxLogic_CMP.SelectedIndex = cmpLogic;

            //Cmp PulseWidth 을 확인한다.

            subIndex = 0x9;
            int pulseWidth = 0;

            ec.ecSlv_ReadCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref pulseWidth, ref errorCode);
            tbxPulseWidth.Text = pulseWidth.ToString();

            isCmpInfoUpdate = false;

        }

        string outPdoPath = string.Format(@"{0}\outPdoLog.txt", Environment.CurrentDirectory);

        private void btnCmpTest_Click(object sender, EventArgs e)
        {
            int val = 0;
            outPDO.OutPDOs[cmpCh].CMP_ListNumber = 10;
            for (ushort i = 0; i < 100; i++)
            {
                outPDO.OutPDOs[cmpCh].CMP_StartAddress = (ushort)(i * 10);
                //if (i == 0) 
                //    outPDO.OutPDOs[cmpCh].CMP_StartAddress = 0;
                //else 
                //    outPDO.OutPDOs[cmpCh].CMP_StartAddress = 1024;

                bool isBreak = true;
                Stopwatch stw = new Stopwatch();
                stw.Start();
                while (isBreak && stw.ElapsedMilliseconds < 10)
                {
                    inPDO = (ETS_EC04H.InPDO)(Marshal.PtrToStructure(inPdoPtr, typeof(ETS_EC04H.InPDO)));
                    if (outPDO.OutPDOs[cmpCh].CMP_ListUpTrigger == inPDO.InPDOs[cmpCh].CMP_ResponseTrigger)
                        isBreak = false;
                    else
                        Thread.Sleep(1);
                }
                if (isBreak)
                    MessageBox.Show("TimeOut");

                using (System.IO.StreamWriter sw = System.IO.File.AppendText(outPdoPath))
                    sw.WriteLine("\r\nStart Address  : {0}", outPDO.OutPDOs[cmpCh].CMP_StartAddress);


                for (int c = 0; c < 10; c++)
                {
                    val = i * 10000 + (c + 1) * 1000;
                    outPDO.OutPDOs[cmpCh].CMP_Couter[c] = val;

                    using (System.IO.StreamWriter sw = System.IO.File.AppendText(outPdoPath))
                        sw.WriteLine("\ti : {0} c : {1}, val : {2}", i, c, val);
                }

                outPDO.OutPDOs[cmpCh].CMP_ListUpTrigger = (ushort)(i + 1);
                //outPDO.OutPDOs[cmpCh].CMP_ListUpTrigger = (ushort)(outPDO.OutPDOs[cmpCh].CMP_ListUpTrigger == 0 ? 1 : 0);


                using (System.IO.StreamWriter sw = System.IO.File.AppendText(outPdoPath))
                    sw.WriteLine("\t\t CMP_ListUpTrigger : {0}, ElapsedTime : {1}", outPDO.OutPDOs[cmpCh].CMP_ListUpTrigger, stw.ElapsedMilliseconds);

                Marshal.StructureToPtr(outPDO, outPdoPtr, false);
                using (System.IO.StreamWriter sw = System.IO.File.AppendText(outPdoPath))
                    sw.WriteLine("\t\t\t Write");

                isBreak = true;
                stw = new Stopwatch();
                stw.Start();
                while (isBreak && stw.ElapsedMilliseconds < 10)
                {
                    inPDO = (ETS_EC04H.InPDO)(Marshal.PtrToStructure(inPdoPtr, typeof(ETS_EC04H.InPDO)));
                    if (outPDO.OutPDOs[cmpCh].CMP_ListUpTrigger == inPDO.InPDOs[cmpCh].CMP_ResponseTrigger)
                        isBreak = false;
                    else
                        Thread.Sleep(1);
                }
                if (isBreak)
                    MessageBox.Show("TimeOut");

                Thread.Sleep(20);

                using (System.IO.StreamWriter sw = System.IO.File.AppendText(outPdoPath))
                    sw.WriteLine("InPDO Read. index : {0}, CMP_Value : {1}, RepsTrg : {2} ElapsedTime : {3}", inPDO.InPDOs[cmpCh].CMP_Index, inPDO.InPDOs[cmpCh].CMP_Value, inPDO.InPDOs[cmpCh].CMP_ResponseTrigger, stw.ElapsedMilliseconds);

                for (short k = 0; k < 10; k++)
                {
                    short startAddr = (short)(10 * i + k);
                    Marshal.WriteInt16(outPdoPtr, outPdoOffset, startAddr);
                    Thread.Sleep(2);

                    inPDO = (ETS_EC04H.InPDO)(Marshal.PtrToStructure(inPdoPtr, typeof(ETS_EC04H.InPDO)));
                    using (System.IO.StreamWriter sw = System.IO.File.AppendText(outPdoPath))
                        sw.WriteLine("InPDO :  StartAddr : {0}, CMP Value : {1} ", startAddr, inPDO.InPDOs[cmpCh].CMP_Value);
                    Thread.Sleep(1);
                }
            }

            //tbxCmpNumber.Text = "10";
            //tbxStartAddress.Text = "0";
            Thread.Sleep(100);

            for (int i = 0; i < 10; i++)
                dgvCmp.Rows[i].Cells[1].Value = outPDO.OutPDOs[cmpCh].CMP_Couter[i];

            short startAddr2 = 0;
            for (short i = 0; i < 1000; i++)
            {
                startAddr2 = i;
                Marshal.WriteInt16(outPdoPtr, outPdoOffset, startAddr2);
                Thread.Sleep(2);

                inPDO = (ETS_EC04H.InPDO)(Marshal.PtrToStructure(inPdoPtr, typeof(ETS_EC04H.InPDO)));
                using (System.IO.StreamWriter sw = System.IO.File.AppendText(outPdoPath))
                    sw.WriteLine("InPDO Read. startAddr : {0}, CMP_Value : {1}, ", startAddr2, inPDO.InPDOs[cmpCh].CMP_Value);
            }

            MessageBox.Show("End");
        }


        private void btnSettingSave_Click(object sender, EventArgs e)
        {
            int index = 0xF001;
            int subIndex = 0x0;
            int isSave = 1;

            //isSave 값이 1일때 저장된다.

            ec.ecSlv_WriteCoeSdo(netID, slaveAddr, index, subIndex, 0, 1, ref isSave, ref errorCode);
        }


        #endregion

        private void tbxStartAddress_TextChanged(object sender, EventArgs e)
        {
            short startAddr = 0;
            short.TryParse(tbxStartAddress.Text, out startAddr);
            //Marshal.WriteInt16(outPdoPtr, outPdoOffset, startAddr);

        }
    }
}
