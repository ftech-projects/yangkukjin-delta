namespace EtherCAT_Examples_CSharp
{
    partial class formSEmg
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
            this.gbxSEmg = new System.Windows.Forms.GroupBox();
            this.lblSEmgState = new System.Windows.Forms.Label();
            this.lblSEmgState_T = new System.Windows.Forms.Label();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.t_SEmg = new System.Windows.Forms.Timer(this.components);
            this.chkIsDecelStop = new System.Windows.Forms.CheckBox();
            this.gbxSEmg.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSEmg
            // 
            this.gbxSEmg.Controls.Add(this.chkIsDecelStop);
            this.gbxSEmg.Controls.Add(this.lblSEmgState);
            this.gbxSEmg.Controls.Add(this.lblSEmgState_T);
            this.gbxSEmg.Controls.Add(this.btnDisable);
            this.gbxSEmg.Controls.Add(this.btnEnable);
            this.gbxSEmg.Location = new System.Drawing.Point(29, 18);
            this.gbxSEmg.Name = "gbxSEmg";
            this.gbxSEmg.Size = new System.Drawing.Size(299, 176);
            this.gbxSEmg.TabIndex = 0;
            this.gbxSEmg.TabStop = false;
            this.gbxSEmg.Text = "Software Emergency";
            // 
            // lblSEmgState
            // 
            this.lblSEmgState.AutoSize = true;
            this.lblSEmgState.Location = new System.Drawing.Point(156, 144);
            this.lblSEmgState.Name = "lblSEmgState";
            this.lblSEmgState.Size = new System.Drawing.Size(11, 12);
            this.lblSEmgState.TabIndex = 1;
            this.lblSEmgState.Text = "-";
            // 
            // lblSEmgState_T
            // 
            this.lblSEmgState_T.AutoSize = true;
            this.lblSEmgState_T.Location = new System.Drawing.Point(19, 144);
            this.lblSEmgState_T.Name = "lblSEmgState_T";
            this.lblSEmgState_T.Size = new System.Drawing.Size(131, 12);
            this.lblSEmgState_T.TabIndex = 1;
            this.lblSEmgState_T.Text = "SoftEmergency State :";
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(143, 64);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(116, 61);
            this.btnDisable.TabIndex = 0;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(21, 64);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(116, 61);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // t_SEmg
            // 
            this.t_SEmg.Tick += new System.EventHandler(this.t_SEmg_Tick);
            // 
            // chkIsDecelStop
            // 
            this.chkIsDecelStop.AutoSize = true;
            this.chkIsDecelStop.Location = new System.Drawing.Point(21, 42);
            this.chkIsDecelStop.Name = "chkIsDecelStop";
            this.chkIsDecelStop.Size = new System.Drawing.Size(91, 16);
            this.chkIsDecelStop.TabIndex = 2;
            this.chkIsDecelStop.Text = "IsDecelStop";
            this.chkIsDecelStop.UseVisualStyleBackColor = true;
            // 
            // formSEmg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 222);
            this.Controls.Add(this.gbxSEmg);
            this.Name = "formSEmg";
            this.gbxSEmg.ResumeLayout(false);
            this.gbxSEmg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSEmg;
        private System.Windows.Forms.Label lblSEmgState;
        private System.Windows.Forms.Label lblSEmgState_T;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Timer t_SEmg;
        private System.Windows.Forms.CheckBox chkIsDecelStop;

    }
}