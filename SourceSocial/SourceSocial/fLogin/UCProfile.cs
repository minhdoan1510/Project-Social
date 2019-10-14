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
    public partial class UCProfile : UserControl
    {
        public UCProfile(Profile profile)
        {
            InitializeComponent();
            LoadDisplay(profile);
        }

        private void LoadDisplay(Profile profile)
        {
            //add ProfileControl
            UCProfile_InfoBox uCProfile_InfoBox = new UCProfile_InfoBox(profile);
            pnlProfile_Infor.Controls.Add(uCProfile_InfoBox);
            
            //

        }
    }
}
