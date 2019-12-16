using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace fLogin
{
    public partial class NotificationBox : Form
    {
        Timer t1 = new Timer();
   
        public NotificationBox(Notify notify,string UIDCurrentUser)
        {
            InitializeComponent();
            if(notify.TypeNotify ==3 )
            {
                lbNotiText.Text = notify.SendName + " đã gửi cho bạn 1 tin nhắn. ";
            }
            else
            lbNotiText.Text = notify.SendName + " đã " + ((notify.TypeNotify == 1) ? "like " : "comment ") + "bài viết của " + ((notify.ReceiveUID==UIDCurrentUser)? "bạn.":notify.ReceiveName + " mà bạn đang theo dõi.");
    
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            Opacity = 0;      
            t1.Interval = 10;  
            t1.Tick += new EventHandler(fadeIn);  
            t1.Start();

        }


        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                t1.Stop();   
                System.Threading.Thread.Sleep(500);
                t1.Tick += new EventHandler(fadeOut); 
                t1.Start();
            }
            else
                Opacity += 0.05;
        }

        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)    
            {
                t1.Stop();    
                Close();  
            }
            else
                Opacity -= 0.05;
        }
    }
}
