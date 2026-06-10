namespace EtherCAT_Examples_CSharp
{
    partial class formTouchProbe
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
            this.cbxTpIndex = new System.Windows.Forms.ComboBox();
            this.lblTpIndex = new System.Windows.Forms.Label();
            this.cbxEventMode = new System.Windows.Forms.ComboBox();
            this.lblEventMode = new System.Windows.Forms.Label();
            this.cbxTriggerSignal = new System.Windows.Forms.ComboBox();
            this.lblTrgSignal = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.cbxEdge = new System.Windows.Forms.ComboBox();
            this.lblEdge = new System.Windows.Forms.Label();
            this.gbxSetup = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.t_TP = new System.Windows.Forms.Timer(this.components);
            this.lbxMonitor = new System.Windows.Forms.ListBox();
            this.gbxSetup.SuspendLayout();
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
            this.cbxAxisList.Location = new System.Drawing.Point(127, 16);
            this.cbxAxisList.Name = "cbxAxisList";
            this.cbxAxisList.Size = new System.Drawing.Size(121, 20);
            this.cbxAxisList.TabIndex = 19;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // cbxTpIndex
            // 
            this.cbxTpIndex.FormattingEnabled = true;
            this.cbxTpIndex.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxTpIndex.Location = new System.Drawing.Point(102, 30);
            this.cbxTpIndex.Name = "cbxTpIndex";
            this.cbxTpIndex.Size = new System.Drawing.Size(121, 20);
            this.cbxTpIndex.TabIndex = 19;
            this.cbxTpIndex.SelectedIndexChanged += new System.EventHandler(this.cbxTpIndex_SelectedIndexChanged);
            // 
            // lblTpIndex
            // 
            this.lblTpIndex.AutoSize = true;
            this.lblTpIndex.Location = new System.Drawing.Point(13, 33);
            this.lblTpIndex.Name = "lblTpIndex";
            this.lblTpIndex.Size = new System.Drawing.Size(56, 12);
            this.lblTpIndex.TabIndex = 20;
            this.lblTpIndex.Text = "TP Index";
            // 
            // cbxEventMode
            // 
            this.cbxEventMode.FormattingEnabled = true;
            this.cbxEventMode.Items.AddRange(new object[] {
            "0 : Single",
            "1 : Continuous"});
            this.cbxEventMode.Location = new System.Drawing.Point(102, 56);
            this.cbxEventMode.Name = "cbxEventMode";
            this.cbxEventMode.Size = new System.Drawing.Size(121, 20);
            this.cbxEventMode.TabIndex = 19;
            // 
            // lblEventMode
            // 
            this.lblEventMode.AutoSize = true;
            this.lblEventMode.Location = new System.Drawing.Point(13, 59);
            this.lblEventMode.Name = "lblEventMode";
            this.lblEventMode.Size = new System.Drawing.Size(72, 12);
            this.lblEventMode.TabIndex = 20;
            this.lblEventMode.Text = "Event Mode";
            // 
            // cbxTriggerSignal
            // 
            this.cbxTriggerSignal.FormattingEnabled = true;
            this.cbxTriggerSignal.Items.AddRange(new object[] {
            "0 : TProbe_Signal",
            "1 : Encoder_ZPulse"});
            this.cbxTriggerSignal.Location = new System.Drawing.Point(102, 82);
            this.cbxTriggerSignal.Name = "cbxTriggerSignal";
            this.cbxTriggerSignal.Size = new System.Drawing.Size(121, 20);
            this.cbxTriggerSignal.TabIndex = 19;
            // 
            // lblTrgSignal
            // 
            this.lblTrgSignal.AutoSize = true;
            this.lblTrgSignal.Location = new System.Drawing.Point(13, 85);
            this.lblTrgSignal.Name = "lblTrgSignal";
            this.lblTrgSignal.Size = new System.Drawing.Size(84, 12);
            this.lblTrgSignal.TabIndex = 20;
            this.lblTrgSignal.Text = "Trigger Signal";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(146, 228);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 52);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cbxEdge
            // 
            this.cbxEdge.FormattingEnabled = true;
            this.cbxEdge.Items.AddRange(new object[] {
            "0 : Undefined",
            "1 : Falling",
            "2 : Rising"});
            this.cbxEdge.Location = new System.Drawing.Point(102, 108);
            this.cbxEdge.Name = "cbxEdge";
            this.cbxEdge.Size = new System.Drawing.Size(121, 20);
            this.cbxEdge.TabIndex = 19;
            // 
            // lblEdge
            // 
            this.lblEdge.AutoSize = true;
            this.lblEdge.Location = new System.Drawing.Point(13, 111);
            this.lblEdge.Name = "lblEdge";
            this.lblEdge.Size = new System.Drawing.Size(34, 12);
            this.lblEdge.TabIndex = 20;
            this.lblEdge.Text = "Edge";
            // 
            // gbxSetup
            // 
            this.gbxSetup.Controls.Add(this.lblTpIndex);
            this.gbxSetup.Controls.Add(this.cbxTpIndex);
            this.gbxSetup.Controls.Add(this.lblEdge);
            this.gbxSetup.Controls.Add(this.cbxEventMode);
            this.gbxSetup.Controls.Add(this.lblTrgSignal);
            this.gbxSetup.Controls.Add(this.cbxTriggerSignal);
            this.gbxSetup.Controls.Add(this.lblEventMode);
            this.gbxSetup.Controls.Add(this.cbxEdge);
            this.gbxSetup.Location = new System.Drawing.Point(24, 58);
            this.gbxSetup.Name = "gbxSetup";
            this.gbxSetup.Size = new System.Drawing.Size(248, 152);
            this.gbxSetup.TabIndex = 22;
            this.gbxSetup.TabStop = false;
            this.gbxSetup.Text = "Setup";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(40, 228);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 52);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // t_TP
            // 
            this.t_TP.Enabled = true;
            this.t_TP.Tick += new System.EventHandler(this.t_TP_Tick);
            // 
            // lbxMonitor
            // 
            this.lbxMonitor.FormattingEnabled = true;
            this.lbxMonitor.ItemHeight = 12;
            this.lbxMonitor.Location = new System.Drawing.Point(24, 304);
            this.lbxMonitor.Name = "lbxMonitor";
            this.lbxMonitor.Size = new System.Drawing.Size(248, 160);
            this.lbxMonitor.TabIndex = 23;
            // 
            // FormTouchProbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 482);
            this.Controls.Add(this.lbxMonitor);
            this.Controls.Add(this.gbxSetup);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxAxisList);
            this.Name = "FormTouchProbe";
            this.gbxSetup.ResumeLayout(false);
            this.gbxSetup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.ComboBox cbxTpIndex;
        private System.Windows.Forms.Label lblTpIndex;
        private System.Windows.Forms.ComboBox cbxEventMode;
        private System.Windows.Forms.Label lblEventMode;
        private System.Windows.Forms.ComboBox cbxTriggerSignal;
        private System.Windows.Forms.Label lblTrgSignal;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cbxEdge;
        private System.Windows.Forms.Label lblEdge;
        private System.Windows.Forms.GroupBox gbxSetup;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer t_TP;
        private System.Windows.Forms.ListBox lbxMonitor;
    }
}