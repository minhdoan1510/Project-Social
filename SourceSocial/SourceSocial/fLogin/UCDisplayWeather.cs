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
    public partial class UCDisplayWeather : UserControl
    {
        private string viTri;
        private string nhietDo;
        private string doAm;
        private Image imageWeather;

        public UCDisplayWeather()
        {
            InitializeComponent();
            ptbCannon.Image = Bitmap.FromFile(Application.StartupPath + @"\Picture\cannon.png");
            ptbCannon.BackColor = Color.Transparent;
            ptbCannon.SizeMode = PictureBoxSizeMode.Zoom;
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
