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
    public partial class UCAbout : UserControl
    {
        public UCAbout()
        {
            InitializeComponent();
            
        }
        private void BtnMinh_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(String.Format("http:\\fb.com/minhdoan1510"));
        }
        private void BtnTien_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(String.Format("http:\\fb.com/MinhTien1412"));
        }
    }
}
