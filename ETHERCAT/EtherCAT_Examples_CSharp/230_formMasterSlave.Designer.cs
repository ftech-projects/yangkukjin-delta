namespace EtherCAT_Examples_CSharp
{
    partial class formMasterSlave
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
            this.lblAxis_Master = new System.Windows.Forms.Label();
            this.cbxAxis_Master = new System.Windows.Forms.ComboBox();
            this.cbxAxis = new System.Windows.Forms.ComboBox();
            this.lblAxis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxRatio = new System.Windows.Forms.TextBox();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnSyncSlave = new System.Windows.Forms.Button();
            this.lblMasterPosOffset = new System.Windows.Forms.Label();
            this.tbxPosOffset = new System.Windows.Forms.TextBox();
            this.chkIsWaitCompt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblAxis_Master
            // 
            this.lblAxis_Master.AutoSize = true;
            this.lblAxis_Master.Location = new System.Drawing.Point(38, 49);
            this.lblAxis_Master.Name = "lblAxis_Master";
            this.lblAxis_Master.Size = new System.Drawing.Size(73, 12);
            this.lblAxis_Master.TabIndex = 20;
            this.lblAxis_Master.Text = "Master Axis";
            // 
            // cbxAxis_Master
            // 
            this.cbxAxis_Master.FormattingEnabled = true;
            this.cbxAxis_Master.Location = new System.Drawing.Point(117, 46);
            this.cbxAxis_Master.Name = "cbxAxis_Master";
            this.cbxAxis_Master.Size = new System.Drawing.Size(107, 20);
            this.cbxAxis_Master.TabIndex = 19;
            this.cbxAxis_Master.SelectedIndexChanged += new System.EventHandler(this.cbxAxis_Master_SelectedIndexChanged);
            // 
            // cbxAxis
            // 
            this.cbxAxis.FormattingEnabled = true;
            this.cbxAxis.Location = new System.Drawing.Point(117, 20);
            this.cbxAxis.Name = "cbxAxis";
            this.cbxAxis.Size = new System.Drawing.Size(107, 20);
            this.cbxAxis.TabIndex = 19;
            this.cbxAxis.SelectedIndexChanged += new System.EventHandler(this.cbxAxis_SelectedIndexChanged);
            // 
            // lblAxis
            // 
            this.lblAxis.AutoSize = true;
            this.lblAxis.Location = new System.Drawing.Point(38, 23);
            this.lblAxis.Name = "lblAxis";
            this.lblAxis.Size = new System.Drawing.Size(30, 12);
            this.lblAxis.TabIndex = 20;
            this.lblAxis.Text = "Axis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ratio";
            // 
            // tbxRatio
            // 
            this.tbxRatio.Location = new System.Drawing.Point(117, 72);
            this.tbxRatio.Name = "tbxRatio";
            this.tbxRatio.Size = new System.Drawing.Size(107, 21);
            this.tbxRatio.TabIndex = 21;
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(135, 113);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(89, 44);
            this.btnDisable.TabIndex = 24;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(40, 113);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(89, 44);
            this.btnEnable.TabIndex = 25;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnSyncSlave
            // 
            this.btnSyncSlave.Location = new System.Drawing.Point(135, 230);
            this.btnSyncSlave.Name = "btnSyncSlave";
            this.btnSyncSlave.Size = new System.Drawing.Size(89, 44);
            this.btnSyncSlave.TabIndex = 25;
            this.btnSyncSlave.Text = "SyncSlave";
            this.btnSyncSlave.UseVisualStyleBackColor = true;
            this.btnSyncSlave.Click += new System.EventHandler(this.btnSyncSlave_Click);
            // 
            // lblMasterPosOffset
            // 
            this.lblMasterPosOffset.AutoSize = true;
            this.lblMasterPosOffset.Location = new System.Drawing.Point(38, 181);
            this.lblMasterPosOffset.Name = "lblMasterPosOffset";
            this.lblMasterPosOffset.Size = new System.Drawing.Size(86, 12);
            this.lblMasterPosOffset.TabIndex = 20;
            this.lblMasterPosOffset.Text = "Position Offset";
            // 
            // tbxPosOffset
            // 
            this.tbxPosOffset.Location = new System.Drawing.Point(135, 178);
            this.tbxPosOffset.Name = "tbxPosOffset";
            this.tbxPosOffset.Size = new System.Drawing.Size(89, 21);
            this.tbxPosOffset.TabIndex = 21;
            // 
            // chkIsWaitCompt
            // 
            this.chkIsWaitCompt.AutoSize = true;
            this.chkIsWaitCompt.Location = new System.Drawing.Point(130, 208);
            this.chkIsWaitCompt.Name = "chkIsWaitCompt";
            this.chkIsWaitCompt.Size = new System.Drawing.Size(94, 16);
            this.chkIsWaitCompt.TabIndex = 26;
            this.chkIsWaitCompt.Text = "IsWaitCompt";
            this.chkIsWaitCompt.UseVisualStyleBackColor = true;
            // 
            // FormMasterSlave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 308);
            this.Controls.Add(this.chkIsWaitCompt);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnSyncSlave);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.tbxPosOffset);
            this.Controls.Add(this.lblMasterPosOffset);
            this.Controls.Add(this.tbxRatio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.lblAxis_Master);
            this.Controls.Add(this.cbxAxis);
            this.Controls.Add(this.cbxAxis_Master);
            this.Name = "FormMasterSlave";
            this.Text = "Master - Slave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis_Master;
        private System.Windows.Forms.ComboBox cbxAxis_Master;
        private System.Windows.Forms.ComboBox cbxAxis;
        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxRatio;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnSyncSlave;
        private System.Windows.Forms.Label lblMasterPosOffset;
        private System.Windows.Forms.TextBox tbxPosOffset;
        private System.Windows.Forms.CheckBox chkIsWaitCompt;
    }
}