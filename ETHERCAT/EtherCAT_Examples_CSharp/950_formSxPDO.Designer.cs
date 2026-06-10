namespace EtherCAT_Examples_CSharp
{
    partial class formSxPDO
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
            this.btnRead = new System.Windows.Forms.Button();
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
            this.cbxAxisList.Size = new System.Drawing.Size(121, 20);
            this.cbxAxisList.TabIndex = 19;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(40, 68);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 21;
            this.btnRead.Text = "button1";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // formSxPDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 312);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxAxisList);
            this.Name = "formSxPDO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.Button btnRead;
    }
}