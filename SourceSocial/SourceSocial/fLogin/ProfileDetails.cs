using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using DTO;
using BUS;
namespace fLogin
{
    public partial class ProfileDetails : MaterialForm
    {
        BUS_Controls BUS_Controls;
        public ProfileDetails(BUS_Controls _Controls,Profile profile)
        {
            BUS_Controls = _Controls;
            InitializeComponent();
            lblName.Text = profile.Name;
            ptbAvatar.BackgroundImage = profile.Avatar;
            tbxBDay.Text = profile.DateOfBirth.ToShortDateString();
            tbxEmail.Text = profile.Email;
            tbxHometown.Text = profile.HomeTown;
            tbxPhonenum.Text = profile.PhoneNum;
            tbxMarriage.Text = profile.MarriageSt;
            if (BUS_Controls.IsFriendWith(profile.Uid) != 2)
                btnAlter.Visible = false;
            else 
            btnAlter.Click += (sender, e) =>
            {
                Profile _profile = new Profile() {
                    Avatar = profile.Avatar,
                    Name = profile.Name,
                    Uid = profile.Uid,
                    DateOfBirth = DateTime.Parse(tbxBDay.Text),
                    Email = tbxEmail.Text,
                    HomeTown = tbxHometown.Text,
                    PhoneNum = tbxPhonenum.Text,
                    MarriageSt = tbxMarriage.Text
                };
                 if (BUS_Controls.AlterProfile(_profile))
                     MessageBox.Show("Thay đổi thông tin thành công!");
                 else
                     MessageBox.Show("Thay đổi thông tin thất bại!");
            };
        }

        private void ProfileDetails_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, ptbAvatar.Width, ptbAvatar.Height);
            ptbAvatar.Region = new Region(path);
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.BLACK);

        }
    }
}
