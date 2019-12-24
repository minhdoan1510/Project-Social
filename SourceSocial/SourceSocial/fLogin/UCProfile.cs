using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Threading;

namespace fLogin
{
    public partial class UCProfile : UserControl
    {
        BUS_Controls BUS_Controls;

        public UCProfile_InfoBox uCProfile_InfoBox;
        public delegate bool ChangeAvatar(Image image);
        public event ChangeAvatar OnChangeAvatar;

        public delegate bool ChangeProfile(Profile profile);
        public event ChangeProfile OnChangeProfile;

        public delegate bool AddFriend(string uid);
        public event AddFriend OnAddFriend;

        public delegate bool DelFriend(string uid);
        public event DelFriend OnDelFriend;

        public delegate void ViewFriend(string uid);
        public event ViewFriend OnViewFriend;

        public delegate void AddPost(string content);
        public event AddPost OnAddPost;

        public delegate void ClickComment(string UID);
        public event ClickComment Post_OnClickComment;

        public delegate void Inbox(string IdMessbox, string Username, string IdUser);
        public event Inbox OnInbox;

        public delegate void ClickLikeList(string IdPost);
        public event ClickLikeList OnClickLikeList;

        public delegate void ClickLikeOutsideNewfeed(string IDpost);
        public event ClickLikeOutsideNewfeed OnClickLikeOutsideNewfeed;



        public UCProfile(BUS_Controls _BUS_Controls, Profile profile, int isFriend)// 0 - NotFriend | 1 - Friend | 2 - CurrentUser
        {
            BUS_Controls = _BUS_Controls;
            InitializeComponent();
            LoadWallNewFeed(profile.Uid);
            LoadDisplay(profile, isFriend);


            OnAddPost += (i) => LoadWallNewFeed(profile.Uid);
            OnAddPost += (i) => LoadDisplay(profile, isFriend);
        }

        private void LoadWallNewFeed(string UID)
        {
            pnlMain_Newfeed_AddPost.AutoScroll = false;
            pnlMain_Newfeed_AddPost.HorizontalScroll.Maximum = 0;
            pnlMain_Newfeed_AddPost.HorizontalScroll.Visible = false;
            pnlMain_Newfeed_AddPost.VerticalScroll.Maximum = 0;
            pnlMain_Newfeed_AddPost.VerticalScroll.Visible = false;
            pnlMain_Newfeed_AddPost.AutoScroll = true;

            pnlNewFeed_Main.Controls.Clear();
            List<Post> posts = BUS_Controls.GetPost();
            foreach (var item in posts)
            {
                if (item.Iduser == UID)
                {
                    UCPostDisplay post = new UCPostDisplay(item);
                    post.Dock = DockStyle.Top;
                    post.Tag = item.Idpost;

                    post.OnClickComment += (i) => Post_OnClickComment(i);
                    post.OnClickLike += (iDPost, add) => BUS_Controls.AddLike_Post(iDPost, add);
                    post.OnClickLikeList += (i) => OnClickLikeList(i);
                    post.OnClickLikeOutsideNewfeed += (i) => OnClickLikeOutsideNewfeed(i);
                    if (BUS_Controls.LoadLikesOfPost(item.Idpost).Contains(BUS_Controls.Profilecurrent.Uid))

                        post.Liked = true;

                    else post.Liked = false;
                    pnlNewFeed_Main.Controls.Add(post);
                }
            }
        }

        private void LoadDisplay(Profile profile, int isFriend)
        {
            //add ProfileControl
            UCProfile_InfoBox uCProfile_InfoBox = new UCProfile_InfoBox(BUS_Controls, profile, isFriend);
            pnlProfile_Infor.Controls.Add(uCProfile_InfoBox);
            uCProfile_InfoBox.OnChangeAvatar += (i) => OnChangeAvatar(i);
            uCProfile_InfoBox.OnAddFriend += () => OnAddFriend(this.Tag.ToString());
            uCProfile_InfoBox.OnDelFriend += () => OnDelFriend(this.Tag.ToString());
            uCProfile_InfoBox.OnViewFriend += (i) => OnViewFriend(i);
            uCProfile_InfoBox.LbNumFriend.Text = string.Format("{0} bạn", BUS_Controls.numOfFriend(profile.Uid));
            uCProfile_InfoBox.OnInbox += (IdMessBox, Username, IdUser) => OnInbox(IdMessBox, Username, IdUser);
            uCProfile_InfoBox.OnChangeProfile += (i) => OnChangeProfile(i);
            //
            //add UCaddPost
            if (isFriend == 2)
            {

                UCAddPost uCAddPost = new UCAddPost();
                uCAddPost.OnAddPost += (content) => OnAddPost(content);
                uCAddPost.Dock = DockStyle.Top;
                this.pnlNewFeed_Main.Controls.Add(uCAddPost);
            }
            //
            //
        }

    }
}
