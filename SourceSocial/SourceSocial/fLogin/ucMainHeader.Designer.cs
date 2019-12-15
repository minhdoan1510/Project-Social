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
            this.pnlNotify = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNotify = new System.Windows.Forms.Button();
            this.btnMess = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.pnlProfile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlNotify.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNotify
            // 
            this.pnlNotify.BackColor = System.Drawing.Color.Transparent;
            this.pnlNotify.Controls.Add(this.button2);
            this.pnlNotify.Controls.Add(this.btnNotify);
            this.pnlNotify.Controls.Add(this.btnMess);
            this.pnlNotify.Location = new System.Drawing.Point(707, 12);
            this.pnlNotify.Name = "pnlNotify";
            this.pnlNotify.Size = new System.Drawing.Size(165, 50);
            this.pnlNotify.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(7, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "frenf";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnNotify
            // 
            this.btnNotify.BackColor = System.Drawing.Color.Transparent;
            this.btnNotify.FlatAppearance.BorderSize = 0;
            this.btnNotify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(226)))), ((int)(((byte)(84)))));
            this.btnNotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotify.Location = new System.Drawing.Point(57, 0);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(50, 50);
            this.btnNotify.TabIndex = 1;
            this.btnNotify.UseVisualStyleBackColor = false;
            // 
            // btnMess
            // 
            this.btnMess.BackColor = System.Drawing.Color.Transparent;
            this.btnMess.FlatAppearance.BorderSize = 0;
            this.btnMess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(226)))), ((int)(((byte)(84)))));
            this.btnMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMess.Location = new System.Drawing.Point(112, 0);
            this.btnMess.Name = "btnMess";
            this.btnMess.Size = new System.Drawing.Size(50, 50);
            this.btnMess.TabIndex = 0;
            this.btnMess.UseVisualStyleBackColor = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.tbxSearch);
            this.pnlSearch.Location = new System.Drawing.Point(264, 21);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(422, 35);
            this.pnlSearch.TabIndex = 5;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(3, 3);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(416, 29);
            this.tbxSearch.TabIndex = 0;
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptbLogo.Location = new System.Drawing.Point(4, 3);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(241, 68);
            this.ptbLogo.TabIndex = 4;
            this.ptbLogo.TabStop = false;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Enabled = false;
            this.ptbAvatar.Location = new System.Drawing.Point(902, 16);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(44, 44);
            this.ptbAvatar.TabIndex = 1;
            this.ptbAvatar.TabStop = false;
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.Yellow;
            this.pnlProfile.Depth = 0;
            this.pnlProfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pnlProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlProfile.Location = new System.Drawing.Point(887, 12);
            this.pnlProfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Primary = true;
            this.pnlProfile.Size = new System.Drawing.Size(179, 51);
            this.pnlProfile.TabIndex = 7;
            this.pnlProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pnlProfile.UseVisualStyleBackColor = false;
            this.pnlProfile.Click += new System.EventHandler(this.PnlProfile_Click);
            // 
            // UCMainHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.ptbAvatar);
            this.Controls.Add(this.pnlNotify);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.pnlProfile);
            this.Name = "UCMainHeader";
            this.Size = new System.Drawing.Size(1080, 75);
            this.pnlNotify.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlNotify;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNotify;
        private System.Windows.Forms.Button btnMess;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private MaterialSkin.Controls.MaterialRaisedButton pnlProfile;
        private System.Windows.Forms.TextBox tbxSearch;
    }
}
