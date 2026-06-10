namespace EtherCAT_Examples_CSharp
{
    partial class formIxArc
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
            this.lblAxisX = new System.Windows.Forms.Label();
            this.cbxAxisX = new System.Windows.Forms.ComboBox();
            this.tbxP0_X = new System.Windows.Forms.TextBox();
            this.lblP0_X = new System.Windows.Forms.Label();
            this.btnMoveStart = new System.Windows.Forms.Button();
            this.btnMoveToStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSpeedType = new System.Windows.Forms.ComboBox();
            this.lblSpeedMode = new System.Windows.Forms.Label();
            this.cbxSpeedMode = new System.Windows.Forms.ComboBox();
            this.tbxInit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxWork = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxAccel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDecel = new System.Windows.Forms.TextBox();
            this.tbxJerk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxAxisY = new System.Windows.Forms.ComboBox();
            this.lblAxisY = new System.Windows.Forms.Label();
            this.rdoArcMode1 = new System.Windows.Forms.RadioButton();
            this.rdoArcMode2 = new System.Windows.Forms.RadioButton();
            this.rdoArcMode0 = new System.Windows.Forms.RadioButton();
            this.lblP0_Y = new System.Windows.Forms.Label();
            this.tbxP0_Y = new System.Windows.Forms.TextBox();
            this.lblP1_X = new System.Windows.Forms.Label();
            this.tbxP1_X = new System.Windows.Forms.TextBox();
            this.lblP1_Y = new System.Windows.Forms.Label();
            this.tbxP1_Y = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.tbxAngle = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.cbxDir = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAxisX
            // 
            this.lblAxisX.AutoSize = true;
            this.lblAxisX.Location = new System.Drawing.Point(38, 19);
            this.lblAxisX.Name = "lblAxisX";
            this.lblAxisX.Size = new System.Drawing.Size(42, 12);
            this.lblAxisX.TabIndex = 20;
            this.lblAxisX.Text = "Axis X";
            // 
            // cbxAxisX
            // 
            this.cbxAxisX.FormattingEnabled = true;
            this.cbxAxisX.Location = new System.Drawing.Point(133, 16);
            this.cbxAxisX.Name = "cbxAxisX";
            this.cbxAxisX.Size = new System.Drawing.Size(121, 20);
            this.cbxAxisX.TabIndex = 19;
            // 
            // tbxP0_X
            // 
            this.tbxP0_X.Location = new System.Drawing.Point(462, 103);
            this.tbxP0_X.Name = "tbxP0_X";
            this.tbxP0_X.Size = new System.Drawing.Size(66, 21);
            this.tbxP0_X.TabIndex = 21;
            this.tbxP0_X.Text = "10000";
            // 
            // lblP0_X
            // 
            this.lblP0_X.AutoSize = true;
            this.lblP0_X.Location = new System.Drawing.Point(313, 106);
            this.lblP0_X.Name = "lblP0_X";
            this.lblP0_X.Size = new System.Drawing.Size(47, 12);
            this.lblP0_X.TabIndex = 20;
            this.lblP0_X.Text = "Pos0_X";
            // 
            // btnMoveStart
            // 
            this.btnMoveStart.Location = new System.Drawing.Point(311, 258);
            this.btnMoveStart.Name = "btnMoveStart";
            this.btnMoveStart.Size = new System.Drawing.Size(66, 48);
            this.btnMoveStart.TabIndex = 22;
            this.btnMoveStart.Text = "Move\r\nStart";
            this.btnMoveStart.UseVisualStyleBackColor = true;
            this.btnMoveStart.Click += new System.EventHandler(this.btnMoveStart_Click);
            // 
            // btnMoveToStart
            // 
            this.btnMoveToStart.Location = new System.Drawing.Point(388, 258);
            this.btnMoveToStart.Name = "btnMoveToStart";
            this.btnMoveToStart.Size = new System.Drawing.Size(66, 48);
            this.btnMoveToStart.TabIndex = 22;
            this.btnMoveToStart.Text = "MoveTo\r\nStart";
            this.btnMoveToStart.UseVisualStyleBackColor = true;
            this.btnMoveToStart.Click += new System.EventHandler(this.btnMoveToStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(462, 258);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(66, 48);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "IxSpeedType";
            // 
            // cbxSpeedType
            // 
            this.cbxSpeedType.FormattingEnabled = true;
            this.cbxSpeedType.Items.AddRange(new object[] {
            "Master",
            "Vector"});
            this.cbxSpeedType.Location = new System.Drawing.Point(133, 104);
            this.cbxSpeedType.Name = "cbxSpeedType";
            this.cbxSpeedType.Size = new System.Drawing.Size(121, 20);
            this.cbxSpeedType.TabIndex = 25;
            // 
            // lblSpeedMode
            // 
            this.lblSpeedMode.AutoSize = true;
            this.lblSpeedMode.Location = new System.Drawing.Point(38, 133);
            this.lblSpeedMode.Name = "lblSpeedMode";
            this.lblSpeedMode.Size = new System.Drawing.Size(73, 12);
            this.lblSpeedMode.TabIndex = 24;
            this.lblSpeedMode.Text = "SpeedMode";
            // 
            // cbxSpeedMode
            // 
            this.cbxSpeedMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxSpeedMode.FormattingEnabled = true;
            this.cbxSpeedMode.Items.AddRange(new object[] {
            "Constant",
            "Trapzoidal",
            "S-Curve"});
            this.cbxSpeedMode.Location = new System.Drawing.Point(133, 129);
            this.cbxSpeedMode.Name = "cbxSpeedMode";
            this.cbxSpeedMode.Size = new System.Drawing.Size(121, 20);
            this.cbxSpeedMode.TabIndex = 26;
            // 
            // tbxInit
            // 
            this.tbxInit.Location = new System.Drawing.Point(133, 154);
            this.tbxInit.Name = "tbxInit";
            this.tbxInit.Size = new System.Drawing.Size(121, 21);
            this.tbxInit.TabIndex = 27;
            this.tbxInit.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "InitSpeed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "EndSpeed";
            // 
            // tbxEnd
            // 
            this.tbxEnd.Location = new System.Drawing.Point(133, 180);
            this.tbxEnd.Name = "tbxEnd";
            this.tbxEnd.Size = new System.Drawing.Size(121, 21);
            this.tbxEnd.TabIndex = 27;
            this.tbxEnd.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "WorkSpeed";
            // 
            // tbxWork
            // 
            this.tbxWork.Location = new System.Drawing.Point(133, 206);
            this.tbxWork.Name = "tbxWork";
            this.tbxWork.Size = new System.Drawing.Size(121, 21);
            this.tbxWork.TabIndex = 27;
            this.tbxWork.Text = "100000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "Accel";
            // 
            // tbxAccel
            // 
            this.tbxAccel.Location = new System.Drawing.Point(133, 232);
            this.tbxAccel.Name = "tbxAccel";
            this.tbxAccel.Size = new System.Drawing.Size(121, 21);
            this.tbxAccel.TabIndex = 27;
            this.tbxAccel.Text = "1000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "Decel";
            // 
            // tbxDecel
            // 
            this.tbxDecel.Location = new System.Drawing.Point(133, 258);
            this.tbxDecel.Name = "tbxDecel";
            this.tbxDecel.Size = new System.Drawing.Size(121, 21);
            this.tbxDecel.TabIndex = 27;
            this.tbxDecel.Text = "1000000";
            // 
            // tbxJerk
            // 
            this.tbxJerk.Location = new System.Drawing.Point(133, 285);
            this.tbxJerk.Name = "tbxJerk";
            this.tbxJerk.Size = new System.Drawing.Size(121, 21);
            this.tbxJerk.TabIndex = 27;
            this.tbxJerk.Text = "0.66";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "Jerk";
            // 
            // cbxAxisY
            // 
            this.cbxAxisY.FormattingEnabled = true;
            this.cbxAxisY.Location = new System.Drawing.Point(133, 42);
            this.cbxAxisY.Name = "cbxAxisY";
            this.cbxAxisY.Size = new System.Drawing.Size(121, 20);
            this.cbxAxisY.TabIndex = 19;
            // 
            // lblAxisY
            // 
            this.lblAxisY.AutoSize = true;
            this.lblAxisY.Location = new System.Drawing.Point(38, 45);
            this.lblAxisY.Name = "lblAxisY";
            this.lblAxisY.Size = new System.Drawing.Size(42, 12);
            this.lblAxisY.TabIndex = 20;
            this.lblAxisY.Text = "Axis Y";
            // 
            // rdoArcMode1
            // 
            this.rdoArcMode1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoArcMode1.AutoSize = true;
            this.rdoArcMode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoArcMode1.Font = new System.Drawing.Font("Arial", 9F);
            this.rdoArcMode1.ForeColor = System.Drawing.Color.Black;
            this.rdoArcMode1.Location = new System.Drawing.Point(349, 41);
            this.rdoArcMode1.Name = "rdoArcMode1";
            this.rdoArcMode1.Size = new System.Drawing.Size(102, 19);
            this.rdoArcMode1.TabIndex = 29;
            this.rdoArcMode1.TabStop = true;
            this.rdoArcMode1.Tag = "1";
            this.rdoArcMode1.Text = "CenterP EndP";
            this.rdoArcMode1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoArcMode1.UseVisualStyleBackColor = true;
            // 
            // rdoArcMode2
            // 
            this.rdoArcMode2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoArcMode2.AutoSize = true;
            this.rdoArcMode2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoArcMode2.Font = new System.Drawing.Font("Arial", 9F);
            this.rdoArcMode2.ForeColor = System.Drawing.Color.Black;
            this.rdoArcMode2.Location = new System.Drawing.Point(349, 66);
            this.rdoArcMode2.Name = "rdoArcMode2";
            this.rdoArcMode2.Size = new System.Drawing.Size(39, 19);
            this.rdoArcMode2.TabIndex = 30;
            this.rdoArcMode2.TabStop = true;
            this.rdoArcMode2.Tag = "2";
            this.rdoArcMode2.Text = "3P";
            this.rdoArcMode2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoArcMode2.UseVisualStyleBackColor = true;
            // 
            // rdoArcMode0
            // 
            this.rdoArcMode0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoArcMode0.AutoSize = true;
            this.rdoArcMode0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoArcMode0.Font = new System.Drawing.Font("Arial", 9F);
            this.rdoArcMode0.ForeColor = System.Drawing.Color.Black;
            this.rdoArcMode0.Location = new System.Drawing.Point(349, 17);
            this.rdoArcMode0.Name = "rdoArcMode0";
            this.rdoArcMode0.Size = new System.Drawing.Size(105, 19);
            this.rdoArcMode0.TabIndex = 28;
            this.rdoArcMode0.TabStop = true;
            this.rdoArcMode0.Tag = "0";
            this.rdoArcMode0.Text = "CenterP  Angle";
            this.rdoArcMode0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoArcMode0.UseVisualStyleBackColor = true;
            // 
            // lblP0_Y
            // 
            this.lblP0_Y.AutoSize = true;
            this.lblP0_Y.Location = new System.Drawing.Point(313, 131);
            this.lblP0_Y.Name = "lblP0_Y";
            this.lblP0_Y.Size = new System.Drawing.Size(47, 12);
            this.lblP0_Y.TabIndex = 20;
            this.lblP0_Y.Text = "Pos0_Y";
            // 
            // tbxP0_Y
            // 
            this.tbxP0_Y.Location = new System.Drawing.Point(462, 128);
            this.tbxP0_Y.Name = "tbxP0_Y";
            this.tbxP0_Y.Size = new System.Drawing.Size(66, 21);
            this.tbxP0_Y.TabIndex = 21;
            this.tbxP0_Y.Text = "10000";
            // 
            // lblP1_X
            // 
            this.lblP1_X.AutoSize = true;
            this.lblP1_X.Location = new System.Drawing.Point(313, 157);
            this.lblP1_X.Name = "lblP1_X";
            this.lblP1_X.Size = new System.Drawing.Size(47, 12);
            this.lblP1_X.TabIndex = 20;
            this.lblP1_X.Text = "Pos1_X";
            // 
            // tbxP1_X
            // 
            this.tbxP1_X.Location = new System.Drawing.Point(462, 154);
            this.tbxP1_X.Name = "tbxP1_X";
            this.tbxP1_X.Size = new System.Drawing.Size(66, 21);
            this.tbxP1_X.TabIndex = 21;
            this.tbxP1_X.Text = "20000";
            // 
            // lblP1_Y
            // 
            this.lblP1_Y.AutoSize = true;
            this.lblP1_Y.Location = new System.Drawing.Point(313, 183);
            this.lblP1_Y.Name = "lblP1_Y";
            this.lblP1_Y.Size = new System.Drawing.Size(47, 12);
            this.lblP1_Y.TabIndex = 20;
            this.lblP1_Y.Text = "Pos1_Y";
            // 
            // tbxP1_Y
            // 
            this.tbxP1_Y.Location = new System.Drawing.Point(462, 180);
            this.tbxP1_Y.Name = "tbxP1_Y";
            this.tbxP1_Y.Size = new System.Drawing.Size(66, 21);
            this.tbxP1_Y.TabIndex = 21;
            this.tbxP1_Y.Text = "20000";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(313, 209);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(37, 12);
            this.lblAngle.TabIndex = 20;
            this.lblAngle.Text = "Angle";
            // 
            // tbxAngle
            // 
            this.tbxAngle.Location = new System.Drawing.Point(462, 206);
            this.tbxAngle.Name = "tbxAngle";
            this.tbxAngle.Size = new System.Drawing.Size(66, 21);
            this.tbxAngle.TabIndex = 21;
            this.tbxAngle.Text = "90";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(313, 235);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(54, 12);
            this.lblDir.TabIndex = 20;
            this.lblDir.Text = "Direction";
            // 
            // cbxDir
            // 
            this.cbxDir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxDir.FormattingEnabled = true;
            this.cbxDir.Items.AddRange(new object[] {
            "-",
            "+"});
            this.cbxDir.Location = new System.Drawing.Point(462, 232);
            this.cbxDir.Name = "cbxDir";
            this.cbxDir.Size = new System.Drawing.Size(66, 20);
            this.cbxDir.TabIndex = 26;
            // 
            // FormIxArc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 336);
            this.Controls.Add(this.rdoArcMode1);
            this.Controls.Add(this.rdoArcMode2);
            this.Controls.Add(this.rdoArcMode0);
            this.Controls.Add(this.tbxJerk);
            this.Controls.Add(this.tbxDecel);
            this.Controls.Add(this.tbxAccel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxWork);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxInit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxDir);
            this.Controls.Add(this.cbxSpeedMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSpeedMode);
            this.Controls.Add(this.cbxSpeedType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnMoveToStart);
            this.Controls.Add(this.btnMoveStart);
            this.Controls.Add(this.tbxAngle);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.tbxP1_Y);
            this.Controls.Add(this.lblP1_Y);
            this.Controls.Add(this.tbxP1_X);
            this.Controls.Add(this.lblP1_X);
            this.Controls.Add(this.tbxP0_Y);
            this.Controls.Add(this.lblP0_Y);
            this.Controls.Add(this.tbxP0_X);
            this.Controls.Add(this.lblP0_X);
            this.Controls.Add(this.lblAxisY);
            this.Controls.Add(this.lblAxisX);
            this.Controls.Add(this.cbxAxisY);
            this.Controls.Add(this.cbxAxisX);
            this.Name = "FormIxArc";
            this.Text = "IxArc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxisX;
        private System.Windows.Forms.ComboBox cbxAxisX;
        private System.Windows.Forms.TextBox tbxP0_X;
        private System.Windows.Forms.Label lblP0_X;
        private System.Windows.Forms.Button btnMoveStart;
        private System.Windows.Forms.Button btnMoveToStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSpeedType;
        private System.Windows.Forms.Label lblSpeedMode;
        private System.Windows.Forms.ComboBox cbxSpeedMode;
        private System.Windows.Forms.TextBox tbxInit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxWork;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxAccel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxDecel;
        private System.Windows.Forms.TextBox tbxJerk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxAxisY;
        private System.Windows.Forms.Label lblAxisY;
        internal System.Windows.Forms.RadioButton rdoArcMode1;
        internal System.Windows.Forms.RadioButton rdoArcMode2;
        internal System.Windows.Forms.RadioButton rdoArcMode0;
        private System.Windows.Forms.Label lblP0_Y;
        private System.Windows.Forms.TextBox tbxP0_Y;
        private System.Windows.Forms.Label lblP1_X;
        private System.Windows.Forms.TextBox tbxP1_X;
        private System.Windows.Forms.Label lblP1_Y;
        private System.Windows.Forms.TextBox tbxP1_Y;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.TextBox tbxAngle;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.ComboBox cbxDir;
    }
}