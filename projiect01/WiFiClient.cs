using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace projiect01
{
    public class WiFiClient
    {
        private TcpClient tcpClient;
        private string ip = "192.168.1.0"; // 服务器IP地址
        private int port = 8000; // 服务器端口

        public string IP
        {
            get { return ip; }
            set { ip = value; }
        }

        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        public void ConnectToServer()
        {
            tcpClient = new TcpClient();
            tcpClient.BeginConnect(ip, port, new AsyncCallback(OnConnected), null);
        }

        private void OnConnected(IAsyncResult ar)
        {
            if (tcpClient != null && tcpClient.Connected)
            {
                Console.WriteLine("Connected to server.");

                NetworkStream stream = tcpClient.GetStream();

                // 发送数据到服务器
                byte[] message = Encoding.UTF8.GetBytes("Hello from client");
                stream.Write(message, 0, message.Length);

                // 读取服务器回显的数据
                byte[] bytes = new byte[1024];
                int bytesRead = stream.Read(bytes, 0, bytes.Length);
                string data = Encoding.UTF8.GetString(bytes, 0, bytesRead);

                Console.WriteLine("Received from server: " + data);

                tcpClient.Close();
            }
        }
    }
}
