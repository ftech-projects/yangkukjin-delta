namespace EtherCAT_Examples_CSharp
{
    partial class formAutoTorque
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
            this.cbxAxisList = new System.Windows.Forms.ComboBox();
            this.lblAxis = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwItem = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.tbxTorque = new System.Windows.Forms.TextBox();
            this.lblTorque = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.chkLowSpeed = new System.Windows.Forms.CheckBox();
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.tbxLowSpeed = new System.Windows.Forms.TextBox();
            this.chkhighSpeed = new System.Windows.Forms.CheckBox();
            this.tbxHighSpeed = new System.Windows.Forms.TextBox();
            this.btnStartMulti = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStartSingle = new System.Windows.Forms.Button();
            this.tbxPosition = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // lblAxis
            // 
            this.lblAxis.AutoSize = true;
            this.lblAxis.Location = new System.Drawing.Point(38, 19);
            this.lblAxis.Name = "lblAxis";
            this.lblAxis.Size = new System.Drawing.Size(30, 12);
            this.lblAxis.TabIndex = 20;
            this.lblAxis.Text = "Axis";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwItem);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbxDuration);
            this.groupBox1.Controls.Add(this.lblDuration);
            this.groupBox1.Controls.Add(this.tbxTorque);
            this.groupBox1.Controls.Add(this.lblTorque);
            this.groupBox1.Location = new System.Drawing.Point(21, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 187);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Torque";
            // 
            // lvwItem
            // 
            this.lvwItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwItem.GridLines = true;
            this.lvwItem.Location = new System.Drawing.Point(166, 27);
            this.lvwItem.Name = "lvwItem";
            this.lvwItem.Size = new System.Drawing.Size(146, 103);
            this.lvwItem.TabIndex = 3;
            this.lvwItem.UseCompatibleStateImageBehavior = false;
            this.lvwItem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Torque";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Duration";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 70;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(238, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 38);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(82, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxDuration
            // 
            this.tbxDuration.Location = new System.Drawing.Point(82, 54);
            this.tbxDuration.Name = "tbxDuration";
            this.tbxDuration.Size = new System.Drawing.Size(78, 21);
            this.tbxDuration.TabIndex = 1;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(28, 57);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(51, 12);
            this.lblDuration.TabIndex = 0;
            this.lblDuration.Text = "Duration";
            // 
            // tbxTorque
            // 
            this.tbxTorque.Location = new System.Drawing.Point(82, 27);
            this.tbxTorque.Name = "tbxTorque";
            this.tbxTorque.Size = new System.Drawing.Size(78, 21);
            this.tbxTorque.TabIndex = 1;
            // 
            // lblTorque
            // 
            this.lblTorque.AutoSize = true;
            this.lblTorque.Location = new System.Drawing.Point(28, 30);
            this.lblTorque.Name = "lblTorque";
            this.lblTorque.Size = new System.Drawing.Size(45, 12);
            this.lblTorque.TabIndex = 0;
            this.lblTorque.Text = "Torque";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTime);
            this.groupBox2.Controls.Add(this.chkLowSpeed);
            this.groupBox2.Controls.Add(this.tbxTime);
            this.groupBox2.Controls.Add(this.tbxLowSpeed);
            this.groupBox2.Controls.Add(this.chkhighSpeed);
            this.groupBox2.Controls.Add(this.tbxHighSpeed);
            this.groupBox2.Location = new System.Drawing.Point(21, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 131);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Limit Condition";
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Location = new System.Drawing.Point(132, 93);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(53, 16);
            this.chkTime.TabIndex = 0;
            this.chkTime.Text = "Time";
            this.chkTime.UseVisualStyleBackColor = true;
            // 
            // chkLowSpeed
            // 
            this.chkLowSpeed.AutoSize = true;
            this.chkLowSpeed.Location = new System.Drawing.Point(132, 66);
            this.chkLowSpeed.Name = "chkLowSpeed";
            this.chkLowSpeed.Size = new System.Drawing.Size(88, 16);
            this.chkLowSpeed.TabIndex = 0;
            this.chkLowSpeed.Text = "Low Speed";
            this.chkLowSpeed.UseVisualStyleBackColor = true;
            // 
            // tbxTime
            // 
            this.tbxTime.Location = new System.Drawing.Point(224, 88);
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.Size = new System.Drawing.Size(88, 21);
            this.tbxTime.TabIndex = 1;
            // 
            // tbxLowSpeed
            // 
            this.tbxLowSpeed.Location = new System.Drawing.Point(224, 61);
            this.tbxLowSpeed.Name = "tbxLowSpeed";
            this.tbxLowSpeed.Size = new System.Drawing.Size(88, 21);
            this.tbxLowSpeed.TabIndex = 1;
            // 
            // chkhighSpeed
            // 
            this.chkhighSpeed.AutoSize = true;
            this.chkhighSpeed.Location = new System.Drawing.Point(132, 39);
            this.chkhighSpeed.Name = "chkhighSpeed";
            this.chkhighSpeed.Size = new System.Drawing.Size(89, 16);
            this.chkhighSpeed.TabIndex = 0;
            this.chkhighSpeed.Text = "High Speed";
            this.chkhighSpeed.UseVisualStyleBackColor = true;
            // 
            // tbxHighSpeed
            // 
            this.tbxHighSpeed.Location = new System.Drawing.Point(224, 34);
            this.tbxHighSpeed.Name = "tbxHighSpeed";
            this.tbxHighSpeed.Size = new System.Drawing.Size(88, 21);
            this.tbxHighSpeed.TabIndex = 1;
            // 
            // btnStartMulti
            // 
            this.btnStartMulti.Location = new System.Drawing.Point(151, 393);
            this.btnStartMulti.Name = "btnStartMulti";
            this.btnStartMulti.Size = new System.Drawing.Size(88, 38);
            this.btnStartMulti.TabIndex = 2;
            this.btnStartMulti.Text = "Start Multi";
            this.btnStartMulti.UseVisualStyleBackColor = true;
            this.btnStartMulti.Click += new System.EventHandler(this.btnStartMulti_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(245, 393);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 38);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStartSingle
            // 
            this.btnStartSingle.Location = new System.Drawing.Point(57, 393);
            this.btnStartSingle.Name = "btnStartSingle";
            this.btnStartSingle.Size = new System.Drawing.Size(88, 38);
            this.btnStartSingle.TabIndex = 2;
            this.btnStartSingle.Text = "Start Single";
            this.btnStartSingle.UseVisualStyleBackColor = true;
            this.btnStartSingle.Click += new System.EventHandler(this.btnStartSingle_Click);
            // 
            // tbxPosition
            // 
            this.tbxPosition.Location = new System.Drawing.Point(150, 483);
            this.tbxPosition.Name = "tbxPosition";
            this.tbxPosition.Size = new System.Drawing.Size(88, 21);
            this.tbxPosition.TabIndex = 1;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(245, 473);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(88, 38);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(94, 486);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(50, 12);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Position";
            // 
            // FormAutoTorque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.tbxPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStartSingle);
            this.Controls.Add(this.btnStartMulti);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxAxisList);
            this.Name = "FormAutoTorque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox tbxTorque;
        private System.Windows.Forms.Label lblTorque;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTime;
        private System.Windows.Forms.CheckBox chkLowSpeed;
        private System.Windows.Forms.TextBox tbxTime;
        private System.Windows.Forms.TextBox tbxLowSpeed;
        private System.Windows.Forms.CheckBox chkhighSpeed;
        private System.Windows.Forms.TextBox tbxHighSpeed;
        private System.Windows.Forms.Button btnStartMulti;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnStartSingle;
        private System.Windows.Forms.TextBox tbxPosition;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label lblPosition;


    }
}