using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;
using System.Drawing;

namespace BUS
{
    public class BUS_Controls
    {
        private List<Post> posts = new List<Post>();
        DAL_Controls dal = new DAL_Controls();
        string UIDcurrent;
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
                    LoadDataPost(dal.SignIn(account).Rows[0].ItemArray[0].ToString());
                    UIDcurrent = dal.SignIn(account).Rows[0].ItemArray[0].ToString();
                    return true;
                }
            }
            return false;
        }
        private bool CheckAccount_SignIn(Account account)
        {
            return true;
        }
        private void LoadDataPost(string v)
        {
            DataTable data = dal.LoadPost_fMain(v);
            for(int i=0;i<data.Rows.Count;i++)
            {
                Post temp = new Post();
                temp.Iduser = data.Rows[i].ItemArray[0].ToString();
                temp.Idpost = data.Rows[i].ItemArray[1].ToString();
                temp.Liked = (int)data.Rows[i].ItemArray[2];
                temp.Content = data.Rows[i].ItemArray[3].ToString();
                //temp.Image = (Bitmap)data.Rows[i].ItemArray[4];
                temp.Time = data.Rows[i].ItemArray[5].ToString();
                temp.Name = data.Rows[i].ItemArray[6].ToString();
                posts.Add(temp);
            }
        }
        public bool AddPost(Post post)
        {
            post.Idpost = new Random().Next(10000000, 99999999).ToString();
            post.Iduser = UIDcurrent;
            if(dal.AddPost(post))
            {
                posts.Add(post);
                return true;
            }
            return false;
        }
        public List<Comment> LoadCMTof(string IDPost)
        {
            List<Comment> comments = new List<Comment>();
            DataTable data = dal.LoadCMTof(IDPost);
            for (int i = data.Rows.Count - 1; i >= 0; i--)
            {
                Comment comment = new Comment();
                comment.IdUser = data.Rows[i].ItemArray[0].ToString();
                comment.Name = data.Rows[i].ItemArray[1].ToString();
                //comment.Avatar = (Bitmap)data.Rows[i].ItemArray[2];
                comment.Avatar = null;
                comment.IdPost = data.Rows[i].ItemArray[3].ToString();
                comment.IdComment = data.Rows[i].ItemArray[4].ToString();
                comment.Content = data.Rows[i].ItemArray[5].ToString();
                comment.Time = data.Rows[i].ItemArray[6].ToString();
                comments.Add(comment);
            }
            return comments;
        }
    }
}
