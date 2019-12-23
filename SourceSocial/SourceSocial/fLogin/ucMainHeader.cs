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

        public delegate void OpenGame();
        public event OpenGame OnOpenGame;


        public PictureBox PtbLogo { get => ptbLogo; set => ptbLogo = value; }
        public Image imageProfile { get => pnlProfile.Iconimage; set {
                pnlProfile.Iconimage = CropCircleImage(value, new PointF(value.Height / 2, value.Height / 2), value.Height / 2, pnlProfile.BackColor);
            } }

        #endregion


        public UCMainHeader(Profile _profile, List<KeyValuePair<string, string>> _people)
        {
            InitializeComponent();
            profile = _profile;
            peopleList = _people;
            LoadMainHeader(_profile);
          
        }

        #region Load_UCMainHeader
        private void LoadMainHeader(Profile _profile)
        {
            InitSearchTbx();
            //   this.PtbLogo.Image = Bitmap.FromFile(Application.StartupPath + @"/Picture/LogoMain.png");
            //   this.PtbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pnlProfile.Text = _profile.Name;
            imageProfile = _profile.Avatar;

            pnlProfile.Click += PnlProfile_Click;

            PtbLogo.Click += (s, e) => OnOpenHome();
            btnMess.Click += (s, e) => OnOpenMessenger();
            btnNotify.Click += (s, e) => OnOpenNotify();
            btnGame.Click += (s, e) => OnOpenGame();
            tbxSearch.KeyDown += UCMainHeader_KeyDown;
       
            ptbLogo.Image = Bitmap.FromFile(Application.StartupPath + @"\Picture\LogoMain.png");
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            btnMess.Image = Bitmap.FromFile(Application.StartupPath + @"\Picture\mess2.png");
            btnMess.SizeMode = PictureBoxSizeMode.Zoom;
            btnNotify.Image = Bitmap.FromFile(Application.StartupPath + @"\Picture\noti2.png");
            btnNotify.SizeMode = PictureBoxSizeMode.Zoom;
            btnGame.Image = Bitmap.FromFile(Application.StartupPath + @"\Picture\game.png");
            btnGame.SizeMode = PictureBoxSizeMode.Zoom;
      
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

        public Image CropCircleImage(Image srcImage, PointF center, float radius, Color backGround)
        {
            Image dstImage = new Bitmap(srcImage.Height, srcImage.Height, srcImage.PixelFormat);

            using (Graphics g = Graphics.FromImage(dstImage))
            {
                RectangleF r = new RectangleF(center.X - radius, center.Y - radius,
                                                         radius * 2, radius * 2);

                // fills background color
                using (Brush br = new SolidBrush(backGround))
                {
                    g.FillRectangle(br, 0, 0, dstImage.Width, dstImage.Height);
                }
                g.SmoothingMode = SmoothingMode.AntiAlias;
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(r);
                g.SetClip(path);
                g.DrawImage(srcImage, 0, 0);

                return dstImage;
            }
        }
        #endregion

        private void BtnMess_Click(object sender, EventArgs e)
        {
            if (OnOpenMessenger != null)
                OnOpenMessenger();
        }

    }
}
