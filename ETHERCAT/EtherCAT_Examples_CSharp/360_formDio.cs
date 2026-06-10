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
    // IO 관련 함수군은 Global Channel(전역 번호) 함수군과 Local Channel(지역 채널) 함수군으로 구분된다.
    // Global 함수군은 네트워크에 연결된 모든 채널을 종합하여 채널 번호를 할당한다. (DI 와 Do 는 구분)
    // Local 함수군은 각각의 슬레이브에 독립적으로 채널 번호를 할당한다. (모든 슬레이브의 첫번 째 채널값이 0)
    // Global 함수군은 슬레이브의 연결 순서 변경, 통신 문제 등에 의해 의도치 않은 값으로 확인될 가능성이 있으므로
    // 가능한 Local 함수군을 사용하는 것이 좋다.

    public partial class formDio : Form
    {
        public formDio()
        {
            InitializeComponent();
            if (UpdateForm())
            {
                t_Di.Start();
                t_Do.Start();
            }
        }

    #region base

        int netID = 5;
        int errorCode = 0;
        


        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

    #endregion
        
        private bool UpdateForm()
        {
            // UI 처리용
            if (!ec.ecGn_IsDevLoaded(0, ref errorCode))
            {
                this.Controls.OfType<GroupBox>().ToList().ForEach(x => x.Enabled = false);
                return false;
            }
                

            // 네트워크에 연결된 총 DI 채널 개수를 확인한다.
            int diChCount = ec.ecdiGetNumChannels(netID, ref errorCode);
            tbxDiCount.Text = diChCount.ToString();

            // 네트워크에 연결된 총 DO 채널 개수를 확인한다.
            int doChCount = ec.ecdoGetNumChannels(netID, ref errorCode);
            tbxDoCount.Text = doChCount.ToString();

            // UI 처리용 (CheckBox의 TabIndex 활용)
            int index = 0;
            int tt = 0;
            var t = gbxDo.Controls.OfType<CheckBox>().ToList();
            t.ForEach(x => x.TabIndex = tt++);
            gbxDo.Controls.OfType<CheckBox>().ToList().ForEach(x => x.TabIndex = index++);
            return true;
        }

    #region DI
        private void rdoDiGlobal_CheckedChanged(object sender, EventArgs e)
        {
            // Global 채널 사용 시에는 Slave를 구분하지 않는다.
            lblDiSlaveAddr.Enabled = false;
            tbxDiSlaveAddr.Enabled = false;

            // CheckBox Enable
            gbxDi.Controls.OfType<CheckBox>().ToList().ForEach(x => x.Enabled = true);
        }

        private void rdoDiLocal_CheckedChanged(object sender, EventArgs e)
        {
            lblDiSlaveAddr.Enabled = true;
            tbxDiSlaveAddr.Enabled = true;
        }

        private void t_Di_Tick(object sender, EventArgs e)
        {
            uint InitChannel = 0;
            byte numChannel = 0;
            uint diVal = 0;

            uint.TryParse(tbxDiInitCh.Text, out InitChannel);
            byte.TryParse(tbxDiNumCh.Text, out numChannel);

            // Global 함수군 사용 시
            if (rdoDiGlobal.Checked)
            {
                // 본 예제에서는 InitChannel 부터 numChannel 만큼의 Di Channel값을 확인한다.
                // numChannel이 16보다 큰 경우 16개만 확인한다.
                
                // InitChannel : 입력 상태를 확인할 시작 채널 번호
                // NumChannel : 입력 상태를 확인할 채널의 수
                // Return 값의 각 비트값이 채널값이다 ex) 첫번째 비트값이 InitChannel에 해당하는 채널의 신호상태 값
                diVal = ec.ecdiGetMulti(netID, InitChannel, numChannel, ref errorCode);                               
            }
            else // Local Channel 함수군 사용 시
            {
                ushort slaveAddr = 0;
                // if (ushort.TryParse(tbxDiSlaveAddr.Text, out slaveAddr) && slaveAddr > 0x200) 
                if (ushort.TryParse(tbxDiSlaveAddr.Text, out slaveAddr))
                    diVal = ec.ecdiGetMulti_L(netID, slaveAddr, InitChannel, numChannel, ref errorCode);
                
            }

            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                t_Di.Enabled = false;
                return;
            } 

            // UI 처리. 본 기능과 관련 없음
            var chks = gbxDi.Controls.OfType<CheckBox>().ToList();
            for (int i = 0; i < numChannel; i++)
            {
                chks[i].Text = string.Format("Ch {0:00}", InitChannel + i);
                chks[i].Checked = ((diVal >> i) & 1) == 1;
            }
        }

        private void tbxDiNumCh_TextChanged(object sender, EventArgs e)
        {
            // UI 처리

            byte numChannel = 0;
            byte.TryParse(tbxDiNumCh.Text, out numChannel);

            var chks = gbxDi.Controls.OfType<CheckBox>().ToList();

            for (int i = 0; i < numChannel; i++)
                chks[i].Enabled = true;

            for (int i = numChannel; i < 16; i++)
                chks[i].Enabled = false;
        }

    #endregion

        private void rdoDoLocal_CheckedChanged(object sender, EventArgs e)
        {
            lblDoSlaveAddr.Enabled = true;
            tbxDoSlaveAddr.Enabled = true;
        }

        private void rdoDoGlobal_CheckedChanged(object sender, EventArgs e)
        {
            // Global 채널 사용 시에는 Slave를 구분하지 않는다.
            lblDoSlaveAddr.Enabled = false;
            tbxDoSlaveAddr.Enabled = false;

            // CheckBox Enable
            gbxDo.Controls.OfType<CheckBox>().ToList().ForEach(x => x.Enabled = true);
        }

        private void tbxDoNumCh_TextChanged(object sender, EventArgs e)
        {
            // UI 처리

            byte numChannel = 0;
            byte.TryParse(tbxDiNumCh.Text, out numChannel);

            var chks = gbxDo.Controls.OfType<CheckBox>().ToList();

            for (int i = 0; i < numChannel; i++)
                chks[i].Enabled = true;

            for (int i = numChannel; i < 16; i++)
                chks[i].Enabled = false;
        }

        private void DoCh_Click(object sender, EventArgs e)
        {
            int InitCh = 0;
            int.TryParse(tbxDoInitCh.Text, out InitCh);

            if (rdoPutOne.Checked) // DoPutOne
            {
                // CheckBox 의 Check 상태를 확인한다.
                bool outState = (sender as CheckBox).Checked;                
                int doLocalCh = (sender as CheckBox).TabIndex;
                uint doGlobalCh = (uint)(doLocalCh + InitCh);

                ushort slaveAddr = 0;
                // 선택된 채널의 출력값을 변경한다.
                if (rdoDoGlobal.Checked)
                {
                    ec.ecdoPutOne(netID, doGlobalCh, outState, ref errorCode);
                    if (errorCode != 0) // 에러처리
                        AddLog(errorCode);
                }
                else
                {
                    //if (ushort.TryParse(tbxDoSlaveAddr.Text, out slaveAddr) && slaveAddr > 0x200)
                    if (ushort.TryParse(tbxDoSlaveAddr.Text, out slaveAddr))
                    {
                        ec.ecdoPutOne_L(netID, slaveAddr, doLocalCh, outState, ref errorCode);
                        if (errorCode != 0) // 에러처리
                            AddLog(errorCode);
                    }
                }
            }
            else
            {
                int numCh = 0;
                int.TryParse(tbxDoNumCh.Text, out numCh);
                uint doVal = 0;
                var chkList = gbxDo.Controls.OfType<CheckBox>().ToList();
                foreach (var chk in chkList)
                    if (chk.Checked)
                        doVal |= (uint)(1 << chk.TabIndex);

                // DoPutMulti의 OutState는 각 비트가 채널값이 된다.
                // 1,2,3 채널 출력시의 OutState값은 7
                // 1,2,3,4 채널 출력시의 OutState값은 15
                ushort slaveAddr = 0;
                // 선택된 채널의 출력값을 변경한다.
                if (rdoDoGlobal.Checked)
                {
                    ec.ecdoPutMulti(netID, (uint)InitCh, (byte)numCh, doVal, ref errorCode);
                    if (errorCode != 0) // 에러처리
                        AddLog(errorCode);
                }
                else
                {
                    // if (ushort.TryParse(tbxDoSlaveAddr.Text, out slaveAddr) && slaveAddr > 0x200)
                    if (ushort.TryParse(tbxDoSlaveAddr.Text, out slaveAddr))
                    {
                        ec.ecdoPutMulti_L(netID, slaveAddr, 0, 32, doVal, ref errorCode);
                        if (errorCode != 0) // 에러처리
                            AddLog(errorCode);
                    }
                }
            }
        }

        private void t_Do_Tick(object sender, EventArgs e)
        {
            uint InitChannel = 0;
            byte numChannel = 0;
            uint doVal = 0;

            uint.TryParse(tbxDoInitCh.Text, out InitChannel);
            byte.TryParse(tbxDoNumCh.Text, out numChannel);

            // Global 함수군 사용 시
            if (rdoDoGlobal.Checked)
            {
                // 본 예제에서는 InitChannel 부터 numChannel 만큼의 Do Channel값을 확인한다.
                // numChannel이 16보다 큰 경우 16개만 확인한다.

                // InitChannel : 입력 상태를 확인할 시작 채널 번호
                // NumChannel : 입력 상태를 확인할 채널의 수
                // Return 값의 각 비트값이 채널값이다 ex) 첫번째 비트값이 InitChannel에 해당하는 채널의 신호상태 값
                doVal = ec.ecdoGetMulti(netID, InitChannel, numChannel, ref errorCode);
            }
            else // Local Channel 함수군 사용 시
            {
                ushort slaveAddr = 0;
                // if (ushort.TryParse(tbxDoSlaveAddr.Text, out slaveAddr) && slaveAddr > 0x200)
                if (ushort.TryParse(tbxDoSlaveAddr.Text, out slaveAddr))
                    doVal = ec.ecdoGetMulti_L(netID, slaveAddr, InitChannel, numChannel, ref errorCode);
            }

            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                t_Do.Enabled = false;
                return;
            }

            // UI 처리. 본 기능과 관련 없음
            var chks = gbxDo.Controls.OfType<CheckBox>().ToList();
            for (int i = 0; i < numChannel; i++)
            {
                chks[i].Text = string.Format("Ch {0:00}", InitChannel + i);
                chks[i].Checked = ((doVal >> i) & 1) == 1;
            }
        }

        private void formDio_Load(object sender, EventArgs e)
        {

        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
