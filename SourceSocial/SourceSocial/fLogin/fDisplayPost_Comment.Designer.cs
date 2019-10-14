namespace fLogin
{
    partial class fDisplayPost_Comment
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
            this.pnlDisplayPost_Comment = new System.Windows.Forms.Panel();
            this.ptbExitCommentDisplay = new System.Windows.Forms.PictureBox();
            this.pnlAddComment = new System.Windows.Forms.Panel();
            this.pnlMainCommentDisplay = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExitCommentDisplay)).BeginInit();
            this.pnlMainCommentDisplay.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDisplayPost_Comment
            // 
            this.pnlDisplayPost_Comment.AutoScroll = true;
            this.pnlDisplayPost_Comment.AutoSize = true;
            this.pnlDisplayPost_Comment.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDisplayPost_Comment.Location = new System.Drawing.Point(0, 48);
            this.pnlDisplayPost_Comment.MaximumSize = new System.Drawing.Size(645, 300);
            this.pnlDisplayPost_Comment.Name = "pnlDisplayPost_Comment";
            this.pnlDisplayPost_Comment.Size = new System.Drawing.Size(645, 0);
            this.pnlDisplayPost_Comment.TabIndex = 0;
            // 
            // ptbExitCommentDisplay
            // 
            this.ptbExitCommentDisplay.BackColor = System.Drawing.Color.Transparent;
            this.ptbExitCommentDisplay.Location = new System.Drawing.Point(643, 3);
            this.ptbExitCommentDisplay.Name = "ptbExitCommentDisplay";
            this.ptbExitCommentDisplay.Size = new System.Drawing.Size(27, 27);
            this.ptbExitCommentDisplay.TabIndex = 1;
            this.ptbExitCommentDisplay.TabStop = false;
            // 
            // pnlAddComment
            // 
            this.pnlAddComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddComment.Location = new System.Drawing.Point(0, 0);
            this.pnlAddComment.MaximumSize = new System.Drawing.Size(645, 1000);
            this.pnlAddComment.Name = "pnlAddComment";
            this.pnlAddComment.Size = new System.Drawing.Size(645, 48);
            this.pnlAddComment.TabIndex = 2;
            // 
            // pnlMainCommentDisplay
            // 
            this.pnlMainCommentDisplay.AutoSize = true;
            this.pnlMainCommentDisplay.Controls.Add(this.pnlDisplayPost_Comment);
            this.pnlMainCommentDisplay.Controls.Add(this.pnlAddComment);
            this.pnlMainCommentDisplay.Location = new System.Drawing.Point(13, 33);
            this.pnlMainCommentDisplay.Name = "pnlMainCommentDisplay";
            this.pnlMainCommentDisplay.Size = new System.Drawing.Size(645, 48);
            this.pnlMainCommentDisplay.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlMainCommentDisplay);
            this.panel1.Controls.Add(this.ptbExitCommentDisplay);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(675, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 88);
            this.panel1.TabIndex = 6;
            // 
            // fDisplayPost_Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(675, 88);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(675, 500);
            this.Name = "fDisplayPost_Comment";
            this.Text = "DisplayPost_Comment";
            ((System.ComponentModel.ISupportInitialize)(this.ptbExitCommentDisplay)).EndInit();
            this.pnlMainCommentDisplay.ResumeLayout(false);
            this.pnlMainCommentDisplay.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplayPost_Comment;
        private System.Windows.Forms.PictureBox ptbExitCommentDisplay;
        private System.Windows.Forms.Panel pnlAddComment;
        private System.Windows.Forms.Panel pnlMainCommentDisplay;
        private System.Windows.Forms.Panel panel1;
    }
}