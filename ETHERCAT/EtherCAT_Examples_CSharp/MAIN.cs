using System;
using System.CodeDom;
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
    public partial class MAIN : Form
    {
        int netID = 5;
        int errorCode = 0;
       
        public MAIN()
        {
            InitializeComponent();
        }

        private void btSETUP_Click(object sender, EventArgs e)
        {
            new EtherCAT_Examples_CSharp.formMain().Show();
            
        }

        private void btINIT_Click(object sender, EventArgs e)
        {
            new formInitialize().Show();
        }

        private void btON_Click(object sender, EventArgs e)
        {
            int slaveAddr = Convert.ToInt16(tbSLAVEID.Text);
            int doLocalCh = Convert.ToInt16(tbChannel.Text);
            ec.ecdoPutOne_L(netID, (ushort)slaveAddr, doLocalCh, true, ref errorCode);
            if (errorCode != 0) 
            { 
                tbERROR.Text = errorCode.ToString() +"\r\n";
             }
        }

        private void btOFF_Click(object sender, EventArgs e)
        {
            
            int slaveAddr = Convert.ToInt16(tbSLAVEID.Text);
            int doLocalCh = Convert.ToInt16(tbChannel.Text);
            ec.ecdoPutOne_L(netID, (ushort)slaveAddr, doLocalCh, false, ref errorCode);
            if (errorCode != 0) 
            {
                tbERROR.Text = errorCode.ToString() + "\r\n";
            }
        }

        private void btCHECK_Click(object sender, EventArgs e)
        {
            int slaveAddr = Convert.ToInt16(tbCSLAVEID.Text);
            uint diVal = ec.ecdiGetMulti_L(netID, (ushort)slaveAddr, 0, 32, ref errorCode);

            string binary = "";

            for (int i = 0; i < 32; i++)
            {
             binary = binary + ((diVal >> i) & 1).ToString();
                
            }

            tbDIVAL.Text = binary;
            if (errorCode != 0) 
            {
                tbERROR.Text = errorCode.ToString() + "\r\n";
            }
        }

        private void btOCHK_Click(object sender, EventArgs e)
        {
            int slaveAddr = Convert.ToInt16(tbCSLAVEID.Text);
            uint diVal = ec.ecdoGetMulti_L(netID, (ushort)slaveAddr, 0, 32, ref errorCode);

            string binary = "";

            for (int i = 0; i < 32; i++)
            {
                binary = binary + ((diVal >> i) & 1).ToString();

            }

            tbDIVAL.Text = binary;
            if (errorCode != 0)
            {
                tbERROR.Text = errorCode.ToString() + "\r\n";
            }
        }
    }
}
