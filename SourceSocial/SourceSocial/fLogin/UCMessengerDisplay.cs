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


        public delegate object OnGetMessinMessbox(string IDmess);
        public event OnGetMessinMessbox GetMessinMessbox;

        public delegate bool OnSendMess(string Mess, string idMessbox);
        public event OnSendMess SendMessCurrent;


        public UCMessengerDisplay( object _mailboxlists)
        {
            mailboxlists = (List < Mailboxlist > )_mailboxlists;
            InitializeComponent();
            LoadListMess();
            this.btnBack.Click += BtnBack_Click;
            this.btnSend.Click += BtnSend_Click;
            this.txbMess.KeyPress += TxbMess_KeyPress;

        }

        private void TxbMess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Keys.Enter.ToString().Equals(e.KeyChar))
                SendMess();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            SendMess();
        }

        void SendMess()
        {
            if (txbMess.Text != string.Empty && SendMessCurrent != null)
                SendMessCurrent(txbMess.Text, pnlDetailMess.Tag.ToString());
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.pnlDetailMess.Location = new Point(259, 3);
        }

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

        private void UCMessengerUnit_OpenMessBox(string IDmess)
        {
            pnlDisplayMess.Controls.Clear();
            pnlDisplayMess.Tag = mailboxlists.Where(x => x.IDmessbox == IDmess).SingleOrDefault().IDmessbox;
            List<MessinMessbox> detailMess = new List<MessinMessbox>();
            if (GetMessinMessbox != null)
                 detailMess = (List<MessinMessbox>)GetMessinMessbox(IDmess);

            lbName.Text = mailboxlists.Where(x => x.IDmessbox == IDmess).SingleOrDefault().Nameuser;
            foreach (MessinMessbox item in detailMess)
            {
                AddMessinMessbox(item);
            }

            this.pnlDetailMess.Location = new Point(3, 3);

            
        }

        void AddMessinMessbox(MessinMessbox messin)
        {
            object UCmess;
            if (messin.IsMe)
                UCmess = new UCMessofMe(messin.Content);
            else
                UCmess = new UCMessofYou(messin.Avatar, messin.Content);
            ((Control)UCmess).Dock = DockStyle.Top;
            this.pnlDisplayMess.Controls.Add((Control)UCmess);
        }
    }
}
