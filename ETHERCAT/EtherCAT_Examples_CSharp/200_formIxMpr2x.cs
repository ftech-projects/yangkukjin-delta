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
    public partial class formIxMpr2x : Form
    {
        // 자동 원호 삽입 기능에 대한 예제

        public formIxMpr2x()
        {
            InitializeComponent();
            UpdateAxisList();
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
        }


        void AddLog(int errorCode)
        {
            MessageBox.Show(string.Format("ErrorCode : {0}", errorCode));
        }

    #endregion

        int axisX = 0;
        int axisY = 0;
        int ixMapIndex = 0;

        private void btnTest_Click(object sender, EventArgs e)
        {
            axisX = axisList[cbxAxisX.SelectedIndex];
            axisY = axisList[cbxAxisY.SelectedIndex];

            // 보간 맵 설정
            ec.ecmIxCfg_MapAxes(netID, ixMapIndex, 2, new int[2] { axisX, axisY }, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            int speedType = 1; // Vector Speed
            int speedMode = 2; // S-Curve
            double init = 0;
            double end = 0;
            double workSpeed = 100000;
            double accel = 400000;
            double decel = 400000;

            
                        
            // 보간 속도 설정
            ec.ecmIxCfg_SetSpeedPatt(netID, ixMapIndex, speedType, speedMode, init, end, workSpeed, accel, decel, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }
            
            // 지정된 보간맵에 생성했던 MPRLine2X 오브젝트를 삭제
            ec.ecmIxCfg_MPRLin2X_ClearPool(netID, ixMapIndex, ref errorCode);

            // 지정된 보간맵에 MPRLin2X 오브젝트를 생성하여 생성 된 핸들값으로 보간 제어
            // 하나의 보간맵 Pool에 여러개의 오브젝트 등록하여 사용 가능
            // numRefPoints : 등록할 Reference 좌표 개수
            // isAbsPosMode - 0 : 상대좌표로 등록, 1 : 절대 좌표로 등록

            uint pointCount = 8;
            bool isAbsPosMode = false;
            IntPtr obj = ec.ecmIxCfg_MPRLin2X_AddNewObj(netID, ixMapIndex, pointCount, isAbsPosMode, ref errorCode);
            if (errorCode != 0) //에러처리
            {
                AddLog(errorCode);
                return;
            }

            
            // 보간 이송 시 기준 포인트의 좌표를 설정
            // ecmIxCfg_MPRLin2X_AddNewObj 함수에서 설정한 numRefPoint 만큼 수행해야 함
            // pointIndex = 포인트 순서 번호
            // point : 등록할 좌표 배열
            // roundData : 라운드를 삽입하는 경우, 라운드의 크기 설정, 값은 roundDataType에 따라 다름
            // roundDataType : 삽입되는 라운드 형식
            //   0 (DT_NONE) : 라운드 미삽입
            //   1 (DT_RADIUS) : RoundData 는 라운드의 반지름
            //   2 (DT_OFFSET) : 라운드 시작, 종료 위치에 포인트에서의 offset 거리 반영
            int roundDataType = (int)ec.EEcmRoundDataType.RADIUS;
            double roundData = 4000;
            int pointIndex = 0;           
            
            ec.ecmIxCfg_MPRLin2X_SetRefPoint(netID, ixMapIndex, obj, pointIndex++, new double[2] { 0, 0 }, 0, 0, ref errorCode);
            ec.ecmIxCfg_MPRLin2X_SetRefPoint(netID, ixMapIndex, obj, pointIndex++, new double[2] { 20000, 20000 }, roundData, roundDataType, ref errorCode);
            ec.ecmIxCfg_MPRLin2X_SetRefPoint(netID, ixMapIndex, obj, pointIndex++, new double[2] { 60000, 20000 }, roundData, roundDataType, ref errorCode);
            ec.ecmIxCfg_MPRLin2X_SetRefPoint(netID, ixMapIndex, obj, pointIndex++, new double[2] { 60000, 60000 }, roundData, roundDataType, ref errorCode);
            ec.ecmIxCfg_MPRLin2X_SetRefPoint(netID, ixMapIndex, obj, pointIndex++, new double[2] { 0, 60000 }, roundData, roundDataType, ref errorCode);
            ec.ecmIxCfg_MPRLin2X_SetRefPoint(netID, ixMapIndex, obj, pointIndex++, new double[2] { 0, 20000 }, roundData, roundDataType, ref errorCode);
            ec.ecmIxCfg_MPRLin2X_SetRefPoint(netID, ixMapIndex, obj, pointIndex++, new double[2] { 10000, 20000 }, roundData, roundDataType, ref errorCode);
            ec.ecmIxCfg_MPRLin2X_SetRefPoint(netID, ixMapIndex, obj, pointIndex++, new double[2] { 0, 0 }, 0, 0, ref errorCode);
            // 에러처리 생략
            
            // 지정된 보간맵의 MPRLin2X 오브젝트 빌드
            // lastPointBuf = 오브젝트 생성시 반환된 오브젝트 핸들값
            double[] lastPointBuf = new double[pointCount];
            ec.ecmIxCfg_MPRLin2X_BuildObj(netID, ixMapIndex, obj, lastPointBuf, ref errorCode);

            // 이송 시작
            // isReverseDir : 이송 방향 결정. 0 : 정방향. 1 : 역방향
            bool isReverseDirection = false;
            ec.ecmIxMot_MPRLin2X_Start(netID, ixMapIndex, obj, isReverseDirection, ref errorCode);
            if (errorCode != 0)// 에러처리
            {
                AddLog(errorCode);
                return;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            int isDecelStop = 1;
            int isWaitCompt = 1;
            ec.ecmIxMot_Stop(netID, ixMapIndex, isDecelStop, isWaitCompt, ref errorCode);
            if (errorCode != 0)// 에러처리
            {
                AddLog(errorCode);
                return;
            }
        }
    }
}
