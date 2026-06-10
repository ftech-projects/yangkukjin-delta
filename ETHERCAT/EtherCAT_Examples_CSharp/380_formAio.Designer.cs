namespace EtherCAT_Examples_CSharp
{
    partial class formAio
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
            this.gbxAi = new System.Windows.Forms.GroupBox();
            this.lblAiCh = new System.Windows.Forms.Label();
            this.cbxAiCh = new System.Windows.Forms.ComboBox();
            this.lblAiType = new System.Windows.Forms.Label();
            this.cbxAiType = new System.Windows.Forms.ComboBox();
            this.lblAiRangeMode = new System.Windows.Forms.Label();
            this.cbxAiRangeMode = new System.Windows.Forms.ComboBox();
            this.lblAi = new System.Windows.Forms.Label();
            this.tbxAi = new System.Windows.Forms.TextBox();
            this.gbxAo = new System.Windows.Forms.GroupBox();
            this.tbxAo = new System.Windows.Forms.TextBox();
            this.cbxAoRangeMode = new System.Windows.Forms.ComboBox();
            this.lblAo = new System.Windows.Forms.Label();
            this.lblAoRangeMode = new System.Windows.Forms.Label();
            this.cbxAoCh = new System.Windows.Forms.ComboBox();
            this.lblAoCh = new System.Windows.Forms.Label();
            this.t_AI = new System.Windows.Forms.Timer(this.components);
            this.btnOut = new System.Windows.Forms.Button();
            this.gbxAi.SuspendLayout();
            this.gbxAo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAi
            // 
            this.gbxAi.Controls.Add(this.tbxAi);
            this.gbxAi.Controls.Add(this.cbxAiRangeMode);
            this.gbxAi.Controls.Add(this.cbxAiType);
            this.gbxAi.Controls.Add(this.lblAi);
            this.gbxAi.Controls.Add(this.lblAiRangeMode);
            this.gbxAi.Controls.Add(this.cbxAiCh);
            this.gbxAi.Controls.Add(this.lblAiType);
            this.gbxAi.Controls.Add(this.lblAiCh);
            this.gbxAi.Location = new System.Drawing.Point(25, 22);
            this.gbxAi.Name = "gbxAi";
            this.gbxAi.Size = new System.Drawing.Size(265, 145);
            this.gbxAi.TabIndex = 0;
            this.gbxAi.TabStop = false;
            this.gbxAi.Text = "Analog In";
            // 
            // lblAiCh
            // 
            this.lblAiCh.AutoSize = true;
            this.lblAiCh.Location = new System.Drawing.Point(36, 31);
            this.lblAiCh.Name = "lblAiCh";
            this.lblAiCh.Size = new System.Drawing.Size(52, 12);
            this.lblAiCh.TabIndex = 0;
            this.lblAiCh.Text = "Channel";
            // 
            // cbxAiCh
            // 
            this.cbxAiCh.FormattingEnabled = true;
            this.cbxAiCh.Location = new System.Drawing.Point(119, 28);
            this.cbxAiCh.Name = "cbxAiCh";
            this.cbxAiCh.Size = new System.Drawing.Size(121, 20);
            this.cbxAiCh.TabIndex = 1;
            this.cbxAiCh.SelectedIndexChanged += new System.EventHandler(this.cbxAiCh_SelectedIndexChanged);
            // 
            // lblAiType
            // 
            this.lblAiType.AutoSize = true;
            this.lblAiType.Location = new System.Drawing.Point(36, 57);
            this.lblAiType.Name = "lblAiType";
            this.lblAiType.Size = new System.Drawing.Size(45, 12);
            this.lblAiType.TabIndex = 0;
            this.lblAiType.Text = "AiType";
            // 
            // cbxAiType
            // 
            this.cbxAiType.FormattingEnabled = true;
            this.cbxAiType.Location = new System.Drawing.Point(119, 54);
            this.cbxAiType.Name = "cbxAiType";
            this.cbxAiType.Size = new System.Drawing.Size(121, 20);
            this.cbxAiType.TabIndex = 1;
            this.cbxAiType.SelectedIndexChanged += new System.EventHandler(this.cbxAiType_SelectedIndexChanged);
            // 
            // lblAiRangeMode
            // 
            this.lblAiRangeMode.AutoSize = true;
            this.lblAiRangeMode.Location = new System.Drawing.Point(36, 83);
            this.lblAiRangeMode.Name = "lblAiRangeMode";
            this.lblAiRangeMode.Size = new System.Drawing.Size(73, 12);
            this.lblAiRangeMode.TabIndex = 0;
            this.lblAiRangeMode.Text = "RangeMode";
            // 
            // cbxAiRangeMode
            // 
            this.cbxAiRangeMode.FormattingEnabled = true;
            this.cbxAiRangeMode.Location = new System.Drawing.Point(119, 80);
            this.cbxAiRangeMode.Name = "cbxAiRangeMode";
            this.cbxAiRangeMode.Size = new System.Drawing.Size(121, 20);
            this.cbxAiRangeMode.TabIndex = 1;
            this.cbxAiRangeMode.SelectedIndexChanged += new System.EventHandler(this.cbxAiRangeMode_SelectedIndexChanged);
            // 
            // lblAi
            // 
            this.lblAi.AutoSize = true;
            this.lblAi.Location = new System.Drawing.Point(36, 109);
            this.lblAi.Name = "lblAi";
            this.lblAi.Size = new System.Drawing.Size(37, 12);
            this.lblAi.TabIndex = 0;
            this.lblAi.Text = "Value";
            // 
            // tbxAi
            // 
            this.tbxAi.Location = new System.Drawing.Point(119, 106);
            this.tbxAi.Name = "tbxAi";
            this.tbxAi.ReadOnly = true;
            this.tbxAi.Size = new System.Drawing.Size(121, 21);
            this.tbxAi.TabIndex = 2;
            // 
            // gbxAo
            // 
            this.gbxAo.Controls.Add(this.btnOut);
            this.gbxAo.Controls.Add(this.tbxAo);
            this.gbxAo.Controls.Add(this.cbxAoRangeMode);
            this.gbxAo.Controls.Add(this.lblAo);
            this.gbxAo.Controls.Add(this.lblAoRangeMode);
            this.gbxAo.Controls.Add(this.cbxAoCh);
            this.gbxAo.Controls.Add(this.lblAoCh);
            this.gbxAo.Location = new System.Drawing.Point(312, 22);
            this.gbxAo.Name = "gbxAo";
            this.gbxAo.Size = new System.Drawing.Size(265, 145);
            this.gbxAo.TabIndex = 0;
            this.gbxAo.TabStop = false;
            this.gbxAo.Text = "Analog Out";
            // 
            // tbxAo
            // 
            this.tbxAo.Location = new System.Drawing.Point(119, 106);
            this.tbxAo.Name = "tbxAo";
            this.tbxAo.Size = new System.Drawing.Size(66, 21);
            this.tbxAo.TabIndex = 2;
            // 
            // cbxAoRangeMode
            // 
            this.cbxAoRangeMode.FormattingEnabled = true;
            this.cbxAoRangeMode.Location = new System.Drawing.Point(119, 80);
            this.cbxAoRangeMode.Name = "cbxAoRangeMode";
            this.cbxAoRangeMode.Size = new System.Drawing.Size(121, 20);
            this.cbxAoRangeMode.TabIndex = 1;
            this.cbxAoRangeMode.SelectedIndexChanged += new System.EventHandler(this.cbxAoRangeMode_SelectedIndexChanged);
            // 
            // lblAo
            // 
            this.lblAo.AutoSize = true;
            this.lblAo.Location = new System.Drawing.Point(36, 109);
            this.lblAo.Name = "lblAo";
            this.lblAo.Size = new System.Drawing.Size(37, 12);
            this.lblAo.TabIndex = 0;
            this.lblAo.Text = "Value";
            // 
            // lblAoRangeMode
            // 
            this.lblAoRangeMode.AutoSize = true;
            this.lblAoRangeMode.Location = new System.Drawing.Point(36, 83);
            this.lblAoRangeMode.Name = "lblAoRangeMode";
            this.lblAoRangeMode.Size = new System.Drawing.Size(73, 12);
            this.lblAoRangeMode.TabIndex = 0;
            this.lblAoRangeMode.Text = "RangeMode";
            // 
            // cbxAoCh
            // 
            this.cbxAoCh.FormattingEnabled = true;
            this.cbxAoCh.Location = new System.Drawing.Point(119, 28);
            this.cbxAoCh.Name = "cbxAoCh";
            this.cbxAoCh.Size = new System.Drawing.Size(121, 20);
            this.cbxAoCh.TabIndex = 1;
            this.cbxAoCh.SelectedIndexChanged += new System.EventHandler(this.cbxAoCh_SelectedIndexChanged);
            // 
            // lblAoCh
            // 
            this.lblAoCh.AutoSize = true;
            this.lblAoCh.Location = new System.Drawing.Point(36, 31);
            this.lblAoCh.Name = "lblAoCh";
            this.lblAoCh.Size = new System.Drawing.Size(52, 12);
            this.lblAoCh.TabIndex = 0;
            this.lblAoCh.Text = "Channel";
            // 
            // t_AI
            // 
            this.t_AI.Tick += new System.EventHandler(this.t_AI_Tick);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(191, 104);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(49, 23);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "Output";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // formAio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 203);
            this.Controls.Add(this.gbxAo);
            this.Controls.Add(this.gbxAi);
            this.Name = "formAio";
            this.gbxAi.ResumeLayout(false);
            this.gbxAi.PerformLayout();
            this.gbxAo.ResumeLayout(false);
            this.gbxAo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAi;
        private System.Windows.Forms.TextBox tbxAi;
        private System.Windows.Forms.ComboBox cbxAiRangeMode;
        private System.Windows.Forms.ComboBox cbxAiType;
        private System.Windows.Forms.Label lblAi;
        private System.Windows.Forms.Label lblAiRangeMode;
        private System.Windows.Forms.ComboBox cbxAiCh;
        private System.Windows.Forms.Label lblAiType;
        private System.Windows.Forms.Label lblAiCh;
        private System.Windows.Forms.GroupBox gbxAo;
        private System.Windows.Forms.TextBox tbxAo;
        private System.Windows.Forms.ComboBox cbxAoRangeMode;
        private System.Windows.Forms.Label lblAo;
        private System.Windows.Forms.Label lblAoRangeMode;
        private System.Windows.Forms.ComboBox cbxAoCh;
        private System.Windows.Forms.Label lblAoCh;
        private System.Windows.Forms.Timer t_AI;
        private System.Windows.Forms.Button btnOut;

    }
}