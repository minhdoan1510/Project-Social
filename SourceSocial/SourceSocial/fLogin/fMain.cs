using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace fLogin
{
    public partial class fMain : Form
    {
        BUS_Controls BUS_Controls;
        public fMain(BUS_Controls _BUS_Controls)
        {
            InitializeComponent();
            BUS_Controls = _BUS_Controls;
            LoadDatafMain();
        }
        private void LoadDatafMain()
        {
            AddPost post = new AddPost();
            post.OnAddPost += Post_OnAddPost;
            pnlAddPost.Controls.Add(post);
            LoadNewFeed();

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
            pnlNewFeed_Main.Controls.Clear();
            List<Post> posts = BUS_Controls.GetPost();
            foreach (var item in posts)
            {
                PostDisplay post = new PostDisplay(item.Name, item.Time, item.Content, item.Liked, item.Image);
                post.Dock = DockStyle.Top;
                pnlNewFeed_Main.Controls.Add(post);
            }
        }

        private void BtnExit_Form_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
