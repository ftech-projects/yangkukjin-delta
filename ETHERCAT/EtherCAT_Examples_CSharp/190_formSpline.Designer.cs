namespace EtherCAT_Examples_CSharp
{
    partial class formSpline
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
            this.cbxAxisY = new System.Windows.Forms.ComboBox();
            this.lblAxisY = new System.Windows.Forms.Label();
            this.rtbPos = new System.Windows.Forms.RichTextBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.gbxSpeed = new System.Windows.Forms.GroupBox();
            this.tbxJerk = new System.Windows.Forms.TextBox();
            this.tbxDecel = new System.Windows.Forms.TextBox();
            this.tbxAccel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxWork = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxInit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSpeedMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSpeedMode = new System.Windows.Forms.Label();
            this.cbxSpeedType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxJerkSmoothing = new System.Windows.Forms.GroupBox();
            this.cbxJerkType = new System.Windows.Forms.ComboBox();
            this.lblJsType = new System.Windows.Forms.Label();
            this.tbxDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.tbxThreshHold_Y = new System.Windows.Forms.TextBox();
            this.tbxThreshHold_X = new System.Windows.Forms.TextBox();
            this.lblThreshHole_Y = new System.Windows.Forms.Label();
            this.tbxLowVelRatio = new System.Windows.Forms.TextBox();
            this.lblThreshHole_X = new System.Windows.Forms.Label();
            this.lblLowVelRatio = new System.Windows.Forms.Label();
            this.tbxDecelTime = new System.Windows.Forms.TextBox();
            this.lblDecelTime = new System.Windows.Forms.Label();
            this.gbxAxis = new System.Windows.Forms.GroupBox();
            this.cbxSplineIndex = new System.Windows.Forms.ComboBox();
            this.lblSplineIndex = new System.Windows.Forms.Label();
            this.gbxControl = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnJsSetup = new System.Windows.Forms.Button();
            this.gbxSpeed.SuspendLayout();
            this.gbxJerkSmoothing.SuspendLayout();
            this.gbxAxis.SuspendLayout();
            this.gbxControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAxisX
            // 
            this.lblAxisX.AutoSize = true;
            this.lblAxisX.Location = new System.Drawing.Point(34, 64);
            this.lblAxisX.Name = "lblAxisX";
            this.lblAxisX.Size = new System.Drawing.Size(42, 12);
            this.lblAxisX.TabIndex = 20;
            this.lblAxisX.Text = "Axis X";
            // 
            // cbxAxisX
            // 
            this.cbxAxisX.FormattingEnabled = true;
            this.cbxAxisX.Location = new System.Drawing.Point(122, 61);
            this.cbxAxisX.Name = "cbxAxisX";
            this.cbxAxisX.Size = new System.Drawing.Size(98, 20);
            this.cbxAxisX.TabIndex = 19;
            // 
            // cbxAxisY
            // 
            this.cbxAxisY.FormattingEnabled = true;
            this.cbxAxisY.Location = new System.Drawing.Point(122, 87);
            this.cbxAxisY.Name = "cbxAxisY";
            this.cbxAxisY.Size = new System.Drawing.Size(98, 20);
            this.cbxAxisY.TabIndex = 19;
            // 
            // lblAxisY
            // 
            this.lblAxisY.AutoSize = true;
            this.lblAxisY.Location = new System.Drawing.Point(34, 95);
            this.lblAxisY.Name = "lblAxisY";
            this.lblAxisY.Size = new System.Drawing.Size(42, 12);
            this.lblAxisY.TabIndex = 20;
            this.lblAxisY.Text = "Axis Y";
            // 
            // rtbPos
            // 
            this.rtbPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbPos.Location = new System.Drawing.Point(36, 142);
            this.rtbPos.Name = "rtbPos";
            this.rtbPos.Size = new System.Drawing.Size(184, 140);
            this.rtbPos.TabIndex = 21;
            this.rtbPos.Text = "0,0\n10000,20000\n20000,0\n30000,40000\n40000,0\n50000,60000\n60000,0";
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(28, 28);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(100, 80);
            this.btnBuild.TabIndex = 22;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // gbxSpeed
            // 
            this.gbxSpeed.Controls.Add(this.tbxJerk);
            this.gbxSpeed.Controls.Add(this.tbxDecel);
            this.gbxSpeed.Controls.Add(this.tbxAccel);
            this.gbxSpeed.Controls.Add(this.label8);
            this.gbxSpeed.Controls.Add(this.label7);
            this.gbxSpeed.Controls.Add(this.tbxWork);
            this.gbxSpeed.Controls.Add(this.label6);
            this.gbxSpeed.Controls.Add(this.tbxEnd);
            this.gbxSpeed.Controls.Add(this.label5);
            this.gbxSpeed.Controls.Add(this.tbxInit);
            this.gbxSpeed.Controls.Add(this.label4);
            this.gbxSpeed.Controls.Add(this.cbxSpeedMode);
            this.gbxSpeed.Controls.Add(this.label3);
            this.gbxSpeed.Controls.Add(this.lblSpeedMode);
            this.gbxSpeed.Controls.Add(this.cbxSpeedType);
            this.gbxSpeed.Controls.Add(this.label2);
            this.gbxSpeed.Location = new System.Drawing.Point(302, 28);
            this.gbxSpeed.Name = "gbxSpeed";
            this.gbxSpeed.Size = new System.Drawing.Size(263, 302);
            this.gbxSpeed.TabIndex = 25;
            this.gbxSpeed.TabStop = false;
            this.gbxSpeed.Text = "Speed Setup";
            // 
            // tbxJerk
            // 
            this.tbxJerk.Location = new System.Drawing.Point(126, 234);
            this.tbxJerk.Name = "tbxJerk";
            this.tbxJerk.Size = new System.Drawing.Size(121, 21);
            this.tbxJerk.TabIndex = 38;
            this.tbxJerk.Text = "0.66";
            // 
            // tbxDecel
            // 
            this.tbxDecel.Location = new System.Drawing.Point(126, 207);
            this.tbxDecel.Name = "tbxDecel";
            this.tbxDecel.Size = new System.Drawing.Size(121, 21);
            this.tbxDecel.TabIndex = 39;
            this.tbxDecel.Text = "1000000";
            // 
            // tbxAccel
            // 
            this.tbxAccel.Location = new System.Drawing.Point(126, 181);
            this.tbxAccel.Name = "tbxAccel";
            this.tbxAccel.Size = new System.Drawing.Size(121, 21);
            this.tbxAccel.TabIndex = 40;
            this.tbxAccel.Text = "1000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "Jerk";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "Decel";
            // 
            // tbxWork
            // 
            this.tbxWork.Location = new System.Drawing.Point(126, 155);
            this.tbxWork.Name = "tbxWork";
            this.tbxWork.Size = new System.Drawing.Size(121, 21);
            this.tbxWork.TabIndex = 41;
            this.tbxWork.Text = "100000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "Accel";
            // 
            // tbxEnd
            // 
            this.tbxEnd.Location = new System.Drawing.Point(126, 129);
            this.tbxEnd.Name = "tbxEnd";
            this.tbxEnd.Size = new System.Drawing.Size(121, 21);
            this.tbxEnd.TabIndex = 42;
            this.tbxEnd.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "WorkSpeed";
            // 
            // tbxInit
            // 
            this.tbxInit.Location = new System.Drawing.Point(126, 103);
            this.tbxInit.Name = "tbxInit";
            this.tbxInit.Size = new System.Drawing.Size(121, 21);
            this.tbxInit.TabIndex = 43;
            this.tbxInit.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 32;
            this.label4.Text = "EndSpeed";
            // 
            // cbxSpeedMode
            // 
            this.cbxSpeedMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxSpeedMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxSpeedMode.FormattingEnabled = true;
            this.cbxSpeedMode.Items.AddRange(new object[] {
            "Constant",
            "Trapzoidal",
            "S-Curve"});
            this.cbxSpeedMode.Location = new System.Drawing.Point(126, 78);
            this.cbxSpeedMode.Name = "cbxSpeedMode";
            this.cbxSpeedMode.Size = new System.Drawing.Size(121, 20);
            this.cbxSpeedMode.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "InitSpeed";
            // 
            // lblSpeedMode
            // 
            this.lblSpeedMode.AutoSize = true;
            this.lblSpeedMode.Location = new System.Drawing.Point(31, 82);
            this.lblSpeedMode.Name = "lblSpeedMode";
            this.lblSpeedMode.Size = new System.Drawing.Size(73, 12);
            this.lblSpeedMode.TabIndex = 34;
            this.lblSpeedMode.Text = "SpeedMode";
            // 
            // cbxSpeedType
            // 
            this.cbxSpeedType.FormattingEnabled = true;
            this.cbxSpeedType.Items.AddRange(new object[] {
            "Master",
            "Vector"});
            this.cbxSpeedType.Location = new System.Drawing.Point(126, 53);
            this.cbxSpeedType.Name = "cbxSpeedType";
            this.cbxSpeedType.Size = new System.Drawing.Size(121, 20);
            this.cbxSpeedType.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "IxSpeedType";
            // 
            // gbxJerkSmoothing
            // 
            this.gbxJerkSmoothing.Controls.Add(this.cbxJerkType);
            this.gbxJerkSmoothing.Controls.Add(this.lblJsType);
            this.gbxJerkSmoothing.Controls.Add(this.tbxDuration);
            this.gbxJerkSmoothing.Controls.Add(this.lblDuration);
            this.gbxJerkSmoothing.Controls.Add(this.tbxThreshHold_Y);
            this.gbxJerkSmoothing.Controls.Add(this.tbxThreshHold_X);
            this.gbxJerkSmoothing.Controls.Add(this.lblThreshHole_Y);
            this.gbxJerkSmoothing.Controls.Add(this.tbxLowVelRatio);
            this.gbxJerkSmoothing.Controls.Add(this.lblThreshHole_X);
            this.gbxJerkSmoothing.Controls.Add(this.lblLowVelRatio);
            this.gbxJerkSmoothing.Controls.Add(this.tbxDecelTime);
            this.gbxJerkSmoothing.Controls.Add(this.lblDecelTime);
            this.gbxJerkSmoothing.Location = new System.Drawing.Point(27, 357);
            this.gbxJerkSmoothing.Name = "gbxJerkSmoothing";
            this.gbxJerkSmoothing.Size = new System.Drawing.Size(251, 214);
            this.gbxJerkSmoothing.TabIndex = 26;
            this.gbxJerkSmoothing.TabStop = false;
            this.gbxJerkSmoothing.Text = "Jerk Smoothing";
            // 
            // cbxJerkType
            // 
            this.cbxJerkType.FormattingEnabled = true;
            this.cbxJerkType.Items.AddRange(new object[] {
            "Disable",
            "JerkThreshHold"});
            this.cbxJerkType.Location = new System.Drawing.Point(122, 34);
            this.cbxJerkType.Name = "cbxJerkType";
            this.cbxJerkType.Size = new System.Drawing.Size(104, 20);
            this.cbxJerkType.TabIndex = 36;
            // 
            // lblJsType
            // 
            this.lblJsType.AutoSize = true;
            this.lblJsType.Location = new System.Drawing.Point(25, 37);
            this.lblJsType.Name = "lblJsType";
            this.lblJsType.Size = new System.Drawing.Size(34, 12);
            this.lblJsType.TabIndex = 35;
            this.lblJsType.Text = "Type";
            // 
            // tbxDuration
            // 
            this.tbxDuration.Location = new System.Drawing.Point(122, 114);
            this.tbxDuration.Name = "tbxDuration";
            this.tbxDuration.Size = new System.Drawing.Size(104, 21);
            this.tbxDuration.TabIndex = 40;
            this.tbxDuration.Text = "1000";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(25, 117);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(51, 12);
            this.lblDuration.TabIndex = 30;
            this.lblDuration.Text = "Duration";
            // 
            // tbxThreshHold_Y
            // 
            this.tbxThreshHold_Y.Location = new System.Drawing.Point(122, 168);
            this.tbxThreshHold_Y.Name = "tbxThreshHold_Y";
            this.tbxThreshHold_Y.Size = new System.Drawing.Size(104, 21);
            this.tbxThreshHold_Y.TabIndex = 40;
            this.tbxThreshHold_Y.Text = "1000000";
            // 
            // tbxThreshHold_X
            // 
            this.tbxThreshHold_X.Location = new System.Drawing.Point(122, 141);
            this.tbxThreshHold_X.Name = "tbxThreshHold_X";
            this.tbxThreshHold_X.Size = new System.Drawing.Size(104, 21);
            this.tbxThreshHold_X.TabIndex = 40;
            this.tbxThreshHold_X.Text = "1000000";
            // 
            // lblThreshHole_Y
            // 
            this.lblThreshHole_Y.AutoSize = true;
            this.lblThreshHole_Y.Location = new System.Drawing.Point(25, 171);
            this.lblThreshHole_Y.Name = "lblThreshHole_Y";
            this.lblThreshHole_Y.Size = new System.Drawing.Size(84, 12);
            this.lblThreshHole_Y.TabIndex = 30;
            this.lblThreshHole_Y.Text = "ThreshHold_Y";
            // 
            // tbxLowVelRatio
            // 
            this.tbxLowVelRatio.Location = new System.Drawing.Point(122, 87);
            this.tbxLowVelRatio.Name = "tbxLowVelRatio";
            this.tbxLowVelRatio.Size = new System.Drawing.Size(104, 21);
            this.tbxLowVelRatio.TabIndex = 40;
            this.tbxLowVelRatio.Text = "0.4";
            // 
            // lblThreshHole_X
            // 
            this.lblThreshHole_X.AutoSize = true;
            this.lblThreshHole_X.Location = new System.Drawing.Point(25, 144);
            this.lblThreshHole_X.Name = "lblThreshHole_X";
            this.lblThreshHole_X.Size = new System.Drawing.Size(84, 12);
            this.lblThreshHole_X.TabIndex = 30;
            this.lblThreshHole_X.Text = "ThreshHold_X";
            // 
            // lblLowVelRatio
            // 
            this.lblLowVelRatio.AutoSize = true;
            this.lblLowVelRatio.Location = new System.Drawing.Point(25, 90);
            this.lblLowVelRatio.Name = "lblLowVelRatio";
            this.lblLowVelRatio.Size = new System.Drawing.Size(79, 12);
            this.lblLowVelRatio.TabIndex = 30;
            this.lblLowVelRatio.Text = "LowVel Ratio";
            // 
            // tbxDecelTime
            // 
            this.tbxDecelTime.Location = new System.Drawing.Point(122, 60);
            this.tbxDecelTime.Name = "tbxDecelTime";
            this.tbxDecelTime.Size = new System.Drawing.Size(104, 21);
            this.tbxDecelTime.TabIndex = 40;
            this.tbxDecelTime.Text = "50";
            // 
            // lblDecelTime
            // 
            this.lblDecelTime.AutoSize = true;
            this.lblDecelTime.Location = new System.Drawing.Point(25, 63);
            this.lblDecelTime.Name = "lblDecelTime";
            this.lblDecelTime.Size = new System.Drawing.Size(70, 12);
            this.lblDecelTime.TabIndex = 30;
            this.lblDecelTime.Text = "Decel Time";
            // 
            // gbxAxis
            // 
            this.gbxAxis.Controls.Add(this.lblAxisX);
            this.gbxAxis.Controls.Add(this.cbxSplineIndex);
            this.gbxAxis.Controls.Add(this.cbxAxisX);
            this.gbxAxis.Controls.Add(this.cbxAxisY);
            this.gbxAxis.Controls.Add(this.lblAxisY);
            this.gbxAxis.Controls.Add(this.rtbPos);
            this.gbxAxis.Controls.Add(this.lblSplineIndex);
            this.gbxAxis.Location = new System.Drawing.Point(27, 28);
            this.gbxAxis.Name = "gbxAxis";
            this.gbxAxis.Size = new System.Drawing.Size(251, 302);
            this.gbxAxis.TabIndex = 27;
            this.gbxAxis.TabStop = false;
            this.gbxAxis.Text = "Axis & Position";
            // 
            // cbxSplineIndex
            // 
            this.cbxSplineIndex.FormattingEnabled = true;
            this.cbxSplineIndex.Location = new System.Drawing.Point(122, 34);
            this.cbxSplineIndex.Name = "cbxSplineIndex";
            this.cbxSplineIndex.Size = new System.Drawing.Size(98, 20);
            this.cbxSplineIndex.TabIndex = 19;
            this.cbxSplineIndex.SelectedIndexChanged += new System.EventHandler(this.cbxSplineIndex_SelectedIndexChanged);
            // 
            // lblSplineIndex
            // 
            this.lblSplineIndex.AutoSize = true;
            this.lblSplineIndex.Location = new System.Drawing.Point(34, 37);
            this.lblSplineIndex.Name = "lblSplineIndex";
            this.lblSplineIndex.Size = new System.Drawing.Size(75, 12);
            this.lblSplineIndex.TabIndex = 30;
            this.lblSplineIndex.Text = "Spline Index";
            // 
            // gbxControl
            // 
            this.gbxControl.Controls.Add(this.btnStop);
            this.gbxControl.Controls.Add(this.btnStart);
            this.gbxControl.Controls.Add(this.btnJsSetup);
            this.gbxControl.Controls.Add(this.btnBuild);
            this.gbxControl.Location = new System.Drawing.Point(302, 357);
            this.gbxControl.Name = "gbxControl";
            this.gbxControl.Size = new System.Drawing.Size(263, 214);
            this.gbxControl.TabIndex = 28;
            this.gbxControl.TabStop = false;
            this.gbxControl.Text = "Control";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(136, 117);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 80);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(28, 117);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 80);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnJsSetup
            // 
            this.btnJsSetup.Location = new System.Drawing.Point(136, 28);
            this.btnJsSetup.Name = "btnJsSetup";
            this.btnJsSetup.Size = new System.Drawing.Size(100, 80);
            this.btnJsSetup.TabIndex = 22;
            this.btnJsSetup.Text = "JerkSmoothing Setup";
            this.btnJsSetup.UseVisualStyleBackColor = true;
            this.btnJsSetup.Click += new System.EventHandler(this.btnJsSetup_Click);
            // 
            // FormSpline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 606);
            this.Controls.Add(this.gbxControl);
            this.Controls.Add(this.gbxAxis);
            this.Controls.Add(this.gbxJerkSmoothing);
            this.Controls.Add(this.gbxSpeed);
            this.Name = "FormSpline";
            this.gbxSpeed.ResumeLayout(false);
            this.gbxSpeed.PerformLayout();
            this.gbxJerkSmoothing.ResumeLayout(false);
            this.gbxJerkSmoothing.PerformLayout();
            this.gbxAxis.ResumeLayout(false);
            this.gbxAxis.PerformLayout();
            this.gbxControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAxisX;
        private System.Windows.Forms.ComboBox cbxAxisX;
        private System.Windows.Forms.ComboBox cbxAxisY;
        private System.Windows.Forms.Label lblAxisY;
        private System.Windows.Forms.RichTextBox rtbPos;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.GroupBox gbxSpeed;
        private System.Windows.Forms.TextBox tbxJerk;
        private System.Windows.Forms.TextBox tbxDecel;
        private System.Windows.Forms.TextBox tbxAccel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxWork;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxInit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSpeedMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSpeedMode;
        private System.Windows.Forms.ComboBox cbxSpeedType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxJerkSmoothing;
        private System.Windows.Forms.ComboBox cbxJerkType;
        private System.Windows.Forms.Label lblJsType;
        private System.Windows.Forms.TextBox tbxDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox tbxLowVelRatio;
        private System.Windows.Forms.Label lblLowVelRatio;
        private System.Windows.Forms.TextBox tbxDecelTime;
        private System.Windows.Forms.Label lblDecelTime;
        private System.Windows.Forms.TextBox tbxThreshHold_X;
        private System.Windows.Forms.Label lblThreshHole_X;
        private System.Windows.Forms.GroupBox gbxAxis;
        private System.Windows.Forms.GroupBox gbxControl;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbxSplineIndex;
        private System.Windows.Forms.Label lblSplineIndex;
        private System.Windows.Forms.Button btnJsSetup;
        private System.Windows.Forms.TextBox tbxThreshHold_Y;
        private System.Windows.Forms.Label lblThreshHole_Y;
    }
}