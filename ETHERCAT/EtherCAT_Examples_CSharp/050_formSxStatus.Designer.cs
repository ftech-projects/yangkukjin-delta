namespace EtherCAT_Examples_CSharp
{
    partial class formSxStatus
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
            this.tlpStateMonitor = new System.Windows.Forms.TableLayoutPanel();
            this.lblAxisList = new System.Windows.Forms.Label();
            this.cbxAxisList = new System.Windows.Forms.ComboBox();
            this.lblCmdSpeed = new System.Windows.Forms.Label();
            this.lblCurPos = new System.Windows.Forms.Label();
            this.lblCmdPos = new System.Windows.Forms.Label();
            this.lblCurSpeed = new System.Windows.Forms.Label();
            this.lblTorque = new System.Windows.Forms.Label();
            this.lblTorq = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblCommand = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblAlState_Title = new System.Windows.Forms.Label();
            this.lblAlState = new System.Windows.Forms.Label();
            this.lblCommError = new System.Windows.Forms.Label();
            this.lblErrorCount = new System.Windows.Forms.Label();
            this.lblMotorState_Title = new System.Windows.Forms.Label();
            this.lblMotorState = new System.Windows.Forms.Label();
            this.lblReady_Title = new System.Windows.Forms.Label();
            this.lblWarning_Title = new System.Windows.Forms.Label();
            this.lblAlarm_Title = new System.Windows.Forms.Label();
            this.lblNEL_Title = new System.Windows.Forms.Label();
            this.lblPEL_Title = new System.Windows.Forms.Label();
            this.lblORG_Title = new System.Windows.Forms.Label();
            this.lblInpostion_Title = new System.Windows.Forms.Label();
            this.btnAlarmReset = new System.Windows.Forms.Button();
            this.btnResetErrCnt = new System.Windows.Forms.Button();
            this.btnServoOn = new System.Windows.Forms.Button();
            this.btnResetPosition = new System.Windows.Forms.Button();
            this.lblReady = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.lblNEL = new System.Windows.Forms.Label();
            this.lblPEL = new System.Windows.Forms.Label();
            this.lblORG = new System.Windows.Forms.Label();
            this.lblInposition = new System.Windows.Forms.Label();
            this.t_SxStatus = new System.Windows.Forms.Timer(this.components);
            this.tlpStateMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpStateMonitor
            // 
            this.tlpStateMonitor.BackColor = System.Drawing.Color.White;
            this.tlpStateMonitor.ColumnCount = 4;
            this.tlpStateMonitor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStateMonitor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStateMonitor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStateMonitor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStateMonitor.Controls.Add(this.lblAxisList, 0, 0);
            this.tlpStateMonitor.Controls.Add(this.cbxAxisList, 1, 0);
            this.tlpStateMonitor.Controls.Add(this.lblCmdSpeed, 2, 3);
            this.tlpStateMonitor.Controls.Add(this.lblCurPos, 1, 4);
            this.tlpStateMonitor.Controls.Add(this.lblCmdPos, 1, 3);
            this.tlpStateMonitor.Controls.Add(this.lblCurSpeed, 2, 4);
            this.tlpStateMonitor.Controls.Add(this.lblTorque, 3, 4);
            this.tlpStateMonitor.Controls.Add(this.lblTorq, 3, 2);
            this.tlpStateMonitor.Controls.Add(this.lblPos, 1, 2);
            this.tlpStateMonitor.Controls.Add(this.lblSpeed, 2, 2);
            this.tlpStateMonitor.Controls.Add(this.lblCommand, 0, 3);
            this.tlpStateMonitor.Controls.Add(this.lblCurrent, 0, 4);
            this.tlpStateMonitor.Controls.Add(this.lblAlState_Title, 0, 6);
            this.tlpStateMonitor.Controls.Add(this.lblAlState, 1, 6);
            this.tlpStateMonitor.Controls.Add(this.lblCommError, 2, 6);
            this.tlpStateMonitor.Controls.Add(this.lblErrorCount, 3, 6);
            this.tlpStateMonitor.Controls.Add(this.lblMotorState_Title, 0, 8);
            this.tlpStateMonitor.Controls.Add(this.lblMotorState, 1, 8);
            this.tlpStateMonitor.Controls.Add(this.lblReady_Title, 0, 10);
            this.tlpStateMonitor.Controls.Add(this.lblWarning_Title, 0, 11);
            this.tlpStateMonitor.Controls.Add(this.lblAlarm_Title, 0, 12);
            this.tlpStateMonitor.Controls.Add(this.lblNEL_Title, 2, 10);
            this.tlpStateMonitor.Controls.Add(this.lblPEL_Title, 2, 11);
            this.tlpStateMonitor.Controls.Add(this.lblORG_Title, 2, 12);
            this.tlpStateMonitor.Controls.Add(this.lblInpostion_Title, 2, 13);
            this.tlpStateMonitor.Controls.Add(this.btnAlarmReset, 1, 13);
            this.tlpStateMonitor.Controls.Add(this.btnResetErrCnt, 3, 7);
            this.tlpStateMonitor.Controls.Add(this.btnServoOn, 3, 0);
            this.tlpStateMonitor.Controls.Add(this.btnResetPosition, 0, 2);
            this.tlpStateMonitor.Controls.Add(this.lblReady, 1, 10);
            this.tlpStateMonitor.Controls.Add(this.lblWarning, 1, 11);
            this.tlpStateMonitor.Controls.Add(this.lblAlarm, 1, 12);
            this.tlpStateMonitor.Controls.Add(this.lblNEL, 3, 10);
            this.tlpStateMonitor.Controls.Add(this.lblPEL, 3, 11);
            this.tlpStateMonitor.Controls.Add(this.lblORG, 3, 12);
            this.tlpStateMonitor.Controls.Add(this.lblInposition, 3, 13);
            this.tlpStateMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStateMonitor.Location = new System.Drawing.Point(0, 0);
            this.tlpStateMonitor.Name = "tlpStateMonitor";
            this.tlpStateMonitor.RowCount = 15;
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStateMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStateMonitor.Size = new System.Drawing.Size(571, 438);
            this.tlpStateMonitor.TabIndex = 2;
            // 
            // lblAxisList
            // 
            this.lblAxisList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAxisList.AutoSize = true;
            this.lblAxisList.Location = new System.Drawing.Point(3, 0);
            this.lblAxisList.Name = "lblAxisList";
            this.lblAxisList.Size = new System.Drawing.Size(136, 30);
            this.lblAxisList.TabIndex = 3;
            this.lblAxisList.Text = "Axis";
            this.lblAxisList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxAxisList
            // 
            this.cbxAxisList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAxisList.FormattingEnabled = true;
            this.cbxAxisList.Location = new System.Drawing.Point(145, 3);
            this.cbxAxisList.Name = "cbxAxisList";
            this.cbxAxisList.Size = new System.Drawing.Size(136, 20);
            this.cbxAxisList.TabIndex = 4;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblCmdSpeed
            // 
            this.lblCmdSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCmdSpeed.AutoSize = true;
            this.lblCmdSpeed.Location = new System.Drawing.Point(287, 96);
            this.lblCmdSpeed.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCmdSpeed.Name = "lblCmdSpeed";
            this.lblCmdSpeed.Size = new System.Drawing.Size(136, 18);
            this.lblCmdSpeed.TabIndex = 1;
            this.lblCmdSpeed.Text = "2";
            this.lblCmdSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurPos
            // 
            this.lblCurPos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurPos.AutoSize = true;
            this.lblCurPos.Location = new System.Drawing.Point(145, 126);
            this.lblCurPos.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCurPos.Name = "lblCurPos";
            this.lblCurPos.Size = new System.Drawing.Size(136, 18);
            this.lblCurPos.TabIndex = 1;
            this.lblCurPos.Text = "1";
            this.lblCurPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCmdPos
            // 
            this.lblCmdPos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCmdPos.AutoSize = true;
            this.lblCmdPos.Location = new System.Drawing.Point(145, 96);
            this.lblCmdPos.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCmdPos.Name = "lblCmdPos";
            this.lblCmdPos.Size = new System.Drawing.Size(136, 18);
            this.lblCmdPos.TabIndex = 1;
            this.lblCmdPos.Text = "0";
            this.lblCmdPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurSpeed
            // 
            this.lblCurSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurSpeed.AutoSize = true;
            this.lblCurSpeed.Location = new System.Drawing.Point(287, 126);
            this.lblCurSpeed.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCurSpeed.Name = "lblCurSpeed";
            this.lblCurSpeed.Size = new System.Drawing.Size(136, 18);
            this.lblCurSpeed.TabIndex = 1;
            this.lblCurSpeed.Text = "3";
            this.lblCurSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTorque
            // 
            this.lblTorque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTorque.AutoSize = true;
            this.lblTorque.Location = new System.Drawing.Point(429, 126);
            this.lblTorque.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTorque.Name = "lblTorque";
            this.lblTorque.Size = new System.Drawing.Size(139, 18);
            this.lblTorque.TabIndex = 1;
            this.lblTorque.Text = "4";
            this.lblTorque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTorq
            // 
            this.lblTorq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTorq.AutoSize = true;
            this.lblTorq.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTorq.Location = new System.Drawing.Point(429, 66);
            this.lblTorq.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTorq.Name = "lblTorq";
            this.lblTorq.Size = new System.Drawing.Size(139, 18);
            this.lblTorq.TabIndex = 1;
            this.lblTorq.Text = "Torque";
            this.lblTorq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPos
            // 
            this.lblPos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPos.Location = new System.Drawing.Point(145, 66);
            this.lblPos.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(136, 18);
            this.lblPos.TabIndex = 1;
            this.lblPos.Text = "Position";
            this.lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSpeed.Location = new System.Drawing.Point(287, 66);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(136, 18);
            this.lblSpeed.TabIndex = 1;
            this.lblSpeed.Text = "Speed";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCommand
            // 
            this.lblCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCommand.Location = new System.Drawing.Point(3, 96);
            this.lblCommand.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(136, 18);
            this.lblCommand.TabIndex = 1;
            this.lblCommand.Text = "Command";
            this.lblCommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrent
            // 
            this.lblCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCurrent.Location = new System.Drawing.Point(3, 126);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(136, 18);
            this.lblCurrent.TabIndex = 1;
            this.lblCurrent.Text = "Current";
            this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlState_Title
            // 
            this.lblAlState_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlState_Title.AutoSize = true;
            this.lblAlState_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAlState_Title.Location = new System.Drawing.Point(3, 186);
            this.lblAlState_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAlState_Title.Name = "lblAlState_Title";
            this.lblAlState_Title.Size = new System.Drawing.Size(136, 18);
            this.lblAlState_Title.TabIndex = 1;
            this.lblAlState_Title.Text = "AlState";
            this.lblAlState_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlState
            // 
            this.lblAlState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlState.AutoSize = true;
            this.lblAlState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAlState.ForeColor = System.Drawing.Color.Black;
            this.lblAlState.Location = new System.Drawing.Point(145, 186);
            this.lblAlState.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAlState.Name = "lblAlState";
            this.lblAlState.Size = new System.Drawing.Size(136, 18);
            this.lblAlState.TabIndex = 1;
            this.lblAlState.Text = "alState";
            this.lblAlState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCommError
            // 
            this.lblCommError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommError.AutoSize = true;
            this.lblCommError.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCommError.Location = new System.Drawing.Point(287, 186);
            this.lblCommError.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCommError.Name = "lblCommError";
            this.lblCommError.Size = new System.Drawing.Size(136, 18);
            this.lblCommError.TabIndex = 1;
            this.lblCommError.Text = "Error Count";
            this.lblCommError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrorCount
            // 
            this.lblErrorCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCount.AutoSize = true;
            this.lblErrorCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblErrorCount.ForeColor = System.Drawing.Color.Black;
            this.lblErrorCount.Location = new System.Drawing.Point(429, 186);
            this.lblErrorCount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblErrorCount.Name = "lblErrorCount";
            this.lblErrorCount.Size = new System.Drawing.Size(139, 18);
            this.lblErrorCount.TabIndex = 1;
            this.lblErrorCount.Text = "errorCount";
            this.lblErrorCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMotorState_Title
            // 
            this.lblMotorState_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMotorState_Title.AutoSize = true;
            this.lblMotorState_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMotorState_Title.Location = new System.Drawing.Point(3, 246);
            this.lblMotorState_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMotorState_Title.Name = "lblMotorState_Title";
            this.lblMotorState_Title.Size = new System.Drawing.Size(136, 18);
            this.lblMotorState_Title.TabIndex = 1;
            this.lblMotorState_Title.Text = "Motor State";
            this.lblMotorState_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMotorState
            // 
            this.lblMotorState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMotorState.AutoSize = true;
            this.lblMotorState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMotorState.ForeColor = System.Drawing.Color.Black;
            this.lblMotorState.Location = new System.Drawing.Point(145, 246);
            this.lblMotorState.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMotorState.Name = "lblMotorState";
            this.lblMotorState.Size = new System.Drawing.Size(136, 18);
            this.lblMotorState.TabIndex = 1;
            this.lblMotorState.Text = "motor State";
            this.lblMotorState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReady_Title
            // 
            this.lblReady_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReady_Title.AutoSize = true;
            this.lblReady_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblReady_Title.Location = new System.Drawing.Point(3, 306);
            this.lblReady_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblReady_Title.Name = "lblReady_Title";
            this.lblReady_Title.Size = new System.Drawing.Size(136, 18);
            this.lblReady_Title.TabIndex = 1;
            this.lblReady_Title.Text = "Ready";
            this.lblReady_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWarning_Title
            // 
            this.lblWarning_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarning_Title.AutoSize = true;
            this.lblWarning_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWarning_Title.Location = new System.Drawing.Point(3, 336);
            this.lblWarning_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWarning_Title.Name = "lblWarning_Title";
            this.lblWarning_Title.Size = new System.Drawing.Size(136, 18);
            this.lblWarning_Title.TabIndex = 1;
            this.lblWarning_Title.Text = "Warning";
            this.lblWarning_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlarm_Title
            // 
            this.lblAlarm_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlarm_Title.AutoSize = true;
            this.lblAlarm_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAlarm_Title.Location = new System.Drawing.Point(3, 366);
            this.lblAlarm_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAlarm_Title.Name = "lblAlarm_Title";
            this.lblAlarm_Title.Size = new System.Drawing.Size(136, 18);
            this.lblAlarm_Title.TabIndex = 1;
            this.lblAlarm_Title.Text = "Alarm";
            this.lblAlarm_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNEL_Title
            // 
            this.lblNEL_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNEL_Title.AutoSize = true;
            this.lblNEL_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNEL_Title.Location = new System.Drawing.Point(287, 306);
            this.lblNEL_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNEL_Title.Name = "lblNEL_Title";
            this.lblNEL_Title.Size = new System.Drawing.Size(136, 18);
            this.lblNEL_Title.TabIndex = 1;
            this.lblNEL_Title.Text = "Limit (-)";
            this.lblNEL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPEL_Title
            // 
            this.lblPEL_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPEL_Title.AutoSize = true;
            this.lblPEL_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPEL_Title.Location = new System.Drawing.Point(287, 336);
            this.lblPEL_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPEL_Title.Name = "lblPEL_Title";
            this.lblPEL_Title.Size = new System.Drawing.Size(136, 18);
            this.lblPEL_Title.TabIndex = 1;
            this.lblPEL_Title.Text = "Limit (+)";
            this.lblPEL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblORG_Title
            // 
            this.lblORG_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblORG_Title.AutoSize = true;
            this.lblORG_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblORG_Title.Location = new System.Drawing.Point(287, 366);
            this.lblORG_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblORG_Title.Name = "lblORG_Title";
            this.lblORG_Title.Size = new System.Drawing.Size(136, 18);
            this.lblORG_Title.TabIndex = 1;
            this.lblORG_Title.Text = "Origin";
            this.lblORG_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInpostion_Title
            // 
            this.lblInpostion_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInpostion_Title.AutoSize = true;
            this.lblInpostion_Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInpostion_Title.Location = new System.Drawing.Point(287, 396);
            this.lblInpostion_Title.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblInpostion_Title.Name = "lblInpostion_Title";
            this.lblInpostion_Title.Size = new System.Drawing.Size(136, 18);
            this.lblInpostion_Title.TabIndex = 1;
            this.lblInpostion_Title.Text = "Inposition";
            this.lblInpostion_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlarmReset
            // 
            this.btnAlarmReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlarmReset.BackColor = System.Drawing.Color.White;
            this.btnAlarmReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarmReset.Location = new System.Drawing.Point(145, 393);
            this.btnAlarmReset.Name = "btnAlarmReset";
            this.btnAlarmReset.Size = new System.Drawing.Size(136, 24);
            this.btnAlarmReset.TabIndex = 2;
            this.btnAlarmReset.Text = "Reset Alarm";
            this.btnAlarmReset.UseVisualStyleBackColor = false;
            this.btnAlarmReset.Click += new System.EventHandler(this.btnAlarmReset_Click);
            // 
            // btnResetErrCnt
            // 
            this.btnResetErrCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetErrCnt.BackColor = System.Drawing.Color.White;
            this.btnResetErrCnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetErrCnt.Location = new System.Drawing.Point(429, 213);
            this.btnResetErrCnt.Name = "btnResetErrCnt";
            this.btnResetErrCnt.Size = new System.Drawing.Size(139, 24);
            this.btnResetErrCnt.TabIndex = 2;
            this.btnResetErrCnt.Text = "Reset ErrorCount";
            this.btnResetErrCnt.UseVisualStyleBackColor = false;
            this.btnResetErrCnt.Click += new System.EventHandler(this.btnAlarmReset_Click);
            // 
            // btnServoOn
            // 
            this.btnServoOn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServoOn.BackColor = System.Drawing.Color.White;
            this.btnServoOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServoOn.Location = new System.Drawing.Point(429, 3);
            this.btnServoOn.Name = "btnServoOn";
            this.btnServoOn.Size = new System.Drawing.Size(139, 24);
            this.btnServoOn.TabIndex = 2;
            this.btnServoOn.Text = "ServoOn";
            this.btnServoOn.UseVisualStyleBackColor = false;
            this.btnServoOn.Click += new System.EventHandler(this.btnServoOn_Click);
            // 
            // btnResetPosition
            // 
            this.btnResetPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPosition.BackColor = System.Drawing.Color.White;
            this.btnResetPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPosition.Location = new System.Drawing.Point(3, 63);
            this.btnResetPosition.Name = "btnResetPosition";
            this.btnResetPosition.Size = new System.Drawing.Size(136, 24);
            this.btnResetPosition.TabIndex = 2;
            this.btnResetPosition.Text = "Reset Position";
            this.btnResetPosition.UseVisualStyleBackColor = false;
            this.btnResetPosition.Click += new System.EventHandler(this.btnResetPosition_Click);
            // 
            // lblReady
            // 
            this.lblReady.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReady.AutoSize = true;
            this.lblReady.BackColor = System.Drawing.Color.Gray;
            this.lblReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReady.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblReady.Location = new System.Drawing.Point(145, 306);
            this.lblReady.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(136, 18);
            this.lblReady.TabIndex = 1;
            this.lblReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Gray;
            this.lblWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWarning.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblWarning.Location = new System.Drawing.Point(145, 336);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(136, 18);
            this.lblWarning.TabIndex = 1;
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlarm
            // 
            this.lblAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.BackColor = System.Drawing.Color.Gray;
            this.lblAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAlarm.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAlarm.Location = new System.Drawing.Point(145, 366);
            this.lblAlarm.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(136, 18);
            this.lblAlarm.TabIndex = 1;
            this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNEL
            // 
            this.lblNEL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNEL.AutoSize = true;
            this.lblNEL.BackColor = System.Drawing.Color.Gray;
            this.lblNEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNEL.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblNEL.Location = new System.Drawing.Point(429, 306);
            this.lblNEL.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNEL.Name = "lblNEL";
            this.lblNEL.Size = new System.Drawing.Size(139, 18);
            this.lblNEL.TabIndex = 1;
            this.lblNEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPEL
            // 
            this.lblPEL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPEL.AutoSize = true;
            this.lblPEL.BackColor = System.Drawing.Color.Gray;
            this.lblPEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPEL.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPEL.Location = new System.Drawing.Point(429, 336);
            this.lblPEL.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPEL.Name = "lblPEL";
            this.lblPEL.Size = new System.Drawing.Size(139, 18);
            this.lblPEL.TabIndex = 1;
            this.lblPEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblORG
            // 
            this.lblORG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblORG.AutoSize = true;
            this.lblORG.BackColor = System.Drawing.Color.Gray;
            this.lblORG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblORG.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblORG.Location = new System.Drawing.Point(429, 366);
            this.lblORG.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblORG.Name = "lblORG";
            this.lblORG.Size = new System.Drawing.Size(139, 18);
            this.lblORG.TabIndex = 1;
            this.lblORG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInposition
            // 
            this.lblInposition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInposition.AutoSize = true;
            this.lblInposition.BackColor = System.Drawing.Color.Gray;
            this.lblInposition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInposition.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblInposition.Location = new System.Drawing.Point(429, 396);
            this.lblInposition.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblInposition.Name = "lblInposition";
            this.lblInposition.Size = new System.Drawing.Size(139, 18);
            this.lblInposition.TabIndex = 1;
            this.lblInposition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_SxStatus
            // 
            this.t_SxStatus.Interval = 50;
            this.t_SxStatus.Tick += new System.EventHandler(this.t_SxStatus_Tick);
            // 
            // formSxStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 438);
            this.Controls.Add(this.tlpStateMonitor);
            this.Name = "formSxStatus";
            this.Text = "SxStatus";
            this.tlpStateMonitor.ResumeLayout(false);
            this.tlpStateMonitor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpStateMonitor;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblTorq;
        private System.Windows.Forms.Label lblCmdPos;
        private System.Windows.Forms.Label lblCurPos;
        private System.Windows.Forms.Label lblCmdSpeed;
        private System.Windows.Forms.Label lblCurSpeed;
        private System.Windows.Forms.Label lblTorque;
        private System.Windows.Forms.Label lblAlarm_Title;
        private System.Windows.Forms.Label lblNEL_Title;
        private System.Windows.Forms.Label lblReady_Title;
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Button btnResetPosition;
        private System.Windows.Forms.Label lblAlState_Title;
        private System.Windows.Forms.Label lblAlState;
        private System.Windows.Forms.Label lblMotorState;
        private System.Windows.Forms.Label lblMotorState_Title;
        private System.Windows.Forms.Label lblInpostion_Title;
        private System.Windows.Forms.Label lblAxisList;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.Button btnServoOn;
        private System.Windows.Forms.Button btnAlarmReset;
        private System.Windows.Forms.Timer t_SxStatus;
        private System.Windows.Forms.Label lblPEL_Title;
        private System.Windows.Forms.Label lblORG_Title;
        private System.Windows.Forms.Label lblWarning_Title;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label lblCommError;
        private System.Windows.Forms.Label lblErrorCount;
        private System.Windows.Forms.Button btnResetErrCnt;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblNEL;
        private System.Windows.Forms.Label lblPEL;
        private System.Windows.Forms.Label lblORG;
        private System.Windows.Forms.Label lblInposition;
    }
}