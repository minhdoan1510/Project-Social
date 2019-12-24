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
    public partial class UCMessengerDisplay : UserControl
    {
        List<UCDetailMessbox> uCDetailMessboxes;

        List<Mailboxlist> mailboxlists;


        public delegate object OnGetMailboxlist();
        public event OnGetMailboxlist GetMailboxlist;

        public delegate bool OnSendMess(string Mess, string idMessbox, string uidsend);
        public event OnSendMess SendMessCurrent;

        public delegate object OnGetMessinMessbox(string IDmess);
        public event OnGetMessinMessbox GetMessinMessbox;

        public delegate MessinMessbox OnHaveMess();
        public event OnHaveMess HaveMess;

        public UCMessengerDisplay(object _mailboxlists)
        {
            mailboxlists = (List < Mailboxlist > )_mailboxlists;
            uCDetailMessboxes = new List<UCDetailMessbox>();
            InitializeComponent();
            LoadListMess();

        }

        private void LoadListMess()
        {

            foreach (Mailboxlist item in mailboxlists)
            {
                UCMessengerUnit uCMessengerUnit = new UCMessengerUnit(item.Avatar, item.Nameuser, item.Lastcontent) { Dock = DockStyle.Top, Tag = item.IDmessbox };
                uCMessengerUnit.OpenMessBox += (IdMess,Username) => UCMessengerUnit_OpenMessBox(IdMess,Username,item.Iduser);
                //uCMessengerUnit.Click += UCMessengerUnit_Click;

                this.pnlListMess.Controls.Add(uCMessengerUnit);
            }
        }

        public void UCMessengerUnit_OpenMessBox(string IDmessbox, string Username, string IdUser)
        {
            UCDetailMessbox detailMessbox = uCDetailMessboxes.Where(x => x.Tag.Equals(IDmessbox)).SingleOrDefault();
            Mailboxlist tempMailbox = mailboxlists.Where(x => x.IDmessbox == IDmessbox).SingleOrDefault();
            if(tempMailbox!=null)
            {
               
                if (detailMessbox == null)
                {
                    List<MessinMessbox> detailMess = new List<MessinMessbox>();
                    if (GetMessinMessbox != null)
                        detailMess = (List<MessinMessbox>)GetMessinMessbox(IDmessbox);

                    detailMessbox = new UCDetailMessbox(Username,IdUser);
                    detailMessbox.Avatar = tempMailbox.Avatar;
                    foreach(var item in detailMess)
                        detailMessbox.AddMessinMessbox(item);
                    detailMessbox.Tag = IDmessbox;
                    uCDetailMessboxes.Add(detailMessbox);
                }
            }
            else
            {
                detailMessbox = new UCDetailMessbox(Username,IdUser);
                detailMessbox.Tag = IDmessbox;
                uCDetailMessboxes.Add(detailMessbox);
            }
            detailMessbox.Back += () => this.Controls.Remove(detailMessbox);
            detailMessbox.Dock = DockStyle.Fill;
            detailMessbox.Location = new Point(3, 3);
            detailMessbox.SendMessCurrent += DetailMessbox_SendMessCurrent;
            this.Controls.Add(detailMessbox);
            detailMessbox.BringToFront();
        }

        private bool DetailMessbox_SendMessCurrent(string Mess, string idMessbox,string UID)
        {
           
            if (SendMessCurrent != null)
                return SendMessCurrent(Mess, idMessbox, UID);
            return false;
        }

        public void AddMess(MessinMessbox messin)
        {
            Invoke(new Action(() =>
            {
                uCDetailMessboxes.Where(x => x.Tag.Equals(messin.IDmessBox)).SingleOrDefault().AddMessinMessbox(messin);
            }));
            
        }
    }
}
