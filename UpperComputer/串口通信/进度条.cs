using System;
using System.Windows.Forms;

namespace UpperComputer
{
    public partial class _00_串口通信基础 : Form
    {
        int count = 0;
        int n = 0;
        public _00_串口通信基础()
        {
            InitializeComponent();

            for (int i = 0; i < 20; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text.Length > 0 && !timer1.Enabled)
            {
               n = Convert.ToInt32(comboBox1.Text);
                progressBar1.Maximum = n;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count != 0)
            {
                progressBar1.Value = count;
                label2.Text = (n - count).ToString() + "秒";
            }

            if (count == n)
            {
                timer1.Stop();
                count = 0;
                progressBar1.Value = count;
            }
        }
    }
}
