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
    public partial class NotificationList : Form
    {
        public NotificationList(List<Notify> notifyList,string UIDCurrentUser)
        {
            InitializeComponent();
            foreach(Notify item in notifyList)
            {
                AddNoti(item,UIDCurrentUser);
            }
            btnExit.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Picture\Exit.png");
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;

        }
        public void AddNoti(Notify notify, string UIDCurrentUser)
        {
            NotificationItem notificationItem = new NotificationItem(notify, UIDCurrentUser);
            notificationItem.Dock = DockStyle.Top;
        
            notificationItem.BorderStyle = BorderStyle.FixedSingle;
            this.splitContainer1.Panel2.Controls.Add(notificationItem);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
