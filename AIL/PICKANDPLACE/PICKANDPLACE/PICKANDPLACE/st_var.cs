using System;
using System.Collections.Generic;
using System.Text;

namespace PICKANDPLACE
{
    static public class st_var
    {
        static public int rc_step = 0;

        static public bool robot_connected = false;

        static public string rb_send_msg = "";

        static public string rb_connect_msg = "CONNECT Robot_access\r\n";

        static public string rb_response_msg = "";

        static public int com_check = 0;

        static public bool robot_com = false;

        static public string rb_reply_msg = "OK: YR Information Server( 1.00).\r\n";

        static public int com_check_limit = 0;

        static public string rb_cmd_msg = "";

        static public string rb_cmd_reply_msg = "";

        static public bool rb_has_cmd_data = false;

        static public string rb_cmddata_msg = "";

        static public int rb_cd_reply_format = 0;

        static public string rb_network = "192.168.255.200";

        static public double x_pos = 0;

        static public double y_pos = 0;

        static public double z_pos = 0;

        static public double xr_pos = 0;

        static public double yr_pos = 0;

        static public double zr_pos = 0;

        static public string move_cmd = "";

        static public string JOBNAME = "";

    }
}
