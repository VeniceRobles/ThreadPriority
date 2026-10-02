namespace ThreadPriority
{
    partial class frmTrackThread
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
            lblStatus = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.MediumPurple;
            lblStatus.Location = new Point(78, 62);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(209, 34);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "-Thread Starts-";
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.MediumSlateBlue;
            btnRun.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRun.Location = new Point(134, 140);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 35);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += this.btnRun_Click;
            // 
            // frmTrackThread
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(371, 219);
            Controls.Add(btnRun);
            Controls.Add(lblStatus);
            Name = "frmTrackThread";
            Text = "frmTrackThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Button btnRun;
    }
}
