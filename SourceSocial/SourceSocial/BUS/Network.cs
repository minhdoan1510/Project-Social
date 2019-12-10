using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using DTO;
using System.Windows.Forms;

namespace BUS
{
    public class Network
    {
        public delegate void HavePacket(string obj);
        public event HavePacket OnHavePacket; 

        IPEndPoint IP;
        Socket client;
        public Network()
        {
            Connect();
        }
        private void CloseConnect()
        {
            client.Close();
        }

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("172.105.119.190"), 1510);
           // IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1510);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Lỗi đường truyền");
                return;
            }

            Thread threadReceive = new Thread(Receive);
            threadReceive.IsBackground = true;
            threadReceive.Start();
        }

        public bool Send(object obj)
        {
            try
            {
                client.Send(SetBinary(obj));
                return true;
            }
            catch
            {
                Connect();
                return false;
            }

        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] temp = new byte[1024 * 5000];
                    client.Receive(temp);
                    object mess = GetfromBinary(temp);
                    if (OnHavePacket != null)
                        OnHavePacket((string)mess);
                }
            }
            catch
            {
                CloseConnect();
            }
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
