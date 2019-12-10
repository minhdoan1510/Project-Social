using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Profile
    {
        #region Propertion
        private string uid;
        private string name;
        private Image avatar;
        private DateTime dateOfBirth;
        private string phoneNum;
        private string email;
        private string homeTown;
        private string marriageSt;



        public string Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
<<<<<<< HEAD
        public Image Avatar { get => avatar; set => avatar = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Email { get => email; set => email = value; }
        public string HomeTown { get => homeTown; set => homeTown = value; }
        public string MarriageSt { get => marriageSt; set => marriageSt = value; }
=======
        public Image Avatar { get => avatar; set => avatar = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Email { get => email; set => email = value; }
        public string HomeTown { get => homeTown; set => homeTown = value; }
        public string MarriageSt { get => marriageSt; set => marriageSt = value; }
>>>>>>> minhtien
        #endregion

        public Profile()
        {

        }
    }
}
