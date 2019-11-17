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

        public string Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public Image Avatar { get => avatar; set => avatar = value; }
        #endregion

        public Profile()
        {

        }
    }
}
