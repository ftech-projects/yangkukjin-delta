namespace EtherCAT_Examples_CSharp
{
    partial class formHoming
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
            this.tlpHomingSpeed = new System.Windows.Forms.TableLayoutPanel();
            this.lblHomeSpeedMode_Title = new System.Windows.Forms.Label();
            this.lblHomeWorkSpeed_Title = new System.Windows.Forms.Label();
            this.HomeAccel_Title = new System.Windows.Forms.Label();
            this.HomeDecel_Title = new System.Windows.Forms.Label();
            this.HomeSpec_Title = new System.Windows.Forms.Label();
            this.tbxHomeWorkSpeed = new System.Windows.Forms.TextBox();
            this.tbxHomeAccel = new System.Windows.Forms.TextBox();
            this.tbxHomeDecel = new System.Windows.Forms.TextBox();
            this.tbxHomeSpec = new System.Windows.Forms.TextBox();
            this.cbxSpeedMode = new System.Windows.Forms.ComboBox();
            this.lblHomeSpeedSetup_Title = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.cbxAxisList = new System.Windows.Forms.ComboBox();
            this.lblAxis = new System.Windows.Forms.Label();
            this.lblOffsetDist = new System.Windows.Forms.Label();
            this.tbxOffDis = new System.Windows.Forms.TextBox();
            this.lblHomeMode = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblTouchProbeEdge = new System.Windows.Forms.Label();
            this.cbxHomeDir = new System.Windows.Forms.ComboBox();
            this.cbxHomeTpEdge = new System.Windows.Forms.ComboBox();
            this.btnHommingState = new System.Windows.Forms.Button();
            this.btnHomeStart = new System.Windows.Forms.Button();
            this.btnHomeStop = new System.Windows.Forms.Button();
            this.tbxHomeMode = new System.Windows.Forms.TextBox();
            this.tlpHomingSpeed.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpHomingSpeed
            // 
            this.tlpHomingSpeed.BackColor = System.Drawing.Color.White;
            this.tlpHomingSpeed.ColumnCount = 2;
            this.tlpHomingSpeed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHomingSpeed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHomingSpeed.Controls.Add(this.lblHomeSpeedMode_Title, 0, 1);
            this.tlpHomingSpeed.Controls.Add(this.lblHomeWorkSpeed_Title, 0, 2);
            this.tlpHomingSpeed.Controls.Add(this.HomeAccel_Title, 0, 3);
            this.tlpHomingSpeed.Controls.Add(this.HomeDecel_Title, 0, 4);
            this.tlpHomingSpeed.Controls.Add(this.HomeSpec_Title, 0, 5);
            this.tlpHomingSpeed.Controls.Add(this.tbxHomeWorkSpeed, 1, 2);
            this.tlpHomingSpeed.Controls.Add(this.tbxHomeAccel, 1, 3);
            this.tlpHomingSpeed.Controls.Add(this.tbxHomeDecel, 1, 4);
            this.tlpHomingSpeed.Controls.Add(this.tbxHomeSpec, 1, 5);
            this.tlpHomingSpeed.Controls.Add(this.cbxSpeedMode, 1, 1);
            this.tlpHomingSpeed.Controls.Add(this.lblHomeSpeedSetup_Title, 0, 0);
            this.tlpHomingSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHomingSpeed.Location = new System.Drawing.Point(348, 0);
            this.tlpHomingSpeed.Name = "tlpHomingSpeed";
            this.tlpHomingSpeed.RowCount = 10;
            this.tlpHomingSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHomingSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHomingSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHomingSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHomingSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHomingSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHomingSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHomingSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHomingSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHomingSpeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHomingSpeed.Size = new System.Drawing.Size(274, 359);
            this.tlpHomingSpeed.TabIndex = 9;
            // 
            // lblHomeSpeedMode_Title
            // 
            this.lblHomeSpeedMode_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHomeSpeedMode_Title.AutoSize = true;
            this.lblHomeSpeedMode_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHomeSpeedMode_Title.Location = new System.Drawing.Point(3, 41);
            this.lblHomeSpeedMode_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblHomeSpeedMode_Title.Name = "lblHomeSpeedMode_Title";
            this.lblHomeSpeedMode_Title.Size = new System.Drawing.Size(131, 23);
            this.lblHomeSpeedMode_Title.TabIndex = 1;
            this.lblHomeSpeedMode_Title.Text = "SpeedMode";
            this.lblHomeSpeedMode_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHomeWorkSpeed_Title
            // 
            this.lblHomeWorkSpeed_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHomeWorkSpeed_Title.AutoSize = true;
            this.lblHomeWorkSpeed_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHomeWorkSpeed_Title.Location = new System.Drawing.Point(3, 76);
            this.lblHomeWorkSpeed_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblHomeWorkSpeed_Title.Name = "lblHomeWorkSpeed_Title";
            this.lblHomeWorkSpeed_Title.Size = new System.Drawing.Size(131, 23);
            this.lblHomeWorkSpeed_Title.TabIndex = 1;
            this.lblHomeWorkSpeed_Title.Text = "WorkSpeed";
            this.lblHomeWorkSpeed_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeAccel_Title
            // 
            this.HomeAccel_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeAccel_Title.AutoSize = true;
            this.HomeAccel_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HomeAccel_Title.Location = new System.Drawing.Point(3, 111);
            this.HomeAccel_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.HomeAccel_Title.Name = "HomeAccel_Title";
            this.HomeAccel_Title.Size = new System.Drawing.Size(131, 23);
            this.HomeAccel_Title.TabIndex = 1;
            this.HomeAccel_Title.Text = "Accek";
            this.HomeAccel_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeDecel_Title
            // 
            this.HomeDecel_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeDecel_Title.AutoSize = true;
            this.HomeDecel_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HomeDecel_Title.Location = new System.Drawing.Point(3, 146);
            this.HomeDecel_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.HomeDecel_Title.Name = "HomeDecel_Title";
            this.HomeDecel_Title.Size = new System.Drawing.Size(131, 23);
            this.HomeDecel_Title.TabIndex = 1;
            this.HomeDecel_Title.Text = "Decel";
            this.HomeDecel_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeSpec_Title
            // 
            this.HomeSpec_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeSpec_Title.AutoSize = true;
            this.HomeSpec_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HomeSpec_Title.Location = new System.Drawing.Point(3, 181);
            this.HomeSpec_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.HomeSpec_Title.Name = "HomeSpec_Title";
            this.HomeSpec_Title.Size = new System.Drawing.Size(131, 23);
            this.HomeSpec_Title.TabIndex = 1;
            this.HomeSpec_Title.Text = "SpecSpeed";
            this.HomeSpec_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxHomeWorkSpeed
            // 
            this.tbxHomeWorkSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHomeWorkSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHomeWorkSpeed.Location = new System.Drawing.Point(140, 73);
            this.tbxHomeWorkSpeed.Name = "tbxHomeWorkSpeed";
            this.tbxHomeWorkSpeed.Size = new System.Drawing.Size(131, 21);
            this.tbxHomeWorkSpeed.TabIndex = 3;
            // 
            // tbxHomeAccel
            // 
            this.tbxHomeAccel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHomeAccel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHomeAccel.Location = new System.Drawing.Point(140, 108);
            this.tbxHomeAccel.Name = "tbxHomeAccel";
            this.tbxHomeAccel.Size = new System.Drawing.Size(131, 21);
            this.tbxHomeAccel.TabIndex = 3;
            // 
            // tbxHomeDecel
            // 
            this.tbxHomeDecel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHomeDecel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHomeDecel.Location = new System.Drawing.Point(140, 143);
            this.tbxHomeDecel.Name = "tbxHomeDecel";
            this.tbxHomeDecel.Size = new System.Drawing.Size(131, 21);
            this.tbxHomeDecel.TabIndex = 3;
            // 
            // tbxHomeSpec
            // 
            this.tbxHomeSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHomeSpec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHomeSpec.Location = new System.Drawing.Point(140, 178);
            this.tbxHomeSpec.Name = "tbxHomeSpec";
            this.tbxHomeSpec.Size = new System.Drawing.Size(131, 21);
            this.tbxHomeSpec.TabIndex = 3;
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
            this.cbxSpeedMode.Location = new System.Drawing.Point(140, 38);
            this.cbxSpeedMode.Name = "cbxSpeedMode";
            this.cbxSpeedMode.Size = new System.Drawing.Size(131, 20);
            this.cbxSpeedMode.TabIndex = 4;
            // 
            // lblHomeSpeedSetup_Title
            // 
            this.lblHomeSpeedSetup_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHomeSpeedSetup_Title.AutoSize = true;
            this.lblHomeSpeedSetup_Title.BackColor = System.Drawing.Color.Black;
            this.tlpHomingSpeed.SetColumnSpan(this.lblHomeSpeedSetup_Title, 2);
            this.lblHomeSpeedSetup_Title.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHomeSpeedSetup_Title.ForeColor = System.Drawing.Color.White;
            this.lblHomeSpeedSetup_Title.Location = new System.Drawing.Point(0, 0);
            this.lblHomeSpeedSetup_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lblHomeSpeedSetup_Title.Name = "lblHomeSpeedSetup_Title";
            this.lblHomeSpeedSetup_Title.Size = new System.Drawing.Size(274, 35);
            this.lblHomeSpeedSetup_Title.TabIndex = 0;
            this.lblHomeSpeedSetup_Title.Text = "Homing Speed Setup";
            this.lblHomeSpeedSetup_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.White;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.cbxAxisList, 1, 0);
            this.tlpMain.Controls.Add(this.lblAxis, 0, 0);
            this.tlpMain.Controls.Add(this.lblOffsetDist, 0, 2);
            this.tlpMain.Controls.Add(this.tbxOffDis, 1, 2);
            this.tlpMain.Controls.Add(this.lblHomeMode, 0, 1);
            this.tlpMain.Controls.Add(this.lblDir, 0, 3);
            this.tlpMain.Controls.Add(this.lblTouchProbeEdge, 0, 4);
            this.tlpMain.Controls.Add(this.cbxHomeDir, 1, 3);
            this.tlpMain.Controls.Add(this.cbxHomeTpEdge, 1, 4);
            this.tlpMain.Controls.Add(this.btnHommingState, 1, 6);
            this.tlpMain.Controls.Add(this.btnHomeStart, 0, 7);
            this.tlpMain.Controls.Add(this.btnHomeStop, 1, 7);
            this.tlpMain.Controls.Add(this.tbxHomeMode, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(6);
            this.tlpMain.RowCount = 8;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(348, 359);
            this.tlpMain.TabIndex = 8;
            // 
            // cbxAxisList
            // 
            this.cbxAxisList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAxisList.FormattingEnabled = true;
            this.cbxAxisList.Location = new System.Drawing.Point(177, 9);
            this.cbxAxisList.Name = "cbxAxisList";
            this.cbxAxisList.Size = new System.Drawing.Size(162, 20);
            this.cbxAxisList.TabIndex = 95;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblAxis
            // 
            this.lblAxis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAxis.AutoSize = true;
            this.lblAxis.Location = new System.Drawing.Point(9, 6);
            this.lblAxis.Name = "lblAxis";
            this.lblAxis.Size = new System.Drawing.Size(162, 34);
            this.lblAxis.TabIndex = 94;
            this.lblAxis.Text = "Axis";
            this.lblAxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOffsetDist
            // 
            this.lblOffsetDist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOffsetDist.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblOffsetDist.ForeColor = System.Drawing.Color.Black;
            this.lblOffsetDist.Location = new System.Drawing.Point(9, 77);
            this.lblOffsetDist.Margin = new System.Windows.Forms.Padding(3);
            this.lblOffsetDist.Name = "lblOffsetDist";
            this.lblOffsetDist.Size = new System.Drawing.Size(162, 18);
            this.lblOffsetDist.TabIndex = 89;
            this.lblOffsetDist.Text = "Offset Distance";
            this.lblOffsetDist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxOffDis
            // 
            this.tbxOffDis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOffDis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxOffDis.Font = new System.Drawing.Font("Arial", 9.5F);
            this.tbxOffDis.Location = new System.Drawing.Point(177, 77);
            this.tbxOffDis.Name = "tbxOffDis";
            this.tbxOffDis.Size = new System.Drawing.Size(162, 22);
            this.tbxOffDis.TabIndex = 91;
            this.tbxOffDis.Text = "0";
            this.tbxOffDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHomeMode
            // 
            this.lblHomeMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHomeMode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblHomeMode.ForeColor = System.Drawing.Color.Black;
            this.lblHomeMode.Location = new System.Drawing.Point(9, 43);
            this.lblHomeMode.Margin = new System.Windows.Forms.Padding(3);
            this.lblHomeMode.Name = "lblHomeMode";
            this.lblHomeMode.Size = new System.Drawing.Size(162, 18);
            this.lblHomeMode.TabIndex = 89;
            this.lblHomeMode.Text = "Home Mode";
            this.lblHomeMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDir
            // 
            this.lblDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblDir.ForeColor = System.Drawing.Color.Black;
            this.lblDir.Location = new System.Drawing.Point(9, 111);
            this.lblDir.Margin = new System.Windows.Forms.Padding(3);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(162, 28);
            this.lblDir.TabIndex = 88;
            this.lblDir.Text = "Direction";
            this.lblDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTouchProbeEdge
            // 
            this.lblTouchProbeEdge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTouchProbeEdge.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTouchProbeEdge.ForeColor = System.Drawing.Color.Black;
            this.lblTouchProbeEdge.Location = new System.Drawing.Point(9, 145);
            this.lblTouchProbeEdge.Margin = new System.Windows.Forms.Padding(3);
            this.lblTouchProbeEdge.Name = "lblTouchProbeEdge";
            this.lblTouchProbeEdge.Size = new System.Drawing.Size(162, 28);
            this.lblTouchProbeEdge.TabIndex = 88;
            this.lblTouchProbeEdge.Text = "Touch Probe Edge";
            this.lblTouchProbeEdge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxHomeDir
            // 
            this.cbxHomeDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxHomeDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHomeDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxHomeDir.FormattingEnabled = true;
            this.cbxHomeDir.Items.AddRange(new object[] {
            "(-)",
            "(+)"});
            this.cbxHomeDir.Location = new System.Drawing.Point(177, 111);
            this.cbxHomeDir.Name = "cbxHomeDir";
            this.cbxHomeDir.Size = new System.Drawing.Size(162, 20);
            this.cbxHomeDir.TabIndex = 92;
            // 
            // cbxHomeTpEdge
            // 
            this.cbxHomeTpEdge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxHomeTpEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHomeTpEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxHomeTpEdge.FormattingEnabled = true;
            this.cbxHomeTpEdge.Items.AddRange(new object[] {
            "Falling",
            "Rising"});
            this.cbxHomeTpEdge.Location = new System.Drawing.Point(177, 145);
            this.cbxHomeTpEdge.Name = "cbxHomeTpEdge";
            this.cbxHomeTpEdge.Size = new System.Drawing.Size(162, 20);
            this.cbxHomeTpEdge.TabIndex = 92;
            // 
            // btnHommingState
            // 
            this.btnHommingState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHommingState.BackColor = System.Drawing.Color.Transparent;
            this.btnHommingState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHommingState.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHommingState.ForeColor = System.Drawing.Color.SlateGray;
            this.btnHommingState.Location = new System.Drawing.Point(177, 213);
            this.btnHommingState.Name = "btnHommingState";
            this.btnHommingState.Size = new System.Drawing.Size(162, 63);
            this.btnHommingState.TabIndex = 79;
            this.btnHommingState.Text = "Ready";
            this.btnHommingState.UseVisualStyleBackColor = false;
            // 
            // btnHomeStart
            // 
            this.btnHomeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHomeStart.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHomeStart.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHomeStart.ForeColor = System.Drawing.Color.SlateGray;
            this.btnHomeStart.Location = new System.Drawing.Point(9, 282);
            this.btnHomeStart.Name = "btnHomeStart";
            this.btnHomeStart.Size = new System.Drawing.Size(162, 68);
            this.btnHomeStart.TabIndex = 79;
            this.btnHomeStart.Text = "Start";
            this.btnHomeStart.UseVisualStyleBackColor = false;
            this.btnHomeStart.Click += new System.EventHandler(this.btnHomeStart_Click);
            // 
            // btnHomeStop
            // 
            this.btnHomeStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHomeStop.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHomeStop.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHomeStop.ForeColor = System.Drawing.Color.SlateGray;
            this.btnHomeStop.Location = new System.Drawing.Point(177, 282);
            this.btnHomeStop.Name = "btnHomeStop";
            this.btnHomeStop.Size = new System.Drawing.Size(162, 68);
            this.btnHomeStop.TabIndex = 79;
            this.btnHomeStop.Text = "Stop";
            this.btnHomeStop.UseVisualStyleBackColor = false;
            this.btnHomeStop.Click += new System.EventHandler(this.btnHomeStop_Click);
            // 
            // tbxHomeMode
            // 
            this.tbxHomeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHomeMode.Location = new System.Drawing.Point(177, 43);
            this.tbxHomeMode.Name = "tbxHomeMode";
            this.tbxHomeMode.Size = new System.Drawing.Size(162, 21);
            this.tbxHomeMode.TabIndex = 93;
            // 
            // formHoming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 359);
            this.Controls.Add(this.tlpHomingSpeed);
            this.Controls.Add(this.tlpMain);
            this.Name = "formHoming";
            this.Text = "formHoming";
            this.tlpHomingSpeed.ResumeLayout(false);
            this.tlpHomingSpeed.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpHomingSpeed;
        private System.Windows.Forms.Label lblHomeSpeedMode_Title;
        private System.Windows.Forms.Label lblHomeWorkSpeed_Title;
        private System.Windows.Forms.Label HomeAccel_Title;
        private System.Windows.Forms.Label HomeDecel_Title;
        private System.Windows.Forms.Label HomeSpec_Title;
        private System.Windows.Forms.TextBox tbxHomeWorkSpeed;
        private System.Windows.Forms.TextBox tbxHomeAccel;
        private System.Windows.Forms.TextBox tbxHomeDecel;
        private System.Windows.Forms.TextBox tbxHomeSpec;
        private System.Windows.Forms.ComboBox cbxSpeedMode;
        private System.Windows.Forms.Label lblHomeSpeedSetup_Title;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        internal System.Windows.Forms.Label lblOffsetDist;
        internal System.Windows.Forms.TextBox tbxOffDis;
        internal System.Windows.Forms.Label lblHomeMode;
        internal System.Windows.Forms.Label lblDir;
        internal System.Windows.Forms.Label lblTouchProbeEdge;
        private System.Windows.Forms.ComboBox cbxHomeDir;
        private System.Windows.Forms.ComboBox cbxHomeTpEdge;
        internal System.Windows.Forms.Button btnHommingState;
        internal System.Windows.Forms.Button btnHomeStart;
        internal System.Windows.Forms.Button btnHomeStop;
        private System.Windows.Forms.TextBox tbxHomeMode;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.Label lblAxis;
    }
}