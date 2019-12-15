using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
namespace fLogin
{
    public partial class fMain : MaterialForm
    {
        #region Propertion
        BUS_Controls BUS_Controls;
        UCProfile DisplayProfile;
        Form formMess;        NotificationList formNotify;
        NotificationBox notification;
        #endregion

        public fMain(BUS_Controls _BUS_Controls)
        {
            InitializeComponent();


            BUS_Controls = _BUS_Controls;
            this.BackColor = Color.FromArgb(249, 249, 249);

            BUS_Controls.HaveNewMesseger += BUS_Controls_HaveNewMesseger;
            BUS_Controls.HaveNewNotify += BUS_Controls_HaveNewNotify;

            LoadDatafMain();
            LoadAnimation();


        }
        private void BUS_Controls_HaveNewNotify(Notify notify)
        {
            notification = new NotificationBox(notify,BUS_Controls.Profilecurrent.Uid);
            notification.StartPosition = FormStartPosition.CenterParent;
            notification.ShowDialog();   

        }


        private void BUS_Controls_HaveNewMesseger(MessinMessbox messin)
        {
            foreach (UCMessengerDisplay item in formMess.Controls)
            {
                try
                {
                    item.AddMess(messin);
                }
                catch { }
            }
        }


        #region Animation
        private void LoadAnimation()
        {
            //Exit change color
            //
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.BLACK);

            //
            //Text holder in my post

        }





        #endregion

        #region Load_MainDisplay
        private void LoadDatafMain()
        {
            UCAddPost post = new UCAddPost();
            post.OnAddPost += Post_OnAddPost;
            post.OnAddPost +=(i)=> post.LoadAnimation();
            pnlAddPost.Controls.Add(post);
            LoadNewFeed();
            LoadMainHeader();
            LoadCatalog();
        }


        private void LoadCatalog()
        {
            UCCatalog uCCatalog = new UCCatalog(BUS_Controls.GetPeople());
            uCCatalog.OnSelectionUser += (i) => OnOpenProfile(i);
            this.pnlCatalog.Controls.Add(uCCatalog);
        }

        private void LoadMainHeader()
        {
            UCMainHeader uCMainHeader = new UCMainHeader(BUS_Controls.Profilecurrent, BUS_Controls.GetPeople());
            uCMainHeader.OnOpenProfile += OnOpenProfile;
            uCMainHeader.OnOpenNotify += () =>
            {
                formNotify = new NotificationList(BUS_Controls.GetAllNotifyofUser(), BUS_Controls.Profilecurrent.Uid) { StartPosition = FormStartPosition.Manual, FormBorderStyle = FormBorderStyle.None };
                formNotify.SetDesktopLocation(MousePosition.X, MousePosition.Y);           
                formNotify.ShowDialog();

            };
            uCMainHeader.OnOpenHome += () =>
            {
                if (DisplayProfile != null)
                {
                    this.Controls.Remove(DisplayProfile);
                    DisplayProfile.Dispose();
                    
                  
                    pnlHome.Visible = true;
                }
            };


            uCMainHeader.OnOpenMessenger += () =>
            {
                formMess = new MaterialForm() { Size = new Size(256, 364 + 28), StartPosition = FormStartPosition.CenterScreen ,Sizable = false};
                UCMessengerDisplay uCMessengerDisplay = new UCMessengerDisplay(BUS_Controls.GetMailboxlist());
                uCMessengerDisplay.GetMailboxlist += UCMessengerDisplay_GetMailboxlist;
                uCMessengerDisplay.GetMessinMessbox += UCMessengerDisplay_GetMessinMessbox;
                uCMessengerDisplay.SendMessCurrent += (i, j, uidsend) => BUS_Controls.SendMess(i, j, uidsend);

                uCMessengerDisplay.Location = new Point(0, 25);

                formMess.Controls.Add(uCMessengerDisplay);
                formMess.ShowDialog();
            };


            this.pnlMainHeader.Controls.Add(uCMainHeader);
        }
        private object UCMessengerDisplay_GetMessinMessbox(string id)
        {
            return BUS_Controls.GetMessinMessbox(id);
        }

        private object UCMessengerDisplay_GetMailboxlist()
        {
            return BUS_Controls.GetMailboxlist();
        }


        private void LoadNewFeed()
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
                if (BUS_Controls.ListFriend.Contains(item.Iduser) || item.Iduser == BUS_Controls.Profilecurrent.Uid)
                {
                    UCPostDisplay post = new UCPostDisplay(item.Name, item.Time, item.Content, item.Liked, item.Image, item.Iduser);

                    post.Dock = DockStyle.Top;
                    post.Tag = item.Idpost;
                    post.OnClickComment += Post_OnClickComment;
                    post.OnClickOpenProfile += OnOpenProfile;
                    post.OnClickLike += (iDPost, add) => BUS_Controls.AddLike_Post(iDPost, add);
                    post.OnClickLikeList += (i)=> ShowUserList(BUS_Controls.LoadLikesOfPost(i));
                    if (BUS_Controls.LoadLikesOfPost(item.Idpost).Contains(BUS_Controls.Profilecurrent.Uid))
                        post.PtbLike.Tag = true;
                    else post.PtbLike.Tag = false;
                    this.pnlNewFeed_Main.Controls.Add(post);
                }
            }
        }



        #region Handle_Event_MainDisplay

        private void Post_OnAddPost(string str)
        {
            if (BUS_Controls.AddPost(new Post() { Content = str }))
            {
                MessageBox.Show("Đã Đăng!!!");
                LoadNewFeed();
            }
            else
                MessageBox.Show("Không thành công!!!");
        }

        public void ShowUserList(List<string> UserList)
        {
            if (UserList.Count == 0) return;
            Form l = new Form();
            l.AutoScroll = true;
            l.Size = new Size(350, 500);
            foreach(var item in UserList)
            {
                UCProfile_InfoBox tempInfo = new UCProfile_InfoBox(BUS_Controls,BUS_Controls.GetProfile(item), BUS_Controls.IsFriendWith(item));
                tempInfo.Dock = DockStyle.Top;
                tempInfo.LbNumFriend.Visible = false;
                tempInfo.OnDelFriend +=()=> BUS_Controls.DelFriend(BUS_Controls.GetProfile(item).Uid);
                l.Controls.Add(tempInfo);
            }
            l.Show();

        }
        public void Post_OnClickComment(string IDPost)
        {

            fDisplayPost_Comment displayPost_Comment = new fDisplayPost_Comment(BUS_Controls.LoadCMTof(IDPost));
            displayPost_Comment.Tag = IDPost;
            displayPost_Comment.OnAddComment += DisplayPost_Comment_OnAddComment;
            displayPost_Comment.ShowDialog();
            this.Enabled = true;
        }
        private List<Comment> DisplayPost_Comment_OnAddComment(string idPost, string content)
        {
            return BUS_Controls.AddComment(idPost, content);
        }
       
    
       
        #endregion

        #endregion

        #region UC_Profile
        private void OnOpenProfile(string UID)
        {
            DisplayProfile = new UCProfile(BUS_Controls, BUS_Controls.GetProfile(UID), BUS_Controls.IsFriendWith(UID));
            pnlHome.Visible = false;
            DisplayProfile.Location = pnlHome.Location;
            this.Controls.Add(DisplayProfile);
            DisplayProfile.Tag = UID;
            DisplayProfile.OnChangeAvatar += DisplayProfile_OnChangeAvatar;
            DisplayProfile.OnAddFriend += (i) => BUS_Controls.AddFriend(i);
            DisplayProfile.OnDelFriend += (i) => BUS_Controls.DelFriend(i);
            DisplayProfile.OnAddPost += (i) => Post_OnAddPost(i);
            DisplayProfile.OnViewFriend += (i) => ShowUserList(BUS_Controls.GetListFriend(i));
            DisplayProfile.Post_OnClickComment += (i) => Post_OnClickComment(i);
            DisplayProfile.OnClickLike += (iDPost, add) => BUS_Controls.AddLike_Post(iDPost, add);
            DisplayProfile.OnClickLikeList += (i) => ShowUserList(BUS_Controls.LoadLikesOfPost(i));
            DisplayProfile.Visible = true;
         

        }

        private bool DisplayProfile_OnChangeAvatar(Image i)
        {
            if (BUS_Controls.ChangeAvatar(i))
            {
                foreach (UCPostDisplay item in pnlNewFeed_Main.Controls)
                {
                    if (item.Iduser.Equals(BUS_Controls.Profilecurrent.Uid))
                        item.PtbAvatar_Post.Image = i;
                }
                return true;
            }
            return false;
        }



        #endregion
    }
}
