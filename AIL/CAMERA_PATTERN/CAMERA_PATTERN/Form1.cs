using System;
using System.Windows.Forms;
using Zebra.AuroraImagingLibrary;

namespace CAMERA_PATTERN
{
    public partial class Form1 : Form
    {
        // AIL 객체
        private AIL_ID MilApplication = AIL.M_NULL;
        private AIL_ID MilSystem = AIL.M_NULL;
        private AIL_ID MilDigitizer = AIL.M_NULL;
        private AIL_ID MilDisplay = AIL.M_NULL;

        // 이미지 버퍼
        private AIL_ID MilImage = AIL.M_NULL;
        private AIL_ID MilProcImage = AIL.M_NULL;
        private AIL_ID MilTemplate = AIL.M_NULL;

        // Pattern
        private AIL_ID MilPatContext = AIL.M_NULL;
        private AIL_ID MilPatResult = AIL.M_NULL;

        // Overlay
        private AIL_ID MilGraphicList = AIL.M_NULL;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Application
                AIL.MappAlloc(AIL.M_NULL,
                               AIL.M_DEFAULT,
                               ref MilApplication);

                // System
                AIL.MsysAlloc(MilApplication,
                               AIL.M_SYSTEM_DEFAULT,
                               AIL.M_DEFAULT,
                               AIL.M_DEFAULT,
                               ref MilSystem);
                /*
                // Camera
                AIL.MdigAlloc(MilSystem,
                    AIL.M_DEFAULT,
                   "M_DEFAULT",
                    AIL.M_DEFAULT,
                    ref MilDigitizer);

                // Display
                AIL.MdispAlloc(
                    MilSystem,
                    AIL.M_DEFAULT,
                    "M_DEFAULT",
                    AIL.M_DEFAULT,
                    ref MilDisplay);
                */

                AIL.MdigAlloc(MilSystem,
                    0,
                   "M_DEFAULT",
                    AIL.M_DEFAULT,
                    ref MilDigitizer);

                // Display
                AIL.MdispAlloc(
                    MilSystem,
                    0,
                    "M_DEFAULT",
                    AIL.M_DEFAULT,
                    ref MilDisplay);

                IntPtr hWnd = panel1.Handle;

                              
                // Camera Size
                AIL_INT sizeX =
                    AIL.MdigInquire(MilDigitizer,
                                     AIL.M_SIZE_X);

                AIL_INT sizeY =
                    AIL.MdigInquire(MilDigitizer,
                                     AIL.M_SIZE_Y);

                // Grab Buffer
                AIL.MbufAlloc2d(
                    MilSystem,
                    sizeX,
                    sizeY,
                    8 + AIL.M_UNSIGNED,
                    AIL.M_IMAGE + AIL.M_GRAB + AIL.M_DISP,
                    ref MilImage);

                AIL.MdispSelectWindow(
                    MilDisplay,
                    MilImage,
                    panel1.Handle);

             
                AIL.MbufAlloc2d(
                    MilSystem,
                    sizeX,
                    sizeY,
                    8 + AIL.M_UNSIGNED,
                    AIL.M_IMAGE + AIL.M_PROC,
                    ref MilProcImage);

                // Overlay
                AIL.MgraAllocList(MilSystem,
                                   AIL.M_DEFAULT,
                                   ref MilGraphicList);

                AIL.MdispControl(
                    MilDisplay,
                    AIL.M_ASSOCIATED_GRAPHIC_LIST_ID,
                    MilGraphicList);
                
                AIL.MdispControl(
                    MilDisplay,
                    AIL.M_SCALE_DISPLAY,
                    AIL.M_ENABLE);

                // Template 로드
                AIL.MbufRestore(
                    "template.jpg",
                    MilSystem,
                    ref MilTemplate);

                // Pattern Context
                AIL.MpatAlloc(
                    MilSystem,
                    AIL.M_DEFAULT,
                    AIL.M_DEFAULT,
                    ref MilPatContext);

                // Pattern Result
                AIL.MpatAllocResult(
                    MilSystem,
                    AIL.M_DEFAULT,
                    ref MilPatResult);

                // Pattern 정의
                AIL.MpatDefine(
                    MilPatContext,
                    AIL.M_REGULAR_MODEL,
                    MilTemplate,
                    0,
                    0,
                    AIL.M_DEFAULT,
                    AIL.M_DEFAULT,
                    AIL.M_DEFAULT);

                // Matching 설정
                AIL.MpatControl(
                    MilPatContext,
                    AIL.M_DEFAULT,
                    AIL.M_ACCEPTANCE,
                    50.0);

                AIL.MpatControl(
                    MilPatContext,
                    AIL.M_DEFAULT,
                    AIL.M_NUMBER,
                    1);

                // Angle Search
                AIL.MpatControl(
                    MilPatContext,
                    AIL.M_DEFAULT,
                    AIL.M_SEARCH_ANGLE_MODE,
                    AIL.M_ENABLE); 

                AIL.MpatControl(
                    MilPatContext,
                    AIL.M_DEFAULT,
                    AIL.M_SEARCH_ANGLE_DELTA_NEG,
                    180);

                AIL.MpatControl(
                    MilPatContext,
                    AIL.M_DEFAULT,
                    AIL.M_SEARCH_ANGLE_DELTA_POS,
                    180);

                // Set the search model angle accuracy.
                AIL.MpatControl(MilPatContext, AIL.M_DEFAULT, AIL.M_SEARCH_ANGLE_ACCURACY, 1.0);

                // Preprocess
                AIL.MpatPreprocess(
                    MilPatContext,
                    AIL.M_DEFAULT,
                    MilTemplate);

                AIL.MdigGrabContinuous(
                    MilDigitizer,
                    MilImage);

                label1.Text = "초기화 완료";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                // 1. 카메라 Grab
                AIL.MdigGrab(
                    MilDigitizer,
                    MilImage);
                */

                AIL.MbufCopy(
                    MilImage,
                    MilProcImage);

                // Overlay Clear
                AIL.MgraClear(
                    AIL.M_DEFAULT,
                    MilGraphicList);

                // 2. Pattern Matching
                AIL.MpatFind(
                    MilPatContext,
                    MilProcImage,
                    MilPatResult); 

                // 3. 결과 확인
                long count = 0;

                AIL.MpatGetResult(
                    MilPatResult,
                    AIL.M_GENERAL,
                    AIL.M_NUMBER +
                    AIL.M_TYPE_AIL_INT,
                    ref count);

                if (count > 0)
                {
                    double score = 0;
                    double x = 0;
                    double y = 0;
                    double angle = 0;

                    AIL.MpatGetResult(
                        MilPatResult,
                        0,
                        AIL.M_SCORE,
                        ref score);

                    AIL.MpatGetResult(
                        MilPatResult,
                        0,
                        AIL.M_POSITION_X,
                        ref x);

                    AIL.MpatGetResult(
                        MilPatResult,
                        0,
                        AIL.M_POSITION_Y,
                        ref y);

                    AIL.MpatGetResult(
                        MilPatResult,
                        0,
                        AIL.M_ANGLE,
                        ref angle);

                    // Draw Color
                    AIL.MgraControl(
                        AIL.M_DEFAULT,
                        AIL.M_COLOR,
                        AIL.M_COLOR_GREEN);

                    // Draw Result
                    AIL.MpatDraw(
                        AIL.M_DEFAULT,
                        MilPatResult,
                        MilGraphicList,
                        AIL.M_DRAW_BOX +
                        AIL.M_DRAW_POSITION,
                        0,
                        AIL.M_DEFAULT);

                    // UI 출력
                    label1.Text = "패턴 발견";

                    label2.Text =
                        $"Score : {score:F2}";

                    label3.Text =
                        $"X={x:F2}, Y={y:F2}";

                    label4.Text =
                        $"Angle={angle:F2}";
                }
                else
                {
                    label1.Text = "패턴 없음";
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AIL.MdigHalt(MilDigitizer);

            if (MilGraphicList != AIL.M_NULL)
                AIL.MgraFree(MilGraphicList);

            if (MilPatResult != AIL.M_NULL)
                AIL.MpatFree(MilPatResult);

            if (MilPatContext != AIL.M_NULL)
                AIL.MpatFree(MilPatContext);

            if (MilTemplate != AIL.M_NULL)
                AIL.MbufFree(MilTemplate);

            if (MilImage != AIL.M_NULL)
                AIL.MbufFree(MilImage);

            if (MilProcImage != AIL.M_NULL)
                AIL.MbufFree(MilProcImage);

            if (MilDisplay != AIL.M_NULL)
                AIL.MdispFree(MilDisplay);

            if (MilDigitizer != AIL.M_NULL)
                AIL.MdigFree(MilDigitizer);

            if (MilSystem != AIL.M_NULL)
                AIL.MsysFree(MilSystem);

            if (MilApplication != AIL.M_NULL)
                AIL.MappFree(MilApplication);

        }
    }
}
