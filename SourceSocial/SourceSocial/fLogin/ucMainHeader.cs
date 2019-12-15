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
using System.Drawing.Drawing2D;

namespace fLogin
{
    public partial class UCMainHeader : UserControl
    {
        #region Propertion
        Profile profile;
        List<KeyValuePair<string, string>> peopleList;

        public delegate void OpenProfile(string UID);
        public event OpenProfile OnOpenProfile;

        public delegate void OpenHome();
        public event OpenHome OnOpenHome;

        public delegate void OpenMessenger();
        public event OpenMessenger OnOpenMessenger;

        public delegate void OpenNotify();
        public event OpenNotify OnOpenNotify;


        public PictureBox PtbLogo { get => ptbLogo; set => ptbLogo = value; }
        public PictureBox PtbAvatar { get => ptbAvatar; set => ptbAvatar = value; }

        #endregion


        public UCMainHeader(Profile _profile, List<KeyValuePair<string, string>> _people)
        {
            InitializeComponent();
            profile = _profile;
            peopleList = _people;
            LoadMainHeader(_profile);
            LoadAnimation();
        }

        #region Load_UCMainHeader
        private void LoadMainHeader(Profile _profile)
        {
            InitSearchTbx();
            //   this.PtbLogo.Image = Bitmap.FromFile(Application.StartupPath + @"/Picture/LogoMain.png");
            //   this.PtbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pnlProfile.Text = _profile.Name;
            PtbAvatar.Image = (_profile.Avatar != null) ? _profile.Avatar : Bitmap.FromFile(Application.StartupPath + @"\Picture\NoAvatar.png");
            PtbAvatar.SizeMode = PictureBoxSizeMode.Zoom;

            pnlProfile.Controls.Add(ptbAvatar);
            ptbAvatar.BackColor = Color.Transparent;
            ptbAvatar.Dock = DockStyle.Left;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 3, 43, 43);
            ptbAvatar.Region = new Region(path);

            PtbLogo.Click += (s, e) => OnOpenHome();
            btnMess.Click += (s, e) => OnOpenMessenger();
            btnNotify.Click += (s, e) => OnOpenNotify();
            tbxSearch.KeyDown += UCMainHeader_KeyDown;
            //pnlclick = new Panel() { Size = pnlProfile.Size };
            //pnlProfile.Controls.Add(pnlclick);
            //pnlclick.BringToFront();
            //pnlclick.Visible = false;
            //pnlclick.Click += PnlProfile_Click;

            btnMess.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Picture\mess.png");
            btnMess.BackgroundImageLayout = ImageLayout.Zoom;
            btnNotify.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Picture\noti.png");
            btnNotify.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImage = System.Drawing.Bitmap.FromFile(Application.StartupPath + @"\Picture\widebg.png");
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
        private void UCMainHeader_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (peopleList.Where(x => tbxSearch.Text == x.Value).SingleOrDefault().Key != null)
                    OnOpenProfile(peopleList.Where(x => tbxSearch.Text == x.Value).SingleOrDefault().Key);
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

        private void InitSearchTbx()
        {
            tbxSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (var item in peopleList)
            {
                collection.Add(item.Value);
            }
            tbxSearch.AutoCompleteCustomSource = collection;

        }

        #endregion

        private void BtnMess_Click(object sender, EventArgs e)
        {
            if (OnOpenMessenger != null)
                OnOpenMessenger();
        }

    }
}
