namespace EtherCAT_Examples_CSharp
{
    partial class formIxLine
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
            this.tbxDist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvwItem = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMoveStart = new System.Windows.Forms.Button();
            this.btnMoveToStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSpeedType = new System.Windows.Forms.ComboBox();
            this.lblSpeedMode = new System.Windows.Forms.Label();
            this.cbxSpeedMode = new System.Windows.Forms.ComboBox();
            this.tbxInit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxWork = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxAccel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDecel = new System.Windows.Forms.TextBox();
            this.tbxJerk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.cbxAxisList.Size = new System.Drawing.Size(151, 20);
            this.cbxAxisList.TabIndex = 19;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // tbxDist
            // 
            this.tbxDist.Location = new System.Drawing.Point(103, 42);
            this.tbxDist.Name = "tbxDist";
            this.tbxDist.Size = new System.Drawing.Size(151, 21);
            this.tbxDist.TabIndex = 21;
            this.tbxDist.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "Distance";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(280, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 47);
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
            this.lvwItem.HideSelection = false;
            this.lvwItem.Location = new System.Drawing.Point(373, 16);
            this.lvwItem.Name = "lvwItem";
            this.lvwItem.Size = new System.Drawing.Size(180, 100);
            this.lvwItem.TabIndex = 23;
            this.lvwItem.UseCompatibleStateImageBehavior = false;
            this.lvwItem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Axis";
            this.columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Distance";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(280, 69);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 47);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMoveStart
            // 
            this.btnMoveStart.Location = new System.Drawing.Point(280, 122);
            this.btnMoveStart.Name = "btnMoveStart";
            this.btnMoveStart.Size = new System.Drawing.Size(140, 97);
            this.btnMoveStart.TabIndex = 22;
            this.btnMoveStart.Text = "MoveStart";
            this.btnMoveStart.UseVisualStyleBackColor = true;
            this.btnMoveStart.Click += new System.EventHandler(this.btnMoveStart_Click);
            // 
            // btnMoveToStart
            // 
            this.btnMoveToStart.Location = new System.Drawing.Point(426, 122);
            this.btnMoveToStart.Name = "btnMoveToStart";
            this.btnMoveToStart.Size = new System.Drawing.Size(127, 97);
            this.btnMoveToStart.TabIndex = 22;
            this.btnMoveToStart.Text = "MoveToStart";
            this.btnMoveToStart.UseVisualStyleBackColor = true;
            this.btnMoveToStart.Click += new System.EventHandler(this.btnMoveToStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(426, 224);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(127, 100);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "IxSpeedType";
            // 
            // cbxSpeedType
            // 
            this.cbxSpeedType.FormattingEnabled = true;
            this.cbxSpeedType.Items.AddRange(new object[] {
            "Master",
            "Vector"});
            this.cbxSpeedType.Location = new System.Drawing.Point(133, 122);
            this.cbxSpeedType.Name = "cbxSpeedType";
            this.cbxSpeedType.Size = new System.Drawing.Size(121, 20);
            this.cbxSpeedType.TabIndex = 25;
            // 
            // lblSpeedMode
            // 
            this.lblSpeedMode.AutoSize = true;
            this.lblSpeedMode.Location = new System.Drawing.Point(38, 151);
            this.lblSpeedMode.Name = "lblSpeedMode";
            this.lblSpeedMode.Size = new System.Drawing.Size(73, 12);
            this.lblSpeedMode.TabIndex = 24;
            this.lblSpeedMode.Text = "SpeedMode";
            // 
            // cbxSpeedMode
            // 
            this.cbxSpeedMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxSpeedMode.FormattingEnabled = true;
            this.cbxSpeedMode.Items.AddRange(new object[] {
            "Constant",
            "Trapzoidal",
            "S-Curve"});
            this.cbxSpeedMode.Location = new System.Drawing.Point(133, 147);
            this.cbxSpeedMode.Name = "cbxSpeedMode";
            this.cbxSpeedMode.Size = new System.Drawing.Size(121, 20);
            this.cbxSpeedMode.TabIndex = 26;
            // 
            // tbxInit
            // 
            this.tbxInit.Location = new System.Drawing.Point(133, 172);
            this.tbxInit.Name = "tbxInit";
            this.tbxInit.Size = new System.Drawing.Size(121, 21);
            this.tbxInit.TabIndex = 27;
            this.tbxInit.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "InitSpeed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "EndSpeed";
            // 
            // tbxEnd
            // 
            this.tbxEnd.Location = new System.Drawing.Point(133, 198);
            this.tbxEnd.Name = "tbxEnd";
            this.tbxEnd.Size = new System.Drawing.Size(121, 21);
            this.tbxEnd.TabIndex = 27;
            this.tbxEnd.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "WorkSpeed";
            // 
            // tbxWork
            // 
            this.tbxWork.Location = new System.Drawing.Point(133, 224);
            this.tbxWork.Name = "tbxWork";
            this.tbxWork.Size = new System.Drawing.Size(121, 21);
            this.tbxWork.TabIndex = 27;
            this.tbxWork.Text = "100000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "Accel";
            // 
            // tbxAccel
            // 
            this.tbxAccel.Location = new System.Drawing.Point(133, 250);
            this.tbxAccel.Name = "tbxAccel";
            this.tbxAccel.Size = new System.Drawing.Size(121, 21);
            this.tbxAccel.TabIndex = 27;
            this.tbxAccel.Text = "1000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "Decel";
            // 
            // tbxDecel
            // 
            this.tbxDecel.Location = new System.Drawing.Point(133, 276);
            this.tbxDecel.Name = "tbxDecel";
            this.tbxDecel.Size = new System.Drawing.Size(121, 21);
            this.tbxDecel.TabIndex = 27;
            this.tbxDecel.Text = "1000000";
            // 
            // tbxJerk
            // 
            this.tbxJerk.Location = new System.Drawing.Point(133, 303);
            this.tbxJerk.Name = "tbxJerk";
            this.tbxJerk.Size = new System.Drawing.Size(121, 21);
            this.tbxJerk.TabIndex = 27;
            this.tbxJerk.Text = "0.66";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "Jerk";
            // 
            // formIxLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 351);
            this.Controls.Add(this.tbxJerk);
            this.Controls.Add(this.tbxDecel);
            this.Controls.Add(this.tbxAccel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxWork);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxInit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxSpeedMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSpeedMode);
            this.Controls.Add(this.cbxSpeedType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvwItem);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnMoveToStart);
            this.Controls.Add(this.btnMoveStart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxDist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxAxisList);
            this.Name = "formIxLine";
            this.Text = "IxLine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.TextBox tbxDist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvwItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMoveStart;
        private System.Windows.Forms.Button btnMoveToStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSpeedType;
        private System.Windows.Forms.Label lblSpeedMode;
        private System.Windows.Forms.ComboBox cbxSpeedMode;
        private System.Windows.Forms.TextBox tbxInit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxWork;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxAccel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxDecel;
        private System.Windows.Forms.TextBox tbxJerk;
        private System.Windows.Forms.Label label8;
    }
}