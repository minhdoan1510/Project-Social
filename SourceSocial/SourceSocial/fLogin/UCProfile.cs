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
    public partial class UCProfile : UserControl
    {
        public UCProfile_InfoBox uCProfile_InfoBox;
        public delegate bool ChangeAvatar(Image image);
        public event ChangeAvatar OnChangeAvatar;


        public delegate bool LoadPost_Profile(string uid, string content);
        public event LoadPost_Profile OnLoadPost_Profile;
        public UCProfile(Profile profile)
        {
            InitializeComponent();
            LoadDisplay(profile);
        }


        private void LoadDisplay(Profile profile)
        {
            //add ProfileControl
            UCProfile_InfoBox uCProfile_InfoBox = new UCProfile_InfoBox(profile);
            pnlProfile_Infor.Controls.Add(uCProfile_InfoBox);
            uCProfile_InfoBox.OnChangeAvatar += (i) => OnChangeAvatar(i);
            //
            //add UCaddPost
            UCAddPost uCAddPost = new UCAddPost();
            uCAddPost.OnAddPost += (content)=> OnLoadPost_Profile(this.Tag.ToString(),content);


        }

    }
}
