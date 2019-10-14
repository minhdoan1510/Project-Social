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
    public partial class UCProfile_InfoBox : UserControl
    {
        public UCProfile_InfoBox(Profile _profile)
        {
            InitializeComponent();
            PtbAvatar.Image = (_profile.Avatar != null) ? _profile.Avatar : Bitmap.FromFile(Application.StartupPath + @"\Picture\NoAvatar.png");
            PtbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            LbName.Text = _profile.Name;
        }
        public PictureBox PtbAvatar { get=>ptbAvatar; set => ptbAvatar = value; }
        public Label LbName { get=>lbName; set=>lbName = value; }
    }
}
