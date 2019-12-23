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
        public delegate bool ChangeAvatar(Image image);
        public event ChangeAvatar OnChangeAvatar;

        BUS_Controls BUS_Controls;
        public ProfileDetails(BUS_Controls _Controls,Profile profile)
        {
            BUS_Controls = _Controls;
            InitializeComponent();
            lblName.Text = profile.Name;
            ptbAvatar.Image = profile.Avatar;
            ptbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            tbxBDay.Text = profile.DateOfBirth.ToShortDateString();
            tbxEmail.Text = profile.Email != string.Empty? profile.Email:"Chưa cập nhật";
            tbxHometown.Text = profile.HomeTown != string.Empty ? profile.HomeTown: "Chưa cập nhật" ;
            tbxPhonenum.Text = profile.PhoneNum != string.Empty ? profile.PhoneNum :"Chưa cập nhật"; 
            tbxMarriage.Text = profile.MarriageSt != string.Empty ? profile.MarriageSt:"Chưa cập nhật"; 
            if (BUS_Controls.IsFriendWith(profile.Uid) != 2)
            {
                btnAlter.Visible = false;
                btnChangeAvatar.Visible = false;
                foreach (var item in this.Controls.OfType<MaterialSingleLineTextField>())
                    item.Enabled = false;
            }
            else
                btnAlter.Click += (sender, e) =>
                {
                    Profile _profile = new Profile()
                    {
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
        }

        private void ChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();


            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Image bitmap = Bitmap.FromFile(openFile.FileName);
                if (OnChangeAvatar(bitmap))
                {
                    ptbAvatar.Image = bitmap;
                    MessageBox.Show("Đổi avatar thành công");
                }
                else
                {
                    MessageBox.Show("Đổi avatar không thành công");
                }

            }
        }
    }
}
