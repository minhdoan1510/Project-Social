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
        int likeCount;
        DTO.Post Post;
        public delegate void ClickComment(string IDpost);
        public event ClickComment OnClickComment;

        public delegate bool ClickLike(string IDpost,bool add);
        public event ClickLike OnClickLike;

        public delegate void ClickLikeList(string IdPost);
        public event ClickLikeList OnClickLikeList;

        public delegate void ClickOpenProfile(string UID);
        public event ClickOpenProfile OnClickOpenProfile;

        public delegate void ClickLikeOutsideNewfeed(string IDpost);
        public event ClickLikeOutsideNewfeed OnClickLikeOutsideNewfeed;

        public Label LbName_Post { get => lbName_Post; set => lbName_Post = value; }
        public Label LbTime_Post { get => lbTime_Post; set => lbTime_Post = value; }
        public Label LbContent_Post { get => lbContent_Post; set => lbContent_Post = value; }
        public Label LbLiked_Post { get => lbLiked_Post; set => lbLiked_Post = value; }
        public PictureBox PtbAvatar_Post { get => ptbAvatar_Post; set => ptbAvatar_Post = value; }
        public int LikeCount { get => likeCount; set { likeCount = value; OnLikeCountChange(); }  }
        public PictureBox PtbLike { get => ptbLike; set => ptbLike = value; }
        public string Iduser { get => iduser; set => iduser = value; }        public bool Liked { get => (bool)PtbLike.Tag; set { PtbLike.Tag = value; OnLike(); } }

       

        public DTO.Post post
        {
            get => Post;
            set
            {
                Post = value;
                Iduser = Post.Iduser;
                LbName_Post.Text = Post.Name;
                LbTime_Post.Text = Post.Time;

                LbContent_Post.Text = Post.Content;

                PtbAvatar_Post.Image = Post.Image;
                LikeCount = Post.Liked;

            }
        }
        #endregion

        public UCPostDisplay(DTO.Post _post)
        {
            InitializeComponent();
            post = _post;
            LbName_Post.Click += LbName_Post_Click;

           
            PtbAvatar_Post.SizeMode = PictureBoxSizeMode.Zoom;

           

           
            PtbLike.SizeMode = PictureBoxSizeMode.Zoom;
            PtbLike.Click += PtbLike_Click;
            lbLiked_Post.Click += (sender,e)=> OnClickLikeList(this.Tag.ToString());
            btnComment_Post.Click += BtnComment_Post_Click;
            this.bunifuElipse1.ApplyElipse(30);

            LoadAnimation();
        }


        #region Handle_Event
        private void PtbLike_Click(object sender, EventArgs e)
        {
            if (OnClickLike(this.Tag.ToString(), !(bool)Liked))
            {
                LikeCount=(Liked.Equals(false))? LikeCount+1:LikeCount-1;
            
                Liked = !(bool)Liked;
                
                if (OnClickLikeOutsideNewfeed != null)
                    OnClickLikeOutsideNewfeed(this.Tag.ToString());
            }
            
            
        }

        private void OnLikeCountChange()
        {
            this.lbLiked_Post.Text = string.Format("{0} lượt thích", likeCount);
        }

        private void OnLike()
        {
            
            PtbLike.Image = (Liked == false)? Bitmap.FromFile(Application.StartupPath + @"\picture\Like.png"): Bitmap.FromFile(Application.StartupPath + @"\picture\Liked.png");
            
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
