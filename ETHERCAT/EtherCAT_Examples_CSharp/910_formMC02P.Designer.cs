namespace EtherCAT_Examples_CSharp
{
    partial class formMC02P
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
            this.t_MC02P = new System.Windows.Forms.Timer(this.components);
            this.cbxAxis = new System.Windows.Forms.ComboBox();
            this.lblAxis = new System.Windows.Forms.Label();
            this.btnServoOn = new System.Windows.Forms.Button();
            this.rdoVel = new System.Windows.Forms.RadioButton();
            this.rdoAbs = new System.Windows.Forms.RadioButton();
            this.rdoRel = new System.Windows.Forms.RadioButton();
            this.rdoJog = new System.Windows.Forms.RadioButton();
            this.lblSpeedMode_Title = new System.Windows.Forms.Label();
            this.lblWorkSpeed_Title = new System.Windows.Forms.Label();
            this.lblAcc_Title = new System.Windows.Forms.Label();
            this.lblDec_Title = new System.Windows.Forms.Label();
            this.tlpSpeedSetup = new System.Windows.Forms.TableLayoutPanel();
            this.lblMax_Title = new System.Windows.Forms.Label();
            this.tbxWorkSpeed = new System.Windows.Forms.TextBox();
            this.tbxAccel = new System.Windows.Forms.TextBox();
            this.tbxDecel = new System.Windows.Forms.TextBox();
            this.tbxMax = new System.Windows.Forms.TextBox();
            this.cbxSpeedMode = new System.Windows.Forms.ComboBox();
            this.lblSpeedSetup_Title = new System.Windows.Forms.Label();
            this.pnlSpeedSetup = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.tlpMove = new System.Windows.Forms.TableLayoutPanel();
            this.lblDist1 = new System.Windows.Forms.Label();
            this.tbxDist1 = new System.Windows.Forms.TextBox();
            this.tbxDist0 = new System.Windows.Forms.TextBox();
            this.btnMoveN = new System.Windows.Forms.Button();
            this.btnMoveP = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStopEmg = new System.Windows.Forms.Button();
            this.lblDist2 = new System.Windows.Forms.Label();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabMove = new System.Windows.Forms.TabPage();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.btnHomeStop = new System.Windows.Forms.Button();
            this.btnHomeStart = new System.Windows.Forms.Button();
            this.cbxHomeMode = new System.Windows.Forms.ComboBox();
            this.tbxHomeOffset = new System.Windows.Forms.TextBox();
            this.lblHomeOffset = new System.Windows.Forms.Label();
            this.lblHomeMode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpHomeSpeed = new System.Windows.Forms.TableLayoutPanel();
            this.lblHomeSpeedMode = new System.Windows.Forms.Label();
            this.lblHomeWorkSpeed = new System.Windows.Forms.Label();
            this.lblHomeAccel = new System.Windows.Forms.Label();
            this.tbxHomeWorkSpeed = new System.Windows.Forms.TextBox();
            this.tbxHomeAccel = new System.Windows.Forms.TextBox();
            this.cbxHomeSpeedMode = new System.Windows.Forms.ComboBox();
            this.lblHomeSpeedSetup = new System.Windows.Forms.Label();
            this.lblHomeSpeedSpeed = new System.Windows.Forms.Label();
            this.tbxHomeSpecSpeed = new System.Windows.Forms.TextBox();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.chkInputReverse = new System.Windows.Forms.CheckBox();
            this.cbxInputMode = new System.Windows.Forms.ComboBox();
            this.lblInputMode = new System.Windows.Forms.Label();
            this.cbxOutputMode = new System.Windows.Forms.ComboBox();
            this.lblOutputMode = new System.Windows.Forms.Label();
            this.cbxEzLogic = new System.Windows.Forms.ComboBox();
            this.lblEzLogic = new System.Windows.Forms.Label();
            this.cbxOrgLogic = new System.Windows.Forms.ComboBox();
            this.lblOrgLogic = new System.Windows.Forms.Label();
            this.cbxElLogic = new System.Windows.Forms.ComboBox();
            this.lblElLogic = new System.Windows.Forms.Label();
            this.cbxAlarmLogic = new System.Windows.Forms.ComboBox();
            this.lblAlarmLogic = new System.Windows.Forms.Label();
            this.tabIx = new System.Windows.Forms.TabPage();
            this.tbxAxis1Pos = new System.Windows.Forms.TextBox();
            this.lblAxis1Pos = new System.Windows.Forms.Label();
            this.tbxAxis0Pos = new System.Windows.Forms.TextBox();
            this.lblAxis0Pos = new System.Windows.Forms.Label();
            this.btnIxStop = new System.Windows.Forms.Button();
            this.btnIxLineToStart = new System.Windows.Forms.Button();
            this.btnIxLineStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.tlpState = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.lblNEL = new System.Windows.Forms.Label();
            this.lblORG = new System.Windows.Forms.Label();
            this.lblPEL = new System.Windows.Forms.Label();
            this.lblINP = new System.Windows.Forms.Label();
            this.lblCmdPos = new System.Windows.Forms.Label();
            this.lblFdbPos = new System.Windows.Forms.Label();
            this.lblRDY = new System.Windows.Forms.Label();
            this.btnIxStopEmg = new System.Windows.Forms.Button();
            this.lblIxSpeedMode = new System.Windows.Forms.Label();
            this.lblIxWorkSpeed = new System.Windows.Forms.Label();
            this.lblIxAccel = new System.Windows.Forms.Label();
            this.lblIxDecel = new System.Windows.Forms.Label();
            this.tbxIxWorkSpeed = new System.Windows.Forms.TextBox();
            this.tbxIxAccel = new System.Windows.Forms.TextBox();
            this.tbxIxDecel = new System.Windows.Forms.TextBox();
            this.cbxIxSpeedMode = new System.Windows.Forms.ComboBox();
            this.tlpSpeedSetup.SuspendLayout();
            this.pnlSpeedSetup.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.tlpMove.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabMove.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpHomeSpeed.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.tabIx.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.tlpState.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_MC02P
            // 
            this.t_MC02P.Enabled = true;
            this.t_MC02P.Tick += new System.EventHandler(this.t_MC02P_Tick);
            // 
            // cbxAxis
            // 
            this.cbxAxis.FormattingEnabled = true;
            this.cbxAxis.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxAxis.Location = new System.Drawing.Point(53, 12);
            this.cbxAxis.Name = "cbxAxis";
            this.cbxAxis.Size = new System.Drawing.Size(38, 20);
            this.cbxAxis.TabIndex = 0;
            this.cbxAxis.SelectedIndexChanged += new System.EventHandler(this.cbxAxis_SelectedIndexChanged);
            // 
            // lblAxis
            // 
            this.lblAxis.AutoSize = true;
            this.lblAxis.Location = new System.Drawing.Point(17, 15);
            this.lblAxis.Name = "lblAxis";
            this.lblAxis.Size = new System.Drawing.Size(30, 12);
            this.lblAxis.TabIndex = 1;
            this.lblAxis.Text = "Axis";
            // 
            // btnServoOn
            // 
            this.btnServoOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServoOn.Location = new System.Drawing.Point(124, 10);
            this.btnServoOn.Name = "btnServoOn";
            this.btnServoOn.Size = new System.Drawing.Size(75, 23);
            this.btnServoOn.TabIndex = 2;
            this.btnServoOn.Text = "Servo ON";
            this.btnServoOn.UseVisualStyleBackColor = true;
            this.btnServoOn.Click += new System.EventHandler(this.btnServoOn_Click);
            // 
            // rdoVel
            // 
            this.rdoVel.AutoSize = true;
            this.rdoVel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoVel.Location = new System.Drawing.Point(24, 105);
            this.rdoVel.Name = "rdoVel";
            this.rdoVel.Size = new System.Drawing.Size(81, 16);
            this.rdoVel.TabIndex = 17;
            this.rdoVel.TabStop = true;
            this.rdoVel.Text = "Velocity ";
            this.rdoVel.UseVisualStyleBackColor = true;
            this.rdoVel.CheckedChanged += new System.EventHandler(this.rdoJog_CheckedChanged);
            // 
            // rdoAbs
            // 
            this.rdoAbs.AutoSize = true;
            this.rdoAbs.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoAbs.Location = new System.Drawing.Point(24, 83);
            this.rdoAbs.Name = "rdoAbs";
            this.rdoAbs.Size = new System.Drawing.Size(80, 16);
            this.rdoAbs.TabIndex = 18;
            this.rdoAbs.TabStop = true;
            this.rdoAbs.Text = "Absolute";
            this.rdoAbs.UseVisualStyleBackColor = true;
            this.rdoAbs.CheckedChanged += new System.EventHandler(this.rdoJog_CheckedChanged);
            // 
            // rdoRel
            // 
            this.rdoRel.AutoSize = true;
            this.rdoRel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoRel.Location = new System.Drawing.Point(24, 61);
            this.rdoRel.Name = "rdoRel";
            this.rdoRel.Size = new System.Drawing.Size(75, 16);
            this.rdoRel.TabIndex = 19;
            this.rdoRel.TabStop = true;
            this.rdoRel.Text = "Relative";
            this.rdoRel.UseVisualStyleBackColor = true;
            this.rdoRel.CheckedChanged += new System.EventHandler(this.rdoJog_CheckedChanged);
            // 
            // rdoJog
            // 
            this.rdoJog.AutoSize = true;
            this.rdoJog.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoJog.Location = new System.Drawing.Point(24, 37);
            this.rdoJog.Name = "rdoJog";
            this.rdoJog.Size = new System.Drawing.Size(46, 16);
            this.rdoJog.TabIndex = 20;
            this.rdoJog.TabStop = true;
            this.rdoJog.Text = "Jog";
            this.rdoJog.UseVisualStyleBackColor = true;
            this.rdoJog.CheckedChanged += new System.EventHandler(this.rdoJog_CheckedChanged);
            // 
            // lblSpeedMode_Title
            // 
            this.lblSpeedMode_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeedMode_Title.AutoSize = true;
            this.lblSpeedMode_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSpeedMode_Title.Location = new System.Drawing.Point(3, 36);
            this.lblSpeedMode_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpeedMode_Title.Name = "lblSpeedMode_Title";
            this.lblSpeedMode_Title.Size = new System.Drawing.Size(143, 18);
            this.lblSpeedMode_Title.TabIndex = 1;
            this.lblSpeedMode_Title.Text = "SpeedMode";
            this.lblSpeedMode_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWorkSpeed_Title
            // 
            this.lblWorkSpeed_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWorkSpeed_Title.AutoSize = true;
            this.lblWorkSpeed_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorkSpeed_Title.Location = new System.Drawing.Point(3, 66);
            this.lblWorkSpeed_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWorkSpeed_Title.Name = "lblWorkSpeed_Title";
            this.lblWorkSpeed_Title.Size = new System.Drawing.Size(143, 18);
            this.lblWorkSpeed_Title.TabIndex = 1;
            this.lblWorkSpeed_Title.Text = "WorkSpeed";
            this.lblWorkSpeed_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcc_Title
            // 
            this.lblAcc_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAcc_Title.AutoSize = true;
            this.lblAcc_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAcc_Title.Location = new System.Drawing.Point(3, 96);
            this.lblAcc_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAcc_Title.Name = "lblAcc_Title";
            this.lblAcc_Title.Size = new System.Drawing.Size(143, 18);
            this.lblAcc_Title.TabIndex = 1;
            this.lblAcc_Title.Text = "Accel";
            this.lblAcc_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDec_Title
            // 
            this.lblDec_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDec_Title.AutoSize = true;
            this.lblDec_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDec_Title.Location = new System.Drawing.Point(3, 126);
            this.lblDec_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDec_Title.Name = "lblDec_Title";
            this.lblDec_Title.Size = new System.Drawing.Size(143, 18);
            this.lblDec_Title.TabIndex = 1;
            this.lblDec_Title.Text = "Decel";
            this.lblDec_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpSpeedSetup
            // 
            this.tlpSpeedSetup.BackColor = System.Drawing.Color.White;
            this.tlpSpeedSetup.ColumnCount = 2;
            this.tlpSpeedSetup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSpeedSetup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSpeedSetup.Controls.Add(this.lblSpeedMode_Title, 0, 1);
            this.tlpSpeedSetup.Controls.Add(this.lblWorkSpeed_Title, 0, 2);
            this.tlpSpeedSetup.Controls.Add(this.lblAcc_Title, 0, 3);
            this.tlpSpeedSetup.Controls.Add(this.lblDec_Title, 0, 4);
            this.tlpSpeedSetup.Controls.Add(this.lblMax_Title, 0, 5);
            this.tlpSpeedSetup.Controls.Add(this.tbxWorkSpeed, 1, 2);
            this.tlpSpeedSetup.Controls.Add(this.tbxAccel, 1, 3);
            this.tlpSpeedSetup.Controls.Add(this.tbxDecel, 1, 4);
            this.tlpSpeedSetup.Controls.Add(this.tbxMax, 1, 5);
            this.tlpSpeedSetup.Controls.Add(this.cbxSpeedMode, 1, 1);
            this.tlpSpeedSetup.Controls.Add(this.lblSpeedSetup_Title, 0, 0);
            this.tlpSpeedSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSpeedSetup.Location = new System.Drawing.Point(1, 1);
            this.tlpSpeedSetup.Name = "tlpSpeedSetup";
            this.tlpSpeedSetup.RowCount = 7;
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSpeedSetup.Size = new System.Drawing.Size(298, 185);
            this.tlpSpeedSetup.TabIndex = 7;
            // 
            // lblMax_Title
            // 
            this.lblMax_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMax_Title.AutoSize = true;
            this.lblMax_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMax_Title.Location = new System.Drawing.Point(3, 156);
            this.lblMax_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMax_Title.Name = "lblMax_Title";
            this.lblMax_Title.Size = new System.Drawing.Size(143, 18);
            this.lblMax_Title.TabIndex = 1;
            this.lblMax_Title.Text = "MaxSpeed";
            this.lblMax_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxWorkSpeed
            // 
            this.tbxWorkSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxWorkSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxWorkSpeed.Location = new System.Drawing.Point(152, 63);
            this.tbxWorkSpeed.Name = "tbxWorkSpeed";
            this.tbxWorkSpeed.Size = new System.Drawing.Size(143, 21);
            this.tbxWorkSpeed.TabIndex = 3;
            // 
            // tbxAccel
            // 
            this.tbxAccel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAccel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAccel.Location = new System.Drawing.Point(152, 93);
            this.tbxAccel.Name = "tbxAccel";
            this.tbxAccel.Size = new System.Drawing.Size(143, 21);
            this.tbxAccel.TabIndex = 3;
            // 
            // tbxDecel
            // 
            this.tbxDecel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDecel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDecel.Location = new System.Drawing.Point(152, 123);
            this.tbxDecel.Name = "tbxDecel";
            this.tbxDecel.Size = new System.Drawing.Size(143, 21);
            this.tbxDecel.TabIndex = 3;
            // 
            // tbxMax
            // 
            this.tbxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMax.Location = new System.Drawing.Point(152, 153);
            this.tbxMax.Name = "tbxMax";
            this.tbxMax.Size = new System.Drawing.Size(143, 21);
            this.tbxMax.TabIndex = 3;
            // 
            // cbxSpeedMode
            // 
            this.cbxSpeedMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSpeedMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSpeedMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSpeedMode.FormattingEnabled = true;
            this.cbxSpeedMode.Items.AddRange(new object[] {
            "Constant",
            "Trapzoidal",
            "S-Curve"});
            this.cbxSpeedMode.Location = new System.Drawing.Point(152, 33);
            this.cbxSpeedMode.Name = "cbxSpeedMode";
            this.cbxSpeedMode.Size = new System.Drawing.Size(143, 20);
            this.cbxSpeedMode.TabIndex = 4;
            // 
            // lblSpeedSetup_Title
            // 
            this.lblSpeedSetup_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeedSetup_Title.AutoSize = true;
            this.lblSpeedSetup_Title.BackColor = System.Drawing.Color.Black;
            this.tlpSpeedSetup.SetColumnSpan(this.lblSpeedSetup_Title, 2);
            this.lblSpeedSetup_Title.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSpeedSetup_Title.ForeColor = System.Drawing.Color.White;
            this.lblSpeedSetup_Title.Location = new System.Drawing.Point(0, 0);
            this.lblSpeedSetup_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpeedSetup_Title.Name = "lblSpeedSetup_Title";
            this.lblSpeedSetup_Title.Size = new System.Drawing.Size(298, 30);
            this.lblSpeedSetup_Title.TabIndex = 0;
            this.lblSpeedSetup_Title.Text = "Speed Setup";
            this.lblSpeedSetup_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSpeedSetup
            // 
            this.pnlSpeedSetup.BackColor = System.Drawing.Color.Black;
            this.pnlSpeedSetup.Controls.Add(this.tlpSpeedSetup);
            this.pnlSpeedSetup.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpeedSetup.Location = new System.Drawing.Point(206, 3);
            this.pnlSpeedSetup.Name = "pnlSpeedSetup";
            this.pnlSpeedSetup.Padding = new System.Windows.Forms.Padding(1);
            this.pnlSpeedSetup.Size = new System.Drawing.Size(300, 187);
            this.pnlSpeedSetup.TabIndex = 21;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.Black;
            this.pnlControl.Controls.Add(this.tlpMove);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(3, 190);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Padding = new System.Windows.Forms.Padding(1);
            this.pnlControl.Size = new System.Drawing.Size(503, 140);
            this.pnlControl.TabIndex = 22;
            // 
            // tlpMove
            // 
            this.tlpMove.BackColor = System.Drawing.Color.White;
            this.tlpMove.ColumnCount = 3;
            this.tlpMove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpMove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpMove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpMove.Controls.Add(this.lblDist1, 0, 0);
            this.tlpMove.Controls.Add(this.tbxDist1, 2, 1);
            this.tlpMove.Controls.Add(this.tbxDist0, 0, 1);
            this.tlpMove.Controls.Add(this.btnMoveN, 0, 2);
            this.tlpMove.Controls.Add(this.btnMoveP, 2, 2);
            this.tlpMove.Controls.Add(this.btnStop, 1, 2);
            this.tlpMove.Controls.Add(this.btnStopEmg, 1, 0);
            this.tlpMove.Controls.Add(this.lblDist2, 2, 0);
            this.tlpMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMove.Location = new System.Drawing.Point(1, 1);
            this.tlpMove.Name = "tlpMove";
            this.tlpMove.RowCount = 3;
            this.tlpMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMove.Size = new System.Drawing.Size(501, 138);
            this.tlpMove.TabIndex = 6;
            // 
            // lblDist1
            // 
            this.lblDist1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDist1.AutoSize = true;
            this.lblDist1.Location = new System.Drawing.Point(3, 0);
            this.lblDist1.Name = "lblDist1";
            this.lblDist1.Size = new System.Drawing.Size(159, 34);
            this.lblDist1.TabIndex = 5;
            this.lblDist1.Text = "Distance 0";
            this.lblDist1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxDist1
            // 
            this.tbxDist1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDist1.Location = new System.Drawing.Point(338, 37);
            this.tbxDist1.Name = "tbxDist1";
            this.tbxDist1.Size = new System.Drawing.Size(160, 21);
            this.tbxDist1.TabIndex = 4;
            this.tbxDist1.Text = "1";
            this.tbxDist1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxDist0
            // 
            this.tbxDist0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDist0.Location = new System.Drawing.Point(3, 37);
            this.tbxDist0.Name = "tbxDist0";
            this.tbxDist0.Size = new System.Drawing.Size(159, 21);
            this.tbxDist0.TabIndex = 4;
            this.tbxDist0.Text = "0";
            this.tbxDist0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMoveN
            // 
            this.btnMoveN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveN.Location = new System.Drawing.Point(3, 71);
            this.btnMoveN.Name = "btnMoveN";
            this.btnMoveN.Size = new System.Drawing.Size(159, 64);
            this.btnMoveN.TabIndex = 2;
            this.btnMoveN.Text = "Move N";
            this.btnMoveN.UseVisualStyleBackColor = true;
            this.btnMoveN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMoveN_MouseDown);
            this.btnMoveN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMoveN_MouseUp);
            // 
            // btnMoveP
            // 
            this.btnMoveP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveP.Location = new System.Drawing.Point(338, 71);
            this.btnMoveP.Name = "btnMoveP";
            this.btnMoveP.Size = new System.Drawing.Size(160, 64);
            this.btnMoveP.TabIndex = 2;
            this.btnMoveP.Text = "Move P";
            this.btnMoveP.UseVisualStyleBackColor = true;
            this.btnMoveP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMoveP_MouseDown);
            this.btnMoveP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMoveP_MouseUp);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(168, 71);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(164, 64);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStopEmg
            // 
            this.btnStopEmg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopEmg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopEmg.Location = new System.Drawing.Point(168, 3);
            this.btnStopEmg.Name = "btnStopEmg";
            this.tlpMove.SetRowSpan(this.btnStopEmg, 2);
            this.btnStopEmg.Size = new System.Drawing.Size(164, 62);
            this.btnStopEmg.TabIndex = 2;
            this.btnStopEmg.Text = "Stop Emg";
            this.btnStopEmg.UseVisualStyleBackColor = true;
            this.btnStopEmg.Click += new System.EventHandler(this.btnStopEmg_Click);
            // 
            // lblDist2
            // 
            this.lblDist2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDist2.AutoSize = true;
            this.lblDist2.Location = new System.Drawing.Point(338, 0);
            this.lblDist2.Name = "lblDist2";
            this.lblDist2.Size = new System.Drawing.Size(160, 34);
            this.lblDist2.TabIndex = 5;
            this.lblDist2.Text = "Distance 1";
            this.lblDist2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabMove);
            this.tabMenu.Controls.Add(this.tabHome);
            this.tabMenu.Controls.Add(this.tabSetup);
            this.tabMenu.Controls.Add(this.tabIx);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 36);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(517, 359);
            this.tabMenu.TabIndex = 23;
            this.tabMenu.SelectedIndexChanged += new System.EventHandler(this.tabMenu_SelectedIndexChanged);
            // 
            // tabMove
            // 
            this.tabMove.Controls.Add(this.pnlSpeedSetup);
            this.tabMove.Controls.Add(this.rdoVel);
            this.tabMove.Controls.Add(this.pnlControl);
            this.tabMove.Controls.Add(this.rdoAbs);
            this.tabMove.Controls.Add(this.rdoJog);
            this.tabMove.Controls.Add(this.rdoRel);
            this.tabMove.Location = new System.Drawing.Point(4, 22);
            this.tabMove.Name = "tabMove";
            this.tabMove.Padding = new System.Windows.Forms.Padding(3);
            this.tabMove.Size = new System.Drawing.Size(509, 333);
            this.tabMove.TabIndex = 0;
            this.tabMove.Text = "Move";
            this.tabMove.UseVisualStyleBackColor = true;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.btnHomeStop);
            this.tabHome.Controls.Add(this.btnHomeStart);
            this.tabHome.Controls.Add(this.cbxHomeMode);
            this.tabHome.Controls.Add(this.tbxHomeOffset);
            this.tabHome.Controls.Add(this.lblHomeOffset);
            this.tabHome.Controls.Add(this.lblHomeMode);
            this.tabHome.Controls.Add(this.panel1);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(509, 333);
            this.tabHome.TabIndex = 1;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // btnHomeStop
            // 
            this.btnHomeStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeStop.Location = new System.Drawing.Point(120, 246);
            this.btnHomeStop.Name = "btnHomeStop";
            this.btnHomeStop.Size = new System.Drawing.Size(99, 62);
            this.btnHomeStop.TabIndex = 27;
            this.btnHomeStop.Text = "Stop";
            this.btnHomeStop.UseVisualStyleBackColor = true;
            this.btnHomeStop.Click += new System.EventHandler(this.btnHomeStop_Click);
            // 
            // btnHomeStart
            // 
            this.btnHomeStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeStart.Location = new System.Drawing.Point(15, 246);
            this.btnHomeStart.Name = "btnHomeStart";
            this.btnHomeStart.Size = new System.Drawing.Size(99, 62);
            this.btnHomeStart.TabIndex = 27;
            this.btnHomeStart.Text = "Start";
            this.btnHomeStart.UseVisualStyleBackColor = true;
            this.btnHomeStart.Click += new System.EventHandler(this.btnHomeStart_Click);
            // 
            // cbxHomeMode
            // 
            this.cbxHomeMode.FormattingEnabled = true;
            this.cbxHomeMode.Location = new System.Drawing.Point(91, 29);
            this.cbxHomeMode.Name = "cbxHomeMode";
            this.cbxHomeMode.Size = new System.Drawing.Size(121, 20);
            this.cbxHomeMode.TabIndex = 26;
            // 
            // tbxHomeOffset
            // 
            this.tbxHomeOffset.Location = new System.Drawing.Point(91, 61);
            this.tbxHomeOffset.Name = "tbxHomeOffset";
            this.tbxHomeOffset.Size = new System.Drawing.Size(121, 21);
            this.tbxHomeOffset.TabIndex = 25;
            // 
            // lblHomeOffset
            // 
            this.lblHomeOffset.AutoSize = true;
            this.lblHomeOffset.Location = new System.Drawing.Point(13, 64);
            this.lblHomeOffset.Name = "lblHomeOffset";
            this.lblHomeOffset.Size = new System.Drawing.Size(70, 12);
            this.lblHomeOffset.TabIndex = 24;
            this.lblHomeOffset.Text = "HomeOffset";
            // 
            // lblHomeMode
            // 
            this.lblHomeMode.AutoSize = true;
            this.lblHomeMode.Location = new System.Drawing.Point(13, 37);
            this.lblHomeMode.Name = "lblHomeMode";
            this.lblHomeMode.Size = new System.Drawing.Size(70, 12);
            this.lblHomeMode.TabIndex = 24;
            this.lblHomeMode.Text = "HomeMode";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.tlpHomeSpeed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(242, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(264, 327);
            this.panel1.TabIndex = 22;
            // 
            // tlpHomeSpeed
            // 
            this.tlpHomeSpeed.BackColor = System.Drawing.Color.White;
            this.tlpHomeSpeed.ColumnCount = 2;
            this.tlpHomeSpeed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHomeSpeed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHomeSpeed.Controls.Add(this.lblHomeSpeedMode, 0, 1);
            this.tlpHomeSpeed.Controls.Add(this.lblHomeWorkSpeed, 0, 2);
            this.tlpHomeSpeed.Controls.Add(this.lblHomeAccel, 0, 3);
            this.tlpHomeSpeed.Controls.Add(this.tbxHomeWorkSpeed, 1, 2);
            this.tlpHomeSpeed.Controls.Add(this.tbxHomeAccel, 1, 3);
            this.tlpHomeSpeed.Controls.Add(this.cbxHomeSpeedMode, 1, 1);
            this.tlpHomeSpeed.Controls.Add(this.lblHomeSpeedSetup, 0, 0);
            this.tlpHomeSpeed.Controls.Add(this.lblHomeSpeedSpeed, 0, 4);
            this.tlpHomeSpeed.Controls.Add(this.tbxHomeSpecSpeed, 1, 4);
            this.tlpHomeSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHomeSpeed.Location = new System.Drawing.Point(1, 1);
            this.tlpHomeSpeed.Name = "tlpHomeSpeed";
            this.tlpHomeSpeed.RowCount = 6;
            this.tlpHomeSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHomeSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHomeSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHomeSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHomeSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHomeSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHomeSpeed.Size = new System.Drawing.Size(262, 325);
            this.tlpHomeSpeed.TabIndex = 7;
            // 
            // lblHomeSpeedMode
            // 
            this.lblHomeSpeedMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHomeSpeedMode.AutoSize = true;
            this.lblHomeSpeedMode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHomeSpeedMode.Location = new System.Drawing.Point(3, 36);
            this.lblHomeSpeedMode.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblHomeSpeedMode.Name = "lblHomeSpeedMode";
            this.lblHomeSpeedMode.Size = new System.Drawing.Size(125, 18);
            this.lblHomeSpeedMode.TabIndex = 1;
            this.lblHomeSpeedMode.Text = "SpeedMode";
            this.lblHomeSpeedMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHomeWorkSpeed
            // 
            this.lblHomeWorkSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHomeWorkSpeed.AutoSize = true;
            this.lblHomeWorkSpeed.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHomeWorkSpeed.Location = new System.Drawing.Point(3, 66);
            this.lblHomeWorkSpeed.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblHomeWorkSpeed.Name = "lblHomeWorkSpeed";
            this.lblHomeWorkSpeed.Size = new System.Drawing.Size(125, 18);
            this.lblHomeWorkSpeed.TabIndex = 1;
            this.lblHomeWorkSpeed.Text = "WorkSpeed";
            this.lblHomeWorkSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHomeAccel
            // 
            this.lblHomeAccel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHomeAccel.AutoSize = true;
            this.lblHomeAccel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHomeAccel.Location = new System.Drawing.Point(3, 96);
            this.lblHomeAccel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblHomeAccel.Name = "lblHomeAccel";
            this.lblHomeAccel.Size = new System.Drawing.Size(125, 18);
            this.lblHomeAccel.TabIndex = 1;
            this.lblHomeAccel.Text = "Accel / Decel";
            this.lblHomeAccel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxHomeWorkSpeed
            // 
            this.tbxHomeWorkSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHomeWorkSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHomeWorkSpeed.Location = new System.Drawing.Point(134, 63);
            this.tbxHomeWorkSpeed.Name = "tbxHomeWorkSpeed";
            this.tbxHomeWorkSpeed.Size = new System.Drawing.Size(125, 21);
            this.tbxHomeWorkSpeed.TabIndex = 3;
            // 
            // tbxHomeAccel
            // 
            this.tbxHomeAccel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHomeAccel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHomeAccel.Location = new System.Drawing.Point(134, 93);
            this.tbxHomeAccel.Name = "tbxHomeAccel";
            this.tbxHomeAccel.Size = new System.Drawing.Size(125, 21);
            this.tbxHomeAccel.TabIndex = 3;
            // 
            // cbxHomeSpeedMode
            // 
            this.cbxHomeSpeedMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxHomeSpeedMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHomeSpeedMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxHomeSpeedMode.FormattingEnabled = true;
            this.cbxHomeSpeedMode.Items.AddRange(new object[] {
            "Constant",
            "Trapzoidal",
            "S-Curve"});
            this.cbxHomeSpeedMode.Location = new System.Drawing.Point(134, 33);
            this.cbxHomeSpeedMode.Name = "cbxHomeSpeedMode";
            this.cbxHomeSpeedMode.Size = new System.Drawing.Size(125, 20);
            this.cbxHomeSpeedMode.TabIndex = 4;
            // 
            // lblHomeSpeedSetup
            // 
            this.lblHomeSpeedSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHomeSpeedSetup.AutoSize = true;
            this.lblHomeSpeedSetup.BackColor = System.Drawing.Color.Black;
            this.tlpHomeSpeed.SetColumnSpan(this.lblHomeSpeedSetup, 2);
            this.lblHomeSpeedSetup.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHomeSpeedSetup.ForeColor = System.Drawing.Color.White;
            this.lblHomeSpeedSetup.Location = new System.Drawing.Point(0, 0);
            this.lblHomeSpeedSetup.Margin = new System.Windows.Forms.Padding(0);
            this.lblHomeSpeedSetup.Name = "lblHomeSpeedSetup";
            this.lblHomeSpeedSetup.Size = new System.Drawing.Size(262, 30);
            this.lblHomeSpeedSetup.TabIndex = 0;
            this.lblHomeSpeedSetup.Text = "Homing Speed Setup";
            this.lblHomeSpeedSetup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHomeSpeedSpeed
            // 
            this.lblHomeSpeedSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHomeSpeedSpeed.AutoSize = true;
            this.lblHomeSpeedSpeed.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHomeSpeedSpeed.Location = new System.Drawing.Point(3, 126);
            this.lblHomeSpeedSpeed.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblHomeSpeedSpeed.Name = "lblHomeSpeedSpeed";
            this.lblHomeSpeedSpeed.Size = new System.Drawing.Size(125, 18);
            this.lblHomeSpeedSpeed.TabIndex = 1;
            this.lblHomeSpeedSpeed.Text = "Spec Speed";
            this.lblHomeSpeedSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxHomeSpecSpeed
            // 
            this.tbxHomeSpecSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHomeSpecSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHomeSpecSpeed.Location = new System.Drawing.Point(134, 123);
            this.tbxHomeSpecSpeed.Name = "tbxHomeSpecSpeed";
            this.tbxHomeSpecSpeed.Size = new System.Drawing.Size(125, 21);
            this.tbxHomeSpecSpeed.TabIndex = 3;
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.chkInputReverse);
            this.tabSetup.Controls.Add(this.cbxInputMode);
            this.tabSetup.Controls.Add(this.lblInputMode);
            this.tabSetup.Controls.Add(this.cbxOutputMode);
            this.tabSetup.Controls.Add(this.lblOutputMode);
            this.tabSetup.Controls.Add(this.cbxEzLogic);
            this.tabSetup.Controls.Add(this.lblEzLogic);
            this.tabSetup.Controls.Add(this.cbxOrgLogic);
            this.tabSetup.Controls.Add(this.lblOrgLogic);
            this.tabSetup.Controls.Add(this.cbxElLogic);
            this.tabSetup.Controls.Add(this.lblElLogic);
            this.tabSetup.Controls.Add(this.cbxAlarmLogic);
            this.tabSetup.Controls.Add(this.lblAlarmLogic);
            this.tabSetup.Location = new System.Drawing.Point(4, 22);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetup.Size = new System.Drawing.Size(509, 333);
            this.tabSetup.TabIndex = 2;
            this.tabSetup.Text = "Setup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // chkInputReverse
            // 
            this.chkInputReverse.AutoSize = true;
            this.chkInputReverse.Location = new System.Drawing.Point(92, 175);
            this.chkInputReverse.Name = "chkInputReverse";
            this.chkInputReverse.Size = new System.Drawing.Size(101, 16);
            this.chkInputReverse.TabIndex = 2;
            this.chkInputReverse.Text = "Input Reverse";
            this.chkInputReverse.UseVisualStyleBackColor = true;
            this.chkInputReverse.CheckedChanged += new System.EventHandler(this.chkInputReverse_CheckedChanged);
            // 
            // cbxInputMode
            // 
            this.cbxInputMode.FormattingEnabled = true;
            this.cbxInputMode.Items.AddRange(new object[] {
            "Normal Open (A)",
            "Normal Close (B)"});
            this.cbxInputMode.Location = new System.Drawing.Point(92, 149);
            this.cbxInputMode.Name = "cbxInputMode";
            this.cbxInputMode.Size = new System.Drawing.Size(121, 20);
            this.cbxInputMode.TabIndex = 1;
            this.cbxInputMode.SelectedIndexChanged += new System.EventHandler(this.Config_SelectedIndexChanged);
            // 
            // lblInputMode
            // 
            this.lblInputMode.AutoSize = true;
            this.lblInputMode.Location = new System.Drawing.Point(13, 152);
            this.lblInputMode.Name = "lblInputMode";
            this.lblInputMode.Size = new System.Drawing.Size(68, 12);
            this.lblInputMode.TabIndex = 0;
            this.lblInputMode.Text = "Input Mode";
            // 
            // cbxOutputMode
            // 
            this.cbxOutputMode.FormattingEnabled = true;
            this.cbxOutputMode.Items.AddRange(new object[] {
            "Normal Open (A)",
            "Normal Close (B)"});
            this.cbxOutputMode.Location = new System.Drawing.Point(92, 123);
            this.cbxOutputMode.Name = "cbxOutputMode";
            this.cbxOutputMode.Size = new System.Drawing.Size(121, 20);
            this.cbxOutputMode.TabIndex = 1;
            this.cbxOutputMode.SelectedIndexChanged += new System.EventHandler(this.Config_SelectedIndexChanged);
            // 
            // lblOutputMode
            // 
            this.lblOutputMode.AutoSize = true;
            this.lblOutputMode.Location = new System.Drawing.Point(13, 126);
            this.lblOutputMode.Name = "lblOutputMode";
            this.lblOutputMode.Size = new System.Drawing.Size(77, 12);
            this.lblOutputMode.TabIndex = 0;
            this.lblOutputMode.Text = "Output Mode";
            // 
            // cbxEzLogic
            // 
            this.cbxEzLogic.FormattingEnabled = true;
            this.cbxEzLogic.Items.AddRange(new object[] {
            "Normal Open (A)",
            "Normal Close (B)"});
            this.cbxEzLogic.Location = new System.Drawing.Point(92, 97);
            this.cbxEzLogic.Name = "cbxEzLogic";
            this.cbxEzLogic.Size = new System.Drawing.Size(121, 20);
            this.cbxEzLogic.TabIndex = 1;
            this.cbxEzLogic.SelectedIndexChanged += new System.EventHandler(this.Config_SelectedIndexChanged);
            // 
            // lblEzLogic
            // 
            this.lblEzLogic.AutoSize = true;
            this.lblEzLogic.Location = new System.Drawing.Point(13, 100);
            this.lblEzLogic.Name = "lblEzLogic";
            this.lblEzLogic.Size = new System.Drawing.Size(56, 12);
            this.lblEzLogic.TabIndex = 0;
            this.lblEzLogic.Text = "EZ Logic";
            // 
            // cbxOrgLogic
            // 
            this.cbxOrgLogic.FormattingEnabled = true;
            this.cbxOrgLogic.Items.AddRange(new object[] {
            "Normal Open (A)",
            "Normal Close (B)"});
            this.cbxOrgLogic.Location = new System.Drawing.Point(92, 71);
            this.cbxOrgLogic.Name = "cbxOrgLogic";
            this.cbxOrgLogic.Size = new System.Drawing.Size(121, 20);
            this.cbxOrgLogic.TabIndex = 1;
            this.cbxOrgLogic.SelectedIndexChanged += new System.EventHandler(this.Config_SelectedIndexChanged);
            // 
            // lblOrgLogic
            // 
            this.lblOrgLogic.AutoSize = true;
            this.lblOrgLogic.Location = new System.Drawing.Point(13, 74);
            this.lblOrgLogic.Name = "lblOrgLogic";
            this.lblOrgLogic.Size = new System.Drawing.Size(66, 12);
            this.lblOrgLogic.TabIndex = 0;
            this.lblOrgLogic.Text = "ORG Logic";
            // 
            // cbxElLogic
            // 
            this.cbxElLogic.FormattingEnabled = true;
            this.cbxElLogic.Items.AddRange(new object[] {
            "Normal Open (A)",
            "Normal Close (B)"});
            this.cbxElLogic.Location = new System.Drawing.Point(92, 45);
            this.cbxElLogic.Name = "cbxElLogic";
            this.cbxElLogic.Size = new System.Drawing.Size(121, 20);
            this.cbxElLogic.TabIndex = 1;
            this.cbxElLogic.SelectedIndexChanged += new System.EventHandler(this.Config_SelectedIndexChanged);
            // 
            // lblElLogic
            // 
            this.lblElLogic.AutoSize = true;
            this.lblElLogic.Location = new System.Drawing.Point(13, 48);
            this.lblElLogic.Name = "lblElLogic";
            this.lblElLogic.Size = new System.Drawing.Size(55, 12);
            this.lblElLogic.TabIndex = 0;
            this.lblElLogic.Text = "EL Logic";
            // 
            // cbxAlarmLogic
            // 
            this.cbxAlarmLogic.FormattingEnabled = true;
            this.cbxAlarmLogic.Items.AddRange(new object[] {
            "Normal Open (A)",
            "Normal Close (B)"});
            this.cbxAlarmLogic.Location = new System.Drawing.Point(92, 19);
            this.cbxAlarmLogic.Name = "cbxAlarmLogic";
            this.cbxAlarmLogic.Size = new System.Drawing.Size(121, 20);
            this.cbxAlarmLogic.TabIndex = 1;
            this.cbxAlarmLogic.SelectedIndexChanged += new System.EventHandler(this.Config_SelectedIndexChanged);
            // 
            // lblAlarmLogic
            // 
            this.lblAlarmLogic.AutoSize = true;
            this.lblAlarmLogic.Location = new System.Drawing.Point(13, 22);
            this.lblAlarmLogic.Name = "lblAlarmLogic";
            this.lblAlarmLogic.Size = new System.Drawing.Size(73, 12);
            this.lblAlarmLogic.TabIndex = 0;
            this.lblAlarmLogic.Text = "Alarm Logic";
            // 
            // tabIx
            // 
            this.tabIx.Controls.Add(this.lblIxSpeedMode);
            this.tabIx.Controls.Add(this.lblIxWorkSpeed);
            this.tabIx.Controls.Add(this.lblIxAccel);
            this.tabIx.Controls.Add(this.lblIxDecel);
            this.tabIx.Controls.Add(this.tbxIxWorkSpeed);
            this.tabIx.Controls.Add(this.tbxIxAccel);
            this.tabIx.Controls.Add(this.tbxIxDecel);
            this.tabIx.Controls.Add(this.cbxIxSpeedMode);
            this.tabIx.Controls.Add(this.tbxAxis1Pos);
            this.tabIx.Controls.Add(this.lblAxis1Pos);
            this.tabIx.Controls.Add(this.tbxAxis0Pos);
            this.tabIx.Controls.Add(this.lblAxis0Pos);
            this.tabIx.Controls.Add(this.btnIxStopEmg);
            this.tabIx.Controls.Add(this.btnIxStop);
            this.tabIx.Controls.Add(this.btnIxLineToStart);
            this.tabIx.Controls.Add(this.btnIxLineStart);
            this.tabIx.Location = new System.Drawing.Point(4, 22);
            this.tabIx.Name = "tabIx";
            this.tabIx.Padding = new System.Windows.Forms.Padding(3);
            this.tabIx.Size = new System.Drawing.Size(509, 333);
            this.tabIx.TabIndex = 3;
            this.tabIx.Text = "IxMove";
            this.tabIx.UseVisualStyleBackColor = true;
            // 
            // tbxAxis1Pos
            // 
            this.tbxAxis1Pos.Location = new System.Drawing.Point(358, 97);
            this.tbxAxis1Pos.Name = "tbxAxis1Pos";
            this.tbxAxis1Pos.Size = new System.Drawing.Size(121, 21);
            this.tbxAxis1Pos.TabIndex = 31;
            // 
            // lblAxis1Pos
            // 
            this.lblAxis1Pos.AutoSize = true;
            this.lblAxis1Pos.Location = new System.Drawing.Point(264, 100);
            this.lblAxis1Pos.Name = "lblAxis1Pos";
            this.lblAxis1Pos.Size = new System.Drawing.Size(84, 12);
            this.lblAxis1Pos.TabIndex = 30;
            this.lblAxis1Pos.Text = "axis1 Position";
            // 
            // tbxAxis0Pos
            // 
            this.tbxAxis0Pos.Location = new System.Drawing.Point(358, 70);
            this.tbxAxis0Pos.Name = "tbxAxis0Pos";
            this.tbxAxis0Pos.Size = new System.Drawing.Size(121, 21);
            this.tbxAxis0Pos.TabIndex = 31;
            // 
            // lblAxis0Pos
            // 
            this.lblAxis0Pos.AutoSize = true;
            this.lblAxis0Pos.Location = new System.Drawing.Point(264, 73);
            this.lblAxis0Pos.Name = "lblAxis0Pos";
            this.lblAxis0Pos.Size = new System.Drawing.Size(85, 12);
            this.lblAxis0Pos.TabIndex = 30;
            this.lblAxis0Pos.Text = "Axis0 Position";
            // 
            // btnIxStop
            // 
            this.btnIxStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIxStop.Location = new System.Drawing.Point(259, 245);
            this.btnIxStop.Name = "btnIxStop";
            this.btnIxStop.Size = new System.Drawing.Size(99, 48);
            this.btnIxStop.TabIndex = 29;
            this.btnIxStop.Text = "Stop";
            this.btnIxStop.UseVisualStyleBackColor = true;
            this.btnIxStop.Click += new System.EventHandler(this.btnIxStop_Click);
            // 
            // btnIxLineToStart
            // 
            this.btnIxLineToStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIxLineToStart.Location = new System.Drawing.Point(154, 245);
            this.btnIxLineToStart.Name = "btnIxLineToStart";
            this.btnIxLineToStart.Size = new System.Drawing.Size(99, 48);
            this.btnIxLineToStart.TabIndex = 28;
            this.btnIxLineToStart.Text = "IxLineToStart";
            this.btnIxLineToStart.UseVisualStyleBackColor = true;
            this.btnIxLineToStart.Click += new System.EventHandler(this.btnIxLineToStart_Click);
            // 
            // btnIxLineStart
            // 
            this.btnIxLineStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIxLineStart.Location = new System.Drawing.Point(49, 245);
            this.btnIxLineStart.Name = "btnIxLineStart";
            this.btnIxLineStart.Size = new System.Drawing.Size(99, 48);
            this.btnIxLineStart.TabIndex = 28;
            this.btnIxLineStart.Text = "IxLineStart";
            this.btnIxLineStart.UseVisualStyleBackColor = true;
            this.btnIxLineStart.Click += new System.EventHandler(this.btnIxLineStart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAxis);
            this.panel2.Controls.Add(this.cbxAxis);
            this.panel2.Controls.Add(this.btnServoOn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 36);
            this.panel2.TabIndex = 24;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.tlpState);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 395);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(517, 67);
            this.pnlStatus.TabIndex = 25;
            // 
            // tlpState
            // 
            this.tlpState.ColumnCount = 5;
            this.tlpState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpState.Controls.Add(this.label1, 0, 0);
            this.tlpState.Controls.Add(this.label2, 0, 1);
            this.tlpState.Controls.Add(this.lblAlarm, 4, 0);
            this.tlpState.Controls.Add(this.lblNEL, 2, 1);
            this.tlpState.Controls.Add(this.lblORG, 3, 1);
            this.tlpState.Controls.Add(this.lblPEL, 4, 1);
            this.tlpState.Controls.Add(this.lblINP, 3, 0);
            this.tlpState.Controls.Add(this.lblCmdPos, 1, 0);
            this.tlpState.Controls.Add(this.lblFdbPos, 1, 1);
            this.tlpState.Controls.Add(this.lblRDY, 2, 0);
            this.tlpState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpState.Location = new System.Drawing.Point(0, 0);
            this.tlpState.Name = "tlpState";
            this.tlpState.RowCount = 2;
            this.tlpState.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpState.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpState.Size = new System.Drawing.Size(517, 67);
            this.tlpState.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CMD Pos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "FDB Pos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlarm
            // 
            this.lblAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAlarm.Location = new System.Drawing.Point(415, 0);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(99, 33);
            this.lblAlarm.TabIndex = 0;
            this.lblAlarm.Text = "ALARM";
            this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNEL
            // 
            this.lblNEL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNEL.AutoSize = true;
            this.lblNEL.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNEL.Location = new System.Drawing.Point(209, 33);
            this.lblNEL.Name = "lblNEL";
            this.lblNEL.Size = new System.Drawing.Size(97, 34);
            this.lblNEL.TabIndex = 0;
            this.lblNEL.Text = "NEL";
            this.lblNEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblORG
            // 
            this.lblORG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblORG.AutoSize = true;
            this.lblORG.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblORG.Location = new System.Drawing.Point(312, 33);
            this.lblORG.Name = "lblORG";
            this.lblORG.Size = new System.Drawing.Size(97, 34);
            this.lblORG.TabIndex = 0;
            this.lblORG.Text = "ORG";
            this.lblORG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPEL
            // 
            this.lblPEL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPEL.AutoSize = true;
            this.lblPEL.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPEL.Location = new System.Drawing.Point(415, 33);
            this.lblPEL.Name = "lblPEL";
            this.lblPEL.Size = new System.Drawing.Size(99, 34);
            this.lblPEL.TabIndex = 0;
            this.lblPEL.Text = "PEL";
            this.lblPEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblINP
            // 
            this.lblINP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblINP.AutoSize = true;
            this.lblINP.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblINP.Location = new System.Drawing.Point(312, 0);
            this.lblINP.Name = "lblINP";
            this.lblINP.Size = new System.Drawing.Size(97, 33);
            this.lblINP.TabIndex = 0;
            this.lblINP.Text = "INP";
            this.lblINP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCmdPos
            // 
            this.lblCmdPos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCmdPos.AutoSize = true;
            this.lblCmdPos.Location = new System.Drawing.Point(106, 0);
            this.lblCmdPos.Name = "lblCmdPos";
            this.lblCmdPos.Size = new System.Drawing.Size(97, 33);
            this.lblCmdPos.TabIndex = 0;
            this.lblCmdPos.Text = "CMD Pos";
            this.lblCmdPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFdbPos
            // 
            this.lblFdbPos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFdbPos.AutoSize = true;
            this.lblFdbPos.Location = new System.Drawing.Point(106, 33);
            this.lblFdbPos.Name = "lblFdbPos";
            this.lblFdbPos.Size = new System.Drawing.Size(97, 34);
            this.lblFdbPos.TabIndex = 0;
            this.lblFdbPos.Text = "CMD Pos";
            this.lblFdbPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRDY
            // 
            this.lblRDY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRDY.AutoSize = true;
            this.lblRDY.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRDY.Location = new System.Drawing.Point(209, 0);
            this.lblRDY.Name = "lblRDY";
            this.lblRDY.Size = new System.Drawing.Size(97, 33);
            this.lblRDY.TabIndex = 0;
            this.lblRDY.Text = "RDY";
            this.lblRDY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIxStopEmg
            // 
            this.btnIxStopEmg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIxStopEmg.Location = new System.Drawing.Point(364, 245);
            this.btnIxStopEmg.Name = "btnIxStopEmg";
            this.btnIxStopEmg.Size = new System.Drawing.Size(99, 48);
            this.btnIxStopEmg.TabIndex = 29;
            this.btnIxStopEmg.Text = "StopEmg";
            this.btnIxStopEmg.UseVisualStyleBackColor = true;
            this.btnIxStopEmg.Click += new System.EventHandler(this.btnIxStopEmg_Click);
            // 
            // lblIxSpeedMode
            // 
            this.lblIxSpeedMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIxSpeedMode.AutoSize = true;
            this.lblIxSpeedMode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIxSpeedMode.Location = new System.Drawing.Point(14, 43);
            this.lblIxSpeedMode.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblIxSpeedMode.Name = "lblIxSpeedMode";
            this.lblIxSpeedMode.Size = new System.Drawing.Size(82, 12);
            this.lblIxSpeedMode.TabIndex = 32;
            this.lblIxSpeedMode.Text = "SpeedMode";
            this.lblIxSpeedMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIxWorkSpeed
            // 
            this.lblIxWorkSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIxWorkSpeed.AutoSize = true;
            this.lblIxWorkSpeed.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIxWorkSpeed.Location = new System.Drawing.Point(14, 73);
            this.lblIxWorkSpeed.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblIxWorkSpeed.Name = "lblIxWorkSpeed";
            this.lblIxWorkSpeed.Size = new System.Drawing.Size(77, 12);
            this.lblIxWorkSpeed.TabIndex = 33;
            this.lblIxWorkSpeed.Text = "WorkSpeed";
            this.lblIxWorkSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIxAccel
            // 
            this.lblIxAccel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIxAccel.AutoSize = true;
            this.lblIxAccel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIxAccel.Location = new System.Drawing.Point(14, 103);
            this.lblIxAccel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblIxAccel.Name = "lblIxAccel";
            this.lblIxAccel.Size = new System.Drawing.Size(42, 12);
            this.lblIxAccel.TabIndex = 34;
            this.lblIxAccel.Text = "Accel";
            this.lblIxAccel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIxDecel
            // 
            this.lblIxDecel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIxDecel.AutoSize = true;
            this.lblIxDecel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIxDecel.Location = new System.Drawing.Point(14, 133);
            this.lblIxDecel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblIxDecel.Name = "lblIxDecel";
            this.lblIxDecel.Size = new System.Drawing.Size(42, 12);
            this.lblIxDecel.TabIndex = 35;
            this.lblIxDecel.Text = "Decel";
            this.lblIxDecel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxIxWorkSpeed
            // 
            this.tbxIxWorkSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxIxWorkSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxIxWorkSpeed.Location = new System.Drawing.Point(108, 73);
            this.tbxIxWorkSpeed.Name = "tbxIxWorkSpeed";
            this.tbxIxWorkSpeed.Size = new System.Drawing.Size(111, 21);
            this.tbxIxWorkSpeed.TabIndex = 36;
            // 
            // tbxIxAccel
            // 
            this.tbxIxAccel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxIxAccel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxIxAccel.Location = new System.Drawing.Point(108, 103);
            this.tbxIxAccel.Name = "tbxIxAccel";
            this.tbxIxAccel.Size = new System.Drawing.Size(111, 21);
            this.tbxIxAccel.TabIndex = 37;
            // 
            // tbxIxDecel
            // 
            this.tbxIxDecel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxIxDecel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxIxDecel.Location = new System.Drawing.Point(108, 133);
            this.tbxIxDecel.Name = "tbxIxDecel";
            this.tbxIxDecel.Size = new System.Drawing.Size(111, 21);
            this.tbxIxDecel.TabIndex = 38;
            // 
            // cbxIxSpeedMode
            // 
            this.cbxIxSpeedMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxIxSpeedMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIxSpeedMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxIxSpeedMode.FormattingEnabled = true;
            this.cbxIxSpeedMode.Items.AddRange(new object[] {
            "Constant",
            "Trapzoidal",
            "S-Curve"});
            this.cbxIxSpeedMode.Location = new System.Drawing.Point(108, 43);
            this.cbxIxSpeedMode.Name = "cbxIxSpeedMode";
            this.cbxIxSpeedMode.Size = new System.Drawing.Size(111, 20);
            this.cbxIxSpeedMode.TabIndex = 39;
            // 
            // formMC02P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 462);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.panel2);
            this.Name = "formMC02P";
            this.Text = "formMC02P";
            this.tlpSpeedSetup.ResumeLayout(false);
            this.tlpSpeedSetup.PerformLayout();
            this.pnlSpeedSetup.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.tlpMove.ResumeLayout(false);
            this.tlpMove.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.tabMove.ResumeLayout(false);
            this.tabMove.PerformLayout();
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tlpHomeSpeed.ResumeLayout(false);
            this.tlpHomeSpeed.PerformLayout();
            this.tabSetup.ResumeLayout(false);
            this.tabSetup.PerformLayout();
            this.tabIx.ResumeLayout(false);
            this.tabIx.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.tlpState.ResumeLayout(false);
            this.tlpState.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer t_MC02P;
        private System.Windows.Forms.ComboBox cbxAxis;
        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.Button btnServoOn;
        private System.Windows.Forms.RadioButton rdoVel;
        private System.Windows.Forms.RadioButton rdoAbs;
        private System.Windows.Forms.RadioButton rdoRel;
        private System.Windows.Forms.RadioButton rdoJog;
        private System.Windows.Forms.Label lblSpeedMode_Title;
        private System.Windows.Forms.Label lblWorkSpeed_Title;
        private System.Windows.Forms.Label lblAcc_Title;
        private System.Windows.Forms.Label lblDec_Title;
        private System.Windows.Forms.TableLayoutPanel tlpSpeedSetup;
        private System.Windows.Forms.Label lblMax_Title;
        private System.Windows.Forms.TextBox tbxWorkSpeed;
        private System.Windows.Forms.TextBox tbxAccel;
        private System.Windows.Forms.TextBox tbxDecel;
        private System.Windows.Forms.TextBox tbxMax;
        private System.Windows.Forms.ComboBox cbxSpeedMode;
        private System.Windows.Forms.Label lblSpeedSetup_Title;
        private System.Windows.Forms.Panel pnlSpeedSetup;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.TableLayoutPanel tlpMove;
        private System.Windows.Forms.Label lblDist1;
        private System.Windows.Forms.TextBox tbxDist1;
        private System.Windows.Forms.TextBox tbxDist0;
        private System.Windows.Forms.Button btnMoveN;
        private System.Windows.Forms.Button btnMoveP;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStopEmg;
        private System.Windows.Forms.Label lblDist2;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabMove;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpHomeSpeed;
        private System.Windows.Forms.Label lblHomeSpeedMode;
        private System.Windows.Forms.Label lblHomeWorkSpeed;
        private System.Windows.Forms.Label lblHomeAccel;
        private System.Windows.Forms.TextBox tbxHomeWorkSpeed;
        private System.Windows.Forms.TextBox tbxHomeAccel;
        private System.Windows.Forms.ComboBox cbxHomeSpeedMode;
        private System.Windows.Forms.Label lblHomeSpeedSetup;
        private System.Windows.Forms.Label lblHomeSpeedSpeed;
        private System.Windows.Forms.TextBox tbxHomeSpecSpeed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHomeStop;
        private System.Windows.Forms.Button btnHomeStart;
        private System.Windows.Forms.ComboBox cbxHomeMode;
        private System.Windows.Forms.TextBox tbxHomeOffset;
        private System.Windows.Forms.Label lblHomeOffset;
        private System.Windows.Forms.Label lblHomeMode;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.ComboBox cbxAlarmLogic;
        private System.Windows.Forms.Label lblAlarmLogic;
        private System.Windows.Forms.ComboBox cbxEzLogic;
        private System.Windows.Forms.Label lblEzLogic;
        private System.Windows.Forms.ComboBox cbxOrgLogic;
        private System.Windows.Forms.Label lblOrgLogic;
        private System.Windows.Forms.ComboBox cbxElLogic;
        private System.Windows.Forms.Label lblElLogic;
        private System.Windows.Forms.ComboBox cbxInputMode;
        private System.Windows.Forms.Label lblInputMode;
        private System.Windows.Forms.ComboBox cbxOutputMode;
        private System.Windows.Forms.Label lblOutputMode;
        private System.Windows.Forms.CheckBox chkInputReverse;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.TableLayoutPanel tlpState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblNEL;
        private System.Windows.Forms.Label lblORG;
        private System.Windows.Forms.Label lblPEL;
        private System.Windows.Forms.Label lblINP;
        private System.Windows.Forms.Label lblRDY;
        private System.Windows.Forms.Label lblCmdPos;
        private System.Windows.Forms.Label lblFdbPos;
        private System.Windows.Forms.TabPage tabIx;
        private System.Windows.Forms.Button btnIxStop;
        private System.Windows.Forms.Button btnIxLineToStart;
        private System.Windows.Forms.Button btnIxLineStart;
        private System.Windows.Forms.TextBox tbxAxis1Pos;
        private System.Windows.Forms.Label lblAxis1Pos;
        private System.Windows.Forms.TextBox tbxAxis0Pos;
        private System.Windows.Forms.Label lblAxis0Pos;
        private System.Windows.Forms.Button btnIxStopEmg;
        private System.Windows.Forms.Label lblIxSpeedMode;
        private System.Windows.Forms.Label lblIxWorkSpeed;
        private System.Windows.Forms.Label lblIxAccel;
        private System.Windows.Forms.Label lblIxDecel;
        private System.Windows.Forms.TextBox tbxIxWorkSpeed;
        private System.Windows.Forms.TextBox tbxIxAccel;
        private System.Windows.Forms.TextBox tbxIxDecel;
        private System.Windows.Forms.ComboBox cbxIxSpeedMode;
    }
}