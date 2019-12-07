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
    public partial class UCMessofYou : UserControl
    {
        private Image avatar;
        private string mess;

        


        public UCMessofYou( Image _avatar, string _mess )
        {
            InitializeComponent();
            Avatar = _avatar;
            Mess = _mess;
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
