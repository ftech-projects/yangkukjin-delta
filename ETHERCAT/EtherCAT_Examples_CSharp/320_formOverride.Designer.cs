namespace EtherCAT_Examples_CSharp
{
    partial class formOverride
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
            this.lblAxis = new System.Windows.Forms.Label();
            this.cbxAxisList = new System.Windows.Forms.ComboBox();
            this.lblNewDist = new System.Windows.Forms.Label();
            this.tbxNewDist = new System.Windows.Forms.TextBox();
            this.lblNewPos = new System.Windows.Forms.Label();
            this.tbxNewPos = new System.Windows.Forms.TextBox();
            this.lblNewSpeed = new System.Windows.Forms.Label();
            this.tbxNewSpeed = new System.Windows.Forms.TextBox();
            this.gbxOverride = new System.Windows.Forms.GroupBox();
            this.btnOverrideMove = new System.Windows.Forms.Button();
            this.btnOverrideMoveTo = new System.Windows.Forms.Button();
            this.btnOverrideSpeed = new System.Windows.Forms.Button();
            this.lblResult_T = new System.Windows.Forms.Label();
            this.lblIsIgnored = new System.Windows.Forms.Label();
            this.gbxOverride.SuspendLayout();
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
            this.cbxAxisList.Location = new System.Drawing.Point(140, 16);
            this.cbxAxisList.Name = "cbxAxisList";
            this.cbxAxisList.Size = new System.Drawing.Size(100, 20);
            this.cbxAxisList.TabIndex = 19;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // lblNewDist
            // 
            this.lblNewDist.AutoSize = true;
            this.lblNewDist.Location = new System.Drawing.Point(39, 28);
            this.lblNewDist.Name = "lblNewDist";
            this.lblNewDist.Size = new System.Drawing.Size(84, 12);
            this.lblNewDist.TabIndex = 21;
            this.lblNewDist.Text = "New Distance";
            // 
            // tbxNewDist
            // 
            this.tbxNewDist.Location = new System.Drawing.Point(23, 43);
            this.tbxNewDist.Name = "tbxNewDist";
            this.tbxNewDist.Size = new System.Drawing.Size(100, 21);
            this.tbxNewDist.TabIndex = 22;
            // 
            // lblNewPos
            // 
            this.lblNewPos.AutoSize = true;
            this.lblNewPos.Location = new System.Drawing.Point(43, 81);
            this.lblNewPos.Name = "lblNewPos";
            this.lblNewPos.Size = new System.Drawing.Size(80, 12);
            this.lblNewPos.TabIndex = 21;
            this.lblNewPos.Text = "New Position";
            // 
            // tbxNewPos
            // 
            this.tbxNewPos.Location = new System.Drawing.Point(23, 96);
            this.tbxNewPos.Name = "tbxNewPos";
            this.tbxNewPos.Size = new System.Drawing.Size(100, 21);
            this.tbxNewPos.TabIndex = 22;
            // 
            // lblNewSpeed
            // 
            this.lblNewSpeed.AutoSize = true;
            this.lblNewSpeed.Location = new System.Drawing.Point(52, 136);
            this.lblNewSpeed.Name = "lblNewSpeed";
            this.lblNewSpeed.Size = new System.Drawing.Size(71, 12);
            this.lblNewSpeed.TabIndex = 21;
            this.lblNewSpeed.Text = "New Speed";
            // 
            // tbxNewSpeed
            // 
            this.tbxNewSpeed.Location = new System.Drawing.Point(23, 151);
            this.tbxNewSpeed.Name = "tbxNewSpeed";
            this.tbxNewSpeed.Size = new System.Drawing.Size(100, 21);
            this.tbxNewSpeed.TabIndex = 22;
            // 
            // gbxOverride
            // 
            this.gbxOverride.Controls.Add(this.lblIsIgnored);
            this.gbxOverride.Controls.Add(this.lblResult_T);
            this.gbxOverride.Controls.Add(this.btnOverrideSpeed);
            this.gbxOverride.Controls.Add(this.btnOverrideMoveTo);
            this.gbxOverride.Controls.Add(this.btnOverrideMove);
            this.gbxOverride.Controls.Add(this.lblNewDist);
            this.gbxOverride.Controls.Add(this.tbxNewSpeed);
            this.gbxOverride.Controls.Add(this.lblNewPos);
            this.gbxOverride.Controls.Add(this.tbxNewPos);
            this.gbxOverride.Controls.Add(this.tbxNewDist);
            this.gbxOverride.Controls.Add(this.lblNewSpeed);
            this.gbxOverride.Location = new System.Drawing.Point(12, 63);
            this.gbxOverride.Name = "gbxOverride";
            this.gbxOverride.Size = new System.Drawing.Size(250, 239);
            this.gbxOverride.TabIndex = 23;
            this.gbxOverride.TabStop = false;
            this.gbxOverride.Text = "Override";
            // 
            // btnOverrideMove
            // 
            this.btnOverrideMove.Location = new System.Drawing.Point(141, 28);
            this.btnOverrideMove.Name = "btnOverrideMove";
            this.btnOverrideMove.Size = new System.Drawing.Size(87, 36);
            this.btnOverrideMove.TabIndex = 23;
            this.btnOverrideMove.Text = "Override Move";
            this.btnOverrideMove.UseVisualStyleBackColor = true;
            this.btnOverrideMove.Click += new System.EventHandler(this.btnOverrideMove_Click);
            // 
            // btnOverrideMoveTo
            // 
            this.btnOverrideMoveTo.Location = new System.Drawing.Point(141, 81);
            this.btnOverrideMoveTo.Name = "btnOverrideMoveTo";
            this.btnOverrideMoveTo.Size = new System.Drawing.Size(87, 36);
            this.btnOverrideMoveTo.TabIndex = 23;
            this.btnOverrideMoveTo.Text = "Override MoveTo";
            this.btnOverrideMoveTo.UseVisualStyleBackColor = true;
            this.btnOverrideMoveTo.Click += new System.EventHandler(this.btnOverrideMoveTo_Click);
            // 
            // btnOverrideSpeed
            // 
            this.btnOverrideSpeed.Location = new System.Drawing.Point(141, 136);
            this.btnOverrideSpeed.Name = "btnOverrideSpeed";
            this.btnOverrideSpeed.Size = new System.Drawing.Size(87, 36);
            this.btnOverrideSpeed.TabIndex = 23;
            this.btnOverrideSpeed.Text = "Override Speed";
            this.btnOverrideSpeed.UseVisualStyleBackColor = true;
            this.btnOverrideSpeed.Click += new System.EventHandler(this.btnOverrideSpeed_Click);
            // 
            // lblResult_T
            // 
            this.lblResult_T.AutoSize = true;
            this.lblResult_T.Location = new System.Drawing.Point(21, 205);
            this.lblResult_T.Name = "lblResult_T";
            this.lblResult_T.Size = new System.Drawing.Size(99, 12);
            this.lblResult_T.TabIndex = 24;
            this.lblResult_T.Text = "Override Result :";
            // 
            // lblIsIgnored
            // 
            this.lblIsIgnored.AutoSize = true;
            this.lblIsIgnored.Location = new System.Drawing.Point(139, 205);
            this.lblIsIgnored.Name = "lblIsIgnored";
            this.lblIsIgnored.Size = new System.Drawing.Size(11, 12);
            this.lblIsIgnored.TabIndex = 24;
            this.lblIsIgnored.Text = "-";
            // 
            // formOverride
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 336);
            this.Controls.Add(this.gbxOverride);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxAxisList);
            this.Name = "formOverride";
            this.gbxOverride.ResumeLayout(false);
            this.gbxOverride.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.Label lblNewDist;
        private System.Windows.Forms.TextBox tbxNewDist;
        private System.Windows.Forms.Label lblNewPos;
        private System.Windows.Forms.TextBox tbxNewPos;
        private System.Windows.Forms.Label lblNewSpeed;
        private System.Windows.Forms.TextBox tbxNewSpeed;
        private System.Windows.Forms.GroupBox gbxOverride;
        private System.Windows.Forms.Button btnOverrideSpeed;
        private System.Windows.Forms.Button btnOverrideMoveTo;
        private System.Windows.Forms.Button btnOverrideMove;
        private System.Windows.Forms.Label lblIsIgnored;
        private System.Windows.Forms.Label lblResult_T;
    }
}