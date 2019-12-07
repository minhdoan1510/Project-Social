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
        List<DetailClientSocket> clients;
        IPEndPoint IP;
        Socket server;
        public Server()
        {
            Console.WriteLine("Creating the server");
            clients = new List<DetailClientSocket>();
            IP = new IPEndPoint(IPAddress.Any, 1510);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        }
        ~Server()
        {
            CloseConnect();
        }
        public void Run()
        {
            Connect();
        }
        void Connect()
        {
            try
            {
                Console.WriteLine("Connetting....");
                server.Bind(IP);
                Console.WriteLine("The server is ready to accept the connection!!!");
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Error!!!!! Trying again....");
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
                        Console.WriteLine("Have 1 device request access");
                        clients.Add(new DetailClientSocket(client,string.Empty));
                        Send(SetBinary("0"),client);
                        //Send(SetBinary("Minh"), client);

                        Thread threadReceive = new Thread(Receive);
                        threadReceive.IsBackground = true;
                        threadReceive.Start(client);
                        Console.WriteLine("Device access allowed");
                        Console.WriteLine("The number of current connections is {0}",clients.Count);
                    }
                }
                catch (Exception e)
                {
                    server.Close();
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Connection lost, recovering");
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
                            Console.WriteLine("Received message package.Sending to the client");
                            if (Send(temp, clients.Where(x=>x.UID == packet.UID ).SingleOrDefault().Socket))
                                Console.WriteLine("Send success");
                            else
                                Console.WriteLine("Client not working. The packet has been saved in the database");
                            break;

                        case 2:

                            break;

                        case 0:
                            clients.Where(x => x.Socket == ((Socket)obj)).SingleOrDefault().UID = packet.UID;
                            Console.WriteLine("Received UID {0} from the client",packet.UID);
                            break;
                    }
               
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The client whose {0} ID is disconnected", clients.Where(x => x.Socket == client).SingleOrDefault().UID);
                Console.WriteLine("The number of current connections is {0}", clients.Count);
                clients.Remove(clients.Where(x => x.Socket == client).SingleOrDefault());
                client.Close();
            }
        }
        //private bool SendPacketforClient(byte[] temp, Socket socket)
        //{
        //    if (clients.Where(x => x.Socket == socket).ToList().Count != 0)
        //    {
        //        Send(temp, socket);
        //        return true;
        //    }
        //    return false;
        //}
        private void CloseConnect()
        {
            server.Close();
        }
        object GetfromBinary(byte[] obj)
        {
            MemoryStream stream = new MemoryStream(obj);
            BinaryFormatter binary = new BinaryFormatter();
            return binary.Deserialize(stream);
        }
        byte[] SetBinary(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(stream, obj);

            return stream.ToArray();
        }
    }
}
