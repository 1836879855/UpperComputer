namespace UpperComputer.串口通信
{
    partial class SerialPortAssisant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_AllData = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rtb_send = new System.Windows.Forms.RichTextBox();
            this.rtb_receive = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ckb_autoResend = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdb_sendHEX = new System.Windows.Forms.RadioButton();
            this.rdb_sendASCII = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbk_showsend = new System.Windows.Forms.CheckBox();
            this.cbk_showtime = new System.Windows.Forms.CheckBox();
            this.cbk_autowrap = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdb_receiveHEX = new System.Windows.Forms.RadioButton();
            this.rdb_receiveASCII = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.cbx_stopbit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_checkbit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_databits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_baudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_port = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_AllData);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 720);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 35);
            this.panel3.TabIndex = 2;
            // 
            // lbl_AllData
            // 
            this.lbl_AllData.AutoSize = true;
            this.lbl_AllData.Location = new System.Drawing.Point(86, 10);
            this.lbl_AllData.Name = "lbl_AllData";
            this.lbl_AllData.Size = new System.Drawing.Size(0, 18);
            this.lbl_AllData.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "已发送:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 685);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.rtb_send);
            this.panel2.Controls.Add(this.rtb_receive);
            this.panel2.Controls.Add(this.btn_send);
            this.panel2.Location = new System.Drawing.Point(280, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 681);
            this.panel2.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(572, 624);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 46);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // rtb_send
            // 
            this.rtb_send.Location = new System.Drawing.Point(4, 546);
            this.rtb_send.Name = "rtb_send";
            this.rtb_send.Size = new System.Drawing.Size(561, 129);
            this.rtb_send.TabIndex = 2;
            this.rtb_send.Text = "";
            // 
            // rtb_receive
            // 
            this.rtb_receive.Location = new System.Drawing.Point(4, 0);
            this.rtb_receive.Name = "rtb_receive";
            this.rtb_receive.ReadOnly = true;
            this.rtb_receive.Size = new System.Drawing.Size(638, 526);
            this.rtb_receive.TabIndex = 1;
            this.rtb_receive.Text = "";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(572, 549);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 51);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Location = new System.Drawing.Point(0, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(274, 681);
            this.panel6.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.ckb_autoResend);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Location = new System.Drawing.Point(9, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 127);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口发送设置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "ms";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(122, 93);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(93, 28);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ckb_autoResend
            // 
            this.ckb_autoResend.AutoSize = true;
            this.ckb_autoResend.Location = new System.Drawing.Point(7, 96);
            this.ckb_autoResend.Name = "ckb_autoResend";
            this.ckb_autoResend.Size = new System.Drawing.Size(106, 22);
            this.ckb_autoResend.TabIndex = 2;
            this.ckb_autoResend.Text = "自动重发";
            this.ckb_autoResend.UseVisualStyleBackColor = true;
            this.ckb_autoResend.CheckedChanged += new System.EventHandler(this.ckb_autoResend_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdb_sendHEX);
            this.panel4.Controls.Add(this.rdb_sendASCII);
            this.panel4.Location = new System.Drawing.Point(0, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 52);
            this.panel4.TabIndex = 1;
            // 
            // rdb_sendHEX
            // 
            this.rdb_sendHEX.AutoSize = true;
            this.rdb_sendHEX.Location = new System.Drawing.Point(153, 13);
            this.rdb_sendHEX.Name = "rdb_sendHEX";
            this.rdb_sendHEX.Size = new System.Drawing.Size(60, 22);
            this.rdb_sendHEX.TabIndex = 1;
            this.rdb_sendHEX.TabStop = true;
            this.rdb_sendHEX.Text = "HEX";
            this.rdb_sendHEX.UseVisualStyleBackColor = true;
            // 
            // rdb_sendASCII
            // 
            this.rdb_sendASCII.AutoSize = true;
            this.rdb_sendASCII.Checked = true;
            this.rdb_sendASCII.Location = new System.Drawing.Point(5, 13);
            this.rdb_sendASCII.Name = "rdb_sendASCII";
            this.rdb_sendASCII.Size = new System.Drawing.Size(78, 22);
            this.rdb_sendASCII.TabIndex = 0;
            this.rdb_sendASCII.TabStop = true;
            this.rdb_sendASCII.Text = "ASCII";
            this.rdb_sendASCII.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbk_showsend);
            this.groupBox2.Controls.Add(this.cbk_showtime);
            this.groupBox2.Controls.Add(this.cbk_autowrap);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Location = new System.Drawing.Point(4, 478);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "串口接收设置";
            // 
            // cbk_showsend
            // 
            this.cbk_showsend.AutoSize = true;
            this.cbk_showsend.Location = new System.Drawing.Point(151, 106);
            this.cbk_showsend.Margin = new System.Windows.Forms.Padding(4);
            this.cbk_showsend.Name = "cbk_showsend";
            this.cbk_showsend.Size = new System.Drawing.Size(106, 22);
            this.cbk_showsend.TabIndex = 8;
            this.cbk_showsend.Text = "显示发送";
            this.cbk_showsend.UseVisualStyleBackColor = true;
            // 
            // cbk_showtime
            // 
            this.cbk_showtime.AutoSize = true;
            this.cbk_showtime.Location = new System.Drawing.Point(5, 160);
            this.cbk_showtime.Margin = new System.Windows.Forms.Padding(4);
            this.cbk_showtime.Name = "cbk_showtime";
            this.cbk_showtime.Size = new System.Drawing.Size(106, 22);
            this.cbk_showtime.TabIndex = 7;
            this.cbk_showtime.Text = "显示时间";
            this.cbk_showtime.UseVisualStyleBackColor = true;
            // 
            // cbk_autowrap
            // 
            this.cbk_autowrap.AutoSize = true;
            this.cbk_autowrap.Location = new System.Drawing.Point(5, 107);
            this.cbk_autowrap.Margin = new System.Windows.Forms.Padding(4);
            this.cbk_autowrap.Name = "cbk_autowrap";
            this.cbk_autowrap.Size = new System.Drawing.Size(106, 22);
            this.cbk_autowrap.TabIndex = 6;
            this.cbk_autowrap.Text = "自动换行";
            this.cbk_autowrap.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rdb_receiveHEX);
            this.panel5.Controls.Add(this.rdb_receiveASCII);
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(261, 52);
            this.panel5.TabIndex = 2;
            // 
            // rdb_receiveHEX
            // 
            this.rdb_receiveHEX.AutoSize = true;
            this.rdb_receiveHEX.Location = new System.Drawing.Point(153, 13);
            this.rdb_receiveHEX.Name = "rdb_receiveHEX";
            this.rdb_receiveHEX.Size = new System.Drawing.Size(60, 22);
            this.rdb_receiveHEX.TabIndex = 1;
            this.rdb_receiveHEX.TabStop = true;
            this.rdb_receiveHEX.Text = "HEX";
            this.rdb_receiveHEX.UseVisualStyleBackColor = true;
            // 
            // rdb_receiveASCII
            // 
            this.rdb_receiveASCII.AutoSize = true;
            this.rdb_receiveASCII.Checked = true;
            this.rdb_receiveASCII.Location = new System.Drawing.Point(5, 13);
            this.rdb_receiveASCII.Name = "rdb_receiveASCII";
            this.rdb_receiveASCII.Size = new System.Drawing.Size(78, 22);
            this.rdb_receiveASCII.TabIndex = 0;
            this.rdb_receiveASCII.TabStop = true;
            this.rdb_receiveASCII.Text = "ASCII";
            this.rdb_receiveASCII.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_open);
            this.groupBox1.Controls.Add(this.cbx_stopbit);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbx_checkbit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbx_databits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbx_baudrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbx_port);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "停止位";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(13, 238);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(242, 32);
            this.btn_open.TabIndex = 14;
            this.btn_open.Text = "打开串口";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // cbx_stopbit
            // 
            this.cbx_stopbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_stopbit.FormattingEnabled = true;
            this.cbx_stopbit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbx_stopbit.Location = new System.Drawing.Point(79, 206);
            this.cbx_stopbit.Name = "cbx_stopbit";
            this.cbx_stopbit.Size = new System.Drawing.Size(176, 26);
            this.cbx_stopbit.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "停止位";
            // 
            // cbx_checkbit
            // 
            this.cbx_checkbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_checkbit.FormattingEnabled = true;
            this.cbx_checkbit.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.cbx_checkbit.Location = new System.Drawing.Point(79, 164);
            this.cbx_checkbit.Name = "cbx_checkbit";
            this.cbx_checkbit.Size = new System.Drawing.Size(176, 26);
            this.cbx_checkbit.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "校验位";
            // 
            // cbx_databits
            // 
            this.cbx_databits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_databits.FormattingEnabled = true;
            this.cbx_databits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbx_databits.Location = new System.Drawing.Point(79, 120);
            this.cbx_databits.Name = "cbx_databits";
            this.cbx_databits.Size = new System.Drawing.Size(176, 26);
            this.cbx_databits.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "数据位";
            // 
            // cbx_baudrate
            // 
            this.cbx_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_baudrate.FormattingEnabled = true;
            this.cbx_baudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "Custom"});
            this.cbx_baudrate.Location = new System.Drawing.Point(79, 73);
            this.cbx_baudrate.Name = "cbx_baudrate";
            this.cbx_baudrate.Size = new System.Drawing.Size(176, 26);
            this.cbx_baudrate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "波特率";
            // 
            // cbx_port
            // 
            this.cbx_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_port.FormattingEnabled = true;
            this.cbx_port.Location = new System.Drawing.Point(79, 26);
            this.cbx_port.Name = "cbx_port";
            this.cbx_port.Size = new System.Drawing.Size(176, 26);
            this.cbx_port.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "端  口";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 32);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SerialPortAssisant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 758);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "SerialPortAssisant";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.SerialPortAssisant_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RichTextBox rtb_send;
        private System.Windows.Forms.RichTextBox rtb_receive;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox ckb_autoResend;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdb_sendHEX;
        private System.Windows.Forms.RadioButton rdb_sendASCII;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbk_showsend;
        private System.Windows.Forms.CheckBox cbk_showtime;
        private System.Windows.Forms.CheckBox cbk_autowrap;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdb_receiveHEX;
        private System.Windows.Forms.RadioButton rdb_receiveASCII;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ComboBox cbx_stopbit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_checkbit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_databits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_baudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_AllData;
        private System.Windows.Forms.Label label6;
    }
}