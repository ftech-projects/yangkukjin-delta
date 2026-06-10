namespace EtherCAT_Examples_CSharp
{
    partial class formMxMot
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
            this.tbxDist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvwItem = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnVMoveN = new System.Windows.Forms.Button();
            this.btnMoveStart = new System.Windows.Forms.Button();
            this.btnMoveToStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnVMoveP = new System.Windows.Forms.Button();
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
            this.cbxAxisList.Size = new System.Drawing.Size(117, 20);
            this.cbxAxisList.TabIndex = 19;
            // 
            // tbxDist
            // 
            this.tbxDist.Location = new System.Drawing.Point(103, 42);
            this.tbxDist.Name = "tbxDist";
            this.tbxDist.Size = new System.Drawing.Size(117, 21);
            this.tbxDist.TabIndex = 21;
            this.tbxDist.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "Distance";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(226, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 47);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvwItem
            // 
            this.lvwItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwItem.GridLines = true;
            this.lvwItem.Location = new System.Drawing.Point(319, 16);
            this.lvwItem.Name = "lvwItem";
            this.lvwItem.Size = new System.Drawing.Size(202, 122);
            this.lvwItem.TabIndex = 23;
            this.lvwItem.UseCompatibleStateImageBehavior = false;
            this.lvwItem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Axis";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Distance";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(444, 144);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 47);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnVMoveN
            // 
            this.btnVMoveN.Location = new System.Drawing.Point(40, 91);
            this.btnVMoveN.Name = "btnVMoveN";
            this.btnVMoveN.Size = new System.Drawing.Size(87, 47);
            this.btnVMoveN.TabIndex = 22;
            this.btnVMoveN.Text = "VMove (-)";
            this.btnVMoveN.UseVisualStyleBackColor = true;
            this.btnVMoveN.Click += new System.EventHandler(this.btnMoveN_Click);
            // 
            // btnMoveStart
            // 
            this.btnMoveStart.Location = new System.Drawing.Point(40, 144);
            this.btnMoveStart.Name = "btnMoveStart";
            this.btnMoveStart.Size = new System.Drawing.Size(87, 47);
            this.btnMoveStart.TabIndex = 22;
            this.btnMoveStart.Text = "MoveStart";
            this.btnMoveStart.UseVisualStyleBackColor = true;
            this.btnMoveStart.Click += new System.EventHandler(this.btnMoveStart_Click);
            // 
            // btnMoveToStart
            // 
            this.btnMoveToStart.Location = new System.Drawing.Point(133, 144);
            this.btnMoveToStart.Name = "btnMoveToStart";
            this.btnMoveToStart.Size = new System.Drawing.Size(87, 47);
            this.btnMoveToStart.TabIndex = 22;
            this.btnMoveToStart.Text = "MoveToStart";
            this.btnMoveToStart.UseVisualStyleBackColor = true;
            this.btnMoveToStart.Click += new System.EventHandler(this.btnMoveToStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(226, 144);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(87, 47);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnVMoveP
            // 
            this.btnVMoveP.Location = new System.Drawing.Point(133, 91);
            this.btnVMoveP.Name = "btnVMoveP";
            this.btnVMoveP.Size = new System.Drawing.Size(87, 47);
            this.btnVMoveP.TabIndex = 22;
            this.btnVMoveP.Text = "VMove (+)";
            this.btnVMoveP.UseVisualStyleBackColor = true;
            this.btnVMoveP.Click += new System.EventHandler(this.btnVMoveP_Click);
            // 
            // FormMxMot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 223);
            this.Controls.Add(this.lvwItem);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnMoveToStart);
            this.Controls.Add(this.btnMoveStart);
            this.Controls.Add(this.btnVMoveP);
            this.Controls.Add(this.btnVMoveN);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxDist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAxis);
            this.Controls.Add(this.cbxAxisList);
            this.Name = "FormMxMot";
            this.Text = "MxMot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.ComboBox cbxAxisList;
        private System.Windows.Forms.TextBox tbxDist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvwItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnVMoveN;
        private System.Windows.Forms.Button btnMoveStart;
        private System.Windows.Forms.Button btnMoveToStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnVMoveP;
    }
}