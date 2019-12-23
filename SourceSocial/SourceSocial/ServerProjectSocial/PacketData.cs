using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerProjectSocial
{
    enum TypePacket { Messenger, Notify, RequestUID }
    public class PacketData
    {
        private int tPacket; // 0-RequestUID 1-Messenger, 2-Notify, 
        private string iDmess;
        private string uID;
        private string iDNotify;
        private string isLogined;

        public string IDmess { get => iDmess; set => iDmess = value; }
        public string UID { get => uID; set => uID = value; }
        public int TPacket { get => tPacket; set => tPacket = value; }
        public string IDNotify { get => iDNotify; set => iDNotify = value; }
        public string IsLogined { get => isLogined; set => isLogined = value; }

        public PacketData() { }

        public PacketData(string str) //struct string <flag>_<UID>_<IDmess>
        {
            string[] temp = str.Split('_');
            TPacket = Convert.ToInt32(temp[0]);
            switch (TPacket)
            {
                case 0:
                    try
                    {
                        UID = temp[1];
                    }
                    catch { UID = string.Empty; }
                    break;
                case 1:
                    try
                    {
                        UID = temp[1];
                    }
                    catch { UID = string.Empty; break; }

                    try
                    {
                        IDmess = temp[2];
                    }
                    catch { IDmess = string.Empty; }
                    break;

                case 2:
                    IDNotify = temp[1];
                    break;
                case 5:
                    IsLogined = temp[1];
                    break;
                default:
                    break;
            }
        }
    }
}
