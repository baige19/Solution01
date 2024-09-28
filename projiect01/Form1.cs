using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projiect01
{
    public partial class Form1 : Form
    {
        private WiFiServer server;
        private WiFiClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void ServerButton_Click(object sender, EventArgs e)
        {
            try 
            {     
                if (ServerButton.Text == "启动监听")
                {
                    server = new WiFiServer(int.Parse(OwnerPort.Text));
                    OwnerIPV4adress.Text = server.GetIPV4Name();
                    server.StartServer();
                    ServerButton.Text = "关闭监听";
                }
                else
                {
                    server.CloseServer();
                    ServerButton.Text = "启动监听";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClientButton.Text == "建立连接")
                {
                    client = new WiFiClient();
                    client.ip = GoalIPV4adress.Text;
                    client.port = int.Parse(GoalPort.Text);
                    client.ConnectToServer();
                    ClientButton.Text = "断开连接";
                }
                else
                {
                    ClientButton.Text = "建立连接";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
