using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace fLogin
{
    public partial class UCMessofYou : UserControl
    {
        private Image avatar;
        private string mess;

        public UCMessofYou(Image _avatar, string _mess)
        {
            InitializeComponent();
            ptbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            Avatar = _avatar ?? Bitmap.FromFile(System.Windows.Forms.Application.StartupPath + @"\Picture\NoAvatar.png");
            Mess = _mess;
            using (Graphics g = CreateGraphics())
            {
                SizeF size = g.MeasureString(txbMess.Text, txbMess.Font);
                txbMess.Width = (int)Math.Ceiling(size.Width) + 15;
            }

        }

        public Image Avatar
        {
            get => avatar;
            set
            {
                avatar = value;
                ptbAvatar.Image = value;

            }
        }
        public string Mess
        {
            get => mess;
            set
            {
                mess = value;
                txbMess.Text = value;
            }
        }

    }
}
