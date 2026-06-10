namespace EtherCAT_Examples_CSharp
{
    partial class formSD
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
            this.lblCh = new System.Windows.Forms.Label();
            this.cbxCh = new System.Windows.Forms.ComboBox();
            this.chkInvertLogic = new System.Windows.Forms.CheckBox();
            this.lblFilterCount = new System.Windows.Forms.Label();
            this.tbxFilterCount = new System.Windows.Forms.TextBox();
            this.lblOffset = new System.Windows.Forms.Label();
            this.tbxOffset = new System.Windows.Forms.TextBox();
            this.lblLatchMode = new System.Windows.Forms.Label();
            this.cbxLatchMode = new System.Windows.Forms.ComboBox();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnRestoreSpeed = new System.Windows.Forms.Button();
            this.btnIsInput = new System.Windows.Forms.Button();
            this.lblOffsetMode = new System.Windows.Forms.Label();
            this.cbxOffsetMode = new System.Windows.Forms.ComboBox();
            this.lblChType = new System.Windows.Forms.Label();
            this.cbxChType = new System.Windows.Forms.ComboBox();
            this.t_SD = new System.Windows.Forms.Timer(this.components);
            this.btnIsAct = new System.Windows.Forms.Button();
            this.tbxSpeed = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
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
            this.cbxAxisList.Location = new System.Drawing.Point(121, 16);
            this.cbxAxisList.Name = "cbxAxisList";
            this.cbxAxisList.Size = new System.Drawing.Size(103, 20);
            this.cbxAxisList.TabIndex = 19;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblCh
            // 
            this.lblCh.AutoSize = true;
            this.lblCh.Location = new System.Drawing.Point(38, 90);
            this.lblCh.Name = "lblCh";
            this.lblCh.Size = new System.Drawing.Size(52, 12);
            this.lblCh.TabIndex = 20;
            this.lblCh.Text = "Channel";
            // 
            // cbxCh
            // 
            this.cbxCh.FormattingEnabled = true;
            this.cbxCh.Location = new System.Drawing.Point(121, 87);
            this.cbxCh.Name = "cbxCh";
            this.cbxCh.Size = new System.Drawing.Size(103, 20);
            this.cbxCh.TabIndex = 19;
            this.cbxCh.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // chkInvertLogic
            // 
            this.chkInvertLogic.AutoSize = true;
            this.chkInvertLogic.Location = new System.Drawing.Point(135, 113);
            this.chkInvertLogic.Name = "chkInvertLogic";
            this.chkInvertLogic.Size = new System.Drawing.Size(89, 16);
            this.chkInvertLogic.TabIndex = 21;
            this.chkInvertLogic.Text = "Invert Logic";
            this.chkInvertLogic.UseVisualStyleBackColor = true;
            // 
            // lblFilterCount
            // 
            this.lblFilterCount.AutoSize = true;
            this.lblFilterCount.Location = new System.Drawing.Point(38, 141);
            this.lblFilterCount.Name = "lblFilterCount";
            this.lblFilterCount.Size = new System.Drawing.Size(65, 12);
            this.lblFilterCount.TabIndex = 20;
            this.lblFilterCount.Text = "FilterCount";
            // 
            // tbxFilterCount
            // 
            this.tbxFilterCount.Location = new System.Drawing.Point(121, 138);
            this.tbxFilterCount.Name = "tbxFilterCount";
            this.tbxFilterCount.Size = new System.Drawing.Size(103, 21);
            this.tbxFilterCount.TabIndex = 22;
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(38, 194);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(37, 12);
            this.lblOffset.TabIndex = 20;
            this.lblOffset.Text = "Offset";
            // 
            // tbxOffset
            // 
            this.tbxOffset.Location = new System.Drawing.Point(121, 191);
            this.tbxOffset.Name = "tbxOffset";
            this.tbxOffset.Size = new System.Drawing.Size(103, 21);
            this.tbxOffset.TabIndex = 22;
            // 
            // lblLatchMode
            // 
            this.lblLatchMode.AutoSize = true;
            this.lblLatchMode.Location = new System.Drawing.Point(38, 221);
            this.lblLatchMode.Name = "lblLatchMode";
            this.lblLatchMode.Size = new System.Drawing.Size(68, 12);
            this.lblLatchMode.TabIndex = 20;
            this.lblLatchMode.Text = "LatchMode";
            // 
            // cbxLatchMode
            // 
            this.cbxLatchMode.FormattingEnabled = true;
            this.cbxLatchMode.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.cbxLatchMode.Location = new System.Drawing.Point(121, 218);
            this.cbxLatchMode.Name = "cbxLatchMode";
            this.cbxLatchMode.Size = new System.Drawing.Size(103, 20);
            this.cbxLatchMode.TabIndex = 19;
            this.cbxLatchMode.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(40, 276);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(89, 44);
            this.btnEnable.TabIndex = 23;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(135, 276);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(89, 44);
            this.btnDisable.TabIndex = 23;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnRestoreSpeed
            // 
            this.btnRestoreSpeed.Location = new System.Drawing.Point(40, 326);
            this.btnRestoreSpeed.Name = "btnRestoreSpeed";
            this.btnRestoreSpeed.Size = new System.Drawing.Size(89, 44);
            this.btnRestoreSpeed.TabIndex = 23;
            this.btnRestoreSpeed.Text = "Restore\r\nSpeed";
            this.btnRestoreSpeed.UseVisualStyleBackColor = true;
            this.btnRestoreSpeed.Click += new System.EventHandler(this.btnRestoreSpeed_Click);
            // 
            // btnIsInput
            // 
            this.btnIsInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsInput.Location = new System.Drawing.Point(40, 376);
            this.btnIsInput.Name = "btnIsInput";
            this.btnIsInput.Size = new System.Drawing.Size(89, 44);
            this.btnIsInput.TabIndex = 23;
            this.btnIsInput.Text = "IsInput";
            this.btnIsInput.UseVisualStyleBackColor = true;
            // 
            // lblOffsetMode
            // 
            this.lblOffsetMode.AutoSize = true;
            this.lblOffsetMode.Location = new System.Drawing.Point(38, 168);
            this.lblOffsetMode.Name = "lblOffsetMode";
            this.lblOffsetMode.Size = new System.Drawing.Size(73, 12);
            this.lblOffsetMode.TabIndex = 20;
            this.lblOffsetMode.Text = "Offset Mode";
            // 
            // cbxOffsetMode
            // 
            this.cbxOffsetMode.FormattingEnabled = true;
            this.cbxOffsetMode.Location = new System.Drawing.Point(121, 165);
            this.cbxOffsetMode.Name = "cbxOffsetMode";
            this.cbxOffsetMode.Size = new System.Drawing.Size(103, 20);
            this.cbxOffsetMode.TabIndex = 19;
            this.cbxOffsetMode.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblChType
            // 
            this.lblChType.AutoSize = true;
            this.lblChType.Location = new System.Drawing.Point(38, 64);
            this.lblChType.Name = "lblChType";
            this.lblChType.Size = new System.Drawing.Size(81, 12);
            this.lblChType.TabIndex = 20;
            this.lblChType.Text = "ChannelType";
            // 
            // cbxChType
            // 
            this.cbxChType.FormattingEnabled = true;
            this.cbxChType.Items.AddRange(new object[] {
            "Global",
            "OnBoard"});
            this.cbxChType.Location = new System.Drawing.Point(121, 61);
            this.cbxChType.Name = "cbxChType";
            this.cbxChType.Size = new System.Drawing.Size(103, 20);
            this.cbxChType.TabIndex = 19;
            this.cbxChType.SelectedIndexChanged += new System.EventHandler(this.cbxChType_SelectedIndexChanged);
            // 
            // t_SD
            // 
            this.t_SD.Enabled = true;
            this.t_SD.Tick += new System.EventHandler(this.t_SD_Tick);
            // 
            // btnIsAct
            // 
            this.btnIsAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsAct.Location = new System.Drawing.Point(135, 376);
            this.btnIsAct.Name = "btnIsAct";
            this.btnIsAct.Size = new System.Drawing.Size(89, 44);
            this.btnIsAct.TabIndex = 23;
            this.btnIsAct.Text = "IsAct";
            this.btnIsAct.UseVisualStyleBackColor = true;
            // 
            // tbxSpeed
            // 
            this.tbxSpeed.Location = new System.Drawing.Point(121, 244);
            this.tbxSpeed.Name = "tbxSpeed";
            this.tbxSpeed.Size = new System.Drawing.Size(103, 21);
            this.tbxSpeed.TabIndex = 22;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(38, 247);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 12);
            this.lblSpeed.TabIndex = 20;
            this.lblSpeed.Text = "Speed";
            // 
            // FormSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 491);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnIsAct);
            this.Controls.Add(this.btnIsInput);
            this.Controls.Add(this.btnRestoreSpeed);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.tbxSpeed);
            this.Controls.Add(this.tbxOffset);
            this.Controls.Add(this.tbxFilterCount);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.chkInvertLogic);
            this.Controls.Add(this.lblLatchMode);
            this.Controls.Add(this.lblOffsetMode);
            this.Controls.Add(this.lblOffset);
            this.Controls.Add(this.lblFilterCount);
            this.Controls.Add(this.lblChType);
            this.Controls.Add(this.lblCh);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxOffsetMode);
            this.Controls.Add(this.cbxLatchMode);
            this.Controls.Add(this.cbxChType);
            this.Controls.Add(this.cbxCh);
            this.Controls.Add(this.cbxAxisList);
            this.Name = "FormSD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.Label lblCh;
        private System.Windows.Forms.ComboBox cbxCh;
        private System.Windows.Forms.CheckBox chkInvertLogic;
        private System.Windows.Forms.Label lblFilterCount;
        private System.Windows.Forms.TextBox tbxFilterCount;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.TextBox tbxOffset;
        private System.Windows.Forms.Label lblLatchMode;
        private System.Windows.Forms.ComboBox cbxLatchMode;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnRestoreSpeed;
        private System.Windows.Forms.Button btnIsInput;
        private System.Windows.Forms.Label lblOffsetMode;
        private System.Windows.Forms.ComboBox cbxOffsetMode;
        private System.Windows.Forms.Label lblChType;
        private System.Windows.Forms.ComboBox cbxChType;
        private System.Windows.Forms.Timer t_SD;
        private System.Windows.Forms.Button btnIsAct;
        private System.Windows.Forms.TextBox tbxSpeed;
        private System.Windows.Forms.Label lblSpeed;
    }
}