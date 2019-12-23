using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

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
           
            try
            {

                return DataProvider.Instance.ExecuteQuery(@"EXEC SignIn @IDuser , @PassWord", new object[] { account.Username, account.Password });
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

        #region Handle_fMain
        public DataTable LoadPosts(string uid)
                {
                    try
                    {
                        return DataProvider.Instance.ExecuteQuery(string.Format(@"SELECT Post.IDUSER,Post.IDPOST,Post.LIKED,Post.CONTENT,Post.IMAGE,Post.TIME, Profile.NAME, Profile.AVATAR
                            FROM dbo.POST AS Post, dbo.PROFILE AS Profile
                            WHERE  Post.IDUSER = '{0}' AND Post.IDUSER=Profile.UIDuser
                            UNION ALL
                            SELECT Post.IDUSER,Post.IDPOST,Post.LIKED,Post.CONTENT,Post.IMAGE,Post.TIME, Profile.NAME, Profile.AVATAR
                            FROM dbo.POST AS Post
                            INNER JOIN dbo.FRIEND AS Friend  ON (Friend.UID1 = '{0}' AND Friend.UID2 = Post.IDUSER)OR(Friend.UID2 = '{0}'AND Friend.UID1 = Post.IDUSER)
                            INNER JOIN dbo.PROFILE AS Profile on Post.IDUSER=Profile.UIDuser
                            ORDER BY Post.TIME",uid));
                    }
                    catch {
                        return null;
                    }
                    finally
                    {
                        _conn.Close();
                    }

                }

        public DataTable LoadAllPosts()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery(@"SELECT Post.IDUSER,Post.IDPOST,Post.LIKED,Post.CONTENT,Post.IMAGE,Post.TIME, Profile.NAME, Profile.AVATAR 
                    FROM dbo.POST AS Post, dbo.PROFILE AS Profile 
                    WHERE Post.IDUSER=Profile.UIDuser
                    ORDER BY Post.TIME ASC");


            }
            catch {
                return null;
            }
            finally
            {
                _conn.Close();
            }

        }

        public DataTable GetMailboxlist(string id)
        {
            try
            {
                //return Task.Factory.StartNew(
                //    new Func<DataTable>(() => DataProvider.Instance.ExecuteQuery(@"EXEC GetMailboxlist @IDuser", new object[] { id }))
                //    ).Result;

                return DataProvider.Instance.ExecuteQuery(@"EXEC GetMailboxlist @IDuser", new object[] { id });
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
            try
            {
                return DataProvider.Instance.ExecuteNonQuery(@"EXEC AddMess @IDmessbox , @IDmess , @UIDsend , @Content", new object[] { idmessbox, idmess, uid, content }) > 0;
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

        public DataTable GetMessinMessbox(string idMess)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery(@"EXEC GetMessinMessbox @IDmess", new object[] { idMess });
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

        public string GetIdMessbox(string iDuser1, string iDuser2)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery(@"EXEC GetIdMessbox @IDuser1 , @IDuser2", new object[] { iDuser1, iDuser2 }).Rows[0].ItemArray[0].ToString();
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

        public string CreateMessBox(string iDuser1, string iDuser2)
        {
            try
            {
                string idMessBox = new Random().Next(10000000, 99999999).ToString();
                return ((DataProvider.Instance.ExecuteNonQuery(@"EXEC AddMessbox @IDmessbox , @IDuser1 , @IDuser2", new object[] { idMessBox, iDuser1, iDuser2 }) > 0) ? idMessBox : null);
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
                return DataProvider.Instance.ExecuteNonQuery(@"
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
                                                              (    @idPost ,       -- IDPOST - varchar(30)
                                                                   @idUser ,       -- IDUSER - varchar(30)
                                                                  0,        -- LIKED - int
                                                                   @Content ,       -- CONTENT - Ntext
                                                                  NULL,     -- IMAGE - image
                                                                  GETDATE() -- TIME - datetime
                                                              )
                                                              ", new object[] { post.Idpost, post.Iduser, post.Content }) > 0;
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

        public bool AddLike(string IdPost, string IdUser)
        {
            try
            {
                return DataProvider.Instance.ExecuteNonQuery(@"
                                                              INSERT INTO dbo.posts_like_list
                                                              (
                                                                  IDPOST,
                                                                  IDUSER
                                                              )
                                                              VALUES
                                                              (   @IDPOST ,       -- IDPOST - varchar(30)
                                                                  @IDUSER      -- IDUSER - varchar(30)
                                                              )
                                                              ", new object[] { IdPost, IdUser }) > 0;
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

        public bool UnLike(string IdPost, string IdUser)
        {
            try
            {
                return DataProvider.Instance.ExecuteNonQuery(@"DELETE FROM dbo.posts_like_list WHERE IdPost = @IdPost AND IdUser = @IdUser"
                                                              , new object[] { IdPost, IdUser }) > 0;
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
                return DataProvider.Instance.ExecuteQuery(@"EXEC LoadCMTof @UIDpost", new object[] { UIDpost });
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

        public bool AddComment(Comment comment)
        {
            try
            {
                return DataProvider.Instance.ExecuteNonQuery(@"EXEC AddComment @IDcomment , @IDPOST , @CONTENT , @IDuser", 
                                                        new object[] { comment.IdComment, comment.IdPost, comment.Content, comment.IdUser }) > 0;
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

        public DataTable LoadLikesof(string iDPost)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery(@"SELECT IdUser FROM dbo.posts_like_list WHERE IdPost = @iDPost", new object[] { iDPost });
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

        public DataTable GetPeople(string UID)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery(@"SELECT * FROM dbo.PROFILE WHERE UIDuser != @UID ", new object[] { UID });
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

        public DataTable GetMessfromIDMess(string idmess)
        {
            DataTable data = new DataTable();
            try
            {
                return DataProvider.Instance.ExecuteQuery(@"EXEC GetMessfromIDMess @IDmess", new object[] { idmess });
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
                return DataProvider.Instance.ExecuteQuery(@"SELECT * FROM dbo.FRIEND WHERE @UID IN (UID1,UID2)", new object[] { UID });
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
        public bool ChangeAvatar(Profile profile)
        {
            try
            {

                return DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.PROFILE SET AVATAR = @avatar WHERE UIDuser = @uid", new object[] { ConvertImageToBinary(profile.Avatar), profile.Uid }) > 0;
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

        public bool AddFriend(string UID1, string UID2)
        {
            try
            {
                return DataProvider.Instance.ExecuteNonQuery(@"INSERT dbo.FRIEND(UID1, UID2) VALUES( @uid1 , @uid2 )", new object[] { UID1, UID2 }) > 0;
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
                return DataProvider.Instance.ExecuteNonQuery(string.Format(@"DELETE FROM dbo.FRIEND WHERE (UID1 = '{0}'AND UID2 = '{1}') OR (UID1 = '{1}'AND UID2 = '{0}')", UID1, UID2)) > 0;
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

        public DataTable GetProfile(string UID)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery(@"SELECT * FROM dbo.PROFILE WHERE UIDuser = @UID", new object[] { UID });
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

        public bool AlterProfile(Profile profile)
        {
            try
            {
                return DataProvider.Instance.ExecuteNonQuery(@"UPDATE PROFILE SET NGSINH = @NS ,SODT = @Tel ,EMAIL= @email ,QUEQUAN= @Home ,HONNHAN= @MarriageSt WHERE UIDuser = @uid",
               new object[] { profile.DateOfBirth.ToLocalTime(), profile.PhoneNum, profile.Email, profile.HomeTown, profile.MarriageSt, profile.Uid }) > 0;
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

        public string GetNameUser(string uID)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery(@"SELECT dbo.PROFILE.NAME FROM dbo.PROFILE WHERE dbo.PROFILE.UIDuser = @IDuser",
                                                                new object[] { uID }).Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "";
            }
            finally
            {
                _conn.Close();
            }

        }

        #endregion

        #region Handle_Notify
        public bool SaveNotifyInDTB(Notify notify)
        {
            try
            {
                return DataProvider.Instance.ExecuteNonQuery(@"EXEC AddNotify  @IDNotify , @IDPost , @Content , @IDuser , @TypeNotify", new object[] { notify.IDNotify, notify.IDPost, notify.IDPost, notify.SendUID, notify.TypeNotify }) > 0;
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

        public DataTable GetAllNotifyofUser(string UID)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery(@"EXEC GetAllNotifyofUser @IDuser", new object[] { UID });
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
                return DataProvider.Instance.ExecuteQuery(@"EXEC GetOnlyOneNotify @IDNotify", new object[] { IDNotify });
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

        #region Handle_Other
        public string ImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to base 64 string
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();

            }
        }
        #endregion
    }
}



