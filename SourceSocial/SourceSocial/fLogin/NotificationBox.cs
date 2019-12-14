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
            lbNotiText.Text = notify.SendName + " đã " + ((notify.TypeNotify == 1) ? "like " : "comment ") + "bài viết của " + ((notify.ReceiveUID==UIDCurrentUser)? "bạn.":notify.ReceiveName + " mà bạn đang theo dõi.");
    
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();

        }


        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                t1.Stop();   //this stops the timer if the form is completely displayed
                System.Threading.Thread.Sleep(500);
                t1.Tick += new EventHandler(fadeOut);  //this calls the fade out function
                t1.Start();
            }
            else
                Opacity += 0.05;
        }

        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                t1.Stop();    //if it is, we stop the timer
                Close();   //and we try to close the form
            }
            else
                Opacity -= 0.05;
        }
    }
}
