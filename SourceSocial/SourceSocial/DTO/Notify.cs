using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Notify
    {
        private string iDNotify;
        private string iDPost;
        private string content;
        private string sendName;
        private string receiveName;
        private string receiveUID;
        private string sendUID;
        private int typeNotify;
        private DateTime time;
        public string IDNotify { get => iDNotify; set => iDNotify = value; }
        public string IDPost { get => iDPost; set => iDPost = value; }
        public string Content { get => content; set => content = value; }
        public string SendName { get => sendName; set => sendName = value; }
        public string ReceiveName { get => receiveName; set => receiveName = value; }
        public string ReceiveUID { get => receiveUID; set => receiveUID = value; }
        public string SendUID { get => sendUID; set => sendUID = value; }
        public int TypeNotify { get => typeNotify; set => typeNotify = value; }
        public DateTime Time { get => time; set => time = value; }
    }
}
