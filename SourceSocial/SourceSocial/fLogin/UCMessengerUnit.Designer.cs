namespace fLogin
{
    partial class UCMessengerUnit
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbMessDisplay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Location = new System.Drawing.Point(6, 8);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(30, 30);
            this.ptbAvatar.TabIndex = 0;
            this.ptbAvatar.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(42, 6);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(41, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            // 
            // lbMessDisplay
            // 
            this.lbMessDisplay.AutoSize = true;
            this.lbMessDisplay.ForeColor = System.Drawing.Color.DimGray;
            this.lbMessDisplay.Location = new System.Drawing.Point(42, 26);
            this.lbMessDisplay.Name = "lbMessDisplay";
            this.lbMessDisplay.Size = new System.Drawing.Size(35, 13);
            this.lbMessDisplay.TabIndex = 2;
            this.lbMessDisplay.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lbMessDisplay);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.ptbAvatar);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 46);
            this.panel1.TabIndex = 3;
            // 
            // UCMessengerUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "UCMessengerUnit";
            this.Size = new System.Drawing.Size(256, 50);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMessDisplay;
        private System.Windows.Forms.Panel panel1;
    }
}
