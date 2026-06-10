using System.Net.Sockets;
using System.Text;
using Zebra.AuroraImagingLibrary;

namespace PICKANDPLACE
{
    public partial class Form1 : Form
    {

        private TcpClient client;
        private NetworkStream stream;

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

        private void ROBOT_COM_Tick(object sender, EventArgs e)
        {
            switch (st_var.rc_step)
            {
                case 1000:
                    com_open();
                    st_var.rc_step = 2000;
                    break;

                case 2000:
                    if (st_var.robot_connected)
                    {
                        txtTCP_RES.Text = "CONNECT SUCCESS";
                        st_var.rc_step = 4000;
                    }
                    else
                    {
                        txtTCP_RES.Text = "CONNECT FAIL";
                        st_var.rc_step = 20000;
                    }
                    break;

                case 4000:
                    st_var.rb_send_msg = st_var.rb_connect_msg;
                    txtTCP_SND.Text = st_var.rb_send_msg;
                    com_send();
                    st_var.rc_step = 5000;
                    break;

                case 5000:
                    if (st_var.robot_com)
                    {
                        txtTCP_RES.Text = st_var.rb_response_msg;
                        st_var.com_check = 0;
                        st_var.rc_step = 7000;
                    }
                    else
                    {
                        txtTCP_RES.Text = "COMMUNICATION FAIL";
                        st_var.rc_step = 20000;
                    }
                    break;

                case 7000:
                    st_var.com_check = st_var.com_check + 1;

                    if (st_var.rb_response_msg == st_var.rb_reply_msg)
                    {
                        st_var.rc_step = 9000;
                    }
                    else
                    {
                        if (st_var.com_check > st_var.com_check_limit)
                        {
                            st_var.rc_step = 20000;
                        }
                    }

                    break;

                case 9000:
                    st_var.rb_send_msg = st_var.rb_cmd_msg;
                    txtTCP_SND.Text = st_var.rb_send_msg;
                    com_send();
                    st_var.rc_step = 10000;
                    break;

                case 10000:
                    if (st_var.robot_com)
                    {
                        txtTCP_RES.Text = st_var.rb_response_msg;
                        st_var.com_check = 0;
                        st_var.rc_step = 12000;

                    }
                    else
                    {
                        txtTCP_RES.Text = "COMMUNICATION FAIL";
                        st_var.rc_step = 20000;
                    }
                    break;

                case 12000:
                    st_var.com_check = st_var.com_check + 1;
                    if (st_var.rb_response_msg == st_var.rb_cmd_reply_msg)
                    {
                        st_var.rc_step = 13500;
                    }
                    else
                    {
                        if (st_var.com_check > st_var.com_check_limit)
                        {
                            st_var.rc_step = 20000;
                        }
                    }
                    break;

                case 13500:
                    if (st_var.rb_has_cmd_data)
                    {
                        st_var.rc_step = 14000;
                    }
                    else
                    {
                        st_var.rc_step = 16200;
                    }
                    break;

                case 14000:
                    st_var.rb_send_msg = st_var.rb_cmddata_msg;
                    txtTCP_SND.Text = st_var.rb_send_msg;
                    com_send();
                    st_var.rc_step = 15000;
                    break;

                case 15000:
                    if (st_var.robot_com)
                    {
                        txtTCP_RES.Text = st_var.rb_response_msg;
                        st_var.com_check = 0;
                        st_var.rc_step = 17000;

                    }
                    else
                    {
                        txtTCP_RES.Text = "COMMUNICATION FAIL";
                        st_var.rc_step = 20000;
                    }
                    break;

                case 16200:
                    com_read();
                    st_var.rc_step = 16400;
                    break;

                case 16400:
                    if (st_var.robot_com)
                    {
                        txtTCP_RES.Text = st_var.rb_response_msg;
                        st_var.com_check = 0;
                        st_var.rc_step = 17000;

                    }
                    else
                    {
                        txtTCP_RES.Text = "COMMUNICATION FAIL";
                        st_var.rc_step = 20000;
                    }
                    break;

                case 17000:

                    st_var.com_check = st_var.com_check + 1;

                    bool chk_result = check_format();

                    if (chk_result)
                    {
                        st_var.rc_step = 19000;
                    }
                    else
                    {
                        if (st_var.com_check > st_var.com_check_limit)
                        {
                            st_var.rc_step = 20000;
                        }
                    }
                    break;

                case 19000:
                    if (st_var.rb_cd_reply_format == 2)
                    {
                        position_parse();
                    }

                    st_var.rc_step = 20000;
                    break;

                case 20000:

                    com_close();
                    ROBOT_COM.Enabled = false;
                    break;
            }
        }

        private void com_open()
        {
            try
            {
                // ROBOT SERVER CONNECT(192,168,255,200 port:80)
                client = new TcpClient(st_var.rb_network, 80);
                stream = client.GetStream();
                st_var.robot_connected = true;

            }
            catch
            {
                st_var.robot_connected = false;
            }
        }

        private void com_send()
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(st_var.rb_send_msg);

                // 서버로 메시지 전송
                stream.Write(data, 0, data.Length);

                // 서버 응답 수신
                byte[] buffer = new byte[1024];
                int bytes = stream.Read(buffer, 0, buffer.Length);
                st_var.rb_response_msg = Encoding.UTF8.GetString(buffer, 0, bytes);

                st_var.robot_com = true;

            }
            catch (Exception ex)
            {
                st_var.robot_com = false;
            }
        }

        private void com_read()
        {
            try
            {

                // 서버 응답 수신
                byte[] buffer = new byte[1024];
                int bytes = stream.Read(buffer, 0, buffer.Length);
                st_var.rb_response_msg = Encoding.UTF8.GetString(buffer, 0, bytes);

                st_var.robot_com = true;

            }
            catch (Exception ex)
            {
                st_var.robot_com = false;
            }
        }

        private void com_close()
        {
            stream?.Close();
            client?.Close();
        }

        private bool check_format()
        {
            bool result = false;

            // 1: SVON 2: POSITION 3: MOVE 4: JOB

            switch (st_var.rb_cd_reply_format)
            {
                case 1:
                    result = chk_SVON_format();
                    break;

                case 2:
                    result = chk_position_format();
                    break;

                case 3:
                    result = chk_move_format();
                    break;

                case 4:
                    result = chk_job_format();
                    break;

                case 5:
                    result = chk_var_format();
                    break;

                default:
                    result = false;
                    break;

            }

            return result;
        }


        private bool chk_SVON_format()
        {
            bool result = (st_var.rb_response_msg == "0000\r\n");

            return result;
        }

        private bool chk_position_format()
        {
            bool result = (st_var.rb_response_msg.Length > 14);

            return result;
        }

        private bool chk_move_format()
        {
            bool result = (st_var.rb_response_msg == "0000\r\n");

            return result;
        }

        private bool chk_job_format()
        {
            bool result = (st_var.rb_response_msg == "0000\r\n");

            return result;
        }

        private bool chk_var_format()
        {
            bool result = (st_var.rb_response_msg.Length > 0);

            return result;
        }

        private void position_parse()
        {
            try
            {
                txtX_POS.Text = st_var.rb_response_msg.Split(',')[0];
                txtY_POS.Text = st_var.rb_response_msg.Split(',')[1];
                txtZ_POS.Text = st_var.rb_response_msg.Split(',')[2];
                txtX_ROT.Text = st_var.rb_response_msg.Split(',')[3];
                txtY_ROT.Text = st_var.rb_response_msg.Split(',')[4];
                txtZ_ROT.Text = st_var.rb_response_msg.Split(',')[5];

                st_var.x_pos = Double.Parse(txtX_POS.Text);
                st_var.y_pos = Double.Parse(txtY_POS.Text);
                st_var.z_pos = Double.Parse(txtZ_POS.Text);
                st_var.xr_pos = Double.Parse(txtX_ROT.Text);
                st_var.yr_pos = Double.Parse(txtY_ROT.Text);
                st_var.zr_pos = Double.Parse(txtZ_POS.Text);
            }
            catch { }

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
                    25.0);

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

                // Angle Accuracy
                AIL.MpatControl(
                    MilPatContext,
                    AIL.M_DEFAULT,
                    AIL.M_SEARCH_ANGLE_ACCURACY,
                    1.0);

                // Preprocess
                AIL.MpatPreprocess(
                    MilPatContext,
                    AIL.M_DEFAULT,
                    MilTemplate);

                AIL.MdigGrabContinuous(
                    MilDigitizer,
                    MilImage);

                label12.Text = "초기화 완료";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSVON_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST SVON 2\r\n";
            st_var.rb_cmd_reply_msg = "OK: SVON\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = "1,\r";
            st_var.rb_cd_reply_format = 1;

            if (!ROBOT_COM.Enabled) { ROBOT_COM.Enabled = true; }
        }

        private void btSVOFF_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST SVON 2\r\n";
            st_var.rb_cmd_reply_msg = "OK: SVON\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = "0,\r";
            st_var.rb_cd_reply_format = 1;

            if (!ROBOT_COM.Enabled) { ROBOT_COM.Enabled = true; }
        }

        private void btXPLUS_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,{DISTANCE.Text:F3},0,0,0,0,0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            if (!ROBOT_COM.Enabled) { ROBOT_COM.Enabled = true; }
        }

        private void btXMINUS_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,{(Double.Parse(DISTANCE.Text) * -1).ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            if (!ROBOT_COM.Enabled) { ROBOT_COM.Enabled = true; }
        }

        private void btYPLUS_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,0,{DISTANCE.Text:F3},0,0,0,0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            if (!ROBOT_COM.Enabled) { ROBOT_COM.Enabled = true; }
        }

        private void btYMINUS_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,0,{(Double.Parse(DISTANCE.Text) * -1).ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            if (!ROBOT_COM.Enabled) { ROBOT_COM.Enabled = true; }
        }

        private void btZPLUS_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,0,0,{DISTANCE.Text:F3},0,0,0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            if (!ROBOT_COM.Enabled) { ROBOT_COM.Enabled = true; }
        }

        private void btZMINUS_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,0,0,{(Double.Parse(DISTANCE.Text) * -1).ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            if (!ROBOT_COM.Enabled) { ROBOT_COM.Enabled = true; }
        }

        private void btPOSITION_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
            st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = "1,0\r";
            st_var.rb_cd_reply_format = 2;
            if (!ROBOT_COM.Enabled) { ROBOT_COM.Enabled = true; }
        }

        private void btSEARCH_Click(object sender, EventArgs e)
        {
            st_var.JOBNAME = "SEARCH";

            st_var.rc_step = 1000;
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST START " + (st_var.JOBNAME.Length + 1).ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: START\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.JOBNAME + "\r";
            st_var.rb_cd_reply_format = 4;

            if (!ROBOT_COM.Enabled) { ROBOT_COM.Enabled = true; }

        }

        private void btPLACE_Click(object sender, EventArgs e)
        {
            st_var.JOBNAME = "PLACE";

            st_var.rc_step = 1000;
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST START " + (st_var.JOBNAME.Length + 1).ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: START\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.JOBNAME + "\r";
            st_var.rb_cd_reply_format = 4;

            if (!ROBOT_COM.Enabled) { ROBOT_COM.Enabled = true; }
        }

        private void btGET_Click(object sender, EventArgs e)
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
                    label12.Text = "패턴 발견";

                    label13.Text =
                        $"Score : {score:F2}";

                    label14.Text =
                        $"X={x:F2}, Y={y:F2}";

                    label15.Text =
                        $"Angle={angle:F2}";
                }
                else
                {
                    label12.Text = "패턴 없음";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btGRAB_Click(object sender, EventArgs e)
        {

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
