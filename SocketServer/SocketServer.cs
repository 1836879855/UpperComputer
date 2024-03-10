using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SocketServer
{
    public partial class SocketServer : Form
    {
        Socket socket;
        List<Socket> CustomerSockets = new List<Socket>();

        public SocketServer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化Socket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_listen_Click(object sender, EventArgs e)
        {
            string IP = txt_ip.Text;
            int Port = int.Parse(txt_port.Text);
            if (socket == null)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint IPAndPort = new IPEndPoint(IPAddress.Parse(IP), Port);
                socket.Bind(IPAndPort);
                socket.Listen(10);
            }
            ThreadPool.QueueUserWorkItem(new WaitCallback(GetCustomerSocket), socket);
        }

        /// <summary>
        /// 监听客服端
        /// </summary>
        /// <param name="o"></param>
        private void GetCustomerSocket(object o)
        {
            Socket customerSocket = o as Socket;
            while (true)
            {
                customerSocket = socket.Accept();
                if (customerSocket != null)
                {
                    CustomerSockets.Add(customerSocket);
                    ShowCustmerMsg(customerSocket.RemoteEndPoint.ToString() + ":" + "连接成功");
                    ThreadPool.QueueUserWorkItem(new WaitCallback(GetCustomerMsg), customerSocket);
                }
            }
        }

        /// <summary>
        /// 接收客户端发来的信息
        /// </summary>
        /// <param name="o"></param>
        private void GetCustomerMsg(object o)
        {
            Socket customerMsg = o as Socket;
            byte[] buffer = new byte[1024];
            int n;
            string msg;
            while (true)
            {
                try
                {
                    n = customerMsg.Receive(buffer, 0, buffer.Length, SocketFlags.None);
                }
                catch (Exception)
                {
                    MessageBox.Show("客服端非正常退出");
                    CustomerSockets.Remove(customerMsg);
                    return;
                }
                if (n <= 0)
                {
                    MessageBox.Show("客服端正常退出");
                    CustomerSockets.Remove(customerMsg);
                    return;
                }
                msg = customerMsg.RemoteEndPoint.ToString() + ":" + Encoding.Default.GetString(buffer, 0, n);
                ShowCustmerMsg(msg);
            }
        }

        /// <summary>
        /// 将客服端发送的消息显示出来
        /// </summary>
        /// <param name="s"></param>
        private void ShowCustmerMsg(string s)
        {
            if (txt_msg.InvokeRequired)
            {
                txt_msg.BeginInvoke(new Action(() =>
                {
                    txt_msg.Text += $"{s}\r\n";
                }));
            }
            else
            {
                txt_msg.Text += $"{s}\r\n";
            }
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e)
        {
            foreach (var socket in CustomerSockets)
            {
                if (CustomerSockets.Count>0&&socket.Connected)
                {
                    byte[] buffer = Encoding.Default.GetBytes(txt_send.Text);
                    socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                }
                else
                {
                    MessageBox.Show("还没有客户端连接进来");
                    return ;
                }
            }
        }
    }
}
