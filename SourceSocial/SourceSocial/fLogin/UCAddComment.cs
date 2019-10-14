using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace fLogin
{
    public partial class UCAddComment : UserControl
    {
        public delegate void SendCommment(string content);
        public event SendCommment OnSendComment;
        public UCAddComment()
        {
            InitializeComponent();
            PtbSendComment.Image = Bitmap.FromFile(Application.StartupPath + @"/Picture/SendComment.png");
            PtbSendComment.SizeMode = PictureBoxSizeMode.Zoom;
            PtbSendComment.Click += PtbSendComment_Click;
            TxbContentComment.KeyDown += TxbContentComment_KeyDown;
        }

        private void TxbContentComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (new Regex(@"\S").Match(TxbContentComment.Text).Success)
                    OnSendComment(TxbContentComment.Text);
                txbContentComment.Text = "";
            }
        }
        private void PtbSendComment_Click(object sender, EventArgs e)
        {
            if (new Regex(@"\S").Match(TxbContentComment.Text).Success)
                OnSendComment(TxbContentComment.Text);
            txbContentComment.Text = "";
        }
        public TextBox TxbContentComment { get => txbContentComment; set => txbContentComment = value; }
        public PictureBox PtbSendComment { get => ptbSendComment; set => ptbSendComment = value; }
    }
}
