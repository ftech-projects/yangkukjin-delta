namespace EtherCAT_Examples_CSharp
{
    partial class FormZVIS
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
            this.lblFrequency = new System.Windows.Forms.Label();
            this.tbxFrequency = new System.Windows.Forms.TextBox();
            this.lblDampingRatio = new System.Windows.Forms.Label();
            this.tbxDampingRatio = new System.Windows.Forms.TextBox();
            this.lblZvisMode = new System.Windows.Forms.Label();
            this.cbxZvisMode = new System.Windows.Forms.ComboBox();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAxis
            // 
            this.lblAxis.AutoSize = true;
            this.lblAxis.Location = new System.Drawing.Point(48, 19);
            this.lblAxis.Name = "lblAxis";
            this.lblAxis.Size = new System.Drawing.Size(30, 12);
            this.lblAxis.TabIndex = 20;
            this.lblAxis.Text = "Axis";
            // 
            // cbxAxisList
            // 
            this.cbxAxisList.FormattingEnabled = true;
            this.cbxAxisList.Location = new System.Drawing.Point(140, 16);
            this.cbxAxisList.Name = "cbxAxisList";
            this.cbxAxisList.Size = new System.Drawing.Size(84, 20);
            this.cbxAxisList.TabIndex = 19;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(48, 66);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(65, 12);
            this.lblFrequency.TabIndex = 20;
            this.lblFrequency.Text = "Frequency";
            // 
            // tbxFrequency
            // 
            this.tbxFrequency.Location = new System.Drawing.Point(140, 63);
            this.tbxFrequency.Name = "tbxFrequency";
            this.tbxFrequency.Size = new System.Drawing.Size(84, 21);
            this.tbxFrequency.TabIndex = 21;
            // 
            // lblDampingRatio
            // 
            this.lblDampingRatio.AutoSize = true;
            this.lblDampingRatio.Location = new System.Drawing.Point(48, 93);
            this.lblDampingRatio.Name = "lblDampingRatio";
            this.lblDampingRatio.Size = new System.Drawing.Size(76, 12);
            this.lblDampingRatio.TabIndex = 20;
            this.lblDampingRatio.Text = "Daping Ratio";
            // 
            // tbxDampingRatio
            // 
            this.tbxDampingRatio.Location = new System.Drawing.Point(140, 90);
            this.tbxDampingRatio.Name = "tbxDampingRatio";
            this.tbxDampingRatio.Size = new System.Drawing.Size(84, 21);
            this.tbxDampingRatio.TabIndex = 21;
            // 
            // lblZvisMode
            // 
            this.lblZvisMode.AutoSize = true;
            this.lblZvisMode.Location = new System.Drawing.Point(48, 120);
            this.lblZvisMode.Name = "lblZvisMode";
            this.lblZvisMode.Size = new System.Drawing.Size(68, 12);
            this.lblZvisMode.TabIndex = 20;
            this.lblZvisMode.Text = "ZVIS Mode";
            // 
            // cbxZvisMode
            // 
            this.cbxZvisMode.FormattingEnabled = true;
            this.cbxZvisMode.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbxZvisMode.Location = new System.Drawing.Point(140, 117);
            this.cbxZvisMode.Name = "cbxZvisMode";
            this.cbxZvisMode.Size = new System.Drawing.Size(84, 20);
            this.cbxZvisMode.TabIndex = 19;
            this.cbxZvisMode.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(50, 159);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(84, 41);
            this.btnEnable.TabIndex = 22;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(140, 159);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(84, 41);
            this.btnDisable.TabIndex = 22;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // FormZB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 239);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.tbxDampingRatio);
            this.Controls.Add(this.lblZvisMode);
            this.Controls.Add(this.tbxFrequency);
            this.Controls.Add(this.lblDampingRatio);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxZvisMode);
            this.Controls.Add(this.cbxAxisList);
            this.Name = "FormZB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.TextBox tbxFrequency;
        private System.Windows.Forms.Label lblDampingRatio;
        private System.Windows.Forms.TextBox tbxDampingRatio;
        private System.Windows.Forms.Label lblZvisMode;
        private System.Windows.Forms.ComboBox cbxZvisMode;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
    }
}