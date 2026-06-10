using Basler.Pylon;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.XObjdetect;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ROBOT_CORRECT
{

    public partial class Main : Form
    {
        private Camera camera;
        private Mat template;
        private Bitmap bitmap_manual;

        private TcpClient client;
        private NetworkStream stream;
        private SerialPort serialPort;

        public Main()
        {
            InitializeComponent();
        }

        private void AUTO_Click(object sender, EventArgs e)
        {
            PAGE.SelectedIndex = 0;
            AUTO.Image = Properties.Resources.button1_dn;
            MANUAL.Image = Properties.Resources.button1_up;
            SETTING.Image = Properties.Resources.button1_up;
        }

        private void MANUAL_Click(object sender, EventArgs e)
        {
            PAGE.SelectedIndex = 1;

            AUTO.Image = Properties.Resources.button1_up;
            MANUAL.Image = Properties.Resources.button1_dn;
            SETTING.Image = Properties.Resources.button1_up;
        }

        private void SETTING_Click(object sender, EventArgs e)
        {
            PAGE.SelectedIndex = 2;

            AUTO.Image = Properties.Resources.button1_up;
            MANUAL.Image = Properties.Resources.button1_up;
            SETTING.Image = Properties.Resources.button1_dn;
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);

        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder reVal, int size, string filepath);

        private void ROBOT_NET_CONFIRM_Click(object sender, EventArgs e)
        {
            st_var.rb_network = txtIP1.Text + "." + txtIP2.Text + "." + txtIP3.Text + "." + txtIP4.Text;
            WritePrivateProfileString("NETWORK", "ROBOT_IP1", txtIP1.Text, "C:\\ROBOT_CORRECT\\config.ini");
            WritePrivateProfileString("NETWORK", "ROBOT_IP2", txtIP2.Text, "C:\\ROBOT_CORRECT\\config.ini");
            WritePrivateProfileString("NETWORK", "ROBOT_IP3", txtIP3.Text, "C:\\ROBOT_CORRECT\\config.ini");
            WritePrivateProfileString("NETWORK", "ROBOT_IP4", txtIP4.Text, "C:\\ROBOT_CORRECT\\config.ini");
        }

        private void CNT_CONFIRM_Click(object sender, EventArgs e)
        {
            st_var.rb_connect_msg = txtCNTM.Text + "\r\n";
            WritePrivateProfileString("NETWORK", "ROBOT_CNTM", txtCNTM.Text, "C:\\ROBOT_CORRECT\\config.ini");
        }

        private void RPY_CONFIRM_Click(object sender, EventArgs e)
        {
            st_var.rb_reply_msg = txtRPLYM.Text + "\r\n";
            WritePrivateProfileString("NETWORK", "ROBOT_RPLM", txtRPLYM.Text, "C:\\ROBOT_CORRECT\\config.ini");
        }

        private void SER_PORT_CONFIRM_Click(object sender, EventArgs e)
        {
            st_var.ser_com = cbSERIAL.Text;
            WritePrivateProfileString("NETWORK", "SERIAL_PORT", cbSERIAL.Text, "C:\\ROBOT_CORRECT\\config.ini");
        }

        private void Main_Load(object sender, EventArgs e)
        {
          

            StringBuilder get = new StringBuilder();
            get.Capacity = 40;
            try
            {
                // ROBOT IP
                GetPrivateProfileString("NETWORK", "ROBOT_IP1", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtIP1.Text = get.ToString();

                GetPrivateProfileString("NETWORK", "ROBOT_IP2", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtIP2.Text = get.ToString();

                GetPrivateProfileString("NETWORK", "ROBOT_IP3", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtIP3.Text = get.ToString();

                GetPrivateProfileString("NETWORK", "ROBOT_IP4", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtIP4.Text = get.ToString();

                st_var.rb_network = txtIP1.Text + "." + txtIP2.Text + "." + txtIP3.Text + "." + txtIP4.Text;

                // ROBOT CONNECT MESSAGE

                GetPrivateProfileString("NETWORK", "ROBOT_CNTM", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtCNTM.Text = get.ToString();
                st_var.rb_connect_msg = txtCNTM.Text + "\r\n";

                //ROBOT REPLY MESSAGE
                GetPrivateProfileString("NETWORK", "ROBOT_RPLM", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtRPLYM.Text = get.ToString();
                st_var.rb_reply_msg = txtRPLYM.Text + "\r\n";

                //IO SERIAL PORT
                GetPrivateProfileString("NETWORK", "SERIAL_PORT", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                cbSERIAL.Text = get.ToString();
                st_var.ser_com = cbSERIAL.Text;

                //TEMPLATE IMAGE
                GetPrivateProfileString("IMAGE", "TEMPLATE", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtTEMPFILE.Text = get.ToString();
                st_var.template_file = txtTEMPFILE.Text;

                //TOLERANCE
                GetPrivateProfileString("TOLERANCE", "X_TOLERANCE", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtXtol.Text = get.ToString();
                st_var.x_tol = double.Parse(txtXtol.Text);

                GetPrivateProfileString("TOLERANCE", "Y_TOLERANCE", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtYtol.Text = get.ToString();
                st_var.y_tol = double.Parse(txtYtol.Text);

                GetPrivateProfileString("TOLERANCE", "Z_TOLERANCE", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtZtol.Text = get.ToString();
                st_var.z_tol = double.Parse(txtZtol.Text);

                //OUT OF RANGE
                GetPrivateProfileString("OUTOFRANGE", "X", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtXOUTR.Text = get.ToString();
                st_var.x_outr = double.Parse(txtXOUTR.Text);

                GetPrivateProfileString("OUTOFRANGE", "Y", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtYOUTR.Text = get.ToString();
                st_var.y_outr = double.Parse(txtYOUTR.Text);

                //WAIT
                GetPrivateProfileString("WAIT", "ACT1", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtACT1WAIT.Text = get.ToString();
                st_var.act1_wait = (int)(double.Parse(txtACT1WAIT.Text) * 20);

                GetPrivateProfileString("WAIT", "ACT2", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtACT2WAIT.Text = get.ToString();
                st_var.act2_wait = (int)(double.Parse(txtACT2WAIT.Text) * 20);

                GetPrivateProfileString("WAIT", "ACT3", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtACT3WAIT.Text = get.ToString();
                st_var.act3_wait = (int)(double.Parse(txtACT3WAIT.Text) * 20);

                GetPrivateProfileString("WAIT", "CRT1", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtCOR1WAIT.Text = get.ToString();
                st_var.crt1_wait = int.Parse(txtCOR1WAIT.Text);

                GetPrivateProfileString("WAIT", "CRT2", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtCOR2WAIT.Text = get.ToString();
                st_var.crt2_wait = int.Parse(txtCOR2WAIT.Text);

                GetPrivateProfileString("WAIT", "CRT3", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtCOR3WAIT.Text = get.ToString();
                st_var.crt3_wait = int.Parse(txtCOR3WAIT.Text);

                GetPrivateProfileString("WAIT", "CRT4", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtCOR4WAIT.Text = get.ToString();
                st_var.crt4_wait = int.Parse(txtCOR4WAIT.Text);

                //CORRECT SPEED

                GetPrivateProfileString("COR_SPD", "CRT1", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtCOR1SPD.Text = get.ToString();
                st_var.cor1_spd = int.Parse(txtCOR1SPD.Text);

                GetPrivateProfileString("COR_SPD", "CRT2", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtCOR2SPD.Text = get.ToString();
                st_var.cor2_spd = int.Parse(txtCOR2SPD.Text);

                GetPrivateProfileString("COR_SPD", "CRT3", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtCOR3SPD.Text = get.ToString();
                st_var.cor3_spd = int.Parse(txtCOR3SPD.Text);

                GetPrivateProfileString("COR_SPD", "CRT4", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtCOR4SPD.Text = get.ToString();
                st_var.cor4_spd = int.Parse(txtCOR4SPD.Text);

                // Z SCAN
                GetPrivateProfileString("Z_SCAN", "Min", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtMin.Text = get.ToString();
                st_var.z_scan_min = double.Parse(txtMin.Text);

                GetPrivateProfileString("Z_SCAN", "Max", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtMax.Text = get.ToString();
                st_var.z_scan_max = double.Parse(txtMax.Text);

                //ROBOT CHK CORD
                GetPrivateProfileString("CHK_CORD", "XCORD", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtXCORD.Text = get.ToString();
                st_var.robot_chk_pos_X = double.Parse(txtXCORD.Text);

                GetPrivateProfileString("CHK_CORD", "YCORD", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtYCORD.Text = get.ToString();
                st_var.robot_chk_pos_Y = double.Parse(txtYCORD.Text);

                GetPrivateProfileString("CHK_CORD", "ZCORD", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtZCORD.Text = get.ToString();
                st_var.robot_chk_pos_Z = double.Parse(txtZCORD.Text);

                //PIXEL RATIO
                GetPrivateProfileString("PIXEL_RATIO", "XRATIO", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtXRATIO.Text = get.ToString();
                st_var.diff_x = double.Parse(txtXCORD.Text);

                GetPrivateProfileString("PIXEL_RATIO", "YRATIO", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtYRATIO.Text = get.ToString();
                st_var.diff_y = double.Parse(txtYCORD.Text);


                //DISPLAY SETTING
                GetPrivateProfileString("DISPLAY", "CENTERX", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtCNTRX.Text = get.ToString();
                st_var.center_x = int.Parse(txtCNTRX.Text);

                GetPrivateProfileString("DISPLAY", "CENTERY", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtCNTRY.Text = get.ToString();
                st_var.center_y = int.Parse(txtCNTRY.Text);

                GetPrivateProfileString("DISPLAY", "FIT_R", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtFITR.Text = get.ToString();
                st_var.fit_r = int.Parse(txtFITR.Text);

                GetPrivateProfileString("DISPLAY", "OUT_R", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtOUTR.Text = get.ToString();
                st_var.out_r = int.Parse(txtOUTR.Text);

                //out range brigntness
                GetPrivateProfileString("OUT_RANGE", "MAX", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtMAXBR.Text = get.ToString();
                st_var.max_bright = int.Parse(txtMAXBR.Text);

                GetPrivateProfileString("OUT_RANGE", "MIN", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtMINBR.Text = get.ToString();
                st_var.min_bright = int.Parse(txtMINBR.Text);

                //out range center
                GetPrivateProfileString("OUT_OF_RANGE_CENTER", "X_POS", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtXPOS.Text = get.ToString();
                st_var.hole_center_x = int.Parse(txtXPOS.Text);

                GetPrivateProfileString("OUT_OF_RANGE_CENTER", "Y_POS", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtYPOS.Text = get.ToString();
                st_var.hole_center_y = int.Parse(txtYPOS.Text);

                //check diff
                GetPrivateProfileString("CHECK_DIFFERENCE", "X_DIFF", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtXDIFF.Text = get.ToString();
                st_var.robot_diff_x = double.Parse(txtXDIFF.Text);

                GetPrivateProfileString("CHECK_DIFFERENCE", "Y_DIFF", "", get, get.Capacity, "C:\\ROBOT_CORRECT\\config.ini");
                txtYDIFF.Text = get.ToString();
                st_var.robot_diff_y = double.Parse(txtYDIFF.Text);


                // Template
                template = CvInvoke.Imread(st_var.template_file, ImreadModes.Grayscale);

                // Template은 반드시 Grayscale CV_8U
                if (template.NumberOfChannels > 1)
                    CvInvoke.CvtColor(template, template, ColorConversion.Bgr2Gray);
            }
            catch
            {

            }


            try
            {
                camera = new Camera(); // 첫 번째 연결된 Basler 카메라
                camera.Open();

                // Single Frame Grab
                camera.Parameters[PLCamera.AcquisitionMode]
                      .SetValue(PLCamera.AcquisitionMode.SingleFrame);

                // Mono8 픽셀 포맷
                camera.Parameters[PLCamera.PixelFormat]
                      .SetValue(PLCamera.PixelFormat.Mono8);

                // 노출 시간 (us)
                camera.Parameters[PLCamera.ExposureTimeAbs].SetValue(50000);

                MessageBox.Show("Camera Open Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Camera Open Failed\n" + ex.Message);
            }


            try
            {
                serialPort = new SerialPort(st_var.ser_com, 115200, Parity.None, 8, StopBits.One);
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
                MessageBox.Show("Port Open Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Port Open Failed\n" + ex.Message);
            }

        }

        private void tmROBOT_Tick(object sender, EventArgs e)
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

                    if (st_var.rb_cd_reply_format == 5)
                    {
                        tbVARDATA.Text = st_var.rb_response_msg;
                    }


                    st_var.rc_step = 20000;
                    break;

                case 20000:

                    com_close();
                    tmROBOT.Enabled = false;
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
                st_var.zr_pos = Double.Parse(txtZ_ROT.Text);
            }
            catch { }

        }

        private void SVON_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST SVON 2\r\n";
            st_var.rb_cmd_reply_msg = "OK: SVON\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = "1,\r";
            st_var.rb_cd_reply_format = 1;

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }

        }

        private void SVOFF_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST SVON 2\r\n";
            st_var.rb_cmd_reply_msg = "OK: SVON\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = "0,\r";
            st_var.rb_cd_reply_format = 1;

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void MOV_X_POS_Click(object sender, EventArgs e)
        {

            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,{DISTANCE.Text:F3},0,0,0,0,0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            st_var.log_msg = st_var.log_msg + "MOVE_X_POS_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void MOV_X_NEG_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,{(Double.Parse(DISTANCE.Text) * -1).ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            st_var.log_msg = st_var.log_msg + "MOVE_X_NEG_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void MOV_Y_NEG_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,0,{(Double.Parse(DISTANCE.Text) * -1).ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            st_var.log_msg = st_var.log_msg + "MOVE_Y_NEG_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void MOV_Y_POS_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,0,{DISTANCE.Text:F3},0,0,0,0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            st_var.log_msg = st_var.log_msg + "MOVE_Y_POS_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void MOV_Z_UP_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,0,0,{DISTANCE.Text:F3},0,0,0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            st_var.log_msg = st_var.log_msg + "MOVE_Z_UP_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void MOV_Z_DN_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,0,0,{(Double.Parse(DISTANCE.Text) * -1).ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            st_var.log_msg = st_var.log_msg + "MOVE_Z_DN_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void X_ROT_POS_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,0,0,0,{DISTANCE.Text:F3},0,0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            st_var.log_msg = st_var.log_msg + "ROT_X_POS_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void X_ROT_NEG_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,0,0,0,{(Double.Parse(DISTANCE.Text) * -1).ToString():F3},0,0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            st_var.log_msg = st_var.log_msg + "ROT_X_NEG_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void Y_ROT_POS_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,0,0,0,0,{DISTANCE.Text:F3},0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            st_var.log_msg = st_var.log_msg + "ROT_Y_POS_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void Y_ROT_NEG_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,0,0,0,0,{(Double.Parse(DISTANCE.Text) * -1).ToString():F3},0,0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            st_var.log_msg = st_var.log_msg + "ROT_Y_NEG_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void Z_ROT_POS_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,0,0,0,0,0,{DISTANCE.Text:F3},0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            st_var.log_msg = st_var.log_msg + "ROT_Z_POS_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void Z_ROT_NEG_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.move_cmd = $"0,{SPEED.Text:F2},1,0,0,0,0,0,{(Double.Parse(DISTANCE.Text) * -1).ToString():F3},0,0,0,0,0,0,0,0,0";
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
            st_var.rb_cd_reply_format = 3;

            st_var.log_msg = st_var.log_msg + "ROT_Z_NEG_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void GETPOS_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
            st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = "1,0\r";
            st_var.rb_cd_reply_format = 2;
            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void JOB_START_Click(object sender, EventArgs e)
        {
            if (txtJOBNAME.Text.Trim().Length > 0)
            {
                st_var.rc_step = 1000;
                st_var.rb_cmd_msg = "HOSTCTRL_REQUEST START " + (txtJOBNAME.Text.Length + 1).ToString() + "\r\n";
                st_var.rb_cmd_reply_msg = "OK: START\r\n";
                st_var.rb_has_cmd_data = true;
                st_var.rb_cmddata_msg = txtJOBNAME.Text + "\r";
                st_var.rb_cd_reply_format = 4;

                st_var.log_msg = st_var.log_msg + "JOB_START_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
            }

            txtJOBNAME.Text = "";
        }

        private void btTEMPLATE_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "템플레이트 선택";
            openFileDialog.Multiselect = false; // 여러 파일 선택 여부

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                st_var.template_file = openFileDialog.FileName;
                txtTEMPFILE.Text = st_var.template_file;
                WritePrivateProfileString("IMAGE", "TEMPLATE", txtTEMPFILE.Text, "C:\\ROBOT_CORRECT\\config.ini");

                template = CvInvoke.Imread(st_var.template_file, ImreadModes.Grayscale);

                // Template은 반드시 Grayscale CV_8U
                if (template.NumberOfChannels > 1)
                    CvInvoke.CvtColor(template, template, ColorConversion.Bgr2Gray);

            }
        }

        private void CMOPEN_Click(object sender, EventArgs e)
        {
            try
            {
                camera = new Camera(); // 첫 번째 연결된 Basler 카메라
                camera.Open();

                // Single Frame Grab
                camera.Parameters[PLCamera.AcquisitionMode]
                      .SetValue(PLCamera.AcquisitionMode.SingleFrame);

                // Mono8 픽셀 포맷
                camera.Parameters[PLCamera.PixelFormat]
                      .SetValue(PLCamera.PixelFormat.Mono8);

                // 노출 시간 (us)
                camera.Parameters[PLCamera.ExposureTimeAbs].SetValue(50000);

                MessageBox.Show("Camera Open Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Camera Open Failed\n" + ex.Message);
            }
        }

        private void GRAB_Click(object sender, EventArgs e)
        {
            try
            {
                IGrabResult grabResult = camera.StreamGrabber.GrabOne(2000);


                if (grabResult.GrabSucceeded)
                {
                    // Pixel 포맷 확인 (보통 Mono8 또는 BGR8)
                    PixelType pixelType = grabResult.PixelTypeValue;


                    if (pixelType == PixelType.Mono8)
                    {
                        bitmap_manual = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format8bppIndexed);

                        // Grayscale 팔레트 설정
                        ColorPalette palette = bitmap_manual.Palette;
                        for (int i = 0; i < 256; i++)
                        {
                            palette.Entries[i] = Color.FromArgb(i, i, i);
                        }
                        bitmap_manual.Palette = palette;
                    }
                    else
                    {
                        bitmap_manual = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format24bppRgb);
                    }

                    BitmapData bmpData = bitmap_manual.LockBits(
                        new Rectangle(0, 0, bitmap_manual.Width, bitmap_manual.Height),
                        ImageLockMode.WriteOnly,
                        bitmap_manual.PixelFormat);

                    // Grab 데이터 복사
                    Marshal.Copy(grabResult.PixelData as byte[], 0, bmpData.Scan0,
                                 grabResult.Width * grabResult.Height *
                                 (Image.GetPixelFormatSize(bitmap_manual.PixelFormat) / 8));

                    bitmap_manual.UnlockBits(bmpData);

                    SCR_MANUAL.Image?.Dispose();
                    SCR_MANUAL.Image = bitmap_manual;

                    st_var.log_msg = st_var.log_msg + "GRAB_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                }
                else
                {
                    MessageBox.Show("Grab Failed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Grab Error\n" + ex.Message);
            }
        }

        private void display_normal_OUTR()
        {
            FUNC_GRAB();
            FUNC_CATCH2(); // WILL BE REPLACED WITH FUNC_CATCH()!!
            NORMAL.Image?.Dispose();
            NORMAL.Image = st_var.bitmap_catch;
            try
            {
                NORMAL.Image.Save("C:\\BACKUP_IMAGE\\OUTR_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch { }
            st_var.log_msg = st_var.log_msg + "OUTRANGE :X=" + st_var.catch_X_position.ToString() + ", Y=" + st_var.catch_Y_position.ToString() + "_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
        }

        private void display_normal()
        {
            FUNC_GRAB();
            FUNC_CATCH();
            NORMAL.Image?.Dispose();
            NORMAL.Image = st_var.bitmap_catch;
            try
            {
                NORMAL.Image.Save("C:\\BACKUP_IMAGE\\NORMAL_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch
            { }
            st_var.log_msg = st_var.log_msg + "NORMAL :X=" + st_var.catch_X_position.ToString() + ", Y=" + st_var.catch_Y_position.ToString() + "_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
        }

        private void display_correct()
        {
            FUNC_GRAB();
            FUNC_CATCH();
            CORRECT.Image?.Dispose();
            CORRECT.Image = st_var.bitmap_catch;
            try
            {
                CORRECT.Image.Save("C:\\BACKUP_IMAGE\\CORRECT_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch { }
            st_var.log_msg = st_var.log_msg + "CORRECT :X=" + st_var.catch_X_position.ToString() + ", Y=" + st_var.catch_Y_position.ToString() + "_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
        }

        private void FUNC_GRAB()
        {
            try
            {
                IGrabResult grabResult = camera.StreamGrabber.GrabOne(2000);


                if (grabResult.GrabSucceeded)
                {
                    // Pixel 포맷 확인 (보통 Mono8 또는 BGR8)
                    PixelType pixelType = grabResult.PixelTypeValue;


                    if (pixelType == PixelType.Mono8)
                    {
                        st_var.bitmap_grab = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format8bppIndexed);

                        // Grayscale 팔레트 설정
                        ColorPalette palette = st_var.bitmap_grab.Palette;
                        for (int i = 0; i < 256; i++)
                        {
                            palette.Entries[i] = Color.FromArgb(i, i, i);
                        }
                        st_var.bitmap_grab.Palette = palette;
                    }
                    else
                    {
                        st_var.bitmap_grab = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format24bppRgb);
                    }

                    BitmapData bmpData = st_var.bitmap_grab.LockBits(
                        new Rectangle(0, 0, st_var.bitmap_grab.Width, st_var.bitmap_grab.Height),
                        ImageLockMode.WriteOnly,
                        st_var.bitmap_grab.PixelFormat);

                    // Grab 데이터 복사
                    Marshal.Copy(grabResult.PixelData as byte[], 0, bmpData.Scan0,
                                 grabResult.Width * grabResult.Height *
                                 (Image.GetPixelFormatSize(st_var.bitmap_grab.PixelFormat) / 8));

                    st_var.bitmap_grab.UnlockBits(bmpData);

                }
                else
                {
                    MessageBox.Show("Grab Failed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Grab Error\n" + ex.Message);
            }
        }

        private void FUNC_CATCH()
        {
            try
            {
                Mat frame = st_var.bitmap_grab.ToMat();
                if (frame.IsEmpty) return;

                Mat grayFrame = new Mat();
                if (frame.NumberOfChannels > 1)
                    CvInvoke.CvtColor(frame, grayFrame, ColorConversion.Bgr2Gray);
                else
                    grayFrame = frame.Clone();

                if (grayFrame.Depth != DepthType.Cv8U)
                    grayFrame.ConvertTo(grayFrame, DepthType.Cv8U);

                Mat result = new Mat();
                CvInvoke.MatchTemplate(grayFrame, template, result, TemplateMatchingType.CcorrNormed);

                double minVal = 0, maxVal = 0;
                Point minLoc = new Point(), maxLoc = new Point();
                CvInvoke.MinMaxLoc(result, ref minVal, ref maxVal, ref minLoc, ref maxLoc);

                Rectangle matchRect = new Rectangle(maxLoc, template.Size);

                st_var.catch_point = maxVal;
                st_var.catch_X_position = visionTOrealX(maxLoc.Y + (template.Size.Height / 2));
                st_var.catch_Y_position = visionTOrealY(maxLoc.X + (template.Size.Width / 2));

                Mat displayFrame = frame.Clone();
                CvInvoke.Rectangle(displayFrame, matchRect, new MCvScalar(0, 0, 255), 2);

                Point display_center = new Point();
                display_center.X = st_var.center_x;
                display_center.Y = st_var.center_y;

                CvInvoke.Circle(displayFrame, display_center, st_var.fit_r, new MCvScalar(0, 0, 255), 5);

                CvInvoke.Circle(displayFrame, display_center, st_var.out_r, new MCvScalar(0, 0, 255), 5);

                st_var.bitmap_catch = displayFrame.ToBitmap();
            }
            catch
            {
            }
        }

        private void FUNC_CATCH2()
        {
            try
            {
                Image<Gray, byte> grayImg = st_var.bitmap_grab.ToImage<Gray, byte>();

                Point center = new Point(st_var.hole_center_x, st_var.hole_center_y);

                Image<Gray, byte> extractImg = ExtractCircularROI(grayImg, center, st_var.hole_radius);

                Image<Gray, byte> resultImg = new Image<Gray, byte>(grayImg.Size);

                CvInvoke.InRange(extractImg, new ScalarArray(st_var.min_bright), new ScalarArray(st_var.max_bright), resultImg);

                st_var.bitmap_catch = FindBlobsByContour(resultImg).ToBitmap();

               
            }
            catch
            {

            }
        }

        private Image<Gray, byte> ExtractCircularROI(Image<Gray, byte> src, Point center, int radius)
        {
            // CREATE MASK
            Image<Gray, byte> mask = new Image<Gray, byte>(src.Size);
            mask.SetZero();

            // DRAW CIRCLE ON MASK
            CvInvoke.Circle(
                mask,
                center,
                radius,
                new MCvScalar(255),
                -1);

            // Result Image
            Image<Gray, byte> result = new Image<Gray, byte>(src.Size);

            // APPLY MASK
            CvInvoke.BitwiseAnd(src, src, result, mask);

            return result;
        }

        private Image<Gray, byte> FindBlobsByContour(Image<Gray, byte> binaryImg)
        {
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat hierarchy = new Mat();

            CvInvoke.FindContours(
                binaryImg,
                contours,
                hierarchy,
                RetrType.External,      // 외곽 Contour만
                ChainApproxMethod.ChainApproxSimple
            );

            Image<Gray, byte> result = binaryImg.Clone();

            List<double> area = new List<double>();

            for (int i = 0; i < contours.Size; i++)
            {
                area.Add(CvInvoke.ContourArea(contours[i]));
            }

            int maxIndex = 0;
            double maxValue = area[0];

            for (int i = 1; i < area.Count; i++)
            {
                if (area[i] > maxValue)
                {
                    maxValue = area[i];
                    maxIndex = i;
                }
            }

            Rectangle rect = CvInvoke.BoundingRectangle(contours[maxIndex]);

            int cx = rect.X + rect.Width / 2;
            int cy = rect.Y + rect.Height / 2;

            CvInvoke.Rectangle(result, rect, new MCvScalar(255, 255, 255), 5);
            CvInvoke.Circle(result, new Point(cx, cy), 20, new MCvScalar(255, 255, 255), -1);

            st_var.catch_X_position = visionTOrealX(cy);
            st_var.catch_Y_position = visionTOrealY(cx);

            Point display_center = new Point();
            display_center.X = st_var.center_x;
            display_center.Y = st_var.center_y;

            CvInvoke.Circle(result, display_center, st_var.fit_r, new MCvScalar(255, 255, 255), 5);

            CvInvoke.Circle(result, display_center, st_var.out_r, new MCvScalar(255, 255, 255), 5);

            return result;

        }

        private void CATCH_Click(object sender, EventArgs e)
        {
            try
            {
                Mat frame = bitmap_manual.ToMat();

                if (frame.IsEmpty) return;

                Mat grayFrame = frame;

                if (frame.NumberOfChannels > 1)
                    CvInvoke.CvtColor(frame, grayFrame, ColorConversion.Bgr2Gray);

                if (grayFrame.Depth != DepthType.Cv8U)
                    grayFrame.ConvertTo(grayFrame, DepthType.Cv8U);


                Mat result = new Mat();

                CvInvoke.MatchTemplate(grayFrame, template, result, TemplateMatchingType.CcorrNormed);

                double minVal = 0, maxVal = 0;
                Point minLoc = new Point();
                Point maxLoc = new Point();

                CvInvoke.MinMaxLoc(result, ref minVal, ref maxVal, ref minLoc, ref maxLoc);

                // 매칭된 위치 좌표
                Rectangle matchRect = new Rectangle(maxLoc, template.Size);

                // 좌표 출력

                txtCPOSITION.Text = $"X:{visionTOrealX(maxLoc.Y + (template.Size.Height / 2)):F3}, Y:{visionTOrealY(maxLoc.X + (template.Size.Width / 2)):F3}";

                // 매칭 영역 표시
                CvInvoke.Rectangle(frame, matchRect, new MCvScalar(0, 0, 255), 2);

                // PictureBox에 표시
                SCR_MANUAL.Image?.Dispose();
                SCR_MANUAL.Image = frame.ToBitmap();

                st_var.log_msg = st_var.log_msg + "CATCH1_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
            }
            catch
            {
            }

        }
        private double visionTOrealX(int Y)
        {
            return ((Y - st_var.vision_chk_Y) * st_var.robot_cnv_rate_X) + st_var.robot_diff_x;
        }

        private double visionTOrealX2(int Y)
        {
            return ((Y - st_var.vision_chk_Y) * st_var.robot_cnv_rate_X * st_var.rate_diff_x) + st_var.robot_chk_pos_X - st_var.diff_x;
        }
        private double visionTOrealY(int X)
        {
            return ((X - st_var.vision_chk_X) * st_var.robot_cnv_rate_Y) + st_var.robot_diff_y;
        }

        private double visionTOrealY2(int X)
        {
            return ((X - st_var.vision_chk_X) * st_var.robot_cnv_rate_Y * st_var.rate_diff_y) + st_var.robot_chk_pos_Y - st_var.diff_y;
        }


        private void START_Click(object sender, EventArgs e)
        {
            START.Image = Properties.Resources.button2_dn;
            st_var.auto_step = 1000;
            st_var.auto_step_temp = 1000;
            if (!tmAUTO.Enabled && !tmCORRECT.Enabled) { tmAUTO.Enabled = true; }
        }

        private void STOP_Click(object sender, EventArgs e)
        {
            if (tmAUTO.Enabled) { tmAUTO.Enabled = false; }

            START.Image = Properties.Resources.button2_up;

            ASTART.Checked = false;
            PHASE1.Checked = false;
            PHASE2.Checked = false;
            PHASE3.Checked = false;
            AEND.Checked = false;

            ASTART.BackgroundImage = Properties.Resources.led5_off;
            PHASE1.BackgroundImage = Properties.Resources.led5_off;
            PHASE2.BackgroundImage = Properties.Resources.led5_off;
            PHASE3.BackgroundImage = Properties.Resources.led5_off;
            AEND.BackgroundImage = Properties.Resources.led5_off;
        }

        private void tmAUTO_Tick(object sender, EventArgs e)
        {

            switch (st_var.auto_step)
            {
                case 1000:

                    NORMAL.Image = null;
                    NORMAL.Image?.Dispose();

                    CORRECT.Image = null;
                    CORRECT.Image?.Dispose();

                    POS_X.Text = "";
                    POS_Y.Text = "";


                    COR_START.Checked = false;
                    GET_POS1.Checked = false;
                    GET_POS2.Checked = false;
                    GET_POS3.Checked = false;
                    GET_POS4.Checked = false;
                    MOVE1.Checked = false;
                    MOVE2.Checked = false;
                    MOVE3.Checked = false;
                    MOVE4.Checked = false;
                    GET_Z_POS.Checked = false;
                    COR_END.Checked = false;


                    COR_START.BackgroundImage = Properties.Resources.led5_off;
                    GET_POS1.BackgroundImage = Properties.Resources.led5_off;
                    GET_POS2.BackgroundImage = Properties.Resources.led5_off;
                    GET_POS3.BackgroundImage = Properties.Resources.led5_off;
                    GET_POS4.BackgroundImage = Properties.Resources.led5_off;
                    MOVE1.BackgroundImage = Properties.Resources.led5_off;
                    MOVE2.BackgroundImage = Properties.Resources.led5_off;
                    MOVE3.BackgroundImage = Properties.Resources.led5_off;
                    MOVE4.BackgroundImage = Properties.Resources.led5_off;
                    GET_Z_POS.BackgroundImage = Properties.Resources.led5_off;
                    COR_END.BackgroundImage = Properties.Resources.led5_off;

                    //start motion 1 
                    NG.Checked = false;
                    NG.BackgroundImage = Properties.Resources.led2_off;

                    GOOD.Checked = false;
                    GOOD.BackgroundImage = Properties.Resources.led1_off;

                    OUTRANGE.Checked = false;
                    OUTRANGE.BackgroundImage = Properties.Resources.led3_off;

                    ASTART.Checked = true;
                    PHASE1.Checked = true;
                    PHASE2.Checked = false;
                    PHASEWORK.Checked = false;
                    PHASE3.Checked = false;
                    AEND.Checked = false;

                    ASTART.BackgroundImage = Properties.Resources.led5_on;
                    PHASE1.BackgroundImage = Properties.Resources.led5_on;
                    PHASE2.BackgroundImage = Properties.Resources.led5_off;
                    PHASEWORK.BackgroundImage = Properties.Resources.led5_off;
                    PHASE3.BackgroundImage = Properties.Resources.led5_off;
                    AEND.BackgroundImage = Properties.Resources.led5_off;

                    txtJOBNAME.Text = "TIP1";
                    st_var.rc_step = 1000;
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST START " + (txtJOBNAME.Text.Length + 1).ToString() + "\r\n";
                    st_var.rb_cmd_reply_msg = "OK: START\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = txtJOBNAME.Text + "\r";
                    st_var.rb_cd_reply_format = 4;
                    if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }

                    st_var.act1_cnt = 0;

                    st_var.auto_step = 2000;

                    if (st_var.auto_step != st_var.auto_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "JOB_TIP1_START_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 2000:
                    if (st_var.io_status[0])
                    {
                        st_var.auto_step = 3000;
                    }
                    else
                    {
                        st_var.act1_cnt = st_var.act1_cnt + 1;

                        if (st_var.act1_cnt > st_var.act1_wait)
                        {
                            st_var.auto_step = 10000;
                        }
                    }

                    if (st_var.auto_step != st_var.auto_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "JOB_TIP1_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 3000:
                    display_normal_OUTR();
                    //chk position with normal position

                    POS_X.Text = st_var.catch_X_position.ToString("F2");
                    POS_Y.Text = st_var.catch_Y_position.ToString("F2");

                    if ((Math.Abs(st_var.robot_chk_pos_X - st_var.catch_X_position) > st_var.x_outr) || (Math.Abs(st_var.robot_chk_pos_Y - st_var.catch_Y_position) > st_var.y_outr))
                    {
                        OUTRANGE.Checked = true;
                        OUTRANGE.BackgroundImage = Properties.Resources.led3_on;
                        st_var.auto_step = 10000;
                    }
                    else
                    {
                        OUTRANGE.Checked = false;
                        OUTRANGE.BackgroundImage = Properties.Resources.led3_off;
                        st_var.auto_step = 4000;
                    }

                    if (st_var.auto_step != st_var.auto_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "CHK_OUT_OF_RANGE_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;


                case 4000:
                    // start motion 2
                    ASTART.Checked = true;
                    PHASE1.Checked = true;
                    PHASE2.Checked = true;
                    PHASEWORK.Checked = false;
                    PHASE3.Checked = false;
                    AEND.Checked = false;

                    ASTART.BackgroundImage = Properties.Resources.led5_on;
                    PHASE1.BackgroundImage = Properties.Resources.led5_on;
                    PHASE2.BackgroundImage = Properties.Resources.led5_on;
                    PHASEWORK.BackgroundImage = Properties.Resources.led5_off;
                    PHASE3.BackgroundImage = Properties.Resources.led5_off;
                    AEND.BackgroundImage = Properties.Resources.led5_off;


                    txtJOBNAME.Text = "TIP2";
                    st_var.rc_step = 1000;
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST START " + (txtJOBNAME.Text.Length + 1).ToString() + "\r\n";
                    st_var.rb_cmd_reply_msg = "OK: START\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = txtJOBNAME.Text + "\r";
                    st_var.rb_cd_reply_format = 4;
                    if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }

                    st_var.act2_cnt = 0;
                    st_var.auto_step = 5000;

                    if (st_var.auto_step != st_var.auto_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "JOB_TIP2_START_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 5000:

                    if (st_var.io_status[1])
                    {
                        st_var.auto_step = 6000;
                    }
                    else
                    {
                        st_var.act2_cnt = st_var.act2_cnt + 1;

                        if (st_var.act2_cnt > st_var.act2_wait)
                        {
                            st_var.auto_step = 10000;
                        }
                    }

                    if (st_var.auto_step != st_var.auto_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "JOB_TIP2_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 6000:
                    //check position
                    display_normal();

                    POS_X.Text = st_var.catch_X_position.ToString("F2");
                    POS_Y.Text = st_var.catch_Y_position.ToString("F2");

                    st_var.cort_x = 0;
                    st_var.cort_y = 0;
                    st_var.cort_z = 0;

                    CORRECT_X.Text = st_var.cort_x.ToString("F2");
                    CORRECT_Y.Text = st_var.cort_y.ToString("F2");
                    CORRECT_Z.Text = st_var.cort_z.ToString("F2");

                    string result = "";

                    if ((Math.Abs(st_var.robot_chk_pos_X - st_var.catch_X_position) > st_var.x_tol) || (Math.Abs(st_var.robot_chk_pos_Y - st_var.catch_Y_position) > st_var.y_tol))
                    {
                        result = "FALSE";
                        GOOD.Checked = false;
                        GOOD.BackgroundImage = Properties.Resources.led1_off;

                        NG.Checked = true;
                        NG.BackgroundImage = Properties.Resources.led2_on;

                        Bitmap bmp = new Bitmap(NORMAL.Image);

                        using (Graphics g = Graphics.FromImage(bmp))
                        using (Font font = new Font("Arial", 140, FontStyle.Bold))
                        using (Brush brush = new SolidBrush(Color.Red))
                        {
                            g.DrawString("NG X: " + (st_var.robot_chk_pos_X - st_var.catch_X_position).ToString("F2") + ", Y: " + (st_var.robot_chk_pos_Y - st_var.catch_Y_position).ToString("F2"), font, brush, new PointF(210, 300));
                        }

                        NORMAL.Image = bmp;

                        st_var.auto_step = 7000;

                    }
                    else
                    {
                        result = "GOOD";
                        GOOD.Checked = true;
                        GOOD.BackgroundImage = Properties.Resources.led1_on;

                        NG.Checked = false;
                        NG.BackgroundImage = Properties.Resources.led2_off;

                        st_var.auto_step = 7600;
                    }

                    if (st_var.auto_step != st_var.auto_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "CHK_POSITION_" + result + "_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 7000:

                    st_var.correct_step = 1000;
                    st_var.correct_step_temp = 1000;

                    tmCORRECT.Enabled = true;
                    st_var.auto_step = 7500;

                    if (st_var.auto_step != st_var.auto_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "CORRECT_START_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 7500:

                    if (!tmCORRECT.Enabled)
                    {
                        st_var.auto_step = 7600;
                    }

                    if (st_var.auto_step != st_var.auto_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "CORRECT_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 7600:

                    ASTART.Checked = true;
                    PHASE1.Checked = true;
                    PHASE2.Checked = true;
                    PHASEWORK.Checked = true;
                    PHASE3.Checked = false;
                    PHASE3.Checked = false;
                    AEND.Checked = false;

                    ASTART.BackgroundImage = Properties.Resources.led5_on;
                    PHASE1.BackgroundImage = Properties.Resources.led5_on;
                    PHASE2.BackgroundImage = Properties.Resources.led5_on;
                    PHASEWORK.BackgroundImage = Properties.Resources.led5_on;
                    PHASE3.BackgroundImage = Properties.Resources.led5_off;
                    AEND.BackgroundImage = Properties.Resources.led5_off;

                    st_var.work_step = 1000;
                    tmWORK.Enabled = true;
                    st_var.auto_step = 7700;

                    if (st_var.auto_step != st_var.auto_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "WORK_START_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 7700:
                    if (!tmWORK.Enabled)
                    {
                        st_var.auto_step = 8000;
                    }

                    if (st_var.auto_step != st_var.auto_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "WORK_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 8000:

                    ASTART.Checked = true;
                    PHASE1.Checked = true;
                    PHASE2.Checked = true;
                    PHASEWORK.Checked = true;
                    PHASE3.Checked = true;
                    AEND.Checked = false;

                    ASTART.BackgroundImage = Properties.Resources.led5_on;
                    PHASE1.BackgroundImage = Properties.Resources.led5_on;
                    PHASE2.BackgroundImage = Properties.Resources.led5_on;
                    PHASEWORK.BackgroundImage = Properties.Resources.led5_on;
                    PHASE3.BackgroundImage = Properties.Resources.led5_on;
                    AEND.BackgroundImage = Properties.Resources.led5_off;

                    txtJOBNAME.Text = "TIP3";
                    st_var.rc_step = 1000;
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST START " + (txtJOBNAME.Text.Length + 1).ToString() + "\r\n";
                    st_var.rb_cmd_reply_msg = "OK: START\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = txtJOBNAME.Text + "\r";
                    st_var.rb_cd_reply_format = 4;
                    if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }

                    st_var.act3_cnt = 0;
                    st_var.auto_step = 9000;

                    if (st_var.auto_step != st_var.auto_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "JOB_TIP3_START_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 9000:
                    if (st_var.io_status[2])
                    {
                        st_var.auto_step = 10000;
                    }
                    else
                    {
                        st_var.act3_cnt = st_var.act3_cnt + 1;

                        if (st_var.act3_cnt > st_var.act3_wait)
                        {
                            st_var.auto_step = 10000;
                        }
                    }

                    if (st_var.auto_step != st_var.auto_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "JOB_TIP3_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }
                    break;

                case 10000:
                    tmAUTO.Enabled = false;
                    START.Image = Properties.Resources.button2_up;

                    ASTART.Checked = true;
                    PHASE1.Checked = true;
                    PHASE2.Checked = true;
                    PHASEWORK.Checked = true;
                    PHASE3.Checked = true;
                    AEND.Checked = true;

                    ASTART.BackgroundImage = Properties.Resources.led5_on;
                    PHASE1.BackgroundImage = Properties.Resources.led5_on;
                    PHASE2.BackgroundImage = Properties.Resources.led5_on;
                    PHASEWORK.BackgroundImage = Properties.Resources.led5_on;
                    PHASE3.BackgroundImage = Properties.Resources.led5_on;
                    AEND.BackgroundImage = Properties.Resources.led5_on;

                    st_var.log_msg = st_var.log_msg + "CHECK_POSITION_PROCESS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                    try
                    {
                        File.WriteAllText("C:\\LOG\\LOG_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt", st_var.log_msg);
                        st_var.log_msg = "";
                    }
                    catch
                    {

                    }

                    break;

                default:
                    tmAUTO.Enabled = false;
                    break;

            }

            st_var.auto_step_temp = st_var.auto_step;
        }

        private void tmCORRECT_Tick(object sender, EventArgs e)
        {
            switch (st_var.correct_step)
            {
                case 1000:
                    CRT_START.Image = Properties.Resources.button4_dn;
                    CORRECT_X.Text = "";
                    CORRECT_Y.Text = "";
                    CORRECT_Z.Text = "";

                    CORRECT.Image = null;
                    CORRECT.Image?.Dispose();


                    COR_START.Checked = true;
                    GET_POS1.Checked = true;
                    GET_POS2.Checked = false;
                    GET_POS3.Checked = false;
                    GET_POS4.Checked = false;
                    MOVE1.Checked = false;
                    MOVE2.Checked = false;
                    MOVE3.Checked = false;
                    MOVE4.Checked = false;
                    GET_Z_POS.Checked = false;
                    COR_END.Checked = false;

                    COR_START.BackgroundImage = Properties.Resources.led5_on;
                    GET_POS1.BackgroundImage = Properties.Resources.led5_on;
                    GET_POS2.BackgroundImage = Properties.Resources.led5_off;
                    GET_POS3.BackgroundImage = Properties.Resources.led5_off;
                    GET_POS4.BackgroundImage = Properties.Resources.led5_off;
                    MOVE1.BackgroundImage = Properties.Resources.led5_off;
                    MOVE2.BackgroundImage = Properties.Resources.led5_off;
                    MOVE3.BackgroundImage = Properties.Resources.led5_off;
                    MOVE4.BackgroundImage = Properties.Resources.led5_off;
                    GET_Z_POS.BackgroundImage = Properties.Resources.led5_off;
                    COR_END.BackgroundImage = Properties.Resources.led5_off;

                    display_correct();
                    st_var.correct_step = 1600;

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "CHK_CORRECT1_POS_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 1600:

                    st_var.rc_step = 1000;
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                    st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = "1,0\r";
                    st_var.rb_cd_reply_format = 2;
                    if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }

                    st_var.correct_step = 1700;

                    break;

                case 1700:
                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_st = st_var.x_pos;
                        st_var.y_pos_st = st_var.y_pos;
                        st_var.correct_step = 2000;
                    }
                    break;

                case 2000:

                    MOVE1.Checked = true;
                    MOVE1.BackgroundImage = Properties.Resources.led5_on;

                    st_var.cor_move_x = st_var.robot_chk_pos_X - st_var.catch_X_position;

                    st_var.rc_step = 1000;
                    st_var.move_cmd = $"0,{st_var.cor1_spd.ToString():F2},1,{st_var.cor_move_x.ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0,0,0";
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
                    st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
                    st_var.rb_cd_reply_format = 3;

                    if (tmROBOT.Enabled == false)
                    {
                        tmROBOT.Enabled = true;
                        st_var.cor_move_x_cnt = 0;
                        st_var.correct_step = 2200;
                    }

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "MOVE_CORRECT1_XPOS_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 2200:
                    if (tmROBOT.Enabled == false)
                    {
                        st_var.rc_step = 1000;
                        st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                        st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                        st_var.rb_has_cmd_data = true;
                        st_var.rb_cmddata_msg = "1,0\r";
                        st_var.rb_cd_reply_format = 2;
                        tmROBOT.Enabled = true;
                        st_var.correct_step = 2400;
                    }
                    break;

                case 2400:
                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_now = st_var.x_pos;
                        st_var.y_pos_now = st_var.y_pos;

                        if ((Math.Abs(st_var.x_pos_now - st_var.x_pos_st) > Math.Abs(st_var.cor_move_x) * 0.98) || (st_var.cor_move_x_cnt > st_var.crt1_wait))
                        {
                            st_var.correct_step = 3600;

                            st_var.log_msg = st_var.log_msg + "MOVE_CORRECT1_XPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                        }
                        else
                        {
                            st_var.cor_move_x_cnt = st_var.cor_move_x_cnt + 1;
                            st_var.correct_step = 2200;
                        }
                    }
                    break;

                /*
                 case 3000:


                     if (st_var.cor_move_x_cnt > st_var.crt1_wait)
                     {
                         st_var.correct_step = 4000;
                     }
                     else
                     {
                         st_var.cor_move_x_cnt = st_var.cor_move_x_cnt + 1;
                     }

                     if (st_var.correct_step != st_var.correct_step_temp)
                     {
                         st_var.log_msg = st_var.log_msg + "MOVE_CORRECT1_XPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                     }


                     break;
                */

                case 3600:

                    st_var.rc_step = 1000;
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                    st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = "1,0\r";
                    st_var.rb_cd_reply_format = 2;
                    tmROBOT.Enabled = true;
                    st_var.correct_step = 3700;

                    break;

                case 3700:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_st = st_var.x_pos;
                        st_var.y_pos_st = st_var.y_pos;
                        st_var.correct_step = 4000;
                    }

                    break;

                case 4000:
                    st_var.cor_move_y = st_var.robot_chk_pos_Y - st_var.catch_Y_position;

                    st_var.rc_step = 1000;
                    st_var.move_cmd = $"0,{st_var.cor1_spd.ToString():F2},1,0,{st_var.cor_move_y.ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0,0";
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
                    st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
                    st_var.rb_cd_reply_format = 3;

                    if (!tmROBOT.Enabled)
                    {
                        tmROBOT.Enabled = true;
                        st_var.cor_move_y_cnt = 0;
                        st_var.correct_step = 4200;
                    }

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "MOVE_CORRECT1_YPOS_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }
                    break;

                case 4200:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.rc_step = 1000;
                        st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                        st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                        st_var.rb_has_cmd_data = true;
                        st_var.rb_cmddata_msg = "1,0\r";
                        st_var.rb_cd_reply_format = 2;
                        tmROBOT.Enabled = true;

                        st_var.correct_step = 4400;
                    }
                    break;

                case 4400:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_now = st_var.x_pos;
                        st_var.y_pos_now = st_var.y_pos;

                        if ((Math.Abs(st_var.y_pos_now - st_var.y_pos_st) > Math.Abs(st_var.cor_move_y) * 0.98) || (st_var.cor_move_y_cnt > st_var.crt1_wait))
                        {
                            st_var.correct_step = 6000;

                            st_var.log_msg = st_var.log_msg + "MOVE_CORRECT1_YPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                        }
                        else
                        {
                            st_var.cor_move_y_cnt = st_var.cor_move_y_cnt + 1;
                            st_var.correct_step = 4200;
                        }
                    }
                    break;

                /*
                case 5000:
                    if (st_var.cor_move_y_cnt > st_var.crt1_wait)
                    {
                        st_var.correct_step = 6000;
                    }
                    else
                    {
                        st_var.cor_move_y_cnt = st_var.cor_move_y_cnt + 1;
                    }

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "MOVE_CORRECT1_YPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;
                */

                case 6000:

                    GET_POS2.Checked = true;
                    GET_POS2.BackgroundImage = Properties.Resources.led5_on;

                    display_correct();
                    st_var.correct_step = 6600;

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "CHK_CORRECT2_POS_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 6600:

                    st_var.rc_step = 1000;
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                    st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = "1,0\r";
                    st_var.rb_cd_reply_format = 2;
                    tmROBOT.Enabled = true;
                    st_var.correct_step = 6700;

                    break;

                case 6700:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_st = st_var.x_pos;
                        st_var.y_pos_st = st_var.y_pos;
                        st_var.correct_step = 7000;
                    }

                    break;

                case 7000:

                    MOVE2.Checked = true;
                    MOVE2.BackgroundImage = Properties.Resources.led5_on;

                    st_var.cor_move_x = st_var.robot_chk_pos_X - st_var.catch_X_position;

                    st_var.rc_step = 1000;
                    st_var.move_cmd = $"0,{st_var.cor2_spd.ToString():F2},1,{st_var.cor_move_x.ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0,0,0";
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
                    st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
                    st_var.rb_cd_reply_format = 3;

                    if (!tmROBOT.Enabled)
                    {
                        tmROBOT.Enabled = true;
                        st_var.cor_move_x_cnt = 0;
                        st_var.correct_step = 7200;
                    }

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "MOVE_CORRECT2_XPOS_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 7200:
                    if (tmROBOT.Enabled == false)
                    {
                        st_var.rc_step = 1000;
                        st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                        st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                        st_var.rb_has_cmd_data = true;
                        st_var.rb_cmddata_msg = "1,0\r";
                        st_var.rb_cd_reply_format = 2;
                        tmROBOT.Enabled = true;
                        st_var.correct_step = 7400;
                    }
                    break;

                case 7400:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_now = st_var.x_pos;
                        st_var.y_pos_now = st_var.y_pos;

                        if ((Math.Abs(st_var.x_pos_now - st_var.x_pos_st) > Math.Abs(st_var.cor_move_x) * 0.98) || (st_var.cor_move_x_cnt > st_var.crt2_wait))
                        {
                            st_var.correct_step = 8600;

                            st_var.log_msg = st_var.log_msg + "MOVE_CORRECT2_XPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                        }
                        else
                        {
                            st_var.cor_move_x_cnt = st_var.cor_move_x_cnt + 1;
                            st_var.correct_step = 7200;
                        }
                    }
                    break;

                /*
            case 8000:

                if (st_var.cor_move_x_cnt > st_var.crt2_wait)
                {
                    st_var.correct_step = 9000;
                }
                else
                {
                    st_var.cor_move_x_cnt = st_var.cor_move_x_cnt + 1;
                }

                if (st_var.correct_step != st_var.correct_step_temp)
                {
                    st_var.log_msg = st_var.log_msg + "MOVE_CORRECT2_XPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                }

                break;
                */

                case 8600:

                    st_var.rc_step = 1000;
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                    st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = "1,0\r";
                    st_var.rb_cd_reply_format = 2;
                    tmROBOT.Enabled = true; ;
                    st_var.correct_step = 8700;

                    break;

                case 8700:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_st = st_var.x_pos;
                        st_var.y_pos_st = st_var.y_pos;
                        st_var.correct_step = 9000;
                    }

                    break;

                case 9000:

                    st_var.cor_move_y = st_var.robot_chk_pos_Y - st_var.catch_Y_position;

                    st_var.rc_step = 1000;
                    st_var.move_cmd = $"0,{st_var.cor2_spd.ToString():F2},1,0,{st_var.cor_move_y.ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0,0";
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
                    st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
                    st_var.rb_cd_reply_format = 3;

                    if (!tmROBOT.Enabled)
                    {
                        tmROBOT.Enabled = true;
                        st_var.cor_move_y_cnt = 0;
                        st_var.correct_step = 9200;
                    }

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "MOVE_CORRECT2_YPOS_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 9200:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.rc_step = 1000;
                        st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                        st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                        st_var.rb_has_cmd_data = true;
                        st_var.rb_cmddata_msg = "1,0\r";
                        st_var.rb_cd_reply_format = 2;
                        tmROBOT.Enabled = true;
                        st_var.correct_step = 9400;
                    }

                    break;

                case 9400:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_now = st_var.x_pos;
                        st_var.y_pos_now = st_var.y_pos;

                        if ((Math.Abs(st_var.y_pos_now - st_var.y_pos_st) > Math.Abs(st_var.cor_move_y) * 0.98) || (st_var.cor_move_y_cnt > st_var.crt2_wait))
                        {
                            st_var.correct_step = 11000;

                            st_var.log_msg = st_var.log_msg + "MOVE_CORRECT2_YPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                        }
                        else
                        {
                            st_var.cor_move_y_cnt = st_var.cor_move_y_cnt + 1;

                            st_var.correct_step = 9200;
                        }
                    }

                    break;

                /*
                case 10000:

                    if (st_var.cor_move_y_cnt > st_var.crt2_wait)
                    {
                        st_var.correct_step = 11000;
                    }
                    else
                    {
                        st_var.cor_move_y_cnt = st_var.cor_move_y_cnt + 1;
                    }

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "MOVE_CORRECT2_YPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }
                    break;
                 */

                case 11000:

                    GET_POS3.Checked = true;
                    GET_POS3.BackgroundImage = Properties.Resources.led5_on;

                    display_correct();
                    st_var.correct_step = 11600;

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "CHK_CORRECT3_POS_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 11600:

                    st_var.rc_step = 1000;
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                    st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = "1,0\r";
                    st_var.rb_cd_reply_format = 2;
                    tmROBOT.Enabled = true;

                    st_var.correct_step = 11700;

                    break;

                case 11700:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_st = st_var.x_pos;
                        st_var.y_pos_st = st_var.y_pos;
                        st_var.correct_step = 12000;
                    }

                    break;

                case 12000:

                    MOVE3.Checked = true;
                    MOVE3.BackgroundImage = Properties.Resources.led5_on;

                    st_var.cor_move_x = st_var.robot_chk_pos_X - st_var.catch_X_position;

                    st_var.rc_step = 1000;
                    st_var.move_cmd = $"0,{st_var.cor3_spd.ToString():F2},1,{st_var.cor_move_x.ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0,0,0";
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
                    st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
                    st_var.rb_cd_reply_format = 3;

                    if (!tmROBOT.Enabled)
                    {
                        tmROBOT.Enabled = true;
                        st_var.cor_move_x_cnt = 0;
                        st_var.correct_step = 12200;
                    }

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "MOVE_CORRECT3_XPOS_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 12200:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.rc_step = 1000;
                        st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                        st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                        st_var.rb_has_cmd_data = true;
                        st_var.rb_cmddata_msg = "1,0\r";
                        st_var.rb_cd_reply_format = 2;
                        tmROBOT.Enabled = true;

                        st_var.correct_step = 12400;
                    }

                    break;

                case 12400:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_now = st_var.x_pos;
                        st_var.y_pos_now = st_var.y_pos;

                        if ((Math.Abs(st_var.x_pos_now - st_var.x_pos_st) > Math.Abs(st_var.cor_move_x) * 0.98) || (st_var.cor_move_x_cnt > st_var.crt3_wait))
                        {
                            st_var.correct_step = 13600;

                            st_var.log_msg = st_var.log_msg + "MOVE_CORRECT3_XPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                        }
                        else
                        {
                            st_var.cor_move_x_cnt = st_var.cor_move_x_cnt + 1;

                            st_var.correct_step = 12200;
                        }
                    }

                    break;


                /*
                   case 13000:

                       if (st_var.cor_move_x_cnt > st_var.crt3_wait)
                       {
                           st_var.correct_step = 14000;
                       }
                       else
                       {
                           st_var.cor_move_x_cnt = st_var.cor_move_x_cnt + 1;
                       }

                       if (st_var.correct_step != st_var.correct_step_temp)
                       {
                           st_var.log_msg = st_var.log_msg + "MOVE_CORRECT3_XPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                       }
                       break;
                */

                case 13600:

                    st_var.rc_step = 1000;
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                    st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = "1,0\r";
                    st_var.rb_cd_reply_format = 2;
                    tmROBOT.Enabled = true;
                    st_var.correct_step = 13700;

                    break;

                case 13700:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_st = st_var.x_pos;
                        st_var.y_pos_st = st_var.y_pos;
                        st_var.correct_step = 14000;
                    }

                    break;

                case 14000:

                    st_var.cor_move_y = st_var.robot_chk_pos_Y - st_var.catch_Y_position;

                    st_var.rc_step = 1000;
                    st_var.move_cmd = $"0,{st_var.cor3_spd.ToString():F2},1,0,{st_var.cor_move_y.ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0,0";
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
                    st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
                    st_var.rb_cd_reply_format = 3;

                    if (!tmROBOT.Enabled)
                    {
                        tmROBOT.Enabled = true;
                        st_var.cor_move_y_cnt = 0;
                        st_var.correct_step = 14200;
                    }

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "MOVE_CORRECT3_YPOS_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 14200:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.rc_step = 1000;
                        st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                        st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                        st_var.rb_has_cmd_data = true;
                        st_var.rb_cmddata_msg = "1,0\r";
                        st_var.rb_cd_reply_format = 2;
                        tmROBOT.Enabled = true;
                        st_var.correct_step = 14400;
                    }
                    break;

                case 14400:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_now = st_var.x_pos;
                        st_var.y_pos_now = st_var.y_pos;

                        if ((Math.Abs(st_var.y_pos_now - st_var.y_pos_st) > Math.Abs(st_var.cor_move_y) * 0.98) || (st_var.cor_move_y_cnt > st_var.crt3_wait))
                        {
                            st_var.correct_step = 16000;

                            st_var.log_msg = st_var.log_msg + "MOVE_CORRECT3_YPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                        }
                        else
                        {
                            st_var.cor_move_y_cnt = st_var.cor_move_y_cnt + 1;

                            st_var.correct_step = 14200;
                        }
                    }

                    break;

                /*
                case 15000:

                    if (st_var.cor_move_y_cnt > st_var.crt3_wait)
                    {
                        st_var.correct_step = 16000;
                    }
                    else
                    {
                        st_var.cor_move_y_cnt = st_var.cor_move_y_cnt + 1;
                    }

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "MOVE_CORRECT3_YPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;
                */

                case 16000:

                    GET_POS4.Checked = true;
                    GET_POS4.BackgroundImage = Properties.Resources.led5_on;

                    display_correct();
                    st_var.correct_step = 16200;

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "CHK_CORRECT4_POS_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 16200:

                    st_var.rc_step = 1000;
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                    st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = "1,0\r";
                    st_var.rb_cd_reply_format = 2;
                    tmROBOT.Enabled = true;

                    st_var.correct_step = 16400;

                    break;

                case 16400:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_st = st_var.x_pos;
                        st_var.y_pos_st = st_var.y_pos;
                        st_var.correct_step = 17000;
                    }
                    break;

                case 17000:

                    MOVE4.Checked = true;
                    MOVE4.BackgroundImage = Properties.Resources.led5_on;

                    st_var.cor_move_x = st_var.robot_chk_pos_X - st_var.catch_X_position;

                    st_var.rc_step = 1000;
                    st_var.move_cmd = $"0,{st_var.cor3_spd.ToString():F2},1,{st_var.cor_move_x.ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0,0,0";
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
                    st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
                    st_var.rb_cd_reply_format = 3;

                    if (!tmROBOT.Enabled)
                    {
                        tmROBOT.Enabled = true;
                        st_var.cor_move_x_cnt = 0;
                        st_var.correct_step = 17200;
                    }


                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "MOVE_CORRECT4_XPOS_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 17200:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.rc_step = 1000;
                        st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                        st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                        st_var.rb_has_cmd_data = true;
                        st_var.rb_cmddata_msg = "1,0\r";
                        st_var.rb_cd_reply_format = 2;
                        tmROBOT.Enabled = true;

                        st_var.correct_step = 17400;
                    }

                    break;

                case 17400:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_now = st_var.x_pos;
                        st_var.y_pos_now = st_var.y_pos;

                        if ((Math.Abs(st_var.x_pos_now - st_var.x_pos_st) > Math.Abs(st_var.cor_move_x) * 0.98) || (st_var.cor_move_x_cnt > st_var.crt4_wait))
                        {
                            st_var.correct_step = 18200;

                            st_var.log_msg = st_var.log_msg + "MOVE_CORRECT4_XPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                        }
                        else
                        {
                            st_var.cor_move_x_cnt = st_var.cor_move_x_cnt + 1;

                            st_var.correct_step = 17200;
                        }
                    }

                    break;

                /*
                 case 18000:

                     if (st_var.cor_move_x_cnt > st_var.crt3_wait)
                     {
                         st_var.correct_step = 19000;
                     }
                     else
                     {
                         st_var.cor_move_x_cnt = st_var.cor_move_x_cnt + 1;
                     }

                     if (st_var.correct_step != st_var.correct_step_temp)
                     {
                         st_var.log_msg = st_var.log_msg + "MOVE_CORRECT4_XPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                     }

                     break;
                */
                case 18200:

                    st_var.rc_step = 1000;
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                    st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = "1,0\r";
                    st_var.rb_cd_reply_format = 2;
                    tmROBOT.Enabled = true;
                    st_var.correct_step = 18400;

                    break;

                case 18400:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_st = st_var.x_pos;
                        st_var.y_pos_st = st_var.y_pos;
                        st_var.correct_step = 19000;
                    }

                    break;

                case 19000:

                    st_var.cor_move_y = st_var.robot_chk_pos_Y - st_var.catch_Y_position;

                    st_var.rc_step = 1000;
                    st_var.move_cmd = $"0,{st_var.cor3_spd.ToString():F2},1,0,{st_var.cor_move_y.ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0,0";
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
                    st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
                    st_var.rb_cd_reply_format = 3;

                    if (!tmROBOT.Enabled)
                    {
                        tmROBOT.Enabled = true;
                        st_var.cor_move_y_cnt = 0;
                        st_var.correct_step = 19200;
                    }

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "MOVE_CORRECT4_YPOS_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 19200:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.rc_step = 1000;
                        st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                        st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                        st_var.rb_has_cmd_data = true;
                        st_var.rb_cmddata_msg = "1,0\r";
                        st_var.rb_cd_reply_format = 2;
                        tmROBOT.Enabled = true;

                        st_var.correct_step = 19400;
                    }

                    break;

                case 19400:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.x_pos_now = st_var.x_pos;
                        st_var.y_pos_now = st_var.y_pos;

                        if ((Math.Abs(st_var.y_pos_now - st_var.y_pos_st) > Math.Abs(st_var.cor_move_y) * 0.98) || (st_var.cor_move_y_cnt > st_var.crt4_wait))
                        {
                            st_var.correct_step = 30000;

                            st_var.log_msg = st_var.log_msg + "MOVE_CORRECT4_YPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                        }
                        else
                        {
                            st_var.cor_move_y_cnt = st_var.cor_move_y_cnt + 1;

                            st_var.correct_step = 19200;
                        }
                    }

                    break;

                /*
                 case 20000:

                     if (st_var.cor_move_y_cnt > st_var.crt3_wait)
                     {
                         st_var.correct_step = 21000;
                     }
                     else
                     {
                         st_var.cor_move_y_cnt = st_var.cor_move_y_cnt + 1;
                     }

                     if (st_var.correct_step != st_var.correct_step_temp)
                     {
                         st_var.log_msg = st_var.log_msg + "MOVE_CORRECT4_YPOS_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                     }

                     break;
                */

                case 21000:

                    GET_Z_POS.Checked = true;
                    GET_Z_POS.BackgroundImage = Properties.Resources.led5_on;

                    txtZ_POS.Text = "";
                    st_var.rc_step = 1000;
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                    st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = "1,0\r";
                    st_var.rb_cd_reply_format = 2;
                    tmROBOT.Enabled = true;

                    st_var.correct_step = 22000;
                    st_var.pos_cnt = 0;

                    if (st_var.correct_step != st_var.correct_step_temp)
                    {
                        st_var.log_msg = st_var.log_msg + "Z_SCAN_START_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                    }

                    break;

                case 22000:
                    if (txtZ_POS.Text.Trim().Length > 0)
                    {
                        st_var.crnt_z_pos = double.Parse(txtZ_POS.Text);
                        st_var.z_pos_st = st_var.crnt_z_pos;
                        st_var.correct_step = 23000;
                    }
                    else
                    {
                        st_var.pos_cnt = st_var.pos_cnt + 1;

                        if (st_var.pos_cnt > st_var.pos_wait)
                        {
                            st_var.correct_step = 32000;
                        }
                    }

                    break;

                case 23000:
                    st_var.z_scan_real_min = st_var.crnt_z_pos - 2 * ((int)((st_var.crnt_z_pos - st_var.z_scan_min) / 2));
                    st_var.z_scan_real_max = st_var.crnt_z_pos + 2 * ((int)((st_var.z_scan_max - st_var.crnt_z_pos) / 2));
                    st_var.z_scan_up_value = (int)((st_var.z_scan_real_max - st_var.z_scan_real_min) / 2) + 1;
                    st_var.z_scan_up_cnt = 0;
                    st_var.catch_points.Clear();

                    st_var.cor_move_z = st_var.z_scan_real_min - st_var.crnt_z_pos;

                    st_var.rc_step = 1000;
                    st_var.move_cmd = $"0,{st_var.cor4_spd.ToString():F2},1,0,0,{st_var.cor_move_z.ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0";
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
                    st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
                    st_var.rb_cd_reply_format = 3;

                    if (!tmROBOT.Enabled)
                    {
                        tmROBOT.Enabled = true;
                        st_var.crt4_cnt = 0;
                        st_var.correct_step = 23600;
                    }

                    break;

                case 23600:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.rc_step = 1000;
                        st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                        st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                        st_var.rb_has_cmd_data = true;
                        st_var.rb_cmddata_msg = "1,0\r";
                        st_var.rb_cd_reply_format = 2;
                        tmROBOT.Enabled = true;

                        st_var.correct_step = 23800;
                    }

                    break;

                case 23800:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.z_pos_now = st_var.z_pos;

                        if ((Math.Abs(st_var.z_pos_now - st_var.z_pos_st) > Math.Abs(st_var.cor_move_z) * 0.98))
                        {
                            st_var.correct_step = 25000;

                            st_var.log_msg = st_var.log_msg + "MOVE_START_Z_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                        }
                        else
                        {
                            st_var.correct_step = 23600;
                        }
                    }
                    break;

                /*
                case 24000:
                    if (st_var.crt4_cnt > (st_var.crt4_wait * (int)((st_var.crnt_z_pos - st_var.z_scan_min) / 2)))
                    {
                        st_var.correct_step = 25000;
                    }
                    else
                    {
                        st_var.crt4_cnt = st_var.crt4_cnt + 1;
                    }
                    break;
                */

                case 25000:
                    if (st_var.z_scan_up_cnt < st_var.z_scan_up_value)
                    {
                        display_correct();
                        st_var.catch_points.Add(st_var.catch_point);
                        st_var.z_scan_up_cnt = st_var.z_scan_up_cnt + 1;
                        st_var.correct_step = 25200;
                    }
                    else
                    {
                        st_var.correct_step = 27200;
                    }
                    break;

                case 25200:

                    st_var.rc_step = 1000;
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                    st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = "1,0\r";
                    st_var.rb_cd_reply_format = 2;
                    tmROBOT.Enabled = true;
                    st_var.correct_step = 25400;
                    break;

                case 25400:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.z_pos_st = st_var.z_pos;
                        st_var.correct_step = 26000;
                    }

                    break;

                case 26000:
                    st_var.cor_move_z = 2;

                    st_var.rc_step = 1000;
                    st_var.move_cmd = $"0,{st_var.cor4_spd.ToString():F2},1,0,0,{st_var.cor_move_z.ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0";
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
                    st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
                    st_var.rb_cd_reply_format = 3;

                    if (!tmROBOT.Enabled)
                    {
                        tmROBOT.Enabled = true;
                        st_var.crt4_cnt = 0;
                        st_var.correct_step = 26400;
                    }

                    break;

                case 26400:
                    if (tmROBOT.Enabled == false)
                    {
                        st_var.rc_step = 1000;
                        st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                        st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                        st_var.rb_has_cmd_data = true;
                        st_var.rb_cmddata_msg = "1,0\r";
                        st_var.rb_cd_reply_format = 2;
                        tmROBOT.Enabled = true;
                        st_var.correct_step = 26600;
                    }
                    break;

                case 26600:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.z_pos_now = st_var.z_pos;

                        if ((Math.Abs(st_var.z_pos_now - st_var.z_pos_st) > Math.Abs(st_var.cor_move_z) * 0.98))
                        {
                            st_var.correct_step = 25000;

                            st_var.log_msg = st_var.log_msg + "MOVE_SCANZ_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                        }
                        else
                        {
                            st_var.correct_step = 26400;
                        }
                    }
                    break;

                /*
                case 27000:
                    if (st_var.crt4_cnt > st_var.crt4_wait)
                    {
                        st_var.correct_step = 25000;
                    }
                    else
                    {
                        st_var.crt4_cnt = st_var.crt4_cnt + 1;
                    }
                    break;
                */

                case 27200:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.rc_step = 1000;
                        st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                        st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                        st_var.rb_has_cmd_data = true;
                        st_var.rb_cmddata_msg = "1,0\r";
                        st_var.rb_cd_reply_format = 2;
                        tmROBOT.Enabled = true;
                        st_var.correct_step = 27400;
                    }
                    break;

                case 27400:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.z_pos_st = st_var.z_pos;
                        st_var.correct_step = 28000;
                    }
                    break;


                case 28000:
                    st_var.catch_max_value = st_var.catch_points.Max();
                    st_var.max_index = st_var.catch_points.IndexOf(st_var.catch_max_value);
                    st_var.cor_move_z = -2 * ((st_var.catch_points.Count - st_var.max_index));
                    // st_var.cor_move_z = -2 * ((st_var.catch_points.Count - st_var.max_index) + 1);


                    st_var.rc_step = 1000;
                    st_var.move_cmd = $"0,{st_var.cor4_spd.ToString():F2},1,0,0,{st_var.cor_move_z.ToString():F3},0,0,0,0,0,0,0,0,0,0,0,0";
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST IMOV " + st_var.move_cmd.Length.ToString() + "\r\n";
                    st_var.rb_cmd_reply_msg = "OK: IMOV\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = st_var.move_cmd + "\r";
                    st_var.rb_cd_reply_format = 3;

                    if (!tmROBOT.Enabled)
                    {
                        tmROBOT.Enabled = true;
                        st_var.crt4_cnt = 0;
                        st_var.correct_step = 28400;

                    }

                    break;

                case 28400:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.rc_step = 1000;
                        st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                        st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                        st_var.rb_has_cmd_data = true;
                        st_var.rb_cmddata_msg = "1,0\r";
                        st_var.rb_cd_reply_format = 2;
                        tmROBOT.Enabled = true;
                        st_var.correct_step = 28600;
                    }
                    break;

                case 28600:

                    if (tmROBOT.Enabled == false)
                    {
                        st_var.z_pos_now = st_var.z_pos;

                        if ((Math.Abs(st_var.z_pos_now - st_var.z_pos_st) > Math.Abs(st_var.cor_move_z) * 0.98))
                        {
                            st_var.correct_step = 30000;

                            st_var.log_msg = st_var.log_msg + "Z_SCAN_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                        }
                        else
                        {
                            st_var.correct_step = 28400;
                        }
                    }
                    break;


                /*   
               case 29000:

                   if (st_var.crt4_cnt > st_var.crt4_wait * ((st_var.catch_points.Count - st_var.max_index) - 1))
                   {
                       st_var.correct_step = 30000;
                   }
                   else
                   {
                       st_var.crt4_cnt = st_var.crt4_cnt + 1;
                   }

                   if (st_var.correct_step != st_var.correct_step_temp)
                   {
                       st_var.log_msg = st_var.log_msg + "Z_SCAN_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
                   }
                   break;
                */

                case 30000:

                    txtX_POS.Text = "";
                    txtY_POS.Text = "";
                    txtZ_POS.Text = "";

                    st_var.rc_step = 1000;
                    st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RPOSC 4\r\n";
                    st_var.rb_cmd_reply_msg = "OK: RPOSC\r\n";
                    st_var.rb_has_cmd_data = true;
                    st_var.rb_cmddata_msg = "1,0\r";
                    st_var.rb_cd_reply_format = 2;
                    if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }

                    st_var.correct_step = 31000;
                    st_var.pos_cnt = 0;

                    break;

                case 31000:

                    if ((txtZ_POS.Text.Trim().Length > 0) && (txtX_POS.Text.Trim().Length > 0) && (txtY_POS.Text.Trim().Length > 0))
                    {
                        st_var.crnt_z_pos = double.Parse(txtZ_POS.Text);
                        st_var.crnt_x_pos = double.Parse(txtX_POS.Text);
                        st_var.crnt_y_pos = double.Parse(txtY_POS.Text);

                        // calculate difference
                        st_var.cort_x = st_var.robot_chk_pos_X - st_var.crnt_x_pos;
                        st_var.cort_y = st_var.robot_chk_pos_Y - st_var.crnt_y_pos;
                        st_var.cort_z = st_var.robot_chk_pos_Z - st_var.crnt_z_pos;

                        CORRECT_X.Text = st_var.cort_x.ToString("F2");
                        CORRECT_Y.Text = st_var.cort_y.ToString("F2");
                        CORRECT_Z.Text = st_var.cort_z.ToString("F2");

                        st_var.correct_step = 32000;
                    }
                    else
                    {
                        st_var.pos_cnt = st_var.pos_cnt + 1;

                        if (st_var.pos_cnt > st_var.pos_wait)
                        {
                            st_var.correct_step = 32000;
                        }
                    }

                    break;

                case 32000:

                    display_correct();

                    COR_END.Checked = true;
                    COR_END.BackgroundImage = Properties.Resources.led5_on;

                    CRT_START.Image = Properties.Resources.button4_up;
                    tmCORRECT.Enabled = false;

                    st_var.log_msg = st_var.log_msg + "CORRECT_END_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

                    break;


                default:
                    CORRECT.Image = Properties.Resources.button4_up;
                    tmCORRECT.Enabled = false;
                    break;


            }

            st_var.correct_step_temp = st_var.correct_step;
        }



        private void TOL_CONFIRM_Click(object sender, EventArgs e)
        {
            st_var.x_tol = double.Parse(txtXtol.Text);
            st_var.y_tol = double.Parse(txtYtol.Text);
            st_var.z_tol = double.Parse(txtZtol.Text);

            WritePrivateProfileString("TOLERANCE", "X_TOLERANCE", txtXtol.Text, "C:\\ROBOT_CORRECT\\config.ini");
            WritePrivateProfileString("TOLERANCE", "Y_TOLERANCE", txtYtol.Text, "C:\\ROBOT_CORRECT\\config.ini");
            WritePrivateProfileString("TOLERANCE", "Z_TOLERANCE", txtZtol.Text, "C:\\ROBOT_CORRECT\\config.ini");

        }



        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadExisting();
                Invoke(new Action(() =>
                {
                    txtSER_RES.Text = data;
                    st_var.io_status = io_parse(data.Trim());

                    IN1.Checked = st_var.io_status[0];
                    IN2.Checked = st_var.io_status[1];
                    IN3.Checked = st_var.io_status[2];
                    IN4.Checked = st_var.io_status[3];
                    IN5.Checked = st_var.io_status[4];
                    IN6.Checked = st_var.io_status[5];
                    IN7.Checked = st_var.io_status[6];
                    IN8.Checked = st_var.io_status[7];


                    if (IN1.Checked)
                    {
                        IN1.BackgroundImage = Properties.Resources.led6_on;
                    }
                    else
                    {
                        IN1.BackgroundImage = Properties.Resources.led6_off;
                    }

                    if (IN2.Checked)
                    {
                        IN2.BackgroundImage = Properties.Resources.led6_on;
                    }
                    else
                    {
                        IN2.BackgroundImage = Properties.Resources.led6_off;
                    }

                    if (IN3.Checked)
                    {
                        IN3.BackgroundImage = Properties.Resources.led6_on;
                    }
                    else
                    {
                        IN3.BackgroundImage = Properties.Resources.led6_off;
                    }

                    if (IN4.Checked)
                    {
                        IN4.BackgroundImage = Properties.Resources.led6_on;
                    }
                    else
                    {
                        IN4.BackgroundImage = Properties.Resources.led6_off;
                    }

                    if (IN5.Checked)
                    {
                        IN5.BackgroundImage = Properties.Resources.led6_on;
                    }
                    else
                    {
                        IN5.BackgroundImage = Properties.Resources.led6_off;
                    }

                    if (IN6.Checked)
                    {
                        IN6.BackgroundImage = Properties.Resources.led6_on;
                    }
                    else
                    {
                        IN6.BackgroundImage = Properties.Resources.led6_off;
                    }

                    if (IN7.Checked)
                    {
                        IN7.BackgroundImage = Properties.Resources.led6_on;
                    }
                    else
                    {
                        IN7.BackgroundImage = Properties.Resources.led6_off;
                    }

                    if (IN8.Checked)
                    {
                        IN8.BackgroundImage = Properties.Resources.led6_on;
                    }
                    else
                    {
                        IN8.BackgroundImage = Properties.Resources.led6_off;
                    }


                }));
            }
            catch { }
        }

        private bool[] io_parse(string response)
        {
            bool[] result = st_var.io_status;

            if (response.IndexOf('S') == 0)
            {
                result[0] = (response.Substring(1, 1) == "1");
                result[1] = (response.Substring(2, 1) == "1");
                result[2] = (response.Substring(3, 1) == "1");
                result[3] = (response.Substring(4, 1) == "1");
                result[4] = (response.Substring(5, 1) == "1");
                result[5] = (response.Substring(6, 1) == "1");
                result[6] = (response.Substring(7, 1) == "1");
                result[7] = (response.Substring(8, 1) == "1");

            }

            return result;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void WAIT_CONFIRM_Click(object sender, EventArgs e)
        {

            WritePrivateProfileString("WAIT", "ACT1", txtACT1WAIT.Text, "C:\\ROBOT_CORRECT\\config.ini");
            WritePrivateProfileString("WAIT", "ACT2", txtACT2WAIT.Text, "C:\\ROBOT_CORRECT\\config.ini");
            WritePrivateProfileString("WAIT", "ACT3", txtACT3WAIT.Text, "C:\\ROBOT_CORRECT\\config.ini");

            WritePrivateProfileString("WAIT", "CRT1", txtCOR1WAIT.Text, "C:\\ROBOT_CORRECT\\config.ini");
            WritePrivateProfileString("WAIT", "CRT2", txtCOR2WAIT.Text, "C:\\ROBOT_CORRECT\\config.ini");
            WritePrivateProfileString("WAIT", "CRT3", txtCOR3WAIT.Text, "C:\\ROBOT_CORRECT\\config.ini");
            WritePrivateProfileString("WAIT", "CRT4", txtCOR4WAIT.Text, "C:\\ROBOT_CORRECT\\config.ini");

            st_var.act1_wait = (int)(double.Parse(txtACT1WAIT.Text) * 20);
            st_var.act2_wait = (int)(double.Parse(txtACT2WAIT.Text) * 20);
            st_var.act3_wait = (int)(double.Parse(txtACT3WAIT.Text) * 20);

            st_var.crt1_wait = int.Parse(txtCOR1WAIT.Text);
            st_var.crt2_wait = int.Parse(txtCOR2WAIT.Text);
            st_var.crt3_wait = int.Parse(txtCOR3WAIT.Text);
            st_var.crt4_wait = int.Parse(txtCOR4WAIT.Text);

        }

        private void OUTR_CONFIRM_Click(object sender, EventArgs e)
        {
            WritePrivateProfileString("OUTOFRANGE", "X", txtXOUTR.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.x_outr = double.Parse(txtXOUTR.Text);

            WritePrivateProfileString("OUTOFRANGE", "Y", txtYOUTR.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.y_outr = double.Parse(txtYOUTR.Text);
        }

        private void CORSPD_CONFIRM_Click(object sender, EventArgs e)
        {
            WritePrivateProfileString("COR_SPD", "CRT1", txtCOR1SPD.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.cor1_spd = int.Parse(txtCOR1SPD.Text);

            WritePrivateProfileString("COR_SPD", "CRT2", txtCOR2SPD.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.cor2_spd = int.Parse(txtCOR2SPD.Text);

            WritePrivateProfileString("COR_SPD", "CRT3", txtCOR3SPD.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.cor3_spd = int.Parse(txtCOR3SPD.Text);

            WritePrivateProfileString("COR_SPD", "CRT4", txtCOR4SPD.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.cor4_spd = int.Parse(txtCOR4SPD.Text);
        }

        private void ZSCANCONFIRM_Click(object sender, EventArgs e)
        {
            if ((double.Parse(txtMin.Text) > st_var.robot_chk_pos_Z) || (double.Parse(txtMax.Text) < st_var.robot_chk_pos_Z))
            {
                txtMin.Text = st_var.robot_chk_pos_Z.ToString();
                txtMax.Text = st_var.robot_chk_pos_Z.ToString();

                return;
            }
            else
            {
                WritePrivateProfileString("Z_SCAN", "MIN", txtMin.Text, "C:\\ROBOT_CORRECT\\config.ini");
                st_var.z_scan_min = double.Parse(txtMin.Text);

                WritePrivateProfileString("Z_SCAN", "MAX", txtMax.Text, "C:\\ROBOT_CORRECT\\config.ini");
                st_var.z_scan_max = double.Parse(txtMax.Text);
            }
        }

        private void CRT_START_Click(object sender, EventArgs e)
        {
            if (!tmCORRECT.Enabled)
            {
                st_var.correct_step = 1000;
                tmCORRECT.Enabled = true;
            }
        }

        private void CORDCONFIRM_Click(object sender, EventArgs e)
        {
            WritePrivateProfileString("CHK_CORD", "XCORD", txtXCORD.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.robot_chk_pos_X = double.Parse(txtXCORD.Text);

            WritePrivateProfileString("CHK_CORD", "YCORD", txtYCORD.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.robot_chk_pos_Y = double.Parse(txtYCORD.Text);

            WritePrivateProfileString("CHK_CORD", "ZCORD", txtZCORD.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.robot_chk_pos_Z = double.Parse(txtZCORD.Text);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
           
           if (serialPort != null && serialPort.IsOpen)
           {
               serialPort.Close();
               MessageBox.Show("포트 연결 해제");
           }
           
        }

        private void DISPLAY_CONFIRM_Click(object sender, EventArgs e)
        {
            WritePrivateProfileString("DISPLAY", "CENTERX", txtCNTRX.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.center_x = int.Parse(txtCNTRX.Text);

            WritePrivateProfileString("DISPLAY", "CENTERY", txtCNTRY.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.center_y = int.Parse(txtCNTRY.Text);

            WritePrivateProfileString("DISPLAY", "FIT_R", txtFITR.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.fit_r = int.Parse(txtFITR.Text);

            WritePrivateProfileString("DISPLAY", "OUT_R", txtOUTR.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.out_r = int.Parse(txtOUTR.Text);

            display_normal();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FUNC_GRAB();
            FUNC_CATCH2(); 
            SCR_MANUAL.Image?.Dispose();
            SCR_MANUAL.Image = st_var.bitmap_catch;

            st_var.log_msg = st_var.log_msg + "CATCH2_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

            txtCPOSITION.Text = $"X:{st_var.catch_X_position:F3}, Y:{st_var.catch_Y_position:F3}";


        }

        private void SVON_MouseDown(object sender, MouseEventArgs e)
        {
            SVON.Image = Properties.Resources.button2_dn;
        }

        private void SVON_MouseUp(object sender, MouseEventArgs e)
        {
            SVON.Image = Properties.Resources.button2_up;
        }

        private void SVOFF_MouseDown(object sender, MouseEventArgs e)
        {
            SVOFF.Image = Properties.Resources.button3_dn;
        }

        private void SVOFF_MouseUp(object sender, MouseEventArgs e)
        {
            SVOFF.Image = Properties.Resources.button3_up;
        }

        private void MOV_X_POS_MouseUp(object sender, MouseEventArgs e)
        {
            MOV_X_POS.Image = Properties.Resources.button5_up;
        }

        private void MOV_X_POS_MouseDown(object sender, MouseEventArgs e)
        {
            MOV_X_POS.Image = Properties.Resources.button5_dn;
        }

        private void MOV_X_NEG_MouseDown(object sender, MouseEventArgs e)
        {
            MOV_X_NEG.Image = Properties.Resources.button5_dn;
        }

        private void MOV_X_NEG_MouseUp(object sender, MouseEventArgs e)
        {
            MOV_X_NEG.Image = Properties.Resources.button5_up;
        }

        private void MOV_Z_UP_MouseDown(object sender, MouseEventArgs e)
        {
            MOV_Z_UP.Image = Properties.Resources.button9_dn;
        }

        private void MOV_Z_UP_MouseUp(object sender, MouseEventArgs e)
        {
            MOV_Z_UP.Image = Properties.Resources.button9_up;
        }

        private void MOV_Z_DN_MouseDown(object sender, MouseEventArgs e)
        {
            MOV_Z_DN.Image = Properties.Resources.button9_dn;
        }

        private void MOV_Z_DN_MouseUp(object sender, MouseEventArgs e)
        {
            MOV_Z_DN.Image = Properties.Resources.button9_up;
        }

        private void MOV_Y_NEG_MouseUp(object sender, MouseEventArgs e)
        {
            MOV_Y_NEG.Image = Properties.Resources.button7_up;
        }

        private void MOV_Y_NEG_MouseDown(object sender, MouseEventArgs e)
        {
            MOV_Y_NEG.Image = Properties.Resources.button7_dn;
        }

        private void MOV_Y_POS_MouseDown(object sender, MouseEventArgs e)
        {
            MOV_Y_POS.Image = Properties.Resources.button7_dn;
        }

        private void MOV_Y_POS_MouseUp(object sender, MouseEventArgs e)
        {
            MOV_Y_POS.Image = Properties.Resources.button7_up;
        }

        private void X_ROT_POS_MouseDown(object sender, MouseEventArgs e)
        {
            X_ROT_POS.Image = Properties.Resources.button5_dn;
        }

        private void X_ROT_POS_MouseUp(object sender, MouseEventArgs e)
        {
            X_ROT_POS.Image = Properties.Resources.button5_up;
        }

        private void X_ROT_NEG_MouseDown(object sender, MouseEventArgs e)
        {
            X_ROT_NEG.Image = Properties.Resources.button5_dn;
        }

        private void X_ROT_NEG_MouseUp(object sender, MouseEventArgs e)
        {
            X_ROT_NEG.Image = Properties.Resources.button5_up;
        }

        private void Y_ROT_POS_MouseUp(object sender, MouseEventArgs e)
        {
            Y_ROT_POS.Image = Properties.Resources.button7_up;
        }

        private void Y_ROT_POS_MouseDown(object sender, MouseEventArgs e)
        {
            Y_ROT_POS.Image = Properties.Resources.button7_dn;
        }

        private void Y_ROT_NEG_MouseDown(object sender, MouseEventArgs e)
        {
            Y_ROT_NEG.Image = Properties.Resources.button7_dn;
        }

        private void Y_ROT_NEG_MouseUp(object sender, MouseEventArgs e)
        {
            Y_ROT_NEG.Image = Properties.Resources.button7_up;
        }

        private void Z_ROT_POS_MouseUp(object sender, MouseEventArgs e)
        {
            Z_ROT_POS.Image = Properties.Resources.button9_up;
        }

        private void Z_ROT_POS_MouseDown(object sender, MouseEventArgs e)
        {
            Z_ROT_POS.Image = Properties.Resources.button9_dn;
        }

        private void Z_ROT_NEG_MouseDown(object sender, MouseEventArgs e)
        {
            Z_ROT_NEG.Image = Properties.Resources.button9_dn;
        }

        private void Z_ROT_NEG_MouseUp(object sender, MouseEventArgs e)
        {
            Z_ROT_NEG.Image = Properties.Resources.button9_up;
        }

        private void JOB_START_MouseDown(object sender, MouseEventArgs e)
        {
            JOB_START.Image = Properties.Resources.button6_dn;
        }

        private void JOB_START_MouseUp(object sender, MouseEventArgs e)
        {
            JOB_START.Image = Properties.Resources.button6_up;
        }

        private void GETPOS_MouseUp(object sender, MouseEventArgs e)
        {
            GETPOS.Image = Properties.Resources.button10_up;
        }

        private void GETPOS_MouseDown(object sender, MouseEventArgs e)
        {
            GETPOS.Image = Properties.Resources.button10_dn;
        }

        private void CATCH_MouseDown(object sender, MouseEventArgs e)
        {
            CATCH.Image = Properties.Resources.button8_dn;
        }

        private void CATCH_MouseUp(object sender, MouseEventArgs e)
        {
            CATCH.Image = Properties.Resources.button8_up;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.button8_dn;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.button8_up;
        }

        private void GRAB_MouseDown(object sender, MouseEventArgs e)
        {
            GRAB.Image = Properties.Resources.button10_dn;
        }

        private void GRAB_MouseUp(object sender, MouseEventArgs e)
        {
            GRAB.Image = Properties.Resources.button10_up;
        }

        private void ROBOT_NET_CONFIRM_MouseDown(object sender, MouseEventArgs e)
        {
            ROBOT_NET_CONFIRM.Image = Properties.Resources.button11_dn;
        }

        private void ROBOT_NET_CONFIRM_MouseUp(object sender, MouseEventArgs e)
        {
            ROBOT_NET_CONFIRM.Image = Properties.Resources.button11_up;
        }

        private void CNT_CONFIRM_MouseDown(object sender, MouseEventArgs e)
        {
            CNT_CONFIRM.Image = Properties.Resources.button11_dn;
        }

        private void CNT_CONFIRM_MouseUp(object sender, MouseEventArgs e)
        {
            CNT_CONFIRM.Image = Properties.Resources.button11_up;
        }

        private void RPY_CONFIRM_MouseDown(object sender, MouseEventArgs e)
        {
            RPY_CONFIRM.Image = Properties.Resources.button11_dn;
        }

        private void RPY_CONFIRM_MouseUp(object sender, MouseEventArgs e)
        {
            RPY_CONFIRM.Image = Properties.Resources.button11_up;
        }

        private void SER_PORT_CONFIRM_MouseDown(object sender, MouseEventArgs e)
        {
            SER_PORT_CONFIRM.Image = Properties.Resources.button11_dn;
        }

        private void SER_PORT_CONFIRM_MouseUp(object sender, MouseEventArgs e)
        {
            SER_PORT_CONFIRM.Image = Properties.Resources.button11_up;
        }

        private void TOL_CONFIRM_MouseDown(object sender, MouseEventArgs e)
        {
            TOL_CONFIRM.Image = Properties.Resources.button11_dn;
        }

        private void TOL_CONFIRM_MouseUp(object sender, MouseEventArgs e)
        {
            TOL_CONFIRM.Image = Properties.Resources.button11_up;
        }

        private void OUTR_CONFIRM_MouseDown(object sender, MouseEventArgs e)
        {
            OUTR_CONFIRM.Image = Properties.Resources.button11_dn;
        }

        private void OUTR_CONFIRM_MouseUp(object sender, MouseEventArgs e)
        {
            OUTR_CONFIRM.Image = Properties.Resources.button11_up;
        }

        private void ZSCANCONFIRM_MouseDown(object sender, MouseEventArgs e)
        {
            ZSCANCONFIRM.Image = Properties.Resources.button11_dn;
        }

        private void ZSCANCONFIRM_MouseUp(object sender, MouseEventArgs e)
        {
            ZSCANCONFIRM.Image = Properties.Resources.button11_up;
        }

        private void WAIT_CONFIRM_MouseDown(object sender, MouseEventArgs e)
        {
            WAIT_CONFIRM.Image = Properties.Resources.button11_dn;
        }

        private void WAIT_CONFIRM_MouseUp(object sender, MouseEventArgs e)
        {
            WAIT_CONFIRM.Image = Properties.Resources.button11_up;
        }

        private void CORSPD_CONFIRM_MouseDown(object sender, MouseEventArgs e)
        {
            CORSPD_CONFIRM.Image = Properties.Resources.button11_dn;
        }

        private void CORSPD_CONFIRM_MouseUp(object sender, MouseEventArgs e)
        {
            CORSPD_CONFIRM.Image = Properties.Resources.button11_up;
        }

        private void CORDCONFIRM_MouseDown(object sender, MouseEventArgs e)
        {
            CORDCONFIRM.Image = Properties.Resources.button11_dn;
        }

        private void CORDCONFIRM_MouseUp(object sender, MouseEventArgs e)
        {
            CORDCONFIRM.Image = Properties.Resources.button11_up;
        }

        private void CMOPEN_MouseDown(object sender, MouseEventArgs e)
        {
            CMOPEN.Image = Properties.Resources.button12_dn;
        }

        private void CMOPEN_MouseUp(object sender, MouseEventArgs e)
        {
            CMOPEN.Image = Properties.Resources.button12_up;
        }

        private void btTEMPLATE_MouseDown(object sender, MouseEventArgs e)
        {
            btTEMPLATE.Image = Properties.Resources.button12_dn;
        }

        private void btTEMPLATE_MouseUp(object sender, MouseEventArgs e)
        {
            btTEMPLATE.Image = Properties.Resources.button12_up;
        }

        private void TCP_SEND_MouseDown(object sender, MouseEventArgs e)
        {
            TCP_SEND.Image = Properties.Resources.button10_dn;
        }

        private void TCP_SEND_MouseUp(object sender, MouseEventArgs e)
        {
            TCP_SEND.Image = Properties.Resources.button10_up;
        }

        private void SER_SEND_MouseDown(object sender, MouseEventArgs e)
        {
            SER_SEND.Image = Properties.Resources.button10_dn;
        }

        private void SER_SEND_MouseUp(object sender, MouseEventArgs e)
        {
            SER_SEND.Image = Properties.Resources.button10_up;
        }

        private void BRTCONFIRM_Click(object sender, EventArgs e)
        {
            WritePrivateProfileString("OUT_RANGE", "MAX", txtMAXBR.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.max_bright = int.Parse(txtMAXBR.Text);

            WritePrivateProfileString("OUT_RANGE", "MIN", txtMINBR.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.min_bright = int.Parse(txtMINBR.Text);
        }

        private void BRTCONFIRM_MouseDown(object sender, MouseEventArgs e)
        {
            BRTCONFIRM.Image = Properties.Resources.button11_dn;
        }

        private void BRTCONFIRM_MouseUp(object sender, MouseEventArgs e)
        {
            BRTCONFIRM.Image = Properties.Resources.button11_up;
        }

        private void DISPLAY_CONFIRM_MouseDown(object sender, MouseEventArgs e)
        {
            DISPLAY_CONFIRM.Image = Properties.Resources.button15_dn;
        }

        private void DISPLAY_CONFIRM_MouseUp(object sender, MouseEventArgs e)
        {
            DISPLAY_CONFIRM.Image = Properties.Resources.button15_up;
        }

        private void SER_SEND_Click(object sender, EventArgs e)
        {
            ser_send();

            st_var.log_msg = st_var.log_msg + "SER_SEND_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
        }

        private void make_send_text()
        {
            string serial_text = "0";

            txtSER_SND.Text = "S";

            for (int i = 0; i < 8; i++)
            {
                if (st_var.output_status[i])
                {
                    serial_text = "1";
                }
                else
                {
                    serial_text = "0";
                }

                txtSER_SND.Text = txtSER_SND.Text + serial_text;

            }

            txtSER_SND.Text = txtSER_SND.Text + "E";

        }
        private void ser_send()
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine(txtSER_SND.Text);
            }
            else
            {
                MessageBox.Show("Port in not open");
            }
        }

        private void OUT1_CheckedChanged(object sender, EventArgs e)
        {
            st_var.output_status[0] = OUT1.Checked;
            make_send_text();
            ser_send();

            if (OUT1.Checked)
            {
                OUT1.BackgroundImage = Properties.Resources.button16_dn;
            }
            else
            {
                OUT1.BackgroundImage = Properties.Resources.button16_up;
            }
        }

        private void OUT2_CheckedChanged(object sender, EventArgs e)
        {
            st_var.output_status[1] = OUT2.Checked;
            make_send_text();
            ser_send();

            if (OUT2.Checked)
            {
                OUT2.BackgroundImage = Properties.Resources.button16_dn;
            }
            else
            {
                OUT2.BackgroundImage = Properties.Resources.button16_up;
            }
        }

        private void OUT3_CheckedChanged(object sender, EventArgs e)
        {
            st_var.output_status[2] = OUT3.Checked;
            make_send_text();
            ser_send();

            if (OUT3.Checked)
            {
                OUT3.BackgroundImage = Properties.Resources.button16_dn;
            }
            else
            {
                OUT3.BackgroundImage = Properties.Resources.button16_up;
            }
        }

        private void OUT4_CheckedChanged(object sender, EventArgs e)
        {
            st_var.output_status[3] = OUT4.Checked;
            make_send_text();
            ser_send();

            if (OUT4.Checked)
            {
                OUT4.BackgroundImage = Properties.Resources.button16_dn;
            }
            else
            {
                OUT4.BackgroundImage = Properties.Resources.button16_up;
            }
        }

        private void OUT5_CheckedChanged(object sender, EventArgs e)
        {
            st_var.output_status[4] = OUT5.Checked;
            make_send_text();
            ser_send();

            if (OUT5.Checked)
            {
                OUT5.BackgroundImage = Properties.Resources.button16_dn;
            }
            else
            {
                OUT5.BackgroundImage = Properties.Resources.button16_up;
            }
        }

        private void OUT6_CheckedChanged(object sender, EventArgs e)
        {
            st_var.output_status[5] = OUT6.Checked;
            make_send_text();
            ser_send();

            if (OUT6.Checked)
            {
                OUT6.BackgroundImage = Properties.Resources.button16_dn;
            }
            else
            {
                OUT6.BackgroundImage = Properties.Resources.button16_up;
            }
        }

        private void OUT7_CheckedChanged(object sender, EventArgs e)
        {
            st_var.output_status[6] = OUT7.Checked;
            make_send_text();
            ser_send();

            if (OUT7.Checked)
            {
                OUT7.BackgroundImage = Properties.Resources.button16_dn;
            }
            else
            {
                OUT7.BackgroundImage = Properties.Resources.button16_up;
            }
        }

        private void OUT8_CheckedChanged(object sender, EventArgs e)
        {
            st_var.output_status[7] = OUT8.Checked;
            make_send_text();
            ser_send();

            if (OUT8.Checked)
            {
                OUT8.BackgroundImage = Properties.Resources.button16_dn;
            }
            else
            {
                OUT8.BackgroundImage = Properties.Resources.button16_up;
            }
        }

        private void STOP_MouseDown(object sender, MouseEventArgs e)
        {
            STOP.Image = Properties.Resources.button3_dn;
        }

        private void STOP_MouseUp(object sender, MouseEventArgs e)
        {
            STOP.Image = Properties.Resources.button3_up;
        }

        private void tmWORK_Tick(object sender, EventArgs e)
        {
            switch (st_var.work_step)
            {
                case 1000:

                    /*
                    
                    st_var.cort_x, st_var.cort_y, st_var.cort_z 에 따라서 모션수정;
                    
                     */
                    st_var.work_step = 0;
                    tmWORK.Enabled = false;
                    break;

            }

        }

        private void TCP_SEND_Click(object sender, EventArgs e)
        {
            com_send();

            st_var.log_msg = st_var.log_msg + "TCP_SEND_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

        }

        private void tmLOG_Tick(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText("C:\\LOG\\LOG_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt", st_var.log_msg);
                st_var.log_msg = "";
            }
            catch
            {

            }
        }

        private void GETVAR_Click(object sender, EventArgs e)
        {
            string var_cmd_data = tb_VARCMD.Text.Trim();
            int cmd_data_length = var_cmd_data.Length + 1;
            st_var.rc_step = 1000;
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST SAVEV " + cmd_data_length.ToString() + "\r\n";
            st_var.rb_cmd_reply_msg = "OK: SAVEV\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = var_cmd_data + "\r";
            st_var.rb_cd_reply_format = 5;
            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WritePrivateProfileString("PIXEL_RATIO", "XRATIO", txtXRATIO.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.diff_x = double.Parse(txtXRATIO.Text);

            WritePrivateProfileString("PIXEL_RATIO", "YRATIO", txtYRATIO.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.diff_y = double.Parse(txtYRATIO.Text);

        }

        private void OUTRCCONFIRM_Click(object sender, EventArgs e)
        {
            WritePrivateProfileString("OUT_OF_RANGE_CENTER", "X_POS", txtXPOS.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.hole_center_x = int.Parse(txtXPOS.Text);

            WritePrivateProfileString("OUT_OF_RANGE_CENTER", "Y_POS", txtYPOS.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.hole_center_y = int.Parse(txtYPOS.Text);
        }

        private void DIFFCONFIRM_Click(object sender, EventArgs e)
        {
            WritePrivateProfileString("CHECK_DIFFERENCE", "X_DIFF", txtXDIFF.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.robot_diff_x = double.Parse(txtXDIFF.Text);

            WritePrivateProfileString("CHECK_DIFFERENCE", "Y_DIFF", txtYDIFF.Text, "C:\\ROBOT_CORRECT\\config.ini");
            st_var.robot_diff_y = double.Parse(txtYDIFF.Text);
        }

        private void DIFFCONFIRM_MouseUp(object sender, MouseEventArgs e)
        {
            DIFFCONFIRM.Image = Properties.Resources.button11_up;
        }

        private void DIFFCONFIRM_MouseDown(object sender, MouseEventArgs e)
        {
            DIFFCONFIRM.Image = Properties.Resources.button11_dn;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.button11_up;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.button11_dn;
        }

        private void OUTRCCONFIRM_MouseUp(object sender, MouseEventArgs e)
        {
            OUTRCCONFIRM.Image = Properties.Resources.button11_up;
        }

        private void OUTRCCONFIRM_MouseDown(object sender, MouseEventArgs e)
        {
            OUTRCCONFIRM.Image = Properties.Resources.button11_dn;
        }

        private void btJOBLIST_Click(object sender, EventArgs e)
        {
            st_var.rc_step = 1000;
            st_var.rb_cmd_msg = "HOSTCTRL_REQUEST RJDIR\r\n";
            st_var.rb_cmd_reply_msg = "OK: RJDIR\r\n";
            st_var.rb_has_cmd_data = true;
            st_var.rb_cmddata_msg = "*\r";
            st_var.rb_cd_reply_format = 4;

            st_var.log_msg = st_var.log_msg + "JOB_START_MANUAL_" + DateTime.Now.ToString("HH:mm:ss") + "\r\n";

            if (!tmROBOT.Enabled) { tmROBOT.Enabled = true; }
        }
    }
}

