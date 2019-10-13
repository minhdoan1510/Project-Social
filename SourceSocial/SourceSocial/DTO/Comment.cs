using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Comment
    {
        private string idPost;
        private string idUser;
        private string idComment;
        private string content;
        private string time;
        private string name;
        private Bitmap avatar;

        public string IdPost { get => idPost; set => idPost = value; }
        public string IdUser { get => idUser; set => idUser = value; }
        public string IdComment { get => idComment; set => idComment = value; }
        public string Content { get => content; set => content = value; }
        public string Time { get => time; set => time = value; }
        public string Name { get => name; set => name = value; }
        public Bitmap Avatar { get => avatar; set => avatar = value; }
    }
}
