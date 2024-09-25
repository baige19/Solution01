using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace projiect01
{
    public class WiFiServer
    {
        private TcpListener tcpListener;
        private int port = 8000; // 选择一个未被使用的端口

        public WiFiServer(int port)
        {
            this.port = port;
        }

        public void StartServer()
        {
            tcpListener = new TcpListener(IPAddress.Any, port);
            tcpListener.Start();
            Console.WriteLine($"Server started on port {port}.");
            WaitForClient();
        }

        private void WaitForClient()
        {
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(OnClientConnect), null);
        }

        private void OnClientConnect(IAsyncResult ar)
        {
            // 接受客户端连接
            TcpClient client = tcpListener.EndAcceptTcpClient(ar);
            Console.WriteLine("Client connected.");

            // 获取网络流
            NetworkStream stream = client.GetStream();
            byte[] bytes = new byte[1024];
            int bytesRead = stream.Read(bytes, 0, bytes.Length);
            string data = Encoding.UTF8.GetString(bytes, 0, bytesRead);

            Console.WriteLine("Received: " + data);

            // 回显数据
            byte[] message = Encoding.UTF8.GetBytes("Echo: " + data);
            stream.Write(message, 0, message.Length);

            // 关闭客户端连接
            client.Close();

            // 继续监听下一个客户端连接
            WaitForClient();
        }

    }
}
