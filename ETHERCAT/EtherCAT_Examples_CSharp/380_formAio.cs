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
    public partial class formAio : Form
    {
        public formAio()
        {
            InitializeComponent();

            InitAi();
            InitAo();
        }

    #region base

        int netID = 5;
        int errorCode = 0;

        int aiCh = 0;
        int aoCh = 0;

        bool isUpdate = false;

        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

    #endregion


    #region AI

        private void InitAi()
        {
            //AI Channel 수를 확인한다.
            int aiChCount = ec.ecaiGetNumChannels(netID, ref errorCode);
            if (errorCode != 0) 
            {
                AddLog(errorCode);
                return;
                //Error 처리
            }

            cbxAiCh.Items.Clear();
            for (int i = 0; i < aiChCount; i++)
                cbxAiCh.Items.Add(string.Format("Channel {0:00}", i));

            // AiType은 Slave에 따라 다르다. 매뉴얼 확인
            // 본 예제는 COMIZOA의 ETS-AI 모듈을 대상으로 한다
            // AIType : 0 - Voltage, 1 - Current
            cbxAiType.Items.Clear();
            cbxAiType.Items.AddRange(new string[2] { "Volatage", "Current" });

            // AiRangeMode는 Slave에 따라 다르다. 매뉴얼 확인
            // 본 예제는 COMIZOA의 ETS-AI 모듈을 대상으로 한다
            // 0 : -10.24 ~ 10.24 (V)
            // 1 : -5.12 ~ 5.12 (V)
            // 2 : -2.56 ~ 2.56 (V)
            // 3 : 0 ~ 10.24 (V)
            // 4 : 0 ~ 5.12 (V)
            // 5 : 4 ~ 20 (mA)
            // 6 : 0 ~ 20 (mA)
            // 7 : 0 ~ 24 (mA)

            cbxAiRangeMode.Items.Clear();
            cbxAiRangeMode.Items.AddRange(new string[8] {
                "0 : -10.24 ~ 10.24 (V)",
                "1 : -5.12 ~ 5.12 (V)",
                "2 : -2.56 ~ 2.56 (V)",
                "3 : 0 ~ 10.24 (V)",
                "4 : 0 ~ 5.12 (V)",
                "5 : 4 ~ 20 (mA)",
                "6 : 0 ~ 20 (mA)",
                "7 : 0 ~ 24 (mA)",
            });

            if (cbxAiCh.Items.Count > 0) 
            {
                aiCh = 0;
                cbxAiCh.SelectedIndex = 0;
            }

            t_AI.Start();
        }

        private void cbxAiCh_SelectedIndexChanged(object sender, EventArgs e)
        {
            aiCh = cbxAiCh.SelectedIndex;

            // AI 채널이 속한 Slave의 Index를 확인한다.
            // Slave의 Index나 Address를 아는 경우 수행하지 않는다.
            int slaveIndex = ec.ecaiGetSlaveIndex(netID, (uint)aiCh, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                //Error 처리
            }

            GetAiType(aiCh);
            GetAiRangeMode(aiCh);
        }

        private void GetAiType(int ch)
        {
            // AiType은 CoeSDO를 통해 확인한다.
            // index = 0x80n0 (n은 Local Channel)
            // *주의 - ecai 함수군은 글로벌 채널을 대상으로 하지만, CoeSDO 함수군은 Slave를 대상으로 하므로, 로컬채널이 대상이다
            // ETS-AI08AH 모듈 두개를 사용할 경우, 9번 채널은 두번째 ETS-AI08AH 모듈의 2번째 채널이므로, index의 n은 1이 된다.
            // 본 예제는 AI08AH 모듈 한 개를 사용하는 경우로 가정한다.
            // subIndex = 0x3
            // dataSize = 1
            // isComptAccess = 0

            int slaveIndex = ec.ecaiGetSlaveIndex(netID, (uint)aiCh, ref errorCode);
            int aiType = 0;
            int index = 0x8000 + ch * 0x10;
            int subIndex = 3;
            int dataSize = 1;
            int isComptAccess = 0;

            //AiType을 확인한다.
            ec.ecSlv_ReadCoeSdo_A(netID, slaveIndex, index, subIndex, isComptAccess, dataSize, ref aiType, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                //Error 처리
            }

            if (aiType >= 0 && aiType < 2)
            {
                isUpdate = true;
                cbxAiType.SelectedIndex = aiType;
                isUpdate = false;
            }                
        }

        private void GetAiRangeMode(int ch)
        {
            // AiRangeMode는 CoeSDO를 통해 확인한다.
            // index = 0x80n0 (n은 Local Channel)
            // *주의 - ecai 함수군은 글로벌 채널을 대상으로 하지만, CoeSDO 함수군은 Slave를 대상으로 하므로, 로컬채널이 대상이다
            // ETS-AI08AH 모듈 두개를 사용할 경우, 9번 채널은 두번째 ETS-AI08AH 모듈의 2번째 채널이므로, index의 n은 1이 된다.
            // 본 예제는 AI08AH 모듈 한 개를 사용하는 경우로 가정한다.
            // subIndex = 0x9
            // dataSize = 1
            // isComptAccess = 0

            int slaveIndex = ec.ecaiGetSlaveIndex(netID, (uint)aiCh, ref errorCode);
            int aiRangeMode = 0;
            int index = 0x8000 + ch * 0x10;
            int subIndex = 9;
            int dataSize = 1;
            int isComptAccess = 0;

            // AIRangeMode를 확인한다.
            ec.ecSlv_ReadCoeSdo_A(netID, slaveIndex, index, subIndex, isComptAccess, dataSize, ref aiRangeMode, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                //Error 처리
            }

            if (aiRangeMode >= 0 && aiRangeMode < 8)
            {
                isUpdate = true;
                cbxAiRangeMode.SelectedIndex = aiRangeMode;
                isUpdate = false;
            }
        }

        private void cbxAiType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdate)
                return;

            int slaveIndex = ec.ecaiGetSlaveIndex(netID, (uint)aiCh, ref errorCode);
            int aiType = cbxAiType.SelectedIndex;
            int index = 0x8000 + aiCh * 0x10;
            int subIndex = 3;
            int dataSize = 1;
            int isComptAccess = 0;

            //AiType을 확인한다.
            ec.ecSlv_WriteCoeSdo_A(netID, slaveIndex, index, subIndex, isComptAccess, dataSize, ref aiType, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                //Error 처리
            }

            Thread.Sleep(2);
            WriteToSave(slaveIndex);
        }

        private void cbxAiRangeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdate)
                return;

            int slaveIndex = ec.ecaiGetSlaveIndex(netID, (uint)aiCh, ref errorCode);
            int aiRangeMode = cbxAiRangeMode.SelectedIndex;
            int index = 0x8000 + aiCh * 0x10;
            int subIndex = 9;
            int dataSize = 1;
            int isComptAccess = 0;

            // AIRangeMode를 확인한다.
            ec.ecSlv_WriteCoeSdo_A(netID, slaveIndex, index, subIndex, isComptAccess, dataSize, ref aiRangeMode, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                //Error 처리
            }

            Thread.Sleep(2);
            WriteToSave(slaveIndex);
        }

        private void t_AI_Tick(object sender, EventArgs e)
        {
            // ecaiGetChanVal_I 는 Ai 모듈의 값 타입이 정수형일때 사용한다. 모듈 매뉴얼 확인
            // ecaiGetChanVal_F 는Ai 모듈의 값 타입이 Float 이거나 Real 일때 사용한다. 
            // ecaiGetChanVal_FS 은 Ai 모듈의 값타입이 digit 인경우, Scale을 정해 반환받을 때 사용한다. ex) 0 ~ 65535 반환(digit), -10 ~ 10 (V)로 확인
            // COMIZOA 의 AI 모듈은 AiType에 상관없이 mV, mA 단위의 정수형으로 반환한다.
            int aiVal = ec.ecaiGetChanVal_I(netID, (uint)aiCh, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                //Error 처리
                t_AI.Stop();
            }

            tbxAi.Text = aiVal.ToString();
        }

    #endregion


        #region AO : AI와 함수형태 및 사용법이 같다

        private void InitAo()
        {
            //AO Channel 수를 확인한다.
            int aoChCount = ec.ecaoGetNumChannels(netID, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return;
                //Error 처리
            }

            cbxAoCh.Items.Clear();
            for (int i = 0; i < aoChCount; i++)
                cbxAoCh.Items.Add(string.Format("Channel {0:00}", i));
                        
            // AoRangeMode는 Slave에 따라 다르다. 매뉴얼 확인
            // ETS-AO04I
            // 0 : 4 ~ 20 mA
            // 1 : 0 ~ 20 mA
            // 2 : 0 ~ 24 mA

            // ETS-AO04V
            // 0 : 0 ~ 5 (V)
            // 1 : 0 ~ 10 (V)
            // 2 : 0 ~ 10.8 (V)
            // 3 : -5 ~ 5 (V)
            // 4 : -10 ~ 10 (V)
            // 5 : -10.8 ~ 10.8 (V)

            // 본 예제는 ETS-AO04V를 대상으로 한다.
           
            cbxAoRangeMode.Items.Clear();
            cbxAoRangeMode.Items.AddRange(new string[6] {
                "0 : 0 ~ 5 (V)",
                "1 : 0 ~ 10 (V)",
                "2 : 0 ~ 10.8 (V)",
                "3 : -5 ~ 5 (V)",
                "4 : -10 ~ 10 (V)",
                "5 : -10.8 ~ 10.8 (V)",               
            });

            if (cbxAoCh.Items.Count > 0)
            {
                aoCh = 0;
                cbxAoCh.SelectedIndex = 0;
            }
        }

        private void cbxAoCh_SelectedIndexChanged(object sender, EventArgs e)
        {
            aoCh = cbxAoCh.SelectedIndex;

            // AO 채널이 속한 Slave의 Index를 확인한다.
            // Slave의 Index나 Address를 아는 경우 수행하지 않는다.
            int slaveIndex = ec.ecaoGetSlaveIndex(netID, (uint)aoCh, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                //Error 처리
            }

            // ecaoGetOutValue_I 는 Ao 모듈의 값 타입이 정수형일때 사용한다. 모듈 매뉴얼 확인
            // ecaoGetOutValue_F 는 Ao 모듈의 값 타입이 Float 이거나 Real 일때 사용한다. 
            // COMIZOA 의 AO 모듈은 Type에 상관없이 mV, mA 단위의 정수형으로 반환한다.
            int aoVal = ec.ecaoGetOutValue_I(netID, (uint)aoCh, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                //Error 처리
            }

            tbxAo.Text = aoVal.ToString();

            GetAoRangeMode(aoCh);
        }


        private void GetAoRangeMode(int ch)
        {
            // AoRangeMode는 CoeSDO를 통해 확인한다.
            // index = 0x80n0 (n은 Local Channel)
            // *주의 - ecao 함수군은 글로벌 채널을 대상으로 하지만, CoeSDO 함수군은 Slave를 대상으로 하므로, 로컬채널이 대상이다
            // ETS-AO04V 모듈 두개를 사용할 경우, 5번 채널은 두번째 ETS-AO04V 모듈의 2번째 채널이므로, index의 n은 1이 된다.
            // 본 예제는 AO04V 모듈 한 개를 사용하는 경우로 가정한다.
            // subIndex = 0x9
            // dataSize = 1
            // isComptAccess = 0

            int slaveIndex = ec.ecaoGetSlaveIndex(netID, (uint)aoCh, ref errorCode);
            int rangeMode = 0;
            int index = 0x8000 + ch * 0x10;
            int subIndex = 1;
            int dataSize = 1;
            int isComptAccess = 0;

            // AIRangeMode를 확인한다.
            ec.ecSlv_ReadCoeSdo_A(netID, slaveIndex, index, subIndex, isComptAccess, dataSize, ref rangeMode, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                //Error 처리
            }

            if (rangeMode >= 0 && rangeMode < 6)
            {
                isUpdate = true;
                cbxAoRangeMode.SelectedIndex = rangeMode;
                isUpdate = false;
            }                
        }

        private void cbxAoRangeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdate)
                return;

            int slaveIndex = ec.ecaoGetSlaveIndex(netID, (uint)aoCh, ref errorCode);
            int rangeMode = cbxAoRangeMode.SelectedIndex;
            int index = 0x8000 + aoCh * 0x10;
            int subIndex = 1;
            int dataSize = 4;
            int isComptAccess = 0;

            // AORangeMode를 확인한다.
            ec.ecSlv_WriteCoeSdo_A(netID, slaveIndex, index, subIndex, isComptAccess, dataSize, ref rangeMode, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                //Error 처리
            }

            Thread.Sleep(2);
            WriteToSave(slaveIndex);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            int outData = 0;
            int.TryParse(tbxAo.Text, out outData);

            ec.ecaoSetChanVal_I(netID, (uint)aoCh, outData, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                //Error 처리
            }
        }

        #endregion

        

        private void WriteToSave(int slaveIndex)
        {
            // 모듈에 변경값을 기록한다.                 
            int isSave = 0; // Setting 값을 저장하지 않음
            ec.ecSlv_WriteCoeSdo_A(netID, slaveIndex, 0xF001, 0x00, 0, 2, ref isSave, ref errorCode);
            System.Threading.Thread.Sleep(2);

            // Flag 변경이 확인되야 하므로, 0을 먼저 기록하고 1을 기록한다.
            isSave = 1; // Setting 값을 저장
            ec.ecSlv_WriteCoeSdo_A(netID, slaveIndex, 0xF001, 0x00, 0, 2, ref isSave, ref errorCode);
        }

        
    }
}
