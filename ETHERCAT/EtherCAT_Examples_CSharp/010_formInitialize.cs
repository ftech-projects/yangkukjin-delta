using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

using ec = ComiLib.EtherCAT.SafeNativeMethods;


// 디바이스 초기화에 대한 예제
// 셋업에 대한 상세 내용은 다음 페이지를 참조하시기 바랍니다.
// https://winoar.com/dokuwiki/platform:ethercat:1_setup:0_guide

namespace EtherCAT_Examples_CSharp
{
    public partial class formInitialize : Form
    {
        public formInitialize()
        {
            InitializeComponent();
           
        }

        int netID = 5;
        int errorCode = 0;

        

    #region AddLog
    
        private void AddLog(int errorCode)
        {
            if (errorCode == 0)
                return;

            //if (lbxLog.InvokeRequired)
            //{
            //    lbxLog.BeginInvoke(new Action(() =>
            //    {
            //        lbxLog.Items.Add(ec.ecUtl_GetErrorString(errorCode));
            //        lbxLog.SelectedIndex = lbxLog.Items.Count - 1;
            //    }));
            //}
            //else
            //{
            //    lbxLog.Items.Add(ec.ecUtl_GetErrorString(errorCode));
            //    lbxLog.SelectedIndex = lbxLog.Items.Count - 1;
            //}
        }


        private void AddLog(string errorString)
        {
            if (lbxLog.InvokeRequired)
            {
                lbxLog.BeginInvoke(new Action(() =>
                {
                    lbxLog.Items.Add(errorString);
                    lbxLog.SelectedIndex = lbxLog.Items.Count - 1;
                }));
            }
            else
            {
                lbxLog.Items.Add(errorString);
                lbxLog.SelectedIndex = lbxLog.Items.Count - 1;
            }
        }

    #endregion

        /// <summary>
        /// Master Device를 초기화합니다.
        /// </summary>
        /// <returns></returns>
        private bool MasterDeviceInit()
        {            
            try
            {
                // Device를 초기화합니다.           
                if (!ec.ecGn_LoadDevice(ref errorCode))
                {
                    AddLog(errorCode);
                    switch (errorCode)
                    {
                        case 5:
                            AddLog("Mater Device에 12V 전원이 입력되었는지 확인 바랍니다.");
                            break;

                        case 8:
                            AddLog("Mater Device가 부팅되지 않았습니다. Windows의 FastBoot(빠른시작켜기)가 활성화 되어 있는 경우 비활성화 하세요");
                            break;
                    }

                    return false;
                }
            }
            catch (BadImageFormatException)
            {
                MessageBox.Show(string.Format("ecGn_LoadDevice Failed : DLL 버전(x86/x64)이 OS와 맞지 않습니다."));
                return false;
            }
            catch (DllNotFoundException)
            {
                MessageBox.Show(string.Format("ecGn_LoadDevice Failed : DLL을 찾을 수 없습니다."));
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ecGn_LoadDevice Failed : Exception - {0}", ex.ToString()));
                return false;
            }

            // Config된 slave 수를 확인합니다.
            // Configuration 단계에서 설정된 슬레이브의 수로 현재 연결된 슬레이브 수와는 관련이 없습니다.
            // Config 상세 정보  https://winoar.com/dokuwiki/platform:ethercat:1_setup:10_config:20_configuration
            uint cfgCount = ec.ecNet_GetCfgSlaveCount(netID, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return false;
            }
            
            // 현재 네트워크에 연결되어 있는 slave 수를 확인합니다.
            uint slaveCount = ec.ecNet_ScanSlaves(netID, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return false;
            }
            
            // 설정된 모듈 수만큼 스캔되었는지 확인합니다.
            if (cfgCount != slaveCount)
            {
                AddLog("현재 스캔된 슬레이브의 모듈 수와 설정된 슬레이브의 모듈 수가  다릅니다.");
                AddLog(string.Format("ScanSlave : {0}. CfgCount : {1}", slaveCount, cfgCount));
                AddLog("전원이 들어가지 않았거나 네트워크와 연결되지 않은 슬레이브 모듈이 있는지 확인하시기 바랍니다.");
                AddLog("마스터를 포함한 슬레이브 모듈의 개수가 ScanSlave와 같다면 Configuration 을 재실행 하시기 바랍니다.");
                return false;
            }
            
            // SW Version(FW, WDM, SDK)이 서로 호환되는 버전인지 확인합니다.
            // 호환되지 않는 버전이 설치되어 있는 경우 오동작 할 수 있습니다.
            if (!GetVersionCompResult())
            {
                AddLog("Version compare fail");                
                return false;
            }
            AddLog("Version compare compt");

            // 슬레이브의 Input / Output이 반대로 연결된 모듈이 있는지 확인합니다.            
            if (!CheckReveseConnection())
            {
                AddLog("역삽입된 모듈이 있습니다."); 
                return false;
            }

            // Network의 alStatus를 OP로 설정합니다.
            ec.ecNet_SetAlState(netID, ec.EEcAlState.OP, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return false;
            }
            AddLog("Set AlState to OP");

            // Network의 alStatus가 변경되는 경우, 모든 Slave의 alStatus도 Network의 alStatus로 변경됩니다.
            // slave의 alStatus가 OP가 되지 않는 경우, 해당 slave를 점검하시기 바랍니다.
            // https://winoar.com/dokuwiki/platform:ethercat:1_setup:10_config:ts:30_safeop_failed
            
            // 모든 모듈의 alStatus가 OP가 되었는지 확인합니다.
            // alStatus가 OP가 아닌 slave는 정상적으로 제어되지 않습니다.
            ec.EEcAlState alState = ec.EEcAlState.INITIAL;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            bool isSuccess = false;
            while (sw.ElapsedMilliseconds < 10000 && !isSuccess)
            {
                isSuccess = true;
                for (int i = 0; i < slaveCount; i++)
                {
                    alState = ec.ecSlv_GetAlState_A(netID, i, ref errorCode);
                    if (alState != ec.EEcAlState.OP || errorCode != 0)
                    {
                        isSuccess = false;
                        break;
                    }
                }
                Thread.Sleep(200);
            }

            if (!isSuccess)
            {
                for (int i = 0; i < slaveCount; i++)
                {
                    alState = ec.ecSlv_GetAlState_A(netID, i, ref errorCode);
                    if (alState != ec.EEcAlState.OP || errorCode != 0)
                        AddLog(string.Format("슬레이브 : {0} 의 AlState를 OP로 설정하는데 실패하였습니다.", i));                
                }

                return false;
            }
            
            AddLog("MasterDevice Init Compt");
            return true;
        }

        /// <summary>
        /// Config된 정보와 Scan된 정보 비교 (설정값과 실제값 비교)
        /// </summary>
        /// <returns></returns>
        public bool CheckChannel()
        {
            // Scan 된 Axis나 IO 채널 수를 비교하려면 아래 코드를 수행합니다.
            // 연결된 축리스트를 확인합니다.            
            byte[] axisList = new byte[32];            
            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, 32, ref errorCode);
            Array.Resize(ref axisList, axisCount);            

            if (errorCode != 0)
            {
                AddLog(errorCode);
                return false;
            }

            if (axisCount == 0)
            {
                // 서보를 사용하는 경우에만 에러처리 합니다.
                AddLog("연결된 축이 없습니다.");                
            }

            // config 된 DI Channel 수를 확인합니다.
            int totalDiCount = ec.ecdiGetNumChannels(netID, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return false;
            }

            // config 된 DO Channel 수를 확인합니다.
            int totalDoCount = ec.ecdoGetNumChannels(netID, ref errorCode);
            if (errorCode != 0)
            {
                AddLog(errorCode);
                return false;
            }

            int definedAxisCount = 8; // 실제 설치되어 있는 서보 드라이버의 수
            if (definedAxisCount != axisCount)
            {
                // axisCount 가 다른 경우 물리적으로 연결되지 않은 축이 있는지 확인합니다.
                // 모두 연결되어 있다면 config를 다시 실행합니다.
                AddLog("연결되지 않은 축이 있거나 Config 정보가 다릅니다.");
                return false;
            }

            int definedDiCount = 32; // 실제 설치되어 있는 di channel 수
            int definedDoCount = 32; // 실제 설치되어 있는 do channel 수

            if (definedDiCount != totalDiCount)
            {
                AddLog("연결되지 않은 DI Slave가 있거나 Config 정보가 다릅니다.");
                return false;
            }

            if (definedDoCount != totalDoCount)
            {
                AddLog("연결되지 않은 DO Slave가 있거나 Config 정보가 다릅니다.");
                return false;
            }

            return true;
        }


        /// <summary>
        /// FW - WDM - DLL 간 버전 호환성을 확인
        /// </summary>
        private bool GetVersionCompResult()
        {
            ec.TEcFileVerInfo_SDK sdkInfo = new ec.TEcFileVerInfo_SDK();
            ec.TEcFileVerInfo_WDM driverInfo = new ec.TEcFileVerInfo_WDM();
            ec.TEcFileVerInfo_FW fwInfo = new ec.TEcFileVerInfo_FW();
            
            bool isSuccess = ec.ecNet_GetVerInfo(netID, ref sdkInfo, ref driverInfo, ref fwInfo, ref errorCode);

            if (!isSuccess)
            {
                //FW - SDK 호환성 결과
                switch (sdkInfo.nFwCompResult)
                {
                    case (int)ec.EEcVerCompatResult.ecVER_MISMATCH_LOWER: AddLog("Library version is higher than the Firmware"); return false;
                    case (int)ec.EEcVerCompatResult.ecVER_MISMATCH_HIGHER: AddLog("Library version is lower than the Firmware"); return false;
                    case (int)ec.EEcVerCompatResult.ecVER_MATCH: AddLog("FW-SDK : OK"); break;
                    default: AddLog("Firmware Version is invalid"); return false;
                }

                //FW-WDM 호환성 결과
                switch (driverInfo.nFwCompResult)
                {
                    case (int)ec.EEcVerCompatResult.ecVER_MISMATCH_LOWER: AddLog("Driver version is higher than the Firmware"); return false;
                    case (int)ec.EEcVerCompatResult.ecVER_MISMATCH_HIGHER: AddLog("Driver version is lower than the Firmware"); return false;
                    case (int)ec.EEcVerCompatResult.ecVER_MATCH: AddLog("FW-WDM : OK"); break;
                    default: AddLog("Firmware Version is invalid"); return false;
                }

                //SDK-WDM
                switch (sdkInfo.nWdmCompResult)
                {
                    case (int)ec.EEcVerCompatResult.ecVER_MISMATCH_LOWER: AddLog("Driver version is lower than the Library"); return false;
                    case (int)ec.EEcVerCompatResult.ecVER_MISMATCH_HIGHER: AddLog("Library version is lower than the Driver"); return false;
                    case (int)ec.EEcVerCompatResult.ecVER_MATCH: AddLog("SDK-WDM : OK"); break;
                    default: AddLog("Driver Version is invalid"); return false;
                }
            }
            
            return isSuccess;
        }
                
        /// <summary>
        /// 슬레이브의 Inport / Outport가 반대가 삽입된 모듈을 검색합니다.
        /// </summary>
        private bool CheckReveseConnection()
        {
            if (!CanCheckReverseConnection())
                return false;
            
            // 역삽입된 슬레이브의 수를 확인합니다.
            int scanSlaveCount = 0;
            int reverseConnectionCount = ec.ecNet_CheckReverseConnections(netID, ref scanSlaveCount, ref errorCode);

            // 정의된 슬레이브 수가 있다면, 스캔된 슬레이브의 수와 비교합니다.
            //if (definedSlaveCount != scanSlaveCount)
            //{
            //    // 두 변수값의 차이는 Config 되었지만 현재 연결되어 있지 않은 슬레이브의 수입니다.
            //    AddLog(string.Format("Disconnected Slave Count = {0}", definedSlaveCount - scanSlaveCount));
            //}

            // reverseConnectionCount 값이 0인 경우, 역삽입된 모듈이 없는 경우이므로 정상입니다.
            if (reverseConnectionCount == 0)
            {
                AddLog(string.Format("ReverseConnection is nothing."));
                return true;
            }                
            else
            {
                AddLog(string.Format("ReverseConnectionCount = {0}", reverseConnectionCount));

                bool isReverseConnected = false;
                // 역삽입된 모듈이 있는 경우, 슬레이브별로 역삽입 여부를 확인합니다.
                for (ushort i = 0; i < scanSlaveCount; i++)
                {                    
                    isReverseConnected = ec.ecSlv_IsReverseConnected_A(netID, i, ref errorCode);

                    if (isReverseConnected)
                        AddLog(string.Format("Check SlaveIndex {0} : ReverseConnected", i));
                }
                return false;
            }
        }

        /// <summary>
        /// 역삽입 검출 기능을 사용할 수 있는지 확인
        /// DLL : 1.5.3.2 ( FW : 1.92 / WDM : 1.5.0.6)  이상의 버전에서 사용 가능
        /// </summary>        
        private bool CanCheckReverseConnection()
        {
            ec.TEcFileVerInfo_SDK sdkInfo = new ec.TEcFileVerInfo_SDK();
            ec.TEcFileVerInfo_WDM driverInfo = new ec.TEcFileVerInfo_WDM();
            ec.TEcFileVerInfo_FW fwInfo = new ec.TEcFileVerInfo_FW();

            //FW / Driver / Library의 버전을 확인합니다.
            bool isSuccess = ec.ecNet_GetVerInfo(netID, ref sdkInfo, ref driverInfo, ref fwInfo, ref errorCode);
            string sdkVer = string.Format("{0}{1}{2}{3}", sdkInfo.CurVer.MajorVer, sdkInfo.CurVer.MinorVer, sdkInfo.CurVer.BuildNo, sdkInfo.CurVer.RevNo);
            int curVer = int.Parse(sdkVer);

            // Library의 버전이 1.5.3.2 이하인 경우 해당 기능을 사용할 수 없습니다.
            if (curVer < 1532)
            {
                AddLog("CheckReverseConnection : Not Supported version");
                return false;
            }

            return true;
        }

        private void formInitialize_Shown(object sender, EventArgs e)
        {

            if (MasterDeviceInit())
            {
                this.Close();
            }
        }
    }
}
