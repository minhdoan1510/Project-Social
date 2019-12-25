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
    public partial class UCDisplayUserOnline : UserControl
    {

        public delegate void OnClickUser(string uid);
        public event OnClickUser ClickUser;

        public UCDisplayUserOnline()
        {
            InitializeComponent();
            
            this.pnlDisplay.AutoScroll = false;
            this.pnlDisplay.HorizontalScroll.Maximum = 0;
            this.pnlDisplay.HorizontalScroll.Visible = false;
            this.pnlDisplay.VerticalScroll.Maximum = 0;
            this.pnlDisplay.VerticalScroll.Visible = false;
            this.pnlDisplay.AutoScroll = true;
        }

        public void AddUserOnline(string name, string uid)
        {
            UCDisplayUserOnlineUnit uCDisplayUserOnlineUnit = new UCDisplayUserOnlineUnit(name, uid);
            uCDisplayUserOnlineUnit.ClickUser += (id) => ClickUser(id);
            uCDisplayUserOnlineUnit.Dock = DockStyle.Top;

            //TextBox textBox = new TextBox();// { Dock = DockStyle.Top };
            this.pnlDisplay.Controls.Add(uCDisplayUserOnlineUnit);
           // this.pnlDisplay.Controls.Add(textBox);
        }


        public void DelUserOnline(string uid)
        {

            foreach (Control item in this.pnlDisplay.Controls)
            {
                try
                {
                    if (item.Tag.Equals(uid))
                            item.Dispose();
                }
                catch { }
            }
        }
    }
}
