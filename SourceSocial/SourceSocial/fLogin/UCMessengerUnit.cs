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
    public partial class UCMessengerUnit : UserControl
    {
        public delegate void OnOpenMessBox(string IDmess);
        public event OnOpenMessBox OpenMessBox;



        public UCMessengerUnit(Image _avatar, string _name, string _lastmess)
        {

            InitializeComponent();
            ptbAvatar.Image = _avatar;
            ptbAvatar.SizeMode = PictureBoxSizeMode.Zoom;

            lbName.Text = _name;

            lbMessDisplay.Text = _lastmess;

            this.panel1.Click += Panel1_Click;
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            if (OpenMessBox != null)
                OpenMessBox(this.Tag.ToString() );
        }
    }
}
