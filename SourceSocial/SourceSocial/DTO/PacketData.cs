using System;
using System.Collections.Generic;

namespace DTO
{
    public enum TypePacket { Messenger, Notify, RequestUID }
    public enum TypeOnlineUserPacket { Load, Add, Del }
    public class PacketData
    {
        private int tPacket; // 0-RequestUID, 1-Messenger, 2-Notify, 3-Online User
        private string iDmess;
        private string uID;
        private string iDNotify;
        List<KeyValuePair<string, string>> listOnlineUser;
        private int tOnlineUserPacket; // 0-Load, 1-Add, 2-Del
        private bool isLogined;

        public string IDmess { get => iDmess; set => iDmess = value; }
        public string UID { get => uID; set => uID = value; }
        public int TPacket { get => tPacket; set => tPacket = value; }
        public string IDNotify { get => iDNotify; set => iDNotify = value; }
        public int TOnlineUserPacket { get => tOnlineUserPacket; set => tOnlineUserPacket = value; }
        public List<KeyValuePair<string, string>> ListOnlineUser { get => listOnlineUser; set => listOnlineUser = value; }
        public bool IsLogined { get => isLogined; set => isLogined = value; }

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
                case 3:
                    ListOnlineUser = new List<KeyValuePair<string, string>>();

                    for (int i = 2; i < temp.Length; i++)
                    {
                        string[] temp2 = temp[i].Split('|');
                        ListOnlineUser.Add(new KeyValuePair<string, string>(temp2[0], temp2[1]));
                    }

                    if (temp[1].Equals("Load"))
                        TOnlineUserPacket = 0;
                    else if (temp[1].Equals("Add"))
                        TOnlineUserPacket = 1;
                    else
                        TOnlineUserPacket = 2;

                    break;
                case 5:
                    IsLogined = temp[1] == "1";
                    break;

                default:
                    break;
            }
        }
    }
}
