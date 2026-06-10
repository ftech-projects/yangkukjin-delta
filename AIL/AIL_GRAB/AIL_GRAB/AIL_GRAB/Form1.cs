//using Basler.Pylon;
using System;
using System.Drawing;
using System.Windows.Forms;
using Zebra.AuroraImagingLibrary;
using static System.Net.WebRequestMethods;

namespace AIL_GRAB
{
    public partial class Form1 : Form
    {
        // MIL 식별자(ID) 변수 선언
        private AIL_ID MilApplication = AIL.M_NULL;
        private AIL_ID MilSystem = AIL.M_NULL;
        private AIL_ID MilDigitizer = AIL.M_NULL;
        private AIL_ID MilDisplay = AIL.M_NULL;
        private AIL_ID MilImage = AIL.M_NULL;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. AIL Application 할당
                AIL.MappAlloc(AIL.M_NULL, AIL.M_DEFAULT, ref MilApplication);

                // 2. Default System 할당 (GigE Vision Controller)  DEFAULT 시스템을 GIGE로..
                AIL.MsysAlloc(MilApplication, AIL.M_SYSTEM_DEFAULT, AIL.M_DEFAULT, AIL.M_DEFAULT, ref MilSystem);

                // 3. Digitizer 할당 (연결된 첫 번째 GIGE 카메라)
                AIL.MdigAlloc(MilSystem, 0, "M_DEFAULT", AIL.M_DEFAULT, ref MilDigitizer);

                // 4. Display 할당 및 Form의 PictureBox 또는 Handle에 연결
                AIL.MdispAlloc(MilSystem, AIL.M_DEFAULT, "M_DEFAULT", AIL.M_DEFAULT, ref MilDisplay);

                AIL_INT sizeX = AIL.MdigInquire(MilDigitizer, AIL.M_SIZE_X);

                AIL_INT sizeY = AIL.MdigInquire(MilDigitizer, AIL.M_SIZE_Y);

                // 5. 이미지 버퍼 할당
                AIL.MbufAlloc2d(MilSystem, sizeX, sizeY, 8 + AIL.M_UNSIGNED, AIL.M_IMAGE + AIL.M_GRAB + AIL.M_DISP, ref MilImage);

                AIL.MdispSelect(MilDisplay, MilImage); // 화면에 디스플레이 창 연결


            }
            catch (Exception ex)
            {
                MessageBox.Show("MIL 초기화 실패: " + ex.Message);
            }

        }

        private void btnGRAB_Click(object sender, EventArgs e)
        {
            // 6. 단일 이미지 획득 (Grab)
            // 카메라로부터 이미지를 1장 캡처하여 MilImage 버퍼에 저장합니다.
            AIL.MdigGrab(MilDigitizer, MilImage);

        }

        private void btnLIVE_Click(object sender, EventArgs e)
        {
            // 7. 연속 이미지 획득 (Live)
            // 백그라운드 스레드에서 연속적으로 이미지를 획득하며 라이브 영상을 띄웁니다.
            AIL.MdigGrabContinuous(MilDigitizer, MilImage);           

        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            // 8. Grab 정지
            AIL.MdigHalt(MilDigitizer);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 9. 리소스 해제 (역순으로 해제해야 함)
            if (MilImage != AIL.M_NULL) AIL.MbufFree(MilImage);
            if (MilDisplay != AIL.M_NULL) AIL.MdispFree(MilDisplay);
            if (MilDigitizer != AIL.M_NULL) AIL.MdigFree(MilDigitizer);
            if (MilSystem != AIL.M_NULL) AIL.MsysFree(MilSystem);
            if (MilApplication != AIL.M_NULL) AIL.MappFree(MilApplication);

        }
    }
}
