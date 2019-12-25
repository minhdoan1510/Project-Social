namespace fLogin
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.pnlMainHeader = new System.Windows.Forms.Panel();
            this.pnlNewFeed_Main = new System.Windows.Forms.Panel();
            this.pnlAddPost = new System.Windows.Forms.Panel();
            this.pnlCatalog = new System.Windows.Forms.Panel();
            this.pnlWeather = new System.Windows.Forms.Panel();
            this.pnlMain_Newfeed_AddPost = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlMain_Newfeed_AddPost.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainHeader
            // 
            this.pnlMainHeader.Location = new System.Drawing.Point(0, 24);
            this.pnlMainHeader.Name = "pnlMainHeader";
            this.pnlMainHeader.Size = new System.Drawing.Size(1076, 75);
            this.pnlMainHeader.TabIndex = 1;
            // 
            // pnlNewFeed_Main
            // 
            this.pnlNewFeed_Main.AutoSize = true;
            this.pnlNewFeed_Main.Location = new System.Drawing.Point(0, 200);
            this.pnlNewFeed_Main.Name = "pnlNewFeed_Main";
            this.pnlNewFeed_Main.Size = new System.Drawing.Size(707, 389);
            this.pnlNewFeed_Main.TabIndex = 2;
            // 
            // pnlAddPost
            // 
            this.pnlAddPost.Location = new System.Drawing.Point(0, 1);
            this.pnlAddPost.Name = "pnlAddPost";
            this.pnlAddPost.Size = new System.Drawing.Size(707, 162);
            this.pnlAddPost.TabIndex = 3;
            // 
            // pnlCatalog
            // 
            this.pnlCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.pnlCatalog.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCatalog.Location = new System.Drawing.Point(0, 0);
            this.pnlCatalog.Name = "pnlCatalog";
            this.pnlCatalog.Size = new System.Drawing.Size(217, 592);
            this.pnlCatalog.TabIndex = 4;
            // 
            // pnlWeather
            // 
            this.pnlWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.pnlWeather.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlWeather.Location = new System.Drawing.Point(924, 0);
            this.pnlWeather.Name = "pnlWeather";
            this.pnlWeather.Size = new System.Drawing.Size(149, 592);
            this.pnlWeather.TabIndex = 5;
            // 
            // pnlMain_Newfeed_AddPost
            // 
            this.pnlMain_Newfeed_AddPost.AutoScroll = true;
            this.pnlMain_Newfeed_AddPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.pnlMain_Newfeed_AddPost.Controls.Add(this.btnReload);
            this.pnlMain_Newfeed_AddPost.Controls.Add(this.pnlNewFeed_Main);
            this.pnlMain_Newfeed_AddPost.Controls.Add(this.pnlAddPost);
            this.pnlMain_Newfeed_AddPost.Location = new System.Drawing.Point(217, 0);
            this.pnlMain_Newfeed_AddPost.MaximumSize = new System.Drawing.Size(707, 593);
            this.pnlMain_Newfeed_AddPost.Name = "pnlMain_Newfeed_AddPost";
            this.pnlMain_Newfeed_AddPost.Size = new System.Drawing.Size(707, 590);
            this.pnlMain_Newfeed_AddPost.TabIndex = 6;
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.pnlCatalog);
            this.pnlHome.Controls.Add(this.pnlWeather);
            this.pnlHome.Controls.Add(this.pnlMain_Newfeed_AddPost);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHome.Location = new System.Drawing.Point(0, 100);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1073, 592);
            this.pnlHome.TabIndex = 7;
            // 
            // btnReload
            // 
            this.btnReload.Activecolor = System.Drawing.Color.Blue;
            this.btnReload.BackColor = System.Drawing.Color.Blue;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.BorderRadius = 0;
            this.btnReload.ButtonText = "Reload";
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.DisabledColor = System.Drawing.Color.Gray;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReload.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReload.Iconimage")));
            this.btnReload.Iconimage_right = null;
            this.btnReload.Iconimage_right_Selected = null;
            this.btnReload.Iconimage_Selected = null;
            this.btnReload.IconMarginLeft = 0;
            this.btnReload.IconMarginRight = 0;
            this.btnReload.IconRightVisible = true;
            this.btnReload.IconRightZoom = 0D;
            this.btnReload.IconVisible = true;
            this.btnReload.IconZoom = 40D;
            this.btnReload.IsTab = false;
            this.btnReload.Location = new System.Drawing.Point(286, 171);
            this.btnReload.Name = "btnReload";
            this.btnReload.Normalcolor = System.Drawing.Color.Blue;
            this.btnReload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReload.selected = false;
            this.btnReload.Size = new System.Drawing.Size(142, 23);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.Textcolor = System.Drawing.Color.White;
            this.btnReload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1073, 692);
            this.Controls.Add(this.pnlMainHeader);
            this.Controls.Add(this.pnlHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocialHub";
            this.pnlMain_Newfeed_AddPost.ResumeLayout(false);
            this.pnlMain_Newfeed_AddPost.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMainHeader;
        private System.Windows.Forms.Panel pnlNewFeed_Main;
        private System.Windows.Forms.Panel pnlAddPost;
        private System.Windows.Forms.Panel pnlCatalog;
        private System.Windows.Forms.Panel pnlWeather;
        private System.Windows.Forms.Panel pnlMain_Newfeed_AddPost;
        private System.Windows.Forms.Panel pnlHome;
        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
    }
}