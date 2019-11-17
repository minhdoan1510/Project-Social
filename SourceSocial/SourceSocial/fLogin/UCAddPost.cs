using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace fLogin
{
    public partial class UCAddPost : UserControl
    {
        #region Propertion
        public delegate void Getstring(string str);
        public event Getstring OnAddPost;

        public RichTextBox RtbContent_Main { get => rtbContent_Main; }
        public Button BtnAddPost_Main { get => btnAddPost_Main; set => btnAddPost_Main = value; }
        #endregion

        public UCAddPost()
        {
            InitializeComponent();
            LoadAnimation();
        }

        #region Handle_Event
        private void BtnAddPost_Main_Click(object sender, EventArgs e)
        {
            if (new Regex(@"\S").Match(RtbContent_Main.Text).Success)
                if (OnAddPost != null)
                    OnAddPost(RtbContent_Main.Text);
        }

        #endregion

        #region Animation
        private void LoadAnimation()
        {
            //Text placeholder in my post
            string placeholder = "Bạn đang nghĩ gì???";
            rtbContent_Main.SelectionAlignment = HorizontalAlignment.Center;
            rtbContent_Main.Text = placeholder;
            rtbContent_Main.ForeColor = Color.FromArgb(138, 138, 138);
            rtbContent_Main.GotFocus += (s,e) =>
            {
                if (rtbContent_Main.Text == placeholder)
                {
                    rtbContent_Main.Text = "";
                    rtbContent_Main.ForeColor = Color.FromArgb(28, 28, 28);
                }
            };
            rtbContent_Main.LostFocus += (s,e)=> 
            {
                if (string.IsNullOrWhiteSpace(rtbContent_Main.Text))
                {
                    rtbContent_Main.SelectionAlignment = HorizontalAlignment.Center;
                    rtbContent_Main.ForeColor = Color.FromArgb(138, 138, 138);
                    rtbContent_Main.Text = placeholder;
                }
            };
            //rTextbox format center text

        }
        #endregion
    }
}
