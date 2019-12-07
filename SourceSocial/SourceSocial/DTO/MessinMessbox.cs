using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MessinMessbox
    {
        string iDmess, iDmessBox, uidSend, content;
        bool isMe;
        Image avatar;
        DateTime  time;

        public MessinMessbox() { }
        public MessinMessbox(string _iDmess, string _iDmessBox, string _uidSend, string _content, Image _avatar, DateTime _time, bool _isMe)
        {
            IDmess = _iDmess;
            IDmessBox = _iDmessBox;
            UidSend = _uidSend;
            Time = _time;
            Avatar = _avatar;
            Content = _content;
            IsMe = _isMe;
        }

        public string IDmess { get => iDmess; set => iDmess = value; }
        public string IDmessBox { get => iDmessBox; set => iDmessBox = value; }
        public string UidSend { get => uidSend; set => uidSend = value; }
        public string Content { get => content; set => content = value; }
        public Image Avatar { get => avatar; set => avatar = value; }
        public DateTime Time { get => time; set => time = value; }
        public bool IsMe { get => isMe; set => isMe = value; }
    }
}
