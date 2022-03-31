using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client_For_SemesterProject
{
    internal class Network
    {
        private const string k_GlobalIp = "127.0.0.1";
        private const int k_Port = 7777;
        private static IPAddress ipAddress = IPAddress.Parse(k_GlobalIp);
        private static IPEndPoint remoteEp = new IPEndPoint(ipAddress, k_Port);
        private static Socket handler = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        internal static bool Connect()
        {
            try
            {
                //	Connect the socket to the remote endpoint (the server)
                handler.Connect(remoteEp);
                //	If we get to this line, the connection was successful
                //	If the Connect() method failed, an Exception would have been thrown
                Console.WriteLine("Connected to {0}", handler.RemoteEndPoint);
                Console.WriteLine("Type 'quit' to disconnect\r\n");
                return true;
            }
            catch
            {
                return false;
            }
        }
        internal static void Close_Connection()
        {
            handler.Shutdown(SocketShutdown.Both);
        }
        internal static void SendMessage(string message)
        {
            var bytes = Encoding.ASCII.GetBytes(message);
            handler.Send(bytes);
        }
        internal static string RecieveMessage()
        {
            var buffer = new byte[1024];
            var numBytesReceived = handler.Receive(buffer);
            var textReceived = Encoding.ASCII.GetString(buffer, 0, numBytesReceived);
            return textReceived;
        }
    }
}
