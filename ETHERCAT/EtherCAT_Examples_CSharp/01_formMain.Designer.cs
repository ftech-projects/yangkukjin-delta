namespace EtherCAT_Examples_CSharp
{
    partial class formMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnCfg = new System.Windows.Forms.Button();
            this.btnSxMot = new System.Windows.Forms.Button();
            this.btnPosCorr_2D = new System.Windows.Forms.Button();
            this.btnPosCorr = new System.Windows.Forms.Button();
            this.btnSxSt = new System.Windows.Forms.Button();
            this.btnSxMot_aSync = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnMultiTorque = new System.Windows.Forms.Button();
            this.lblMultiTorque = new System.Windows.Forms.Label();
            this.lblAutoTorque = new System.Windows.Forms.Label();
            this.btnmAutoTorque = new System.Windows.Forms.Button();
            this.btnTorque = new System.Windows.Forms.Button();
            this.btnSD = new System.Windows.Forms.Button();
            this.lblSD = new System.Windows.Forms.Label();
            this.lblExtStop = new System.Windows.Forms.Label();
            this.btnExtStop = new System.Windows.Forms.Button();
            this.btnSyncAxis = new System.Windows.Forms.Button();
            this.btnRingCounter = new System.Windows.Forms.Button();
            this.btnRingCounter_Abs = new System.Windows.Forms.Button();
            this.btnCmpCont = new System.Windows.Forms.Button();
            this.btnOverride = new System.Windows.Forms.Button();
            this.btnTouchProbe = new System.Windows.Forms.Button();
            this.btnSetSpeedAdv = new System.Windows.Forms.Button();
            this.btnPMonitor = new System.Windows.Forms.Button();
            this.btnSlaveIF = new System.Windows.Forms.Button();
            this.btnDio = new System.Windows.Forms.Button();
            this.btnDiLatch = new System.Windows.Forms.Button();
            this.btnAio = new System.Windows.Forms.Button();
            this.btnPdoToStruct = new System.Windows.Forms.Button();
            this.btnCmpOne = new System.Windows.Forms.Button();
            this.btnZVIS = new System.Windows.Forms.Button();
            this.btnCollisionAvoidance = new System.Windows.Forms.Button();
            this.btnHardEmg = new System.Windows.Forms.Button();
            this.btnSoftEmg = new System.Windows.Forms.Button();
            this.btnPtMotion = new System.Windows.Forms.Button();
            this.btnListMotion = new System.Windows.Forms.Button();
            this.btnMasterSlave = new System.Windows.Forms.Button();
            this.btnHoming = new System.Windows.Forms.Button();
            this.btnIxVia = new System.Windows.Forms.Button();
            this.btnMpr2xLin = new System.Windows.Forms.Button();
            this.btnIxSpline = new System.Windows.Forms.Button();
            this.btnIxArc = new System.Windows.Forms.Button();
            this.btnIxLine = new System.Windows.Forms.Button();
            this.btnMxMot = new System.Windows.Forms.Button();
            this.lblCmpContinuous = new System.Windows.Forms.Label();
            this.lblCmpOne = new System.Windows.Forms.Label();
            this.lblZVIS = new System.Windows.Forms.Label();
            this.lblHEmg = new System.Windows.Forms.Label();
            this.lblSEmg = new System.Windows.Forms.Label();
            this.btnMC02P = new System.Windows.Forms.Button();
            this.btnGCode = new System.Windows.Forms.Button();
            this.lblPdoToStruct = new System.Windows.Forms.Label();
            this.btnCookBook10 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 7;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.Controls.Add(this.btnInit, 1, 0);
            this.tlpMain.Controls.Add(this.btnCfg, 1, 1);
            this.tlpMain.Controls.Add(this.btnSxMot, 1, 2);
            this.tlpMain.Controls.Add(this.btnPosCorr_2D, 1, 6);
            this.tlpMain.Controls.Add(this.btnPosCorr, 1, 5);
            this.tlpMain.Controls.Add(this.btnSxSt, 1, 4);
            this.tlpMain.Controls.Add(this.btnSxMot_aSync, 1, 3);
            this.tlpMain.Controls.Add(this.label1, 0, 0);
            this.tlpMain.Controls.Add(this.label2, 0, 1);
            this.tlpMain.Controls.Add(this.label3, 0, 2);
            this.tlpMain.Controls.Add(this.label4, 0, 3);
            this.tlpMain.Controls.Add(this.label5, 0, 4);
            this.tlpMain.Controls.Add(this.label6, 0, 5);
            this.tlpMain.Controls.Add(this.label7, 0, 6);
            this.tlpMain.Controls.Add(this.label8, 0, 7);
            this.tlpMain.Controls.Add(this.label9, 0, 8);
            this.tlpMain.Controls.Add(this.label10, 0, 9);
            this.tlpMain.Controls.Add(this.label11, 0, 10);
            this.tlpMain.Controls.Add(this.label12, 0, 11);
            this.tlpMain.Controls.Add(this.label13, 0, 12);
            this.tlpMain.Controls.Add(this.label14, 0, 13);
            this.tlpMain.Controls.Add(this.label15, 0, 14);
            this.tlpMain.Controls.Add(this.btnMultiTorque, 1, 14);
            this.tlpMain.Controls.Add(this.lblMultiTorque, 2, 14);
            this.tlpMain.Controls.Add(this.lblAutoTorque, 2, 13);
            this.tlpMain.Controls.Add(this.btnmAutoTorque, 1, 13);
            this.tlpMain.Controls.Add(this.btnTorque, 1, 12);
            this.tlpMain.Controls.Add(this.btnSD, 1, 11);
            this.tlpMain.Controls.Add(this.lblSD, 2, 11);
            this.tlpMain.Controls.Add(this.lblExtStop, 2, 10);
            this.tlpMain.Controls.Add(this.btnExtStop, 1, 10);
            this.tlpMain.Controls.Add(this.btnSyncAxis, 1, 9);
            this.tlpMain.Controls.Add(this.btnRingCounter, 1, 7);
            this.tlpMain.Controls.Add(this.btnRingCounter_Abs, 1, 8);
            this.tlpMain.Controls.Add(this.btnCmpCont, 5, 0);
            this.tlpMain.Controls.Add(this.btnOverride, 5, 1);
            this.tlpMain.Controls.Add(this.btnTouchProbe, 5, 2);
            this.tlpMain.Controls.Add(this.btnSetSpeedAdv, 5, 3);
            this.tlpMain.Controls.Add(this.btnPMonitor, 5, 4);
            this.tlpMain.Controls.Add(this.btnSlaveIF, 5, 5);
            this.tlpMain.Controls.Add(this.btnDio, 5, 6);
            this.tlpMain.Controls.Add(this.btnDiLatch, 5, 7);
            this.tlpMain.Controls.Add(this.btnAio, 5, 8);
            this.tlpMain.Controls.Add(this.btnPdoToStruct, 5, 9);
            this.tlpMain.Controls.Add(this.btnCmpOne, 3, 14);
            this.tlpMain.Controls.Add(this.btnZVIS, 3, 13);
            this.tlpMain.Controls.Add(this.btnCollisionAvoidance, 3, 12);
            this.tlpMain.Controls.Add(this.btnHardEmg, 3, 11);
            this.tlpMain.Controls.Add(this.btnSoftEmg, 3, 10);
            this.tlpMain.Controls.Add(this.btnPtMotion, 3, 9);
            this.tlpMain.Controls.Add(this.btnListMotion, 3, 8);
            this.tlpMain.Controls.Add(this.btnMasterSlave, 3, 7);
            this.tlpMain.Controls.Add(this.btnHoming, 3, 6);
            this.tlpMain.Controls.Add(this.btnIxVia, 3, 5);
            this.tlpMain.Controls.Add(this.btnMpr2xLin, 3, 4);
            this.tlpMain.Controls.Add(this.btnIxSpline, 3, 3);
            this.tlpMain.Controls.Add(this.btnIxArc, 3, 2);
            this.tlpMain.Controls.Add(this.btnIxLine, 3, 1);
            this.tlpMain.Controls.Add(this.btnMxMot, 3, 0);
            this.tlpMain.Controls.Add(this.lblCmpContinuous, 6, 0);
            this.tlpMain.Controls.Add(this.lblCmpOne, 4, 14);
            this.tlpMain.Controls.Add(this.lblZVIS, 4, 13);
            this.tlpMain.Controls.Add(this.lblHEmg, 4, 11);
            this.tlpMain.Controls.Add(this.lblSEmg, 4, 10);
            this.tlpMain.Controls.Add(this.btnMC02P, 5, 12);
            this.tlpMain.Controls.Add(this.btnGCode, 5, 14);
            this.tlpMain.Controls.Add(this.lblPdoToStruct, 6, 9);
            this.tlpMain.Controls.Add(this.btnCookBook10, 1, 15);
            this.tlpMain.Controls.Add(this.label16, 2, 15);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 16;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1192, 753);
            this.tlpMain.TabIndex = 0;
            // 
            // btnInit
            // 
            this.btnInit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInit.Location = new System.Drawing.Point(33, 3);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(114, 34);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "초기화";
            this.btnInit.UseVisualStyleBackColor = false;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnCfg
            // 
            this.btnCfg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCfg.Location = new System.Drawing.Point(33, 43);
            this.btnCfg.Name = "btnCfg";
            this.btnCfg.Size = new System.Drawing.Size(114, 34);
            this.btnCfg.TabIndex = 0;
            this.btnCfg.Text = "환경 설정";
            this.btnCfg.UseVisualStyleBackColor = true;
            // 
            // btnSxMot
            // 
            this.btnSxMot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSxMot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSxMot.Location = new System.Drawing.Point(33, 83);
            this.btnSxMot.Name = "btnSxMot";
            this.btnSxMot.Size = new System.Drawing.Size(114, 34);
            this.btnSxMot.TabIndex = 0;
            this.btnSxMot.Text = "단축 이송";
            this.btnSxMot.UseVisualStyleBackColor = false;
            this.btnSxMot.Click += new System.EventHandler(this.btnSxMot_Click);
            // 
            // btnPosCorr_2D
            // 
            this.btnPosCorr_2D.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPosCorr_2D.Location = new System.Drawing.Point(33, 243);
            this.btnPosCorr_2D.Name = "btnPosCorr_2D";
            this.btnPosCorr_2D.Size = new System.Drawing.Size(114, 34);
            this.btnPosCorr_2D.TabIndex = 0;
            this.btnPosCorr_2D.Text = "2차원 위치 보정";
            this.btnPosCorr_2D.UseVisualStyleBackColor = true;
            // 
            // btnPosCorr
            // 
            this.btnPosCorr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPosCorr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPosCorr.Location = new System.Drawing.Point(33, 203);
            this.btnPosCorr.Name = "btnPosCorr";
            this.btnPosCorr.Size = new System.Drawing.Size(114, 34);
            this.btnPosCorr.TabIndex = 0;
            this.btnPosCorr.Text = "1차원 위치 보정";
            this.btnPosCorr.UseVisualStyleBackColor = false;
            this.btnPosCorr.Click += new System.EventHandler(this.btnPosCorr_Click);
            // 
            // btnSxSt
            // 
            this.btnSxSt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSxSt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSxSt.Location = new System.Drawing.Point(33, 163);
            this.btnSxSt.Name = "btnSxSt";
            this.btnSxSt.Size = new System.Drawing.Size(114, 34);
            this.btnSxSt.TabIndex = 0;
            this.btnSxSt.Text = "모션 상태 감시";
            this.btnSxSt.UseVisualStyleBackColor = false;
            this.btnSxSt.Click += new System.EventHandler(this.btnSxSt_Click);
            // 
            // btnSxMot_aSync
            // 
            this.btnSxMot_aSync.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSxMot_aSync.Location = new System.Drawing.Point(33, 123);
            this.btnSxMot_aSync.Name = "btnSxMot_aSync";
            this.btnSxMot_aSync.Size = new System.Drawing.Size(114, 34);
            this.btnSxMot_aSync.TabIndex = 0;
            this.btnSxMot_aSync.Text = "단축 이송 2";
            this.btnSxMot_aSync.UseVisualStyleBackColor = true;
            this.btnSxMot_aSync.Click += new System.EventHandler(this.btnSxMot_RPM_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 40);
            this.label4.TabIndex = 1;
            this.label4.Text = "4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 40);
            this.label5.TabIndex = 1;
            this.label5.Text = "5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 40);
            this.label6.TabIndex = 1;
            this.label6.Text = "6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 40);
            this.label7.TabIndex = 1;
            this.label7.Text = "7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 40);
            this.label8.TabIndex = 1;
            this.label8.Text = "8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 40);
            this.label9.TabIndex = 1;
            this.label9.Text = "9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 40);
            this.label10.TabIndex = 1;
            this.label10.Text = "10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 40);
            this.label11.TabIndex = 1;
            this.label11.Text = "11";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 40);
            this.label12.TabIndex = 1;
            this.label12.Text = "12";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 480);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 40);
            this.label13.TabIndex = 1;
            this.label13.Text = "13";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 520);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 40);
            this.label14.TabIndex = 1;
            this.label14.Text = "14";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 560);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 40);
            this.label15.TabIndex = 1;
            this.label15.Text = "15";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMultiTorque
            // 
            this.btnMultiTorque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMultiTorque.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMultiTorque.Location = new System.Drawing.Point(33, 563);
            this.btnMultiTorque.Name = "btnMultiTorque";
            this.btnMultiTorque.Size = new System.Drawing.Size(114, 34);
            this.btnMultiTorque.TabIndex = 0;
            this.btnMultiTorque.Text = "Multi Torque";
            this.btnMultiTorque.UseVisualStyleBackColor = false;
            this.btnMultiTorque.Click += new System.EventHandler(this.btnMultiTorque_Click);
            // 
            // lblMultiTorque
            // 
            this.lblMultiTorque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMultiTorque.AutoSize = true;
            this.lblMultiTorque.Location = new System.Drawing.Point(153, 560);
            this.lblMultiTorque.Name = "lblMultiTorque";
            this.lblMultiTorque.Size = new System.Drawing.Size(260, 40);
            this.lblMultiTorque.TabIndex = 1;
            this.lblMultiTorque.Text = "기준 축(Target Axis) 이송 시 기준축의 위치에 따라 제어축의 토크를 정해진 리스트에 따라 자동으로 제어";
            this.lblMultiTorque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAutoTorque
            // 
            this.lblAutoTorque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAutoTorque.AutoSize = true;
            this.lblAutoTorque.Location = new System.Drawing.Point(153, 520);
            this.lblAutoTorque.Name = "lblAutoTorque";
            this.lblAutoTorque.Size = new System.Drawing.Size(221, 40);
            this.lblAutoTorque.TabIndex = 1;
            this.lblAutoTorque.Text = "위치 제어 후 자동으로 토크 제어로 변환";
            this.lblAutoTorque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnmAutoTorque
            // 
            this.btnmAutoTorque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmAutoTorque.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnmAutoTorque.Location = new System.Drawing.Point(33, 523);
            this.btnmAutoTorque.Name = "btnmAutoTorque";
            this.btnmAutoTorque.Size = new System.Drawing.Size(114, 34);
            this.btnmAutoTorque.TabIndex = 0;
            this.btnmAutoTorque.Text = "Auto Torque";
            this.btnmAutoTorque.UseVisualStyleBackColor = false;
            this.btnmAutoTorque.Click += new System.EventHandler(this.btnmAutoTorque_Click);
            // 
            // btnTorque
            // 
            this.btnTorque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTorque.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTorque.Location = new System.Drawing.Point(33, 483);
            this.btnTorque.Name = "btnTorque";
            this.btnTorque.Size = new System.Drawing.Size(114, 34);
            this.btnTorque.TabIndex = 0;
            this.btnTorque.Text = "속도 / 토크 제어";
            this.btnTorque.UseVisualStyleBackColor = false;
            this.btnTorque.Click += new System.EventHandler(this.btnTorque_Click);
            // 
            // btnSD
            // 
            this.btnSD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSD.Location = new System.Drawing.Point(33, 443);
            this.btnSD.Name = "btnSD";
            this.btnSD.Size = new System.Drawing.Size(114, 34);
            this.btnSD.TabIndex = 0;
            this.btnSD.Text = "SD";
            this.btnSD.UseVisualStyleBackColor = false;
            this.btnSD.Click += new System.EventHandler(this.btnSD_Click);
            // 
            // lblSD
            // 
            this.lblSD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSD.AutoSize = true;
            this.lblSD.Location = new System.Drawing.Point(153, 440);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(181, 40);
            this.lblSD.TabIndex = 1;
            this.lblSD.Text = "외부 신호 입력에 의한 속도 변경";
            this.lblSD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExtStop
            // 
            this.lblExtStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExtStop.AutoSize = true;
            this.lblExtStop.Location = new System.Drawing.Point(153, 400);
            this.lblExtStop.Name = "lblExtStop";
            this.lblExtStop.Size = new System.Drawing.Size(153, 40);
            this.lblExtStop.TabIndex = 1;
            this.lblExtStop.Text = "외부 신호 입력에 의한 정지";
            this.lblExtStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExtStop
            // 
            this.btnExtStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtStop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExtStop.Location = new System.Drawing.Point(33, 403);
            this.btnExtStop.Name = "btnExtStop";
            this.btnExtStop.Size = new System.Drawing.Size(114, 34);
            this.btnExtStop.TabIndex = 0;
            this.btnExtStop.Text = "Ext Stop";
            this.btnExtStop.UseVisualStyleBackColor = false;
            this.btnExtStop.Click += new System.EventHandler(this.btnExtStop_Click);
            // 
            // btnSyncAxis
            // 
            this.btnSyncAxis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSyncAxis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSyncAxis.Location = new System.Drawing.Point(33, 363);
            this.btnSyncAxis.Name = "btnSyncAxis";
            this.btnSyncAxis.Size = new System.Drawing.Size(114, 34);
            this.btnSyncAxis.TabIndex = 0;
            this.btnSyncAxis.Text = "SyncAxis";
            this.btnSyncAxis.UseVisualStyleBackColor = false;
            this.btnSyncAxis.Click += new System.EventHandler(this.btnSyncAxis_Click);
            // 
            // btnRingCounter
            // 
            this.btnRingCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRingCounter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRingCounter.Location = new System.Drawing.Point(33, 283);
            this.btnRingCounter.Name = "btnRingCounter";
            this.btnRingCounter.Size = new System.Drawing.Size(114, 34);
            this.btnRingCounter.TabIndex = 0;
            this.btnRingCounter.Text = "링카운터";
            this.btnRingCounter.UseVisualStyleBackColor = false;
            this.btnRingCounter.Click += new System.EventHandler(this.btnRingCounter_Click);
            // 
            // btnRingCounter_Abs
            // 
            this.btnRingCounter_Abs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRingCounter_Abs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRingCounter_Abs.Location = new System.Drawing.Point(33, 323);
            this.btnRingCounter_Abs.Name = "btnRingCounter_Abs";
            this.btnRingCounter_Abs.Size = new System.Drawing.Size(114, 34);
            this.btnRingCounter_Abs.TabIndex = 0;
            this.btnRingCounter_Abs.Text = "링카운터 - 절대치\r\n";
            this.btnRingCounter_Abs.UseVisualStyleBackColor = false;
            this.btnRingCounter_Abs.Click += new System.EventHandler(this.btnRingCounter_Abs_Click);
            // 
            // btnCmpCont
            // 
            this.btnCmpCont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCmpCont.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCmpCont.Location = new System.Drawing.Point(807, 3);
            this.btnCmpCont.Name = "btnCmpCont";
            this.btnCmpCont.Size = new System.Drawing.Size(114, 34);
            this.btnCmpCont.TabIndex = 0;
            this.btnCmpCont.Text = "CMP Continuous";
            this.btnCmpCont.UseVisualStyleBackColor = false;
            this.btnCmpCont.Click += new System.EventHandler(this.btnCmpCont_Click);
            // 
            // btnOverride
            // 
            this.btnOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOverride.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOverride.Location = new System.Drawing.Point(807, 43);
            this.btnOverride.Name = "btnOverride";
            this.btnOverride.Size = new System.Drawing.Size(114, 34);
            this.btnOverride.TabIndex = 0;
            this.btnOverride.Text = "Override";
            this.btnOverride.UseVisualStyleBackColor = false;
            this.btnOverride.Click += new System.EventHandler(this.btnOverride_Click);
            // 
            // btnTouchProbe
            // 
            this.btnTouchProbe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTouchProbe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTouchProbe.Location = new System.Drawing.Point(807, 83);
            this.btnTouchProbe.Name = "btnTouchProbe";
            this.btnTouchProbe.Size = new System.Drawing.Size(114, 34);
            this.btnTouchProbe.TabIndex = 0;
            this.btnTouchProbe.Text = "터치 프로브";
            this.btnTouchProbe.UseVisualStyleBackColor = false;
            this.btnTouchProbe.Click += new System.EventHandler(this.btnTouchProbe_Click);
            // 
            // btnSetSpeedAdv
            // 
            this.btnSetSpeedAdv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetSpeedAdv.Location = new System.Drawing.Point(807, 123);
            this.btnSetSpeedAdv.Name = "btnSetSpeedAdv";
            this.btnSetSpeedAdv.Size = new System.Drawing.Size(114, 34);
            this.btnSetSpeedAdv.TabIndex = 0;
            this.btnSetSpeedAdv.Text = "고급 속도 설정";
            this.btnSetSpeedAdv.UseVisualStyleBackColor = true;
            this.btnSetSpeedAdv.Click += new System.EventHandler(this.btnSetSpeedAdv_Click);
            // 
            // btnPMonitor
            // 
            this.btnPMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPMonitor.Location = new System.Drawing.Point(807, 163);
            this.btnPMonitor.Name = "btnPMonitor";
            this.btnPMonitor.Size = new System.Drawing.Size(114, 34);
            this.btnPMonitor.TabIndex = 0;
            this.btnPMonitor.Text = "Performance Monitor";
            this.btnPMonitor.UseVisualStyleBackColor = true;
            this.btnPMonitor.Click += new System.EventHandler(this.btnPMonitor_Click);
            // 
            // btnSlaveIF
            // 
            this.btnSlaveIF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSlaveIF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSlaveIF.Location = new System.Drawing.Point(807, 203);
            this.btnSlaveIF.Name = "btnSlaveIF";
            this.btnSlaveIF.Size = new System.Drawing.Size(114, 34);
            this.btnSlaveIF.TabIndex = 0;
            this.btnSlaveIF.Text = "Slave Interfacce (CoeSDO)";
            this.btnSlaveIF.UseVisualStyleBackColor = false;
            this.btnSlaveIF.Click += new System.EventHandler(this.btnSlaveIF_Click);
            // 
            // btnDio
            // 
            this.btnDio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDio.Location = new System.Drawing.Point(807, 243);
            this.btnDio.Name = "btnDio";
            this.btnDio.Size = new System.Drawing.Size(114, 34);
            this.btnDio.TabIndex = 0;
            this.btnDio.Text = "DI/DO";
            this.btnDio.UseVisualStyleBackColor = false;
            this.btnDio.Click += new System.EventHandler(this.btnDio_Click);
            // 
            // btnDiLatch
            // 
            this.btnDiLatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiLatch.Location = new System.Drawing.Point(807, 283);
            this.btnDiLatch.Name = "btnDiLatch";
            this.btnDiLatch.Size = new System.Drawing.Size(114, 34);
            this.btnDiLatch.TabIndex = 0;
            this.btnDiLatch.Text = "DI Latch";
            this.btnDiLatch.UseVisualStyleBackColor = true;
            // 
            // btnAio
            // 
            this.btnAio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAio.Location = new System.Drawing.Point(807, 323);
            this.btnAio.Name = "btnAio";
            this.btnAio.Size = new System.Drawing.Size(114, 34);
            this.btnAio.TabIndex = 0;
            this.btnAio.Text = "AI/AO";
            this.btnAio.UseVisualStyleBackColor = false;
            this.btnAio.Click += new System.EventHandler(this.btnAio_Click);
            // 
            // btnPdoToStruct
            // 
            this.btnPdoToStruct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPdoToStruct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPdoToStruct.Location = new System.Drawing.Point(807, 363);
            this.btnPdoToStruct.Name = "btnPdoToStruct";
            this.btnPdoToStruct.Size = new System.Drawing.Size(114, 34);
            this.btnPdoToStruct.TabIndex = 0;
            this.btnPdoToStruct.Text = "PDO to Struct";
            this.btnPdoToStruct.UseVisualStyleBackColor = false;
            this.btnPdoToStruct.Click += new System.EventHandler(this.btnPdoToStruct_Click);
            // 
            // btnCmpOne
            // 
            this.btnCmpOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCmpOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCmpOne.Location = new System.Drawing.Point(420, 563);
            this.btnCmpOne.Name = "btnCmpOne";
            this.btnCmpOne.Size = new System.Drawing.Size(114, 34);
            this.btnCmpOne.TabIndex = 0;
            this.btnCmpOne.Text = "CMP One";
            this.btnCmpOne.UseVisualStyleBackColor = false;
            this.btnCmpOne.Click += new System.EventHandler(this.btnCmpOne_Click);
            // 
            // btnZVIS
            // 
            this.btnZVIS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZVIS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnZVIS.Location = new System.Drawing.Point(420, 523);
            this.btnZVIS.Name = "btnZVIS";
            this.btnZVIS.Size = new System.Drawing.Size(114, 34);
            this.btnZVIS.TabIndex = 0;
            this.btnZVIS.Text = "진동억제";
            this.btnZVIS.UseVisualStyleBackColor = false;
            this.btnZVIS.Click += new System.EventHandler(this.btnZVIS_Click);
            // 
            // btnCollisionAvoidance
            // 
            this.btnCollisionAvoidance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollisionAvoidance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCollisionAvoidance.Location = new System.Drawing.Point(420, 483);
            this.btnCollisionAvoidance.Name = "btnCollisionAvoidance";
            this.btnCollisionAvoidance.Size = new System.Drawing.Size(114, 34);
            this.btnCollisionAvoidance.TabIndex = 0;
            this.btnCollisionAvoidance.Text = "충돌방지";
            this.btnCollisionAvoidance.UseVisualStyleBackColor = false;
            this.btnCollisionAvoidance.Click += new System.EventHandler(this.btnCollisionAvoidance_Click);
            // 
            // btnHardEmg
            // 
            this.btnHardEmg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHardEmg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHardEmg.Location = new System.Drawing.Point(420, 443);
            this.btnHardEmg.Name = "btnHardEmg";
            this.btnHardEmg.Size = new System.Drawing.Size(114, 34);
            this.btnHardEmg.TabIndex = 0;
            this.btnHardEmg.Text = "Hardware Emergency";
            this.btnHardEmg.UseVisualStyleBackColor = false;
            this.btnHardEmg.Click += new System.EventHandler(this.btnHardEmg_Click);
            // 
            // btnSoftEmg
            // 
            this.btnSoftEmg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoftEmg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSoftEmg.Location = new System.Drawing.Point(420, 403);
            this.btnSoftEmg.Name = "btnSoftEmg";
            this.btnSoftEmg.Size = new System.Drawing.Size(114, 34);
            this.btnSoftEmg.TabIndex = 0;
            this.btnSoftEmg.Text = "Software Emergency";
            this.btnSoftEmg.UseVisualStyleBackColor = false;
            this.btnSoftEmg.Click += new System.EventHandler(this.btnSoftEmg_Click);
            // 
            // btnPtMotion
            // 
            this.btnPtMotion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPtMotion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPtMotion.Location = new System.Drawing.Point(420, 363);
            this.btnPtMotion.Name = "btnPtMotion";
            this.btnPtMotion.Size = new System.Drawing.Size(114, 34);
            this.btnPtMotion.TabIndex = 0;
            this.btnPtMotion.Text = "PT 모션";
            this.btnPtMotion.UseVisualStyleBackColor = false;
            this.btnPtMotion.Click += new System.EventHandler(this.btnPtMotion_Click);
            // 
            // btnListMotion
            // 
            this.btnListMotion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListMotion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListMotion.Location = new System.Drawing.Point(420, 323);
            this.btnListMotion.Name = "btnListMotion";
            this.btnListMotion.Size = new System.Drawing.Size(114, 34);
            this.btnListMotion.TabIndex = 0;
            this.btnListMotion.Text = "리스트 모션";
            this.btnListMotion.UseVisualStyleBackColor = false;
            this.btnListMotion.Click += new System.EventHandler(this.btnListMotion_Click);
            // 
            // btnMasterSlave
            // 
            this.btnMasterSlave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasterSlave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMasterSlave.Location = new System.Drawing.Point(420, 283);
            this.btnMasterSlave.Name = "btnMasterSlave";
            this.btnMasterSlave.Size = new System.Drawing.Size(114, 34);
            this.btnMasterSlave.TabIndex = 0;
            this.btnMasterSlave.Text = "마스터 / 슬레이브";
            this.btnMasterSlave.UseVisualStyleBackColor = false;
            this.btnMasterSlave.Click += new System.EventHandler(this.btnMasterSlave_Click);
            // 
            // btnHoming
            // 
            this.btnHoming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHoming.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHoming.Location = new System.Drawing.Point(420, 243);
            this.btnHoming.Name = "btnHoming";
            this.btnHoming.Size = new System.Drawing.Size(114, 34);
            this.btnHoming.TabIndex = 0;
            this.btnHoming.Text = "홈복귀";
            this.btnHoming.UseVisualStyleBackColor = false;
            this.btnHoming.Click += new System.EventHandler(this.btnHoming_Click);
            // 
            // btnIxVia
            // 
            this.btnIxVia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIxVia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIxVia.Location = new System.Drawing.Point(420, 203);
            this.btnIxVia.Name = "btnIxVia";
            this.btnIxVia.Size = new System.Drawing.Size(114, 34);
            this.btnIxVia.TabIndex = 0;
            this.btnIxVia.Text = "경유 이송";
            this.btnIxVia.UseVisualStyleBackColor = false;
            this.btnIxVia.Click += new System.EventHandler(this.btnIxVia_Click);
            // 
            // btnMpr2xLin
            // 
            this.btnMpr2xLin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMpr2xLin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMpr2xLin.Location = new System.Drawing.Point(420, 163);
            this.btnMpr2xLin.Name = "btnMpr2xLin";
            this.btnMpr2xLin.Size = new System.Drawing.Size(114, 34);
            this.btnMpr2xLin.TabIndex = 0;
            this.btnMpr2xLin.Text = "자동 원호 삽입";
            this.btnMpr2xLin.UseVisualStyleBackColor = false;
            this.btnMpr2xLin.Click += new System.EventHandler(this.btnMpr2xLin_Click);
            // 
            // btnIxSpline
            // 
            this.btnIxSpline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIxSpline.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIxSpline.Location = new System.Drawing.Point(420, 123);
            this.btnIxSpline.Name = "btnIxSpline";
            this.btnIxSpline.Size = new System.Drawing.Size(114, 34);
            this.btnIxSpline.TabIndex = 0;
            this.btnIxSpline.Text = "스플라인 보간";
            this.btnIxSpline.UseVisualStyleBackColor = false;
            this.btnIxSpline.Click += new System.EventHandler(this.btnIxSpline_Click);
            // 
            // btnIxArc
            // 
            this.btnIxArc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIxArc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIxArc.Location = new System.Drawing.Point(420, 83);
            this.btnIxArc.Name = "btnIxArc";
            this.btnIxArc.Size = new System.Drawing.Size(114, 34);
            this.btnIxArc.TabIndex = 0;
            this.btnIxArc.Text = "원호 보간";
            this.btnIxArc.UseVisualStyleBackColor = false;
            this.btnIxArc.Click += new System.EventHandler(this.btnIxArc_Click);
            // 
            // btnIxLine
            // 
            this.btnIxLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIxLine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIxLine.Location = new System.Drawing.Point(420, 43);
            this.btnIxLine.Name = "btnIxLine";
            this.btnIxLine.Size = new System.Drawing.Size(114, 34);
            this.btnIxLine.TabIndex = 0;
            this.btnIxLine.Text = "직선 보간";
            this.btnIxLine.UseVisualStyleBackColor = false;
            this.btnIxLine.Click += new System.EventHandler(this.btnIxLine_Click);
            // 
            // btnMxMot
            // 
            this.btnMxMot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMxMot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMxMot.Location = new System.Drawing.Point(420, 3);
            this.btnMxMot.Name = "btnMxMot";
            this.btnMxMot.Size = new System.Drawing.Size(114, 34);
            this.btnMxMot.TabIndex = 0;
            this.btnMxMot.Text = "다축이송";
            this.btnMxMot.UseVisualStyleBackColor = false;
            this.btnMxMot.Click += new System.EventHandler(this.btnMxMot_Click);
            // 
            // lblCmpContinuous
            // 
            this.lblCmpContinuous.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCmpContinuous.AutoSize = true;
            this.lblCmpContinuous.Location = new System.Drawing.Point(927, 0);
            this.lblCmpContinuous.Name = "lblCmpContinuous";
            this.lblCmpContinuous.Size = new System.Drawing.Size(254, 40);
            this.lblCmpContinuous.TabIndex = 1;
            this.lblCmpContinuous.Text = " 마스터보드에서 지원하는 CMP (위치 비교 트리거 출력) 중 연속 출력에 대한 기능";
            this.lblCmpContinuous.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCmpOne
            // 
            this.lblCmpOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCmpOne.AutoSize = true;
            this.lblCmpOne.Location = new System.Drawing.Point(540, 560);
            this.lblCmpOne.Name = "lblCmpOne";
            this.lblCmpOne.Size = new System.Drawing.Size(230, 40);
            this.lblCmpOne.TabIndex = 1;
            this.lblCmpOne.Text = "정해진 위치에서 트리거 출력 및 Callback";
            this.lblCmpOne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblZVIS
            // 
            this.lblZVIS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblZVIS.AutoSize = true;
            this.lblZVIS.Location = new System.Drawing.Point(540, 520);
            this.lblZVIS.Name = "lblZVIS";
            this.lblZVIS.Size = new System.Drawing.Size(260, 40);
            this.lblZVIS.TabIndex = 1;
            this.lblZVIS.Text = "입력성형(Input Shaping) 방식을 이용하여 잔류진동을 억제하는 기능";
            this.lblZVIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHEmg
            // 
            this.lblHEmg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHEmg.AutoSize = true;
            this.lblHEmg.Location = new System.Drawing.Point(540, 440);
            this.lblHEmg.Name = "lblHEmg";
            this.lblHEmg.Size = new System.Drawing.Size(260, 40);
            this.lblHEmg.TabIndex = 1;
            this.lblHEmg.Text = "Onboard 또는 범용 DI 입력에 의한 비상정지 설정";
            this.lblHEmg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSEmg
            // 
            this.lblSEmg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSEmg.AutoSize = true;
            this.lblSEmg.Location = new System.Drawing.Point(540, 400);
            this.lblSEmg.Name = "lblSEmg";
            this.lblSEmg.Size = new System.Drawing.Size(174, 40);
            this.lblSEmg.TabIndex = 1;
            this.lblSEmg.Text = "Software 방식의 비상정지 설정";
            this.lblSEmg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMC02P
            // 
            this.btnMC02P.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMC02P.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMC02P.Location = new System.Drawing.Point(807, 483);
            this.btnMC02P.Name = "btnMC02P";
            this.btnMC02P.Size = new System.Drawing.Size(114, 34);
            this.btnMC02P.TabIndex = 0;
            this.btnMC02P.Text = "ETS-MC02P";
            this.btnMC02P.UseVisualStyleBackColor = false;
            this.btnMC02P.Click += new System.EventHandler(this.btnMC02P_Click);
            // 
            // btnGCode
            // 
            this.btnGCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGCode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGCode.Location = new System.Drawing.Point(807, 563);
            this.btnGCode.Name = "btnGCode";
            this.btnGCode.Size = new System.Drawing.Size(114, 34);
            this.btnGCode.TabIndex = 0;
            this.btnGCode.Text = "G Code";
            this.btnGCode.UseVisualStyleBackColor = false;
            this.btnGCode.Click += new System.EventHandler(this.btnGCode_Click);
            // 
            // lblPdoToStruct
            // 
            this.lblPdoToStruct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPdoToStruct.AutoSize = true;
            this.lblPdoToStruct.Location = new System.Drawing.Point(927, 360);
            this.lblPdoToStruct.Name = "lblPdoToStruct";
            this.lblPdoToStruct.Size = new System.Drawing.Size(257, 40);
            this.lblPdoToStruct.TabIndex = 1;
            this.lblPdoToStruct.Text = "PDO Data를 구조체로 확인합니다.  4byte 이상의 IO data 등을 한번에 확인할 수 있습니다.";
            this.lblPdoToStruct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCookBook10
            // 
            this.btnCookBook10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCookBook10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCookBook10.Location = new System.Drawing.Point(33, 603);
            this.btnCookBook10.Name = "btnCookBook10";
            this.btnCookBook10.Size = new System.Drawing.Size(114, 147);
            this.btnCookBook10.TabIndex = 2;
            this.btnCookBook10.Text = "CookBook 10";
            this.btnCookBook10.UseVisualStyleBackColor = false;
            this.btnCookBook10.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(153, 600);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 12);
            this.label16.TabIndex = 3;
            this.label16.Text = "label16";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 753);
            this.Controls.Add(this.tlpMain);
            this.Name = "formMain";
            this.Text = "EtherCAT Examples Ver 0.91 (2020.04.17)";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnCfg;
        private System.Windows.Forms.Button btnSxMot;
        private System.Windows.Forms.Button btnSxSt;
        private System.Windows.Forms.Button btnPosCorr;
        private System.Windows.Forms.Button btnPosCorr_2D;
        private System.Windows.Forms.Button btnRingCounter;
        private System.Windows.Forms.Button btnExtStop;
        private System.Windows.Forms.Button btnSD;
        private System.Windows.Forms.Button btnCmpOne;
        private System.Windows.Forms.Button btnZVIS;
        private System.Windows.Forms.Button btnCollisionAvoidance;
        private System.Windows.Forms.Button btnPtMotion;
        private System.Windows.Forms.Button btnListMotion;
        private System.Windows.Forms.Button btnMasterSlave;
        private System.Windows.Forms.Button btnHoming;
        private System.Windows.Forms.Button btnIxVia;
        private System.Windows.Forms.Button btnMpr2xLin;
        private System.Windows.Forms.Button btnIxSpline;
        private System.Windows.Forms.Button btnIxArc;
        private System.Windows.Forms.Button btnIxLine;
        private System.Windows.Forms.Button btnMxMot;
        private System.Windows.Forms.Button btnmAutoTorque;
        private System.Windows.Forms.Button btnTorque;
        private System.Windows.Forms.Button btnMultiTorque;
        private System.Windows.Forms.Label lblAutoTorque;
        private System.Windows.Forms.Label lblMultiTorque;
        private System.Windows.Forms.Label lblSD;
        private System.Windows.Forms.Label lblExtStop;
        private System.Windows.Forms.Button btnOverride;
        private System.Windows.Forms.Button btnSlaveIF;
        private System.Windows.Forms.Button btnAio;
        private System.Windows.Forms.Button btnDio;
        private System.Windows.Forms.Button btnTouchProbe;
        private System.Windows.Forms.Label lblCmpOne;
        private System.Windows.Forms.Button btnCmpCont;
        private System.Windows.Forms.Label lblCmpContinuous;
        private System.Windows.Forms.Button btnSxMot_aSync;
        private System.Windows.Forms.Button btnSoftEmg;
        private System.Windows.Forms.Label lblSEmg;
        private System.Windows.Forms.Button btnDiLatch;
        private System.Windows.Forms.Button btnSyncAxis;
        private System.Windows.Forms.Label lblZVIS;
        private System.Windows.Forms.Button btnSetSpeedAdv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPMonitor;
        private System.Windows.Forms.Button btnHardEmg;
        private System.Windows.Forms.Label lblHEmg;
        private System.Windows.Forms.Button btnRingCounter_Abs;
        private System.Windows.Forms.Button btnPdoToStruct;
        private System.Windows.Forms.Button btnMC02P;
        private System.Windows.Forms.Button btnGCode;
        private System.Windows.Forms.Label lblPdoToStruct;
        private System.Windows.Forms.Button btnCookBook10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer timer1;
    }
}

