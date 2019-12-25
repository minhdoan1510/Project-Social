namespace fLogin
{
    partial class NotificationBox
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
            this.lbNotiText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNotiText
            // 
            this.lbNotiText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNotiText.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotiText.Location = new System.Drawing.Point(0, 0);
            this.lbNotiText.Name = "lbNotiText";
            this.lbNotiText.Size = new System.Drawing.Size(351, 136);
            this.lbNotiText.TabIndex = 0;
            this.lbNotiText.Text = "label1";
            this.lbNotiText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotificationBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 136);
            this.Controls.Add(this.lbNotiText);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Notification";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Notification_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNotiText;
    }
}