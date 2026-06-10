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
    public partial class formSpline : Form
    {
        public formSpline()
        {
            InitializeComponent();
            UpdateAxisList();
        }

    #region base

        int netID = 5;
        int axisID_X = 0;
        int axisID_Y = 0;
        int errorCode = 0;
        byte[] axisList = new byte[32];

        private void UpdateAxisList()
        {
            cbxSplineIndex.Items.Clear();
            cbxAxisX.Items.Clear();
            cbxAxisY.Items.Clear();

            for (int i = 0; i < 16; i++)
                cbxSplineIndex.Items.Add(string.Format("{0:00}", i));

            int axisCount = ec.ecmGn_GetAxisList(netID, axisList, (byte)axisList.Length, ref errorCode);
            if (errorCode != 0) //Error 처리
                AddLog(errorCode);

            for (int i = 0; i < axisCount; i++)
            {
                cbxAxisX.Items.Add(string.Format("{0:00}", axisList[i]));
                cbxAxisY.Items.Add(string.Format("{0:00}", axisList[i]));
            }

            cbxSplineIndex.SelectedIndex = 0;
                
            if (axisCount > 0)
                cbxAxisX.SelectedIndex = 0;

            if (axisCount > 1)
                cbxAxisX.SelectedIndex = 1;
        }


        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

    #endregion

        int mapIndex = 0;

        int speedType = 0;
        int speedMode = 0;
        double init = 0;
        double end = 0;
        double work = 0;
        double acc = 0;
        double dec = 0;
        double jerkRatio = 0;

        IntPtr obj = IntPtr.Zero;
        List<double[]> posList;
        

        private void cbxSplineIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            // 포인트가 많은 경우 Thread나 Task 등으로 처리한다.
            
            // 보간 맵을 설정한다.
            // 최대 8차원 Spline까지 가능하며, 본 예제에서는 2차원 Spline을 다룬다.
            mapIndex = cbxSplineIndex.SelectedIndex;
            int axisX = cbxAxisX.SelectedIndex;
            int axisY = cbxAxisY.SelectedIndex;
            const int axisCount = 2;

            int[] splineAxisList = new int[axisCount] { axisX, axisY };

            ec.ecmIxCfg_MapAxes(netID, mapIndex, axisCount, splineAxisList, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 지정된 보간 맵에 생성된 스플라인 오브젝트를 삭제한다.
            // 이 함수를 수행하지 않고 ecIxCfg_Spline_AddNewObj 함수를 반복 수행하면
            // 마스터 장치 내의 메모리 부족 현상이 일어날 수 있다.
            ec.ecmIxCfg_Spline_ClearPool(netID, mapIndex, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // pointCount : spline 맵 빌드시 참조할 point(Ref Point) 수
            uint pointCount = (uint)rtbPos.Lines.Count();

            // isAbsPos : 절대좌표여부 확인( true : 절대좌표 / false : 상대좌표)
            bool isAbsPos = false;

            // 지정된 보간맵에 스플라인 오브젝트를 생성한다.
            // 여기서 생성한 오브젝트의 핸들값으로 스플라인 보간을 제어.
            // 하나의 보간 맵 pool에 여러개의 오브젝트를 등록하여 사용할 수 있다.
            obj = ec.ecmIxCfg_Spline_AddNewObj(netID, mapIndex, pointCount, isAbsPos, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }
            
            posList = new List<double[]>();

            // UI 처리 : Point 확인 
            string[] items = rtbPos.Text.Split("\r\n".ToCharArray());
            foreach (string s in items)
            {
                if (string.IsNullOrEmpty(s))
                    break;

                string[] sub = s.Split(',');
                double[] pos = new double[axisCount];

                for (int i = 0; i < axisCount; i++)
                    double.TryParse(sub[i], out pos[i]);
            }

            // Ref Point 등록            
            for (int i = 0; i < pointCount; i++)
                ec.ecmIxCfg_Spline_SetRefPoint(netID, mapIndex, obj, i, posList[i], axisCount, ref errorCode);

            // Build
            // 동일한 스플라인 모션을 반복할 경우, Build는 최초 1회만 실행
            ec.ecmIxCfg_Spline_BuildObj(netID, mapIndex, obj, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // 보간 속도를 설정한다.           
            if (obj == null)
                return;

            speedType = cbxSpeedType.SelectedIndex;
            speedMode = cbxSpeedMode.SelectedIndex;
            double.TryParse(tbxInit.Text, out init);
            double.TryParse(tbxEnd.Text, out end);
            double.TryParse(tbxWork.Text, out work);
            double.TryParse(tbxAccel.Text, out acc);
            double.TryParse(tbxDecel.Text, out dec);

            ec.ecmIxCfg_SetSpeedPatt(netID, mapIndex, speedType, speedMode, init, end, work, acc, dec, ref errorCode);

            // 보간 속도 설정 중 Jerk Ratio를 설정한다.
            double.TryParse(tbxJerk.Text, out jerkRatio);
            ec.ecmIxCfg_SetJerkRatio(netID, mapIndex, jerkRatio, ref errorCode);

            // 첫번째 좌표를 시작점으로 한다.
            ec.ecmIxMot_LineTo(netID, mapIndex, posList[0], ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 역방향으로 진행할지 설정
            // true인 경우 마지막 등록된 좌표값이 첫번째 point가 된다.
            bool isReverseDir = false;

            ec.ecmIxMot_Spline_Start(netID, mapIndex, obj, isReverseDir, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }
        }


        private void btnJsSetup_Click(object sender, EventArgs e)
        {
            // Spline 모션 중 기준 값 이상의 Jerk 가 발생할 시 
            // 미리 지정된 ratio 및 감속 시간으로 지정된 유지시간 동안 감속한다.
            // 급격한 가감속으로 인한 진동, 소음의 발생을 방지할 수 있다.

            if(obj == null)
                return;

            // JerkSmoothingType을 설정한다. (0 : Disable / 1 : JerkThrehHold)
            int jsType = cbxJerkType.SelectedIndex;
            ec.ecmIxCfg_Spline_GetJsType(netID, mapIndex, obj, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            if(jsType == 0)
                return;
            
            // JerkSmoothing 관련 환경 설정. EEcmSplJsPropId  참조            
            // EEcmSplJsPropId.ecmJSPROP_DEC_TIME_ms : 감속시간 (단위 : ms)
            
            double decelTime = 0;
            double.TryParse(tbxDecelTime.Text, out decelTime);

            ec.ecmIxCfg_Spline_SetJsProp_F(netID, mapIndex, obj, (int)ec.EEcmSplJsPropId.ecmJSPROP_DEC_TIME_ms, decelTime, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }
                        
            // EEcmSplJsPropId.ecmJSPROP_LOWVEL_DUR_ms : 감속 후 유지시간 (단위 : ms)
            double duration = 0;
            double.TryParse(tbxDuration.Text, out duration);
            ec.ecmIxCfg_Spline_SetJsProp_F(netID, mapIndex, obj, (int)ec.EEcmSplJsPropId.ecmJSPROP_LOWVEL_DUR_ms, duration, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // ec.EEcmSplJsPropId.ecmJSPROP_LOWVEL_RATIO : 감속 비
            double lowVelRatio = 0;
            double.TryParse(tbxLowVelRatio.Text, out lowVelRatio);
            ec.ecmIxCfg_Spline_SetJsProp_F(netID, mapIndex, obj, (int)ec.EEcmSplJsPropId.ecmJSPROP_LOWVEL_RATIO, lowVelRatio, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            // 각 축에 대해 ThreshHold 값을 설정한다.
            // 해당 축의 Jerk 값이 ThreshHold 값을 넘으면 Jerk Smoothing 기능이 적용된다.
            double jsThreshHold_X = 0;
            double.TryParse(tbxThreshHold_X.Text, out jsThreshHold_X);
            double jsThreshHold_Y = 0;
            double.TryParse(tbxThreshHold_Y.Text, out jsThreshHold_Y);
                        
            ec.ecmIxCfg_Spline_SetJerkThresh(netID, mapIndex, obj, axisID_X, jsThreshHold_X, ref errorCode);
            ec.ecmIxCfg_Spline_SetJerkThresh(netID, mapIndex, obj, axisID_Y, jsThreshHold_Y, ref errorCode);    
            // 에러처리 생략
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            // 감속 정지 여부 설정
            int isDecelStop = 1;
            
            // 모션 정지시까지 대기할지 여부 설정
            int isWaitCompt = 1;

            // 정지
            ec.ecmIxMot_Stop(netID, mapIndex, isDecelStop, isWaitCompt, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

        }


        private void UpdateForm()
        {
            // 보간맵에 설정된 속도값을 확인한다.
            mapIndex = cbxSplineIndex.SelectedIndex;
            ec.ecmIxCfg_GetSpeedPatt(netID, mapIndex, ref speedType, ref speedMode, ref init, ref end, ref work, ref acc, ref dec, ref errorCode);
            jerkRatio = ec.ecmIxCfg_GetJerkRatio(netID, mapIndex, ref errorCode);

            cbxSpeedType.SelectedIndex = speedType;
            cbxSpeedMode.SelectedIndex = speedMode;
            tbxInit.Text = init.ToString();
            tbxEnd.Text = end.ToString();
            tbxWork.Text = work.ToString();
            tbxAccel.Text = acc.ToString();
            tbxDecel.Text = dec.ToString();
            tbxJerk.Text = jerkRatio.ToString();
                        
            if(obj == null)
                return;

            // 보간맵에 설정된 JerkSmoothing Type을 확인한다.
            // 이하 에러처리 생략
            int jsType = ec.ecmIxCfg_Spline_GetJsType(netID, mapIndex, obj, ref errorCode);
                                    
            if (jsType == 0) // JsType == Disable 인 경우
            {
                cbxJerkType.SelectedIndex = 0;
                return;
            }
               

            // 보간맵에 설정된 JerkSmoothing의 설정값을 확인한다.
            double decelTime = ec.ecmIxCfg_Spline_GetJsProp_F(netID, mapIndex, obj, (int)ec.EEcmSplJsPropId.ecmJSPROP_DEC_TIME_ms, ref errorCode);
            double duration = ec.ecmIxCfg_Spline_GetJsProp_F(netID, mapIndex, obj, (int)ec.EEcmSplJsPropId.ecmJSPROP_LOWVEL_DUR_ms, ref errorCode);
            double velRatio = ec.ecmIxCfg_Spline_GetJsProp_F(netID, mapIndex, obj, (int)ec.EEcmSplJsPropId.ecmJSPROP_LOWVEL_RATIO, ref errorCode);
            
            tbxDecelTime.Text = decelTime.ToString();
            tbxDuration.Text = duration.ToString();
            tbxLowVelRatio.Text = lblLowVelRatio.ToString();

            // ThreshHold 값 (기준값)을 확인한다.
            double threshHold_X = ec.ecmIxCfg_Spline_GetJerkThresh(netID, mapIndex, obj, axisID_X, ref errorCode);
            double threshHold_Y = ec.ecmIxCfg_Spline_GetJerkThresh(netID, mapIndex, obj, axisID_Y, ref errorCode);

            tbxThreshHold_X.Text = threshHold_X.ToString();
            tbxThreshHold_Y.Text = threshHold_Y.ToString();
        }        
    }
}
