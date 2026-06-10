namespace EtherCAT_Examples_CSharp
{
    partial class formMultiTorque
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
            this.cbxRefAxis = new System.Windows.Forms.ComboBox();
            this.cbxTargetAxis = new System.Windows.Forms.ComboBox();
            this.lblTargetAxis = new System.Windows.Forms.Label();
            this.lblTargetPos = new System.Windows.Forms.Label();
            this.lblCmdTorq = new System.Windows.Forms.Label();
            this.tbxRefPos = new System.Windows.Forms.TextBox();
            this.tbxTargetTorq = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvwItem = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInitialTorque = new System.Windows.Forms.Label();
            this.lblStopTorque = new System.Windows.Forms.Label();
            this.tbxInitTorq = new System.Windows.Forms.TextBox();
            this.tbxStopTorq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCmpMode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAxis
            // 
            this.lblAxis.AutoSize = true;
            this.lblAxis.Location = new System.Drawing.Point(23, 19);
            this.lblAxis.Name = "lblAxis";
            this.lblAxis.Size = new System.Drawing.Size(52, 12);
            this.lblAxis.TabIndex = 20;
            this.lblAxis.Text = "Ref Axis";
            // 
            // cbxRefAxis
            // 
            this.cbxRefAxis.FormattingEnabled = true;
            this.cbxRefAxis.Location = new System.Drawing.Point(110, 16);
            this.cbxRefAxis.Name = "cbxRefAxis";
            this.cbxRefAxis.Size = new System.Drawing.Size(121, 20);
            this.cbxRefAxis.TabIndex = 19;
            // 
            // cbxTargetAxis
            // 
            this.cbxTargetAxis.FormattingEnabled = true;
            this.cbxTargetAxis.Location = new System.Drawing.Point(110, 47);
            this.cbxTargetAxis.Name = "cbxTargetAxis";
            this.cbxTargetAxis.Size = new System.Drawing.Size(121, 20);
            this.cbxTargetAxis.TabIndex = 19;
            // 
            // lblTargetAxis
            // 
            this.lblTargetAxis.AutoSize = true;
            this.lblTargetAxis.Location = new System.Drawing.Point(23, 50);
            this.lblTargetAxis.Name = "lblTargetAxis";
            this.lblTargetAxis.Size = new System.Drawing.Size(70, 12);
            this.lblTargetAxis.TabIndex = 20;
            this.lblTargetAxis.Text = "Target Axis";
            // 
            // lblTargetPos
            // 
            this.lblTargetPos.AutoSize = true;
            this.lblTargetPos.Location = new System.Drawing.Point(23, 102);
            this.lblTargetPos.Name = "lblTargetPos";
            this.lblTargetPos.Size = new System.Drawing.Size(72, 12);
            this.lblTargetPos.TabIndex = 20;
            this.lblTargetPos.Text = "Ref Position";
            // 
            // lblCmdTorq
            // 
            this.lblCmdTorq.AutoSize = true;
            this.lblCmdTorq.Location = new System.Drawing.Point(23, 130);
            this.lblCmdTorq.Name = "lblCmdTorq";
            this.lblCmdTorq.Size = new System.Drawing.Size(85, 12);
            this.lblCmdTorq.TabIndex = 20;
            this.lblCmdTorq.Text = "Target Torque";
            // 
            // tbxRefPos
            // 
            this.tbxRefPos.Location = new System.Drawing.Point(131, 99);
            this.tbxRefPos.Name = "tbxRefPos";
            this.tbxRefPos.Size = new System.Drawing.Size(100, 21);
            this.tbxRefPos.TabIndex = 21;
            this.tbxRefPos.Text = "0";
            // 
            // tbxTargetTorq
            // 
            this.tbxTargetTorq.Location = new System.Drawing.Point(131, 127);
            this.tbxTargetTorq.Name = "tbxTargetTorq";
            this.tbxTargetTorq.Size = new System.Drawing.Size(100, 21);
            this.tbxTargetTorq.TabIndex = 21;
            this.tbxTargetTorq.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(131, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 49);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvwItem
            // 
            this.lvwItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwItem.GridLines = true;
            this.lvwItem.Location = new System.Drawing.Point(239, 16);
            this.lvwItem.Name = "lvwItem";
            this.lvwItem.Size = new System.Drawing.Size(179, 187);
            this.lvwItem.TabIndex = 23;
            this.lvwItem.UseCompatibleStateImageBehavior = false;
            this.lvwItem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "position";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "torque";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 50;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(25, 330);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 49);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(131, 330);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 49);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(355, 221);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 49);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblInitialTorque
            // 
            this.lblInitialTorque.AutoSize = true;
            this.lblInitialTorque.Location = new System.Drawing.Point(23, 224);
            this.lblInitialTorque.Name = "lblInitialTorque";
            this.lblInitialTorque.Size = new System.Drawing.Size(78, 12);
            this.lblInitialTorque.TabIndex = 20;
            this.lblInitialTorque.Text = "Initial Torque";
            // 
            // lblStopTorque
            // 
            this.lblStopTorque.AutoSize = true;
            this.lblStopTorque.Location = new System.Drawing.Point(23, 252);
            this.lblStopTorque.Name = "lblStopTorque";
            this.lblStopTorque.Size = new System.Drawing.Size(70, 12);
            this.lblStopTorque.TabIndex = 20;
            this.lblStopTorque.Text = "StopTorque";
            // 
            // tbxInitTorq
            // 
            this.tbxInitTorq.Location = new System.Drawing.Point(131, 221);
            this.tbxInitTorq.Name = "tbxInitTorq";
            this.tbxInitTorq.Size = new System.Drawing.Size(100, 21);
            this.tbxInitTorq.TabIndex = 21;
            this.tbxInitTorq.Text = "0";
            // 
            // tbxStopTorq
            // 
            this.tbxStopTorq.Location = new System.Drawing.Point(131, 249);
            this.tbxStopTorq.Name = "tbxStopTorq";
            this.tbxStopTorq.Size = new System.Drawing.Size(100, 21);
            this.tbxStopTorq.TabIndex = 21;
            this.tbxStopTorq.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ref CmpMode";
            // 
            // cbxCmpMode
            // 
            this.cbxCmpMode.FormattingEnabled = true;
            this.cbxCmpMode.Items.AddRange(new object[] {
            "Target Pos < Ref Pos",
            "Target Pos > Ref Pos",
            "Target Pos <= Ref Pos",
            "Target Pos >= Ref Pos"});
            this.cbxCmpMode.Location = new System.Drawing.Point(131, 276);
            this.cbxCmpMode.Name = "cbxCmpMode";
            this.cbxCmpMode.Size = new System.Drawing.Size(100, 20);
            this.cbxCmpMode.TabIndex = 19;
            // 
            // FormMultiTorque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 408);
            this.Controls.Add(this.lvwItem);
            this.Controls.Add(this.cbxCmpMode);
            this.Controls.Add(this.cbxTargetAxis);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTargetAxis);
            this.Controls.Add(this.tbxStopTorq);
            this.Controls.Add(this.tbxInitTorq);
            this.Controls.Add(this.tbxTargetTorq);
            this.Controls.Add(this.tbxRefPos);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.lblStopTorque);
            this.Controls.Add(this.cbxRefAxis);
            this.Controls.Add(this.lblInitialTorque);
            this.Controls.Add(this.lblCmdTorq);
            this.Controls.Add(this.lblTargetPos);
            this.Name = "FormMultiTorque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxRefAxis;
        private System.Windows.Forms.ComboBox cbxTargetAxis;
        private System.Windows.Forms.Label lblTargetAxis;
        private System.Windows.Forms.Label lblTargetPos;
        private System.Windows.Forms.Label lblCmdTorq;
        private System.Windows.Forms.TextBox tbxRefPos;
        private System.Windows.Forms.TextBox tbxTargetTorq;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvwItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInitialTorque;
        private System.Windows.Forms.Label lblStopTorque;
        private System.Windows.Forms.TextBox tbxInitTorq;
        private System.Windows.Forms.TextBox tbxStopTorq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCmpMode;
    }
}