using System;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Controls: ConnectToDTB
    {
        public bool SignUp(Account account)
        {
            _conn.Open();
            string UID = new Random().Next(10000000, 99999999).ToString();
            string query = string.Format
                (@"
                INSERT dbo.PROFILE
                (
                    UIDuser,
                    NAME,
                    AVATAR
                )
                VALUES
                (   '{0}',  -- UIDuser - varchar(30)
                    N'{3}',  -- NAME - Nvarchar(20)
                    NULL -- AVATAR - image
                )
                INSERT dbo.ACCOUNT
                (
                    UID,
                    ID,
                    PASS
                )
                VALUES
                (   '{0}', -- UID - varchar(30)
                    '{1}', -- ID - varchar(20)
                    '{2}'  -- PASS - varchar(20)
                )
                ", UID, account.Username, account.Password, account.Name);
            SqlCommand sql = new SqlCommand(query,_conn);
            if (sql.ExecuteNonQuery() > 0)
            {
                _conn.Close();
                return true;
            }
            _conn.Close();
            return false;
        }
        public DataTable SignIn(Account account)
        {
            _conn.Open();

            string query = string.Format
                (@"
                SELECT Profile.*
                FROM dbo.ACCOUNT AS acc, dbo.PROFILE AS Profile 
                WHERE acc.ID = '{0}' AND acc.PASS = '{1}' AND Profile.UIDuser = acc.UID
                ", account.Username, account.Password);
            SqlDataAdapter sqlData = new SqlDataAdapter(query, _conn);
            DataTable dataTable= new DataTable();
            sqlData.Fill(dataTable);
            _conn.Close();
            return dataTable;
        }

        public DataTable LoadPost_fMain(string UID)
        {
            _conn.Open();
            string query = string.Format
                (@"
                SELECT Post.IDUSER,Post.IDPOST,Post.LIKED,Post.CONTENT,Post.IMAGE,Post.TIME, Profile.NAME
                FROM dbo.POST AS Post, dbo.PROFILE AS Profile
                WHERE  Post.IDUSER = '{0}' AND Post.IDUSER=Profile.UIDuser
                UNION ALL
                SELECT Post.IDUSER,Post.IDPOST,Post.LIKED,Post.CONTENT,Post.IMAGE,Post.TIME, Profile.NAME
                FROM dbo.POST AS Post
                INNER JOIN dbo.FRIEND AS Friend  ON (Friend.UID1 = '{0}'AND Friend.UID2 = Post.IDUSER)OR(Friend.UID2 = '{0}'AND Friend.UID1 = Post.IDUSER)
                INNER JOIN dbo.PROFILE AS Profile on Post.IDUSER=Profile.UIDuser
                ", UID);
            DataTable dataTable = new DataTable();
            SqlDataAdapter sql = new SqlDataAdapter(query, _conn);
            sql.Fill(dataTable);
            _conn.Close();
            return dataTable;
        }

        public bool AddPost(Post post)
        {
            try
            {
                _conn.Open();
                string query = string.Format
                  (@"
              INSERT dbo.POST
              (
                  IDPOST,
                  IDUSER,
                  LIKED,
                  CONTENT,
                  IMAGE,
                  TIME
              )
              VALUES
              (   '{0}',       -- IDPOST - varchar(30)
                  '{1}',       -- IDUSER - varchar(30)
                  0,        -- LIKED - int
                  N'{2}',       -- CONTENT - Ntext
                  NULL,     -- IMAGE - image
                  GETDATE() -- TIME - datetime
              )
              ", post.Idpost, post.Iduser, post.Content);
                SqlCommand sql = new SqlCommand(query, _conn);
                if (sql.ExecuteNonQuery() > 0)
                    return true;
            return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable LoadCMTof(string UIDpost)
        {
            try
            {
                string query = string.Format
                    (@"
                    SELECT Profile.UIDuser, Profile.NAME,Profile.AVATAR, Post.IDPOST, CMT.IDcomment, CMT.CONTENT,CMT.TIME
                    FROM dbo.COMMENT AS CMT
                    INNER JOIN dbo.PROFILE AS Profile ON Profile.UIDuser = CMT.IDuser
                    INNER JOIN dbo.POST AS Post ON Post.IDPOST = CMT.IDPOST
                    WHERE CMT.IDPOST='{0}'
                    ", UIDpost);
                SqlDataAdapter sqlData = new SqlDataAdapter(query, _conn);
                DataTable data = new DataTable();
                sqlData.Fill(data);
                return data;
            }
            catch
            {
                
            }
            finally
            {
                _conn.Close();
            }
            return null;
        }

        public bool AddComment(Comment comment)
        {
            try
            {
                _conn.Open();
                string query = string.Format
                    (@"
                    INSERT dbo.COMMENT
                    (
                        IDcomment,
                        IDPOST,
                        CONTENT,
                        TIME,
                        IDuser
                    )
                    VALUES
                    (   '{0}',        -- IDcomment - varchar(30)
                        '{1}',        -- IDPOST - varchar(30)
                        '{2}',        -- CONTENT - text
                        GETDATE(), -- TIME - datetime
                        '{3}'         -- IDuser - varchar(30)
                    )
                    ", comment.IdComment,comment.IdPost,comment.Content,comment.IdUser);
                SqlCommand sqlCommand = new SqlCommand(query, _conn);
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }


}
