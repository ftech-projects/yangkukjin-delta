namespace EtherCAT_Examples_CSharp
{
    partial class formIxVia
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
            this.lblP2_X = new System.Windows.Forms.Label();
            this.tbxP2_X = new System.Windows.Forms.TextBox();
            this.lblP2_Y = new System.Windows.Forms.Label();
            this.tbxP2_Y = new System.Windows.Forms.TextBox();
            this.lblP3_X = new System.Windows.Forms.Label();
            this.tbxP3_X = new System.Windows.Forms.TextBox();
            this.lbl_P3Y = new System.Windows.Forms.Label();
            this.tbxP3_Y = new System.Windows.Forms.TextBox();
            this.cbxRoundType = new System.Windows.Forms.ComboBox();
            this.lblRType = new System.Windows.Forms.Label();
            this.lblNRadius = new System.Windows.Forms.Label();
            this.tbxNormalRadius = new System.Windows.Forms.TextBox();
            this.lblMinRadius = new System.Windows.Forms.Label();
            this.tbxMinRadius = new System.Windows.Forms.TextBox();
            this.chkIsAbsPos = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbxOverride = new System.Windows.Forms.GroupBox();
            this.tbxNewPosY = new System.Windows.Forms.TextBox();
            this.lblNewP_X = new System.Windows.Forms.Label();
            this.btnOverride = new System.Windows.Forms.Button();
            this.tbxNewPosX = new System.Windows.Forms.TextBox();
            this.lblNewP_Y = new System.Windows.Forms.Label();
            this.tbxNewRadius = new System.Windows.Forms.TextBox();
            this.lblNewRadius = new System.Windows.Forms.Label();
            this.gbxOverride.SuspendLayout();
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
            this.cbxAxisX.Location = new System.Drawing.Point(103, 16);
            this.cbxAxisX.Name = "cbxAxisX";
            this.cbxAxisX.Size = new System.Drawing.Size(85, 20);
            this.cbxAxisX.TabIndex = 19;
            this.cbxAxisX.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // cbxAxisY
            // 
            this.cbxAxisY.FormattingEnabled = true;
            this.cbxAxisY.Location = new System.Drawing.Point(278, 16);
            this.cbxAxisY.Name = "cbxAxisY";
            this.cbxAxisY.Size = new System.Drawing.Size(85, 20);
            this.cbxAxisY.TabIndex = 19;
            this.cbxAxisY.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblAxisY
            // 
            this.lblAxisY.AutoSize = true;
            this.lblAxisY.Location = new System.Drawing.Point(213, 19);
            this.lblAxisY.Name = "lblAxisY";
            this.lblAxisY.Size = new System.Drawing.Size(42, 12);
            this.lblAxisY.TabIndex = 20;
            this.lblAxisY.Text = "Axis Y";
            // 
            // lblP2_X
            // 
            this.lblP2_X.AutoSize = true;
            this.lblP2_X.Location = new System.Drawing.Point(49, 61);
            this.lblP2_X.Name = "lblP2_X";
            this.lblP2_X.Size = new System.Drawing.Size(31, 12);
            this.lblP2_X.TabIndex = 20;
            this.lblP2_X.Text = "P2 X";
            // 
            // tbxP2_X
            // 
            this.tbxP2_X.Location = new System.Drawing.Point(103, 58);
            this.tbxP2_X.Name = "tbxP2_X";
            this.tbxP2_X.Size = new System.Drawing.Size(85, 21);
            this.tbxP2_X.TabIndex = 21;
            this.tbxP2_X.Text = "100000";
            // 
            // lblP2_Y
            // 
            this.lblP2_Y.AutoSize = true;
            this.lblP2_Y.Location = new System.Drawing.Point(49, 88);
            this.lblP2_Y.Name = "lblP2_Y";
            this.lblP2_Y.Size = new System.Drawing.Size(31, 12);
            this.lblP2_Y.TabIndex = 20;
            this.lblP2_Y.Text = "P2 Y";
            // 
            // tbxP2_Y
            // 
            this.tbxP2_Y.Location = new System.Drawing.Point(103, 85);
            this.tbxP2_Y.Name = "tbxP2_Y";
            this.tbxP2_Y.Size = new System.Drawing.Size(85, 21);
            this.tbxP2_Y.TabIndex = 21;
            this.tbxP2_Y.Text = "100000";
            // 
            // lblP3_X
            // 
            this.lblP3_X.AutoSize = true;
            this.lblP3_X.Location = new System.Drawing.Point(226, 61);
            this.lblP3_X.Name = "lblP3_X";
            this.lblP3_X.Size = new System.Drawing.Size(31, 12);
            this.lblP3_X.TabIndex = 20;
            this.lblP3_X.Text = "P3 X";
            // 
            // tbxP3_X
            // 
            this.tbxP3_X.Location = new System.Drawing.Point(278, 58);
            this.tbxP3_X.Name = "tbxP3_X";
            this.tbxP3_X.Size = new System.Drawing.Size(85, 21);
            this.tbxP3_X.TabIndex = 21;
            this.tbxP3_X.Text = "200000";
            // 
            // lbl_P3Y
            // 
            this.lbl_P3Y.AutoSize = true;
            this.lbl_P3Y.Location = new System.Drawing.Point(226, 88);
            this.lbl_P3Y.Name = "lbl_P3Y";
            this.lbl_P3Y.Size = new System.Drawing.Size(31, 12);
            this.lbl_P3Y.TabIndex = 20;
            this.lbl_P3Y.Text = "P3 Y";
            // 
            // tbxP3_Y
            // 
            this.tbxP3_Y.Location = new System.Drawing.Point(278, 85);
            this.tbxP3_Y.Name = "tbxP3_Y";
            this.tbxP3_Y.Size = new System.Drawing.Size(85, 21);
            this.tbxP3_Y.TabIndex = 21;
            this.tbxP3_Y.Text = "0";
            // 
            // cbxRoundType
            // 
            this.cbxRoundType.FormattingEnabled = true;
            this.cbxRoundType.Items.AddRange(new object[] {
            "Start",
            "End"});
            this.cbxRoundType.Location = new System.Drawing.Point(278, 127);
            this.cbxRoundType.Name = "cbxRoundType";
            this.cbxRoundType.Size = new System.Drawing.Size(85, 20);
            this.cbxRoundType.TabIndex = 19;
            this.cbxRoundType.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblRType
            // 
            this.lblRType.AutoSize = true;
            this.lblRType.Location = new System.Drawing.Point(181, 130);
            this.lblRType.Name = "lblRType";
            this.lblRType.Size = new System.Drawing.Size(74, 12);
            this.lblRType.TabIndex = 20;
            this.lblRType.Text = "Round Type";
            // 
            // lblNRadius
            // 
            this.lblNRadius.AutoSize = true;
            this.lblNRadius.Location = new System.Drawing.Point(168, 156);
            this.lblNRadius.Name = "lblNRadius";
            this.lblNRadius.Size = new System.Drawing.Size(89, 12);
            this.lblNRadius.TabIndex = 20;
            this.lblNRadius.Text = "Normal Radius";
            // 
            // tbxNormalRadius
            // 
            this.tbxNormalRadius.Location = new System.Drawing.Point(279, 153);
            this.tbxNormalRadius.Name = "tbxNormalRadius";
            this.tbxNormalRadius.Size = new System.Drawing.Size(85, 21);
            this.tbxNormalRadius.TabIndex = 21;
            this.tbxNormalRadius.Text = "4000";
            // 
            // lblMinRadius
            // 
            this.lblMinRadius.AutoSize = true;
            this.lblMinRadius.Location = new System.Drawing.Point(156, 183);
            this.lblMinRadius.Name = "lblMinRadius";
            this.lblMinRadius.Size = new System.Drawing.Size(101, 12);
            this.lblMinRadius.TabIndex = 20;
            this.lblMinRadius.Text = "Minimum Radius";
            // 
            // tbxMinRadius
            // 
            this.tbxMinRadius.Location = new System.Drawing.Point(279, 180);
            this.tbxMinRadius.Name = "tbxMinRadius";
            this.tbxMinRadius.Size = new System.Drawing.Size(85, 21);
            this.tbxMinRadius.TabIndex = 21;
            this.tbxMinRadius.Text = "400";
            // 
            // chkIsAbsPos
            // 
            this.chkIsAbsPos.AutoSize = true;
            this.chkIsAbsPos.Location = new System.Drawing.Point(262, 219);
            this.chkIsAbsPos.Name = "chkIsAbsPos";
            this.chkIsAbsPos.Size = new System.Drawing.Size(101, 16);
            this.chkIsAbsPos.TabIndex = 22;
            this.chkIsAbsPos.Text = "IsAbsPosition";
            this.chkIsAbsPos.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(278, 259);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 36);
            this.btnStop.TabIndex = 23;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(170, 259);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 36);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbxOverride
            // 
            this.gbxOverride.Controls.Add(this.tbxNewPosY);
            this.gbxOverride.Controls.Add(this.lblNewP_X);
            this.gbxOverride.Controls.Add(this.btnOverride);
            this.gbxOverride.Controls.Add(this.tbxNewPosX);
            this.gbxOverride.Controls.Add(this.lblNewP_Y);
            this.gbxOverride.Controls.Add(this.tbxNewRadius);
            this.gbxOverride.Controls.Add(this.lblNewRadius);
            this.gbxOverride.Location = new System.Drawing.Point(12, 301);
            this.gbxOverride.Name = "gbxOverride";
            this.gbxOverride.Size = new System.Drawing.Size(369, 118);
            this.gbxOverride.TabIndex = 24;
            this.gbxOverride.TabStop = false;
            this.gbxOverride.Text = "Target Override";
            // 
            // tbxNewPosY
            // 
            this.tbxNewPosY.Location = new System.Drawing.Point(137, 53);
            this.tbxNewPosY.Name = "tbxNewPosY";
            this.tbxNewPosY.Size = new System.Drawing.Size(85, 21);
            this.tbxNewPosY.TabIndex = 21;
            this.tbxNewPosY.Text = "50000";
            // 
            // lblNewP_X
            // 
            this.lblNewP_X.AutoSize = true;
            this.lblNewP_X.Location = new System.Drawing.Point(62, 29);
            this.lblNewP_X.Name = "lblNewP_X";
            this.lblNewP_X.Size = new System.Drawing.Size(53, 12);
            this.lblNewP_X.TabIndex = 20;
            this.lblNewP_X.Text = "목표점 X";
            // 
            // btnOverride
            // 
            this.btnOverride.Location = new System.Drawing.Point(266, 26);
            this.btnOverride.Name = "btnOverride";
            this.btnOverride.Size = new System.Drawing.Size(85, 75);
            this.btnOverride.TabIndex = 23;
            this.btnOverride.Text = "Override";
            this.btnOverride.UseVisualStyleBackColor = true;
            this.btnOverride.Click += new System.EventHandler(this.btnOverride_Click);
            // 
            // tbxNewPosX
            // 
            this.tbxNewPosX.Location = new System.Drawing.Point(137, 26);
            this.tbxNewPosX.Name = "tbxNewPosX";
            this.tbxNewPosX.Size = new System.Drawing.Size(85, 21);
            this.tbxNewPosX.TabIndex = 21;
            this.tbxNewPosX.Text = "250000";
            // 
            // lblNewP_Y
            // 
            this.lblNewP_Y.AutoSize = true;
            this.lblNewP_Y.Location = new System.Drawing.Point(62, 56);
            this.lblNewP_Y.Name = "lblNewP_Y";
            this.lblNewP_Y.Size = new System.Drawing.Size(53, 12);
            this.lblNewP_Y.TabIndex = 20;
            this.lblNewP_Y.Text = "목표점 Y";
            // 
            // tbxNewRadius
            // 
            this.tbxNewRadius.Location = new System.Drawing.Point(137, 80);
            this.tbxNewRadius.Name = "tbxNewRadius";
            this.tbxNewRadius.Size = new System.Drawing.Size(85, 21);
            this.tbxNewRadius.TabIndex = 21;
            this.tbxNewRadius.Text = "2000";
            // 
            // lblNewRadius
            // 
            this.lblNewRadius.AutoSize = true;
            this.lblNewRadius.Location = new System.Drawing.Point(62, 83);
            this.lblNewRadius.Name = "lblNewRadius";
            this.lblNewRadius.Size = new System.Drawing.Size(44, 12);
            this.lblNewRadius.TabIndex = 20;
            this.lblNewRadius.Text = "Radius";
            // 
            // FormIxVia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.gbxOverride);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.chkIsAbsPos);
            this.Controls.Add(this.tbxP3_Y);
            this.Controls.Add(this.tbxP2_Y);
            this.Controls.Add(this.lbl_P3Y);
            this.Controls.Add(this.lblP2_Y);
            this.Controls.Add(this.tbxMinRadius);
            this.Controls.Add(this.tbxP3_X);
            this.Controls.Add(this.lblMinRadius);
            this.Controls.Add(this.lblP3_X);
            this.Controls.Add(this.tbxNormalRadius);
            this.Controls.Add(this.tbxP2_X);
            this.Controls.Add(this.lblNRadius);
            this.Controls.Add(this.lblP2_X);
            this.Controls.Add(this.lblAxisY);
            this.Controls.Add(this.cbxAxisY);
            this.Controls.Add(this.lblRType);
            this.Controls.Add(this.cbxRoundType);
            this.Controls.Add(this.lblAxisX);
            this.Controls.Add(this.cbxAxisX);
            this.Name = "FormIxVia";
            this.gbxOverride.ResumeLayout(false);
            this.gbxOverride.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxisX;
        private System.Windows.Forms.ComboBox cbxAxisX;
        private System.Windows.Forms.ComboBox cbxAxisY;
        private System.Windows.Forms.Label lblAxisY;
        private System.Windows.Forms.Label lblP2_X;
        private System.Windows.Forms.TextBox tbxP2_X;
        private System.Windows.Forms.Label lblP2_Y;
        private System.Windows.Forms.TextBox tbxP2_Y;
        private System.Windows.Forms.Label lblP3_X;
        private System.Windows.Forms.TextBox tbxP3_X;
        private System.Windows.Forms.Label lbl_P3Y;
        private System.Windows.Forms.TextBox tbxP3_Y;
        private System.Windows.Forms.ComboBox cbxRoundType;
        private System.Windows.Forms.Label lblRType;
        private System.Windows.Forms.Label lblNRadius;
        private System.Windows.Forms.TextBox tbxNormalRadius;
        private System.Windows.Forms.Label lblMinRadius;
        private System.Windows.Forms.TextBox tbxMinRadius;
        private System.Windows.Forms.CheckBox chkIsAbsPos;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbxOverride;
        private System.Windows.Forms.TextBox tbxNewPosY;
        private System.Windows.Forms.Label lblNewP_X;
        private System.Windows.Forms.Button btnOverride;
        private System.Windows.Forms.TextBox tbxNewPosX;
        private System.Windows.Forms.Label lblNewP_Y;
        private System.Windows.Forms.TextBox tbxNewRadius;
        private System.Windows.Forms.Label lblNewRadius;
    }
}