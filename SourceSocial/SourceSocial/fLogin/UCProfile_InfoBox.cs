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
using System.IO;

namespace fLogin
{
    public partial class UCProfile_InfoBox : UserControl
    {
        public delegate bool ChangeAvatar(Image image);
        public event ChangeAvatar OnChangeAvatar;

        public delegate bool AddFriend();
        public event AddFriend OnAddFriend;

        public UCProfile_InfoBox(Profile _profile)
        {
            InitializeComponent();
            PtbAvatar.Image = (_profile.Avatar != null) ? _profile.Avatar : Bitmap.FromFile(Application.StartupPath + @"\Picture\NoAvatar.png");
            PtbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            PtbAvatar.Click += PtbAvatar_Click;
            LbName.Text = _profile.Name;
        }

        private void PtbAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Image bitmap = Bitmap.FromFile(openFile.FileName);
                if (OnChangeAvatar(bitmap))

                //Test
                //


                //if (true)
                {
                    PtbAvatar.Image = bitmap;
                    MessageBox.Show("Đổi avatar thành công");
                }
                else
                {
                    MessageBox.Show("Đổi avatar không thành công");
                }
            }
        }

        public PictureBox PtbAvatar { get=>ptbAvatar; set => ptbAvatar = value; }
        public Label LbName { get=>lbName; set=>lbName = value; }

        private void Button1_Click(object sender, EventArgs e)
        {
            OnAddFriend();
        }
    }
}
