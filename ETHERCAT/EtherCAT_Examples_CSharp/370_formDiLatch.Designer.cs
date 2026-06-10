namespace EtherCAT_Examples_CSharp
{
    partial class formDiLatch
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
            this.lblLocalCh = new System.Windows.Forms.Label();
            this.lblfilterCycle = new System.Windows.Forms.Label();
            this.tbxFilterCycle = new System.Windows.Forms.TextBox();
            this.lblIntertLogic = new System.Windows.Forms.Label();
            this.tbxControl = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbxInvertLogic = new System.Windows.Forms.ComboBox();
            this.tbxLocalCh = new System.Windows.Forms.TextBox();
            this.tbxSlaveAddr = new System.Windows.Forms.TextBox();
            this.lblSlaveAddr = new System.Windows.Forms.Label();
            this.gbxState = new System.Windows.Forms.GroupBox();
            this.lblLatchCount = new System.Windows.Forms.Label();
            this.tbxLatchCount = new System.Windows.Forms.TextBox();
            this.t_DiLatch = new System.Windows.Forms.Timer(this.components);
            this.tbxControl.SuspendLayout();
            this.gbxState.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocalCh
            // 
            this.lblLocalCh.AutoSize = true;
            this.lblLocalCh.Location = new System.Drawing.Point(26, 69);
            this.lblLocalCh.Name = "lblLocalCh";
            this.lblLocalCh.Size = new System.Drawing.Size(87, 12);
            this.lblLocalCh.TabIndex = 0;
            this.lblLocalCh.Text = "Local Channel";
            // 
            // lblfilterCycle
            // 
            this.lblfilterCycle.AutoSize = true;
            this.lblfilterCycle.Location = new System.Drawing.Point(26, 96);
            this.lblfilterCycle.Name = "lblfilterCycle";
            this.lblfilterCycle.Size = new System.Drawing.Size(69, 12);
            this.lblfilterCycle.TabIndex = 0;
            this.lblfilterCycle.Text = "Filter Cycle";
            // 
            // tbxFilterCycle
            // 
            this.tbxFilterCycle.Location = new System.Drawing.Point(119, 93);
            this.tbxFilterCycle.Name = "tbxFilterCycle";
            this.tbxFilterCycle.Size = new System.Drawing.Size(100, 21);
            this.tbxFilterCycle.TabIndex = 1;
            // 
            // lblIntertLogic
            // 
            this.lblIntertLogic.AutoSize = true;
            this.lblIntertLogic.Location = new System.Drawing.Point(26, 123);
            this.lblIntertLogic.Name = "lblIntertLogic";
            this.lblIntertLogic.Size = new System.Drawing.Size(70, 12);
            this.lblIntertLogic.TabIndex = 0;
            this.lblIntertLogic.Text = "Invert Logic";
            // 
            // tbxControl
            // 
            this.tbxControl.Controls.Add(this.btnStop);
            this.tbxControl.Controls.Add(this.btnStart);
            this.tbxControl.Controls.Add(this.cbxInvertLogic);
            this.tbxControl.Controls.Add(this.tbxLocalCh);
            this.tbxControl.Controls.Add(this.tbxSlaveAddr);
            this.tbxControl.Controls.Add(this.lblSlaveAddr);
            this.tbxControl.Controls.Add(this.tbxFilterCycle);
            this.tbxControl.Controls.Add(this.lblLocalCh);
            this.tbxControl.Controls.Add(this.lblfilterCycle);
            this.tbxControl.Controls.Add(this.lblIntertLogic);
            this.tbxControl.Location = new System.Drawing.Point(26, 22);
            this.tbxControl.Name = "tbxControl";
            this.tbxControl.Size = new System.Drawing.Size(246, 227);
            this.tbxControl.TabIndex = 2;
            this.tbxControl.TabStop = false;
            this.tbxControl.Text = "Control";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(128, 159);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(91, 45);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(28, 159);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 45);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbxInvertLogic
            // 
            this.cbxInvertLogic.FormattingEnabled = true;
            this.cbxInvertLogic.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.cbxInvertLogic.Location = new System.Drawing.Point(119, 120);
            this.cbxInvertLogic.Name = "cbxInvertLogic";
            this.cbxInvertLogic.Size = new System.Drawing.Size(100, 20);
            this.cbxInvertLogic.TabIndex = 2;
            // 
            // tbxLocalCh
            // 
            this.tbxLocalCh.Location = new System.Drawing.Point(119, 66);
            this.tbxLocalCh.Name = "tbxLocalCh";
            this.tbxLocalCh.Size = new System.Drawing.Size(100, 21);
            this.tbxLocalCh.TabIndex = 1;
            this.tbxLocalCh.TextChanged += new System.EventHandler(this.tbxLocalCh_TextChanged);
            // 
            // tbxSlaveAddr
            // 
            this.tbxSlaveAddr.Location = new System.Drawing.Point(119, 39);
            this.tbxSlaveAddr.Name = "tbxSlaveAddr";
            this.tbxSlaveAddr.Size = new System.Drawing.Size(100, 21);
            this.tbxSlaveAddr.TabIndex = 1;
            this.tbxSlaveAddr.TextChanged += new System.EventHandler(this.tbxSlaveAddr_TextChanged);
            // 
            // lblSlaveAddr
            // 
            this.lblSlaveAddr.AutoSize = true;
            this.lblSlaveAddr.Location = new System.Drawing.Point(26, 42);
            this.lblSlaveAddr.Name = "lblSlaveAddr";
            this.lblSlaveAddr.Size = new System.Drawing.Size(87, 12);
            this.lblSlaveAddr.TabIndex = 0;
            this.lblSlaveAddr.Text = "Slave Address";
            // 
            // gbxState
            // 
            this.gbxState.Controls.Add(this.lblLatchCount);
            this.gbxState.Controls.Add(this.tbxLatchCount);
            this.gbxState.Location = new System.Drawing.Point(26, 269);
            this.gbxState.Name = "gbxState";
            this.gbxState.Size = new System.Drawing.Size(246, 100);
            this.gbxState.TabIndex = 3;
            this.gbxState.TabStop = false;
            this.gbxState.Text = "State";
            // 
            // lblLatchCount
            // 
            this.lblLatchCount.AutoSize = true;
            this.lblLatchCount.Location = new System.Drawing.Point(26, 45);
            this.lblLatchCount.Name = "lblLatchCount";
            this.lblLatchCount.Size = new System.Drawing.Size(73, 12);
            this.lblLatchCount.TabIndex = 0;
            this.lblLatchCount.Text = "Latch Count";
            // 
            // tbxLatchCount
            // 
            this.tbxLatchCount.Enabled = false;
            this.tbxLatchCount.Location = new System.Drawing.Point(119, 42);
            this.tbxLatchCount.Name = "tbxLatchCount";
            this.tbxLatchCount.Size = new System.Drawing.Size(100, 21);
            this.tbxLatchCount.TabIndex = 1;
            // 
            // t_DiLatch
            // 
            this.t_DiLatch.Tick += new System.EventHandler(this.t_DiLatch_Tick);
            // 
            // formDiLatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 381);
            this.Controls.Add(this.gbxState);
            this.Controls.Add(this.tbxControl);
            this.Name = "formDiLatch";
            this.tbxControl.ResumeLayout(false);
            this.tbxControl.PerformLayout();
            this.gbxState.ResumeLayout(false);
            this.gbxState.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLocalCh;
        private System.Windows.Forms.Label lblfilterCycle;
        private System.Windows.Forms.TextBox tbxFilterCycle;
        private System.Windows.Forms.Label lblIntertLogic;
        private System.Windows.Forms.GroupBox tbxControl;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbxInvertLogic;
        private System.Windows.Forms.TextBox tbxSlaveAddr;
        private System.Windows.Forms.Label lblSlaveAddr;
        private System.Windows.Forms.GroupBox gbxState;
        private System.Windows.Forms.Label lblLatchCount;
        private System.Windows.Forms.TextBox tbxLatchCount;
        private System.Windows.Forms.TextBox tbxLocalCh;
        private System.Windows.Forms.Timer t_DiLatch;

    }
}