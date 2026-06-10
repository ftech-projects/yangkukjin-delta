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
using System.IO;
using System.Diagnostics;

using ec = ComiLib.EtherCAT.SafeNativeMethods;

namespace EtherCAT_Examples_CSharp
{
    public partial class formPtMotion : Form
    {        
        public formPtMotion()
        {
            InitializeComponent();
            UpdateAxisList();

            GetPosData();
        }

    #region base

        int netID = 5;
        int errorCode = 0;
        byte[] axisList = new byte[32];

        private void UpdateAxisList()
        {
            cbxAxisX.Items.Clear();

            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, (byte)axisList.Length, ref errorCode);
            if (errorCode != 0) //Error 처리
                AddLog(errorCode);

            for (int i = 0; i < axisCount; i++)
            {
                cbxAxisX.Items.Add(string.Format("{0:00}", axisList[i]));
                cbxAxisY.Items.Add(string.Format("{0:00}", axisList[i]));
            }
                
            if (axisCount > 0)
                cbxAxisX.SelectedIndex = 0;

            if (axisCount > 1)
                cbxAxisY.SelectedIndex = 1;

        }

        private void cbxAxisList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int axisIndex = cbxAxisX.SelectedIndex;
            axisX = axisList[axisIndex];

            // 지정된 축이 관여된 리스트 모션 맵 번호를 반환한다. 코드 참고용
            // 리스트모션에 참여하지 않고 있다면 -1 반환
            ptIndex = ec.ecmSxSt_GetPtmMapIdx(netID, axisX, ref errorCode);
        }


        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

    #endregion

        int axisX = 0;
        int axisY = 0;
        int ptIndex = 0;
        List<double[]> posData = new List<double[]>();

        private void GetPosData()
        {
            // PointData를 file에서 불러온다
            // 해당 부분은 PT Motion 과는 관련 없음

            string filePath = string.Format(@"{0}\data\MotionSeq_ PT Motion.csv", Application.StartupPath);
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File Not Found");
                return;
            }
            
            using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.GetEncoding("euc-kr")))
            {
                while (!sr.EndOfStream)
                {
                    var srcString = sr.ReadLine().Split(',');
                    double[] srcData = new double[srcString.Length];
                    for (int i = 0; i < srcString.Length; i++)
                        double.TryParse(srcString[i], out srcData[i]);

                    posData.Add(srcData);
                }
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            axisX = axisList[cbxAxisX.SelectedIndex];
            axisY = axisList[cbxAxisY.SelectedIndex];

            // PT Motion 기능 시작
            // 함수 호출 후 ecmPtmCfg_AddItem_PT 함수를 실행하면 등록된 Positoin-Table 값의 위치로 이송
            
            // ptIndex : PT Motion 맵 인덱스, 최대 8개까지 지원되며, 0~7 의 값을 가짐
            // axisMask1 : 0~31번 축 중에서 PT Motion 에 참여하는 축 Mask
            // axisMask2 : 32~63번 축 중에서 PT Motion 에 참여하는 축 Mask.
            uint axisMask1 = (uint)((1 << axisX) + (1 << axisY));
            uint axisMask2 = 0;
            ec.ecmPtmCtl_Begin(netID, ptIndex, axisMask1, axisMask2, ref errorCode);
            if (errorCode != 0)// 에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 포지션을 모두 등록한 후 이송을 하기 위해서는 ecmPtmCtl_SetHold()를 실행한다
     
            double durTime = 0;
            double[] posDataList;
            int numPosData = 2;
            bool isAbsPos = false;

            for (int i = 0; i < posData.Count; i++) 
            {
                // 위치와 시간 정보로 구성되는 이송스텝 등록
                // durTime : 이송 스텝의 지속시간. ms 단위로 설정
                // posDataList : 각 축이 해당 스텝에 이송해야 하는 거리 또는 좌표값
                // numPosData : 배열을 통해 전달되는 위치 데이터의 개수
                // isAbsPos : posDataList의 값이 거리값인지 위치값인지에 대한 설정

                durTime = i == 0 ? posData[i][0] : posData[i][0] - posData[i - 1][0];
                posDataList = new double[2] { posData[i][1], posData[i][2] };

                ec.ecmPtmCmd_AddItem_PT(netID, ptIndex, durTime, posDataList, numPosData, isAbsPos, ref errorCode);
                // 에러 처리 생략
            }

            //완료 처리
            ec.EEcmPtmSts runState = new ec.EEcmPtmSts();
            int runStepCount = 0;
            int remStepCount = 0;
            int totalCount = posData.Count;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            int limit = 10000;

            lblTotalCount.Text = totalCount.ToString();
            bool isSuccess = false;

            while (sw.ElapsedMilliseconds < limit)
            {
                // 동작상태를 확인한다.
                // runStepCount : 현재까지 실행 완료, 또는 실행중인 스텝의 수
                // remStepCount : 아직 실행되지 않고 대기 중인 스텝의 수
                // runState : 동작상태 
                //  DISABLED : PT Motion이 종료된 상태, ecmPtmCtl_Begin() 전이거나, ecmPtmCtl_End() 실행 후
                //  PAUSED : 기능이 활성화 되었지만 hold 상태 스텝 등록은 가능하지만 이송은 진행되지 않음
                //  RUN_IDLE : 기능이 활성화 되었지만, 등록된 커맨드가 없는 경우
                //  RUN_BUSY : 기능이 활성화 되었고, 커맨드가 실행중인 경우
                //  RUN_COMPT : 기능이 활성화 된 상태에서 커맨드가 모두 실행된 경우
                runState = ec.ecmPtmSt_GetRunSts(netID, ptIndex, ref runStepCount, ref remStepCount, ref errorCode);

                lblState.Text = runState.ToString();
                lblRunStepCount.Text = runStepCount.ToString();
                lblRemStepCount.Text = remStepCount.ToString();

                if (runState == ec.EEcmPtmSts.ecmPTM_STS_RUN_COMPT)
                {
                    isSuccess = true;
                    break;
                }

                if (runState == ec.EEcmPtmSts.ecmPTM_STS_DISABLED)
                    break;

                Thread.Sleep(50);
            }
                
            if(!isSuccess)
            {
                //에러처리
            }

            // PT Motion 기능 종료
            ec.ecmPtmCtl_End(netID, ptIndex, ref errorCode);              
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            // Hold 상태 셋팅
            // isHold : hold 상태 설정 (0 : 이송 중지, 1 : 이송 재개)
            
            bool isHold = false;
            ec.ecmPtmCtl_SetHold(netID, ptIndex, isHold, ref errorCode);
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            bool isHold = true;
            ec.ecmPtmCtl_SetHold(netID, ptIndex, isHold, ref errorCode);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            // PT Motion 기능 종료
            ec.ecmPtmCtl_End(netID, ptIndex, ref errorCode);
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            // 현재 등록되어 있는 PT Motion 맵을 모두 해제한다.
            // PT Motion 구동 중 의도 하지 않은 상황에서 종료되어 해당 축이 PT Motion 맵에 포함되어 있는 경우
            // 일반 이송 명령이 정상적으로 수행되지 않을 수 있다.

            ec.ecmPtmResetAll(netID, ref errorCode);
        }


    }
}
