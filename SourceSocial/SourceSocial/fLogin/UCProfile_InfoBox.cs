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
using System.Threading;

namespace fLogin
{
    public partial class UCProfile_InfoBox : UserControl
    {
        #region Propertion
        private int IsFriend;
        public delegate bool ChangeAvatar(Image image);
        public event ChangeAvatar OnChangeAvatar;

        public delegate bool AddFriend();
        public event AddFriend OnAddFriend;

        public delegate bool DelFriend();
        public event DelFriend OnDelFriend;

        public PictureBox PtbAvatar { get => ptbAvatar; set => ptbAvatar = value; }
        public Label LbName { get => lbName; set => lbName = value; }
        public Button BtnAddFriend { get => btnAddFriend; set => btnAddFriend = value; }
        public Button BtnMessenger { get => btnMessenger; set => btnMessenger = value; }
        #endregion
        public UCProfile_InfoBox(Profile _profile,int isFriend)// 0 - NotFriend | 1 - Friend | 2 - CurrentUser
        {
            InitializeComponent();
            PtbAvatar.Image = (_profile.Avatar != null) ? _profile.Avatar : Bitmap.FromFile(Application.StartupPath + @"\Picture\NoAvatar.png");
            PtbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
           
            LbName.Text = _profile.Name;
            IsFriend = isFriend;
            UpdateTypeProfile();
            CheckForIllegalCrossThreadCalls = false;
        }
        #region Handle_Event
        private void BtnAddFriend_ClickDelFriend(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn huỷ kết bạn không", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (OnDelFriend())
                {
                    IsFriend = 0;
                    UpdateTypeProfile();
                    MessageBox.Show("Huỷ Thành Công");
                }
                else
                    MessageBox.Show("Huỷ Thất bại");
            }
        }
        private void BtnAddFriend_ClickAddFriend(object sender, EventArgs e)
        {
            if (OnAddFriend())
            {
                IsFriend = 1;
                UpdateTypeProfile();
                MessageBox.Show("Kết Bạn Thành Công");
            }
            else
                MessageBox.Show("Kết bạn Thất bại");
        }

        private void PtbAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Image bitmap = Bitmap.FromFile(openFile.FileName);

                //Form loadding = new Form() { FormBorderStyle = FormBorderStyle.None, Size = new Size(100, 300), StartPosition = FormStartPosition.CenterScreen };
                //TextBox textBox = new TextBox() { Text = "Loadding....", Dock = DockStyle.Fill, TextAlign = HorizontalAlignment.Center };
                //loadding.Controls.Add(textBox);

                //Thread thread = new Thread(() =>
                //{
                //    CheckForIllegalCrossThreadCalls = false;
                //    if (OnChangeAvatar(bitmap))
                //    {
                //        loadding.Dispose();
                //        PtbAvatar.Image = bitmap;
                //        MessageBox.Show("Đổi avatar thành công");
                //    }
                //    else
                //    {
                //        loadding.Dispose();
                //        MessageBox.Show("Đổi avatar không thành công");
                //    }
                //    CheckForIllegalCrossThreadCalls = true;

                //});
                //thread.Start();
                //loadding.ShowDialog();

                if (OnChangeAvatar(bitmap))
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
        #endregion

        #region Handle_Other
        private void UpdateTypeProfile()
        {
            if (IsFriend == 2)
            {
                BtnAddFriend.Visible = false;
                BtnMessenger.Visible = false;
                PtbAvatar.Click += PtbAvatar_Click;
            }
            else if (IsFriend == 1)
            {
                BtnAddFriend.Text = "Huỷ kết bạn";
                BtnAddFriend.Visible = true;
                BtnMessenger.Visible = true;
                try
                {
                    BtnAddFriend.Click -= BtnAddFriend_ClickAddFriend;
                }
                catch
                {

                }
                BtnAddFriend.Click += BtnAddFriend_ClickDelFriend;
            }
            else
            {
                BtnAddFriend.Text = "Kết bạn";
                BtnAddFriend.Visible = true;
                BtnMessenger.Visible = false;
                try
                {
                    BtnAddFriend.Click -= BtnAddFriend_ClickDelFriend;
                }
                catch
                {

                }
                BtnAddFriend.Click += BtnAddFriend_ClickAddFriend;
            }
        }
        #endregion
    }
}
