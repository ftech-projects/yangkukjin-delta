namespace EtherCAT_Examples_CSharp
{
    partial class formTorque
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
            this.rdoPosition = new System.Windows.Forms.RadioButton();
            this.rdoVelocity = new System.Windows.Forms.RadioButton();
            this.rdoTorque = new System.Windows.Forms.RadioButton();
            this.gbxOperationMode = new System.Windows.Forms.GroupBox();
            this.gbxVelocity = new System.Windows.Forms.GroupBox();
            this.btnVel = new System.Windows.Forms.Button();
            this.tbxTargetVel = new System.Windows.Forms.TextBox();
            this.lblTargetVelocity = new System.Windows.Forms.Label();
            this.tbxMaxTorque = new System.Windows.Forms.TextBox();
            this.lblMaxTorque = new System.Windows.Forms.Label();
            this.gbxTorque = new System.Windows.Forms.GroupBox();
            this.btnTorque = new System.Windows.Forms.Button();
            this.tbxTargetTorque = new System.Windows.Forms.TextBox();
            this.lblTargetTorque = new System.Windows.Forms.Label();
            this.tbxMaxVel = new System.Windows.Forms.TextBox();
            this.lblMaxVel = new System.Windows.Forms.Label();
            this.rdoHoming = new System.Windows.Forms.RadioButton();
            this.gbxOperationMode.SuspendLayout();
            this.gbxVelocity.SuspendLayout();
            this.gbxTorque.SuspendLayout();
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
            this.cbxAxisList.Location = new System.Drawing.Point(103, 16);
            this.cbxAxisList.Name = "cbxAxisList";
            this.cbxAxisList.Size = new System.Drawing.Size(121, 20);
            this.cbxAxisList.TabIndex = 19;
            this.cbxAxisList.SelectedIndexChanged += new System.EventHandler(this.cbxAxisList_SelectedIndexChanged);
            // 
            // rdoPosition
            // 
            this.rdoPosition.AutoSize = true;
            this.rdoPosition.Location = new System.Drawing.Point(21, 43);
            this.rdoPosition.Name = "rdoPosition";
            this.rdoPosition.Size = new System.Drawing.Size(112, 16);
            this.rdoPosition.TabIndex = 21;
            this.rdoPosition.TabStop = true;
            this.rdoPosition.Text = "Position Control";
            this.rdoPosition.UseVisualStyleBackColor = true;
            this.rdoPosition.CheckedChanged += new System.EventHandler(this.rdoPosition_CheckedChanged);
            // 
            // rdoVelocity
            // 
            this.rdoVelocity.AutoSize = true;
            this.rdoVelocity.Location = new System.Drawing.Point(20, 65);
            this.rdoVelocity.Name = "rdoVelocity";
            this.rdoVelocity.Size = new System.Drawing.Size(112, 16);
            this.rdoVelocity.TabIndex = 21;
            this.rdoVelocity.TabStop = true;
            this.rdoVelocity.Text = "Velocity Control";
            this.rdoVelocity.UseVisualStyleBackColor = true;
            this.rdoVelocity.CheckedChanged += new System.EventHandler(this.rdoVelocity_CheckedChanged);
            // 
            // rdoTorque
            // 
            this.rdoTorque.AutoSize = true;
            this.rdoTorque.Location = new System.Drawing.Point(20, 87);
            this.rdoTorque.Name = "rdoTorque";
            this.rdoTorque.Size = new System.Drawing.Size(107, 16);
            this.rdoTorque.TabIndex = 21;
            this.rdoTorque.TabStop = true;
            this.rdoTorque.Text = "Torque Control";
            this.rdoTorque.UseVisualStyleBackColor = true;
            this.rdoTorque.CheckedChanged += new System.EventHandler(this.rdoTorque_CheckedChanged);
            // 
            // gbxOperationMode
            // 
            this.gbxOperationMode.Controls.Add(this.rdoHoming);
            this.gbxOperationMode.Controls.Add(this.rdoPosition);
            this.gbxOperationMode.Controls.Add(this.rdoTorque);
            this.gbxOperationMode.Controls.Add(this.rdoVelocity);
            this.gbxOperationMode.Location = new System.Drawing.Point(24, 58);
            this.gbxOperationMode.Name = "gbxOperationMode";
            this.gbxOperationMode.Size = new System.Drawing.Size(248, 116);
            this.gbxOperationMode.TabIndex = 22;
            this.gbxOperationMode.TabStop = false;
            this.gbxOperationMode.Text = "Operation Mode";
            // 
            // gbxVelocity
            // 
            this.gbxVelocity.Controls.Add(this.btnVel);
            this.gbxVelocity.Controls.Add(this.tbxTargetVel);
            this.gbxVelocity.Controls.Add(this.lblTargetVelocity);
            this.gbxVelocity.Controls.Add(this.tbxMaxTorque);
            this.gbxVelocity.Controls.Add(this.lblMaxTorque);
            this.gbxVelocity.Location = new System.Drawing.Point(24, 180);
            this.gbxVelocity.Name = "gbxVelocity";
            this.gbxVelocity.Size = new System.Drawing.Size(248, 146);
            this.gbxVelocity.TabIndex = 23;
            this.gbxVelocity.TabStop = false;
            this.gbxVelocity.Text = "Velocity Control";
            // 
            // btnVel
            // 
            this.btnVel.Location = new System.Drawing.Point(116, 85);
            this.btnVel.Name = "btnVel";
            this.btnVel.Size = new System.Drawing.Size(100, 48);
            this.btnVel.TabIndex = 2;
            this.btnVel.Text = "Set Velocity";
            this.btnVel.UseVisualStyleBackColor = true;
            this.btnVel.Click += new System.EventHandler(this.btnVel_Click);
            // 
            // tbxTargetVel
            // 
            this.tbxTargetVel.Location = new System.Drawing.Point(116, 58);
            this.tbxTargetVel.Name = "tbxTargetVel";
            this.tbxTargetVel.Size = new System.Drawing.Size(100, 21);
            this.tbxTargetVel.TabIndex = 1;
            // 
            // lblTargetVelocity
            // 
            this.lblTargetVelocity.AutoSize = true;
            this.lblTargetVelocity.Location = new System.Drawing.Point(19, 61);
            this.lblTargetVelocity.Name = "lblTargetVelocity";
            this.lblTargetVelocity.Size = new System.Drawing.Size(90, 12);
            this.lblTargetVelocity.TabIndex = 0;
            this.lblTargetVelocity.Text = "Target Velocity";
            // 
            // tbxMaxTorque
            // 
            this.tbxMaxTorque.Location = new System.Drawing.Point(116, 31);
            this.tbxMaxTorque.Name = "tbxMaxTorque";
            this.tbxMaxTorque.Size = new System.Drawing.Size(100, 21);
            this.tbxMaxTorque.TabIndex = 1;
            this.tbxMaxTorque.Text = "0";
            // 
            // lblMaxTorque
            // 
            this.lblMaxTorque.AutoSize = true;
            this.lblMaxTorque.Location = new System.Drawing.Point(19, 34);
            this.lblMaxTorque.Name = "lblMaxTorque";
            this.lblMaxTorque.Size = new System.Drawing.Size(74, 12);
            this.lblMaxTorque.TabIndex = 0;
            this.lblMaxTorque.Text = "Max Torque";
            // 
            // gbxTorque
            // 
            this.gbxTorque.Controls.Add(this.btnTorque);
            this.gbxTorque.Controls.Add(this.tbxTargetTorque);
            this.gbxTorque.Controls.Add(this.lblTargetTorque);
            this.gbxTorque.Controls.Add(this.tbxMaxVel);
            this.gbxTorque.Controls.Add(this.lblMaxVel);
            this.gbxTorque.Location = new System.Drawing.Point(24, 332);
            this.gbxTorque.Name = "gbxTorque";
            this.gbxTorque.Size = new System.Drawing.Size(248, 146);
            this.gbxTorque.TabIndex = 23;
            this.gbxTorque.TabStop = false;
            this.gbxTorque.Text = "Torque Control";
            // 
            // btnTorque
            // 
            this.btnTorque.Location = new System.Drawing.Point(116, 85);
            this.btnTorque.Name = "btnTorque";
            this.btnTorque.Size = new System.Drawing.Size(100, 48);
            this.btnTorque.TabIndex = 2;
            this.btnTorque.Text = "Set Torque";
            this.btnTorque.UseVisualStyleBackColor = true;
            this.btnTorque.Click += new System.EventHandler(this.btnTorque_Click);
            // 
            // tbxTargetTorque
            // 
            this.tbxTargetTorque.Location = new System.Drawing.Point(116, 58);
            this.tbxTargetTorque.Name = "tbxTargetTorque";
            this.tbxTargetTorque.Size = new System.Drawing.Size(100, 21);
            this.tbxTargetTorque.TabIndex = 1;
            // 
            // lblTargetTorque
            // 
            this.lblTargetTorque.AutoSize = true;
            this.lblTargetTorque.Location = new System.Drawing.Point(19, 61);
            this.lblTargetTorque.Name = "lblTargetTorque";
            this.lblTargetTorque.Size = new System.Drawing.Size(85, 12);
            this.lblTargetTorque.TabIndex = 0;
            this.lblTargetTorque.Text = "Target Torque";
            // 
            // tbxMaxVel
            // 
            this.tbxMaxVel.Location = new System.Drawing.Point(116, 31);
            this.tbxMaxVel.Name = "tbxMaxVel";
            this.tbxMaxVel.Size = new System.Drawing.Size(100, 21);
            this.tbxMaxVel.TabIndex = 1;
            // 
            // lblMaxVel
            // 
            this.lblMaxVel.AutoSize = true;
            this.lblMaxVel.Location = new System.Drawing.Point(19, 34);
            this.lblMaxVel.Name = "lblMaxVel";
            this.lblMaxVel.Size = new System.Drawing.Size(81, 12);
            this.lblMaxVel.TabIndex = 0;
            this.lblMaxVel.Text = "Velocity Limit";
            // 
            // rdoHoming
            // 
            this.rdoHoming.AutoSize = true;
            this.rdoHoming.Location = new System.Drawing.Point(21, 21);
            this.rdoHoming.Name = "rdoHoming";
            this.rdoHoming.Size = new System.Drawing.Size(110, 16);
            this.rdoHoming.TabIndex = 21;
            this.rdoHoming.TabStop = true;
            this.rdoHoming.Text = "Homing Control";
            this.rdoHoming.UseVisualStyleBackColor = true;
            this.rdoHoming.CheckedChanged += new System.EventHandler(this.rdoHoming_CheckedChanged);
            // 
            // FormTorque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 489);
            this.Controls.Add(this.gbxTorque);
            this.Controls.Add(this.gbxVelocity);
            this.Controls.Add(this.gbxOperationMode);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxAxisList);
            this.Name = "FormTorque";
            this.gbxOperationMode.ResumeLayout(false);
            this.gbxOperationMode.PerformLayout();
            this.gbxVelocity.ResumeLayout(false);
            this.gbxVelocity.PerformLayout();
            this.gbxTorque.ResumeLayout(false);
            this.gbxTorque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.RadioButton rdoPosition;
        private System.Windows.Forms.RadioButton rdoVelocity;
        private System.Windows.Forms.RadioButton rdoTorque;
        private System.Windows.Forms.GroupBox gbxOperationMode;
        private System.Windows.Forms.GroupBox gbxVelocity;
        private System.Windows.Forms.Button btnVel;
        private System.Windows.Forms.TextBox tbxTargetVel;
        private System.Windows.Forms.Label lblTargetVelocity;
        private System.Windows.Forms.TextBox tbxMaxTorque;
        private System.Windows.Forms.Label lblMaxTorque;
        private System.Windows.Forms.GroupBox gbxTorque;
        private System.Windows.Forms.Button btnTorque;
        private System.Windows.Forms.TextBox tbxTargetTorque;
        private System.Windows.Forms.Label lblTargetTorque;
        private System.Windows.Forms.TextBox tbxMaxVel;
        private System.Windows.Forms.Label lblMaxVel;
        private System.Windows.Forms.RadioButton rdoHoming;
    }
}