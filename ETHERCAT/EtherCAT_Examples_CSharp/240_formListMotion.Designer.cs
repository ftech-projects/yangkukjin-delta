namespace EtherCAT_Examples_CSharp
{
    partial class formListMotion
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
            this.lblAxis = new System.Windows.Forms.Label();
            this.cbxAxisList = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.cbxAxisY = new System.Windows.Forms.ComboBox();
            this.lblAxisY = new System.Windows.Forms.Label();
            this.cbxAxisX = new System.Windows.Forms.ComboBox();
            this.lblAxisX = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRunStepState_T = new System.Windows.Forms.Label();
            this.lblRunStepID_T = new System.Windows.Forms.Label();
            this.lblRunStepState = new System.Windows.Forms.Label();
            this.lblRunStepID = new System.Windows.Forms.Label();
            this.lblRunStepCount = new System.Windows.Forms.Label();
            this.lblRunStepCount_T = new System.Windows.Forms.Label();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.btnLmStop = new System.Windows.Forms.Button();
            this.btnLmRun = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxCh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAxis
            // 
            this.lblAxis.AutoSize = true;
            this.lblAxis.Location = new System.Drawing.Point(137, 32);
            this.lblAxis.Name = "lblAxis";
            this.lblAxis.Size = new System.Drawing.Size(30, 12);
            this.lblAxis.TabIndex = 20;
            this.lblAxis.Text = "Axis";
            // 
            // cbxAxisList
            // 
            this.cbxAxisList.FormattingEnabled = true;
            this.cbxAxisList.Location = new System.Drawing.Point(108, 47);
            this.cbxAxisList.Name = "cbxAxisList";
            this.cbxAxisList.Size = new System.Drawing.Size(59, 20);
            this.cbxAxisList.TabIndex = 19;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(195, 32);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(78, 35);
            this.btnTest.TabIndex = 21;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.cbxAxisList);
            this.groupBox1.Controls.Add(this.lblAxis);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 85);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "속도 프로파일 만들기";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTest2);
            this.groupBox2.Controls.Add(this.cbxAxisY);
            this.groupBox2.Controls.Add(this.lblAxisY);
            this.groupBox2.Controls.Add(this.cbxAxisX);
            this.groupBox2.Controls.Add(this.lblAxisX);
            this.groupBox2.Location = new System.Drawing.Point(24, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 85);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "말풍선 그리기";
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(195, 32);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(78, 35);
            this.btnTest2.TabIndex = 21;
            this.btnTest2.Text = "Test 2";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // cbxAxisY
            // 
            this.cbxAxisY.FormattingEnabled = true;
            this.cbxAxisY.Location = new System.Drawing.Point(108, 47);
            this.cbxAxisY.Name = "cbxAxisY";
            this.cbxAxisY.Size = new System.Drawing.Size(59, 20);
            this.cbxAxisY.TabIndex = 19;
            this.cbxAxisY.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblAxisY
            // 
            this.lblAxisY.AutoSize = true;
            this.lblAxisY.Location = new System.Drawing.Point(125, 32);
            this.lblAxisY.Name = "lblAxisY";
            this.lblAxisY.Size = new System.Drawing.Size(42, 12);
            this.lblAxisY.TabIndex = 20;
            this.lblAxisY.Text = "Axis Y";
            // 
            // cbxAxisX
            // 
            this.cbxAxisX.FormattingEnabled = true;
            this.cbxAxisX.Location = new System.Drawing.Point(21, 47);
            this.cbxAxisX.Name = "cbxAxisX";
            this.cbxAxisX.Size = new System.Drawing.Size(59, 20);
            this.cbxAxisX.TabIndex = 19;
            this.cbxAxisX.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblAxisX
            // 
            this.lblAxisX.AutoSize = true;
            this.lblAxisX.Location = new System.Drawing.Point(38, 32);
            this.lblAxisX.Name = "lblAxisX";
            this.lblAxisX.Size = new System.Drawing.Size(42, 12);
            this.lblAxisX.TabIndex = 20;
            this.lblAxisX.Text = "Axis X";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRunStepState_T);
            this.groupBox3.Controls.Add(this.lblRunStepID_T);
            this.groupBox3.Controls.Add(this.lblRunStepState);
            this.groupBox3.Controls.Add(this.lblRunStepID);
            this.groupBox3.Controls.Add(this.lblRunStepCount);
            this.groupBox3.Controls.Add(this.lblRunStepCount_T);
            this.groupBox3.Location = new System.Drawing.Point(24, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 106);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "리스트 모션 상태 확인";
            // 
            // lblRunStepState_T
            // 
            this.lblRunStepState_T.AutoSize = true;
            this.lblRunStepState_T.Location = new System.Drawing.Point(19, 73);
            this.lblRunStepState_T.Name = "lblRunStepState_T";
            this.lblRunStepState_T.Size = new System.Drawing.Size(96, 12);
            this.lblRunStepState_T.TabIndex = 0;
            this.lblRunStepState_T.Text = "Run Step State :";
            // 
            // lblRunStepID_T
            // 
            this.lblRunStepID_T.AutoSize = true;
            this.lblRunStepID_T.Location = new System.Drawing.Point(19, 51);
            this.lblRunStepID_T.Name = "lblRunStepID_T";
            this.lblRunStepID_T.Size = new System.Drawing.Size(75, 12);
            this.lblRunStepID_T.TabIndex = 0;
            this.lblRunStepID_T.Text = "Run StepID :";
            // 
            // lblRunStepState
            // 
            this.lblRunStepState.AutoSize = true;
            this.lblRunStepState.Location = new System.Drawing.Point(137, 73);
            this.lblRunStepState.Name = "lblRunStepState";
            this.lblRunStepState.Size = new System.Drawing.Size(11, 12);
            this.lblRunStepState.TabIndex = 0;
            this.lblRunStepState.Text = "0";
            // 
            // lblRunStepID
            // 
            this.lblRunStepID.AutoSize = true;
            this.lblRunStepID.Location = new System.Drawing.Point(137, 51);
            this.lblRunStepID.Name = "lblRunStepID";
            this.lblRunStepID.Size = new System.Drawing.Size(11, 12);
            this.lblRunStepID.TabIndex = 0;
            this.lblRunStepID.Text = "0";
            // 
            // lblRunStepCount
            // 
            this.lblRunStepCount.AutoSize = true;
            this.lblRunStepCount.Location = new System.Drawing.Point(137, 27);
            this.lblRunStepCount.Name = "lblRunStepCount";
            this.lblRunStepCount.Size = new System.Drawing.Size(11, 12);
            this.lblRunStepCount.TabIndex = 0;
            this.lblRunStepCount.Text = "0";
            // 
            // lblRunStepCount_T
            // 
            this.lblRunStepCount_T.AutoSize = true;
            this.lblRunStepCount_T.Location = new System.Drawing.Point(19, 27);
            this.lblRunStepCount_T.Name = "lblRunStepCount_T";
            this.lblRunStepCount_T.Size = new System.Drawing.Size(101, 12);
            this.lblRunStepCount_T.TabIndex = 0;
            this.lblRunStepCount_T.Text = "Run Step Count :";
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(219, 374);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(78, 35);
            this.btnResetAll.TabIndex = 21;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // btnLmStop
            // 
            this.btnLmStop.Location = new System.Drawing.Point(48, 374);
            this.btnLmStop.Name = "btnLmStop";
            this.btnLmStop.Size = new System.Drawing.Size(78, 35);
            this.btnLmStop.TabIndex = 21;
            this.btnLmStop.Text = "Stop (Pause)";
            this.btnLmStop.UseVisualStyleBackColor = true;
            this.btnLmStop.Click += new System.EventHandler(this.btnLmStop_Click);
            // 
            // btnLmRun
            // 
            this.btnLmRun.Location = new System.Drawing.Point(132, 374);
            this.btnLmRun.Name = "btnLmRun";
            this.btnLmRun.Size = new System.Drawing.Size(78, 35);
            this.btnLmRun.TabIndex = 21;
            this.btnLmRun.Text = "Run (Resume)";
            this.btnLmRun.UseVisualStyleBackColor = true;
            this.btnLmRun.Click += new System.EventHandler(this.btnLmRun_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "IO Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbxCh
            // 
            this.tbxCh.Location = new System.Drawing.Point(48, 423);
            this.tbxCh.Name = "tbxCh";
            this.tbxCh.Size = new System.Drawing.Size(76, 21);
            this.tbxCh.TabIndex = 25;
            this.tbxCh.Text = "3";
            this.tbxCh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "label1";
            // 
            // formListMotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxCh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLmRun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLmStop);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formListMotion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.ComboBox cbxAxisY;
        private System.Windows.Forms.Label lblAxisY;
        private System.Windows.Forms.ComboBox cbxAxisX;
        private System.Windows.Forms.Label lblAxisX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblRunStepState_T;
        private System.Windows.Forms.Label lblRunStepID_T;
        private System.Windows.Forms.Label lblRunStepState;
        private System.Windows.Forms.Label lblRunStepID;
        private System.Windows.Forms.Label lblRunStepCount;
        private System.Windows.Forms.Label lblRunStepCount_T;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button btnLmStop;
        private System.Windows.Forms.Button btnLmRun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbxCh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}