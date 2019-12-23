using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace fLogin
{
    public partial class fLogin : MaterialSkin.Controls.MaterialForm
    {
        #region propertion
        BUS_Controls BUS_Controls = new BUS_Controls();
        #endregion

        public fLogin()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red800, MaterialSkin.Primary.Red600, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            ptbAvatar.Image = Bitmap.FromFile(Application.StartupPath + @"\Picture\avatarLoginfrm.png");
            ptbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        #region Handle_Event
     
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
            }
            else
                MessageBox.Show("Khong thanh cong");
        }
        async private void BtnSignIn_Click(object sender, EventArgs e)
        {
            UCLoading ucLoadingLogin = new UCLoading();
            this.Controls.Add(ucLoadingLogin);
            ucLoadingLogin.BringToFront();

            Func<bool> funcSigIn = new Func<bool>(() => BUS_Controls.SigIn(new Account() { Username = txbUsername_SignIn.Text, Password = txbPassword_SignIn.Text }));

            Task<bool> taskSigIn = new Task<bool>(funcSigIn);
            taskSigIn.Start();
            await taskSigIn;
            

            
            if (taskSigIn.Result)
            {
                LoadfMain();


                //this.Close();
                

            }
            else
            {
                this.Controls.Remove(ucLoadingLogin);
                MessageBox.Show("Sai!!!!");
            }

            //BUS_Controls.SigIn(new Account() { Username = "nkoxway49", Password = "123" });
            //fMain fMain = new fMain(BUS_Controls);
            //this.Visible = false;
            //fMain.ShowDialog();
        }

        async private void LoadfMain()
        {

            Form fMain = new Form();
            fMain = new fMain(BUS_Controls);
            fMain.FormClosed += (j, s) => this.Close();
            this.Hide();
            fMain.ShowDialog();
        }

        #endregion

    }
}
