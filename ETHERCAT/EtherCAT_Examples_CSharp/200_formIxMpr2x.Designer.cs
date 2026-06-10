namespace EtherCAT_Examples_CSharp
{
    partial class formIxMpr2x
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAxisX
            // 
            this.lblAxisX.AutoSize = true;
            this.lblAxisX.Location = new System.Drawing.Point(16, 39);
            this.lblAxisX.Name = "lblAxisX";
            this.lblAxisX.Size = new System.Drawing.Size(42, 12);
            this.lblAxisX.TabIndex = 20;
            this.lblAxisX.Text = "Axis X";
            // 
            // cbxAxisX
            // 
            this.cbxAxisX.FormattingEnabled = true;
            this.cbxAxisX.Location = new System.Drawing.Point(81, 36);
            this.cbxAxisX.Name = "cbxAxisX";
            this.cbxAxisX.Size = new System.Drawing.Size(64, 20);
            this.cbxAxisX.TabIndex = 19;
            this.cbxAxisX.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // cbxAxisY
            // 
            this.cbxAxisY.FormattingEnabled = true;
            this.cbxAxisY.Location = new System.Drawing.Point(81, 62);
            this.cbxAxisY.Name = "cbxAxisY";
            this.cbxAxisY.Size = new System.Drawing.Size(64, 20);
            this.cbxAxisY.TabIndex = 19;
            this.cbxAxisY.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblAxisY
            // 
            this.lblAxisY.AutoSize = true;
            this.lblAxisY.Location = new System.Drawing.Point(16, 65);
            this.lblAxisY.Name = "lblAxisY";
            this.lblAxisY.Size = new System.Drawing.Size(42, 12);
            this.lblAxisY.TabIndex = 20;
            this.lblAxisY.Text = "Axis Y";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.cbxAxisY);
            this.groupBox1.Controls.Add(this.lblAxisY);
            this.groupBox1.Controls.Add(this.cbxAxisX);
            this.groupBox1.Controls.Add(this.lblAxisX);
            this.groupBox1.Location = new System.Drawing.Point(26, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 118);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "말풍선 그리기 예제";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(173, 34);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(74, 48);
            this.btnTest.TabIndex = 21;
            this.btnTest.Text = "Start";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(253, 34);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(74, 48);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // FormIxMpr2x
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 173);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormIxMpr2x";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAxisX;
        private System.Windows.Forms.ComboBox cbxAxisX;
        private System.Windows.Forms.ComboBox cbxAxisY;
        private System.Windows.Forms.Label lblAxisY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnStop;
    }
}