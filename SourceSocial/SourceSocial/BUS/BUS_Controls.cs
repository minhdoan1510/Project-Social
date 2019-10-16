using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Drawing;

namespace BUS
{
    public class BUS_Controls
    {
        private List<Post> posts = new List<Post>();
        private List<KeyValuePair<string, List<Comment>>> comments=new List<KeyValuePair<string, List<Comment>>>();
        private Profile profilecurrent = new Profile();
        DAL_Controls dal = new DAL_Controls();

        public Profile Profilecurrent { get => profilecurrent; set => profilecurrent = value; }

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

        public List<Post> GetPost()
        {
            return posts;
        }

        public bool SigIn(Account account)
        {
            if (CheckAccount_SignIn(account))
            {
                DataTable data = dal.SignIn(account);
                if (data.Rows.Count == 1)
                {
                    LoadDataPost(data.Rows[0].ItemArray[0].ToString());
                    Profilecurrent.Uid = data.Rows[0].ItemArray[0].ToString();
                    Profilecurrent.Name = data.Rows[0].ItemArray[1].ToString();
                    profilecurrent.Avatar = ConverttoImage(data.Rows[0].ItemArray[2]) ?? Bitmap.FromFile(System.Windows.Forms.Application.StartupPath + @"\Picture\NoAvatar.png");
                    return true;
                }
            }
            return false;
        }
        private bool CheckAccount_SignIn(Account account)
        {
            return true;
        }
        private void LoadDataPost(string UID)
        {
            DataTable data = dal.LoadPost_fMain(UID);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Post temp = new Post();
                temp.Iduser = data.Rows[i].ItemArray[0].ToString();
                temp.Idpost = data.Rows[i].ItemArray[1].ToString();
                temp.Liked = (int)data.Rows[i].ItemArray[2];
                temp.Content = data.Rows[i].ItemArray[3].ToString();
                temp.Image = ConverttoImage(data.Rows[i].ItemArray[4]);
                temp.Time = data.Rows[i].ItemArray[5].ToString();
                temp.Name = data.Rows[i].ItemArray[6].ToString();
                posts.Add(temp);
            }
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

        public bool AddPost(Post post)
        {
            post.Idpost = new Random().Next(10000000, 99999999).ToString();
            post.Iduser = Profilecurrent.Uid;
            post.Name = Profilecurrent.Name;
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
            foreach(var item in comments)
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

        public bool ChangeAvatar(Image image)
        {
            if (dal.ChangeAvatar(new Profile() { Uid = profilecurrent.Uid, Avatar = image }))
            {
                profilecurrent.Avatar = image;
                return true;
            }
            return false;
        }
    }
}
