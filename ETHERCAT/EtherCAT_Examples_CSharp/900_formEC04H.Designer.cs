namespace EtherCAT_Examples_CSharp
{
    partial class formEC04H
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
            this.tabEC04H = new System.Windows.Forms.TabControl();
            this.tabCounter = new System.Windows.Forms.TabPage();
            this.tbxDefault_Z = new System.Windows.Forms.TextBox();
            this.pnlCounter = new System.Windows.Forms.Panel();
            this.tlpCounter = new System.Windows.Forms.TableLayoutPanel();
            this.lblDefault_AB_T = new System.Windows.Forms.Label();
            this.lblDefault_AB = new System.Windows.Forms.Label();
            this.lblRead_AB_T = new System.Windows.Forms.Label();
            this.lblRead_AB = new System.Windows.Forms.Label();
            this.lblDefault_Z_T = new System.Windows.Forms.Label();
            this.lbDefault_Z = new System.Windows.Forms.Label();
            this.lblRead_Z_T = new System.Windows.Forms.Label();
            this.lblRead_Z = new System.Windows.Forms.Label();
            this.tbxDefault_AB = new System.Windows.Forms.TextBox();
            this.lblCounterChannel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCounterChannel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAB_Enable = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnClear_AB = new System.Windows.Forms.Button();
            this.rdoDown = new System.Windows.Forms.RadioButton();
            this.cbxInputMode = new System.Windows.Forms.ComboBox();
            this.rdoUp = new System.Windows.Forms.RadioButton();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.btnClear_Z = new System.Windows.Forms.Button();
            this.chkFilterEnable = new System.Windows.Forms.CheckBox();
            this.chkInverse_A = new System.Windows.Forms.CheckBox();
            this.chkInverse_Z = new System.Windows.Forms.CheckBox();
            this.chkInverse_B = new System.Windows.Forms.CheckBox();
            this.tabLatch = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoReadMode_Manual = new System.Windows.Forms.RadioButton();
            this.rdoReadMode_Auto = new System.Windows.Forms.RadioButton();
            this.lvwLatch = new System.Windows.Forms.ListView();
            this.chIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCounter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLatchClear = new System.Windows.Forms.Button();
            this.chkLatch = new System.Windows.Forms.CheckBox();
            this.tbxLatchIndex = new System.Windows.Forms.TextBox();
            this.lblLatchManualIndex_T = new System.Windows.Forms.Label();
            this.pnlLatchMonitor = new System.Windows.Forms.Panel();
            this.tlpLatch = new System.Windows.Forms.TableLayoutPanel();
            this.lblLatch_Index_T = new System.Windows.Forms.Label();
            this.lblLatch_Count_T = new System.Windows.Forms.Label();
            this.lblLatchCounter = new System.Windows.Forms.Label();
            this.lblLatchIndex = new System.Windows.Forms.Label();
            this.lblEdgeMode = new System.Windows.Forms.Label();
            this.lblLatchCh = new System.Windows.Forms.Label();
            this.cbxEdge = new System.Windows.Forms.ComboBox();
            this.cbxLatchChannel = new System.Windows.Forms.ComboBox();
            this.tabCMP_EC04H = new System.Windows.Forms.TabPage();
            this.dgvCmp = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCMP = new System.Windows.Forms.Panel();
            this.tlpCMP_EC04H = new System.Windows.Forms.TableLayoutPanel();
            this.inPOD_CMP_Index_T = new System.Windows.Forms.Label();
            this.inPOD_CMP_Value_T = new System.Windows.Forms.Label();
            this.lblCmpValue = new System.Windows.Forms.Label();
            this.inPOD_CMP_ResponseTrg_T = new System.Windows.Forms.Label();
            this.lblRepsTrg = new System.Windows.Forms.Label();
            this.lblCmpIndex = new System.Windows.Forms.Label();
            this.btnSettingSave = new System.Windows.Forms.Button();
            this.btnCmpClear = new System.Windows.Forms.Button();
            this.btnCmpTest = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.chkCmpRepeat = new System.Windows.Forms.CheckBox();
            this.chkEnable_CMP = new System.Windows.Forms.CheckBox();
            this.tbxStartAddress = new System.Windows.Forms.TextBox();
            this.tbxCmpNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPulseWidth = new System.Windows.Forms.TextBox();
            this.lblCmpLogic_T = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxLogic_CMP = new System.Windows.Forms.ComboBox();
            this.cbxChannel_CMP = new System.Windows.Forms.ComboBox();
            this.t_EC04H = new System.Windows.Forms.Timer(this.components);
            this.tabEC04H.SuspendLayout();
            this.tabCounter.SuspendLayout();
            this.pnlCounter.SuspendLayout();
            this.tlpCounter.SuspendLayout();
            this.tabLatch.SuspendLayout();
            this.pnlLatchMonitor.SuspendLayout();
            this.tlpLatch.SuspendLayout();
            this.tabCMP_EC04H.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmp)).BeginInit();
            this.pnlCMP.SuspendLayout();
            this.tlpCMP_EC04H.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEC04H
            // 
            this.tabEC04H.Controls.Add(this.tabCounter);
            this.tabEC04H.Controls.Add(this.tabLatch);
            this.tabEC04H.Controls.Add(this.tabCMP_EC04H);
            this.tabEC04H.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEC04H.Location = new System.Drawing.Point(0, 0);
            this.tabEC04H.Name = "tabEC04H";
            this.tabEC04H.SelectedIndex = 0;
            this.tabEC04H.Size = new System.Drawing.Size(664, 322);
            this.tabEC04H.TabIndex = 2;
            // 
            // tabCounter
            // 
            this.tabCounter.Controls.Add(this.tbxDefault_Z);
            this.tabCounter.Controls.Add(this.pnlCounter);
            this.tabCounter.Controls.Add(this.tbxDefault_AB);
            this.tabCounter.Controls.Add(this.lblCounterChannel);
            this.tabCounter.Controls.Add(this.label2);
            this.tabCounter.Controls.Add(this.cbxCounterChannel);
            this.tabCounter.Controls.Add(this.label4);
            this.tabCounter.Controls.Add(this.chkAB_Enable);
            this.tabCounter.Controls.Add(this.label17);
            this.tabCounter.Controls.Add(this.btnClear_AB);
            this.tabCounter.Controls.Add(this.rdoDown);
            this.tabCounter.Controls.Add(this.cbxInputMode);
            this.tabCounter.Controls.Add(this.rdoUp);
            this.tabCounter.Controls.Add(this.cbxFilter);
            this.tabCounter.Controls.Add(this.btnClear_Z);
            this.tabCounter.Controls.Add(this.chkFilterEnable);
            this.tabCounter.Controls.Add(this.chkInverse_A);
            this.tabCounter.Controls.Add(this.chkInverse_Z);
            this.tabCounter.Controls.Add(this.chkInverse_B);
            this.tabCounter.Location = new System.Drawing.Point(4, 22);
            this.tabCounter.Name = "tabCounter";
            this.tabCounter.Padding = new System.Windows.Forms.Padding(3);
            this.tabCounter.Size = new System.Drawing.Size(656, 296);
            this.tabCounter.TabIndex = 0;
            this.tabCounter.Text = "Counter";
            this.tabCounter.UseVisualStyleBackColor = true;
            // 
            // tbxDefault_Z
            // 
            this.tbxDefault_Z.Location = new System.Drawing.Point(489, 113);
            this.tbxDefault_Z.Name = "tbxDefault_Z";
            this.tbxDefault_Z.Size = new System.Drawing.Size(120, 21);
            this.tbxDefault_Z.TabIndex = 7;
            this.tbxDefault_Z.TextChanged += new System.EventHandler(this.tbxDefault_Z_TextChanged);
            // 
            // pnlCounter
            // 
            this.pnlCounter.BackColor = System.Drawing.Color.SlateGray;
            this.pnlCounter.Controls.Add(this.tlpCounter);
            this.pnlCounter.Location = new System.Drawing.Point(30, 146);
            this.pnlCounter.Name = "pnlCounter";
            this.pnlCounter.Padding = new System.Windows.Forms.Padding(1);
            this.pnlCounter.Size = new System.Drawing.Size(244, 124);
            this.pnlCounter.TabIndex = 0;
            // 
            // tlpCounter
            // 
            this.tlpCounter.BackColor = System.Drawing.Color.White;
            this.tlpCounter.ColumnCount = 2;
            this.tlpCounter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpCounter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpCounter.Controls.Add(this.lblDefault_AB_T, 0, 0);
            this.tlpCounter.Controls.Add(this.lblDefault_AB, 1, 0);
            this.tlpCounter.Controls.Add(this.lblRead_AB_T, 0, 1);
            this.tlpCounter.Controls.Add(this.lblRead_AB, 1, 1);
            this.tlpCounter.Controls.Add(this.lblDefault_Z_T, 0, 2);
            this.tlpCounter.Controls.Add(this.lbDefault_Z, 1, 2);
            this.tlpCounter.Controls.Add(this.lblRead_Z_T, 0, 3);
            this.tlpCounter.Controls.Add(this.lblRead_Z, 1, 3);
            this.tlpCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCounter.Location = new System.Drawing.Point(1, 1);
            this.tlpCounter.Name = "tlpCounter";
            this.tlpCounter.RowCount = 4;
            this.tlpCounter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCounter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCounter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCounter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCounter.Size = new System.Drawing.Size(242, 122);
            this.tlpCounter.TabIndex = 2;
            // 
            // lblDefault_AB_T
            // 
            this.lblDefault_AB_T.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDefault_AB_T.AutoSize = true;
            this.lblDefault_AB_T.Location = new System.Drawing.Point(3, 0);
            this.lblDefault_AB_T.Name = "lblDefault_AB_T";
            this.lblDefault_AB_T.Size = new System.Drawing.Size(90, 30);
            this.lblDefault_AB_T.TabIndex = 0;
            this.lblDefault_AB_T.Text = "Default_AB";
            this.lblDefault_AB_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDefault_AB
            // 
            this.lblDefault_AB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDefault_AB.AutoSize = true;
            this.lblDefault_AB.Location = new System.Drawing.Point(99, 0);
            this.lblDefault_AB.Name = "lblDefault_AB";
            this.lblDefault_AB.Size = new System.Drawing.Size(140, 30);
            this.lblDefault_AB.TabIndex = 0;
            this.lblDefault_AB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRead_AB_T
            // 
            this.lblRead_AB_T.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRead_AB_T.AutoSize = true;
            this.lblRead_AB_T.Location = new System.Drawing.Point(3, 30);
            this.lblRead_AB_T.Name = "lblRead_AB_T";
            this.lblRead_AB_T.Size = new System.Drawing.Size(90, 30);
            this.lblRead_AB_T.TabIndex = 0;
            this.lblRead_AB_T.Text = "Read_AB";
            this.lblRead_AB_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRead_AB
            // 
            this.lblRead_AB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRead_AB.AutoSize = true;
            this.lblRead_AB.Location = new System.Drawing.Point(99, 30);
            this.lblRead_AB.Name = "lblRead_AB";
            this.lblRead_AB.Size = new System.Drawing.Size(140, 30);
            this.lblRead_AB.TabIndex = 0;
            this.lblRead_AB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDefault_Z_T
            // 
            this.lblDefault_Z_T.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDefault_Z_T.AutoSize = true;
            this.lblDefault_Z_T.Location = new System.Drawing.Point(3, 60);
            this.lblDefault_Z_T.Name = "lblDefault_Z_T";
            this.lblDefault_Z_T.Size = new System.Drawing.Size(90, 30);
            this.lblDefault_Z_T.TabIndex = 0;
            this.lblDefault_Z_T.Text = "Default_Z";
            this.lblDefault_Z_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDefault_Z
            // 
            this.lbDefault_Z.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDefault_Z.AutoSize = true;
            this.lbDefault_Z.Location = new System.Drawing.Point(99, 60);
            this.lbDefault_Z.Name = "lbDefault_Z";
            this.lbDefault_Z.Size = new System.Drawing.Size(140, 30);
            this.lbDefault_Z.TabIndex = 0;
            this.lbDefault_Z.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRead_Z_T
            // 
            this.lblRead_Z_T.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRead_Z_T.AutoSize = true;
            this.lblRead_Z_T.Location = new System.Drawing.Point(3, 90);
            this.lblRead_Z_T.Name = "lblRead_Z_T";
            this.lblRead_Z_T.Size = new System.Drawing.Size(90, 32);
            this.lblRead_Z_T.TabIndex = 0;
            this.lblRead_Z_T.Text = "Read_Z";
            this.lblRead_Z_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRead_Z
            // 
            this.lblRead_Z.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRead_Z.AutoSize = true;
            this.lblRead_Z.Location = new System.Drawing.Point(99, 90);
            this.lblRead_Z.Name = "lblRead_Z";
            this.lblRead_Z.Size = new System.Drawing.Size(140, 32);
            this.lblRead_Z.TabIndex = 0;
            this.lblRead_Z.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxDefault_AB
            // 
            this.tbxDefault_AB.Location = new System.Drawing.Point(489, 50);
            this.tbxDefault_AB.Name = "tbxDefault_AB";
            this.tbxDefault_AB.Size = new System.Drawing.Size(120, 21);
            this.tbxDefault_AB.TabIndex = 7;
            this.tbxDefault_AB.TextChanged += new System.EventHandler(this.tbxDefault_AB_TextChanged);
            // 
            // lblCounterChannel
            // 
            this.lblCounterChannel.AutoSize = true;
            this.lblCounterChannel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCounterChannel.Location = new System.Drawing.Point(28, 26);
            this.lblCounterChannel.Name = "lblCounterChannel";
            this.lblCounterChannel.Size = new System.Drawing.Size(52, 12);
            this.lblCounterChannel.TabIndex = 0;
            this.lblCounterChannel.Text = "Channel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Default_Z";
            // 
            // cbxCounterChannel
            // 
            this.cbxCounterChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCounterChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCounterChannel.FormattingEnabled = true;
            this.cbxCounterChannel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbxCounterChannel.Location = new System.Drawing.Point(97, 21);
            this.cbxCounterChannel.Name = "cbxCounterChannel";
            this.cbxCounterChannel.Size = new System.Drawing.Size(177, 20);
            this.cbxCounterChannel.TabIndex = 1;
            this.cbxCounterChannel.SelectedIndexChanged += new System.EventHandler(this.cbxCounterChannel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Input Mode";
            // 
            // chkAB_Enable
            // 
            this.chkAB_Enable.AutoSize = true;
            this.chkAB_Enable.Location = new System.Drawing.Point(30, 115);
            this.chkAB_Enable.Name = "chkAB_Enable";
            this.chkAB_Enable.Size = new System.Drawing.Size(89, 16);
            this.chkAB_Enable.TabIndex = 3;
            this.chkAB_Enable.Text = "A/B Enable";
            this.chkAB_Enable.UseVisualStyleBackColor = true;
            this.chkAB_Enable.CheckedChanged += new System.EventHandler(this.chkAB_Enable_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(544, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 6;
            this.label17.Text = "Default_AB";
            // 
            // btnClear_AB
            // 
            this.btnClear_AB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear_AB.Location = new System.Drawing.Point(348, 21);
            this.btnClear_AB.Name = "btnClear_AB";
            this.btnClear_AB.Size = new System.Drawing.Size(100, 50);
            this.btnClear_AB.TabIndex = 4;
            this.btnClear_AB.Text = "A/B Clear";
            this.btnClear_AB.UseVisualStyleBackColor = true;
            this.btnClear_AB.Click += new System.EventHandler(this.btnClear_AB_Click);
            // 
            // rdoDown
            // 
            this.rdoDown.AutoSize = true;
            this.rdoDown.Location = new System.Drawing.Point(489, 161);
            this.rdoDown.Name = "rdoDown";
            this.rdoDown.Size = new System.Drawing.Size(112, 16);
            this.rdoDown.TabIndex = 5;
            this.rdoDown.TabStop = true;
            this.rdoDown.Text = "Direction  Down";
            this.rdoDown.UseVisualStyleBackColor = true;
            this.rdoDown.CheckedChanged += new System.EventHandler(this.rdoDown_CheckedChanged);
            // 
            // cbxInputMode
            // 
            this.cbxInputMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInputMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxInputMode.FormattingEnabled = true;
            this.cbxInputMode.Items.AddRange(new object[] {
            "A/B x4",
            "A/B x2",
            "A/B x1",
            "Pulse/Dir",
            "CW/CCW"});
            this.cbxInputMode.Location = new System.Drawing.Point(138, 50);
            this.cbxInputMode.Name = "cbxInputMode";
            this.cbxInputMode.Size = new System.Drawing.Size(136, 20);
            this.cbxInputMode.TabIndex = 1;
            this.cbxInputMode.SelectedIndexChanged += new System.EventHandler(this.cbxInputMode_SelectedIndexChanged);
            // 
            // rdoUp
            // 
            this.rdoUp.AutoSize = true;
            this.rdoUp.Location = new System.Drawing.Point(349, 161);
            this.rdoUp.Name = "rdoUp";
            this.rdoUp.Size = new System.Drawing.Size(99, 16);
            this.rdoUp.TabIndex = 5;
            this.rdoUp.TabStop = true;
            this.rdoUp.Text = "Direction : Up";
            this.rdoUp.UseVisualStyleBackColor = true;
            this.rdoUp.CheckedChanged += new System.EventHandler(this.rdoUp_CheckedChanged);
            // 
            // cbxFilter
            // 
            this.cbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Items.AddRange(new object[] {
            "1 Clk",
            "2 Clk",
            "4 Clk",
            "8 Clk",
            "16 Clk",
            "32 Clk",
            "64 Clk",
            "128 Clk"});
            this.cbxFilter.Location = new System.Drawing.Point(160, 82);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(114, 20);
            this.cbxFilter.TabIndex = 1;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // btnClear_Z
            // 
            this.btnClear_Z.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear_Z.Location = new System.Drawing.Point(348, 84);
            this.btnClear_Z.Name = "btnClear_Z";
            this.btnClear_Z.Size = new System.Drawing.Size(100, 50);
            this.btnClear_Z.TabIndex = 4;
            this.btnClear_Z.Text = "Z Clear";
            this.btnClear_Z.UseVisualStyleBackColor = true;
            this.btnClear_Z.Click += new System.EventHandler(this.btnClear_Z_Click);
            // 
            // chkFilterEnable
            // 
            this.chkFilterEnable.AutoSize = true;
            this.chkFilterEnable.Location = new System.Drawing.Point(30, 84);
            this.chkFilterEnable.Name = "chkFilterEnable";
            this.chkFilterEnable.Size = new System.Drawing.Size(94, 16);
            this.chkFilterEnable.TabIndex = 3;
            this.chkFilterEnable.Text = "Filter Enable";
            this.chkFilterEnable.UseVisualStyleBackColor = true;
            this.chkFilterEnable.CheckedChanged += new System.EventHandler(this.chkFilterEnable_CheckedChanged);
            // 
            // chkInverse_A
            // 
            this.chkInverse_A.AutoSize = true;
            this.chkInverse_A.Location = new System.Drawing.Point(348, 207);
            this.chkInverse_A.Name = "chkInverse_A";
            this.chkInverse_A.Size = new System.Drawing.Size(117, 16);
            this.chkInverse_A.TabIndex = 3;
            this.chkInverse_A.Text = "A Phase Inverse";
            this.chkInverse_A.UseVisualStyleBackColor = true;
            this.chkInverse_A.CheckedChanged += new System.EventHandler(this.chkInverse_A_CheckedChanged);
            // 
            // chkInverse_Z
            // 
            this.chkInverse_Z.AutoSize = true;
            this.chkInverse_Z.Location = new System.Drawing.Point(348, 253);
            this.chkInverse_Z.Name = "chkInverse_Z";
            this.chkInverse_Z.Size = new System.Drawing.Size(117, 16);
            this.chkInverse_Z.TabIndex = 3;
            this.chkInverse_Z.Text = "Z Phase Inverse";
            this.chkInverse_Z.UseVisualStyleBackColor = true;
            this.chkInverse_Z.Click += new System.EventHandler(this.chkInverse_Z_CheckedChanged);
            // 
            // chkInverse_B
            // 
            this.chkInverse_B.AutoSize = true;
            this.chkInverse_B.Location = new System.Drawing.Point(348, 231);
            this.chkInverse_B.Name = "chkInverse_B";
            this.chkInverse_B.Size = new System.Drawing.Size(117, 16);
            this.chkInverse_B.TabIndex = 3;
            this.chkInverse_B.Text = "B Phase Inverse";
            this.chkInverse_B.UseVisualStyleBackColor = true;
            this.chkInverse_B.Click += new System.EventHandler(this.chkInverse_B_CheckedChanged);
            // 
            // tabLatch
            // 
            this.tabLatch.Controls.Add(this.label1);
            this.tabLatch.Controls.Add(this.rdoReadMode_Manual);
            this.tabLatch.Controls.Add(this.rdoReadMode_Auto);
            this.tabLatch.Controls.Add(this.lvwLatch);
            this.tabLatch.Controls.Add(this.btnLatchClear);
            this.tabLatch.Controls.Add(this.chkLatch);
            this.tabLatch.Controls.Add(this.tbxLatchIndex);
            this.tabLatch.Controls.Add(this.lblLatchManualIndex_T);
            this.tabLatch.Controls.Add(this.pnlLatchMonitor);
            this.tabLatch.Controls.Add(this.lblEdgeMode);
            this.tabLatch.Controls.Add(this.lblLatchCh);
            this.tabLatch.Controls.Add(this.cbxEdge);
            this.tabLatch.Controls.Add(this.cbxLatchChannel);
            this.tabLatch.Location = new System.Drawing.Point(4, 22);
            this.tabLatch.Name = "tabLatch";
            this.tabLatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabLatch.Size = new System.Drawing.Size(656, 296);
            this.tabLatch.TabIndex = 1;
            this.tabLatch.Text = "Latch";
            this.tabLatch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "LatchCounter On AutoMode";
            // 
            // rdoReadMode_Manual
            // 
            this.rdoReadMode_Manual.AutoSize = true;
            this.rdoReadMode_Manual.Location = new System.Drawing.Point(36, 78);
            this.rdoReadMode_Manual.Name = "rdoReadMode_Manual";
            this.rdoReadMode_Manual.Size = new System.Drawing.Size(138, 16);
            this.rdoReadMode_Manual.TabIndex = 18;
            this.rdoReadMode_Manual.TabStop = true;
            this.rdoReadMode_Manual.Text = "ReadMode : Manual";
            this.rdoReadMode_Manual.UseVisualStyleBackColor = true;
            this.rdoReadMode_Manual.CheckedChanged += new System.EventHandler(this.rdoReadMode_Manual_CheckedChanged);
            // 
            // rdoReadMode_Auto
            // 
            this.rdoReadMode_Auto.AutoSize = true;
            this.rdoReadMode_Auto.Location = new System.Drawing.Point(36, 100);
            this.rdoReadMode_Auto.Name = "rdoReadMode_Auto";
            this.rdoReadMode_Auto.Size = new System.Drawing.Size(121, 16);
            this.rdoReadMode_Auto.TabIndex = 17;
            this.rdoReadMode_Auto.TabStop = true;
            this.rdoReadMode_Auto.Text = "ReadMode : Auto";
            this.rdoReadMode_Auto.UseVisualStyleBackColor = true;
            this.rdoReadMode_Auto.CheckedChanged += new System.EventHandler(this.rdoReadMode_Auto_CheckedChanged);
            // 
            // lvwLatch
            // 
            this.lvwLatch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIndex,
            this.chCounter});
            this.lvwLatch.GridLines = true;
            this.lvwLatch.HideSelection = false;
            this.lvwLatch.Location = new System.Drawing.Point(359, 115);
            this.lvwLatch.Name = "lvwLatch";
            this.lvwLatch.Size = new System.Drawing.Size(244, 150);
            this.lvwLatch.TabIndex = 16;
            this.lvwLatch.UseCompatibleStateImageBehavior = false;
            this.lvwLatch.View = System.Windows.Forms.View.Details;
            // 
            // chIndex
            // 
            this.chIndex.Text = "Index";
            // 
            // chCounter
            // 
            this.chCounter.Text = "LatchCounter";
            this.chCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCounter.Width = 150;
            // 
            // btnLatchClear
            // 
            this.btnLatchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLatchClear.Location = new System.Drawing.Point(479, 18);
            this.btnLatchClear.Name = "btnLatchClear";
            this.btnLatchClear.Size = new System.Drawing.Size(124, 50);
            this.btnLatchClear.TabIndex = 15;
            this.btnLatchClear.Text = "Latch Clear";
            this.btnLatchClear.UseVisualStyleBackColor = true;
            this.btnLatchClear.Click += new System.EventHandler(this.btnLatchClear_Click);
            // 
            // chkLatch
            // 
            this.chkLatch.AutoSize = true;
            this.chkLatch.Location = new System.Drawing.Point(36, 44);
            this.chkLatch.Name = "chkLatch";
            this.chkLatch.Size = new System.Drawing.Size(98, 16);
            this.chkLatch.TabIndex = 14;
            this.chkLatch.Text = "Latch Enable";
            this.chkLatch.UseVisualStyleBackColor = true;
            this.chkLatch.CheckedChanged += new System.EventHandler(this.chkLatch_CheckedChanged);
            // 
            // tbxLatchIndex
            // 
            this.tbxLatchIndex.Location = new System.Drawing.Point(140, 173);
            this.tbxLatchIndex.Name = "tbxLatchIndex";
            this.tbxLatchIndex.Size = new System.Drawing.Size(139, 21);
            this.tbxLatchIndex.TabIndex = 13;
            this.tbxLatchIndex.TextChanged += new System.EventHandler(this.tbxLatchIndex_TextChanged);
            // 
            // lblLatchManualIndex_T
            // 
            this.lblLatchManualIndex_T.AutoSize = true;
            this.lblLatchManualIndex_T.Location = new System.Drawing.Point(45, 179);
            this.lblLatchManualIndex_T.Name = "lblLatchManualIndex_T";
            this.lblLatchManualIndex_T.Size = new System.Drawing.Size(82, 12);
            this.lblLatchManualIndex_T.TabIndex = 12;
            this.lblLatchManualIndex_T.Text = "Manual Index";
            // 
            // pnlLatchMonitor
            // 
            this.pnlLatchMonitor.BackColor = System.Drawing.Color.SlateGray;
            this.pnlLatchMonitor.Controls.Add(this.tlpLatch);
            this.pnlLatchMonitor.Location = new System.Drawing.Point(36, 214);
            this.pnlLatchMonitor.Name = "pnlLatchMonitor";
            this.pnlLatchMonitor.Padding = new System.Windows.Forms.Padding(1);
            this.pnlLatchMonitor.Size = new System.Drawing.Size(247, 52);
            this.pnlLatchMonitor.TabIndex = 8;
            // 
            // tlpLatch
            // 
            this.tlpLatch.BackColor = System.Drawing.Color.White;
            this.tlpLatch.ColumnCount = 2;
            this.tlpLatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpLatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpLatch.Controls.Add(this.lblLatch_Index_T, 0, 0);
            this.tlpLatch.Controls.Add(this.lblLatch_Count_T, 0, 1);
            this.tlpLatch.Controls.Add(this.lblLatchCounter, 1, 1);
            this.tlpLatch.Controls.Add(this.lblLatchIndex, 1, 0);
            this.tlpLatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLatch.Location = new System.Drawing.Point(1, 1);
            this.tlpLatch.Name = "tlpLatch";
            this.tlpLatch.RowCount = 2;
            this.tlpLatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLatch.Size = new System.Drawing.Size(245, 50);
            this.tlpLatch.TabIndex = 2;
            // 
            // lblLatch_Index_T
            // 
            this.lblLatch_Index_T.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLatch_Index_T.AutoSize = true;
            this.lblLatch_Index_T.Location = new System.Drawing.Point(3, 0);
            this.lblLatch_Index_T.Name = "lblLatch_Index_T";
            this.lblLatch_Index_T.Size = new System.Drawing.Size(92, 25);
            this.lblLatch_Index_T.TabIndex = 0;
            this.lblLatch_Index_T.Text = "Index";
            this.lblLatch_Index_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLatch_Count_T
            // 
            this.lblLatch_Count_T.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLatch_Count_T.AutoSize = true;
            this.lblLatch_Count_T.Location = new System.Drawing.Point(3, 25);
            this.lblLatch_Count_T.Name = "lblLatch_Count_T";
            this.lblLatch_Count_T.Size = new System.Drawing.Size(92, 25);
            this.lblLatch_Count_T.TabIndex = 0;
            this.lblLatch_Count_T.Text = "Counter_Value";
            this.lblLatch_Count_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLatchCounter
            // 
            this.lblLatchCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLatchCounter.AutoSize = true;
            this.lblLatchCounter.Location = new System.Drawing.Point(101, 25);
            this.lblLatchCounter.Name = "lblLatchCounter";
            this.lblLatchCounter.Size = new System.Drawing.Size(141, 25);
            this.lblLatchCounter.TabIndex = 0;
            this.lblLatchCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLatchIndex
            // 
            this.lblLatchIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLatchIndex.AutoSize = true;
            this.lblLatchIndex.Location = new System.Drawing.Point(101, 0);
            this.lblLatchIndex.Name = "lblLatchIndex";
            this.lblLatchIndex.Size = new System.Drawing.Size(141, 25);
            this.lblLatchIndex.TabIndex = 0;
            this.lblLatchIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEdgeMode
            // 
            this.lblEdgeMode.AutoSize = true;
            this.lblEdgeMode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEdgeMode.Location = new System.Drawing.Point(44, 138);
            this.lblEdgeMode.Name = "lblEdgeMode";
            this.lblEdgeMode.Size = new System.Drawing.Size(66, 12);
            this.lblEdgeMode.TabIndex = 7;
            this.lblEdgeMode.Text = "EdgeMode";
            // 
            // lblLatchCh
            // 
            this.lblLatchCh.AutoSize = true;
            this.lblLatchCh.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLatchCh.Location = new System.Drawing.Point(34, 23);
            this.lblLatchCh.Name = "lblLatchCh";
            this.lblLatchCh.Size = new System.Drawing.Size(52, 12);
            this.lblLatchCh.TabIndex = 7;
            this.lblLatchCh.Text = "Channel";
            // 
            // cbxEdge
            // 
            this.cbxEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEdge.FormattingEnabled = true;
            this.cbxEdge.Items.AddRange(new object[] {
            "None",
            "Falling Edge",
            "Rising Edge",
            "Edge"});
            this.cbxEdge.Location = new System.Drawing.Point(139, 135);
            this.cbxEdge.Name = "cbxEdge";
            this.cbxEdge.Size = new System.Drawing.Size(143, 20);
            this.cbxEdge.TabIndex = 11;
            this.cbxEdge.SelectedIndexChanged += new System.EventHandler(this.cbxEdge_SelectedIndexChanged);
            // 
            // cbxLatchChannel
            // 
            this.cbxLatchChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLatchChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxLatchChannel.FormattingEnabled = true;
            this.cbxLatchChannel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbxLatchChannel.Location = new System.Drawing.Point(139, 18);
            this.cbxLatchChannel.Name = "cbxLatchChannel";
            this.cbxLatchChannel.Size = new System.Drawing.Size(140, 20);
            this.cbxLatchChannel.TabIndex = 11;
            this.cbxLatchChannel.SelectedIndexChanged += new System.EventHandler(this.cbxLatchChannel_SelectedIndexChanged);
            // 
            // tabCMP_EC04H
            // 
            this.tabCMP_EC04H.Controls.Add(this.dgvCmp);
            this.tabCMP_EC04H.Controls.Add(this.pnlCMP);
            this.tabCMP_EC04H.Controls.Add(this.btnSettingSave);
            this.tabCMP_EC04H.Controls.Add(this.btnCmpClear);
            this.tabCMP_EC04H.Controls.Add(this.btnCmpTest);
            this.tabCMP_EC04H.Controls.Add(this.btnWrite);
            this.tabCMP_EC04H.Controls.Add(this.chkCmpRepeat);
            this.tabCMP_EC04H.Controls.Add(this.chkEnable_CMP);
            this.tabCMP_EC04H.Controls.Add(this.tbxStartAddress);
            this.tabCMP_EC04H.Controls.Add(this.tbxCmpNumber);
            this.tabCMP_EC04H.Controls.Add(this.label6);
            this.tabCMP_EC04H.Controls.Add(this.label5);
            this.tabCMP_EC04H.Controls.Add(this.tbxPulseWidth);
            this.tabCMP_EC04H.Controls.Add(this.lblCmpLogic_T);
            this.tabCMP_EC04H.Controls.Add(this.label3);
            this.tabCMP_EC04H.Controls.Add(this.label10);
            this.tabCMP_EC04H.Controls.Add(this.cbxLogic_CMP);
            this.tabCMP_EC04H.Controls.Add(this.cbxChannel_CMP);
            this.tabCMP_EC04H.Location = new System.Drawing.Point(4, 22);
            this.tabCMP_EC04H.Name = "tabCMP_EC04H";
            this.tabCMP_EC04H.Padding = new System.Windows.Forms.Padding(3);
            this.tabCMP_EC04H.Size = new System.Drawing.Size(656, 296);
            this.tabCMP_EC04H.TabIndex = 2;
            this.tabCMP_EC04H.Text = "CMP";
            this.tabCMP_EC04H.UseVisualStyleBackColor = true;
            // 
            // dgvCmp
            // 
            this.dgvCmp.AllowUserToAddRows = false;
            this.dgvCmp.AllowUserToDeleteRows = false;
            this.dgvCmp.AllowUserToResizeColumns = false;
            this.dgvCmp.AllowUserToResizeRows = false;
            this.dgvCmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Value});
            this.dgvCmp.Location = new System.Drawing.Point(278, 18);
            this.dgvCmp.Name = "dgvCmp";
            this.dgvCmp.RowHeadersVisible = false;
            this.dgvCmp.RowTemplate.Height = 23;
            this.dgvCmp.Size = new System.Drawing.Size(165, 260);
            this.dgvCmp.TabIndex = 29;
            // 
            // No
            // 
            this.No.Frozen = true;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No.Width = 30;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pnlCMP
            // 
            this.pnlCMP.BackColor = System.Drawing.Color.SlateGray;
            this.pnlCMP.Controls.Add(this.tlpCMP_EC04H);
            this.pnlCMP.Location = new System.Drawing.Point(35, 178);
            this.pnlCMP.Name = "pnlCMP";
            this.pnlCMP.Padding = new System.Windows.Forms.Padding(1);
            this.pnlCMP.Size = new System.Drawing.Size(197, 100);
            this.pnlCMP.TabIndex = 28;
            // 
            // tlpCMP_EC04H
            // 
            this.tlpCMP_EC04H.BackColor = System.Drawing.Color.White;
            this.tlpCMP_EC04H.ColumnCount = 2;
            this.tlpCMP_EC04H.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpCMP_EC04H.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpCMP_EC04H.Controls.Add(this.inPOD_CMP_Index_T, 0, 0);
            this.tlpCMP_EC04H.Controls.Add(this.inPOD_CMP_Value_T, 0, 1);
            this.tlpCMP_EC04H.Controls.Add(this.lblCmpValue, 1, 1);
            this.tlpCMP_EC04H.Controls.Add(this.inPOD_CMP_ResponseTrg_T, 0, 2);
            this.tlpCMP_EC04H.Controls.Add(this.lblRepsTrg, 1, 2);
            this.tlpCMP_EC04H.Controls.Add(this.lblCmpIndex, 1, 0);
            this.tlpCMP_EC04H.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCMP_EC04H.Location = new System.Drawing.Point(1, 1);
            this.tlpCMP_EC04H.Name = "tlpCMP_EC04H";
            this.tlpCMP_EC04H.RowCount = 3;
            this.tlpCMP_EC04H.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpCMP_EC04H.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpCMP_EC04H.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpCMP_EC04H.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCMP_EC04H.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCMP_EC04H.Size = new System.Drawing.Size(195, 98);
            this.tlpCMP_EC04H.TabIndex = 2;
            // 
            // inPOD_CMP_Index_T
            // 
            this.inPOD_CMP_Index_T.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inPOD_CMP_Index_T.AutoSize = true;
            this.inPOD_CMP_Index_T.Location = new System.Drawing.Point(3, 0);
            this.inPOD_CMP_Index_T.Name = "inPOD_CMP_Index_T";
            this.inPOD_CMP_Index_T.Size = new System.Drawing.Size(72, 32);
            this.inPOD_CMP_Index_T.TabIndex = 0;
            this.inPOD_CMP_Index_T.Text = "Index";
            this.inPOD_CMP_Index_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inPOD_CMP_Value_T
            // 
            this.inPOD_CMP_Value_T.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inPOD_CMP_Value_T.AutoSize = true;
            this.inPOD_CMP_Value_T.Location = new System.Drawing.Point(3, 32);
            this.inPOD_CMP_Value_T.Name = "inPOD_CMP_Value_T";
            this.inPOD_CMP_Value_T.Size = new System.Drawing.Size(72, 32);
            this.inPOD_CMP_Value_T.TabIndex = 0;
            this.inPOD_CMP_Value_T.Text = "Value";
            this.inPOD_CMP_Value_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCmpValue
            // 
            this.lblCmpValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCmpValue.AutoSize = true;
            this.lblCmpValue.Location = new System.Drawing.Point(81, 32);
            this.lblCmpValue.Name = "lblCmpValue";
            this.lblCmpValue.Size = new System.Drawing.Size(111, 32);
            this.lblCmpValue.TabIndex = 0;
            this.lblCmpValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inPOD_CMP_ResponseTrg_T
            // 
            this.inPOD_CMP_ResponseTrg_T.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inPOD_CMP_ResponseTrg_T.AutoSize = true;
            this.inPOD_CMP_ResponseTrg_T.Location = new System.Drawing.Point(3, 64);
            this.inPOD_CMP_ResponseTrg_T.Name = "inPOD_CMP_ResponseTrg_T";
            this.inPOD_CMP_ResponseTrg_T.Size = new System.Drawing.Size(72, 34);
            this.inPOD_CMP_ResponseTrg_T.TabIndex = 0;
            this.inPOD_CMP_ResponseTrg_T.Text = "Reps.Trg";
            this.inPOD_CMP_ResponseTrg_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRepsTrg
            // 
            this.lblRepsTrg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRepsTrg.AutoSize = true;
            this.lblRepsTrg.Location = new System.Drawing.Point(81, 64);
            this.lblRepsTrg.Name = "lblRepsTrg";
            this.lblRepsTrg.Size = new System.Drawing.Size(111, 34);
            this.lblRepsTrg.TabIndex = 0;
            this.lblRepsTrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCmpIndex
            // 
            this.lblCmpIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCmpIndex.AutoSize = true;
            this.lblCmpIndex.Location = new System.Drawing.Point(81, 0);
            this.lblCmpIndex.Name = "lblCmpIndex";
            this.lblCmpIndex.Size = new System.Drawing.Size(111, 32);
            this.lblCmpIndex.TabIndex = 0;
            this.lblCmpIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSettingSave
            // 
            this.btnSettingSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingSave.Location = new System.Drawing.Point(477, 242);
            this.btnSettingSave.Name = "btnSettingSave";
            this.btnSettingSave.Size = new System.Drawing.Size(139, 35);
            this.btnSettingSave.TabIndex = 27;
            this.btnSettingSave.Text = "Setting Save";
            this.btnSettingSave.UseVisualStyleBackColor = true;
            this.btnSettingSave.Click += new System.EventHandler(this.btnSettingSave_Click);
            // 
            // btnCmpClear
            // 
            this.btnCmpClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCmpClear.Location = new System.Drawing.Point(126, 133);
            this.btnCmpClear.Name = "btnCmpClear";
            this.btnCmpClear.Size = new System.Drawing.Size(106, 28);
            this.btnCmpClear.TabIndex = 27;
            this.btnCmpClear.Text = "Clear";
            this.btnCmpClear.UseVisualStyleBackColor = true;
            this.btnCmpClear.Click += new System.EventHandler(this.btnCmpClear_Click);
            // 
            // btnCmpTest
            // 
            this.btnCmpTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCmpTest.Location = new System.Drawing.Point(477, 156);
            this.btnCmpTest.Name = "btnCmpTest";
            this.btnCmpTest.Size = new System.Drawing.Size(139, 35);
            this.btnCmpTest.TabIndex = 27;
            this.btnCmpTest.Text = "Test";
            this.btnCmpTest.UseVisualStyleBackColor = true;
            this.btnCmpTest.Click += new System.EventHandler(this.btnCmpTest_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrite.Location = new System.Drawing.Point(477, 113);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(139, 35);
            this.btnWrite.TabIndex = 27;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // chkCmpRepeat
            // 
            this.chkCmpRepeat.AutoSize = true;
            this.chkCmpRepeat.Location = new System.Drawing.Point(137, 45);
            this.chkCmpRepeat.Name = "chkCmpRepeat";
            this.chkCmpRepeat.Size = new System.Drawing.Size(95, 16);
            this.chkCmpRepeat.TabIndex = 26;
            this.chkCmpRepeat.Text = "CMP Repeat";
            this.chkCmpRepeat.UseVisualStyleBackColor = true;
            this.chkCmpRepeat.CheckedChanged += new System.EventHandler(this.chkCmpRepeat_CheckedChanged);
            // 
            // chkEnable_CMP
            // 
            this.chkEnable_CMP.AutoSize = true;
            this.chkEnable_CMP.Location = new System.Drawing.Point(35, 45);
            this.chkEnable_CMP.Name = "chkEnable_CMP";
            this.chkEnable_CMP.Size = new System.Drawing.Size(95, 16);
            this.chkEnable_CMP.TabIndex = 26;
            this.chkEnable_CMP.Text = "CMP Enable";
            this.chkEnable_CMP.UseVisualStyleBackColor = true;
            this.chkEnable_CMP.CheckedChanged += new System.EventHandler(this.chkEnable_CMP_CheckedChanged);
            // 
            // tbxStartAddress
            // 
            this.tbxStartAddress.Location = new System.Drawing.Point(544, 48);
            this.tbxStartAddress.Name = "tbxStartAddress";
            this.tbxStartAddress.Size = new System.Drawing.Size(72, 21);
            this.tbxStartAddress.TabIndex = 25;
            this.tbxStartAddress.TextChanged += new System.EventHandler(this.tbxStartAddress_TextChanged);
            // 
            // tbxCmpNumber
            // 
            this.tbxCmpNumber.Location = new System.Drawing.Point(544, 21);
            this.tbxCmpNumber.Name = "tbxCmpNumber";
            this.tbxCmpNumber.Size = new System.Drawing.Size(72, 21);
            this.tbxCmpNumber.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "Start Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "Pulse Number";
            // 
            // tbxPulseWidth
            // 
            this.tbxPulseWidth.Location = new System.Drawing.Point(126, 94);
            this.tbxPulseWidth.Name = "tbxPulseWidth";
            this.tbxPulseWidth.Size = new System.Drawing.Size(106, 21);
            this.tbxPulseWidth.TabIndex = 25;
            this.tbxPulseWidth.TextChanged += new System.EventHandler(this.tbxPulseWidth_TextChanged);
            // 
            // lblCmpLogic_T
            // 
            this.lblCmpLogic_T.AutoSize = true;
            this.lblCmpLogic_T.Location = new System.Drawing.Point(49, 70);
            this.lblCmpLogic_T.Name = "lblCmpLogic_T";
            this.lblCmpLogic_T.Size = new System.Drawing.Size(36, 12);
            this.lblCmpLogic_T.TabIndex = 24;
            this.lblCmpLogic_T.Text = "Logic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "Pulse Width";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(33, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "Channel";
            // 
            // cbxLogic_CMP
            // 
            this.cbxLogic_CMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLogic_CMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxLogic_CMP.FormattingEnabled = true;
            this.cbxLogic_CMP.Items.AddRange(new object[] {
            "High",
            "Low"});
            this.cbxLogic_CMP.Location = new System.Drawing.Point(126, 67);
            this.cbxLogic_CMP.Name = "cbxLogic_CMP";
            this.cbxLogic_CMP.Size = new System.Drawing.Size(106, 20);
            this.cbxLogic_CMP.TabIndex = 22;
            this.cbxLogic_CMP.SelectedIndexChanged += new System.EventHandler(this.cbxLogic_CMP_SelectedIndexChanged);
            // 
            // cbxChannel_CMP
            // 
            this.cbxChannel_CMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChannel_CMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxChannel_CMP.FormattingEnabled = true;
            this.cbxChannel_CMP.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbxChannel_CMP.Location = new System.Drawing.Point(103, 18);
            this.cbxChannel_CMP.Name = "cbxChannel_CMP";
            this.cbxChannel_CMP.Size = new System.Drawing.Size(129, 20);
            this.cbxChannel_CMP.TabIndex = 22;
            this.cbxChannel_CMP.SelectedIndexChanged += new System.EventHandler(this.cbxChannel_CMP_SelectedIndexChanged);
            // 
            // t_EC04H
            // 
            this.t_EC04H.Tick += new System.EventHandler(this.t_EC04H_Tick);
            // 
            // formEC04H
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 322);
            this.Controls.Add(this.tabEC04H);
            this.Name = "formEC04H";
            this.Text = "formEC04H";
            this.tabEC04H.ResumeLayout(false);
            this.tabCounter.ResumeLayout(false);
            this.tabCounter.PerformLayout();
            this.pnlCounter.ResumeLayout(false);
            this.tlpCounter.ResumeLayout(false);
            this.tlpCounter.PerformLayout();
            this.tabLatch.ResumeLayout(false);
            this.tabLatch.PerformLayout();
            this.pnlLatchMonitor.ResumeLayout(false);
            this.tlpLatch.ResumeLayout(false);
            this.tlpLatch.PerformLayout();
            this.tabCMP_EC04H.ResumeLayout(false);
            this.tabCMP_EC04H.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmp)).EndInit();
            this.pnlCMP.ResumeLayout(false);
            this.tlpCMP_EC04H.ResumeLayout(false);
            this.tlpCMP_EC04H.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEC04H;
        private System.Windows.Forms.TabPage tabCounter;
        private System.Windows.Forms.TextBox tbxDefault_Z;
        private System.Windows.Forms.Panel pnlCounter;
        private System.Windows.Forms.TableLayoutPanel tlpCounter;
        private System.Windows.Forms.Label lblDefault_AB_T;
        private System.Windows.Forms.Label lblDefault_AB;
        private System.Windows.Forms.Label lblRead_AB_T;
        private System.Windows.Forms.Label lblRead_AB;
        private System.Windows.Forms.Label lblDefault_Z_T;
        private System.Windows.Forms.Label lbDefault_Z;
        private System.Windows.Forms.Label lblRead_Z_T;
        private System.Windows.Forms.Label lblRead_Z;
        private System.Windows.Forms.TextBox tbxDefault_AB;
        private System.Windows.Forms.Label lblCounterChannel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCounterChannel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAB_Enable;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnClear_AB;
        private System.Windows.Forms.RadioButton rdoDown;
        private System.Windows.Forms.ComboBox cbxInputMode;
        private System.Windows.Forms.RadioButton rdoUp;
        private System.Windows.Forms.ComboBox cbxFilter;
        private System.Windows.Forms.Button btnClear_Z;
        private System.Windows.Forms.CheckBox chkFilterEnable;
        private System.Windows.Forms.CheckBox chkInverse_A;
        private System.Windows.Forms.CheckBox chkInverse_Z;
        private System.Windows.Forms.CheckBox chkInverse_B;
        private System.Windows.Forms.TabPage tabLatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoReadMode_Manual;
        private System.Windows.Forms.RadioButton rdoReadMode_Auto;
        private System.Windows.Forms.ListView lvwLatch;
        private System.Windows.Forms.ColumnHeader chIndex;
        private System.Windows.Forms.ColumnHeader chCounter;
        private System.Windows.Forms.Button btnLatchClear;
        private System.Windows.Forms.CheckBox chkLatch;
        private System.Windows.Forms.TextBox tbxLatchIndex;
        private System.Windows.Forms.Label lblLatchManualIndex_T;
        private System.Windows.Forms.Panel pnlLatchMonitor;
        private System.Windows.Forms.TableLayoutPanel tlpLatch;
        private System.Windows.Forms.Label lblLatch_Index_T;
        private System.Windows.Forms.Label lblLatch_Count_T;
        private System.Windows.Forms.Label lblLatchCounter;
        private System.Windows.Forms.Label lblLatchIndex;
        private System.Windows.Forms.Label lblEdgeMode;
        private System.Windows.Forms.Label lblLatchCh;
        private System.Windows.Forms.ComboBox cbxEdge;
        private System.Windows.Forms.ComboBox cbxLatchChannel;
        private System.Windows.Forms.TabPage tabCMP_EC04H;
        private System.Windows.Forms.DataGridView dgvCmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Panel pnlCMP;
        private System.Windows.Forms.TableLayoutPanel tlpCMP_EC04H;
        private System.Windows.Forms.Label inPOD_CMP_Index_T;
        private System.Windows.Forms.Label inPOD_CMP_Value_T;
        private System.Windows.Forms.Label lblCmpValue;
        private System.Windows.Forms.Label inPOD_CMP_ResponseTrg_T;
        private System.Windows.Forms.Label lblRepsTrg;
        private System.Windows.Forms.Label lblCmpIndex;
        private System.Windows.Forms.Button btnSettingSave;
        private System.Windows.Forms.Button btnCmpClear;
        private System.Windows.Forms.Button btnCmpTest;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.CheckBox chkCmpRepeat;
        private System.Windows.Forms.CheckBox chkEnable_CMP;
        private System.Windows.Forms.TextBox tbxStartAddress;
        private System.Windows.Forms.TextBox tbxCmpNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPulseWidth;
        private System.Windows.Forms.Label lblCmpLogic_T;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxLogic_CMP;
        private System.Windows.Forms.ComboBox cbxChannel_CMP;
        private System.Windows.Forms.Timer t_EC04H;
    }
}