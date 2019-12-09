using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            Console.WriteLine( "["+ DateTime.Now +"] Creating the server");
            clients = new List<DetailClientSocket>();
            IP = new IPEndPoint(IPAddress.Any, 1510);
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
                Console.WriteLine( "["+ DateTime.Now +"] Connetting....");
                server.Bind(IP);
                Console.WriteLine( "["+ DateTime.Now +"] The server is ready to accept the connection!!!");
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine( "["+ DateTime.Now +"] Error!!!!! Trying again....");
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
                        Console.WriteLine( "["+ DateTime.Now +"] Have 1 device request access");
                        clients.Add(new DetailClientSocket(client,string.Empty));
                        Send(SetBinary("0"),client);
                        //Send(SetBinary("Minh"), client);

                        Thread threadReceive = new Thread(Receive);
                        threadReceive.IsBackground = true;
                        threadReceive.Start(client);
                        Console.WriteLine( "["+ DateTime.Now +"] Device access allowed");
                        Console.WriteLine( "["+ DateTime.Now +"] The number of current connections is {0}",clients.Count);
                    }
                }
                catch (Exception e)
                {
                    server.Close();
                    Console.WriteLine(e.Message);
                    Console.WriteLine( "["+ DateTime.Now +"] Connection lost, recovering");
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
            catch { return false; }
        }
        void Receive(object obj)
        {
            Socket client = (Socket)obj;
            try
            {
                while (true)
                {
                    SocketFlags so = new SocketFlags();
                    byte[] temp = new byte[1024 * 5000];
                    client.Receive(temp, so);
                    
                    string packet_str = (string)GetfromBinary(temp);
                    PacketData packet = new PacketData(packet_str);
                    switch (packet.TPacket)
                    {
                        case 1:
                            Console.WriteLine( "["+ DateTime.Now +"] Received message package.Sending to the client");
                            try
                            {
                                if (Send(temp, clients.Where(x => x.UID == packet.UID).SingleOrDefault().Socket))
                                    Console.WriteLine( "["+ DateTime.Now +"] Send success");
                            }
                            catch { Console.WriteLine( "["+ DateTime.Now +"] Client not working. The packet has been saved in the database"); }
                            break;

                        case 2:

                            break;

                        case 0:
                            clients.Where(x => x.Socket == ((Socket)obj)).SingleOrDefault().UID = packet.UID;
                            Console.WriteLine( "["+ DateTime.Now +"] Received UID {0} from the client",packet.UID);
                            break;
                    }
               
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine( "["+ DateTime.Now +"] The client whose {0} ID is disconnected", clients.Where(x => x.Socket == client).SingleOrDefault().UID);
                clients.Remove(clients.Where(x => x.Socket == client).SingleOrDefault());
                Console.WriteLine( "["+ DateTime.Now +"] The number of current connections is {0}", clients.Count);
                client.Close();
            }
        }
        #endregion

        /// <summary>
        /// Convert binary to object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        object GetfromBinary(byte[] obj)
        {
            MemoryStream stream = new MemoryStream(obj);
            BinaryFormatter binary = new BinaryFormatter();
            return binary.Deserialize(stream);
        }
        /// <summary>
        /// Convert object to binary
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        byte[] SetBinary(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(stream, obj);

            return stream.ToArray();
        }
    }
}