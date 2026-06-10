namespace EtherCAT_Examples_CSharp
{
    partial class formCmpOne
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
            this.tlpCMP = new System.Windows.Forms.TableLayoutPanel();
            this.cbxAxisList = new System.Windows.Forms.ComboBox();
            this.lblAxis = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.cbxMethod = new System.Windows.Forms.ComboBox();
            this.lblCntrType = new System.Windows.Forms.Label();
            this.cbxCntrType = new System.Windows.Forms.ComboBox();
            this.rdoOut_OnBoard = new System.Windows.Forms.RadioButton();
            this.rdoOut_Global = new System.Windows.Forms.RadioButton();
            this.cbxOut_OnBoard = new System.Windows.Forms.ComboBox();
            this.cbxOut_Global = new System.Windows.Forms.ComboBox();
            this.cbxLogic = new System.Windows.Forms.ComboBox();
            this.lblLogic = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.tbxDuration = new System.Windows.Forms.TextBox();
            this.lblNotifyType_Title = new System.Windows.Forms.Label();
            this.cbxTypeSel = new System.Windows.Forms.ComboBox();
            this.lbxPosition = new System.Windows.Forms.ListBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.tbxPosition = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.btnCmpMove = new System.Windows.Forms.Button();
            this.lblMovePosition = new System.Windows.Forms.Label();
            this.tbxCmpDist = new System.Windows.Forms.TextBox();
            this.lblOutCount_T = new System.Windows.Forms.Label();
            this.lblLastPos_T = new System.Windows.Forms.Label();
            this.lblOutCount = new System.Windows.Forms.Label();
            this.lblOutPosition = new System.Windows.Forms.Label();
            this.btnCmpOneStop = new System.Windows.Forms.Button();
            this.btnCmpOneStart = new System.Windows.Forms.Button();
            this.btnManualTrg = new System.Windows.Forms.Button();
            this.lblOutState = new System.Windows.Forms.Label();
            this.btnStateToggle = new System.Windows.Forms.Button();
            this.lblOutState_T = new System.Windows.Forms.Label();
            this.t_CmpOne = new System.Windows.Forms.Timer(this.components);
            this.tlpCMP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCMP
            // 
            this.tlpCMP.BackColor = System.Drawing.Color.White;
            this.tlpCMP.ColumnCount = 6;
            this.tlpCMP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpCMP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpCMP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCMP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpCMP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCMP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCMP.Controls.Add(this.cbxAxisList, 1, 0);
            this.tlpCMP.Controls.Add(this.lblAxis, 0, 0);
            this.tlpCMP.Controls.Add(this.lblMethod, 0, 4);
            this.tlpCMP.Controls.Add(this.cbxMethod, 1, 4);
            this.tlpCMP.Controls.Add(this.lblCntrType, 0, 3);
            this.tlpCMP.Controls.Add(this.cbxCntrType, 1, 3);
            this.tlpCMP.Controls.Add(this.rdoOut_OnBoard, 0, 1);
            this.tlpCMP.Controls.Add(this.rdoOut_Global, 0, 2);
            this.tlpCMP.Controls.Add(this.cbxOut_OnBoard, 1, 1);
            this.tlpCMP.Controls.Add(this.cbxOut_Global, 1, 2);
            this.tlpCMP.Controls.Add(this.cbxLogic, 1, 5);
            this.tlpCMP.Controls.Add(this.lblLogic, 0, 5);
            this.tlpCMP.Controls.Add(this.lblDuration, 0, 6);
            this.tlpCMP.Controls.Add(this.tbxDuration, 1, 6);
            this.tlpCMP.Controls.Add(this.lblNotifyType_Title, 0, 7);
            this.tlpCMP.Controls.Add(this.cbxTypeSel, 1, 7);
            this.tlpCMP.Controls.Add(this.lbxPosition, 4, 0);
            this.tlpCMP.Controls.Add(this.lblPosition, 3, 0);
            this.tlpCMP.Controls.Add(this.tbxPosition, 3, 1);
            this.tlpCMP.Controls.Add(this.btnAdd, 3, 2);
            this.tlpCMP.Controls.Add(this.btnRemove, 3, 3);
            this.tlpCMP.Controls.Add(this.btnClear, 3, 4);
            this.tlpCMP.Controls.Add(this.btnAddList, 5, 5);
            this.tlpCMP.Controls.Add(this.btnCmpMove, 5, 7);
            this.tlpCMP.Controls.Add(this.lblMovePosition, 4, 7);
            this.tlpCMP.Controls.Add(this.tbxCmpDist, 4, 8);
            this.tlpCMP.Controls.Add(this.lblOutCount_T, 4, 10);
            this.tlpCMP.Controls.Add(this.lblLastPos_T, 4, 11);
            this.tlpCMP.Controls.Add(this.lblOutCount, 5, 10);
            this.tlpCMP.Controls.Add(this.lblOutPosition, 5, 11);
            this.tlpCMP.Controls.Add(this.btnCmpOneStop, 1, 11);
            this.tlpCMP.Controls.Add(this.btnCmpOneStart, 0, 11);
            this.tlpCMP.Controls.Add(this.btnManualTrg, 0, 9);
            this.tlpCMP.Controls.Add(this.lblOutState, 5, 12);
            this.tlpCMP.Controls.Add(this.btnStateToggle, 1, 9);
            this.tlpCMP.Controls.Add(this.lblOutState_T, 4, 12);
            this.tlpCMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCMP.Location = new System.Drawing.Point(0, 0);
            this.tlpCMP.Name = "tlpCMP";
            this.tlpCMP.RowCount = 14;
            this.tlpCMP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpCMP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpCMP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpCMP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpCMP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpCMP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpCMP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpCMP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpCMP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpCMP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpCMP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpCMP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpCMP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpCMP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCMP.Size = new System.Drawing.Size(643, 415);
            this.tlpCMP.TabIndex = 2;
            // 
            // cbxAxisList
            // 
            this.cbxAxisList.FormattingEnabled = true;
            this.cbxAxisList.Location = new System.Drawing.Point(103, 3);
            this.cbxAxisList.Name = "cbxAxisList";
            this.cbxAxisList.Size = new System.Drawing.Size(94, 20);
            this.cbxAxisList.TabIndex = 5;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblAxis
            // 
            this.lblAxis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAxis.AutoSize = true;
            this.lblAxis.Location = new System.Drawing.Point(3, 0);
            this.lblAxis.Name = "lblAxis";
            this.lblAxis.Size = new System.Drawing.Size(94, 28);
            this.lblAxis.TabIndex = 8;
            this.lblAxis.Text = "Axis";
            this.lblAxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMethod
            // 
            this.lblMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(3, 112);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(94, 28);
            this.lblMethod.TabIndex = 5;
            this.lblMethod.Text = "Method";
            this.lblMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxMethod
            // 
            this.cbxMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMethod.DropDownWidth = 250;
            this.cbxMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMethod.FormattingEnabled = true;
            this.cbxMethod.Items.AddRange(new object[] {
            "0 : Current = Reference (While Counting Down)",
            "1 : Current = Reference (While Counting Up)",
            "2 : Current = Reference",
            "3 : Current < Reference",
            "4 : Current > Reference",
            "5 : Current <= Reference",
            "6 : Current >= Reference"});
            this.cbxMethod.Location = new System.Drawing.Point(103, 115);
            this.cbxMethod.Name = "cbxMethod";
            this.cbxMethod.Size = new System.Drawing.Size(94, 20);
            this.cbxMethod.TabIndex = 3;
            // 
            // lblCntrType
            // 
            this.lblCntrType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCntrType.AutoSize = true;
            this.lblCntrType.Location = new System.Drawing.Point(3, 84);
            this.lblCntrType.Name = "lblCntrType";
            this.lblCntrType.Size = new System.Drawing.Size(94, 28);
            this.lblCntrType.TabIndex = 5;
            this.lblCntrType.Text = "Control Type";
            this.lblCntrType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxCntrType
            // 
            this.cbxCntrType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCntrType.DropDownWidth = 94;
            this.cbxCntrType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCntrType.FormattingEnabled = true;
            this.cbxCntrType.Items.AddRange(new object[] {
            "0 : Command",
            "1 : Feedback"});
            this.cbxCntrType.Location = new System.Drawing.Point(103, 87);
            this.cbxCntrType.Name = "cbxCntrType";
            this.cbxCntrType.Size = new System.Drawing.Size(94, 20);
            this.cbxCntrType.TabIndex = 3;
            // 
            // rdoOut_OnBoard
            // 
            this.rdoOut_OnBoard.AutoSize = true;
            this.rdoOut_OnBoard.Checked = true;
            this.rdoOut_OnBoard.Location = new System.Drawing.Point(3, 31);
            this.rdoOut_OnBoard.Name = "rdoOut_OnBoard";
            this.rdoOut_OnBoard.Size = new System.Drawing.Size(72, 16);
            this.rdoOut_OnBoard.TabIndex = 9;
            this.rdoOut_OnBoard.TabStop = true;
            this.rdoOut_OnBoard.Text = "OnBoard";
            this.rdoOut_OnBoard.UseVisualStyleBackColor = true;
            this.rdoOut_OnBoard.CheckedChanged += new System.EventHandler(this.rdoOut_OnBoard_CheckedChanged);
            // 
            // rdoOut_Global
            // 
            this.rdoOut_Global.AutoSize = true;
            this.rdoOut_Global.Location = new System.Drawing.Point(3, 59);
            this.rdoOut_Global.Name = "rdoOut_Global";
            this.rdoOut_Global.Size = new System.Drawing.Size(80, 16);
            this.rdoOut_Global.TabIndex = 9;
            this.rdoOut_Global.Text = "Global DO";
            this.rdoOut_Global.UseVisualStyleBackColor = true;
            this.rdoOut_Global.CheckedChanged += new System.EventHandler(this.rdoOut_Global_CheckedChanged);
            // 
            // cbxOut_OnBoard
            // 
            this.cbxOut_OnBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOut_OnBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOut_OnBoard.FormattingEnabled = true;
            this.cbxOut_OnBoard.Items.AddRange(new object[] {
            "0 : DO 0",
            "1 : DO 1",
            "2 : DO 2",
            "3 : DO 3"});
            this.cbxOut_OnBoard.Location = new System.Drawing.Point(103, 31);
            this.cbxOut_OnBoard.Name = "cbxOut_OnBoard";
            this.cbxOut_OnBoard.Size = new System.Drawing.Size(94, 20);
            this.cbxOut_OnBoard.TabIndex = 3;
            // 
            // cbxOut_Global
            // 
            this.cbxOut_Global.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOut_Global.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOut_Global.FormattingEnabled = true;
            this.cbxOut_Global.Location = new System.Drawing.Point(103, 59);
            this.cbxOut_Global.Name = "cbxOut_Global";
            this.cbxOut_Global.Size = new System.Drawing.Size(94, 20);
            this.cbxOut_Global.TabIndex = 3;
            // 
            // cbxLogic
            // 
            this.cbxLogic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLogic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxLogic.FormattingEnabled = true;
            this.cbxLogic.Items.AddRange(new object[] {
            "0 : Logic A",
            "1 : Logic B"});
            this.cbxLogic.Location = new System.Drawing.Point(103, 143);
            this.cbxLogic.Name = "cbxLogic";
            this.cbxLogic.Size = new System.Drawing.Size(94, 20);
            this.cbxLogic.TabIndex = 3;
            // 
            // lblLogic
            // 
            this.lblLogic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogic.AutoSize = true;
            this.lblLogic.Location = new System.Drawing.Point(3, 140);
            this.lblLogic.Name = "lblLogic";
            this.lblLogic.Size = new System.Drawing.Size(94, 28);
            this.lblLogic.TabIndex = 5;
            this.lblLogic.Text = "Logic";
            this.lblLogic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(3, 168);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(94, 28);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxDuration
            // 
            this.tbxDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDuration.Location = new System.Drawing.Point(103, 171);
            this.tbxDuration.Name = "tbxDuration";
            this.tbxDuration.Size = new System.Drawing.Size(94, 21);
            this.tbxDuration.TabIndex = 4;
            this.tbxDuration.Text = "10";
            // 
            // lblNotifyType_Title
            // 
            this.lblNotifyType_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotifyType_Title.AutoSize = true;
            this.lblNotifyType_Title.Location = new System.Drawing.Point(3, 196);
            this.lblNotifyType_Title.Name = "lblNotifyType_Title";
            this.lblNotifyType_Title.Size = new System.Drawing.Size(94, 28);
            this.lblNotifyType_Title.TabIndex = 7;
            this.lblNotifyType_Title.Text = "Notify Type";
            this.lblNotifyType_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxTypeSel
            // 
            this.cbxTypeSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTypeSel.FormattingEnabled = true;
            this.cbxTypeSel.Items.AddRange(new object[] {
            "0 : Message",
            "1 : CallBack",
            "2 : Disable"});
            this.cbxTypeSel.Location = new System.Drawing.Point(103, 199);
            this.cbxTypeSel.Name = "cbxTypeSel";
            this.cbxTypeSel.Size = new System.Drawing.Size(94, 20);
            this.cbxTypeSel.TabIndex = 6;
            // 
            // lbxPosition
            // 
            this.tlpCMP.SetColumnSpan(this.lbxPosition, 2);
            this.lbxPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxPosition.FormattingEnabled = true;
            this.lbxPosition.ItemHeight = 12;
            this.lbxPosition.Location = new System.Drawing.Point(343, 3);
            this.lbxPosition.Name = "lbxPosition";
            this.tlpCMP.SetRowSpan(this.lbxPosition, 5);
            this.lbxPosition.Size = new System.Drawing.Size(297, 134);
            this.lbxPosition.TabIndex = 2;
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(243, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(94, 28);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "Position";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPosition
            // 
            this.tbxPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPosition.Location = new System.Drawing.Point(243, 31);
            this.tbxPosition.Name = "tbxPosition";
            this.tbxPosition.Size = new System.Drawing.Size(94, 21);
            this.tbxPosition.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(243, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 22);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRemove.Location = new System.Drawing.Point(243, 87);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 22);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(243, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 22);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddList.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddList.Location = new System.Drawing.Point(494, 143);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(146, 22);
            this.btnAddList.TabIndex = 1;
            this.btnAddList.Text = "TestAddList";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // btnCmpMove
            // 
            this.btnCmpMove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCmpMove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCmpMove.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCmpMove.Location = new System.Drawing.Point(494, 199);
            this.btnCmpMove.Name = "btnCmpMove";
            this.tlpCMP.SetRowSpan(this.btnCmpMove, 2);
            this.btnCmpMove.Size = new System.Drawing.Size(146, 50);
            this.btnCmpMove.TabIndex = 1;
            this.btnCmpMove.Tag = "AlwaysEnable";
            this.btnCmpMove.Text = "Move";
            this.btnCmpMove.UseVisualStyleBackColor = true;
            this.btnCmpMove.Click += new System.EventHandler(this.btnCmpMove_Click);
            // 
            // lblMovePosition
            // 
            this.lblMovePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMovePosition.AutoSize = true;
            this.lblMovePosition.Location = new System.Drawing.Point(343, 196);
            this.lblMovePosition.Name = "lblMovePosition";
            this.lblMovePosition.Size = new System.Drawing.Size(145, 28);
            this.lblMovePosition.TabIndex = 5;
            this.lblMovePosition.Tag = "AlwaysEnable";
            this.lblMovePosition.Text = "Distance";
            this.lblMovePosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxCmpDist
            // 
            this.tbxCmpDist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCmpDist.Location = new System.Drawing.Point(343, 227);
            this.tbxCmpDist.Name = "tbxCmpDist";
            this.tbxCmpDist.Size = new System.Drawing.Size(145, 21);
            this.tbxCmpDist.TabIndex = 4;
            this.tbxCmpDist.Tag = "AlwaysEnable";
            // 
            // lblOutCount_T
            // 
            this.lblOutCount_T.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutCount_T.AutoSize = true;
            this.lblOutCount_T.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOutCount_T.Location = new System.Drawing.Point(343, 280);
            this.lblOutCount_T.Name = "lblOutCount_T";
            this.lblOutCount_T.Size = new System.Drawing.Size(145, 28);
            this.lblOutCount_T.TabIndex = 10;
            this.lblOutCount_T.Text = "Out Count";
            this.lblOutCount_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastPos_T
            // 
            this.lblLastPos_T.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastPos_T.AutoSize = true;
            this.lblLastPos_T.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLastPos_T.Location = new System.Drawing.Point(343, 308);
            this.lblLastPos_T.Name = "lblLastPos_T";
            this.lblLastPos_T.Size = new System.Drawing.Size(145, 28);
            this.lblLastPos_T.TabIndex = 10;
            this.lblLastPos_T.Text = "Last Out Position";
            this.lblLastPos_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutCount
            // 
            this.lblOutCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutCount.AutoSize = true;
            this.lblOutCount.Location = new System.Drawing.Point(494, 280);
            this.lblOutCount.Name = "lblOutCount";
            this.lblOutCount.Size = new System.Drawing.Size(146, 28);
            this.lblOutCount.TabIndex = 10;
            this.lblOutCount.Text = "Out Count";
            this.lblOutCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutPosition
            // 
            this.lblOutPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutPosition.AutoSize = true;
            this.lblOutPosition.Location = new System.Drawing.Point(494, 308);
            this.lblOutPosition.Name = "lblOutPosition";
            this.lblOutPosition.Size = new System.Drawing.Size(146, 28);
            this.lblOutPosition.TabIndex = 10;
            this.lblOutPosition.Text = "Last Out Position";
            this.lblOutPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCmpOneStop
            // 
            this.btnCmpOneStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCmpOneStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCmpOneStop.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCmpOneStop.Location = new System.Drawing.Point(103, 311);
            this.btnCmpOneStop.Name = "btnCmpOneStop";
            this.tlpCMP.SetRowSpan(this.btnCmpOneStop, 2);
            this.btnCmpOneStop.Size = new System.Drawing.Size(94, 50);
            this.btnCmpOneStop.TabIndex = 1;
            this.btnCmpOneStop.Tag = "AlwaysEnable";
            this.btnCmpOneStop.Text = "CMP (One) Stop";
            this.btnCmpOneStop.UseVisualStyleBackColor = true;
            this.btnCmpOneStop.Click += new System.EventHandler(this.btnCmpOneStop_Click);
            // 
            // btnCmpOneStart
            // 
            this.btnCmpOneStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCmpOneStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCmpOneStart.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCmpOneStart.Location = new System.Drawing.Point(3, 311);
            this.btnCmpOneStart.Name = "btnCmpOneStart";
            this.tlpCMP.SetRowSpan(this.btnCmpOneStart, 2);
            this.btnCmpOneStart.Size = new System.Drawing.Size(94, 50);
            this.btnCmpOneStart.TabIndex = 1;
            this.btnCmpOneStart.Text = "CMP (One) Start";
            this.btnCmpOneStart.UseVisualStyleBackColor = true;
            this.btnCmpOneStart.Click += new System.EventHandler(this.btnCmpOneStart_Click);
            // 
            // btnManualTrg
            // 
            this.btnManualTrg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManualTrg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManualTrg.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnManualTrg.Location = new System.Drawing.Point(3, 255);
            this.btnManualTrg.Name = "btnManualTrg";
            this.tlpCMP.SetRowSpan(this.btnManualTrg, 2);
            this.btnManualTrg.Size = new System.Drawing.Size(94, 50);
            this.btnManualTrg.TabIndex = 1;
            this.btnManualTrg.Text = "Manual TriggerOut";
            this.btnManualTrg.UseVisualStyleBackColor = true;
            this.btnManualTrg.Click += new System.EventHandler(this.btnManualTrg_Click);
            // 
            // lblOutState
            // 
            this.lblOutState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutState.AutoSize = true;
            this.lblOutState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOutState.Location = new System.Drawing.Point(494, 339);
            this.lblOutState.Margin = new System.Windows.Forms.Padding(3);
            this.lblOutState.Name = "lblOutState";
            this.lblOutState.Size = new System.Drawing.Size(146, 22);
            this.lblOutState.TabIndex = 10;
            this.lblOutState.Text = "State";
            this.lblOutState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStateToggle
            // 
            this.btnStateToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStateToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStateToggle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStateToggle.Location = new System.Drawing.Point(103, 255);
            this.btnStateToggle.Name = "btnStateToggle";
            this.tlpCMP.SetRowSpan(this.btnStateToggle, 2);
            this.btnStateToggle.Size = new System.Drawing.Size(94, 50);
            this.btnStateToggle.TabIndex = 11;
            this.btnStateToggle.Text = "State Toggle";
            this.btnStateToggle.UseVisualStyleBackColor = true;
            this.btnStateToggle.Click += new System.EventHandler(this.btnStateToggle_Click);
            // 
            // lblOutState_T
            // 
            this.lblOutState_T.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutState_T.AutoSize = true;
            this.lblOutState_T.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOutState_T.Location = new System.Drawing.Point(343, 336);
            this.lblOutState_T.Name = "lblOutState_T";
            this.lblOutState_T.Size = new System.Drawing.Size(145, 28);
            this.lblOutState_T.TabIndex = 10;
            this.lblOutState_T.Text = "Out State";
            this.lblOutState_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_CmpOne
            // 
            this.t_CmpOne.Enabled = true;
            this.t_CmpOne.Tick += new System.EventHandler(this.t_CmpOne_Tick);
            // 
            // formCmpOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 415);
            this.Controls.Add(this.tlpCMP);
            this.Name = "formCmpOne";
            this.Text = "Cmp_One";
            this.tlpCMP.ResumeLayout(false);
            this.tlpCMP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCMP;
        private System.Windows.Forms.Label lblCntrType;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblLogic;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.ComboBox cbxCntrType;
        private System.Windows.Forms.ComboBox cbxMethod;
        private System.Windows.Forms.ComboBox cbxOut_OnBoard;
        private System.Windows.Forms.ComboBox cbxLogic;
        private System.Windows.Forms.TextBox tbxDuration;
        private System.Windows.Forms.ListBox lbxPosition;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cbxTypeSel;
        private System.Windows.Forms.Label lblNotifyType_Title;
        private System.Windows.Forms.Button btnCmpMove;
        private System.Windows.Forms.TextBox tbxCmpDist;
        private System.Windows.Forms.Label lblMovePosition;
        private System.Windows.Forms.Button btnCmpOneStart;
        private System.Windows.Forms.Button btnCmpOneStop;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.RadioButton rdoOut_OnBoard;
        private System.Windows.Forms.RadioButton rdoOut_Global;
        private System.Windows.Forms.ComboBox cbxOut_Global;
        private System.Windows.Forms.Timer t_CmpOne;
        private System.Windows.Forms.Button btnManualTrg;
        private System.Windows.Forms.Label lblOutCount_T;
        private System.Windows.Forms.Label lblLastPos_T;
        private System.Windows.Forms.Label lblOutCount;
        private System.Windows.Forms.Label lblOutPosition;
        private System.Windows.Forms.Label lblOutState;
        private System.Windows.Forms.Button btnStateToggle;
        private System.Windows.Forms.Label lblOutState_T;
    }
}