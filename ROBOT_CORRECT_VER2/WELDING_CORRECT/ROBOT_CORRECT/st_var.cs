using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;


namespace ROBOT_CORRECT
{
    static public class st_var
    {
        static public string rb_network = "";
        
        static public string rb_connect_msg = "";
        static public string rb_reply_msg = "";
        
        static public string rb_cmd_msg = "";
        static public string rb_cmd_reply_msg = "";

        static public bool rb_has_cmd_data = false;
        static public string rb_cmddata_msg = "";
      
        static public int rb_cd_reply_format = 0; // 1: SVON 2: POSITION 3: MOVE 4: JOB

        static public string log_msg = "";      

        static public string rb_send_msg = "";
        static public string rb_response_msg = "";
      
        static public string ser_com = "";
        static public bool[] io_status = { false, false, false, false, false, false, false, false };
        static public bool[] output_status = {false, false, false, false, false, false, false, false};

        static public int rc_step = 0;

        static public bool robot_connected = false;
        static public bool robot_com = false;

        static public int com_check = 0;
        static public int com_check_limit = 2;

        static public string move_cmd = "";

        static public double x_pos = 0;
        static public double y_pos = 0;
        static public double z_pos = 0;
        static public double xr_pos = 0;
        static public double yr_pos = 0;
        static public double zr_pos = 0;

        static public double x_pos_st = 0;
        static public double y_pos_st = 0;
        static public double z_pos_st = 0;

        static public double x_pos_now = 0;
        static public double y_pos_now = 0;
        static public double z_pos_now = 0;

        static public string template_file = "";

        static public int auto_step = 0;
        static public int auto_step_temp = 0;

        static public int correct_step = 0;
        static public int correct_step_temp = 0;

        static public int work_step = 0;
        
        static public double robot_chk_pos_X = 459.573;
        static public double robot_chk_pos_Y = -950.082;
        static public double robot_chk_pos_Z = -5.091;

        static public double robot_diff_x = 0;
        static public double robot_diff_y = 0;

        static public double diff_x = -15.054;
        static public double diff_y = 10.18;

        static public double robot_cnv_rate_X = -0.0363;
        static public double robot_cnv_rate_Y = 0.0344;

        static public double rate_diff_x = 1.265;
        static public double rate_diff_y = 1;

        static public double vision_chk_Y = 675;
        static public double vision_chk_X = 907;

        static public Bitmap bitmap_grab;
        static public Bitmap bitmap_catch;

        static public double catch_X_position = 0;
        static public double catch_Y_position = 0;
        static public double catch_point = 0;
        static public List<double> catch_points = new List<double>();
        static public double catch_max_value = 0;
        static public int max_index = 0;

        static public double x_tol = 0;
        static public double y_tol = 0;
        static public double z_tol = 0; 

        static public double x_outr = 0;
        static public double y_outr = 0;
        
        static public double act1_wait = 0;
        static public double act2_wait = 0;
        static public double act3_wait = 0;

        static public double crt1_wait = 0;
        static public double crt2_wait = 0;
        static public double crt3_wait = 0;
        static public double crt4_wait = 0;

        static public int act1_cnt = 0;
        static public int act2_cnt = 0;
        static public int act3_cnt = 0;

        static public int crt1_cnt = 0;
        static public int crt2_cnt = 0;
        static public int crt3_cnt = 0;
        static public int crt4_cnt = 0;

        static public double cor_move_x = 0;
        static public double cor_move_y = 0;
        static public double cor_move_z = 0;

        static public int cor_move_x_cnt = 0;
        static public int cor_move_y_cnt = 0;

        static public int cor1_spd = 0;
        static public int cor2_spd = 0;
        static public int cor3_spd = 0;
        static public int cor4_spd = 0;

        static public double z_scan_min = 0;
        static public double z_scan_real_min = 0;
        static public double z_scan_max = 0;
        static public double z_scan_real_max = 0;
        static public int z_scan_up_value = 0;
        static public int z_scan_up_cnt = 0;

        static public double crnt_z_pos = 0;
        static public double crnt_y_pos = 0;
        static public double crnt_x_pos = 0;

        static public double cort_x = 0;
        static public double cort_y = 0;    
        static public double cort_z = 0;

        static public int pos_cnt = 0;
        static public int pos_wait = 100;

        static public int center_x = 0;
        static public int center_y = 0;

        static public int fit_r = 0;
        static public int out_r = 0;

        static public int hole_center_x = 1230;
        static public int hole_center_y = 950;
        static public int hole_radius = 900;

        static public int max_bright = 0;
        static public int min_bright = 0;



    }
}
