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

namespace fLogin
{
    public partial class UCMainHeader : UserControl
    {
        #region Propertion
        Profile profile;

        public delegate void OpenProfile(string UID);
        public event OpenProfile OnOpenProfile;

        public delegate void OpenHome();
        public event OpenHome OnOpenHome;
        public Label LbName { get => lbName; set => lbName = value; }
        public PictureBox PtbLogo { get => ptbLogo; set => ptbLogo = value; }
        public PictureBox PtbAvatar { get => ptbAvatar; set => ptbAvatar = value; }

        #endregion

        public UCMainHeader(Profile _profile)
        {
            InitializeComponent();
            profile = _profile;
            LoadMainHeader(_profile);
            LoadAnimation();
        }

        #region Load_UCMainHeader
        private void LoadMainHeader(Profile _profile)
        {
            this.PtbLogo.Image = Bitmap.FromFile(Application.StartupPath + @"/Picture/LogoMain.png");
            this.PtbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            LbName.Text = _profile.Name;
            PtbAvatar.Image = (_profile.Avatar != null) ? _profile.Avatar : Bitmap.FromFile(Application.StartupPath + @"\Picture\NoAvatar.png");
            PtbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pnlProfile.Click += PnlProfile_Click;
            PtbLogo.Click += (s, e) => OnOpenHome();
        }
        #endregion

        #region Handle_Event
        private void PnlProfile_Click(object sender, EventArgs e)
        {
            if (OnOpenProfile != null)
            {
                OnOpenProfile(profile.Uid);
            }
        }
        #endregion

        #region Animation

        private void LoadAnimation()
        {
            //Animation enter PnlProfile
            pnlProfile.MouseEnter += (s, e) =>
            {
                pnlProfile.BackColor = Color.FromArgb(51, 51, 51);
            };
            pnlProfile.MouseLeave += (s, e) =>
            {
                 pnlProfile.BackColor = Color.Transparent;
            };
        }

        #endregion
    }
}
