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

        public delegate void ViewFriend(string uid);
        public event ViewFriend OnViewFriend;

        public delegate void Inbox(string IdMessbox,string Username, string IdUser);
        public event Inbox OnInbox;


        public PictureBox PtbAvatar { get => ptbAvatar; set => ptbAvatar = value; }
        public Label LbName { get => lbName; set => lbName = value; }
        public Label LbNumFriend { get => lbFriend_Count; set => lbFriend_Count = value; }
        public Bunifu.Framework.UI.BunifuFlatButton BtnAddFriend { get => btnAddFriend; set => btnAddFriend = value; }
        public Bunifu.Framework.UI.BunifuFlatButton BtnMessenger { get => btnMessenger; set => btnMessenger = value; }
        public ProfileDetails profileDetails;
        #endregion
        public UCProfile_InfoBox(BUS.BUS_Controls bUS_Controls,Profile _profile,int isFriend)// 0 - NotFriend | 1 - Friend | 2 - CurrentUser
        {
            InitializeComponent();
            PtbAvatar.Image = (_profile.Avatar != null) ? _profile.Avatar : Bitmap.FromFile(Application.StartupPath + @"\Picture\NoAvatar.png");
            PtbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMessenger.Iconimage = Bitmap.FromFile(Application.StartupPath + @"\Picture\messWhite.png");
            lbName.Click += (i, e) =>
            {
                profileDetails = new ProfileDetails(bUS_Controls, _profile);
                profileDetails.OnChangeAvatar += (image) => OnChangeAvatar(image);
                profileDetails.Show();
            };
            LbName.Text = _profile.Name;
            IsFriend = isFriend;
            UpdateTypeProfile();
            lbFriend_Count.Click += (i,e)=>OnViewFriend(_profile.Uid);
            btnMessenger.Click += (i, e) =>
            {

                OnInbox(bUS_Controls.GetIdMessbox(bUS_Controls.Profilecurrent.Uid,_profile.Uid),_profile.Name,_profile.Uid);

            };
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


        #endregion

        #region Handle_Other
        private void UpdateTypeProfile()
        {
            if (IsFriend == 2)
            {
                BtnAddFriend.Visible = false;
                BtnMessenger.Visible = false;
              
            }
            else if (IsFriend == 1)
            {
                BtnAddFriend.Text = "Huỷ kết bạn";
                BtnAddFriend.BackColor = Color.Red;
                BtnAddFriend.colbackground = Color.Red;
                BtnAddFriend.colhover = Color.FromArgb(211, 47, 47);
                BtnAddFriend.Visible = true;
                BtnAddFriend.Update();
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
                BtnAddFriend.colbackground = btnMessenger.colbackground;
                BtnAddFriend.colhover = btnMessenger.colhover;
                BtnAddFriend.Visible = true;
                BtnAddFriend.Update();
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
