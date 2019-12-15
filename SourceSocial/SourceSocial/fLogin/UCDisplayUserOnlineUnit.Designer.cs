namespace fLogin
{
    partial class UCDisplayUserOnlineUnit
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
            this.lbName = new System.Windows.Forms.Label();
            this.ptbActive = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbActive)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbName.Location = new System.Drawing.Point(4, 5);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(96, 21);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Minh Đoàn";
            // 
            // ptbActive
            // 
            this.ptbActive.Location = new System.Drawing.Point(185, 9);
            this.ptbActive.Name = "ptbActive";
            this.ptbActive.Size = new System.Drawing.Size(13, 13);
            this.ptbActive.TabIndex = 1;
            this.ptbActive.TabStop = false;
            // 
            // UCDisplayUserOnlineUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.Controls.Add(this.ptbActive);
            this.Controls.Add(this.lbName);
            this.Name = "UCDisplayUserOnlineUnit";
            this.Size = new System.Drawing.Size(208, 30);
            ((System.ComponentModel.ISupportInitialize)(this.ptbActive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox ptbActive;
    }
}
