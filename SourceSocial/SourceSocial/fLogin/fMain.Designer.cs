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
            this.pnlMainHeader = new System.Windows.Forms.Panel();
            this.pnlNewFeed_Main = new System.Windows.Forms.Panel();
            this.pnlAddPost = new System.Windows.Forms.Panel();
            this.pnlCatalog = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlMain_Newfeed_AddPost = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlMain_Newfeed_AddPost.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainHeader
            // 
            this.pnlMainHeader.Location = new System.Drawing.Point(0, 25);
            this.pnlMainHeader.Name = "pnlMainHeader";
            this.pnlMainHeader.Size = new System.Drawing.Size(1076, 75);
            this.pnlMainHeader.TabIndex = 1;
            // 
            // pnlNewFeed_Main
            // 
            this.pnlNewFeed_Main.AutoSize = true;
            this.pnlNewFeed_Main.Location = new System.Drawing.Point(0, 189);
            this.pnlNewFeed_Main.Name = "pnlNewFeed_Main";
            this.pnlNewFeed_Main.Size = new System.Drawing.Size(707, 401);
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
            this.pnlCatalog.Location = new System.Drawing.Point(2, 1);
            this.pnlCatalog.Name = "pnlCatalog";
            this.pnlCatalog.Size = new System.Drawing.Size(208, 591);
            this.pnlCatalog.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(927, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(138, 589);
            this.panel6.TabIndex = 5;
            // 
            // pnlMain_Newfeed_AddPost
            // 
            this.pnlMain_Newfeed_AddPost.AutoScroll = true;
            this.pnlMain_Newfeed_AddPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
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
            this.pnlHome.Controls.Add(this.panel6);
            this.pnlHome.Controls.Add(this.pnlMain_Newfeed_AddPost);
            this.pnlHome.Location = new System.Drawing.Point(1, 101);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1068, 592);
            this.pnlHome.TabIndex = 7;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1073, 701);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlMainHeader);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain";
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlMain_Newfeed_AddPost;
        private System.Windows.Forms.Panel pnlHome;
    }
}