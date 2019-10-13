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
    public partial class DisplayPost_Comment : Form
    {
        public DisplayPost_Comment(List<Comment> comments)
        {
            InitializeComponent();
            LoadComment(comments);
        }

        private void LoadComment(List<Comment> comments)
        {
            foreach (var item in comments)
            {
                CommentDisplay comment = new CommentDisplay(item.Name, item.Avatar, item.Content, item.Time);
                comment.Tag = item.IdComment;
                comment.Dock = DockStyle.Top;
                pnlDisplayPost_Comment.Controls.Add(comment);
            }
        }
    }
}
