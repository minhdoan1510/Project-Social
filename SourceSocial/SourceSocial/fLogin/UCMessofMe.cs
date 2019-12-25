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

    public partial class UCMessofMe : UserControl
    {

        public UCMessofMe(string _content)
        {
            InitializeComponent();
            Mess = _content;
            using (Graphics g = CreateGraphics())
            {
                SizeF size = g.MeasureString(txbMess.Text, txbMess.Font);
                txbMess.Width = (int)Math.Ceiling(size.Width) + 15;

            }

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
