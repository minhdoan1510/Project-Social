using BUS;
using DTO;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fLogin
{
    public partial class fMain : MaterialForm
    {
        #region Propertion
        BUS_Controls BUS_Controls;

        UCProfile DisplayProfile;
        UCDisplayWeather uCDisplayWeather;
        Form formMess;               NotificationList formNotify;
        NotificationBox notification;
        UCDisplayUserOnline uCDisplayUserOnline;
        UCMainHeader uCMainHeader;
        WebClient web = new WebClient();

        #endregion

        public fMain(BUS_Controls _BUS_Controls)
        {
            InitializeComponent();
          

            BUS_Controls = _BUS_Controls;
            this.BackColor = Color.FromArgb(249, 249, 249);
            LoadAnimation();

            LoadDatafMain();

            BUS_Controls.HaveNewMesseger += BUS_Controls_HaveNewMesseger;
            BUS_Controls.HaveNewNotify += BUS_Controls_HaveNewNotify;            BUS_Controls.GetUserOnline += BUS_Controls_GetUserOnline;


            new Thread(() => GetWeather()).Start();

        }

        /// <summary>
        /// khu vực thời tiết
        /// </summary>
        async void GetWeather()
        {
            GPSLocation.WeatherForecast.initClient();
            GPSLocation.weather_data.RootObject val = await
                GPSLocation.WeatherForecast.requestWeather();

            if (uCDisplayWeather == null)
            {
                uCDisplayWeather = new UCDisplayWeather();
                Invoke(new Action(() =>
                    {
                        pnlWeather.Controls.Add(uCDisplayWeather);
                    }
                ));
            }
            Invoke(new Action(() =>
                {
                    string temp = string.Format(Application.StartupPath + string.Format(@"\PictureWeather\{0}.png", val.weather[0].icon));
                    if (!File.Exists(temp))
                        web.DownloadFile(GPSLocation.WeatherForecast.iconUrl + val.weather[0].icon + ".png", temp);
                    Image image = Bitmap.FromFile(Application.StartupPath + string.Format(@"\PictureWeather\{0}.png", val.weather[0].icon));
                    uCDisplayWeather.ImageWeather = image;
                    uCDisplayWeather.ViTri = val.sys.country + ", " + val.name;
                    uCDisplayWeather.NhietDo = (val.main.temp - 273.15).ToString() + " độ C";
                    uCDisplayWeather.DoAm = val.main.humidity.ToString() + "%";
                    //pnlWeather.Controls.Remove(ucLoadingWeather);
                }
                ));
        }
        /// <summary>
        /// OnlineUser
        /// </summary>
        /// <param name="TOnlineUserPacket"></param>
        /// <param name="listOnline"></param>
        private void BUS_Controls_GetUserOnline(int TOnlineUserPacket, List<KeyValuePair<string, string>> listOnline)
        {
            if (TOnlineUserPacket == 0)
            {
                foreach (KeyValuePair<string, string> item in listOnline)
                {
                    Invoke(new Action(() =>
                    {
                        uCDisplayUserOnline.AddUserOnline(item.Value, item.Key);
                    }));
                }
            }
            else if (TOnlineUserPacket == 1)
                Invoke(new Action(() =>
                {
                    uCDisplayUserOnline.AddUserOnline(listOnline[0].Value, listOnline[0].Key);
                }));
            else
                Invoke(new Action(() =>
                {
                    uCDisplayUserOnline.DelUserOnline(listOnline[0].Key);
                }));

        }
        /// <summary>
        /// Notify
        /// </summary>
        /// <param name="notify"></param>
        private void BUS_Controls_HaveNewNotify(Notify notify)
        {
            notification = new NotificationBox(notify, BUS_Controls.Profilecurrent.Uid);
            notification.StartPosition = FormStartPosition.CenterParent;
            notification.ShowDialog();

        }
        /// <summary>
        /// Messsenger
        /// </summary>
        /// <param name="messin"></param>
        private void BUS_Controls_HaveNewMesseger(MessinMessbox messin)
        {
            if (formMess == null)
            {
                Notify temp = new Notify()
                {
                    TypeNotify = 3,
                    SendName = BUS_Controls.GetProfile(messin.UidSend).Name
                };
                BUS_Controls_HaveNewNotify(temp);
            }
            foreach (UCMessengerDisplay item in formMess.Controls)
            {
                try
                {
                    item.AddMess(messin);


                }
                catch { }
            }            


        }

        #region Animation
        private void LoadAnimation()
        {
            //Exit change color
            //

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;

            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red800, MaterialSkin.Primary.Red700, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);


            //
            //Text holder in my post

        }
        #endregion


        #region Load_MainDisplay
        private async void LoadDatafMain()
        {
            UCAddPost post = new UCAddPost();
            post.OnAddPost += Post_OnAddPost;
            post.OnAddPost += (i) => post.LoadAnimation();
            post.Dock = DockStyle.Fill;
            pnlAddPost.Controls.Add(post);

            UCLoading ucPostloading = new UCLoading();

            this.pnlNewFeed_Main.Controls.Add(ucPostloading);


            pnlMain_Newfeed_AddPost.AutoScroll = false;
            pnlMain_Newfeed_AddPost.HorizontalScroll.Maximum = 0;
            pnlMain_Newfeed_AddPost.HorizontalScroll.Visible = false;
            pnlMain_Newfeed_AddPost.VerticalScroll.Maximum = 0;
            pnlMain_Newfeed_AddPost.VerticalScroll.Visible = false;
            pnlMain_Newfeed_AddPost.AutoScroll = true;

            LoadMainHeader();
            LoadCatalog();


            await Task.Factory.StartNew((() => LoadNewFeed()));
            this.pnlNewFeed_Main.Controls.Remove(ucPostloading);

            this.btnReload.Click += BtnReload_Click;
        }

        private async void BtnReload_Click(object sender, EventArgs e)
        {
            UCLoading uCLoading = new UCLoading();
            pnlNewFeed_Main.Controls.Add(uCLoading);
            pnlNewFeed_Main.Controls.Clear();
            uCLoading.BringToFront();

            await Task.Factory.StartNew((() => LoadNewFeed()));


        }

        private void LoadCatalog()
        {
            //UCCatalog uCCatalog = new UCCatalog(BUS_Controls.GetPeople());
            //uCCatalog.OnSelectionUser += (i) => OnOpenProfile(i);
            //this.pnlCatalog.Controls.Add(uCCatalog);

            UCAbout uCAbout = new UCAbout();
            uCAbout.Dock = DockStyle.Top;
            pnlCatalog.Controls.Add(uCAbout);

            uCDisplayUserOnline = new UCDisplayUserOnline();
            uCDisplayUserOnline.Dock = DockStyle.Bottom;
            uCDisplayUserOnline.ClickUser += (id) => OnOpenProfile(id);
            pnlCatalog.Controls.Add(uCDisplayUserOnline);

            BUS_Controls.SendRequestUserOnline();
        }

        private void LoadMainHeader()
        {
            uCMainHeader = new UCMainHeader(BUS_Controls.Profilecurrent, BUS_Controls.GetPeople());
            uCMainHeader.OnOpenProfile += OnOpenProfile;
            uCMainHeader.OnOpenNotify += () =>
            {
                formNotify = new NotificationList(BUS_Controls) { StartPosition = FormStartPosition.Manual, FormBorderStyle = FormBorderStyle.None };
                formNotify.SetDesktopLocation(MousePosition.X, MousePosition.Y);
                formNotify.OnClickNotify += (i) => DisplaySpecificPost(i);
                formNotify.ShowDialog();

            };
            uCMainHeader.OnOpenHome += () => OpenHome();

            uCMainHeader.OnOpenGame += btnGame_Click;

            uCMainHeader.OnOpenMessenger += () => fMain_OpenMessenger();
            this.pnlMainHeader.Controls.Add(uCMainHeader);
        }
        private void OpenHome()
        {
            if (DisplayProfile != null)
            {

                this.Controls.Remove(DisplayProfile);
                DisplayProfile.Dispose();
                DisplayProfile = null;
                pnlHome.Visible = true;

            }
        }


        private void DisplaySpecificPost(string IDPost)
        {
            Form form = new Form() { Size = new Size(707, 265), StartPosition = FormStartPosition.WindowsDefaultLocation /*,FormBorderStyle = FormBorderStyle.FixedToolWindow*/};
            UCPostDisplay postDisplay = CreatePostDisplay(BUS_Controls.GetPost(IDPost));
            postDisplay.OnClickLikeOutsideNewfeed += (i) => ClickLikeOutsideNewfeed(i);
            //this.pnlNewFeed_Main.Controls.OfType<UCPostDisplay>().Single(x => x.Tag.ToString() == IDPost); 
            postDisplay.Dock = DockStyle.Fill;
            form.Controls.Add(postDisplay);
            formNotify.FormClosed += (i, e) => form.ShowDialog();
            formNotify.Close();



        }

        private async Task fMain_OpenMessenger()
        {
            //Invoke(new Action(() =>
            //{
            formMess = new MaterialForm() { Size = new Size(256, 364 + 28), StartPosition = FormStartPosition.CenterScreen, Sizable = false , MaximizeBox = false};
            UCLoading uCLoadingMEssbox = new UCLoading();
            formMess.Controls.Add(uCLoadingMEssbox);


            await Task.Run(new Action(() =>
               {
                   UCMessengerDisplay uCMessengerDisplay = new UCMessengerDisplay(BUS_Controls.GetMailboxlist());
                   uCMessengerDisplay.GetMailboxlist += UCMessengerDisplay_GetMailboxlist;
                   uCMessengerDisplay.GetMessinMessbox += UCMessengerDisplay_GetMessinMessbox;
                   uCMessengerDisplay.SendMessCurrent += (i, j, uidsend) => BUS_Controls.SendMess(i, j, uidsend);
                   uCMessengerDisplay.Location = new Point(0, 25);
                   Invoke(new Action(() =>
                    {
                        formMess.Controls.Add(uCMessengerDisplay);
                        formMess.FormClosed += (i, e) => { formMess = null; };
                        formMess.Controls.Remove(uCLoadingMEssbox);
                        if (formMess.Visible != true)
                            formMess.ShowDialog();
                    }));
               }));



            //}));

        }

        private void UCProfileInfoBox_OpenSpecificMessbox(string IdMessBox, string Username, string IdUser)
        {
            formMess = new MaterialForm() { Size = new Size(256, 364 + 28), StartPosition = FormStartPosition.CenterScreen, Sizable = false };

            UCMessengerDisplay uCMessengerDisplay = new UCMessengerDisplay(BUS_Controls.GetMailboxlist());

            uCMessengerDisplay.GetMailboxlist += UCMessengerDisplay_GetMailboxlist;

            uCMessengerDisplay.GetMessinMessbox += UCMessengerDisplay_GetMessinMessbox;

            uCMessengerDisplay.SendMessCurrent += (i, j, uidsend) => BUS_Controls.SendMess(i, j, uidsend);

            uCMessengerDisplay.Location = new Point(0, 25);

            formMess.Controls.Add(uCMessengerDisplay);
            uCMessengerDisplay.UCMessengerUnit_OpenMessBox(IdMessBox, Username, IdUser);
            formMess.ShowDialog();
        }

        private object UCMessengerDisplay_GetMessinMessbox(string id)
        {
            return BUS_Controls.GetMessinMessbox(id);
        }

        private object UCMessengerDisplay_GetMailboxlist()
        {
            return BUS_Controls.GetMailboxlist();
        }
        private void LoadNewFeed()
        {
            BUS_Controls.Reload();
            Invoke(new Action(() => pnlNewFeed_Main.Controls.Clear()));
            List<Post> posts = BUS_Controls.GetPost();
            foreach (var item in posts)
            {
                if (BUS_Controls.ListFriend.Contains(item.Iduser) || item.Iduser == BUS_Controls.Profilecurrent.Uid)
                {
                    UCPostDisplay post = CreatePostDisplay(item);
                    Invoke(new Action(() => { this.pnlNewFeed_Main.Controls.Add(post); }));
                }
            }
            try
            {
                foreach (Control item in pnlNewFeed_Main.Controls.OfType<UCLoading>())
                {
                    pnlNewFeed_Main.Controls.Remove(item);
                }
            }
            catch { }
        }

        public UCPostDisplay CreatePostDisplay(Post post)
        {
            UCPostDisplay postDisplay = new UCPostDisplay(post);
            postDisplay.Dock = DockStyle.Top;
            postDisplay.Tag = post.Idpost;
            postDisplay.OnClickComment += Post_OnClickComment;
            postDisplay.OnClickOpenProfile += OnOpenProfile;
            postDisplay.OnClickLike += (iDPost, add) => BUS_Controls.AddLike_Post(iDPost, add);
            postDisplay.OnClickLikeList += (i) => ShowUserList(BUS_Controls.LoadLikesOfPost(i));
            if (BUS_Controls.LoadLikesOfPost(post.Idpost).Contains(BUS_Controls.Profilecurrent.Uid))
                postDisplay.Liked = true;
            else
                postDisplay.Liked = false;
            return postDisplay;
        }


        #region Handle_Event_MainDisplay

        private void Post_OnAddPost(string str)
        {
            Post temp = BUS_Controls.AddPost(new Post() { Content = str });
            if (temp!=null)
            {
                MessageBox.Show("Đã Đăng!!!");

                UCPostDisplay post = CreatePostDisplay(temp);
                this.pnlNewFeed_Main.Controls.Add(post);
                OpenHome();
            }
            else
                MessageBox.Show("Không thành công!!!");
        }

        public void ShowUserList(List<string> UserList)
        {
            if (UserList.Count == 0) return;
            Form l = new Form() { Text = "Danh sách", MaximizeBox = false , FormBorderStyle = FormBorderStyle.FixedDialog };
            l.AutoScroll = true;
            l.Size = new Size(350, 500);
            foreach (var item in UserList)
            {
                UCProfile_InfoBox tempInfo = new UCProfile_InfoBox(BUS_Controls, BUS_Controls.GetProfile(item), BUS_Controls.IsFriendWith(item));
                tempInfo.Dock = DockStyle.Top;
                tempInfo.LbNumFriend.Visible = false;
                tempInfo.OnDelFriend += () => BUS_Controls.DelFriend(BUS_Controls.GetProfile(item).Uid);

                tempInfo.OnAddFriend += () => BUS_Controls.AddFriend(BUS_Controls.GetProfile(item).Uid);

                tempInfo.OnInbox += (IdMessBox, Username, IdUser) => UCProfileInfoBox_OpenSpecificMessbox(IdMessBox, Username, IdUser);


                l.Controls.Add(tempInfo);
            }
            l.ShowDialog();

        }
        public void Post_OnClickComment(string IDPost)
        {

            fDisplayPost_Comment displayPost_Comment = new fDisplayPost_Comment(BUS_Controls.LoadCMTof(IDPost));
            displayPost_Comment.Tag = IDPost;
            displayPost_Comment.OnAddComment += DisplayPost_Comment_OnAddComment;
            displayPost_Comment.ShowDialog();
            this.Enabled = true;
        }
        private List<Comment> DisplayPost_Comment_OnAddComment(string idPost, string content)
        {
            return BUS_Controls.AddComment(idPost, content);
        }

        public void ClickLikeOutsideNewfeed(string IDPost)
        {
            UCPostDisplay temp = this.pnlNewFeed_Main.Controls.OfType<UCPostDisplay>().Single(x => x.Tag.ToString() == IDPost);
            temp.LikeCount = (temp.Liked.Equals(false)) ? temp.LikeCount + 1 : temp.LikeCount - 1;
            temp.Liked = !(bool)temp.Liked;
        }


        #endregion


        #endregion


        #region UC_Profile
        private void OnOpenProfile(string UID)
        {
            if (DisplayProfile != null)
            {
                DisplayProfile.Dispose();
                DisplayProfile = null;
            }
            DisplayProfile = new UCProfile(BUS_Controls, BUS_Controls.GetProfile(UID), BUS_Controls.IsFriendWith(UID));
            pnlHome.Visible = false;
            DisplayProfile.Location = pnlHome.Location;
            this.Controls.Add(DisplayProfile);
            DisplayProfile.Tag = UID;
            DisplayProfile.OnChangeAvatar += DisplayProfile_OnChangeAvatar;
            DisplayProfile.OnAddFriend += (i) => BUS_Controls.AddFriend(i);
            DisplayProfile.OnDelFriend += (i) => BUS_Controls.DelFriend(i);
            DisplayProfile.OnAddPost += (i) => Post_OnAddPost(i);

            DisplayProfile.OnViewFriend += (i) => ShowUserList(BUS_Controls.GetListFriend(i));

            DisplayProfile.Post_OnClickComment += (i) => Post_OnClickComment(i);

            DisplayProfile.OnClickLikeList += (i) => ShowUserList(BUS_Controls.LoadLikesOfPost(i));

            DisplayProfile.OnInbox += (IdMessBox, Username, IdUser) => UCProfileInfoBox_OpenSpecificMessbox(IdMessBox, Username, IdUser);

            DisplayProfile.OnClickLikeOutsideNewfeed += (i) => ClickLikeOutsideNewfeed(i);

            DisplayProfile.OnChangeProfile += (i) => ProfileDetails_OnChangeProfile(i);

            DisplayProfile.Visible = true;



        }

        private bool DisplayProfile_OnChangeAvatar(Image i)
        {
            if (BUS_Controls.ChangeAvatar(i))
            {
                foreach (UCPostDisplay item in pnlNewFeed_Main.Controls)
                {
                    if (item.Iduser.Equals(BUS_Controls.Profilecurrent.Uid))
                        item.PtbAvatar_Post.Image = i;
                }
                uCMainHeader.imageProfile = i;
                OpenHome();
                return true;
            }
            return false;
        }

        private bool ProfileDetails_OnChangeProfile(Profile profile)
        {
            if (BUS_Controls.AlterProfile(profile))
            {
                OpenHome();
                return true;
            }
            return false;
        }

        #endregion

        private void btnGame_Click()
        {
            frmMain Game = new frmMain();
            Game.OnShareHighScore += (i) => Post_OnAddPost(string.Format(BUS_Controls.Profilecurrent.Name + " đã đạt {0} điểm khi chơi Eye Color Test! ", i));
            Game.Show();

        }
    }
}
