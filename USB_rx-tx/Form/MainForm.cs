using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace USB_rx_tx
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (USBconnect.Text == "连接")
            {
                try
                {
                    
                    serialPort1.PortName = USB_port1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(USB_boundrate.Text);
                    serialPort1.Open();
                    send.Enabled = true;
                    USBconnect.Text = "断开";
                    linkstatus.BackColor = Color.SpringGreen;
                }
                catch
                {
                    MessageBox.Show("端口连接失败", "错误");
                    linkstatus.BackColor = Color.Red;

                }
            }
            else 
            {
                try
                {
                    serialPort1.Close();
                    send.Enabled = false;
                    USBconnect.Text = "连接";
                    linkstatus.BackColor = Color.Red;
                }
                catch
                {
                    MessageBox.Show("端口断开失败", "错误");
                   
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //先打开所有COM口，成功的就添加
            for (int i = 1; i < 20; i++)
            {
                serialPort1.PortName = "COM" + i.ToString();
                RXbox.AppendText(i.ToString());
                serialPort1.BaudRate = 9600;
                try
                {
                    serialPort1.Open();
                    USB_port1.Items.Add("COM" + i.ToString());
                    RXbox.AppendText("COM" + i.ToString());
                    serialPort1.Close();
                }
                catch
                { }
            }
            USB_boundrate.Text = "9600";
            send.Enabled = false;
        }

        private void SENDBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'a' && e.KeyChar <= 'f') || (e.KeyChar >= 'A' && e.KeyChar <= 'F') || e.KeyChar == '\b')
            {
                if ((e.KeyChar >= 'a' && e.KeyChar <= 'f'))
                {
                    e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
                }
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            Int32  SENDleg = send.Text.Length;
            byte[] sendbuff = {0x12,0x13,0x14 };
            if (send.Text != "")
            {
                try
                {
                    //serialPort1.Write(SENDBox.Text);//发送字符
                    serialPort1.Write(sendbuff, 0,3);//发送数值
                }
                catch
                {
                   // MessageBox.Show("串口数据写入错误", "错误");
                }
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            byte[] data = new byte[serialPort1.BytesToRead];
            serialPort1.Read(data, 0, data.Length);
            foreach (byte mneber in data)
            {
                string str = Convert.ToString(mneber, 16).ToUpper();
                RXbox.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + " ");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        //WndProc：主要用在拦截并处理系统消息和自定义消息
        //Winform程序会产生很多消息，比如你单击鼠标，移动窗口都会产生消息。这个函数就是默认的消息处理函数。你可以重载这个函数来制定自己的消息处理流程。
        //在Winform程序中，可以重写WndProc函数，来捕捉所有发生的窗口消息
        public const int WM_DEVICECHANGE = 0x219;//设备改变
        public const int DBT_DEVICEARRIVAL = 0x8000;//检测到新设备
        public const int DBT_DEVICECERMOVECPMPLETE = 0x8004;//移除设备




        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_DEVICECHANGE:
                    switch ((int)m.WParam)
                    {
                        case DBT_DEVICEARRIVAL:
                            {
                                MessageBox.Show("端口插入", "");

                                break;
                            }
                        case DBT_DEVICECERMOVECPMPLETE:
                            {
                                MessageBox.Show("端口拔出", "");

                                break;
                            }

                    }
                    // RefreshUsableSp()方法为刷新串口的相关操作
                    //把上面的读取COM0-20整成一个方法
                    break;
            
            }
        
        
        }

    }

    
}
