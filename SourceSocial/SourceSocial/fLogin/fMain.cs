using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace fLogin
{
    public partial class fMain : Form
    {
        #region Propertion
        BUS_Controls BUS_Controls;
        UCProfile DisplayProfile;
        #endregion

        public fMain(BUS_Controls _BUS_Controls)
        {
            InitializeComponent();
            BUS_Controls = _BUS_Controls;
            this.BackColor = Color.FromArgb(249, 249, 249);
            this.btnExit_Form.Click += (s, e) => Close();
            LoadDatafMain();
            LoadAnimation();
        }

        #region Animation
        private void LoadAnimation()
        {
            //Exit change color
            //
            btnExit_Form.MouseEnter += BtnExit_Form_MouseEnter;
            btnExit_Form.MouseLeave += BtnExit_Form_MouseLeave;
            //
            //Text holder in my post

        }

        private void BtnExit_Form_MouseLeave(object sender, EventArgs e)
        {
            btnExit_Form.BackColor = pnlTitle.BackColor;
        }

        private void BtnExit_Form_MouseEnter(object sender, EventArgs e)
        {
            btnExit_Form.BackColor = Color.FromArgb(pnlTitle.BackColor.R + 20, pnlTitle.BackColor.G + 20, pnlTitle.BackColor.B + 20);
        }



        #endregion

        #region Load_MainDisplay
        private void LoadDatafMain()
        {
            UCAddPost post = new UCAddPost();
            post.OnAddPost += Post_OnAddPost;
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
            UCMainHeader uCMainHeader = new UCMainHeader(BUS_Controls.Profilecurrent);
            uCMainHeader.OnOpenProfile += OnOpenProfile;

            uCMainHeader.OnOpenHome += () =>
            {
                this.Controls.Remove(DisplayProfile);
                pnlHome.Visible = true;
            };
            this.pnlMainHeader.Controls.Add(uCMainHeader);
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
                UCPostDisplay post = new UCPostDisplay(item.Name, item.Time, item.Content, item.Liked, item.Image, item.Iduser);
                post.Dock = DockStyle.Top;
                post.Tag = item.Idpost;
                post.OnClickComment += Post_OnClickComment;
                post.OnClickOpenProfile += OnOpenProfile;
                pnlNewFeed_Main.Controls.Add(post);
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

        private void Post_OnClickComment(string IDPost)
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
            DisplayProfile = new UCProfile(BUS_Controls.GetProfile(UID), BUS_Controls.IsFriendWith(UID));
            pnlHome.Visible = false;
            DisplayProfile.Location = pnlHome.Location;
            this.Controls.Add(DisplayProfile);
            DisplayProfile.Tag = UID;
            DisplayProfile.OnChangeAvatar += (i) => BUS_Controls.ChangeAvatar(i);
            DisplayProfile.OnAddFriend += (i) => BUS_Controls.AddFriend(i);
            DisplayProfile.OnDelFriend += (i) => BUS_Controls.DelFriend(i);
            DisplayProfile.Visible = true;
            

        }



        #endregion
    }
}
