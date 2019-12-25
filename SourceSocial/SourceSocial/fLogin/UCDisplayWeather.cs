using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace fLogin
{
    public partial class UCDisplayWeather : UserControl
    {
        private string viTri;
        private string nhietDo;
        private string doAm;
        private Image imageWeather;

        public delegate void OnMessBug(string str);
        public event OnMessBug Messbug;

        public UCDisplayWeather()
        {
            InitializeComponent();
            ptbCannon.Image = Bitmap.FromFile(Application.StartupPath + @"\Picture\cannon.png");
            ptbCannon.BackColor = Color.Transparent;
            ptbCannon.SizeMode = PictureBoxSizeMode.Zoom;
            btnBug.Click += BtnBug_Click;
        }

        private void BtnBug_Click(object sender, EventArgs e)
        {
            Form fBug = new MaterialForm() { Size = new Size(449, 25+472), StartPosition = FormStartPosition.CenterScreen, Sizable = false, MaximizeBox = false , MinimizeBox = false};
            fBug.Text = "Gửi phản hồi về lỗi cho chúng tôi";
            UCBug uCBug = new UCBug() { Location = new Point(0, 25) };
            fBug.Controls.Add(uCBug);
            uCBug.Messbug += (s) => { Messbug(s); };
            uCBug.CloseBug += () => { fBug.Close(); };
            fBug.ShowDialog();
        }

        public void Update( string _vtri,string _nhietdo,string _doam)
        {
            ViTri = _vtri;
            NhietDo = _nhietdo;
            DoAm = _doam;
        }

        public string ViTri
        {
            get => viTri;
            set
            {
                lbViTri.Text = value;
                viTri = value;
            }
        }
        public string NhietDo
        {
            get => nhietDo;
            set
            {
                lbNhietDo.Text = value;
                nhietDo = value;
            }
        }
        public string DoAm
        {
            get => doAm;
            set
            {
                lbDoAm.Text = value;
                doAm = value;
            }
        }

        public Image ImageWeather
        {
            get => imageWeather;
            set
            {
                ptbWeather.Image = value;
                imageWeather = value;
            }
        }
    }
}
