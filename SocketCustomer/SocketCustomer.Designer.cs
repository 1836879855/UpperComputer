﻿namespace SocketCustomer
{
    partial class SocketCustomer
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
            this.btn_send = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_msg = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_send = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(667, 48);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(105, 54);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_port);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_ip);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(535, 25);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(237, 28);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(382, 25);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 28);
            this.txt_port.TabIndex = 2;
            this.txt_port.Text = "4090";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP：";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(142, 25);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(166, 28);
            this.txt_ip.TabIndex = 0;
            this.txt_ip.Text = "192.168.1.7";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_msg);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(777, 235);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // txt_msg
            // 
            this.txt_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_msg.Location = new System.Drawing.Point(3, 24);
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.ReadOnly = true;
            this.txt_msg.Size = new System.Drawing.Size(771, 208);
            this.txt_msg.TabIndex = 0;
            this.txt_msg.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_send);
            this.groupBox2.Controls.Add(this.txt_send);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 124);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // txt_send
            // 
            this.txt_send.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_send.Location = new System.Drawing.Point(3, 24);
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(632, 97);
            this.txt_send.TabIndex = 0;
            this.txt_send.Text = "";
            // 
            // SocketCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "SocketCustomer";
            this.Text = "SocketCustomer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txt_msg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txt_send;
    }
}