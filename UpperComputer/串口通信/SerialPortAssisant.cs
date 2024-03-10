using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UpperComputer.串口通信
{
    public partial class SerialPortAssisant : Form
    {
        public SerialPortAssisant()
        {
            InitializeComponent();
        }

        List<byte> lsb = new List<byte>();

        #region 初始化

        /// <summary>
        /// 初始化串口信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialPortAssisant_Load(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\SerialComm");
            string[] coms = rk.GetValueNames();
            cbx_port.Items.Clear();
            string comName = "";
            if (coms.Length > 0)
            {
                foreach (string com in coms)
                {
                    comName = rk.GetValue(com).ToString();
                    cbx_port.Items.Add(comName);
                }
                cbx_port.SelectedIndex = 0;
                cbx_baudrate.SelectedIndex = 0;
                cbx_databits.SelectedIndex = 3;
                cbx_checkbit.SelectedIndex = 0;
                cbx_stopbit.SelectedIndex = 0;
            }
            else
            {
                cbx_port.DropDownStyle = ComboBoxStyle.DropDown;
                MessageBox.Show("该设备没有串口");
            }
        }

        /// <summary>
        /// 设置串口参数
        /// </summary>
        private void SetValue()
        {
            serialPort.PortName = cbx_port.Text;
            serialPort.BaudRate = int.Parse(cbx_baudrate.Text);
            serialPort.DataBits = int.Parse(cbx_databits.Text);
            switch (cbx_checkbit.Text)
            {
                case "None": serialPort.Parity = Parity.None; break;
                case "Odd": serialPort.Parity = Parity.Odd; break;
                case "Even": serialPort.Parity = Parity.Even; break;
                case "Mark": serialPort.Parity = Parity.Mark; break;
                case "Space": serialPort.Parity = Parity.Space; break;
                default:
                    break;
            }
            switch (cbx_stopbit.Text)
            {
                case "0": serialPort.StopBits = StopBits.None; break;
                case "1": serialPort.StopBits = StopBits.One; break;
                case "1.5": serialPort.StopBits = StopBits.OnePointFive; break;
                case "2": serialPort.StopBits = StopBits.Two; break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 打开或关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_open_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                btn_open.Text = "打开串口";
                cbx_port.Enabled = true;
                cbx_baudrate.Enabled = true;
                cbx_checkbit.Enabled = true;
                cbx_databits.Enabled = true;
                cbx_stopbit.Enabled = true;
            }
            else
            {
                try
                {
                    SetValue();
                    serialPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                btn_open.Text = "关闭串口";
                cbx_port.Enabled = false;
                cbx_baudrate.Enabled = false;
                cbx_checkbit.Enabled = false;
                cbx_databits.Enabled = false;
                cbx_stopbit.Enabled = false;
            }
        }

        #endregion


        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (ckb_autoResend.Checked)
            {
                timer1.Start();
            }
            else
            {
                StartSendData();
            }
        }

        /// <summary>
        /// 发送数据的封装
        /// </summary>
        private void StartSendData()
        {
            string data = rtb_send.Text;
            if (data.Length > 0)
            {
                if (rdb_sendASCII.Checked)
                {
                    try
                    {
                        byte[] buffer = Encoding.ASCII.GetBytes(data);
                        serialPort.Write(buffer, 0, buffer.Length);
                        lsb.AddRange(buffer);
                        lbl_AllData.Text = lsb.Count.ToString() + "字节";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        if (timer1.Enabled)
                        {
                            timer1.Stop();
                        }
                    }

                }
                else
                {
                    try
                    {
                        byte[] res = HexToBytes(rtb_send.Text);
                        serialPort.Write(res, 0, res.Length);
                        lsb.AddRange(res);
                        lbl_AllData.Text = lsb.Count.ToString() + "字节";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        if (timer1.Enabled)
                        {
                            timer1.Stop();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请先输入内容");
                if (timer1.Enabled)
                {
                    timer1.Stop();
                }
            }
        }

        /// <summary>
        /// 接受数据处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int n = serialPort.BytesToRead;
                byte[] data = new byte[n];
                serialPort.Read(data, 0, n);
                if (rdb_receiveASCII.Checked)
                {

                    rtb_receive.Invoke((EventHandler)delegate
                    {
                        if (cbk_showtime.Checked)
                        {
                            rtb_receive.AppendText(DateTime.Now.ToString("HH:mm:ss") + ":" + Encoding.ASCII.GetString(data) + "\r\n");
                        }
                        else
                        {
                            rtb_receive.AppendText(Encoding.ASCII.GetString(data) + "\r\n");
                        }
                    });
                }
                else
                {

                    rtb_receive.Invoke((EventHandler)delegate
                    {
                        var res = BitConverter.ToString(data, 0, data.Length).Replace("-", " ");
                        if (cbk_showtime.Checked)
                        {
                            rtb_receive.AppendText(DateTime.Now.ToString("HH:mm:ss") + ":" + res + "\r\n");
                        }
                        else
                        {
                            rtb_receive.AppendText(res + "\r\n");
                        }

                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// 将hex字符串转为字节数组
        /// </summary>
        /// <param name="s">发送框的字符串</param>
        /// <returns></returns>
        private byte[] HexToBytes(string s)
        {
            string str = s.Replace(" ", "");
            if (str.Length % 2 == 0)
            {
                str += " ";
            }
            byte[] data = new byte[str.Length / 2];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = Convert.ToByte(str.Substring(i * 2, 2), 16);
            }
            return data;
        }

        /// <summary>
        /// 定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value;
            StartSendData();
        }

        /// <summary>
        /// 停止自动发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckb_autoResend_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckb_autoResend.Checked)
            {
                timer1.Stop();
            }
        }
    }
}
