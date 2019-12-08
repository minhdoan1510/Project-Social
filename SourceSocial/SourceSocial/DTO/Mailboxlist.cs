using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Mailboxlist
    {
        private string iDmessbox;
        private string nameuser;
        private string lastcontent;
        private Image avatar;
        private string iduser;

        public Mailboxlist() { }

        public string IDmessbox { get => iDmessbox; set => iDmessbox = value; }
        public string Nameuser { get => nameuser; set => nameuser = value; }
        public string Lastcontent { get => lastcontent; set => lastcontent = value; }
        public Image Avatar { get => avatar; set => avatar = value; }
        public string Iduser { get => iduser; set => iduser = value; }
    }
}
