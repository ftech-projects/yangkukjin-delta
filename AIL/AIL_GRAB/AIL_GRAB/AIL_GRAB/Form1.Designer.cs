namespace AIL_GRAB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGRAB = new Button();
            btnLIVE = new Button();
            btnSTOP = new Button();
            SuspendLayout();
            // 
            // btnGRAB
            // 
            btnGRAB.Location = new Point(12, 12);
            btnGRAB.Name = "btnGRAB";
            btnGRAB.Size = new Size(75, 23);
            btnGRAB.TabIndex = 0;
            btnGRAB.Text = "GRAB";
            btnGRAB.UseVisualStyleBackColor = true;
            btnGRAB.Click += btnGRAB_Click;
            // 
            // btnLIVE
            // 
            btnLIVE.Location = new Point(93, 12);
            btnLIVE.Name = "btnLIVE";
            btnLIVE.Size = new Size(75, 23);
            btnLIVE.TabIndex = 1;
            btnLIVE.Text = "LIVE";
            btnLIVE.UseVisualStyleBackColor = true;
            btnLIVE.Click += btnLIVE_Click;
            // 
            // btnSTOP
            // 
            btnSTOP.Location = new Point(174, 12);
            btnSTOP.Name = "btnSTOP";
            btnSTOP.Size = new Size(75, 23);
            btnSTOP.TabIndex = 2;
            btnSTOP.Text = "STOP";
            btnSTOP.UseVisualStyleBackColor = true;
            btnSTOP.Click += btnSTOP_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSTOP);
            Controls.Add(btnLIVE);
            Controls.Add(btnGRAB);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGRAB;
        private Button btnLIVE;
        private Button btnSTOP;
    }
}
