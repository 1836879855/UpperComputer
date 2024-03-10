using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SocketCustomer
{
    public partial class SocketCustomer : Form
    {
        Socket socket;

        public SocketCustomer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化socket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_connect_Click(object sender, EventArgs e)
        {
            string IP = txt_ip.Text;
            int port = int.Parse(txt_port.Text);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            bool b=false;
            await Task.Run(() =>
             {
                 try
                 {
                     socket.Connect(IPAddress.Parse(IP), port);
                 }
                 catch (Exception)
                 {
                     MessageBox.Show("目标服务器可能未开启或发生了故障");
                     b = true;
                     return;
                 }
             });
            if (!b)
            {
                await Task.Run(ReceiveClientMsg);
                if (socket.Connected)
                {
                    ShowMsg($"已成功连接{txt_msg.Text}");
                }
            }
        }

        /// <summary>
        /// 循环接受服务端信息
        /// </summary>
        private void ReceiveClientMsg()
        {
            int n = 0;
            byte[] buffer = new byte[1024];
            string clientMsg;
            while (true)
            {
                if (socket != null)
                {
                    try
                    {
                        n = socket.Receive(buffer, 0, buffer.Length, SocketFlags.None);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("服务端非正常关闭");
                        return;
                    }
                    if (n <= 0)
                    {
                        MessageBox.Show("服务端正常关闭");
                        return;
                    }
                    clientMsg = socket.RemoteEndPoint.ToString() + ":" + Encoding.Default.GetString(buffer, 0, n);
                    ShowMsg(clientMsg);
                }
            }
        }

        /// <summary>
        /// 发送消息给服务端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (socket != null && socket.Connected)
            {
                byte[] data = Encoding.Default.GetBytes(txt_send.Text);
                socket.Send(data, 0, data.Length, SocketFlags.None);
            }
            else
            {
                MessageBox.Show("请先正确连接服务端");
            }
        }

        /// <summary>
        /// 格式化消息，并解决跨线程访问问题
        /// </summary>
        /// <param name="s"></param>
        private void ShowMsg(string s)
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
    }
}
