namespace EtherCAT_Examples_CSharp
{
    partial class formExtStop
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
            this.lblSoueceType = new System.Windows.Forms.Label();
            this.cbxSourceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEdge = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxOffsetMode = new System.Windows.Forms.ComboBox();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.tbxDist = new System.Windows.Forms.TextBox();
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
            this.cbxAxisList.Location = new System.Drawing.Point(118, 16);
            this.cbxAxisList.Name = "cbxAxisList";
            this.cbxAxisList.Size = new System.Drawing.Size(118, 20);
            this.cbxAxisList.TabIndex = 19;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblSoueceType
            // 
            this.lblSoueceType.AutoSize = true;
            this.lblSoueceType.Location = new System.Drawing.Point(38, 58);
            this.lblSoueceType.Name = "lblSoueceType";
            this.lblSoueceType.Size = new System.Drawing.Size(74, 12);
            this.lblSoueceType.TabIndex = 21;
            this.lblSoueceType.Text = "SourceType";
            // 
            // cbxSourceType
            // 
            this.cbxSourceType.FormattingEnabled = true;
            this.cbxSourceType.Items.AddRange(new object[] {
            "ExternalDI",
            "TouchProbe"});
            this.cbxSourceType.Location = new System.Drawing.Point(118, 55);
            this.cbxSourceType.Name = "cbxSourceType";
            this.cbxSourceType.Size = new System.Drawing.Size(118, 20);
            this.cbxSourceType.TabIndex = 22;
            this.cbxSourceType.SelectedIndexChanged += new System.EventHandler(this.cbxSourceType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "StopEdge";
            // 
            // cbxEdge
            // 
            this.cbxEdge.FormattingEnabled = true;
            this.cbxEdge.Items.AddRange(new object[] {
            "Falling",
            "Rising"});
            this.cbxEdge.Location = new System.Drawing.Point(118, 81);
            this.cbxEdge.Name = "cbxEdge";
            this.cbxEdge.Size = new System.Drawing.Size(118, 20);
            this.cbxEdge.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "DI Channel";
            // 
            // cbxCh
            // 
            this.cbxCh.FormattingEnabled = true;
            this.cbxCh.Location = new System.Drawing.Point(118, 133);
            this.cbxCh.Name = "cbxCh";
            this.cbxCh.Size = new System.Drawing.Size(118, 20);
            this.cbxCh.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "OffsetMode";
            // 
            // cbxOffsetMode
            // 
            this.cbxOffsetMode.FormattingEnabled = true;
            this.cbxOffsetMode.Items.AddRange(new object[] {
            "TargetPositionOnly",
            "EnsuringOffset"});
            this.cbxOffsetMode.Location = new System.Drawing.Point(118, 159);
            this.cbxOffsetMode.Name = "cbxOffsetMode";
            this.cbxOffsetMode.Size = new System.Drawing.Size(118, 20);
            this.cbxOffsetMode.TabIndex = 22;
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(40, 198);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(95, 45);
            this.btnEnable.TabIndex = 23;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(141, 198);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(95, 45);
            this.btnDisable.TabIndex = 23;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // tbxDist
            // 
            this.tbxDist.Location = new System.Drawing.Point(118, 107);
            this.tbxDist.Name = "tbxDist";
            this.tbxDist.Size = new System.Drawing.Size(118, 21);
            this.tbxDist.TabIndex = 24;
            // 
            // FormExtStop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 266);
            this.Controls.Add(this.tbxDist);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.cbxOffsetMode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxEdge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSourceType);
            this.Controls.Add(this.lblSoueceType);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxAxisList);
            this.Name = "FormExtStop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.Label lblSoueceType;
        private System.Windows.Forms.ComboBox cbxSourceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEdge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxOffsetMode;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.TextBox tbxDist;
    }
}