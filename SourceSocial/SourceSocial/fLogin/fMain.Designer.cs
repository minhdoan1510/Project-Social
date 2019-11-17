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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit_Form = new System.Windows.Forms.Button();
            this.pnlMainHeader = new System.Windows.Forms.Panel();
            this.pnlNewFeed_Main = new System.Windows.Forms.Panel();
            this.pnlAddPost = new System.Windows.Forms.Panel();
            this.pnlCatalog = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlMain_Newfeed_AddPost = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.pnlMain_Newfeed_AddPost.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.pnlTitle.Controls.Add(this.btnExit_Form);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1080, 30);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.TabStop = true;
            // 
            // btnExit_Form
            // 
            this.btnExit_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.btnExit_Form.FlatAppearance.BorderSize = 0;
            this.btnExit_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit_Form.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit_Form.ForeColor = System.Drawing.Color.White;
            this.btnExit_Form.Location = new System.Drawing.Point(1050, 0);
            this.btnExit_Form.Name = "btnExit_Form";
            this.btnExit_Form.Size = new System.Drawing.Size(30, 30);
            this.btnExit_Form.TabIndex = 0;
            this.btnExit_Form.Text = "X";
            this.btnExit_Form.UseVisualStyleBackColor = false;
            // 
            // pnlMainHeader
            // 
            this.pnlMainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainHeader.Location = new System.Drawing.Point(0, 30);
            this.pnlMainHeader.Name = "pnlMainHeader";
            this.pnlMainHeader.Size = new System.Drawing.Size(1080, 75);
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
            this.pnlCatalog.Location = new System.Drawing.Point(3, 1);
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
            this.pnlHome.Location = new System.Drawing.Point(3, 105);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1068, 592);
            this.pnlHome.TabIndex = 7;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1080, 699);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlMainHeader);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain";
            this.pnlTitle.ResumeLayout(false);
            this.pnlMain_Newfeed_AddPost.ResumeLayout(false);
            this.pnlMain_Newfeed_AddPost.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnExit_Form;
        private System.Windows.Forms.Panel pnlMainHeader;
        private System.Windows.Forms.Panel pnlNewFeed_Main;
        private System.Windows.Forms.Panel pnlAddPost;
        private System.Windows.Forms.Panel pnlCatalog;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlMain_Newfeed_AddPost;
        private System.Windows.Forms.Panel pnlHome;
    }
}