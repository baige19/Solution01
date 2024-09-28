using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace projiect01
{
    public class WiFiServer
    {
        private Logic logic = new Logic();
        private TcpListener tcpListener;
        private int port = 8000; // 选择一个未被使用的端口
        private bool OpenFlag;

        public WiFiServer(int port)
        {
            this.port = port;
        }

        public void StartServer()
        {
            OpenFlag = true;
            tcpListener = new TcpListener(IPAddress.Any, port);
            tcpListener.Start();
            Console.WriteLine($"Server started on port {port}.");
            WaitForClient();
        }

        public void CloseServer()
        {
            OpenFlag = false;
            tcpListener.Stop();
            Console.WriteLine($"Server closed on port {port}.");
        }

        private void WaitForClient()
        {
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(OnClientConnect), null);
        }

        private void OnClientConnect(IAsyncResult ar)
        {
            if (!OpenFlag) return;
            // 接受客户端连接
            TcpClient client = tcpListener.EndAcceptTcpClient(ar);
            Console.WriteLine("Client connected.");

            // 获取网络流
            NetworkStream stream = client.GetStream();
            byte[] bytes = new byte[1024];
            int bytesRead = stream.Read(bytes, 0, bytes.Length);
            string data = Encoding.UTF8.GetString(bytes, 0, bytesRead);
            logic.News = data;
            logic.AllLogic();

            // 回显数据
            byte[] message = Encoding.UTF8.GetBytes("Echo: " + data);
            stream.Write(message, 0, message.Length);

            // 关闭客户端连接
            client.Close();

            // 继续监听下一个客户端连接
            WaitForClient();
           
        }

        public string GetIPV4Name()
        {
            string hostName = Dns.GetHostName(); // 获取本机主机名
            IPAddress[] addresses = Dns.GetHostAddresses(hostName); // 获取本机IP地址列表

            foreach (IPAddress address in addresses)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork) // 检查是否为IPv4地址
                {
                    return address.ToString();
                }
            }
            return "0.0.0.0";
        }

    }
}
