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

<<<<<<< HEAD
        public delegate MessinMessbox OnHaveMess();
        public event OnHaveMess HaveMess;

        public UCDetailMessbox(string name)
        {
            InitializeComponent();
            Load(name);
        }

        private void Load(string name)
        {
            this.btnBack.Click += BtnBack_Click;
            this.btnSend.Click += BtnSend_Click;
            //this.txbMess.KeyPress += TxbMess_KeyPress;
            this.txbMess.KeyDown += TxbMess_KeyDown;
            lbName.Text = name;
        }

        private void TxbMess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendMess();
=======
        public MessinMessbox newMess;

        public UCDetailMessbox(string name)
        {
            InitializeComponent();
            //pnlDisplayMess.AutoScroll = false;
            //pnlDisplayMess.HorizontalScroll.Maximum = 0;
            //pnlDisplayMess.HorizontalScroll.Visible = false;
            //pnlDisplayMess.VerticalScroll.Maximum = 0;
            //pnlDisplayMess.VerticalScroll.Visible = false;
            pnlDisplayMess.AutoScroll = true;
            pnlDisplayMess.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Picture\messbg.png");

            Loading(name);


            pnlDetailMess.Focus();
        }

        private void TxbMess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendMess();
        }

        private void Loading(string name)
        {
            this.btnBack.Click += BtnBack_Click;
            this.btnSend.Click += BtnSend_Click;
            this.txbMess.KeyDown += TxbMess_KeyDown;
            lbName.Text = name;
            
>>>>>>> minhtien
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
            pnlDisplayMess.Select();
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
            UCmess.Dock = DockStyle.Bottom;
            this.pnlDisplayMess.Controls.Add(UCmess);
        }
    }
}
