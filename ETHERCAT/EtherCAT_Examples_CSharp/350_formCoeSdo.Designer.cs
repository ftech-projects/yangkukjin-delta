namespace EtherCAT_Examples_CSharp
{
    partial class formCoeSdo
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
            this.lblIndex = new System.Windows.Forms.Label();
            this.tbxIndex = new System.Windows.Forms.TextBox();
            this.lblSubIndex = new System.Windows.Forms.Label();
            this.tbxSubIndex = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.gbxSDO = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAddr = new System.Windows.Forms.TextBox();
            this.gbxSDO.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(20, 62);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(36, 12);
            this.lblIndex.TabIndex = 20;
            this.lblIndex.Text = "Index";
            // 
            // tbxIndex
            // 
            this.tbxIndex.Location = new System.Drawing.Point(114, 59);
            this.tbxIndex.Name = "tbxIndex";
            this.tbxIndex.Size = new System.Drawing.Size(100, 21);
            this.tbxIndex.TabIndex = 21;
            // 
            // lblSubIndex
            // 
            this.lblSubIndex.AutoSize = true;
            this.lblSubIndex.Location = new System.Drawing.Point(20, 89);
            this.lblSubIndex.Name = "lblSubIndex";
            this.lblSubIndex.Size = new System.Drawing.Size(58, 12);
            this.lblSubIndex.TabIndex = 20;
            this.lblSubIndex.Text = "SubIndex";
            // 
            // tbxSubIndex
            // 
            this.tbxSubIndex.Location = new System.Drawing.Point(114, 86);
            this.tbxSubIndex.Name = "tbxSubIndex";
            this.tbxSubIndex.Size = new System.Drawing.Size(100, 21);
            this.tbxSubIndex.TabIndex = 21;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(20, 116);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 12);
            this.lblSize.TabIndex = 20;
            this.lblSize.Text = "Size";
            // 
            // tbxSize
            // 
            this.tbxSize.Location = new System.Drawing.Point(114, 113);
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.Size = new System.Drawing.Size(100, 21);
            this.tbxSize.TabIndex = 21;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(20, 143);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(37, 12);
            this.lblValue.TabIndex = 20;
            this.lblValue.Text = "Value";
            // 
            // tbxValue
            // 
            this.tbxValue.Location = new System.Drawing.Point(114, 140);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(100, 21);
            this.tbxValue.TabIndex = 21;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(23, 180);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(85, 53);
            this.btnRead.TabIndex = 22;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(129, 180);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(85, 53);
            this.btnWrite.TabIndex = 22;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // gbxSDO
            // 
            this.gbxSDO.Controls.Add(this.label1);
            this.gbxSDO.Controls.Add(this.lblIndex);
            this.gbxSDO.Controls.Add(this.tbxAddr);
            this.gbxSDO.Controls.Add(this.btnWrite);
            this.gbxSDO.Controls.Add(this.tbxIndex);
            this.gbxSDO.Controls.Add(this.btnRead);
            this.gbxSDO.Controls.Add(this.lblSubIndex);
            this.gbxSDO.Controls.Add(this.tbxValue);
            this.gbxSDO.Controls.Add(this.lblSize);
            this.gbxSDO.Controls.Add(this.tbxSize);
            this.gbxSDO.Controls.Add(this.tbxSubIndex);
            this.gbxSDO.Controls.Add(this.lblValue);
            this.gbxSDO.Location = new System.Drawing.Point(21, 21);
            this.gbxSDO.Name = "gbxSDO";
            this.gbxSDO.Size = new System.Drawing.Size(241, 259);
            this.gbxSDO.TabIndex = 23;
            this.gbxSDO.TabStop = false;
            this.gbxSDO.Text = "Coe SDO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "Slave Address";
            // 
            // tbxAddr
            // 
            this.tbxAddr.Location = new System.Drawing.Point(114, 32);
            this.tbxAddr.Name = "tbxAddr";
            this.tbxAddr.Size = new System.Drawing.Size(100, 21);
            this.tbxAddr.TabIndex = 21;
            // 
            // formCoeSdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.gbxSDO);
            this.Name = "formCoeSdo";
            this.gbxSDO.ResumeLayout(false);
            this.gbxSDO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.TextBox tbxIndex;
        private System.Windows.Forms.Label lblSubIndex;
        private System.Windows.Forms.TextBox tbxSubIndex;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox tbxSize;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.GroupBox gbxSDO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAddr;
    }
}