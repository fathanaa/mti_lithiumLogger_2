using System;

using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace mti_lithiumLogger_2
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

            serialPort = new SerialPort();
            serialPort.PortName = "COM4";
            serialPort.BaudRate = 9600;
            serialPort.DtrEnable = true;
            serialPort.Open();

            
            timer.Interval = 1000;
            timer.Tick += new System.EventHandler(timer_Tick);
            timer.Start();
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            String dataFromArduino = serialPort.ReadLine();
            int dard=0;

            Thread thread_arus = new Thread(new ThreadStart(() => arus(dataFromArduino, dard)));
            thread_arus.Start();

            Thread thread_temp = new Thread(new ThreadStart(() => temp(dataFromArduino, dard)));
            thread_temp.Start();

            Thread thread_v01 = new Thread(new ThreadStart(() => v01(dataFromArduino, dard)));
            thread_v01.Start();
        }

        public void arus(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                if (dard == 0x01014359)
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_arus.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }    
        }

        public void temp(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                if (dard == 0x0102671)
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_temp.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void v01(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                if (dard == 0x01032703)
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_v01.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public static string DecimalToHexadecimal(int dec)
        {
            if (dec < 1) return "0";

            int hex = dec;
            string hexStr = string.Empty;

            while (dec > 0)
            {
                hex = dec % 16;
                    if (hex < 10)
                    {
                        hexStr = hexStr.Insert(0, Convert.ToChar(hex + 48).ToString());
                    }
                    else
                    {
                        hexStr = hexStr.Insert(0, Convert.ToChar(hex + 55).ToString());
                    }
                dec /= 16;
            }
            return hexStr;
        }
    }
}
