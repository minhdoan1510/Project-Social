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
    public partial class NotificationItem : UserControl
    {
        public delegate void ClickNotify(string IDPost);
        public event ClickNotify OnClickNotify;

        public NotificationItem(Notify notify, string UIDCurrentUser)
        {
            InitializeComponent();
            lbNoti.Text = notify.SendName + " đã " + ((notify.TypeNotify == 1) ? "like " : "comment ") + "bài viết của " + ((notify.ReceiveUID == UIDCurrentUser) ? "bạn." : notify.ReceiveName + " mà bạn đang theo dõi.");
            lbTime.Text = notify.Time.ToString();
            Click += (s, e) => OnClickNotify(notify.IDPost);
        }
    }
}
