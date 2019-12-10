﻿using DAL;
using DTO;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Controls
    {
        #region Propertion
        private Network network;
        private List<Post> posts;
        private List<KeyValuePair<string, List<Comment>>> comments;
        private Profile profilecurrent;
        private DAL_Controls dal;
        private List<string> listFriend;
        private List<string> listUser;
        public Profile Profilecurrent { get => profilecurrent; set => profilecurrent = value; }
        public List<string> ListFriend { get => listFriend; set => listFriend = value; }

   

        public delegate void OnHaveNewMesseger(MessinMessbox messin);
        public event OnHaveNewMesseger HaveNewMesseger;


        #endregion

        public BUS_Controls()
        {
            posts = new List<Post>();
            comments = new List<KeyValuePair<string, List<Comment>>>();
            Profilecurrent = new Profile();
            dal = new DAL_Controls();
            ListFriend = new List<string>();

        }

        #region Handle Network

        private void Network_OnHavePacket(string obj)
        {
            PacketData packet = new PacketData(obj);
            switch (packet.TPacket)
            {
                case 1:
                    try
                    {
                        MessinMessbox messin = new MessinMessbox(); 
                        DataTable data = dal.GetMessfromIDMess(packet.IDmess);
                        messin.IDmessBox = data.Rows[0].ItemArray[1].ToString();
                        messin.IDmess = data.Rows[0].ItemArray[0].ToString();
                        messin.Content = data.Rows[0].ItemArray[2].ToString();
                        messin.Time = (DateTime)data.Rows[0].ItemArray[4];
                        messin.UidSend = data.Rows[0].ItemArray[5].ToString();
                        messin.Avatar = ConverttoImage(data.Rows[0].ItemArray[0]);
                        if (HaveNewMesseger != null)
                            HaveNewMesseger(messin);
                    }
                    catch { }

                    break;
                case 2:

                    break;

                case 0:
                    packet.UID = Profilecurrent.Uid;
                    network.Send(EncodePacketData(packet));
                    break;
            }
        }
        public bool SendMess(string content, string idmessbox, string uidsend)
        {
            string idmess = new Random().Next(10000000, 99999999).ToString();
            if (dal.SendMess(content, idmess, idmessbox, Profilecurrent.Uid))
            {
                network.Send(EncodePacketData(new PacketData() { IDmess = idmess, UID = uidsend, TPacket = 1 }));
                return true;
            }
            else
                return false;
        }


        public string EncodePacketData(PacketData packet)
        {
            string temp = string.Empty;
            switch (packet.TPacket)
            {
                case 0:
                    temp = packet.TPacket.ToString();
                    temp += (packet.UID != string.Empty) ? ("_" + packet.UID) : "";
                    return temp;
                case 1:
                    temp = packet.TPacket.ToString();
                    temp += (packet.UID != string.Empty) ? ("_" + packet.UID) : "";
                    temp += (packet.IDmess != string.Empty) ? ("_" + packet.IDmess) : "";
                    return temp;
                case 2:

                    break;
                case 3:
                    break;
            }
            return string.Empty;
        }


        #endregion

        #region Handle_Login
        public bool SignUp(Account account)
        {
            if (CheckAccount_SignUp(account))
            {
                return dal.SignUp(account);
            }
            return false;
        }
        private bool CheckAccount_SignUp(Account account)
        {
            return true;
        }
        public bool SigIn(Account account)
        {
            if (CheckAccount_SignIn(account))
            {
                DataTable data = dal.SignIn(account);
                if (data.Rows.Count == 1)
                {
                    LoadDataPost(data.Rows[0].ItemArray[0].ToString());
                    ListFriend = LoadDataListFriend(data.Rows[0].ItemArray[0].ToString());
                    Profilecurrent.Uid = data.Rows[0].ItemArray[0].ToString();
                    Profilecurrent.Name = data.Rows[0].ItemArray[1].ToString();
                    Profilecurrent.Avatar = ConverttoImage(data.Rows[0].ItemArray[2]) ?? Bitmap.FromFile(System.Windows.Forms.Application.StartupPath + @"\Picture\NoAvatar.png");
                    Profilecurrent.DateOfBirth = (DateTime)data.Rows[0].ItemArray[3];
                    Profilecurrent.PhoneNum = data.Rows[0].ItemArray[4].ToString();
                    Profilecurrent.Email = data.Rows[0].ItemArray[5].ToString();
                    Profilecurrent.HomeTown = data.Rows[0].ItemArray[6].ToString();
                    Profilecurrent.MarriageSt = data.Rows[0].ItemArray[7].ToString();
                    network = new Network();
                    network.OnHavePacket += Network_OnHavePacket;
                    return true;
                }
            }
            return false;
        }

        private bool CheckAccount_SignIn(Account account)
        {
            return true;
        }
        #endregion

        #region Handle_fMain
        public List<Post> GetPost()
        {
            return posts;
           
        }
        private void LoadDataPost(string UID)
        {
            DataTable data = dal.LoadAllPosts();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Post temp = new Post();
                temp.Iduser = data.Rows[i].ItemArray[0].ToString();
                temp.Idpost = data.Rows[i].ItemArray[1].ToString();
                temp.Liked = (int)data.Rows[i].ItemArray[2];
                temp.Content = data.Rows[i].ItemArray[3].ToString();
                temp.Image = ConverttoImage(data.Rows[i].ItemArray[7]) ?? Bitmap.FromFile(System.Windows.Forms.Application.StartupPath + @"\Picture\NoAvatar.png");
                temp.Time = data.Rows[i].ItemArray[5].ToString();
                temp.Name = data.Rows[i].ItemArray[6].ToString();
                posts.Add(temp);
            }
        }


        public object GetMailboxlist()
        {
            DataTable data = dal.GetMailboxlist(Profilecurrent.Uid);

            List<Mailboxlist> mailboxlists = new List<Mailboxlist>();

            for (int i=0;i<data.Rows.Count;i++)
            {
                Mailboxlist temp = new Mailboxlist();
                temp.Avatar = ConverttoImage(data.Rows[i].ItemArray[2]) ?? Bitmap.FromFile(System.Windows.Forms.Application.StartupPath + @"\Picture\NoAvatar.png");
                temp.IDmessbox = data.Rows[i].ItemArray[0].ToString();
                temp.Iduser = data.Rows[i].ItemArray[3].ToString();
                temp.Lastcontent = data.Rows[i].ItemArray[4].ToString();
                temp.Nameuser = data.Rows[i].ItemArray[1].ToString();
                mailboxlists.Add(temp);
            }

            return mailboxlists;

        }

        public object GetMessinMessbox(string id)
        {
            DataTable data = dal.GetMessinMessbox(id);

            List<MessinMessbox> messinMessbox = new List<MessinMessbox>();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                MessinMessbox temp = new MessinMessbox();
                temp.Avatar = ConverttoImage(data.Rows[i].ItemArray[6]) ?? Bitmap.FromFile(System.Windows.Forms.Application.StartupPath + @"\Picture\NoAvatar.png");
                temp.IDmess = data.Rows[i].ItemArray[0].ToString();
                temp.IDmessBox = data.Rows[i].ItemArray[1].ToString();
                temp.UidSend = data.Rows[i].ItemArray[5].ToString();
                temp.Content = data.Rows[i].ItemArray[2].ToString();
                temp.Time = (DateTime)data.Rows[i].ItemArray[4];
                temp.IsMe = temp.UidSend == Profilecurrent.Uid;
                messinMessbox.Add(temp);
            }

            return messinMessbox;

        }

        public bool AddPost(Post post)
        {
            post.Idpost = new Random().Next(10000000, 99999999).ToString();
            post.Iduser = Profilecurrent.Uid;
            post.Name = Profilecurrent.Name;
            post.Image = profilecurrent.Avatar;
            post.Time = "Vừa xong";
            if (dal.AddPost(post))
            {
                posts.Add(post);
                return true;
            }
            return false;
        }
        public List<Comment> LoadCMTof(string idPost)
        {
            foreach (var item in comments)
            {
                if (item.Key == idPost)
                {
                    return item.Value;
                }
            }
            return LoadAddCMTof(idPost);
        }
        public List<Comment> LoadAddCMTof(string IDPost)
        {
            List<Comment> commentofpost = new List<Comment>();
            DataTable data = dal.LoadCMTof(IDPost);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Comment comment = new Comment();
                comment.IdUser = data.Rows[i].ItemArray[0].ToString();
                comment.Name = data.Rows[i].ItemArray[1].ToString();
                comment.Avatar = ConverttoImage(data.Rows[i].ItemArray[2]) ?? Bitmap.FromFile(System.Windows.Forms.Application.StartupPath + @"\Picture\NoAvatar.png");
                comment.IdPost = data.Rows[i].ItemArray[3].ToString();
                comment.IdComment = data.Rows[i].ItemArray[4].ToString();
                comment.Content = data.Rows[i].ItemArray[5].ToString();
                comment.Time = data.Rows[i].ItemArray[6].ToString();
                commentofpost.Add(comment);
            }
            comments.Add(new KeyValuePair<string, List<Comment>>(IDPost, commentofpost));
            return commentofpost;
        }
        public List<Comment> AddComment(string idPost, string content)
        {
            Comment comment = new Comment()
            {
                IdUser = Profilecurrent.Uid,
                Name = Profilecurrent.Name,
                IdPost = idPost,
                Content = content,
                Time = "Vừa xong",
                Avatar = profilecurrent.Avatar,
                IdComment = new Random().Next(10000000, 99999999).ToString()
            };
            if (dal.AddComment(comment))
            {
                foreach (var item in comments)
                {
                    if (item.Key == idPost)
                    {
                        item.Value.Add(comment);
                        return item.Value;
                    }
                }
            }
            return null;
        }


        #endregion

        #region Handle_Profile
        private List<string> LoadDataListFriend(string UID)
        {
            List<string> temp= new List<string>();
            DataTable data = dal.GetListFriend(UID);
            if (data == null)
                return null;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                temp.Add(data.Rows[i].ItemArray[((data.Rows[i].ItemArray[0].ToString() == UID) ? 1 : 0)].ToString());
            }
            return temp;

        }
        public List<string> GetListFriend(string UID)
        {
            if (UID == Profilecurrent.Uid)
                return ListFriend;
            return LoadDataListFriend(UID);
        }
        public int numOfFriend(string UID)
        {
            if (UID == Profilecurrent.Uid)
                return ListFriend.Count;
            return LoadDataListFriend(UID).Count;
        }
        public Profile GetProfile(string UID)
        {
            if (UID == profilecurrent.Uid)
                return profilecurrent;
            return LoadDataProfile(UID);
        }

        private Profile LoadDataProfile(string UID)
        {
            
            DataTable dataTable = dal.GetProfile(UID);
            if (dataTable == null)
                return null;
            Profile profile = new Profile();
            profile.Uid = UID;
            profile.Name = dataTable.Rows[0].ItemArray[1].ToString();
            profile.Avatar = ConverttoImage(dataTable.Rows[0].ItemArray[2]) ?? Bitmap.FromFile(System.Windows.Forms.Application.StartupPath + @"\Picture\NoAvatar.png");
            profile.DateOfBirth = ((DateTime)dataTable.Rows[0].ItemArray[3]).ToLocalTime();
            profile.PhoneNum = dataTable.Rows[0].ItemArray[4].ToString();
            profile.Email = dataTable.Rows[0].ItemArray[5].ToString();
            profile.HomeTown = dataTable.Rows[0].ItemArray[6].ToString();
            profile.MarriageSt =  dataTable.Rows[0].ItemArray[7].ToString();
     
            return profile;
        }

        public int IsFriendWith(string UID)// 0 - NotFriend | 1 - Friend | 2 - CurrentUser
        {
            if (UID == Profilecurrent.Uid)
                return 2;
            var temp = ListFriend.Where(x => x == UID).SingleOrDefault();
            if (temp != null)
                return 1;
            return 0;
        }
        public bool AlterProfile(Profile profile)
        {
            return dal.AlterProfile(profile);
        }

        public bool AddFriend(string i)
        {
            if (dal.AddFriend(Profilecurrent.Uid, i))
            {
                ListFriend.Add(i);
                return true;
            }
            return false;
        }
        public bool DelFriend(string i)
        {
            if (dal.DelFriend(i, Profilecurrent.Uid))
            {
                ListFriend.Remove(i);
                return true;
            }
            return false;
        }
        public bool ChangeAvatar(Image image)
        {
            if (dal.ChangeAvatar(new Profile() { Uid = Profilecurrent.Uid, Avatar = image }))
            {
                Profilecurrent.Avatar = image;
                foreach (Post item in posts)
                {
                    if (item.Iduser == profilecurrent.Uid)
                        item.Image = profilecurrent.Avatar;
                }
                return true;
                
            }
            return false;
        }

        #endregion

        #region Handle_Other
        public List<KeyValuePair<string, string>> GetPeople()
        {
            DataTable dataTable = dal.GetPeople(profilecurrent.Uid);
            List<KeyValuePair<string, string>> temp = new List<KeyValuePair<string, string>>();
            for(int i=0;i<dataTable.Rows.Count;i++)
            {
                KeyValuePair<string, string> key = new KeyValuePair<string, string>(dataTable.Rows[i].ItemArray[0].ToString(), dataTable.Rows[i].ItemArray[1].ToString());
                temp.Add(key);
            }
            return temp;
        }
        public Image ConverttoImage(object byteArray)
        {
            try
            {
                byte[] byteArrayIn = (byte[])byteArray;
                Image returnImage;
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true);//Exception occurs here
                return returnImage;
            }
            catch { }
            finally
            {
            }
            return null;
        }
        //private Image ConvertBinaryToImage(byte[] data)
        //{

        //    using (MemoryStream ms = new MemoryStream(data))
        //    {
        //        return Image.FromStream(ms);
        //    }
        //}
        #endregion
    }
}
