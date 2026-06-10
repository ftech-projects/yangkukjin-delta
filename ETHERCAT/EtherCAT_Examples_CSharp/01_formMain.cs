using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ec = ComiLib.EtherCAT.SafeNativeMethods;

namespace EtherCAT_Examples_CSharp
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }
        
       
        private void btnInit_Click(object sender, EventArgs e)
        {
            new formInitialize().Show();
        }

        private void btnSxMot_Click(object sender, EventArgs e)
        {
            new formSxMove().Show();
        }

        private void btnSxMot_RPM_Click(object sender, EventArgs e)
        {

        }

        private void btnSxSt_Click(object sender, EventArgs e)
        {
            new formSxStatus().Show();
        }

        private void btnRingCounter_Click(object sender, EventArgs e)
        {
            new formRingCounter().Show();
        }

        private void btnRingCounter_Abs_Click(object sender, EventArgs e)
        {
            new formRingCounter_Absolute().Show();
        }

        private void btnSyncAxis_Click(object sender, EventArgs e)
        {
            new formSyncAxis().Show();
        }

        private void btnPosCorr_Click(object sender, EventArgs e)
        {
            new formCorr1D().Show();
        }
        
        private void btnExtStop_Click(object sender, EventArgs e)
        {
            new formExtStop().Show();
        }

        private void btnSD_Click(object sender, EventArgs e)
        {
            new formSD().Show();
        }

        private void btnTorque_Click(object sender, EventArgs e)
        {
            new formTorque().Show();
        }

        private void btnmAutoTorque_Click(object sender, EventArgs e)
        {
            new formAutoTorque().Show();
        }

        private void btnMultiTorque_Click(object sender, EventArgs e)
        {
            new formMultiTorque().Show();
        }

        private void btnMxMot_Click(object sender, EventArgs e)
        {
            new formMxMot().Show();
        }

        private void btnIxLine_Click(object sender, EventArgs e)
        {
            new formIxLine().Show();
        }

        private void btnIxArc_Click(object sender, EventArgs e)
        {
            new formIxArc().Show();
        }

        private void btnIxSpline_Click(object sender, EventArgs e)
        {
            new formSpline().Show();
        }

        private void btnMpr2xLin_Click(object sender, EventArgs e)
        {
            new formIxMpr2x().Show();
        }

        private void btnIxVia_Click(object sender, EventArgs e)
        {
            new formIxVia().Show();
        }

        private void btnHoming_Click(object sender, EventArgs e)
        {
            new formHoming().Show();
        }

        private void btnMasterSlave_Click(object sender, EventArgs e)
        {
            new formMasterSlave().Show();
        }

        private void btnListMotion_Click(object sender, EventArgs e)
        {
            new formListMotion().Show();
        }

        private void btnPtMotion_Click(object sender, EventArgs e)
        {
            new formPtMotion().Show();
        }

        private void btnSoftEmg_Click(object sender, EventArgs e)
        {
            new formSEmg().Show();
        }

        private void btnHardEmg_Click(object sender, EventArgs e)
        {
            new formHEmg().Show();
        }

        private void btnCollisionAvoidance_Click(object sender, EventArgs e)
        {
            new formColla().Show();
        }

        private void btnZVIS_Click(object sender, EventArgs e)
        {
            new FormZVIS().Show();
        }

        private void btnCmpOne_Click(object sender, EventArgs e)
        {
            new formCmpOne().Show();
        }

        private void btnCmpCont_Click(object sender, EventArgs e)
        {
            new formCmpCont().Show();
        }

        private void btnOverride_Click(object sender, EventArgs e)
        {
            new formOverride().Show();
        }

        private void btnTouchProbe_Click(object sender, EventArgs e)
        {
            new formTouchProbe().Show();
        }

        private void btnSetSpeedAdv_Click(object sender, EventArgs e)
        {

        }

        private void btnPMonitor_Click(object sender, EventArgs e)
        {

        }

        private void btnSlaveIF_Click(object sender, EventArgs e)
        {
            new formCoeSdo().Show();
        }

        private void btnDio_Click(object sender, EventArgs e)
        {
            new formDio().Show();
        }

        private void btnAio_Click(object sender, EventArgs e)
        {
            new formAio().Show();
        }

        private void btnMC02P_Click(object sender, EventArgs e)
        {
            new formMC02P().Show();
        }

        private void btnGCode_Click(object sender, EventArgs e)
        {
            new formGCode().Show();
        }

        private void btnPdoToStruct_Click(object sender, EventArgs e)
        {
            new formPdoToStruct().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CookBook_Initialize().SystemInit();
        }

        int t = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label16.Text = t++.ToString();
        }
    }
}
