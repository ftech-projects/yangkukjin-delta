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
    public partial class formExtStop : Form
    {
        public formExtStop()
        {
            InitializeComponent();
            UpdateAxisList();
        }

        int netID = 5;
        int axisID = 0;
        int errorCode = 0;
        byte[] axisList = new byte[32];

        int sourceType = 0;
        int edge = 0;
        double offsetDistance = 0;
        int offsetMode = 0;
        bool isEnable = false;
        int channel = 0;

        private void UpdateAxisList()
        {
            cbxAxisList.Items.Clear();

            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, (byte)axisList.Length, ref errorCode);
            for (int i = 0; i < axisCount; i++)
                cbxAxisList.Items.Add(string.Format("Axis {0:00}", axisList[i]));

            if (axisCount > 0)
                cbxAxisList.SelectedIndex = 0;

            cbxSourceType.SelectedIndex = 0;            
        }

        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

        private void cbxAxisList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int axisIndex = cbxAxisList.SelectedIndex;
            axisID = axisList[axisIndex];

            UpdateForm();
        }

        private void UpdateForm()
        {
            // ExtStop 기능에 대한 활성화 여부를 확인한다.
            isEnable = ec.ecmSxCfg_ExtStop_GetEnable(netID, axisID, ref errorCode);

            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
                return;
            }

            if (isEnable)
            {
                btnEnable.BackColor = SystemColors.Highlight;
                btnDisable.BackColor = SystemColors.Control;
            }
            else
            {
                btnEnable.BackColor = SystemColors.Control;
                btnDisable.BackColor = SystemColors.Highlight;
            }

            // ecmSxCfg_ExtStop_SetEnv : 범용 IO 채널로 입력 받고, OffsetTime 을 설정한다.
            // ecmSxCfg_ExtStop_SetEnv2 : 범용 IO 채널로 입력 받고, OffsetDistance 를 설정한다.
            // ecmSxCfg_ExtStop_SetEnv3 : 드라이버의 TouchProbe로 입력받고, OffsetDistance 를 설정한다.
            // SetEnv, SetEnv2는 SetEnv3에 비해 최대 2Cycle까지 지연이 생길 수 있다.            
            // 본 예제에서는 Env2, Env3 를 다룬다.
                        
            if (sourceType == 0)
            {
                // 설정된 DI 채널값을 확인한다.
                ec.TEcLogicAddr sigAddr = new ec.TEcLogicAddr();
                ec.ecmSxCfg_ExtStop_GetEnv2(netID, axisID, ref sigAddr, ref edge, ref offsetDistance, ref errorCode);
                channel = (sigAddr.AddrOfs * 8 + sigAddr.BitIdx);

                if (errorCode != 0)
                {
                    //에러처리
                    AddLog(errorCode);
                    return;
                }

                //SourceType이 범용 IO인 경우 Ch ComboBox에 선택 가능한 Ch값을 입력한다.
                cbxCh.Items.Clear();                                
                int chCount = ec.ecdiGetNumChannels(netID, ref errorCode);
                for (int i = 0; i < chCount; i++)
                    cbxCh.Items.Add(string.Format("{0:00}", i));

                if (channel < chCount)
                    cbxCh.SelectedIndex = channel;
            }
            else
            {
                byte tempSource = 0;
                ec.ecmSxCfg_ExtStop_GetEnv3(netID, axisID, ref tempSource, ref edge, ref offsetDistance, ref errorCode);
                               
                channel = tempSource;
                // 이때 channel은 TouchProbe Index 이다.
                // TouchProbe는 일반적으로 2채널이 제공된다.
                for (int i = 0; i < 2; i++)
                    cbxCh.Items.Add(string.Format("{0:00}", i));

                if (channel < 2)
                    cbxCh.SelectedIndex = channel;
            }

            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
                return;
            }


            cbxEdge.SelectedIndex = edge;
            tbxDist.Text = offsetDistance.ToString();

            //OffsetMode는 센서 감지후 적용 되는 offset이 원래의 이송량보다 큰 경우, offset을 보장할지에 대한 선택값이다.
            //ex) 1,000 offset 설정 후 10,000 이송시 9,500에서 센서가 감지되면 종료 위치를 10,000으로 할지 10,500으로 할지에 대한 옵션
            //OffsetMode의 반환값이 true이면 EnsureOffset, 
            offsetMode = ec.ecmSxCfg_ExtStop_GetOfsDistMode(netID, axisID, ref errorCode) ? 1 : 0;
            cbxOffsetMode.SelectedIndex = offsetMode;
            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
                return;
            }
        }

        private void cbxSourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            sourceType = cbxSourceType.SelectedIndex;
            UpdateForm();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            ec.ecmSxCfg_ExtStop_SetEnable(netID, axisID, true, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            channel = cbxCh.SelectedIndex; //Global Channel
            edge = cbxEdge.SelectedIndex;
            double.TryParse(tbxDist.Text, out offsetDistance);

            if (sourceType == 0) // External DI (범용 IO) 채널 사용 시
            {                
                ec.TEcLogicAddr sigAddr = new ec.TEcLogicAddr();
                uint logicAddr = ec.ecdiGetLogicAddr(netID, (uint)channel, ref errorCode);
                if (errorCode != 0) //에러처리
                {
                    AddLog(errorCode);
                    return;
                }

                sigAddr.AddrOfs = (ushort)(logicAddr & 0xffff);
                sigAddr.BitIdx = (ushort)((logicAddr >> 16) & 0xffff);

                ec.ecmSxCfg_ExtStop_SetEnv2(netID, axisID, sigAddr, edge, offsetDistance, ref errorCode);
                
                if (errorCode != 0)
                {
                    //에러처리
                    AddLog(errorCode);
                    return;
                }
            }
            else // TouchProbe 사용 시
            {                
                ec.ecmSxCfg_ExtStop_SetEnv3(netID, axisID, (byte)channel, edge, offsetDistance, ref errorCode);
                if (errorCode != 0)
                {
                    //에러처리
                    AddLog(errorCode);
                    return;
                }
            }
            
            //OffsetMode는 센서 감지후 적용 되는 offset이 원래의 이송량보다 큰 경우, offset을 보장할지에 대한 선택값이다.
            //ex) 1,000 offset 설정 후 10,000 이송시 9,500에서 센서가 감지되면 종료 위치를 10,000으로 할지 10,500으로 할지에 대한 옵션
            //OffsetMode의 반환값이 true이면 EnsureOffset, 
            offsetMode = cbxOffsetMode.SelectedIndex;
            ec.ecmSxCfg_ExtStop_SetOfsDistMode(netID, axisID, offsetMode == 1, ref errorCode);

            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
                return;
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            ec.ecmSxCfg_ExtStop_SetEnable(netID, axisID, false, ref errorCode);
            if (errorCode != 0) //에러처리
            {                
                AddLog(errorCode);
            }
        }
    }
}
