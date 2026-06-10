namespace EtherCAT_Examples_CSharp
{
    partial class formSyncAxis
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
            this.cbxAxis = new System.Windows.Forms.ComboBox();
            this.cbxSyncAxis = new System.Windows.Forms.ComboBox();
            this.lblSyncAxis = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblSyncType = new System.Windows.Forms.Label();
            this.cbxMethods = new System.Windows.Forms.ComboBox();
            this.lblSyncMethods = new System.Windows.Forms.Label();
            this.tbxPosition = new System.Windows.Forms.TextBox();
            this.lblSyncPosition = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkIsOneShot = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblAxis
            // 
            this.lblAxis.AutoSize = true;
            this.lblAxis.Location = new System.Drawing.Point(31, 19);
            this.lblAxis.Name = "lblAxis";
            this.lblAxis.Size = new System.Drawing.Size(30, 12);
            this.lblAxis.TabIndex = 20;
            this.lblAxis.Text = "Axis";
            // 
            // cbxAxis
            // 
            this.cbxAxis.FormattingEnabled = true;
            this.cbxAxis.Location = new System.Drawing.Point(164, 16);
            this.cbxAxis.Name = "cbxAxis";
            this.cbxAxis.Size = new System.Drawing.Size(121, 20);
            this.cbxAxis.TabIndex = 19;
            this.cbxAxis.SelectedIndexChanged += new System.EventHandler(this.cbxAxis_SelectedIndexChanged);
            // 
            // cbxSyncAxis
            // 
            this.cbxSyncAxis.FormattingEnabled = true;
            this.cbxSyncAxis.Location = new System.Drawing.Point(164, 42);
            this.cbxSyncAxis.Name = "cbxSyncAxis";
            this.cbxSyncAxis.Size = new System.Drawing.Size(121, 20);
            this.cbxSyncAxis.TabIndex = 19;
            this.cbxSyncAxis.SelectedIndexChanged += new System.EventHandler(this.cbxAxis_SelectedIndexChanged);
            // 
            // lblSyncAxis
            // 
            this.lblSyncAxis.AutoSize = true;
            this.lblSyncAxis.Location = new System.Drawing.Point(31, 45);
            this.lblSyncAxis.Name = "lblSyncAxis";
            this.lblSyncAxis.Size = new System.Drawing.Size(59, 12);
            this.lblSyncAxis.TabIndex = 20;
            this.lblSyncAxis.Text = "SyncAxis";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "0 : SyncAxis : Moving start ",
            "1 : SyncAxis : Start of Accel ",
            "2 : SyncAxis : End of Accel ",
            "3 : SyncAxis : Start of Decel ",
            "4 : SyncAxis : End of Decel",
            "5 : SyncAxis : Position"});
            this.cbxType.Location = new System.Drawing.Point(164, 68);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 20);
            this.cbxType.TabIndex = 19;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxAxis_SelectedIndexChanged);
            // 
            // lblSyncType
            // 
            this.lblSyncType.AutoSize = true;
            this.lblSyncType.Location = new System.Drawing.Point(31, 71);
            this.lblSyncType.Name = "lblSyncType";
            this.lblSyncType.Size = new System.Drawing.Size(67, 12);
            this.lblSyncType.TabIndex = 20;
            this.lblSyncType.Text = "Sync Type";
            // 
            // cbxMethods
            // 
            this.cbxMethods.FormattingEnabled = true;
            this.cbxMethods.Items.AddRange(new object[] {
            "0 : > Position of SyncAxis",
            "1 : >= Position of SyncAxis",
            "2 : < Position of SyncAxis ",
            "3 : <= Position of SyncAxis",
            "4 : Cross the position (-) → (+) ",
            "5 : Cross the position (+) → (-) "});
            this.cbxMethods.Location = new System.Drawing.Point(164, 94);
            this.cbxMethods.Name = "cbxMethods";
            this.cbxMethods.Size = new System.Drawing.Size(121, 20);
            this.cbxMethods.TabIndex = 19;
            this.cbxMethods.SelectedIndexChanged += new System.EventHandler(this.cbxAxis_SelectedIndexChanged);
            // 
            // lblSyncMethods
            // 
            this.lblSyncMethods.AutoSize = true;
            this.lblSyncMethods.Location = new System.Drawing.Point(31, 97);
            this.lblSyncMethods.Name = "lblSyncMethods";
            this.lblSyncMethods.Size = new System.Drawing.Size(87, 12);
            this.lblSyncMethods.TabIndex = 20;
            this.lblSyncMethods.Text = "Sync Methods";
            // 
            // tbxPosition
            // 
            this.tbxPosition.Location = new System.Drawing.Point(164, 120);
            this.tbxPosition.Name = "tbxPosition";
            this.tbxPosition.Size = new System.Drawing.Size(121, 21);
            this.tbxPosition.TabIndex = 21;
            // 
            // lblSyncPosition
            // 
            this.lblSyncPosition.AutoSize = true;
            this.lblSyncPosition.Location = new System.Drawing.Point(31, 123);
            this.lblSyncPosition.Name = "lblSyncPosition";
            this.lblSyncPosition.Size = new System.Drawing.Size(83, 12);
            this.lblSyncPosition.TabIndex = 20;
            this.lblSyncPosition.Text = "Sync Position";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(164, 193);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(125, 36);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(33, 193);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 36);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkIsOneShot
            // 
            this.chkIsOneShot.AutoSize = true;
            this.chkIsOneShot.Location = new System.Drawing.Point(203, 161);
            this.chkIsOneShot.Name = "chkIsOneShot";
            this.chkIsOneShot.Size = new System.Drawing.Size(82, 16);
            this.chkIsOneShot.TabIndex = 23;
            this.chkIsOneShot.Text = "IsOneShot";
            this.chkIsOneShot.UseVisualStyleBackColor = true;
            // 
            // FormSyncAxis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 264);
            this.Controls.Add(this.chkIsOneShot);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tbxPosition);
            this.Controls.Add(this.lblSyncPosition);
            this.Controls.Add(this.lblSyncMethods);
            this.Controls.Add(this.lblSyncType);
            this.Controls.Add(this.lblSyncAxis);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxMethods);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.cbxSyncAxis);
            this.Controls.Add(this.cbxAxis);
            this.Name = "FormSyncAxis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxAxis;
        private System.Windows.Forms.ComboBox cbxSyncAxis;
        private System.Windows.Forms.Label lblSyncAxis;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblSyncType;
        private System.Windows.Forms.ComboBox cbxMethods;
        private System.Windows.Forms.Label lblSyncMethods;
        private System.Windows.Forms.TextBox tbxPosition;
        private System.Windows.Forms.Label lblSyncPosition;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkIsOneShot;
    }
}