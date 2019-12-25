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
using BUS;

namespace fLogin
{
    public partial class NotificationList : Form
    {
        public delegate void ClickNotify(string IdPost);
        public event ClickNotify OnClickNotify;

        public NotificationList(BUS_Controls bUS_Controls)
        {
            InitializeComponent();
            foreach (Notify item in bUS_Controls.GetAllNotifyofUser())
            {
                AddNoti(item, bUS_Controls.Profilecurrent.Uid);
            }
            btnExit.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Picture\Exit.png");
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;

        }
        public void AddNoti(Notify notify, string UIDCurrentUser)
        {
            NotificationItem notificationItem = new NotificationItem(notify, UIDCurrentUser);
            notificationItem.Dock = DockStyle.Top;
            notificationItem.BorderStyle = BorderStyle.FixedSingle;
            notificationItem.OnClickNotify += (i) => OnClickNotify(i);
            this.splitContainer1.Panel2.Controls.Add(notificationItem);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
