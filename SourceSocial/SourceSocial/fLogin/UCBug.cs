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
    public partial class UCBug : UserControl
    {
        public delegate void OnMessBug(string str);
        public event OnMessBug Messbug;

        public delegate void OnCloseBug();
        public event OnCloseBug CloseBug;

        public UCBug()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            Messbug(rtbBug.Text);
            MessageBox.Show("Cảm ơn bạn đã góp ý. Góp ý của bạn sẽ khiến chúng tôi mất ăn mất ngủ nhiều hơn. Lời cảm ơn trong nước mắt!!!");
            CloseBug();
        }
    }
}
