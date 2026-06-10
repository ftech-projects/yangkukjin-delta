namespace PICKANDPLACE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ROBOT_COM = new System.Windows.Forms.Timer(components);
            txtTCP_RES = new TextBox();
            txtTCP_SND = new TextBox();
            txtX_POS = new TextBox();
            txtY_POS = new TextBox();
            txtZ_POS = new TextBox();
            txtZ_ROT = new TextBox();
            txtY_ROT = new TextBox();
            txtX_ROT = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            btSVON = new Button();
            btSVOFF = new Button();
            SPEED = new TextBox();
            DISTANCE = new TextBox();
            label10 = new Label();
            label11 = new Label();
            btXPLUS = new Button();
            btXMINUS = new Button();
            btZPLUS = new Button();
            btZMINUS = new Button();
            btYPLUS = new Button();
            btYMINUS = new Button();
            btPOSITION = new Button();
            btSEARCH = new Button();
            btGET = new Button();
            btPLACE = new Button();
            panel1 = new Panel();
            txtHeight = new TextBox();
            label7 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            SuspendLayout();
            // 
            // ROBOT_COM
            // 
            ROBOT_COM.Tick += ROBOT_COM_Tick;
            // 
            // txtTCP_RES
            // 
            txtTCP_RES.Location = new Point(649, 36);
            txtTCP_RES.Name = "txtTCP_RES";
            txtTCP_RES.Size = new Size(139, 23);
            txtTCP_RES.TabIndex = 0;
            // 
            // txtTCP_SND
            // 
            txtTCP_SND.Location = new Point(649, 7);
            txtTCP_SND.Name = "txtTCP_SND";
            txtTCP_SND.Size = new Size(139, 23);
            txtTCP_SND.TabIndex = 1;
            // 
            // txtX_POS
            // 
            txtX_POS.Location = new Point(666, 278);
            txtX_POS.Name = "txtX_POS";
            txtX_POS.Size = new Size(100, 23);
            txtX_POS.TabIndex = 3;
            // 
            // txtY_POS
            // 
            txtY_POS.Location = new Point(666, 307);
            txtY_POS.Name = "txtY_POS";
            txtY_POS.Size = new Size(100, 23);
            txtY_POS.TabIndex = 4;
            // 
            // txtZ_POS
            // 
            txtZ_POS.Location = new Point(666, 336);
            txtZ_POS.Name = "txtZ_POS";
            txtZ_POS.Size = new Size(100, 23);
            txtZ_POS.TabIndex = 5;
            // 
            // txtZ_ROT
            // 
            txtZ_ROT.Location = new Point(666, 423);
            txtZ_ROT.Name = "txtZ_ROT";
            txtZ_ROT.Size = new Size(100, 23);
            txtZ_ROT.TabIndex = 8;
            // 
            // txtY_ROT
            // 
            txtY_ROT.Location = new Point(666, 394);
            txtY_ROT.Name = "txtY_ROT";
            txtY_ROT.Size = new Size(100, 23);
            txtY_ROT.TabIndex = 7;
            // 
            // txtX_ROT
            // 
            txtX_ROT.Location = new Point(666, 365);
            txtX_ROT.Name = "txtX_ROT";
            txtX_ROT.Size = new Size(100, 23);
            txtX_ROT.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(581, 285);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 9;
            label1.Text = "X POSITION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(581, 313);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 10;
            label2.Text = "Y POSITION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(581, 341);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 11;
            label3.Text = "Z POSITION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(581, 369);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 12;
            label4.Text = "X ROTATION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(581, 397);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 13;
            label5.Text = "Y ROTATION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(581, 425);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 14;
            label6.Text = "Z ROTATION";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(572, 10);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 16;
            label8.Text = "SEND";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(572, 39);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 17;
            label9.Text = "RESPONSE";
            // 
            // btSVON
            // 
            btSVON.Location = new Point(575, 65);
            btSVON.Name = "btSVON";
            btSVON.Size = new Size(75, 23);
            btSVON.TabIndex = 18;
            btSVON.Text = "SVON";
            btSVON.UseVisualStyleBackColor = true;
            btSVON.Click += btSVON_Click;
            // 
            // btSVOFF
            // 
            btSVOFF.Location = new Point(656, 65);
            btSVOFF.Name = "btSVOFF";
            btSVOFF.Size = new Size(75, 23);
            btSVOFF.TabIndex = 19;
            btSVOFF.Text = "SVOFF";
            btSVOFF.UseVisualStyleBackColor = true;
            btSVOFF.Click += btSVOFF_Click;
            // 
            // SPEED
            // 
            SPEED.Location = new Point(596, 104);
            SPEED.Name = "SPEED";
            SPEED.Size = new Size(75, 23);
            SPEED.TabIndex = 20;
            // 
            // DISTANCE
            // 
            DISTANCE.Location = new Point(724, 104);
            DISTANCE.Name = "DISTANCE";
            DISTANCE.Size = new Size(75, 23);
            DISTANCE.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(580, 107);
            label10.Name = "label10";
            label10.Size = new Size(14, 15);
            label10.TabIndex = 22;
            label10.Text = "S";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(706, 109);
            label11.Name = "label11";
            label11.Size = new Size(16, 15);
            label11.TabIndex = 23;
            label11.Text = "D";
            // 
            // btXPLUS
            // 
            btXPLUS.Location = new Point(649, 134);
            btXPLUS.Name = "btXPLUS";
            btXPLUS.Size = new Size(75, 23);
            btXPLUS.TabIndex = 24;
            btXPLUS.Text = "XPLUS";
            btXPLUS.UseVisualStyleBackColor = true;
            btXPLUS.Click += btXPLUS_Click;
            // 
            // btXMINUS
            // 
            btXMINUS.Location = new Point(649, 221);
            btXMINUS.Name = "btXMINUS";
            btXMINUS.Size = new Size(75, 23);
            btXMINUS.TabIndex = 25;
            btXMINUS.Text = "X MINUS";
            btXMINUS.UseVisualStyleBackColor = true;
            btXMINUS.Click += btXMINUS_Click;
            // 
            // btZPLUS
            // 
            btZPLUS.Location = new Point(649, 163);
            btZPLUS.Name = "btZPLUS";
            btZPLUS.Size = new Size(75, 23);
            btZPLUS.TabIndex = 26;
            btZPLUS.Text = "ZPLUS";
            btZPLUS.UseVisualStyleBackColor = true;
            btZPLUS.Click += btZPLUS_Click;
            // 
            // btZMINUS
            // 
            btZMINUS.Location = new Point(649, 192);
            btZMINUS.Name = "btZMINUS";
            btZMINUS.Size = new Size(75, 23);
            btZMINUS.TabIndex = 27;
            btZMINUS.Text = "ZMINUS";
            btZMINUS.UseVisualStyleBackColor = true;
            btZMINUS.Click += btZMINUS_Click;
            // 
            // btYPLUS
            // 
            btYPLUS.Location = new Point(724, 176);
            btYPLUS.Name = "btYPLUS";
            btYPLUS.Size = new Size(75, 23);
            btYPLUS.TabIndex = 28;
            btYPLUS.Text = "YPLUS";
            btYPLUS.UseVisualStyleBackColor = true;
            btYPLUS.Click += btYPLUS_Click;
            // 
            // btYMINUS
            // 
            btYMINUS.Location = new Point(572, 176);
            btYMINUS.Name = "btYMINUS";
            btYMINUS.Size = new Size(75, 23);
            btYMINUS.TabIndex = 29;
            btYMINUS.Text = "YMINUS";
            btYMINUS.UseVisualStyleBackColor = true;
            btYMINUS.Click += btYMINUS_Click;
            // 
            // btPOSITION
            // 
            btPOSITION.Location = new Point(575, 254);
            btPOSITION.Name = "btPOSITION";
            btPOSITION.Size = new Size(75, 23);
            btPOSITION.TabIndex = 30;
            btPOSITION.Text = "POSITION";
            btPOSITION.UseVisualStyleBackColor = true;
            btPOSITION.Click += btPOSITION_Click;
            // 
            // btSEARCH
            // 
            btSEARCH.Location = new Point(12, 10);
            btSEARCH.Name = "btSEARCH";
            btSEARCH.Size = new Size(75, 23);
            btSEARCH.TabIndex = 31;
            btSEARCH.Text = "SEARCH";
            btSEARCH.UseVisualStyleBackColor = true;
            btSEARCH.Click += btSEARCH_Click;
            // 
            // btGET
            // 
            btGET.Location = new Point(87, 10);
            btGET.Name = "btGET";
            btGET.Size = new Size(75, 23);
            btGET.TabIndex = 32;
            btGET.Text = "GET";
            btGET.UseVisualStyleBackColor = true;
            btGET.Click += btGET_Click;
            // 
            // btPLACE
            // 
            btPLACE.Location = new Point(168, 10);
            btPLACE.Name = "btPLACE";
            btPLACE.Size = new Size(75, 23);
            btPLACE.TabIndex = 33;
            btPLACE.Text = "PLACE";
            btPLACE.UseVisualStyleBackColor = true;
            btPLACE.Click += btPLACE_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 399);
            panel1.TabIndex = 34;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(469, 12);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(76, 23);
            txtHeight.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(415, 14);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 36;
            label7.Text = "HEIGHT";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 441);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 37;
            label12.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(133, 441);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 38;
            label13.Text = "label13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(258, 441);
            label14.Name = "label14";
            label14.Size = new Size(46, 15);
            label14.TabIndex = 39;
            label14.Text = "label14";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(410, 441);
            label15.Name = "label15";
            label15.Size = new Size(46, 15);
            label15.TabIndex = 40;
            label15.Text = "label15";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 462);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(txtHeight);
            Controls.Add(panel1);
            Controls.Add(btPLACE);
            Controls.Add(btGET);
            Controls.Add(btSEARCH);
            Controls.Add(btPOSITION);
            Controls.Add(btYMINUS);
            Controls.Add(btYPLUS);
            Controls.Add(btZMINUS);
            Controls.Add(btZPLUS);
            Controls.Add(btXMINUS);
            Controls.Add(btXPLUS);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(DISTANCE);
            Controls.Add(SPEED);
            Controls.Add(btSVOFF);
            Controls.Add(btSVON);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtZ_ROT);
            Controls.Add(txtY_ROT);
            Controls.Add(txtX_ROT);
            Controls.Add(txtZ_POS);
            Controls.Add(txtY_POS);
            Controls.Add(txtX_POS);
            Controls.Add(txtTCP_SND);
            Controls.Add(txtTCP_RES);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer ROBOT_COM;
        private TextBox txtTCP_RES;
        private TextBox txtTCP_SND;
        private TextBox txtX_POS;
        private TextBox txtY_POS;
        private TextBox txtZ_POS;
        private TextBox txtZ_ROT;
        private TextBox txtY_ROT;
        private TextBox txtX_ROT;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Button btSVON;
        private Button btSVOFF;
        private TextBox SPEED;
        private TextBox DISTANCE;
        private Label label10;
        private Label label11;
        private Button btXPLUS;
        private Button btXMINUS;
        private Button btZPLUS;
        private Button btZMINUS;
        private Button btYPLUS;
        private Button btYMINUS;
        private Button btPOSITION;
        private Button btSEARCH;
        private Button btGET;
        private Button btPLACE;
        private Panel panel1;
        private TextBox txtHeight;
        private Label label7;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}
