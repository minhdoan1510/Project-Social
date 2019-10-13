using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fLogin
{
    public partial class CommentDisplay : UserControl
    {
        public CommentDisplay(string name, Bitmap avatar, string content, string time)
        {
            InitializeComponent();
            LbName.Text = name;
            LbContent.Text = content;
            LbTime.Text = time;
            PtbAvatar.Image = avatar;
        }
        public Label LbName { get => lbName; set => lbName = value; }
        public Label LbContent { get => lbContent; set => lbContent = value; }
        public Label LbTime { get => lbTime; set => lbTime = value; }
        public PictureBox PtbAvatar { get => ptbAvatar; set => ptbAvatar = value; }
    }
}
