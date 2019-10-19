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

        public delegate bool AddFriend(string uid);
        public event AddFriend OnAddFriend;

        public delegate bool DelFriend(string uid);
        public event DelFriend OnDelFriend;

        public delegate bool LoadPost_Profile(string uid, string content);
        public event LoadPost_Profile OnLoadPost_Profile;

        public UCProfile(Profile profile, int isFriend)// 0 - NotFriend | 1 - Friend | 2 - CurrentUser
        {
            InitializeComponent();
            LoadDisplay(profile, isFriend);
        }


        private void LoadDisplay(Profile profile, int isFriend)
        {
            //add ProfileControl
            UCProfile_InfoBox uCProfile_InfoBox = new UCProfile_InfoBox(profile,isFriend);
            pnlProfile_Infor.Controls.Add(uCProfile_InfoBox);
            uCProfile_InfoBox.OnChangeAvatar += (i) => OnChangeAvatar(i);
            uCProfile_InfoBox.OnAddFriend += () => OnAddFriend(this.Tag.ToString());
            uCProfile_InfoBox.OnDelFriend += () => OnDelFriend(this.Tag.ToString());
            //
            //add UCaddPost
            UCAddPost uCAddPost = new UCAddPost();
            uCAddPost.OnAddPost += (content)=> OnLoadPost_Profile(this.Tag.ToString(),content);
            //
            //

        }

    }
}
