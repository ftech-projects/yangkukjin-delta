namespace EtherCAT_Examples_CSharp
{
    partial class MAIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSETUP = new System.Windows.Forms.Button();
            this.btINIT = new System.Windows.Forms.Button();
            this.btON = new System.Windows.Forms.Button();
            this.btOFF = new System.Windows.Forms.Button();
            this.tbSLAVEID = new System.Windows.Forms.TextBox();
            this.tbChannel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCHECK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCSLAVEID = new System.Windows.Forms.TextBox();
            this.tbDIVAL = new System.Windows.Forms.TextBox();
            this.btOCHK = new System.Windows.Forms.Button();
            this.tbERROR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSETUP
            // 
            this.btSETUP.Location = new System.Drawing.Point(338, 256);
            this.btSETUP.Name = "btSETUP";
            this.btSETUP.Size = new System.Drawing.Size(75, 23);
            this.btSETUP.TabIndex = 0;
            this.btSETUP.Text = "SETUP";
            this.btSETUP.UseVisualStyleBackColor = true;
            this.btSETUP.Click += new System.EventHandler(this.btSETUP_Click);
            // 
            // btINIT
            // 
            this.btINIT.Location = new System.Drawing.Point(3, 12);
            this.btINIT.Name = "btINIT";
            this.btINIT.Size = new System.Drawing.Size(84, 23);
            this.btINIT.TabIndex = 1;
            this.btINIT.Text = "INIT";
            this.btINIT.UseVisualStyleBackColor = true;
            this.btINIT.Click += new System.EventHandler(this.btINIT_Click);
            // 
            // btON
            // 
            this.btON.Location = new System.Drawing.Point(3, 41);
            this.btON.Name = "btON";
            this.btON.Size = new System.Drawing.Size(84, 23);
            this.btON.TabIndex = 2;
            this.btON.Text = "ON";
            this.btON.UseVisualStyleBackColor = true;
            this.btON.Click += new System.EventHandler(this.btON_Click);
            // 
            // btOFF
            // 
            this.btOFF.Location = new System.Drawing.Point(93, 41);
            this.btOFF.Name = "btOFF";
            this.btOFF.Size = new System.Drawing.Size(77, 23);
            this.btOFF.TabIndex = 3;
            this.btOFF.Text = "OFF";
            this.btOFF.UseVisualStyleBackColor = true;
            this.btOFF.Click += new System.EventHandler(this.btOFF_Click);
            // 
            // tbSLAVEID
            // 
            this.tbSLAVEID.Location = new System.Drawing.Point(210, 40);
            this.tbSLAVEID.Name = "tbSLAVEID";
            this.tbSLAVEID.Size = new System.Drawing.Size(64, 21);
            this.tbSLAVEID.TabIndex = 4;
            // 
            // tbChannel
            // 
            this.tbChannel.Location = new System.Drawing.Point(349, 43);
            this.tbChannel.Name = "tbChannel";
            this.tbChannel.Size = new System.Drawing.Size(64, 21);
            this.tbChannel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "CHANNEL";
            // 
            // btCHECK
            // 
            this.btCHECK.Location = new System.Drawing.Point(3, 84);
            this.btCHECK.Name = "btCHECK";
            this.btCHECK.Size = new System.Drawing.Size(86, 23);
            this.btCHECK.TabIndex = 8;
            this.btCHECK.Text = "IN CHECK";
            this.btCHECK.UseVisualStyleBackColor = true;
            this.btCHECK.Click += new System.EventHandler(this.btCHECK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID";
            // 
            // tbCSLAVEID
            // 
            this.tbCSLAVEID.Location = new System.Drawing.Point(115, 103);
            this.tbCSLAVEID.Name = "tbCSLAVEID";
            this.tbCSLAVEID.Size = new System.Drawing.Size(55, 21);
            this.tbCSLAVEID.TabIndex = 9;
            // 
            // tbDIVAL
            // 
            this.tbDIVAL.Location = new System.Drawing.Point(176, 103);
            this.tbDIVAL.Name = "tbDIVAL";
            this.tbDIVAL.Size = new System.Drawing.Size(237, 21);
            this.tbDIVAL.TabIndex = 12;
            // 
            // btOCHK
            // 
            this.btOCHK.Location = new System.Drawing.Point(3, 113);
            this.btOCHK.Name = "btOCHK";
            this.btOCHK.Size = new System.Drawing.Size(86, 23);
            this.btOCHK.TabIndex = 13;
            this.btOCHK.Text = "OUT CHECK";
            this.btOCHK.UseVisualStyleBackColor = true;
            this.btOCHK.Click += new System.EventHandler(this.btOCHK_Click);
            // 
            // tbERROR
            // 
            this.tbERROR.Location = new System.Drawing.Point(12, 167);
            this.tbERROR.Multiline = true;
            this.tbERROR.Name = "tbERROR";
            this.tbERROR.Size = new System.Drawing.Size(401, 83);
            this.tbERROR.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "ERROR LOG";
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 280);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbERROR);
            this.Controls.Add(this.btOCHK);
            this.Controls.Add(this.tbDIVAL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCSLAVEID);
            this.Controls.Add(this.btCHECK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbChannel);
            this.Controls.Add(this.tbSLAVEID);
            this.Controls.Add(this.btOFF);
            this.Controls.Add(this.btON);
            this.Controls.Add(this.btINIT);
            this.Controls.Add(this.btSETUP);
            this.Name = "MAIN";
            this.Text = "MAIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSETUP;
        private System.Windows.Forms.Button btINIT;
        private System.Windows.Forms.Button btON;
        private System.Windows.Forms.Button btOFF;
        private System.Windows.Forms.TextBox tbSLAVEID;
        private System.Windows.Forms.TextBox tbChannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCHECK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCSLAVEID;
        private System.Windows.Forms.TextBox tbDIVAL;
        private System.Windows.Forms.Button btOCHK;
        private System.Windows.Forms.TextBox tbERROR;
        private System.Windows.Forms.Label label3;
    }
}