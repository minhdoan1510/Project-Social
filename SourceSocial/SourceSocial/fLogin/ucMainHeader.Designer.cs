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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMainHeader));
            this.pnlNotify = new System.Windows.Forms.Panel();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnlProfile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNotify = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMess = new Bunifu.Framework.UI.BunifuImageButton();
            this.tbxSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnGame = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGame)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNotify
            // 
            this.pnlNotify.BackColor = System.Drawing.Color.Transparent;
            this.pnlNotify.Controls.Add(this.btnGame);
            this.pnlNotify.Controls.Add(this.btnMess);
            this.pnlNotify.Controls.Add(this.btnNotify);
            this.pnlNotify.Location = new System.Drawing.Point(707, 12);
            this.pnlNotify.Name = "pnlNotify";
            this.pnlNotify.Size = new System.Drawing.Size(165, 50);
            this.pnlNotify.TabIndex = 6;
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
            // pnlProfile
            // 
            this.pnlProfile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlProfile.BorderRadius = 0;
            this.pnlProfile.ButtonText = "bunifuFlatButton1";
            this.pnlProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlProfile.DisabledColor = System.Drawing.Color.Gray;
            this.pnlProfile.Iconcolor = System.Drawing.Color.Transparent;
            this.pnlProfile.Iconimage = ((System.Drawing.Image)(resources.GetObject("pnlProfile.Iconimage")));
            this.pnlProfile.Iconimage_right = null;
            this.pnlProfile.Iconimage_right_Selected = null;
            this.pnlProfile.Iconimage_Selected = null;
            this.pnlProfile.IconMarginLeft = 0;
            this.pnlProfile.IconMarginRight = 0;
            this.pnlProfile.IconRightVisible = true;
            this.pnlProfile.IconRightZoom = 0D;
            this.pnlProfile.IconVisible = true;
            this.pnlProfile.IconZoom = 80D;
            this.pnlProfile.IsTab = false;
            this.pnlProfile.Location = new System.Drawing.Point(884, 12);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlProfile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlProfile.OnHoverTextColor = System.Drawing.Color.White;
            this.pnlProfile.selected = false;
            this.pnlProfile.Size = new System.Drawing.Size(181, 50);
            this.pnlProfile.TabIndex = 8;
            this.pnlProfile.Text = "bunifuFlatButton1";
            this.pnlProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlProfile.Textcolor = System.Drawing.Color.White;
            this.pnlProfile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnNotify
            // 
            this.btnNotify.BackColor = System.Drawing.Color.White;
            this.btnNotify.ErrorImage = null;
            this.btnNotify.ImageActive = null;
            this.btnNotify.InitialImage = null;
            this.btnNotify.Location = new System.Drawing.Point(58, 0);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(50, 50);
            this.btnNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNotify.TabIndex = 9;
            this.btnNotify.TabStop = false;
            this.btnNotify.Zoom = 10;
            // 
            // btnMess
            // 
            this.btnMess.BackColor = System.Drawing.Color.White;
            this.btnMess.ErrorImage = null;
            this.btnMess.ImageActive = null;
            this.btnMess.InitialImage = null;
            this.btnMess.Location = new System.Drawing.Point(115, 0);
            this.btnMess.Name = "btnMess";
            this.btnMess.Size = new System.Drawing.Size(50, 50);
            this.btnMess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMess.TabIndex = 10;
            this.btnMess.TabStop = false;
            this.btnMess.Zoom = 10;
            this.btnMess.Click += new System.EventHandler(this.BtnMess_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.BorderColor = System.Drawing.Color.Red;
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(278, 23);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(389, 31);
            this.tbxSearch.TabIndex = 9;
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.White;
            this.btnGame.ErrorImage = null;
            this.btnGame.ImageActive = null;
            this.btnGame.InitialImage = null;
            this.btnGame.Location = new System.Drawing.Point(1, 0);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(50, 50);
            this.btnGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGame.TabIndex = 11;
            this.btnGame.TabStop = false;
            this.btnGame.Zoom = 10;
            // 
            // UCMainHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.pnlNotify);
            this.Controls.Add(this.ptbLogo);
            this.Name = "UCMainHeader";
            this.Size = new System.Drawing.Size(1080, 75);
            this.pnlNotify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlNotify;
        private System.Windows.Forms.PictureBox ptbLogo;
        private Bunifu.Framework.UI.BunifuFlatButton pnlProfile;
        private Bunifu.Framework.UI.BunifuImageButton btnNotify;
        private Bunifu.Framework.UI.BunifuImageButton btnMess;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbxSearch;
        private Bunifu.Framework.UI.BunifuImageButton btnGame;
    }
}
