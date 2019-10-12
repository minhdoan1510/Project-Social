namespace fLogin
{
    partial class PostDisplay
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
            this.btbAvatar_Post = new System.Windows.Forms.PictureBox();
            this.lbName_Post = new System.Windows.Forms.Label();
            this.lbTime_Post = new System.Windows.Forms.Label();
            this.pnlInfor = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlInter = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbLiked_Post = new System.Windows.Forms.Label();
            this.ptbLike = new System.Windows.Forms.PictureBox();
            this.lbContent_Post = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btbAvatar_Post)).BeginInit();
            this.pnlInfor.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlInter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLike)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btbAvatar_Post
            // 
            this.btbAvatar_Post.Location = new System.Drawing.Point(3, 13);
            this.btbAvatar_Post.Name = "btbAvatar_Post";
            this.btbAvatar_Post.Size = new System.Drawing.Size(40, 40);
            this.btbAvatar_Post.TabIndex = 0;
            this.btbAvatar_Post.TabStop = false;
            // 
            // lbName_Post
            // 
            this.lbName_Post.AutoSize = true;
            this.lbName_Post.Location = new System.Drawing.Point(57, 13);
            this.lbName_Post.Name = "lbName_Post";
            this.lbName_Post.Size = new System.Drawing.Size(35, 13);
            this.lbName_Post.TabIndex = 1;
            this.lbName_Post.Text = "Name";
            // 
            // lbTime_Post
            // 
            this.lbTime_Post.AutoSize = true;
            this.lbTime_Post.Location = new System.Drawing.Point(57, 40);
            this.lbTime_Post.Name = "lbTime_Post";
            this.lbTime_Post.Size = new System.Drawing.Size(99, 13);
            this.lbTime_Post.TabIndex = 2;
            this.lbTime_Post.Text = "hh:mm dd/mm/yyyy";
            // 
            // pnlInfor
            // 
            this.pnlInfor.Controls.Add(this.btbAvatar_Post);
            this.pnlInfor.Controls.Add(this.lbTime_Post);
            this.pnlInfor.Controls.Add(this.lbName_Post);
            this.pnlInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfor.Location = new System.Drawing.Point(0, 0);
            this.pnlInfor.Name = "pnlInfor";
            this.pnlInfor.Size = new System.Drawing.Size(699, 59);
            this.pnlInfor.TabIndex = 3;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lbContent_Post);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContent.Location = new System.Drawing.Point(0, 59);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(699, 114);
            this.pnlContent.TabIndex = 4;
            // 
            // pnlInter
            // 
            this.pnlInter.Controls.Add(this.ptbLike);
            this.pnlInter.Controls.Add(this.button1);
            this.pnlInter.Controls.Add(this.lbLiked_Post);
            this.pnlInter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInter.Location = new System.Drawing.Point(0, 174);
            this.pnlInter.Name = "pnlInter";
            this.pnlInter.Size = new System.Drawing.Size(699, 50);
            this.pnlInter.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(559, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "COMMENT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbLiked_Post
            // 
            this.lbLiked_Post.AutoSize = true;
            this.lbLiked_Post.Location = new System.Drawing.Point(51, 20);
            this.lbLiked_Post.Name = "lbLiked_Post";
            this.lbLiked_Post.Size = new System.Drawing.Size(88, 13);
            this.lbLiked_Post.TabIndex = 1;
            this.lbLiked_Post.Text = "1000 người thích";
            // 
            // ptbLike
            // 
            this.ptbLike.BackColor = System.Drawing.Color.Maroon;
            this.ptbLike.Location = new System.Drawing.Point(15, 15);
            this.ptbLike.Name = "ptbLike";
            this.ptbLike.Size = new System.Drawing.Size(25, 25);
            this.ptbLike.TabIndex = 0;
            this.ptbLike.TabStop = false;
            // 
            // lbContent_Post
            // 
            this.lbContent_Post.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbContent_Post.AutoSize = true;
            this.lbContent_Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent_Post.Location = new System.Drawing.Point(251, 42);
            this.lbContent_Post.Name = "lbContent_Post";
            this.lbContent_Post.Size = new System.Drawing.Size(127, 31);
            this.lbContent_Post.TabIndex = 0;
            this.lbContent_Post.Text = "Nội Dung";
            this.lbContent_Post.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pnlInter);
            this.panel1.Controls.Add(this.pnlContent);
            this.panel1.Controls.Add(this.pnlInfor);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 224);
            this.panel1.TabIndex = 6;
            // 
            // PostDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Name = "PostDisplay";
            this.Size = new System.Drawing.Size(707, 235);
            ((System.ComponentModel.ISupportInitialize)(this.btbAvatar_Post)).EndInit();
            this.pnlInfor.ResumeLayout(false);
            this.pnlInfor.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlInter.ResumeLayout(false);
            this.pnlInter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLike)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btbAvatar_Post;
        private System.Windows.Forms.Label lbName_Post;
        private System.Windows.Forms.Label lbTime_Post;
        private System.Windows.Forms.Panel pnlInfor;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlInter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbLiked_Post;
        private System.Windows.Forms.PictureBox ptbLike;
        private System.Windows.Forms.Label lbContent_Post;
        private System.Windows.Forms.Panel panel1;
    }
}
