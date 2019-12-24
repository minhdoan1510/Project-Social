using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace ServerProjectSocial
{
    public class Server
    {
        #region Propertion
        List<DetailClientSocket> clients;
        IPEndPoint IP;
        Socket server;

        #endregion

        public Server()
        {
            Console.WriteLine("[" + DateTime.Now + "] Creating the server");
            clients = new List<DetailClientSocket>();
            IP = new IPEndPoint(IPAddress.Any, 9865);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        }
        ~Server()
        {
            CloseConnect();
        }

        #region Control
        public void Run()
        {
            Connect();
        }

        void SendAddUserOnline(DetailClientSocket newusser)
        {
            string name = DataProvider.Instance.ExecuteQuery(@"SELECT dbo.PROFILE.NAME
                                                                FROM dbo.PROFILE
                                                                WHERE dbo.PROFILE.UIDuser = @UIDuser", new object[] { newusser.UID }).Rows[0].ItemArray[0].ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(@"EXEC GetUIDListFriend @UIDuser", new object[] { newusser.UID });
            List<KeyValuePair<string, string>> uidbb = new List<KeyValuePair<string, string>>();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                uidbb.Add(new KeyValuePair<string, string>(data.Rows[i].ItemArray[0].ToString(), data.Rows[i].ItemArray[1].ToString()));
            }

            string result = string.Format("3_Add_{0}|{1}", newusser.UID, name);
            foreach (DetailClientSocket item in clients)
            {
                if (newusser.UID != item.UID)
                {
                    try
                    {
                        if (uidbb.Where(x => x.Key == item.UID).ToList().Count ==1)
                            Send(SetBinary(result), item.Socket);
                    }
                    catch { }
                }
            }
        }


        void SendDelUserOnline(DetailClientSocket newusser)
        {
            try
            {
                string result = string.Format("3_Del_{0}|{1}", newusser.UID, "del");
                foreach (DetailClientSocket item in clients)
                {
                    Send(SetBinary(result), item.Socket);
                }
            }
            catch
            {
                SendDelUserOnline(newusser);
            }
        }

        string EndcodeDataUserOnline(string uid)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"EXEC GetUIDListFriend @UIDuser", new object[] { uid });
            List<KeyValuePair<string, string>> uidbb = new List<KeyValuePair<string, string>>();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                uidbb.Add(new KeyValuePair<string, string>(data.Rows[i].ItemArray[0].ToString(), data.Rows[i].ItemArray[1].ToString()));
            }
            string result = "3_Load";
            foreach (KeyValuePair<string, string> item in uidbb)
            {
                try
                {
                    List<DetailClientSocket> temp = clients.Where(x => x.UID == item.Key).ToList();
                    if (temp.Count == 1)
                        result += ("_" + item.Key + "|" + item.Value);
                }
                catch { }
            }
            return result;
        }


        private void CloseConnect()
        {
            server.Close();
        }
        #endregion

        #region Transer
        void Connect()
        {
            try
            {
                Console.WriteLine("[" + DateTime.Now + "] Connecting....");
                server.Bind(IP);
                Console.WriteLine("[" + DateTime.Now + "] The server is ready to accept the connection!!!");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("[" + DateTime.Now + "] Error!!!!! Trying again....");
                Connect();
            }

            Thread threadListen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);

                        Socket client = server.Accept();

                        Console.WriteLine("[" + DateTime.Now + "] Have 1 device request access");

                        clients.Add(new DetailClientSocket(client, string.Empty));
                        Send(SetBinary("0"), client);

                        //Send(SetBinary("Minh"), client);

                        Thread threadReceive = new Thread(Receive);
                        threadReceive.IsBackground = true;
                        threadReceive.Start(client);
                        Console.WriteLine("[" + DateTime.Now + "] Device access allowed");
                        Console.WriteLine("[" + DateTime.Now + "] The number of current connections is {0}", clients.Count);
                    }
                }
                catch (Exception e)
                {
                    server.Close();
                    Console.WriteLine("[" + DateTime.Now + "]" + e.Message);
                    Console.WriteLine("[" + DateTime.Now + "] Connection lost, recovering");
                    IP = new IPEndPoint(IPAddress.Any, 1510);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    Connect();
                }
            });
            //threadListen.IsBackground = true;
            threadListen.Start();


            Thread threadScanUIDclient = new Thread(() =>
            {
                while (true)
                {
                    foreach (DetailClientSocket item in clients)
                    {
                        if (item.UID == string.Empty && (DateTime.Now - item.TimeConnect > TimeSpan.FromMinutes(1)))
                        {
                            server.Send(SetBinary("0"));
                            item.TimeConnect = DateTime.Now;
                        }
                    }
                }
            });
            //threadScanUIDclient.IsBackground = true;
            //threadScanUIDclient.Start();

        }
        bool Send(byte[] temp, Socket socket)
        {
            try
            {
                socket.Send(temp);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("[" + DateTime.Now + "] " + e.Message);
                return false;
            }
        }
        void Receive(object obj)
        {
            Socket client = (Socket)obj;
            try
            {
                while (true)
                {
                    byte[] temp1 = new byte[1024*5000];
                    int cout = client.Receive(temp1);

                    byte[] temp = new byte[cout];

                    for (int i = 0; i < cout; i++)
                    {
                        temp[i] = temp1[i];
                    }

                    string packet_str = (string)GetfromBinary(temp);
                    PacketData packet = new PacketData(packet_str);
                    Handle_ReceivePacket(packet, temp, client);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("[" + DateTime.Now + "] " + e.Message);
                Console.WriteLine("[" + DateTime.Now + "] The client whose {0} ID is disconnected", clients.Where(x => x.Socket == client).SingleOrDefault().UID);

                DetailClientSocket detail = clients.Where(x => x.Socket == client).SingleOrDefault();
                clients.Remove(detail);
                SendDelUserOnline(detail);

                Console.WriteLine("[" + DateTime.Now + "] The number of current connections is {0}", clients.Count);
                client.Close();
            }
        }
        void Handle_ReceivePacket(PacketData packet, byte[] temp, Socket client)
        {
            switch (packet.TPacket)
            {
                case 1:// xử lý khi client gửi tin nhắn
                    Console.WriteLine("[" + DateTime.Now + "] Received message package.Sending to the client");
                    try
                    {
                        if (Send(temp, clients.Where(x => x.UID == packet.UID).SingleOrDefault().Socket))
                            Console.WriteLine("[" + DateTime.Now + "] Send success");
                    }
                    catch { Console.WriteLine("[" + DateTime.Now + "] Client not working. The packet has been saved in the database"); }
                    break;

                case 2://Xử lý khi user gửi thông báo
                    Handle_NotifyPacket(packet.IDNotify, client);
                    break;
                case 3:
                    DetailClientSocket item = clients.Where(x => x.Socket == client).SingleOrDefault();
                    Send(SetBinary(EndcodeDataUserOnline(item.UID)), item.Socket);
                    break;

                case 0://Xử lý yêu cầu UID từ client kết nối tới server
                    DetailClientSocket item1 = clients.Where(x => x.Socket == client).SingleOrDefault();
                    DetailClientSocket item2 = null;
                    item2 = clients.Where(x => x.UID == packet.UID).SingleOrDefault();
                    if (item2 != null)
                    {
                        Send(SetBinary("5_1"), item1.Socket);
                        //clients.Remove(item1);
                        Console.WriteLine("[" + DateTime.Now + "] UID {0} have other access device. Socket removed from server", packet.UID);
                        break;
                    }
                    else
                        Send(SetBinary("5_0"), item1.Socket);
                    item1.UID = packet.UID;

                    SendAddUserOnline(item1);

                    Console.WriteLine("[" + DateTime.Now + "] Received UID {0} from the client", packet.UID);
                    break;
            }
        }
        private void Handle_NotifyPacket(string iDNotify, Socket client)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"EXEC GetListSendNotify @IDNotify", new object[] { iDNotify });
            for (int i = 0; i < data.Rows.Count; i++)
            {
                try
                {
                    DetailClientSocket socketDetail = clients.Where(x => x.UID == data.Rows[i].ItemArray[0].ToString()).Single();
                    if (socketDetail != null && socketDetail.Socket != client)
                        if (Send(SetBinary("2_" + iDNotify), socketDetail.Socket))
                            Console.WriteLine("[" + DateTime.Now + "] Send notify ID " + iDNotify + " to UID " + socketDetail.UID);
                }
                catch (Exception e)
                {
                    Console.WriteLine("[" + DateTime.Now + "] " + e.Message);
                }
            }
        }
        #endregion
        
        
        ///// <summary>
        ///// Convert binary to object
        ///// </summary>
        ///// <param name="obj"></param>
        ///// <returns></returns>
        //object GetfromBinary(byte[] obj)
        //{
        //    MemoryStream stream = new MemoryStream(obj);
        //    BinaryFormatter binary = new BinaryFormatter();
        //    return binary.Deserialize(stream);
        //}
        ///// <summary>
        ///// Convert object to binary
        ///// </summary>
        ///// <param name="obj"></param>
        ///// <returns></returns>
        //byte[] SetBinary(object obj)
        //{
        //    MemoryStream stream = new MemoryStream();
        //    BinaryFormatter binary = new BinaryFormatter();
        //    binary.Serialize(stream, obj);

        //    return stream.ToArray();
        //}



        public static byte[] SetBinary(object obj)
        {
            using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
            {
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(stream, obj);

                byte[] bytes = stream.ToArray();
                stream.Flush();

                return bytes;
            }
        }

        //deserialize
        public static object GetfromBinary(byte[] binaryObj)
        {
            using (System.IO.MemoryStream stream = new System.IO.MemoryStream(binaryObj))
            {
                stream.Position = 0;
                object desObj = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Deserialize(stream);
                return desObj;
            }
        }
    }
}