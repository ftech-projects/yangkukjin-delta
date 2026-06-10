namespace EtherCAT_Examples_CSharp
{
    partial class formRingCounter_Absolute
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
            this.components = new System.ComponentModel.Container();
            this.lblAxis = new System.Windows.Forms.Label();
            this.cbxAxisList = new System.Windows.Forms.ComboBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.tbxRange = new System.Windows.Forms.TextBox();
            this.lblDirMode = new System.Windows.Forms.Label();
            this.cbxDirMode = new System.Windows.Forms.ComboBox();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.lblLimit = new System.Windows.Forms.Label();
            this.tbxRangeLimit = new System.Windows.Forms.TextBox();
            this.gbxAbsInfo = new System.Windows.Forms.GroupBox();
            this.lblIsAbs = new System.Windows.Forms.Label();
            this.lblAbsEnable = new System.Windows.Forms.Label();
            this.t_Ring = new System.Windows.Forms.Timer(this.components);
            this.gbxAbsInfo.SuspendLayout();
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
            this.cbxAxisList.Location = new System.Drawing.Point(129, 16);
            this.cbxAxisList.Name = "cbxAxisList";
            this.cbxAxisList.Size = new System.Drawing.Size(127, 20);
            this.cbxAxisList.TabIndex = 19;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(38, 190);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(41, 12);
            this.lblRange.TabIndex = 20;
            this.lblRange.Text = "Range";
            // 
            // tbxRange
            // 
            this.tbxRange.Location = new System.Drawing.Point(129, 187);
            this.tbxRange.Name = "tbxRange";
            this.tbxRange.Size = new System.Drawing.Size(127, 21);
            this.tbxRange.TabIndex = 21;
            // 
            // lblDirMode
            // 
            this.lblDirMode.AutoSize = true;
            this.lblDirMode.Location = new System.Drawing.Point(38, 224);
            this.lblDirMode.Name = "lblDirMode";
            this.lblDirMode.Size = new System.Drawing.Size(52, 12);
            this.lblDirMode.TabIndex = 20;
            this.lblDirMode.Text = "DirMode";
            // 
            // cbxDirMode
            // 
            this.cbxDirMode.FormattingEnabled = true;
            this.cbxDirMode.Location = new System.Drawing.Point(129, 221);
            this.cbxDirMode.Name = "cbxDirMode";
            this.cbxDirMode.Size = new System.Drawing.Size(127, 20);
            this.cbxDirMode.TabIndex = 19;
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(40, 255);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(105, 66);
            this.btnEnable.TabIndex = 22;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(151, 255);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(105, 66);
            this.btnDisable.TabIndex = 22;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(21, 74);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(72, 12);
            this.lblLimit.TabIndex = 23;
            this.lblLimit.Text = "Range Limit";
            // 
            // tbxRangeLimit
            // 
            this.tbxRangeLimit.Enabled = false;
            this.tbxRangeLimit.Location = new System.Drawing.Point(99, 71);
            this.tbxRangeLimit.Name = "tbxRangeLimit";
            this.tbxRangeLimit.Size = new System.Drawing.Size(111, 21);
            this.tbxRangeLimit.TabIndex = 21;
            // 
            // gbxAbsInfo
            // 
            this.gbxAbsInfo.Controls.Add(this.tbxRangeLimit);
            this.gbxAbsInfo.Controls.Add(this.lblAbsEnable);
            this.gbxAbsInfo.Controls.Add(this.lblIsAbs);
            this.gbxAbsInfo.Controls.Add(this.lblLimit);
            this.gbxAbsInfo.Location = new System.Drawing.Point(40, 49);
            this.gbxAbsInfo.Name = "gbxAbsInfo";
            this.gbxAbsInfo.Size = new System.Drawing.Size(216, 115);
            this.gbxAbsInfo.TabIndex = 24;
            this.gbxAbsInfo.TabStop = false;
            this.gbxAbsInfo.Text = "Absoulte Info";
            // 
            // lblIsAbs
            // 
            this.lblIsAbs.AutoSize = true;
            this.lblIsAbs.Location = new System.Drawing.Point(21, 41);
            this.lblIsAbs.Name = "lblIsAbs";
            this.lblIsAbs.Size = new System.Drawing.Size(62, 12);
            this.lblIsAbs.TabIndex = 23;
            this.lblIsAbs.Text = "Absoulte :";
            // 
            // lblAbsEnable
            // 
            this.lblAbsEnable.AutoSize = true;
            this.lblAbsEnable.Location = new System.Drawing.Point(109, 41);
            this.lblAbsEnable.Name = "lblAbsEnable";
            this.lblAbsEnable.Size = new System.Drawing.Size(11, 12);
            this.lblAbsEnable.TabIndex = 23;
            this.lblAbsEnable.Text = "-";
            // 
            // t_Ring
            // 
            this.t_Ring.Enabled = true;
            this.t_Ring.Tick += new System.EventHandler(this.t_Ring_Tick);
            // 
            // formRingCounter_Absolute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 342);
            this.Controls.Add(this.gbxAbsInfo);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.tbxRange);
            this.Controls.Add(this.lblDirMode);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxDirMode);
            this.Controls.Add(this.cbxAxisList);
            this.Name = "formRingCounter_Absolute";
            this.gbxAbsInfo.ResumeLayout(false);
            this.gbxAbsInfo.PerformLayout();
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
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.TextBox tbxRangeLimit;
        private System.Windows.Forms.GroupBox gbxAbsInfo;
        private System.Windows.Forms.Label lblAbsEnable;
        private System.Windows.Forms.Label lblIsAbs;
        private System.Windows.Forms.Timer t_Ring;
    }
}