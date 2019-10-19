using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace fLogin
{
    public partial class fLogin : Form
    {
        #region propertion
        BUS_Controls BUS_Controls = new BUS_Controls();
        #endregion

        public fLogin()
        {
            InitializeComponent();
        }

        #region Handle_Event
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            pnlSignIn.Visible = false;
        }
        private void BtnSignUp_SignUp_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                Name = txbName_SignUp.Text,
                Password = txbPassword_SignUp.Text,
                Username = txbUsername_SignUp.Text
            };
            if (txbRePassword_SignUp.Text == txbPassword_SignUp.Text && BUS_Controls.SignUp(account))
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlSignIn.Visible = true;
            }
            else
                MessageBox.Show("Khoogn thanh cong");
        }
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (BUS_Controls.SigIn(new Account() { Username = txbUsername_SignIn.Text, Password = txbPassword_SignIn.Text }))
            {
                fMain fMain = new fMain(BUS_Controls);
                fMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai!!!!");
            }
            //BUS_Controls.SigIn(new Account() { Username = "nkoxway49", Password = "123" });
            //fMain fMain = new fMain(BUS_Controls);
            //this.Visible = false;
            //fMain.ShowDialog();
        }
        #endregion
    }
}
