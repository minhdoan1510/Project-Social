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
    public partial class AddPost : UserControl
    {
        public delegate void Getstring(string str);
        public event Getstring OnAddPost;
        public AddPost()
        {
            InitializeComponent();
        }
        public RichTextBox RtbContent_Main { get => rtbContent_Main; }
        public Button BtnAddPost_Main { get => btnAddPost_Main; set => btnAddPost_Main = value; }

        private void BtnAddPost_Main_Click(object sender, EventArgs e)
        {
            if (OnAddPost != null)
                OnAddPost(RtbContent_Main.Text);
        }
    }
}
