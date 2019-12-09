using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServerProjectSocial
{
    public class DetailClientSocket
    {
        Socket socket;
        string uID;
        DateTime timeConnect;

        public DetailClientSocket(Socket _socket, string _UID)
        {
            TimeConnect = DateTime.Now;
            UID = _UID;
            Socket = _socket;
        }

        public Socket Socket { get => socket; set => socket = value; }
        public string UID { get => uID; set => uID = value; }
        public DateTime TimeConnect { get => timeConnect; set => timeConnect = value; }
    }
}
