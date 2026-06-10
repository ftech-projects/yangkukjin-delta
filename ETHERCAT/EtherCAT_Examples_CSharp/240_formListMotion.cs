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
using System.Diagnostics;

using ec = ComiLib.EtherCAT.SafeNativeMethods;

namespace EtherCAT_Examples_CSharp
{
    public partial class formListMotion : Form
    {
        public formListMotion()
        {
            InitializeComponent();

            if (!ec.ecGn_IsDevLoaded(0, ref errorCode))
                ec.ecGn_LoadDevice(ref errorCode);

            UpdateAxisList();
        }

    #region base

        int netID = 5;
        int axisID = 0;
        int errorCode = 0;
        byte[] axisList = new byte[32];

        private void UpdateAxisList()
        {
            if (!ec.ecGn_IsDevLoaded(0, ref errorCode))
                ec.ecGn_LoadDevice(ref errorCode);

            cbxAxisList.Items.Clear();
            cbxAxisX.Items.Clear();
            cbxAxisY.Items.Clear();

            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, (byte)axisList.Length, ref errorCode);
            if (errorCode != 0) //Error 처리
                AddLog(errorCode);

            Array.Resize(ref axisList, axisCount);

            for (int i = 0; i < axisCount; i++)
            {
                cbxAxisList.Items.Add(string.Format("{0:00}", axisList[i]));
                cbxAxisX.Items.Add(string.Format("{0:00}", axisList[i]));
                cbxAxisY.Items.Add(string.Format("{0:00}", axisList[i]));
            }
                
            if (axisCount > 0)
            {
                cbxAxisList.SelectedIndex = 0;
                cbxAxisX.SelectedIndex = 0;
                cbxAxisY.SelectedIndex = 0;
            }

            if (axisCount > 1)
                cbxAxisY.SelectedIndex = 1;
        }

        private void cbxAxisList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int axisIndex = cbxAxisList.SelectedIndex;
            axisID = axisList[axisIndex];
            
            // 지정된 축이 관여된 리스트 모션 맵 번호를 반환한다. 코드 참고용
            // 리스트모션에 참여하지 않고 있다면 -1 반환
            lmMapIndex = ec.ecmSxSt_GetLmMapIdx(netID, axisID, ref errorCode);
        }


        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

    #endregion


        int lmMapIndex = 0;


private void btnTest_Click(object sender, EventArgs e)
{
    // 하나의 축에 대해 위치별로 속도를 변경하여 속도 프로파일을 생성하는 예제
    // 가속구간과 감속 구간을 세구간으로 나누어 다른 속도 패턴으로 이송 (세단계 가속, 세단계 감속)
    // 에러처리는 생략.
    // 리스트모션 맵인덱스, 
    // 최대 8개까지 지원 됨 (0~7)


    // 0~31번 축 중에서 리스트 모션에 참여하는 축의 Mask,
    // 1,2,3 번 참여시 axisMask1 = 14
    uint axisMask1 = 0;

    // 32~63번 축 중에서 리스트 모션에 참여하는 축의 Mask, 
    uint axisMask2 = 0;
    int speedMode = (int)ec.EEcmSpeedMode.ecmSMODE_TRAPE;
    int stepID = 0;
            
    if (axisList.Count() < 31)
    {
        axisMask1 = (uint)(1 << axisID);
        axisMask2 = 0;
    }
    else
    {
        axisMask1 = 0;
        axisMask2 = (uint)(0x01 << (axisID - 32));
    }

    lmMapIndex = 0;

    double initSpeed = 0;
    double endSpeed = 0;
    double workSpeed = 0;
    double accel = 0;
    double decel = 0;

            
    // 리스트 모션 기능을 시작한다.
    // 이후 실행되는 명령은 리스트모션 테이블에 등록되며, ecmLmCtl_Run() 함수 실행시 순차 실행된다.            
    ec.ecmLmCtl_Begin(netID, lmMapIndex, axisMask1, axisMask2, ref errorCode);

    // lmMapIndex 에 해당하는 리스트모션 테이블에 등록되어 있는 모든 스텝을 제거한다.
    ec.ecmLmCtl_ClearQue(netID, lmMapIndex, ref errorCode);
            
    // 다음 속도 패턴으로 이어지고 가속만 존재하는 경우.
    initSpeed = 0;
    endSpeed = 20000; 
    accel = 10000;
    decel = 0; // 감속이 없으므로 decel = 0
    workSpeed = endSpeed;  // 감속이 없는 경우 workSpeed와 endSpeed는 같다.
    ec.ecmSxCfg_SetSpeedPatt(netID, axisID, speedMode, initSpeed, endSpeed, workSpeed, accel, decel, ref errorCode);
                        
    // 실행되는 명령에 ID 를 부여한다.            
    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);

    // 이송 예약            
    ec.ecmSxMot_MoveStart(netID, axisID, 20000, ref errorCode);
            
    // 다음 속도 패턴으로 이어지고 가속과 정속만 존재하는 경우
    initSpeed = endSpeed; // 이전속도 패턴에서 이어지므로 이전 속도 패턴의 endSpeed가 InitSpeed가 된다.
    endSpeed = 40000; //
    accel = 20000;
    decel = 0;
    workSpeed = endSpeed; // 감속이 없는 경우 workSpeed와 endSpeed는 같다.
    ec.ecmSxCfg_SetSpeedPatt(netID, axisID, speedMode, initSpeed, endSpeed, workSpeed, accel, decel, ref errorCode);

    // 이송 예약            
    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);
    ec.ecmSxMot_MoveStart(netID, axisID, 50000, ref errorCode);

    // 다음 속도 패턴으로 이어지고 가속과 정속, 감속이 존재하는 경우
    initSpeed = endSpeed; // 이전속도 패턴에서 이어지므로 이전 속도 패턴의 endSpeed가 InitSpeed가 된다.
    endSpeed = 40000; //
    accel = 10000;
    decel = 10000; 
    workSpeed = 50000;
    ec.ecmSxCfg_SetSpeedPatt(netID, axisID, speedMode, initSpeed, endSpeed, workSpeed, accel, decel, ref errorCode);

    // 이송 예약            
    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);
    ec.ecmSxMot_MoveStart(netID, axisID, 100000, ref errorCode);

    // 가속 없이 정속 이송 후, 감속하는 경우
    initSpeed = endSpeed; // 이전속도 패턴에서 이어지므로 이전 속도 패턴의 endSpeed가 InitSpeed가 된다.
    endSpeed = 20000; //
    accel = 0; // 가속이 없으므로 accel = 0
    decel = 20000;
    workSpeed = initSpeed; // 이전속도 패턴에서 이어지며, workSpeed 부터 시작하므로, workSpeed = initSpeed 가 된다.
    ec.ecmSxCfg_SetSpeedPatt(netID, axisID, speedMode, initSpeed, endSpeed, workSpeed, accel, decel, ref errorCode);

    // 이송 예약         
    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);
    ec.ecmSxMot_MoveStart(netID, axisID, 70000, ref errorCode);

    // 감속 후 이송완료
    initSpeed = endSpeed; // 이전속도 패턴에서 이어지므로 이전 속도 패턴의 endSpeed가 InitSpeed가 된다.
    endSpeed = 0; //
    accel = 0; // 가속이 없으므로 accel = 0
    decel = 10000;
    workSpeed = initSpeed;
    ec.ecmSxCfg_SetSpeedPatt(netID, axisID, speedMode, initSpeed, endSpeed, workSpeed, accel, decel, ref errorCode);

    // 이송 예약
    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID, ref errorCode);
    ec.ecmSxMot_MoveStart(netID, axisID, 20000, ref errorCode);
            
    // 등록된 명령 실행 시작
    ec.ecmLmCtl_Run(netID, lmMapIndex, ref errorCode);
            
    int runStepCount = 0, runStepID = 0, runStepState = 0;

    int timeLimit = 100000;
    Stopwatch sw = new Stopwatch();
    sw.Start();
    bool isSuccess = false;

    // 이송 시간이 timeLimit 보다 크면 에러처리. 본 예제에서는 생략한다.
    Task.Factory.StartNew(() =>
    {
        while (sw.ElapsedMilliseconds < timeLimit)
        {
            // 현재 실행되고 있는 스텝에 대한 정보를 확인한다.
            ec.ecmLmSt_GetRunStepInfo(netID, lmMapIndex, ref runStepCount, ref runStepID, ref runStepState, ref errorCode);

            // runStepID : 현재 실행되고 있는 StepID
            // runStepState : 현재 실행되고 있는 Step의 상태 (Ready, Busy, Paused, Completed)

            // 현재 실행되고 있는 StepID가 마지막 등록된 StepID와 같고, 실행 상태가 Complete 이면 리스토 모션 종료로 판단
            // StepCount로 비교하거나 ecmLmSt_GetRemStepCount 를 이용하여 RemStep 등으로 비교해도 된다.
            if (runStepCount == stepID && runStepState == (int)ec.EEcmLmCmdItemSts.ecmLM_CMDITEM_STS_COMPLETED)
            {
                isSuccess = true;
                break;
            }

            lblRunStepCount.BeginInvoke(new Action(() => lblRunStepCount.Text = runStepCount.ToString()));
            lblRunStepID.BeginInvoke(new Action(() => lblRunStepID.Text = runStepID.ToString()));
            lblRunStepState.BeginInvoke(new Action(() => lblRunStepState.Text = ((ec.EEcmLmCmdItemSts)runStepState).ToString()));
            Thread.Sleep(10);
        }

        if (!isSuccess)
        {
            // 에러처리
        }
        //리스토 모션 종료. 이후 이송 명령은 즉시 실행 됨
        ec.ecmLmCtl_End(netID, lmMapIndex, ref errorCode);
    });

    if (!isSuccess)
    {
        // 에러처리
    }
}

private void btnTest2_Click(object sender, EventArgs e)
{
    // 말풍선 그리기 예제
    // 에러처리는 생략.            

    // 리스트모션 맵인덱스, 
    // 최대 8개까지 지원 됨 (0~7)
            

    // 보간 제어를 위한 맵인덱스
    lmMapIndex = 0;
    int ixMapIndex = 0;
    // 0~31번 축 중에서 리스트 모션에 참여하는 축의 Mask,
    // 1,2,3 번 참여시 axisMask1 = 14
    uint axisMask1 = 0;

    // 32~63번 축 중에서 리스트 모션에 참여하는 축의 Mask, 
    uint axisMask2 = 0;
            
    int axisX = axisList[cbxAxisX.SelectedIndex];
    int axisY = axisList[cbxAxisY.SelectedIndex];
    // axisX < 32 & axisY < 32 로 간주
    axisMask1 = (uint)((1 << axisX) + (1 << axisY));
            
    // lmMapIndex 에 해당하는 리스트모션 테이블에 등록되어 있는 모든 스텝을 제거한다.
    ec.ecmLmCtl_ClearQue(netID, lmMapIndex, ref errorCode);

    // 리스트 모션 기능을 시작한다.
    // 이후 실행되는 명령은 리스트모션 테이블에 등록되며, ecmLmCtl_Run() 함수 실행시 순차 실행된다.
    ec.ecmLmCtl_Begin(netID, lmMapIndex, axisMask1, axisMask2, ref errorCode);

    // 보간맵 설정을 위한 axisList
    int[] ixAxisList = new int[2]{axisX, axisY};

    // 보간맵 설정
    ec.ecmIxCfg_MapAxes(netID, ixMapIndex, 2, ixAxisList, ref errorCode);

    int speedType = 1; //VectorSpeed;
    int speedMode = (int)ec.EEcmSpeedMode.ecmSMODE_TRAPE;

    // 첫번째 이송의 속도 설정 (가속만 설정)
    // endSpeed = workSpeed. decel = 0;
    ec.ecmIxCfg_SetSpeedPatt(netID, ixMapIndex, speedType, speedMode, 0, 10000, 10000, 100000, 0, ref errorCode);

    int stepID = 0;
            
    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);
    ec.ecmIxMot_LineTo(netID, lmMapIndex, new double[] { 0, 0 }, ref errorCode);

    // 두번째 ~ 마지막 두번째 이송까지의 속도 설정 (정속만 설정)
    // initSpeed, endSpeed = workSpeed. accel, decel = 0;
    ec.ecmIxCfg_SetSpeedPatt(netID, ixMapIndex, speedType, speedMode, 0, 10000, 10000, 100000, 0, ref errorCode);

    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);
    ec.ecmIxMot_LineTo(netID, lmMapIndex, new double[] { 20000, 20000 }, ref errorCode);

    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);
    ec.ecmIxMot_LineTo(netID, lmMapIndex, new double[] { 50000, 20000 }, ref errorCode);

    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);
    ec.ecmIxMot_ArcAng_A(netID, lmMapIndex, 50000, 30000, 90, ref errorCode);

    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);
    ec.ecmIxMot_LineTo(netID, lmMapIndex, new double[] { 60000, 50000 }, ref errorCode);

    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);
    ec.ecmIxMot_ArcAng_A(netID, lmMapIndex, 50000, 50000, 90, ref errorCode);

    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);
    ec.ecmIxMot_LineTo(netID, lmMapIndex, new double[] { -10000, 60000 }, ref errorCode);

    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);
    ec.ecmIxMot_ArcAng_A(netID, lmMapIndex, -10000, 50000, 90, ref errorCode);

    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);
    ec.ecmIxMot_LineTo(netID, lmMapIndex, new double[] { -20000, 30000 }, ref errorCode);

    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);
    ec.ecmIxMot_ArcAng_A(netID, lmMapIndex, -10000, 30000, 90, ref errorCode);

    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID++, ref errorCode);
    ec.ecmIxMot_LineTo(netID, lmMapIndex, new double[] { 10000, 20000 }, ref errorCode);

    // 마지막 이송 속도 설정 (감속만 설정)
    // initSpeed = workSpeed. accel, endSpeed = 0;
    ec.ecmIxCfg_SetSpeedPatt(netID, ixMapIndex, speedType, speedMode, 0, 10000, 10000, 100000, 0, ref errorCode);

    ec.ecmLmCfg_SetStepId(netID, lmMapIndex, stepID, ref errorCode);
    ec.ecmIxMot_LineTo(netID, lmMapIndex, new double[] { 0, 0 }, ref errorCode);
            
    // 등록된 명령 실행 시작
    ec.ecmLmCtl_Run(netID, lmMapIndex, ref errorCode);

    int runStepCount = 0, runStepID = 0, runStepState = 0;

    const int timeLimit = 10000;
    Stopwatch sw = new Stopwatch();
    sw.Start();
    bool isSuccess = false;

    // 이송 시간이 timeLimit 보다 크면 에러처리. 본 예제에서는 생략한다.
    // 이송 시간이 timeLimit 보다 크면 에러처리. 본 예제에서는 생략한다.
    Task.Factory.StartNew(() =>
    {
        while (sw.ElapsedMilliseconds < timeLimit)
        {
            // 현재 실행되고 있는 스텝에 대한 정보를 확인한다.
            ec.ecmLmSt_GetRunStepInfo(netID, lmMapIndex, ref runStepCount, ref runStepID, ref runStepState, ref errorCode);

            // runStepID : 현재 실행되고 있는 StepID
            // runStepState : 현재 실행되고 있는 Step의 상태 (Ready, Busy, Paused, Completed)

            // 현재 실행되고 있는 StepID가 마지막 등록된 StepID와 같고, 실행 상태가 Complete 이면 리스토 모션 종료로 판단
            // StepCount로 비교하거나 ecmLmSt_GetRemStepCount 를 이용하여 RemStep 등으로 비교해도 된다.
            if (runStepCount == stepID && runStepState == (int)ec.EEcmLmCmdItemSts.ecmLM_CMDITEM_STS_COMPLETED)
            {
                isSuccess = true;
                break;
            }

            lblRunStepCount.BeginInvoke(new Action(() => lblRunStepCount.Text = runStepCount.ToString()));
            lblRunStepID.BeginInvoke(new Action(() => lblRunStepID.Text = runStepID.ToString()));
            lblRunStepState.BeginInvoke(new Action(() => lblRunStepState.Text = ((ec.EEcmLmCmdItemSts)runStepState).ToString()));
            Thread.Sleep(10);
        }

        if (!isSuccess)
        {
            // 에러처리
        }
        //리스토 모션 종료. 이후 이송 명령은 즉시 실행 됨
        ec.ecmLmCtl_End(netID, lmMapIndex, ref errorCode);
    });

    if (!isSuccess)
    {
        // 에러처리
    }
}

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            // 현재 등록되어 있는 리스트모션 맵을 모두 해제한다.
            // 리스트 모션 구동 중 의도 하지 않은 상황에서 종료되어 해당 축이 리스트 모션 맵에 포함되어 있는 경우
            // 일반 이송 명령이 정상적으로 수행되지 않을 수 있다.

            ec.ecmLmResetAll(netID, ref errorCode);
            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }
        }

        private void btnLmStop_Click(object sender, EventArgs e)
        {
            // 현재 실행되고 있는 리스트모션의 실행을 일시 정지한다.


            // 현재 스텝이 완료될때까지 대기 후 정지
            bool isWaitCutStepCompt = true;
            
            // 정지 시 감속 시간
            int decelTime = 100;

            ec.ecmLmCtl_Stop(netID, lmMapIndex, isWaitCutStepCompt, decelTime, ref errorCode);
            if (errorCode != 0)
            {
                //에러처리
                AddLog(errorCode);
            }
        }

        private void btnLmRun_Click(object sender, EventArgs e)
        {
            // 정지된 리스트모션 명령을 재개한다.

            ec.ecmLmCtl_Run(netID, lmMapIndex, ref errorCode);
            if (errorCode != 0) //에러처리
                AddLog(errorCode);
        }

        uint ch = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            outChangeCount = 0;
            changeCount = 0;
            sw.Start();
            file = string.Format(@"{0}\log_{1}_{2}.log", Application.StartupPath, DateTime.Now.ToString("yyMMdd"), DateTime.Now.ToString("HHmmss"));
            button1.Enabled = false;
            for (int i = 0; i < 10; i++)
            {
                AddLog("Task Start");
                Task t = Task.Factory.StartNew(IoTest);
                t.Wait();

                AddLog("Task End");
                Thread.Sleep(st);

                AddLog("=========================END=============================");
            }
            button1.Enabled = true;
        }

        string str = string.Empty;
        int st = 1000;
        private void IoTest()
        {
            isRun = true;
            //button1.Invoke(new Action(() => button1.Enabled = false));

            
            int numCh = ec.ecdoGetNumChannels(0, ref errorCode);
            if (!uint.TryParse(tbxCh.Text, out ch))
            {
                MessageBox.Show("Ch Error");
                return;
            }
            else if (ch > numCh)
            {
                MessageBox.Show("Ch Error");
                return;
            }

            AddLog("ecmLmCtl_Begin");
            ec.ecmLmCtl_Begin(0, 0x00, 0, 0, ref errorCode);
            //------------------------------------------------------------
            //ec.ecmLmCmd_Delay(0, 0x00, st, ref errorCode);
            ec.ecdoLmPutOne(0, 0x00, ch, true, 0, ref errorCode);
            outChangeCount++;

            ec.ecmLmCmd_Delay(0, 0x00, st, ref errorCode);
            ec.ecdoLmPutOne(0, 0x00, ch, false, 0, ref errorCode);
            outChangeCount++;

            ec.ecmLmCmd_Delay(0, 0x00, st, ref errorCode);
            ec.ecdoLmPutOne(0, 0x00, ch, true, 0, ref errorCode);
            outChangeCount++;

            ec.ecmLmCmd_Delay(0, 0x00, st, ref errorCode);
            ec.ecdoLmPutOne(0, 0x00, ch, false, 0, ref errorCode);
            outChangeCount++;

            ec.ecmLmCmd_Delay(0, 0x00, st, ref errorCode);
            ec.ecdoLmPutOne(0, 0x00, ch, true, 0, ref errorCode);
            outChangeCount++;

            ec.ecmLmCmd_Delay(0, 0x00, st, ref errorCode);
            ec.ecmLmCfg_SetStepId(0, 0, 10, ref errorCode);
            ec.ecdoLmPutOne(0, 0x00, ch, false, 0, ref errorCode);
            outChangeCount++;
            //------------------------------------------------------------
            int LmRunSts;// , RunCount, RunStepId;

            LmRunSts = ec.ecmLmSt_GetRunSts(0, 0x00, ref errorCode);
            AddLog(((ec.EEcmLmSts)LmRunSts).ToString());
            ec.ecmLmCtl_Run(0, 0x00, ref errorCode);
            AddLog("ecmLmCtl_Run");


            //Thread.Sleep(300);
            //ec.ecmLmCmd_Delay(0, 0x00, st, ref errorCode);

            //Task.Factory.StartNew(() =>
            //{
            Stopwatch ssw = new Stopwatch();
            ssw.Start();
            while (true)
            {
                
                LmRunSts = ec.ecmLmSt_GetRunSts(0, 0x00, ref errorCode);
                //AddLog(string.Format("{0}, {1}", ((ec.EEcmLmSts)LmRunSts).ToString(), ssw.ElapsedMilliseconds));
                if (LmRunSts == (int)ec.EEcmLmSts.ecmLM_STS_RUN)
                    break;

                Thread.Sleep(10);
            }

            LmRunSts = ec.ecmLmSt_GetRunSts(0, 0x00, ref errorCode);
            AddLog(((ec.EEcmLmSts)LmRunSts).ToString());

            sw.Restart();
            et = 0;
            //str = string.Format("[{0}] [{1}]WaitCompt Start", DateTime.Now.ToString("HH:mm:ss.fff"), sw.ElapsedMilliseconds - et);
            //AddLog(str);
#if true
            while (isRun)
            {
                OutVal = ec.ecdoGetOne(0, ch, ref errorCode);
                //button2.Invoke(new Action(() => button2.BackColor = isOn ? Color.DarkOrange : Color.White));

                LmRunSts = ec.ecmLmSt_GetRunSts(0, 0x00, ref errorCode);
                if (LmRunSts == (int)ec.EEcmLmSts.ecmLM_STS_STANDBY || LmRunSts == (int)ec.EEcmLmSts.ecmLM_STS_DISABLED)
                {
                    str = string.Format("[{0}] [{1}]WaitCompt End. State : {2}", DateTime.Now.ToString("HH:mm:ss.fff"), sw.ElapsedMilliseconds - et, (ec.EEcmLmSts)LmRunSts);
                    AddLog(str);
                    isRun = false;
                }
                Thread.Sleep(10);
            }
            LmRunSts = ec.ecmLmSt_GetRunSts(0, 0x00, ref errorCode);
            AddLog(((ec.EEcmLmSts)LmRunSts).ToString());
#else

            int runStepCount = 0, runStepID = 0, runStepState = 0;
            
            while (isRun)
        {
                OutVal = ec.ecdoGetOne(0, ch, ref errorCode);
                // 현재 실행되고 있는 스텝에 대한 정보를 확인한다.
                ec.ecmLmSt_GetRunStepInfo(netID, lmMapIndex, ref runStepCount, ref runStepID, ref runStepState, ref errorCode);

                if (runStepID == 10 && runStepState == (int)ec.EEcmLmCmdItemSts.ecmLM_CMDITEM_STS_COMPLETED)
                {
                    Debug.WriteLine(string.Format("[{0}] [{1}]WaitCompt End", DateTime.Now.ToString("HH:mm:ss.fff"), sw.ElapsedMilliseconds - et));
                    isRun = false;
                }

            Thread.Sleep(10);
        }
#endif

            ec.ecmLmCtl_End(0, 0, ref errorCode);
            AddLog("ecmLmCtl_End");
            //button1.Invoke(new Action(() => button1.Enabled = true));
            //}).Wait() ;
        }

        void AddLog(string str)
        {
            Debug.WriteLine(str);

            using (var sw = System.IO.File.AppendText(file))
                sw.Write(string.Format("{0}\r\n", str));
        }

        string file;
        bool outVal = false;
        int outChangeCount = 0;
        long et = 0;
        Stopwatch sw = new Stopwatch();
        bool OutVal
        {
            get { return outVal; }
            set
            {
                if (value == outVal)
                    return;

                outVal = value;
                ChangeCount++;

                str = string.Format("[{0}] [{1}] OutCount : {2}, ChangeCount :{3} ({4})", DateTime.Now.ToString("HH:mm:ss.fff"), sw.ElapsedMilliseconds - et, outChangeCount, ChangeCount, outVal);
                AddLog(str);
                et = sw.ElapsedMilliseconds;
            }
        }

        int changeCount = 0;
        public int ChangeCount
        {
            get { return changeCount; }
            set
            {
                changeCount = value;                
            }
        }

        bool isRun = false;
    }
}
