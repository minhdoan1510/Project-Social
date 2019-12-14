using System;
using System.Data;
using DTO;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace DAL
{
    public class DAL_Controls : ConnectToDTB
    {
        #region Handle_Login
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
            SqlCommand sql = new SqlCommand(query, _conn);
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


            //Logined
            string query = string.Format
                (@"
                SELECT Profile.*
                FROM dbo.ACCOUNT AS acc, dbo.PROFILE AS Profile 
                WHERE acc.ID = '{0}' AND acc.PASS = '{1}' AND Profile.UIDuser = acc.UID
                ", account.Username, account.Password);
            //", "nkoxway49", "123");       
            SqlDataAdapter sqlData = new SqlDataAdapter(query, _conn);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            _conn.Close();
            return dataTable;
        }
        #endregion

        #region Handle_fMain
        public DataTable LoadPost_fMain(string UID)
        {
            _conn.Open();
            string query = string.Format
                (@"
                SELECT Post.IDUSER,Post.IDPOST,Post.LIKED,Post.CONTENT,Post.IMAGE,Post.TIME, Profile.NAME, Profile.AVATAR
                FROM dbo.POST AS Post, dbo.PROFILE AS Profile
                WHERE  Post.IDUSER = '{0}' AND Post.IDUSER=Profile.UIDuser
                UNION ALL
                SELECT Post.IDUSER,Post.IDPOST,Post.LIKED,Post.CONTENT,Post.IMAGE,Post.TIME, Profile.NAME, Profile.AVATAR
                FROM dbo.POST AS Post
                INNER JOIN dbo.FRIEND AS Friend  ON (Friend.UID1 = '{0}'AND Friend.UID2 = Post.IDUSER)OR(Friend.UID2 = '{0}'AND Friend.UID1 = Post.IDUSER)
                INNER JOIN dbo.PROFILE AS Profile on Post.IDUSER=Profile.UIDuser
                ORDER BY Post.TIME
                ", UID);
            DataTable dataTable = new DataTable();
            SqlDataAdapter sql = new SqlDataAdapter(query, _conn);
            sql.Fill(dataTable);
            _conn.Close();
            return dataTable;
        }
        public DataTable LoadAllPosts()
        {
            _conn.Open();
            string query = string.Format
                (@"SELECT Post.IDUSER,Post.IDPOST,Post.LIKED,Post.CONTENT,Post.IMAGE,Post.TIME, Profile.NAME, Profile.AVATAR 
                    FROM dbo.POST AS Post, dbo.PROFILE AS Profile 
                    WHERE Post.IDUSER=Profile.UIDuser
                    ORDER BY Post.TIME ASC
                    ");
            DataTable dataTable = new DataTable();
            SqlDataAdapter sql = new SqlDataAdapter(query, _conn);
            sql.Fill(dataTable);
            _conn.Close();
            return dataTable;
        }


        public DataTable GetMailboxlist(string id)
        {
            DataTable data = new DataTable();
            try
            {
                _conn.Open();
                string query = @"EXEC GetMailboxlist @IDuser";
                SqlCommand sql = new SqlCommand(query, _conn);

                string[] temp = query.Split(' ');
                foreach (string item in temp)
                {
                    if (item.Contains("@"))
                        sql.Parameters.AddWithValue(item, id);
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql);
                sqlDataAdapter.Fill(data);
                return data;
            }
            catch
            {
                return null;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool SendMess(string content, string idmess, string idmessbox, string uid)
        {
            DataTable data = new DataTable();
            try
            {
                _conn.Open();
                string query = @"EXEC AddMess @IDmessbox , @IDmess , @UIDsend , @Content";
                SqlCommand sql = new SqlCommand(query, _conn);

                string[] parameter = new string[] { idmessbox, idmess, uid, content };
                string[] temp = query.Split(' ');
                int i = 0;
                foreach (string item in temp)
                {
                    if (item.Contains("@"))
                        sql.Parameters.AddWithValue(item, parameter[i++]);
                }

                if (sql.ExecuteNonQuery() > 0)
                    return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable GetMessinMessbox(string idMess)
        {
            DataTable data = new DataTable();
            try
            {
                _conn.Open();
                string query = @"EXEC GetMessinMessbox @IDmess";
                SqlCommand sql = new SqlCommand(query, _conn);

                string[] temp = query.Split(' ');
                foreach (string item in temp)
                {
                    if (item.Contains("@"))
                        sql.Parameters.AddWithValue(item, idMess);
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql);
                sqlDataAdapter.Fill(data);
                return data;
            }
            catch
            {
                return null;
            }
            finally
            {
                _conn.Close();
            }
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

        public bool AddLike(string IdPost,string IdUser)
        {
            try
            {
                _conn.Open();
                string query = string.Format
                  (@"
                  INSERT INTO dbo.posts_like_list
                  (
                      IDPOST,
                      IDUSER
                  )
                  VALUES
                  (   '{0}',       -- IDPOST - varchar(30)
                      '{1}'      -- IDUSER - varchar(30)
                  )
                  ", IdPost, IdUser);
                SqlCommand sql = new SqlCommand(query, _conn);
                if (sql.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch(Exception)
            {
                
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool UnLike(string IdPost, string IdUser)
        {
            try
            {
                _conn.Open();
                string query = string.Format
                  (@"
                  DELETE FROM dbo.posts_like_list
                  WHERE IdPost = '{0}'
                  AND IdUser = '{1}'
                 
                  ", IdPost, IdUser);
                SqlCommand sql = new SqlCommand(query, _conn);
                if (sql.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
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
                    ORDER BY Post.TIME
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
                    ", comment.IdComment, comment.IdPost, comment.Content, comment.IdUser);
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

        public DataTable LoadLikesof(string iDPost)
        {
            try
            {
                string query = string.Format
                    (@"
                    SELECT IdUser FROM dbo.posts_like_list
                    WHERE IdPost = '{0}'
                    ", iDPost);
                SqlDataAdapter sqlData = new SqlDataAdapter(query, _conn);
                DataTable data = new DataTable();
                sqlData.Fill(data);
                return data;
            }
            catch(Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return null;
        }
        public DataTable GetPeople(string UID)
        {
            try
            {
                _conn.Open();
                string query = string.Format
                    (@"
                    SELECT *
                    FROM dbo.PROFILE
                    WHERE UIDuser != '{0}'
                    ", UID);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, _conn);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
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

        public DataTable GetMessfromIDMess(string idmess)
        {
            DataTable data = new DataTable();
            try
            {
                _conn.Open();
                string query = @"EXEC GetMessfromIDMess @IDmess";
                SqlCommand sql = new SqlCommand(query, _conn);

                string[] temp = query.Split(' ');
                foreach (string item in temp)
                {
                    if (item.Contains("@"))
                        sql.Parameters.AddWithValue(item, idmess);
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql);
                sqlDataAdapter.Fill(data);
                return data;
            }
            catch
            {
                return null;
            }
            finally
            {
                _conn.Close();
            }
        }

        #endregion

        #region Handle_Profile

        public DataTable GetListFriend(string UID)
        {
            try
            {
                _conn.Open();
                string query = string.Format
                    (@"
                    SELECT *
                    FROM dbo.FRIEND
                    WHERE UID1='{0}'OR UID2='{0}'
                    ", UID);
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

        private byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();

            }
        }
        public bool ChangeAvatar(Profile profile)
        {
            _conn.Open();
            using (var command = _conn.CreateCommand())
            {
                command.CommandText = string.Format("UPDATE dbo.PROFILE SET AVATAR = @avatar WHERE UIDuser = '{0}'", profile.Uid);
                command.Parameters.AddWithValue("@avatar", ConvertImageToBinary(profile.Avatar));
                if (command.ExecuteNonQuery() > 0)
                    return true;
            }

            return false;

            //using (var ms = new MemoryStream())
            //{
            //    profile.Avatar.Save(ms, profile.Avatar.RawFormat);
            //    byte[] temp = ms.ToArray();
            //    ms.Read(temp, 0, temp.Length);
            //    try
            //    {
            //        _conn.Open();
            //        string query = string.Format
            //            (@"
            //        UPDATE dbo.PROFILE 
            //        SET AVATAR = '{0}' 
            //        WHERE UIDuser = '{1}'
            //        ", temp, profile.Uid);
            //        SqlCommand sqlCommand = new SqlCommand(query, _conn);
            //        if (sqlCommand.ExecuteNonQuery() > 0)
            //        {
            //            return true;
            //        }
            //    }
            //    catch
            //    {

            //    }
            //    finally
            //    {
            //        _conn.Close();
            //    }
            //    return false;
            //}
        } // Đang bị lỗi

        public bool AddFriend(string UID1, string UID2)
        {
            try
            {
                _conn.Open();
                string query = string.Format(@"INSERT dbo.FRIEND(UID1, UID2) VALUES('{0}', '{1}')", UID1, UID2);
                SqlCommand sqlCommand = new SqlCommand(query, _conn);
                if (sqlCommand.ExecuteNonQuery() > 0)
                    return true;
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

        public bool DelFriend(string UID1, string UID2)
        {
            try
            {
                _conn.Open();
                string query = string.Format(@"DELETE FROM dbo.FRIEND WHERE (UID1 = '{0}'AND UID2 = '{1}')OR (UID1 = '{1}'AND UID2 = '{0}')", UID1, UID2);
                SqlCommand sqlCommand = new SqlCommand(query, _conn);
                if (sqlCommand.ExecuteNonQuery() > 0)
                    return true;
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

        public DataTable GetProfile(string UID)
        {
            try
            {
                _conn.Open();
                string query = string.Format
                    (@"
                        SELECT *
                        FROM dbo.PROFILE
                        WHERE UIDuser = '{0}'
                    ", UID);
                SqlDataAdapter sqlData = new SqlDataAdapter(query, _conn);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                return dataTable;
            }
            catch (SqlException)
            {

            }
            finally
            {
                _conn.Close();
            }

            return null;
        }

        public bool AlterProfile(Profile profile)
        {

            _conn.Open();
            using (var command = _conn.CreateCommand())
            {
                try
                {
                    command.CommandText = string.Format(
                    "UPDATE PROFILE SET NGSINH = '{0}',SODT = '{1}',EMAIL='{2}',QUEQUAN=N'{3}',HONNHAN='{4}' WHERE UIDuser = '{5}'",
                    profile.DateOfBirth.ToLocalTime(), profile.PhoneNum, profile.Email, profile.HomeTown, profile.MarriageSt, profile.Uid);
                    if (command.ExecuteNonQuery() > 0)
                        return true;
                }
                catch (SqlException)
                {
                }
                finally
                {
                    _conn.Close();
                }
            }

            return false;


        }

        #endregion

        #region Handle_Notify

        public bool SaveNotifyInDTB(Notify notify)
        {
            try
            {
                _conn.Open();

                string query = @"EXEC AddNotify  @IDNotify , @IDPost , @Content , @IDuser , @TypeNotify";
                SqlCommand sql = new SqlCommand(query, _conn);
                sql.Parameters.AddWithValue("@IDNotify", notify.IDNotify);
                sql.Parameters.AddWithValue("@IDPost", notify.IDPost);
                sql.Parameters.AddWithValue("@Content", notify.IDPost);
                sql.Parameters.AddWithValue("@IDuser", notify.SendUID);
                sql.Parameters.AddWithValue("@TypeNotify", notify.TypeNotify);
                if (sql.ExecuteNonQuery() > 0)
                    return true;
            }
            catch 
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable GetAllNotifyofUser(string UID)
        {

            try
            {
                _conn.Open();
                DataTable data = new DataTable();
                string query = @"EXEC GetAllNotifyofUser @IDuser";
                SqlCommand sql = new SqlCommand(query, _conn);
                sql.Parameters.AddWithValue("@IDuser", UID);
                SqlDataAdapter sqlData = new SqlDataAdapter(sql);
                sqlData.Fill(data);
                return (data);
            }
            catch
            {
                return null;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable GetOnlyOneNotify(string IDNotify)
        {
            try
            {
                _conn.Open();

                DataTable data = new DataTable();
                string query = @"EXEC GetOnlyOneNotify @IDNotify";
                SqlCommand sql = new SqlCommand(query, _conn);
                sql.Parameters.AddWithValue("@IDNotify", IDNotify);
             

                SqlDataAdapter sqlData = new SqlDataAdapter(sql);
                sqlData.Fill(data);
                return data;
            }
            catch 
            {
                return null;
            }
            finally
            {
                _conn.Close();
            }
        }

        #endregion
    }
}



