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
using System.Threading;

namespace fLogin
{
    public partial class UCDetailMessbox : UserControl
    {

        public delegate bool OnSendMess(string Mess, string idMessbox);
        public event OnSendMess SendMessCurrent;


        public delegate object OnGetMessinMessbox(string IDmess);
        public event OnGetMessinMessbox GetMessinMessbox;


        public delegate void OnBack();
        public event OnBack Back;

        public MessinMessbox newMess;

        public delegate MessinMessbox OnHaveMess();
        public event OnHaveMess HaveMess;

        public UCDetailMessbox(string name)
        {
            InitializeComponent();
            Load(name);

            Thread lisningMess = new Thread(() =>
            {
                while (true)
                {
                    if (newMess != null)
                    {
                        AddMessinMessbox(newMess);
                        newMess = null;
                    }
                }
            });
            lisningMess.IsBackground = true;
            lisningMess.Start();

        }

        private void Load(string name)
        {
            this.btnBack.Click += BtnBack_Click;
            this.btnSend.Click += BtnSend_Click;
            this.txbMess.KeyPress += TxbMess_KeyPress;
            lbName.Text = name;
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
                if (SendMessCurrent(txbMess.Text, this.Tag.ToString()))
                {
                    AddMessinMessbox(new MessinMessbox() { IsMe = true, Content = txbMess.Text });
                    txbMess.Clear();
                }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (Back != null)
                Back();

        }



        public void AddMessinMessbox(MessinMessbox messin)
        {
            Control UCmess;
            if (messin.IsMe)
                UCmess = new UCMessofMe(messin.Content);
            else
                UCmess = new UCMessofYou(messin.Avatar, messin.Content);
            UCmess.Dock = DockStyle.Top;
            this.pnlDisplayMess.Controls.Add(UCmess);
        }
    }
}
