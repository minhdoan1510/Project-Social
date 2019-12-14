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
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.txbMess = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Location = new System.Drawing.Point(3, 3);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(20, 20);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAvatar.TabIndex = 0;
            this.ptbAvatar.TabStop = false;
            // 
            // txbMess
            // 
            this.txbMess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txbMess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMess.Location = new System.Drawing.Point(29, 3);
            this.txbMess.Multiline = true;
            this.txbMess.Name = "txbMess";
            this.txbMess.ReadOnly = true;
            this.txbMess.Size = new System.Drawing.Size(169, 20);
            this.txbMess.TabIndex = 1;
            // 
            // UCMessofYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txbMess);
            this.Controls.Add(this.ptbAvatar);
            this.MaximumSize = new System.Drawing.Size(256, 27);
            this.MinimumSize = new System.Drawing.Size(256, 27);
            this.Name = "UCMessofYou";
            this.Size = new System.Drawing.Size(256, 27);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.TextBox txbMess;
    }
}
