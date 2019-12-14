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
    public partial class UCMessofMe : UserControl
    {
        public UCMessofMe(string _content)
        {
            InitializeComponent();
            Mess = _content;
        }
        private string mess;
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
