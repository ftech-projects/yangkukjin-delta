using System;
using System.Drawing;
using System.Windows.Forms;
using Zebra.AuroraImagingLibrary;


namespace AIL_PATTERN
{
    public partial class Form1 : Form
    {
        private Image sampleImage;
        private Image templateImage;

        AIL_ID MilApplication = AIL.M_NULL;
        AIL_ID MilSystem = AIL.M_NULL;
        AIL_ID MilDisplay = AIL.M_NULL;

        AIL_ID MilImageSrcC = AIL.M_NULL;
        AIL_ID MilImageSrc = AIL.M_NULL;

        AIL_ID MilImageModelC = AIL.M_NULL;
        AIL_ID MilImageModel = AIL.M_NULL;

        AIL_ID MilPatContext = AIL.M_NULL;
        AIL_ID MilPatResult = AIL.M_NULL;

        AIL_ID MilGraphicList = AIL.M_NULL;

        AIL_ID MilGraContext = AIL.M_NULL;

        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnMatch_Click(object sender, EventArgs e)
        {
          
            try
            {

                // 1. MIL 환경 할당
                AIL.MappAlloc(AIL.M_NULL, AIL.M_DEFAULT, ref MilApplication);
                AIL.MsysAlloc(AIL.M_DEFAULT, AIL.M_SYSTEM_HOST, AIL.M_DEFAULT, AIL.M_DEFAULT, ref MilSystem);

                AIL.MdispAlloc(MilSystem, AIL.M_DEFAULT, "M_WINDOWED", AIL.M_DEFAULT, ref MilDisplay);

                // 2. 이미지 로드 (대상 이미지 및 패턴 이미지)
                AIL.MbufRestore("sample.jpg", MilSystem, ref MilImageSrcC);
                AIL.MbufAlloc2d(MilSystem,
                                AIL.MbufInquire(MilImageSrcC, AIL.M_SIZE_X, AIL.M_NULL),
                                AIL.MbufInquire(MilImageSrcC, AIL.M_SIZE_Y, AIL.M_NULL),
                                8 + AIL.M_UNSIGNED,
                                AIL.M_IMAGE + AIL.M_PROC + AIL.M_DISP,
                                ref MilImageSrc);

                // 컬러 → grayscale 변환
                AIL.MimConvert(MilImageSrcC, MilImageSrc, AIL.M_RGB_TO_Y);

                AIL.MbufRestore("template.jpg", MilSystem, ref MilImageModelC);
                AIL.MbufAlloc2d(MilSystem,
                                AIL.MbufInquire(MilImageModelC, AIL.M_SIZE_X, AIL.M_NULL),
                                AIL.MbufInquire(MilImageModelC, AIL.M_SIZE_Y, AIL.M_NULL),
                                8 + AIL.M_UNSIGNED,
                                AIL.M_IMAGE + AIL.M_PROC,
                                ref MilImageModel);

                // 컬러 → grayscale 변환
                AIL.MimConvert(MilImageModelC, MilImageModel, AIL.M_RGB_TO_Y);

                // 디스플레이에 대상 이미지 표시
                AIL.MdispSelectWindow( MilDisplay, MilImageSrc, panel1.Handle);

                AIL.MgraAllocList(MilSystem, AIL.M_DEFAULT, ref MilGraphicList);
                                               
                AIL.MdispControl(MilDisplay, AIL.M_ASSOCIATED_GRAPHIC_LIST_ID, MilGraphicList);

                AIL.MdispControl(MilDisplay, AIL.M_SCALE_DISPLAY, AIL.M_ENABLE);

                // 3. 패턴 매칭 컨텍스트 및 결과 버퍼 할당
                AIL.MpatAlloc(MilSystem, AIL.M_DEFAULT, AIL.M_DEFAULT, ref MilPatContext);
                AIL.MpatAllocResult(MilSystem, AIL.M_DEFAULT, ref MilPatResult);

                // 4. 모델(패턴) 정의 및 전처리
                // 패턴 이미지 전체를 모델로 등록
                AIL.MpatDefine(MilPatContext, AIL.M_REGULAR_MODEL, MilImageModel, 0, 0, AIL.M_DEFAULT, AIL.M_DEFAULT, AIL.M_DEFAULT);

                AIL.MpatControl(MilPatContext, AIL.M_DEFAULT, AIL.M_ACCURACY, AIL.M_LOW);

                AIL.MpatControl(MilPatContext, AIL.M_DEFAULT, AIL.M_ACCEPTANCE, 25.0);

                AIL.MpatControl(MilPatContext, AIL.M_DEFAULT, AIL.M_NUMBER, 1);

                AIL.MpatControl(MilPatContext, AIL.M_DEFAULT, AIL.M_SPEED, AIL.M_HIGH);


                // Activate the search model angle mode.
                AIL.MpatControl(MilPatContext, AIL.M_DEFAULT, AIL.M_SEARCH_ANGLE_MODE, AIL.M_ENABLE);

                // Set the search model range angle.
                AIL.MpatControl(MilPatContext, AIL.M_DEFAULT, AIL.M_SEARCH_ANGLE_DELTA_NEG, 180);

                AIL.MpatControl(MilPatContext, AIL.M_DEFAULT, AIL.M_SEARCH_ANGLE_DELTA_POS, 180);

                // Set the search model angle accuracy.
                AIL.MpatControl(MilPatContext, AIL.M_DEFAULT, AIL.M_SEARCH_ANGLE_ACCURACY, 5.0);

                // Set the search model angle interpolation mode to bilinear.
                AIL.MpatControl(MilPatContext, AIL.M_DEFAULT, AIL.M_SEARCH_ANGLE_INTERPOLATION_MODE, AIL.M_BILINEAR);

                AIL.MpatPreprocess(MilPatContext, AIL.M_DEFAULT, MilImageModel);

                // 5. 패턴 탐색 실행
                AIL.MpatFind(MilPatContext, MilImageSrc, MilPatResult);

                // 6. 결과 확인
                long NumberOfFound = 0; // MIL_INT는 C#에서 주로 long 또는 int로 매핑됨

                AIL.MpatGetResult(MilPatResult, AIL.M_GENERAL, AIL.M_NUMBER + AIL.M_TYPE_AIL_INT, ref NumberOfFound);

                if (NumberOfFound > 0)
                {
                    double Score = 0.0;
                    double XPos = 0.0;
                    double YPos = 0.0;
                    double Angle = 0;


                    // 가장 일치율이 높은 첫 번째 패턴(인덱스 0)의 정보 가져오기
                    AIL.MpatGetResult(MilPatResult, 0, AIL.M_SCORE, ref Score);
                    AIL.MpatGetResult(MilPatResult, 0, AIL.M_POSITION_X, ref XPos);
                    AIL.MpatGetResult(MilPatResult, 0, AIL.M_POSITION_Y, ref YPos);
                    AIL.MpatGetResult(MilPatResult, 0, AIL.M_ANGLE, ref Angle);
                                        
                    AIL.MgraAlloc(MilSystem, ref MilGraContext);

                    AIL.MgraControl(MilGraContext, AIL.M_COLOR, AIL.M_COLOR_GREEN);

                    AIL.MpatDraw(MilGraContext, MilPatResult, MilGraphicList, AIL.M_DRAW_BOX + AIL.M_DRAW_POSITION, 0, AIL.M_DEFAULT);


                    label1.Text = "패턴 발견 성공!";
                    label2.Text = $"점수: {Score:F2}%";
                    label3.Text = $"위치 좌표: X = {XPos:F2}, Y = {YPos:F2}";
                    label4.Text = $"각도 : Angle = {Angle:F2}";
                }
                else
                {
                    label1.Text = "패턴을 찾지 못했습니다.";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MilPatResult != AIL.M_NULL)
                AIL.MpatFree(MilPatResult);

            if (MilPatContext != AIL.M_NULL)
                AIL.MpatFree(MilPatContext);

            if (MilGraContext != AIL.M_NULL)
            {
                AIL.MgraFree(MilGraContext);
                MilGraContext = AIL.M_NULL;
            }

            if (MilGraphicList != AIL.M_NULL)
                AIL.MgraFree(MilGraphicList);

            if (MilImageModelC != AIL.M_NULL)
                AIL.MbufFree(MilImageModelC);

            if (MilImageSrcC != AIL.M_NULL)
                AIL.MbufFree(MilImageSrcC);

            if (MilImageModel != AIL.M_NULL)
                AIL.MbufFree(MilImageModel);

            if (MilImageSrc != AIL.M_NULL)
                AIL.MbufFree(MilImageSrc);

            if (MilDisplay != AIL.M_NULL)
                AIL.MdispFree(MilDisplay);

            if (MilSystem != AIL.M_NULL)
                AIL.MsysFree(MilSystem);

            if (MilApplication != AIL.M_NULL)
                AIL.MappFree(MilApplication);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
