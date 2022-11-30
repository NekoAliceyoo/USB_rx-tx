
namespace USB_rx_tx
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.USBconnect = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.USB_port1 = new System.Windows.Forms.ComboBox();
            this.USB_boundrate = new System.Windows.Forms.ComboBox();
            this.SENDBox = new System.Windows.Forms.TextBox();
            this.label_串口选择 = new System.Windows.Forms.Label();
            this.label_波特率 = new System.Windows.Forms.Label();
            this.RXbox = new System.Windows.Forms.TextBox();
            this.linkstatus = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // USBconnect
            // 
            this.USBconnect.Location = new System.Drawing.Point(12, 281);
            this.USBconnect.Name = "USBconnect";
            this.USBconnect.Size = new System.Drawing.Size(214, 60);
            this.USBconnect.TabIndex = 0;
            this.USBconnect.Text = "连接";
            this.USBconnect.UseVisualStyleBackColor = true;
            this.USBconnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(12, 410);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(305, 60);
            this.send.TabIndex = 0;
            this.send.Text = "发送";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // USB_port1
            // 
            this.USB_port1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.USB_port1.FormattingEnabled = true;
            this.USB_port1.Location = new System.Drawing.Point(137, 72);
            this.USB_port1.Name = "USB_port1";
            this.USB_port1.Size = new System.Drawing.Size(180, 41);
            this.USB_port1.TabIndex = 2;
            this.USB_port1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // USB_boundrate
            // 
            this.USB_boundrate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.USB_boundrate.FormattingEnabled = true;
            this.USB_boundrate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.USB_boundrate.Location = new System.Drawing.Point(137, 184);
            this.USB_boundrate.Name = "USB_boundrate";
            this.USB_boundrate.Size = new System.Drawing.Size(180, 41);
            this.USB_boundrate.TabIndex = 2;
            // 
            // SENDBox
            // 
            this.SENDBox.Location = new System.Drawing.Point(348, 25);
            this.SENDBox.Multiline = true;
            this.SENDBox.Name = "SENDBox";
            this.SENDBox.Size = new System.Drawing.Size(600, 200);
            this.SENDBox.TabIndex = 3;
            // 
            // label_串口选择
            // 
            this.label_串口选择.AutoSize = true;
            this.label_串口选择.Location = new System.Drawing.Point(24, 80);
            this.label_串口选择.Name = "label_串口选择";
            this.label_串口选择.Size = new System.Drawing.Size(106, 24);
            this.label_串口选择.TabIndex = 4;
            this.label_串口选择.Text = "串口选择";
            this.label_串口选择.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_波特率
            // 
            this.label_波特率.AutoSize = true;
            this.label_波特率.Location = new System.Drawing.Point(24, 193);
            this.label_波特率.Name = "label_波特率";
            this.label_波特率.Size = new System.Drawing.Size(82, 24);
            this.label_波特率.TabIndex = 5;
            this.label_波特率.Text = "波特率";
            // 
            // RXbox
            // 
            this.RXbox.Location = new System.Drawing.Point(348, 281);
            this.RXbox.Multiline = true;
            this.RXbox.Name = "RXbox";
            this.RXbox.ReadOnly = true;
            this.RXbox.Size = new System.Drawing.Size(600, 200);
            this.RXbox.TabIndex = 3;
            // 
            // linkstatus
            // 
            this.linkstatus.BackColor = System.Drawing.Color.Red;
            this.linkstatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.linkstatus.Location = new System.Drawing.Point(244, 281);
            this.linkstatus.Name = "linkstatus";
            this.linkstatus.Size = new System.Drawing.Size(50, 50);
            this.linkstatus.TabIndex = 6;
            this.linkstatus.UseVisualStyleBackColor = false;
            this.linkstatus.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(510, 240);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(107, 35);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 529);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.linkstatus);
            this.Controls.Add(this.label_波特率);
            this.Controls.Add(this.label_串口选择);
            this.Controls.Add(this.RXbox);
            this.Controls.Add(this.SENDBox);
            this.Controls.Add(this.USB_boundrate);
            this.Controls.Add(this.USB_port1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.USBconnect);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button USBconnect;
        private System.Windows.Forms.Button send;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox USB_port1;
        private System.Windows.Forms.ComboBox USB_boundrate;
        private System.Windows.Forms.Label label_串口选择;
        private System.Windows.Forms.Label label_波特率;
        private System.Windows.Forms.TextBox SENDBox;
        private System.Windows.Forms.TextBox RXbox;
        private System.Windows.Forms.Button linkstatus;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

