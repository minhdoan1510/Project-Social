using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;

namespace fLogin
{
    public partial class fDisplayPost_Comment : Form
    {
        public delegate List<Comment> OnAddComment_Display(string idPost, string content);
        public event OnAddComment_Display OnAddComment;
        public fDisplayPost_Comment(List<Comment> comments)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            ptbExitCommentDisplay.Image = Bitmap.FromFile(Application.StartupPath + @"\Picture\Exit.png");
            ptbExitCommentDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            ptbExitCommentDisplay.Click += PtbExitCommentDisplay_Click;
            UCAddComment addComment = new UCAddComment();
            addComment.OnSendComment += AddComment_OnSendComment;

            pnlDisplayPost_Comment.AutoScroll = false;
            pnlDisplayPost_Comment.HorizontalScroll.Maximum = 0;
            pnlDisplayPost_Comment.HorizontalScroll.Visible = false;
            pnlDisplayPost_Comment.VerticalScroll.Maximum = 0;
            pnlDisplayPost_Comment.VerticalScroll.Visible = false;
            pnlDisplayPost_Comment.AutoScroll = true;

            pnlAddComment.Controls.Add(addComment);
            LoadComment(comments);
        }

        private void AddComment_OnSendComment(string content)
        {
            try
            {
                List<Comment> comments = OnAddComment(this.Tag.ToString(), content);
                if (comments != null)
                {
                    LoadComment(comments);
                    return;
                }
                MessageBox.Show("Lỗi không xác định!!!");
            }
            catch
            {
                MessageBox.Show("Lỗi không xác định!!!");
            }
        }

        private void PtbExitCommentDisplay_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadComment(List<Comment> comments)
        {
            pnlDisplayPost_Comment.Controls.Clear();
            foreach (var item in comments)
            {
                UCCommentDisplay comment = new UCCommentDisplay(item.Name, item.Avatar, item.Content, item.Time);
                comment.Tag = item.IdComment;
                comment.Dock = DockStyle.Top;
                pnlDisplayPost_Comment.Controls.Add(comment);
            }
        }
    }
}
