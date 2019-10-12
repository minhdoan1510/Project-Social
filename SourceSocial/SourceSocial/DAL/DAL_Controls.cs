using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data;
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
                    '{3}',  -- NAME - varchar(20)
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
                SELECT * FROM
                dbo.ACCOUNT
                WHERE ID = '{0}' AND PASS = '{1}'
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
                  '{2}',       -- CONTENT - text
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
    }


}
