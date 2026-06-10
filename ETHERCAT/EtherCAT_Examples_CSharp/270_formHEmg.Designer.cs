namespace EtherCAT_Examples_CSharp
{
    partial class formHEmg
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
            this.gbxHEmg = new System.Windows.Forms.GroupBox();
            this.tbxFilterCount = new System.Windows.Forms.TextBox();
            this.cbxCh2 = new System.Windows.Forms.ComboBox();
            this.cbxCh1 = new System.Windows.Forms.ComboBox();
            this.cbxCh0 = new System.Windows.Forms.ComboBox();
            this.chkIsInvertLogic = new System.Windows.Forms.CheckBox();
            this.chkIsDecelStop = new System.Windows.Forms.CheckBox();
            this.lblFilterCount = new System.Windows.Forms.Label();
            this.lbl3rd = new System.Windows.Forms.Label();
            this.lblHEmgState = new System.Windows.Forms.Label();
            this.lbl2nd = new System.Windows.Forms.Label();
            this.lbl1st = new System.Windows.Forms.Label();
            this.lblHEmgState_T = new System.Windows.Forms.Label();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.t_HEmg = new System.Windows.Forms.Timer(this.components);
            this.gbxHEmg.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxHEmg
            // 
            this.gbxHEmg.Controls.Add(this.tbxFilterCount);
            this.gbxHEmg.Controls.Add(this.cbxCh2);
            this.gbxHEmg.Controls.Add(this.cbxCh1);
            this.gbxHEmg.Controls.Add(this.cbxCh0);
            this.gbxHEmg.Controls.Add(this.chkIsInvertLogic);
            this.gbxHEmg.Controls.Add(this.chkIsDecelStop);
            this.gbxHEmg.Controls.Add(this.lblFilterCount);
            this.gbxHEmg.Controls.Add(this.lbl3rd);
            this.gbxHEmg.Controls.Add(this.lblHEmgState);
            this.gbxHEmg.Controls.Add(this.lbl2nd);
            this.gbxHEmg.Controls.Add(this.lbl1st);
            this.gbxHEmg.Controls.Add(this.lblHEmgState_T);
            this.gbxHEmg.Controls.Add(this.btnDisable);
            this.gbxHEmg.Controls.Add(this.btnEnable);
            this.gbxHEmg.Location = new System.Drawing.Point(29, 18);
            this.gbxHEmg.Name = "gbxHEmg";
            this.gbxHEmg.Size = new System.Drawing.Size(299, 339);
            this.gbxHEmg.TabIndex = 0;
            this.gbxHEmg.TabStop = false;
            this.gbxHEmg.Text = "Hardware Emergency";
            // 
            // tbxFilterCount
            // 
            this.tbxFilterCount.Location = new System.Drawing.Point(147, 130);
            this.tbxFilterCount.Name = "tbxFilterCount";
            this.tbxFilterCount.Size = new System.Drawing.Size(116, 21);
            this.tbxFilterCount.TabIndex = 4;
            this.tbxFilterCount.Text = "0";
            // 
            // cbxCh2
            // 
            this.cbxCh2.FormattingEnabled = true;
            this.cbxCh2.Location = new System.Drawing.Point(147, 84);
            this.cbxCh2.Name = "cbxCh2";
            this.cbxCh2.Size = new System.Drawing.Size(116, 20);
            this.cbxCh2.TabIndex = 3;
            // 
            // cbxCh1
            // 
            this.cbxCh1.FormattingEnabled = true;
            this.cbxCh1.Location = new System.Drawing.Point(147, 58);
            this.cbxCh1.Name = "cbxCh1";
            this.cbxCh1.Size = new System.Drawing.Size(116, 20);
            this.cbxCh1.TabIndex = 3;
            // 
            // cbxCh0
            // 
            this.cbxCh0.FormattingEnabled = true;
            this.cbxCh0.Location = new System.Drawing.Point(147, 32);
            this.cbxCh0.Name = "cbxCh0";
            this.cbxCh0.Size = new System.Drawing.Size(116, 20);
            this.cbxCh0.TabIndex = 3;
            // 
            // chkIsInvertLogic
            // 
            this.chkIsInvertLogic.AutoSize = true;
            this.chkIsInvertLogic.Location = new System.Drawing.Point(46, 158);
            this.chkIsInvertLogic.Name = "chkIsInvertLogic";
            this.chkIsInvertLogic.Size = new System.Drawing.Size(95, 16);
            this.chkIsInvertLogic.TabIndex = 2;
            this.chkIsInvertLogic.Text = "IsInvertLogic";
            this.chkIsInvertLogic.UseVisualStyleBackColor = true;
            // 
            // chkIsDecelStop
            // 
            this.chkIsDecelStop.AutoSize = true;
            this.chkIsDecelStop.Location = new System.Drawing.Point(46, 180);
            this.chkIsDecelStop.Name = "chkIsDecelStop";
            this.chkIsDecelStop.Size = new System.Drawing.Size(91, 16);
            this.chkIsDecelStop.TabIndex = 2;
            this.chkIsDecelStop.Text = "IsDecelStop";
            this.chkIsDecelStop.UseVisualStyleBackColor = true;
            // 
            // lblFilterCount
            // 
            this.lblFilterCount.AutoSize = true;
            this.lblFilterCount.Location = new System.Drawing.Point(44, 133);
            this.lblFilterCount.Name = "lblFilterCount";
            this.lblFilterCount.Size = new System.Drawing.Size(69, 12);
            this.lblFilterCount.TabIndex = 1;
            this.lblFilterCount.Text = "Filter Count";
            // 
            // lbl3rd
            // 
            this.lbl3rd.AutoSize = true;
            this.lbl3rd.Location = new System.Drawing.Point(44, 87);
            this.lbl3rd.Name = "lbl3rd";
            this.lbl3rd.Size = new System.Drawing.Size(73, 12);
            this.lbl3rd.TabIndex = 1;
            this.lbl3rd.Text = "3rd Input Ch";
            // 
            // lblHEmgState
            // 
            this.lblHEmgState.AutoSize = true;
            this.lblHEmgState.Location = new System.Drawing.Point(145, 293);
            this.lblHEmgState.Name = "lblHEmgState";
            this.lblHEmgState.Size = new System.Drawing.Size(11, 12);
            this.lblHEmgState.TabIndex = 1;
            this.lblHEmgState.Text = "-";
            // 
            // lbl2nd
            // 
            this.lbl2nd.AutoSize = true;
            this.lbl2nd.Location = new System.Drawing.Point(44, 61);
            this.lbl2nd.Name = "lbl2nd";
            this.lbl2nd.Size = new System.Drawing.Size(76, 12);
            this.lbl2nd.TabIndex = 1;
            this.lbl2nd.Text = "2nd Input Ch";
            // 
            // lbl1st
            // 
            this.lbl1st.AutoSize = true;
            this.lbl1st.Location = new System.Drawing.Point(44, 35);
            this.lbl1st.Name = "lbl1st";
            this.lbl1st.Size = new System.Drawing.Size(72, 12);
            this.lbl1st.TabIndex = 1;
            this.lbl1st.Text = "1st Input Ch";
            // 
            // lblHEmgState_T
            // 
            this.lblHEmgState_T.AutoSize = true;
            this.lblHEmgState_T.Location = new System.Drawing.Point(23, 293);
            this.lblHEmgState_T.Name = "lblHEmgState_T";
            this.lblHEmgState_T.Size = new System.Drawing.Size(110, 12);
            this.lblHEmgState_T.TabIndex = 1;
            this.lblHEmgState_T.Text = "Emergency State :";
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(147, 217);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(116, 61);
            this.btnDisable.TabIndex = 0;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(25, 217);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(116, 61);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // t_HEmg
            // 
            this.t_HEmg.Tick += new System.EventHandler(this.t_HEmg_Tick);
            // 
            // formHEmg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 380);
            this.Controls.Add(this.gbxHEmg);
            this.Name = "formHEmg";
            this.gbxHEmg.ResumeLayout(false);
            this.gbxHEmg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHEmg;
        private System.Windows.Forms.Label lblHEmgState;
        private System.Windows.Forms.Label lblHEmgState_T;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Timer t_HEmg;
        private System.Windows.Forms.CheckBox chkIsDecelStop;
        private System.Windows.Forms.TextBox tbxFilterCount;
        private System.Windows.Forms.ComboBox cbxCh2;
        private System.Windows.Forms.ComboBox cbxCh1;
        private System.Windows.Forms.ComboBox cbxCh0;
        private System.Windows.Forms.Label lblFilterCount;
        private System.Windows.Forms.Label lbl3rd;
        private System.Windows.Forms.Label lbl2nd;
        private System.Windows.Forms.Label lbl1st;
        private System.Windows.Forms.CheckBox chkIsInvertLogic;

    }
}