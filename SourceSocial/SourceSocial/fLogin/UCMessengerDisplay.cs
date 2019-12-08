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

        List<UCDetailMessbox> uCDetailMessboxes;
             

        List<Mailboxlist> mailboxlists;

        private void LoadListMess()
        {

            foreach (Mailboxlist item in mailboxlists)
            {
                UCMessengerUnit uCMessengerUnit = new UCMessengerUnit(item.Avatar, item.Nameuser, item.Lastcontent) { Dock = DockStyle.Top, Tag = item.IDmessbox };
                uCMessengerUnit.OpenMessBox += UCMessengerUnit_OpenMessBox;
                //uCMessengerUnit.Click += UCMessengerUnit_Click;

                this.pnlListMess.Controls.Add(uCMessengerUnit);
            }
        }

        private void UCMessengerUnit_OpenMessBox(string IDmessbox)
        {
            UCDetailMessbox detailMessbox = uCDetailMessboxes.Where(x => x.Tag.Equals(IDmessbox)).SingleOrDefault();
            if (detailMessbox == null)
            {
                List<MessinMessbox> detailMess = new List<MessinMessbox>();
                if (GetMessinMessbox != null)
                    detailMess = (List<MessinMessbox>)GetMessinMessbox(IDmessbox);

                detailMessbox = new UCDetailMessbox(mailboxlists.Where(x => x.IDmessbox.Equals(IDmessbox)).SingleOrDefault().Nameuser);
                foreach (MessinMessbox item in detailMess)
                {
                   detailMessbox.AddMessinMessbox(item);
                }
                detailMessbox.Tag = IDmessbox;
                uCDetailMessboxes.Add(detailMessbox);
            }
            detailMessbox.Back += () => this.Controls.Remove(detailMessbox);
            detailMessbox.Dock = DockStyle.Fill;
            detailMessbox.Location = new Point(3, 3);
            detailMessbox.SendMessCurrent += DetailMessbox_SendMessCurrent;
            this.Controls.Add(detailMessbox);
            detailMessbox.BringToFront();

            //UCDetailMessbox uCDetailMessbox = new UCDetailMessbox(mailboxlists.Where(x => x.IDmessbox == ).SingleOrDefault());


            //pnlDisplayMess.Controls.Clear();
            //pnlDisplayMess.Tag = mailboxlists.Where(x => x.IDmessbox == IDmess).SingleOrDefault().IDmessbox;
            //List<MessinMessbox> detailMess = new List<MessinMessbox>();
            //if (GetMessinMessbox != null)
            //    detailMess = (List<MessinMessbox>)GetMessinMessbox(IDmess);

            //lbName.Text = mailboxlists.Where(x => x.IDmessbox == IDmess).SingleOrDefault().Nameuser;
            //foreach (MessinMessbox item in detailMess)
            //{
            //    AddMessinMessbox(item);
            //}

            //this.pnlDetailMess.Location = new Point(3, 3);


        }

        private bool DetailMessbox_SendMessCurrent(string Mess, string idMessbox)
        {
            if (SendMessCurrent != null)
                return SendMessCurrent(Mess, idMessbox, mailboxlists.Where(x => x.IDmessbox.Equals(idMessbox)).SingleOrDefault().Iduser);
            return false;
        }

        public void AddMess(MessinMessbox messin)
        {
            uCDetailMessboxes.Where(x => x.Tag.Equals(messin.IDmessBox)).SingleOrDefault().newMess = messin;
        }
    }
}
