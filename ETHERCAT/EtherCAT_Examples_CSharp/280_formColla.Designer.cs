namespace EtherCAT_Examples_CSharp
{
    partial class formColla
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
            this.cbxAxis_Slave = new System.Windows.Forms.ComboBox();
            this.lblAxis_Slave = new System.Windows.Forms.Label();
            this.cbxSubOrAdd = new System.Windows.Forms.ComboBox();
            this.lblSubOrAdd = new System.Windows.Forms.Label();
            this.cbxLessOrGreater = new System.Windows.Forms.ComboBox();
            this.lblLessOrGreater = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.tbxLimit = new System.Windows.Forms.TextBox();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.tbxIndex = new System.Windows.Forms.TextBox();
            this.t_Colla = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblAxis
            // 
            this.lblAxis.AutoSize = true;
            this.lblAxis.Location = new System.Drawing.Point(40, 61);
            this.lblAxis.Name = "lblAxis";
            this.lblAxis.Size = new System.Drawing.Size(69, 12);
            this.lblAxis.TabIndex = 20;
            this.lblAxis.Text = "MasterAxis";
            // 
            // cbxAxisList
            // 
            this.cbxAxisList.FormattingEnabled = true;
            this.cbxAxisList.Location = new System.Drawing.Point(134, 58);
            this.cbxAxisList.Name = "cbxAxisList";
            this.cbxAxisList.Size = new System.Drawing.Size(92, 20);
            this.cbxAxisList.TabIndex = 19;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // cbxAxis_Slave
            // 
            this.cbxAxis_Slave.FormattingEnabled = true;
            this.cbxAxis_Slave.Location = new System.Drawing.Point(134, 84);
            this.cbxAxis_Slave.Name = "cbxAxis_Slave";
            this.cbxAxis_Slave.Size = new System.Drawing.Size(92, 20);
            this.cbxAxis_Slave.TabIndex = 19;
            // 
            // lblAxis_Slave
            // 
            this.lblAxis_Slave.AutoSize = true;
            this.lblAxis_Slave.Location = new System.Drawing.Point(40, 87);
            this.lblAxis_Slave.Name = "lblAxis_Slave";
            this.lblAxis_Slave.Size = new System.Drawing.Size(61, 12);
            this.lblAxis_Slave.TabIndex = 20;
            this.lblAxis_Slave.Text = "SlaveAxis";
            // 
            // cbxSubOrAdd
            // 
            this.cbxSubOrAdd.FormattingEnabled = true;
            this.cbxSubOrAdd.Items.AddRange(new object[] {
            "Subtract",
            "Add"});
            this.cbxSubOrAdd.Location = new System.Drawing.Point(134, 110);
            this.cbxSubOrAdd.Name = "cbxSubOrAdd";
            this.cbxSubOrAdd.Size = new System.Drawing.Size(92, 20);
            this.cbxSubOrAdd.TabIndex = 19;
            // 
            // lblSubOrAdd
            // 
            this.lblSubOrAdd.AutoSize = true;
            this.lblSubOrAdd.Location = new System.Drawing.Point(40, 113);
            this.lblSubOrAdd.Name = "lblSubOrAdd";
            this.lblSubOrAdd.Size = new System.Drawing.Size(62, 12);
            this.lblSubOrAdd.TabIndex = 20;
            this.lblSubOrAdd.Text = "SubOrAdd";
            // 
            // cbxLessOrGreater
            // 
            this.cbxLessOrGreater.FormattingEnabled = true;
            this.cbxLessOrGreater.Items.AddRange(new object[] {
            "Less",
            "Greater"});
            this.cbxLessOrGreater.Location = new System.Drawing.Point(134, 136);
            this.cbxLessOrGreater.Name = "cbxLessOrGreater";
            this.cbxLessOrGreater.Size = new System.Drawing.Size(92, 20);
            this.cbxLessOrGreater.TabIndex = 19;
            // 
            // lblLessOrGreater
            // 
            this.lblLessOrGreater.AutoSize = true;
            this.lblLessOrGreater.Location = new System.Drawing.Point(40, 139);
            this.lblLessOrGreater.Name = "lblLessOrGreater";
            this.lblLessOrGreater.Size = new System.Drawing.Size(87, 12);
            this.lblLessOrGreater.TabIndex = 20;
            this.lblLessOrGreater.Text = "LessOrGreater";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(40, 165);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(32, 12);
            this.lblLimit.TabIndex = 20;
            this.lblLimit.Text = "Limit";
            // 
            // tbxLimit
            // 
            this.tbxLimit.Location = new System.Drawing.Point(134, 162);
            this.tbxLimit.Name = "tbxLimit";
            this.tbxLimit.Size = new System.Drawing.Size(92, 21);
            this.tbxLimit.TabIndex = 21;
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(137, 204);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(89, 44);
            this.btnDisable.TabIndex = 24;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(42, 204);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(89, 44);
            this.btnEnable.TabIndex = 25;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(40, 34);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(69, 12);
            this.lblIndex.TabIndex = 20;
            this.lblIndex.Text = "Colla Index";
            // 
            // tbxIndex
            // 
            this.tbxIndex.Location = new System.Drawing.Point(134, 31);
            this.tbxIndex.Name = "tbxIndex";
            this.tbxIndex.Size = new System.Drawing.Size(92, 21);
            this.tbxIndex.TabIndex = 21;
            this.tbxIndex.TextChanged += new System.EventHandler(this.tbxIndex_TextChanged);
            // 
            // t_Colla
            // 
            this.t_Colla.Enabled = true;
            this.t_Colla.Tick += new System.EventHandler(this.t_Colla_Tick);
            // 
            // FormColla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 305);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.tbxIndex);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.tbxLimit);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblLessOrGreater);
            this.Controls.Add(this.lblSubOrAdd);
            this.Controls.Add(this.lblAxis_Slave);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxLessOrGreater);
            this.Controls.Add(this.cbxSubOrAdd);
            this.Controls.Add(this.cbxAxis_Slave);
            this.Controls.Add(this.cbxAxisList);
            this.Name = "FormColla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.ComboBox cbxAxis_Slave;
        private System.Windows.Forms.Label lblAxis_Slave;
        private System.Windows.Forms.ComboBox cbxSubOrAdd;
        private System.Windows.Forms.Label lblSubOrAdd;
        private System.Windows.Forms.ComboBox cbxLessOrGreater;
        private System.Windows.Forms.Label lblLessOrGreater;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.TextBox tbxLimit;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.TextBox tbxIndex;
        private System.Windows.Forms.Timer t_Colla;
    }
}