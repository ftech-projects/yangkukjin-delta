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
    // COE Object 에 대한 Read / Write 예제
    // EEPROM, REGISTER Read / Write 시에도 함수만 다를 뿐 방식은 같다.    

    public partial class formCoeSdo : Form
    {
        public formCoeSdo()
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

        private void btnRead_Click(object sender, EventArgs e)
        {
            // 접근하고자 하는 슬레이브의 물리주소            
            ushort slavePhysAddr = 0;
            
            // 오브젝트 인덱스
            int index = 0;

            // 오브젝트의 서브 인덱스
            int subIndex = 0;

            // 오브젝트가 배열이나 구조체인 경우 해당 오브젝트의 모든 서브인덱스에 해당하는 값을 읽을지에 대한 플래그
            // 지정된 서브인덱스에 대한 값을 읽는 경우 0
            int isComptAccess = 0;

            // 오브젝트의 데이터 크기
            int dataSize = 0;

            // 읽은 데이터가 전달 받을 버퍼
            int pBuf = 0;
            
            // 입력값 확인
            if (!ushort.TryParse(tbxAddr.Text, out slavePhysAddr))
                tbxAddr.Text = slavePhysAddr.ToString();

            index = StringToInt(tbxIndex.Text);
            if (index == 0)
                tbxIndex.Text = index.ToString();
            
            subIndex = StringToInt(tbxSubIndex.Text);
            if (subIndex == 0)
                tbxSubIndex.Text = subIndex.ToString();

            if (!int.TryParse(tbxSize.Text, out dataSize))
                tbxSize.Text = dataSize.ToString();

            // 슬레이브에 연결순서 (Index)로 접근하는 경우 ecSlv_ReadCoeSdo_A() 함수 사용
            // DataType 이 Float 인경우 ecSlv_ReadCoeSdo_Float() 사용
            // DataType 이 Array 인경우 ecSlv_ReadCoeSdo_Array() 사용
            // 대부분의 경우 dataType 은 int 형이다

            ec.ecSlv_ReadCoeSdo(netID, slavePhysAddr, index, subIndex, isComptAccess, dataSize, ref pBuf, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }

            tbxValue.Text = pBuf.ToString();
        }

        int StringToInt(string val)
        {
            int returnVal = 0;
            if (val.Contains("0x"))
                int.TryParse(val.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber, null, out returnVal);
            else
                int.TryParse(val, out returnVal);

            return returnVal;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            ushort slavePhysAddr = 0;
            int index = 0;
            int subIndex = 0;
            int isComptAccess = 0;
            int dataSize = 0;
            int pBuf = 0;
            
            if (!ushort.TryParse(tbxAddr.Text, out slavePhysAddr))
                tbxAddr.Text = slavePhysAddr.ToString();

            index = StringToInt(tbxIndex.Text);
            if (index == 0)
                tbxIndex.Text = index.ToString();

            subIndex = StringToInt(tbxSubIndex.Text);
            if (subIndex == 0)
                tbxSubIndex.Text = subIndex.ToString();

            if (!int.TryParse(tbxSize.Text, out dataSize))
                tbxSize.Text = dataSize.ToString();

            if (!int.TryParse(tbxValue.Text, out pBuf))
                tbxValue.Text = pBuf.ToString();

            // 슬레이브에 연결순서 (Index)로 접근하는 경우 ecSlv_WriteCoeSdo_A() 함수 사용
            // DataType 이 Float 인경우 ecSlv_WriteCoeSdo_Float() 사용
            // DataType 이 Array 인경우 ecSlv_WriteCoeSdo_Array() 사용
            
            ec.ecSlv_WriteCoeSdo(netID, slavePhysAddr, index, subIndex, isComptAccess, dataSize, ref pBuf, ref errorCode);
            if (errorCode != 0) // 에러처리
            {
                AddLog(errorCode);
                return;
            }
        }
    }
}
