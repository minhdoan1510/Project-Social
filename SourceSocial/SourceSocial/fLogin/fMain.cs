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
        BUS_Controls BUS_Controls;
        UCProfile DisplayProfile;
        public fMain(BUS_Controls _BUS_Controls)
        {
            InitializeComponent();
            BUS_Controls = _BUS_Controls;
            this.BackColor = Color.FromArgb(249, 249, 249);
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

        private void LoadDatafMain()
        {
            UCAddPost post = new UCAddPost();
            post.OnAddPost += Post_OnAddPost;
            pnlAddPost.Controls.Add(post);
            LoadNewFeed();
            LoadMainHeader();
        }

        private void LoadMainHeader()
        {
            UCMainHeader uCMainHeader = new UCMainHeader(BUS_Controls.Profilecurrent);
            uCMainHeader.OnOpenProfile += UCMainHeader_OnOpenProfile;
            uCMainHeader.OnOpenHome += () => pnlHome.Visible = true;
            this.pnlMainHeader.Controls.Add(uCMainHeader);
        }

        private void UCMainHeader_OnOpenProfile()
        {
            pnlHome.Visible = false;
            if(DisplayProfile != null)
            {
                DisplayProfile.Visible = true;
            }
            else
            {
                DisplayProfile = new UCProfile(BUS_Controls.Profilecurrent);
                DisplayProfile.Location = pnlHome.Location;
                this.Controls.Add(DisplayProfile);
            }
        }

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
                UCPostDisplay post = new UCPostDisplay(item.Name, item.Time, item.Content, item.Liked, item.Image);
                post.Dock = DockStyle.Top;
                post.Tag = item.Idpost;
                post.OnClickComment += Post_OnClickComment;
                pnlNewFeed_Main.Controls.Add(post);
            }
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

        private void BtnExit_Form_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
