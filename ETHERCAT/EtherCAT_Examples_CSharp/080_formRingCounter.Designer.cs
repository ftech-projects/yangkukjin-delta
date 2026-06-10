namespace EtherCAT_Examples_CSharp
{
    partial class formRingCounter
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
            this.lblRange = new System.Windows.Forms.Label();
            this.tbxRange = new System.Windows.Forms.TextBox();
            this.lblDirMode = new System.Windows.Forms.Label();
            this.cbxDirMode = new System.Windows.Forms.ComboBox();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAxis
            // 
            this.lblAxis.AutoSize = true;
            this.lblAxis.Location = new System.Drawing.Point(38, 19);
            this.lblAxis.Name = "lblAxis";
            this.lblAxis.Size = new System.Drawing.Size(30, 12);
            this.lblAxis.TabIndex = 20;
            this.lblAxis.Text = "Axis";
            // 
            // cbxAxisList
            // 
            this.cbxAxisList.FormattingEnabled = true;
            this.cbxAxisList.Location = new System.Drawing.Point(103, 16);
            this.cbxAxisList.Name = "cbxAxisList";
            this.cbxAxisList.Size = new System.Drawing.Size(127, 20);
            this.cbxAxisList.TabIndex = 19;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(38, 70);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(41, 12);
            this.lblRange.TabIndex = 20;
            this.lblRange.Text = "Range";
            // 
            // tbxRange
            // 
            this.tbxRange.Location = new System.Drawing.Point(103, 67);
            this.tbxRange.Name = "tbxRange";
            this.tbxRange.Size = new System.Drawing.Size(127, 21);
            this.tbxRange.TabIndex = 21;
            // 
            // lblDirMode
            // 
            this.lblDirMode.AutoSize = true;
            this.lblDirMode.Location = new System.Drawing.Point(38, 104);
            this.lblDirMode.Name = "lblDirMode";
            this.lblDirMode.Size = new System.Drawing.Size(52, 12);
            this.lblDirMode.TabIndex = 20;
            this.lblDirMode.Text = "DirMode";
            // 
            // cbxDirMode
            // 
            this.cbxDirMode.FormattingEnabled = true;
            this.cbxDirMode.Location = new System.Drawing.Point(103, 101);
            this.cbxDirMode.Name = "cbxDirMode";
            this.cbxDirMode.Size = new System.Drawing.Size(127, 20);
            this.cbxDirMode.TabIndex = 19;
            this.cbxDirMode.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(40, 143);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(92, 66);
            this.btnEnable.TabIndex = 22;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(138, 143);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(92, 66);
            this.btnDisable.TabIndex = 22;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // FormRingCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.tbxRange);
            this.Controls.Add(this.lblDirMode);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxDirMode);
            this.Controls.Add(this.cbxAxisList);
            this.Name = "FormRingCounter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.TextBox tbxRange;
        private System.Windows.Forms.Label lblDirMode;
        private System.Windows.Forms.ComboBox cbxDirMode;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
    }
}