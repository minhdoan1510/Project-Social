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

        public delegate void OpenProfile();
        public event OpenProfile OnOpenProfile;

        public delegate void OpenHome();
        public event OpenHome OnOpenHome;
        Profile profile = new Profile();
        public UCMainHeader(Profile _profile)
        {
            InitializeComponent();
            LoadMainHeader(_profile);
            LoadAnimation();
            profile = _profile;
        }

        

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

        private void PnlProfile_Click(object sender, EventArgs e)
        {
            if (OnOpenProfile != null)
            {
                OnOpenProfile();
            }
        }

        public Label LbName { get => lbName; set => lbName = value; }
        public PictureBox PtbLogo { get => ptbLogo; set => ptbLogo = value; }
        public PictureBox PtbAvatar { get => ptbAvatar; set => ptbAvatar = value; }

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
