namespace fLogin
{
    partial class UCProfile
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMain_Newfeed_AddPost = new System.Windows.Forms.Panel();
            this.pnlNewFeed_Main = new System.Windows.Forms.Panel();
            this.pnlAddPost = new System.Windows.Forms.Panel();
            this.pnlProfile_Infor = new System.Windows.Forms.Panel();
            this.pnlMain_Newfeed_AddPost.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(14, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 370);
            this.panel2.TabIndex = 11;
            // 
            // pnlMain_Newfeed_AddPost
            // 
            this.pnlMain_Newfeed_AddPost.AutoScroll = true;
            this.pnlMain_Newfeed_AddPost.Controls.Add(this.pnlNewFeed_Main);
            this.pnlMain_Newfeed_AddPost.Controls.Add(this.pnlAddPost);
            this.pnlMain_Newfeed_AddPost.Location = new System.Drawing.Point(352, 0);
            this.pnlMain_Newfeed_AddPost.MaximumSize = new System.Drawing.Size(716, 600);
            this.pnlMain_Newfeed_AddPost.Name = "pnlMain_Newfeed_AddPost";
            this.pnlMain_Newfeed_AddPost.Size = new System.Drawing.Size(716, 593);
            this.pnlMain_Newfeed_AddPost.TabIndex = 10;
            // 
            // pnlNewFeed_Main
            // 
            this.pnlNewFeed_Main.AutoSize = true;
            this.pnlNewFeed_Main.Location = new System.Drawing.Point(0, 190);
            this.pnlNewFeed_Main.Name = "pnlNewFeed_Main";
            this.pnlNewFeed_Main.Size = new System.Drawing.Size(716, 403);
            this.pnlNewFeed_Main.TabIndex = 2;
            // 
            // pnlAddPost
            // 
            this.pnlAddPost.Location = new System.Drawing.Point(0, 1);
            this.pnlAddPost.Name = "pnlAddPost";
            this.pnlAddPost.Size = new System.Drawing.Size(716, 162);
            this.pnlAddPost.TabIndex = 3;
            // 
            // pnlProfile_Infor
            // 
            this.pnlProfile_Infor.Location = new System.Drawing.Point(14, 12);
            this.pnlProfile_Infor.Name = "pnlProfile_Infor";
            this.pnlProfile_Infor.Size = new System.Drawing.Size(329, 174);
            this.pnlProfile_Infor.TabIndex = 9;
            // 
            // UCProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMain_Newfeed_AddPost);
            this.Controls.Add(this.pnlProfile_Infor);
            this.Name = "UCProfile";
            this.Size = new System.Drawing.Size(1080, 593);
            this.pnlMain_Newfeed_AddPost.ResumeLayout(false);
            this.pnlMain_Newfeed_AddPost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMain_Newfeed_AddPost;
        private System.Windows.Forms.Panel pnlNewFeed_Main;
        private System.Windows.Forms.Panel pnlAddPost;
        private System.Windows.Forms.Panel pnlProfile_Infor;
    }
}
