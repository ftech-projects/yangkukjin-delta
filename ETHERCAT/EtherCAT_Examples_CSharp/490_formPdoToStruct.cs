using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using ec = ComiLib.EtherCAT.SafeNativeMethods;
using ComiLib.EtherCAT.Slave;

// DI Data를 원하는 크기로 획득하기 위한 예제입니다.
// 4Byte 이하의 DI 데이터를 취득하는 경우 ecdiGetMulti 함수를 사용하시기 바랍니다.

namespace EtherCAT_Examples_CSharp
{
    public partial class formPdoToStruct : Form
    {
        public formPdoToStruct()
        {
            InitializeComponent();
            Init();
        }

        void AddLog(int errorCode)
        {
            if (errorCode != 0)
                MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct PdoData
        {
            // 원하는 크기로 배열을 설정합니다.
            // 자료형은 int[]가 아니어도 상관없습니다.

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = readSize)]
            public int[] data;
        }

        IntPtr inPdoPtr = IntPtr.Zero;
        PdoData inPDO = new PdoData();        

        int netID = 5;
        ushort slaveAddr = 0x0;
        int errorCode = 0;
        const int readSize = 4;

        private void Init()
        {
            // DeviceLoad가 수행되어 있지 않으면 수행한다.
            if (!ec.ecGn_IsDevLoaded(0, ref errorCode)) 
                if (!ec.ecGn_LoadDevice(ref errorCode))
                {
                    AddLog(errorCode);
                    return;
                }
        }

        bool InitReadBuffer()
        {
            // 프로그램이 실행되거나 slaveAddr, readSize가 변경되는 경우에만 실행합니다.
            // 예제에서는 SlaveAddr가 바뀔 수 있어, 매번 실행합니다.

            // inPDO 구조체 안의 배열을 초기화합니다.
            // ex) readSize 가 4인 경우, 128채널의 상태 정보를 한번에 확인할 수 있습니다.
            inPDO.data = new int[readSize];

            // slaveAddr의 inPDO 주소를 획득합니다.
            inPdoPtr = ec.ecSlv_InPDO_GetBufPtr(netID, slaveAddr, 0, ref errorCode);
            return inPdoPtr != IntPtr.Zero;
        }


        private void tbxNetID_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(tbxNetID.Text, out netID);
            tbxNetID.Text = netID.ToString();
        }

        private bool CheckAddrValid()
        {
            GetSlaveAddr();

            // 유효한 슬레이브 주소인지 확인
            ec.ecSlv_PhysAddr2SlvIdx(netID, slaveAddr, ref errorCode);
            AddLog(errorCode);

            return errorCode == 0;
        }

        void GetSlaveAddr()
        {
            var addr = tbxSlaveAddr.Text;

            // 입력된 주소가 ushort 형인지 확인
            if (addr.Contains("0x")) // 16진수라면
                slaveAddr = ushort.Parse(addr.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber);
            else
                ushort.TryParse(addr, out slaveAddr);
        }


        private void btnPdoRead_Click(object sender, EventArgs e)
        {
            if (!CheckAddrValid())
                return;

            if (!InitReadBuffer())
                return;

            // inPdoPtr 위치에서 PdoData의 크기만큼 데이터를 획득합니다.
            inPDO = (PdoData)(Marshal.PtrToStructure(inPdoPtr, typeof(PdoData)));

            // 획득한 데이터 출력
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < inPDO.data.Length; i++)
                sb.AppendLine(inPDO.data[i].ToString());

            tbxResult.Text = sb.ToString();
        }
    }    
}
