namespace EtherCAT_Examples_CSharp
{
    partial class formSxMove
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
            this.pnlSpeedSetup = new System.Windows.Forms.Panel();
            this.tlpSpeedSetup = new System.Windows.Forms.TableLayoutPanel();
            this.lblSpeedMode_Title = new System.Windows.Forms.Label();
            this.lblWorkSpeed_Title = new System.Windows.Forms.Label();
            this.lblAcc_Title = new System.Windows.Forms.Label();
            this.lblDec_Title = new System.Windows.Forms.Label();
            this.lblInit_Title = new System.Windows.Forms.Label();
            this.lblEnd_Title = new System.Windows.Forms.Label();
            this.lblJerk_Title = new System.Windows.Forms.Label();
            this.lblRatio_Title = new System.Windows.Forms.Label();
            this.trbRatio = new System.Windows.Forms.TrackBar();
            this.tbxWorkSpeed = new System.Windows.Forms.TextBox();
            this.tbxAccel = new System.Windows.Forms.TextBox();
            this.tbxDecel = new System.Windows.Forms.TextBox();
            this.tbxInit = new System.Windows.Forms.TextBox();
            this.tbxEnd = new System.Windows.Forms.TextBox();
            this.tbxJerk = new System.Windows.Forms.TextBox();
            this.cbxSpeedMode = new System.Windows.Forms.ComboBox();
            this.lblSpeedSetup_Title = new System.Windows.Forms.Label();
            this.rdoVel = new System.Windows.Forms.RadioButton();
            this.rdoAbs = new System.Windows.Forms.RadioButton();
            this.rdoRel = new System.Windows.Forms.RadioButton();
            this.rdoJog = new System.Windows.Forms.RadioButton();
            this.lblAxis = new System.Windows.Forms.Label();
            this.cbxAxisList = new System.Windows.Forms.ComboBox();
            this.chkSetRpm = new System.Windows.Forms.CheckBox();
            this.tbxPPR = new System.Windows.Forms.TextBox();
            this.lblPPR = new System.Windows.Forms.Label();
            this.pnlControl.SuspendLayout();
            this.tlpMove.SuspendLayout();
            this.pnlSpeedSetup.SuspendLayout();
            this.tlpSpeedSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.Black;
            this.pnlControl.Controls.Add(this.tlpMove);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 163);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Padding = new System.Windows.Forms.Padding(1);
            this.pnlControl.Size = new System.Drawing.Size(334, 140);
            this.pnlControl.TabIndex = 16;
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
            this.tlpMove.Size = new System.Drawing.Size(332, 138);
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
            this.lblDist1.Size = new System.Drawing.Size(103, 34);
            this.lblDist1.TabIndex = 5;
            this.lblDist1.Text = "Distance 0";
            this.lblDist1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxDist1
            // 
            this.tbxDist1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDist1.Location = new System.Drawing.Point(224, 37);
            this.tbxDist1.Name = "tbxDist1";
            this.tbxDist1.Size = new System.Drawing.Size(105, 21);
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
            this.tbxDist0.Size = new System.Drawing.Size(103, 21);
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
            this.btnMoveN.Size = new System.Drawing.Size(103, 64);
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
            this.btnMoveP.Location = new System.Drawing.Point(224, 71);
            this.btnMoveP.Name = "btnMoveP";
            this.btnMoveP.Size = new System.Drawing.Size(105, 64);
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
            this.btnStop.Location = new System.Drawing.Point(112, 71);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(106, 64);
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
            this.btnStopEmg.Location = new System.Drawing.Point(112, 3);
            this.btnStopEmg.Name = "btnStopEmg";
            this.tlpMove.SetRowSpan(this.btnStopEmg, 2);
            this.btnStopEmg.Size = new System.Drawing.Size(106, 62);
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
            this.lblDist2.Location = new System.Drawing.Point(224, 0);
            this.lblDist2.Name = "lblDist2";
            this.lblDist2.Size = new System.Drawing.Size(105, 34);
            this.lblDist2.TabIndex = 5;
            this.lblDist2.Text = "Distance 1";
            this.lblDist2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSpeedSetup
            // 
            this.pnlSpeedSetup.BackColor = System.Drawing.Color.Black;
            this.pnlSpeedSetup.Controls.Add(this.tlpSpeedSetup);
            this.pnlSpeedSetup.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpeedSetup.Location = new System.Drawing.Point(334, 0);
            this.pnlSpeedSetup.Name = "pnlSpeedSetup";
            this.pnlSpeedSetup.Padding = new System.Windows.Forms.Padding(1);
            this.pnlSpeedSetup.Size = new System.Drawing.Size(300, 303);
            this.pnlSpeedSetup.TabIndex = 15;
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
            this.tlpSpeedSetup.Controls.Add(this.lblInit_Title, 0, 5);
            this.tlpSpeedSetup.Controls.Add(this.lblEnd_Title, 0, 6);
            this.tlpSpeedSetup.Controls.Add(this.lblJerk_Title, 0, 7);
            this.tlpSpeedSetup.Controls.Add(this.lblRatio_Title, 0, 8);
            this.tlpSpeedSetup.Controls.Add(this.trbRatio, 1, 8);
            this.tlpSpeedSetup.Controls.Add(this.tbxWorkSpeed, 1, 2);
            this.tlpSpeedSetup.Controls.Add(this.tbxAccel, 1, 3);
            this.tlpSpeedSetup.Controls.Add(this.tbxDecel, 1, 4);
            this.tlpSpeedSetup.Controls.Add(this.tbxInit, 1, 5);
            this.tlpSpeedSetup.Controls.Add(this.tbxEnd, 1, 6);
            this.tlpSpeedSetup.Controls.Add(this.tbxJerk, 1, 7);
            this.tlpSpeedSetup.Controls.Add(this.cbxSpeedMode, 1, 1);
            this.tlpSpeedSetup.Controls.Add(this.lblSpeedSetup_Title, 0, 0);
            this.tlpSpeedSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSpeedSetup.Location = new System.Drawing.Point(1, 1);
            this.tlpSpeedSetup.Name = "tlpSpeedSetup";
            this.tlpSpeedSetup.RowCount = 9;
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSpeedSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpSpeedSetup.Size = new System.Drawing.Size(298, 301);
            this.tlpSpeedSetup.TabIndex = 7;
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
            this.lblSpeedMode_Title.Size = new System.Drawing.Size(143, 21);
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
            this.lblWorkSpeed_Title.Location = new System.Drawing.Point(3, 69);
            this.lblWorkSpeed_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWorkSpeed_Title.Name = "lblWorkSpeed_Title";
            this.lblWorkSpeed_Title.Size = new System.Drawing.Size(143, 21);
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
            this.lblAcc_Title.Location = new System.Drawing.Point(3, 102);
            this.lblAcc_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAcc_Title.Name = "lblAcc_Title";
            this.lblAcc_Title.Size = new System.Drawing.Size(143, 21);
            this.lblAcc_Title.TabIndex = 1;
            this.lblAcc_Title.Text = "Accek";
            this.lblAcc_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDec_Title
            // 
            this.lblDec_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDec_Title.AutoSize = true;
            this.lblDec_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDec_Title.Location = new System.Drawing.Point(3, 135);
            this.lblDec_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDec_Title.Name = "lblDec_Title";
            this.lblDec_Title.Size = new System.Drawing.Size(143, 21);
            this.lblDec_Title.TabIndex = 1;
            this.lblDec_Title.Text = "Decel";
            this.lblDec_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInit_Title
            // 
            this.lblInit_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInit_Title.AutoSize = true;
            this.lblInit_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInit_Title.Location = new System.Drawing.Point(3, 168);
            this.lblInit_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblInit_Title.Name = "lblInit_Title";
            this.lblInit_Title.Size = new System.Drawing.Size(143, 21);
            this.lblInit_Title.TabIndex = 1;
            this.lblInit_Title.Text = "InitSpeed";
            this.lblInit_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnd_Title
            // 
            this.lblEnd_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnd_Title.AutoSize = true;
            this.lblEnd_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEnd_Title.Location = new System.Drawing.Point(3, 201);
            this.lblEnd_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblEnd_Title.Name = "lblEnd_Title";
            this.lblEnd_Title.Size = new System.Drawing.Size(143, 21);
            this.lblEnd_Title.TabIndex = 1;
            this.lblEnd_Title.Text = "EndSpeed";
            this.lblEnd_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJerk_Title
            // 
            this.lblJerk_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJerk_Title.AutoSize = true;
            this.lblJerk_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblJerk_Title.Location = new System.Drawing.Point(3, 234);
            this.lblJerk_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblJerk_Title.Name = "lblJerk_Title";
            this.lblJerk_Title.Size = new System.Drawing.Size(143, 21);
            this.lblJerk_Title.TabIndex = 1;
            this.lblJerk_Title.Text = "JerkRatio";
            this.lblJerk_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRatio_Title
            // 
            this.lblRatio_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRatio_Title.AutoSize = true;
            this.lblRatio_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRatio_Title.Location = new System.Drawing.Point(3, 267);
            this.lblRatio_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblRatio_Title.Name = "lblRatio_Title";
            this.lblRatio_Title.Size = new System.Drawing.Size(143, 28);
            this.lblRatio_Title.TabIndex = 1;
            this.lblRatio_Title.Text = "Ratio (100)";
            this.lblRatio_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trbRatio
            // 
            this.trbRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbRatio.Location = new System.Drawing.Point(152, 264);
            this.trbRatio.Maximum = 100;
            this.trbRatio.Minimum = 1;
            this.trbRatio.Name = "trbRatio";
            this.trbRatio.Size = new System.Drawing.Size(143, 34);
            this.trbRatio.TabIndex = 2;
            this.trbRatio.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbRatio.Value = 100;
            // 
            // tbxWorkSpeed
            // 
            this.tbxWorkSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxWorkSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxWorkSpeed.Location = new System.Drawing.Point(152, 66);
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
            this.tbxAccel.Location = new System.Drawing.Point(152, 99);
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
            this.tbxDecel.Location = new System.Drawing.Point(152, 132);
            this.tbxDecel.Name = "tbxDecel";
            this.tbxDecel.Size = new System.Drawing.Size(143, 21);
            this.tbxDecel.TabIndex = 3;
            // 
            // tbxInit
            // 
            this.tbxInit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxInit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxInit.Location = new System.Drawing.Point(152, 165);
            this.tbxInit.Name = "tbxInit";
            this.tbxInit.Size = new System.Drawing.Size(143, 21);
            this.tbxInit.TabIndex = 3;
            // 
            // tbxEnd
            // 
            this.tbxEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEnd.Location = new System.Drawing.Point(152, 198);
            this.tbxEnd.Name = "tbxEnd";
            this.tbxEnd.Size = new System.Drawing.Size(143, 21);
            this.tbxEnd.TabIndex = 3;
            // 
            // tbxJerk
            // 
            this.tbxJerk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxJerk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxJerk.Location = new System.Drawing.Point(152, 231);
            this.tbxJerk.Name = "tbxJerk";
            this.tbxJerk.Size = new System.Drawing.Size(143, 21);
            this.tbxJerk.TabIndex = 3;
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
            // rdoVel
            // 
            this.rdoVel.AutoSize = true;
            this.rdoVel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoVel.Location = new System.Drawing.Point(37, 123);
            this.rdoVel.Name = "rdoVel";
            this.rdoVel.Size = new System.Drawing.Size(81, 16);
            this.rdoVel.TabIndex = 11;
            this.rdoVel.TabStop = true;
            this.rdoVel.Text = "Velocity ";
            this.rdoVel.UseVisualStyleBackColor = true;
            this.rdoVel.CheckedChanged += new System.EventHandler(this.rdoJog_CheckedChanged);
            // 
            // rdoAbs
            // 
            this.rdoAbs.AutoSize = true;
            this.rdoAbs.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoAbs.Location = new System.Drawing.Point(37, 101);
            this.rdoAbs.Name = "rdoAbs";
            this.rdoAbs.Size = new System.Drawing.Size(80, 16);
            this.rdoAbs.TabIndex = 12;
            this.rdoAbs.TabStop = true;
            this.rdoAbs.Text = "Absolute";
            this.rdoAbs.UseVisualStyleBackColor = true;
            this.rdoAbs.CheckedChanged += new System.EventHandler(this.rdoJog_CheckedChanged);
            // 
            // rdoRel
            // 
            this.rdoRel.AutoSize = true;
            this.rdoRel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoRel.Location = new System.Drawing.Point(37, 79);
            this.rdoRel.Name = "rdoRel";
            this.rdoRel.Size = new System.Drawing.Size(75, 16);
            this.rdoRel.TabIndex = 13;
            this.rdoRel.TabStop = true;
            this.rdoRel.Text = "Relative";
            this.rdoRel.UseVisualStyleBackColor = true;
            this.rdoRel.CheckedChanged += new System.EventHandler(this.rdoJog_CheckedChanged);
            // 
            // rdoJog
            // 
            this.rdoJog.AutoSize = true;
            this.rdoJog.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoJog.Location = new System.Drawing.Point(37, 55);
            this.rdoJog.Name = "rdoJog";
            this.rdoJog.Size = new System.Drawing.Size(46, 16);
            this.rdoJog.TabIndex = 14;
            this.rdoJog.TabStop = true;
            this.rdoJog.Text = "Jog";
            this.rdoJog.UseVisualStyleBackColor = true;
            this.rdoJog.CheckedChanged += new System.EventHandler(this.rdoJog_CheckedChanged);
            // 
            // lblAxis
            // 
            this.lblAxis.AutoSize = true;
            this.lblAxis.Location = new System.Drawing.Point(88, 19);
            this.lblAxis.Name = "lblAxis";
            this.lblAxis.Size = new System.Drawing.Size(30, 12);
            this.lblAxis.TabIndex = 18;
            this.lblAxis.Text = "Axis";
            // 
            // cbxAxisList
            // 
            this.cbxAxisList.FormattingEnabled = true;
            this.cbxAxisList.Location = new System.Drawing.Point(124, 12);
            this.cbxAxisList.Name = "cbxAxisList";
            this.cbxAxisList.Size = new System.Drawing.Size(121, 20);
            this.cbxAxisList.TabIndex = 17;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // chkSetRpm
            // 
            this.chkSetRpm.AutoSize = true;
            this.chkSetRpm.Location = new System.Drawing.Point(225, 130);
            this.chkSetRpm.Name = "chkSetRpm";
            this.chkSetRpm.Size = new System.Drawing.Size(73, 16);
            this.chkSetRpm.TabIndex = 19;
            this.chkSetRpm.Text = "Set RPM";
            this.chkSetRpm.UseVisualStyleBackColor = true;
            this.chkSetRpm.CheckedChanged += new System.EventHandler(this.chkSetRpm_CheckedChanged);
            // 
            // tbxPPR
            // 
            this.tbxPPR.Location = new System.Drawing.Point(225, 103);
            this.tbxPPR.Name = "tbxPPR";
            this.tbxPPR.Size = new System.Drawing.Size(92, 21);
            this.tbxPPR.TabIndex = 20;
            this.tbxPPR.Text = "360000";
            this.tbxPPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPPR
            // 
            this.lblPPR.AutoSize = true;
            this.lblPPR.Location = new System.Drawing.Point(226, 76);
            this.lblPPR.Name = "lblPPR";
            this.lblPPR.Size = new System.Drawing.Size(91, 24);
            this.lblPPR.TabIndex = 21;
            this.lblPPR.Text = "PPR\r\n(회전당 펄스수)";
            // 
            // formSxMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 303);
            this.Controls.Add(this.lblPPR);
            this.Controls.Add(this.tbxPPR);
            this.Controls.Add(this.chkSetRpm);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxAxisList);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlSpeedSetup);
            this.Controls.Add(this.rdoVel);
            this.Controls.Add(this.rdoAbs);
            this.Controls.Add(this.rdoRel);
            this.Controls.Add(this.rdoJog);
            this.Name = "formSxMove";
            this.Text = "formSxMove";
            this.pnlControl.ResumeLayout(false);
            this.tlpMove.ResumeLayout(false);
            this.tlpMove.PerformLayout();
            this.pnlSpeedSetup.ResumeLayout(false);
            this.tlpSpeedSetup.ResumeLayout(false);
            this.tlpSpeedSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Panel pnlSpeedSetup;
        private System.Windows.Forms.TableLayoutPanel tlpSpeedSetup;
        private System.Windows.Forms.Label lblSpeedMode_Title;
        private System.Windows.Forms.Label lblWorkSpeed_Title;
        private System.Windows.Forms.Label lblAcc_Title;
        private System.Windows.Forms.Label lblDec_Title;
        private System.Windows.Forms.Label lblInit_Title;
        private System.Windows.Forms.Label lblEnd_Title;
        private System.Windows.Forms.Label lblJerk_Title;
        private System.Windows.Forms.Label lblRatio_Title;
        private System.Windows.Forms.TrackBar trbRatio;
        private System.Windows.Forms.TextBox tbxWorkSpeed;
        private System.Windows.Forms.TextBox tbxAccel;
        private System.Windows.Forms.TextBox tbxDecel;
        private System.Windows.Forms.TextBox tbxInit;
        private System.Windows.Forms.TextBox tbxEnd;
        private System.Windows.Forms.TextBox tbxJerk;
        private System.Windows.Forms.ComboBox cbxSpeedMode;
        private System.Windows.Forms.Label lblSpeedSetup_Title;
        private System.Windows.Forms.RadioButton rdoVel;
        private System.Windows.Forms.RadioButton rdoAbs;
        private System.Windows.Forms.RadioButton rdoRel;
        private System.Windows.Forms.RadioButton rdoJog;
        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.CheckBox chkSetRpm;
        private System.Windows.Forms.TextBox tbxPPR;
        private System.Windows.Forms.Label lblPPR;
    }
}