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
    public partial class UCPostDisplay : UserControl
    {
        #region Propertion
        string iduser;

        public delegate void ClickComment(string IDpost);
        public event ClickComment OnClickComment;

        public delegate void ClickLike(string IDpost, string IDuser);
        public event ClickLike OnClickLike;

        public delegate void ClickOpenProfile(string UID);
        public event ClickOpenProfile OnClickOpenProfile;


        public Label LbName_Post { get => lbName_Post; set => lbName_Post = value; }
        public Label LbTime_Post { get => lbTime_Post; set => lbTime_Post = value; }
        public Label LbContent_Post { get => lbContent_Post; set => lbContent_Post = value; }
        public Label LbLiked_Post { get => lbLiked_Post; set => lbLiked_Post = value; }
        public PictureBox PtbAvatar_Post { get => ptbAvatar_Post; set => ptbAvatar_Post = value; }
        public PictureBox PtbLike { get => ptbLike; set => ptbLike = value; }
        public string Iduser { get => iduser; set => iduser = value; }
        #endregion

        public UCPostDisplay(string _name, string _time, string _content, int _liked, Image avatar, string _iduser)
        {
            InitializeComponent();
            Iduser = _iduser;

            LbName_Post.Text = _name;
            LbName_Post.Click += LbName_Post_Click;

            LbTime_Post.Text = _time;

            LbContent_Post.Text = _content;

            PtbAvatar_Post.Image = avatar;
            PtbAvatar_Post.SizeMode = PictureBoxSizeMode.Zoom;

            LbLiked_Post.Text = _liked.ToString() + " lượt thích";

            PtbLike.Image = Bitmap.FromFile(Application.StartupPath + @"\picture\Like.png");
            PtbLike.SizeMode = PictureBoxSizeMode.Zoom;
            PtbLike.Click += PtbLike_Click;

            btnComment_Post.Click += BtnComment_Post_Click;


            LoadAnimation();
        }


        #region Handle_Event
        private void PtbLike_Click(object sender, EventArgs e)
        {

        }

        private void LbName_Post_Click(object sender, EventArgs e)
        {
            if (OnClickOpenProfile != null)
                OnClickOpenProfile(Iduser);
        }

        private void BtnComment_Post_Click(object sender, EventArgs e)
        {
            if (OnClickComment != null)
                OnClickComment(this.Tag.ToString());
        }
        #endregion

        #region Animation


        void LoadAnimation()
        {
            //Set Color when enter Label Name 
            LbName_Post.MouseEnter += (s, e) => LbName_Post.ForeColor = Color.Red;
            LbName_Post.MouseLeave += (s, e) => LbName_Post.ForeColor = Color.Black;


        }


        #endregion
    }
}
