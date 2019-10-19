namespace fLogin
{
    partial class UCMainHeader
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
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.pnlNotify = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.ptbAvatar);
            this.pnlProfile.Controls.Add(this.lbName);
            this.pnlProfile.Location = new System.Drawing.Point(880, 12);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(197, 50);
            this.pnlProfile.TabIndex = 7;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Location = new System.Drawing.Point(3, 3);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(44, 44);
            this.ptbAvatar.TabIndex = 1;
            this.ptbAvatar.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(53, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(62, 23);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            // 
            // pnlNotify
            // 
            this.pnlNotify.Location = new System.Drawing.Point(707, 12);
            this.pnlNotify.Name = "pnlNotify";
            this.pnlNotify.Size = new System.Drawing.Size(165, 50);
            this.pnlNotify.TabIndex = 6;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Location = new System.Drawing.Point(264, 21);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(422, 35);
            this.pnlSearch.TabIndex = 5;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Location = new System.Drawing.Point(4, 3);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(241, 68);
            this.ptbLogo.TabIndex = 4;
            this.ptbLogo.TabStop = false;
            // 
            // UCMainHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.pnlNotify);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.ptbLogo);
            this.Name = "UCMainHeader";
            this.Size = new System.Drawing.Size(1080, 75);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Panel pnlNotify;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.Label lbName;
    }
}
