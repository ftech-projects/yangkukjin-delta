namespace EtherCAT_Examples_CSharp
{
    partial class formPdoToStruct
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
            this.lblNetID = new System.Windows.Forms.Label();
            this.tbxNetID = new System.Windows.Forms.TextBox();
            this.lblSlaveAddr = new System.Windows.Forms.Label();
            this.tbxSlaveAddr = new System.Windows.Forms.TextBox();
            this.btnPdoRead = new System.Windows.Forms.Button();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNetID
            // 
            this.lblNetID.AutoSize = true;
            this.lblNetID.Location = new System.Drawing.Point(36, 31);
            this.lblNetID.Name = "lblNetID";
            this.lblNetID.Size = new System.Drawing.Size(35, 12);
            this.lblNetID.TabIndex = 0;
            this.lblNetID.Text = "NetID";
            // 
            // tbxNetID
            // 
            this.tbxNetID.Location = new System.Drawing.Point(129, 28);
            this.tbxNetID.Name = "tbxNetID";
            this.tbxNetID.Size = new System.Drawing.Size(100, 21);
            this.tbxNetID.TabIndex = 1;
            this.tbxNetID.Text = "0";
            this.tbxNetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxNetID.TextChanged += new System.EventHandler(this.tbxNetID_TextChanged);
            // 
            // lblSlaveAddr
            // 
            this.lblSlaveAddr.AutoSize = true;
            this.lblSlaveAddr.Location = new System.Drawing.Point(36, 58);
            this.lblSlaveAddr.Name = "lblSlaveAddr";
            this.lblSlaveAddr.Size = new System.Drawing.Size(87, 12);
            this.lblSlaveAddr.TabIndex = 0;
            this.lblSlaveAddr.Text = "Slave Address";
            // 
            // tbxSlaveAddr
            // 
            this.tbxSlaveAddr.Location = new System.Drawing.Point(129, 55);
            this.tbxSlaveAddr.Name = "tbxSlaveAddr";
            this.tbxSlaveAddr.Size = new System.Drawing.Size(100, 21);
            this.tbxSlaveAddr.TabIndex = 1;
            this.tbxSlaveAddr.Text = "0x0";
            this.tbxSlaveAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPdoRead
            // 
            this.btnPdoRead.Location = new System.Drawing.Point(38, 98);
            this.btnPdoRead.Name = "btnPdoRead";
            this.btnPdoRead.Size = new System.Drawing.Size(191, 41);
            this.btnPdoRead.TabIndex = 2;
            this.btnPdoRead.Text = "PDO Read";
            this.btnPdoRead.UseVisualStyleBackColor = true;
            this.btnPdoRead.Click += new System.EventHandler(this.btnPdoRead_Click);
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(38, 165);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(191, 87);
            this.tbxResult.TabIndex = 3;
            // 
            // formPdoToStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 264);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.btnPdoRead);
            this.Controls.Add(this.tbxSlaveAddr);
            this.Controls.Add(this.lblSlaveAddr);
            this.Controls.Add(this.tbxNetID);
            this.Controls.Add(this.lblNetID);
            this.Name = "formPdoToStruct";
            this.Text = "PdoToStruct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNetID;
        private System.Windows.Forms.TextBox tbxNetID;
        private System.Windows.Forms.Label lblSlaveAddr;
        private System.Windows.Forms.TextBox tbxSlaveAddr;
        private System.Windows.Forms.Button btnPdoRead;
        private System.Windows.Forms.TextBox tbxResult;
    }
}