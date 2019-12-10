namespace fLogin
{
    partial class UCMessofYou
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbMess = new RoundedLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 28);
            this.panel1.TabIndex = 2;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbAvatar.Location = new System.Drawing.Point(7, 0);
            this.ptbAvatar.MaximumSize = new System.Drawing.Size(26, 26);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(26, 26);
            this.ptbAvatar.TabIndex = 3;
            this.ptbAvatar.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(33, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 28);
            this.panel2.TabIndex = 4;
            // 
            // txbMess
            // 
            this.txbMess._BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txbMess.BackColor = System.Drawing.Color.Transparent;
            this.txbMess.Dock = System.Windows.Forms.DockStyle.Left;
            this.txbMess.Location = new System.Drawing.Point(43, 0);
            this.txbMess.MaximumSize = new System.Drawing.Size(210, 26);
            this.txbMess.Name = "txbMess";
            this.txbMess.Size = new System.Drawing.Size(169, 26);
            this.txbMess.TabIndex = 6;
            this.txbMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCMessofYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txbMess);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ptbAvatar);
            this.Controls.Add(this.panel1);
            this.Name = "UCMessofYou";
            this.Size = new System.Drawing.Size(256, 28);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.Panel panel2;
        private RoundedLabel txbMess;
    }
}
