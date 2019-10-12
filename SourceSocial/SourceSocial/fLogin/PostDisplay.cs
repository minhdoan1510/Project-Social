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
    public partial class PostDisplay : UserControl
    {
        public PostDisplay(string _name, string _time, string _content, int _liked, Bitmap avatar)
        {
            InitializeComponent();
            LbName_Post.Text = _name;
            LbTime_Post.Text = _time;
            LbContent_Post.Text = _content;
            LbLiked_Post.Text = _liked.ToString() + "lượt thích";
            ptbLike.Image = Bitmap.FromFile(Application.StartupPath + @"\picture\Like.png");
        }
        public Label LbName_Post { get => lbName_Post; set => lbName_Post = value; }
        public Label LbTime_Post { get => lbTime_Post; set => lbTime_Post = value; }
        public Label LbContent_Post { get => lbContent_Post; set => lbContent_Post = value; }
        public Label LbLiked_Post { get => lbLiked_Post; set => lbLiked_Post = value; }
        public PictureBox PtbAvatar_Post { get => PtbAvatar_Post; set => PtbAvatar_Post = value; }
    }
}
