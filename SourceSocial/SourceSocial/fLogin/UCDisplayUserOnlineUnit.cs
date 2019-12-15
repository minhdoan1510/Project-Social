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
    public partial class UCDisplayUserOnlineUnit : UserControl
    {
        public delegate void OnClickUser(string uid);
        public event OnClickUser ClickUser; 

        public UCDisplayUserOnlineUnit(string name,string uid)
        {
            InitializeComponent();
            this.Tag = uid;

            lbName.Text = name;
            lbName.Enabled = false;
            lbName.AutoSize = true;

            ptbActive.Enabled = false;

            ptbActive.SizeMode = PictureBoxSizeMode.Zoom;
            ptbActive.Image = Bitmap.FromFile(Application.StartupPath + @"\Picture\active.png");
            this.Click += (s,e) => ClickUser(this.Tag.ToString());
        }

    }
}
