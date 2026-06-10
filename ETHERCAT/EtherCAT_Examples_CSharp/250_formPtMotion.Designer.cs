namespace EtherCAT_Examples_CSharp
{
    partial class formPtMotion
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
            this.gbxSpiral = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.gbxState = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRemStepCount = new System.Windows.Forms.Label();
            this.lblRunStepCount = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxControl = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.gbxSpiral.SuspendLayout();
            this.gbxState.SuspendLayout();
            this.gbxControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAxisX
            // 
            this.lblAxisX.AutoSize = true;
            this.lblAxisX.Location = new System.Drawing.Point(28, 44);
            this.lblAxisX.Name = "lblAxisX";
            this.lblAxisX.Size = new System.Drawing.Size(42, 12);
            this.lblAxisX.TabIndex = 20;
            this.lblAxisX.Text = "Axis X";
            // 
            // cbxAxisX
            // 
            this.cbxAxisX.FormattingEnabled = true;
            this.cbxAxisX.Location = new System.Drawing.Point(93, 41);
            this.cbxAxisX.Name = "cbxAxisX";
            this.cbxAxisX.Size = new System.Drawing.Size(64, 20);
            this.cbxAxisX.TabIndex = 19;
            this.cbxAxisX.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // cbxAxisY
            // 
            this.cbxAxisY.FormattingEnabled = true;
            this.cbxAxisY.Location = new System.Drawing.Point(93, 67);
            this.cbxAxisY.Name = "cbxAxisY";
            this.cbxAxisY.Size = new System.Drawing.Size(64, 20);
            this.cbxAxisY.TabIndex = 19;
            this.cbxAxisY.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblAxisY
            // 
            this.lblAxisY.AutoSize = true;
            this.lblAxisY.Location = new System.Drawing.Point(28, 70);
            this.lblAxisY.Name = "lblAxisY";
            this.lblAxisY.Size = new System.Drawing.Size(42, 12);
            this.lblAxisY.TabIndex = 20;
            this.lblAxisY.Text = "Axis Y";
            // 
            // gbxSpiral
            // 
            this.gbxSpiral.Controls.Add(this.cbxAxisY);
            this.gbxSpiral.Controls.Add(this.btnStart);
            this.gbxSpiral.Controls.Add(this.lblAxisY);
            this.gbxSpiral.Controls.Add(this.cbxAxisX);
            this.gbxSpiral.Controls.Add(this.lblAxisX);
            this.gbxSpiral.Location = new System.Drawing.Point(26, 32);
            this.gbxSpiral.Name = "gbxSpiral";
            this.gbxSpiral.Size = new System.Drawing.Size(331, 118);
            this.gbxSpiral.TabIndex = 21;
            this.gbxSpiral.TabStop = false;
            this.gbxSpiral.Text = "Spiral Examples";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(175, 39);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 48);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "Test Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHold
            // 
            this.btnHold.Location = new System.Drawing.Point(53, 20);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(116, 48);
            this.btnHold.TabIndex = 21;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // gbxState
            // 
            this.gbxState.Controls.Add(this.label3);
            this.gbxState.Controls.Add(this.lblRemStepCount);
            this.gbxState.Controls.Add(this.lblRunStepCount);
            this.gbxState.Controls.Add(this.lblState);
            this.gbxState.Controls.Add(this.lblTotalCount);
            this.gbxState.Controls.Add(this.label4);
            this.gbxState.Controls.Add(this.label2);
            this.gbxState.Controls.Add(this.label1);
            this.gbxState.Location = new System.Drawing.Point(26, 326);
            this.gbxState.Name = "gbxState";
            this.gbxState.Size = new System.Drawing.Size(331, 120);
            this.gbxState.TabIndex = 22;
            this.gbxState.TabStop = false;
            this.gbxState.Text = "PT Motion State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Remained Step Count :";
            // 
            // lblRemStepCount
            // 
            this.lblRemStepCount.AutoSize = true;
            this.lblRemStepCount.Location = new System.Drawing.Point(205, 98);
            this.lblRemStepCount.Name = "lblRemStepCount";
            this.lblRemStepCount.Size = new System.Drawing.Size(11, 12);
            this.lblRemStepCount.TabIndex = 0;
            this.lblRemStepCount.Text = "0";
            // 
            // lblRunStepCount
            // 
            this.lblRunStepCount.AutoSize = true;
            this.lblRunStepCount.Location = new System.Drawing.Point(205, 74);
            this.lblRunStepCount.Name = "lblRunStepCount";
            this.lblRunStepCount.Size = new System.Drawing.Size(11, 12);
            this.lblRunStepCount.TabIndex = 0;
            this.lblRunStepCount.Text = "0";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(205, 26);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(11, 12);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "0";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(205, 50);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(11, 12);
            this.lblTotalCount.TabIndex = 0;
            this.lblTotalCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "RunState :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "TotalCount :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "RunStep Count :";
            // 
            // gbxControl
            // 
            this.gbxControl.Controls.Add(this.btnResetAll);
            this.gbxControl.Controls.Add(this.btnEnd);
            this.gbxControl.Controls.Add(this.btnResume);
            this.gbxControl.Controls.Add(this.btnHold);
            this.gbxControl.Location = new System.Drawing.Point(26, 163);
            this.gbxControl.Name = "gbxControl";
            this.gbxControl.Size = new System.Drawing.Size(331, 140);
            this.gbxControl.TabIndex = 23;
            this.gbxControl.TabStop = false;
            this.gbxControl.Text = "Control";
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(53, 74);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(116, 48);
            this.btnEnd.TabIndex = 21;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(175, 74);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(116, 48);
            this.btnResetAll.TabIndex = 21;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(175, 20);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(116, 48);
            this.btnResume.TabIndex = 21;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // FormPtMotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 496);
            this.Controls.Add(this.gbxControl);
            this.Controls.Add(this.gbxState);
            this.Controls.Add(this.gbxSpiral);
            this.Name = "FormPtMotion";
            this.gbxSpiral.ResumeLayout(false);
            this.gbxSpiral.PerformLayout();
            this.gbxState.ResumeLayout(false);
            this.gbxState.PerformLayout();
            this.gbxControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAxisX;
        private System.Windows.Forms.ComboBox cbxAxisX;
        private System.Windows.Forms.ComboBox cbxAxisY;
        private System.Windows.Forms.Label lblAxisY;
        private System.Windows.Forms.GroupBox gbxSpiral;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.GroupBox gbxState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRemStepCount;
        private System.Windows.Forms.Label lblRunStepCount;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxControl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnResume;
    }
}