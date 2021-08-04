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

            
            // timer.Interval = 1000;
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

            Thread thread_v02 = new Thread(new ThreadStart(() => v02(dataFromArduino, dard)));
            thread_v02.Start();

            Thread thread_v03 = new Thread(new ThreadStart(() => v03(dataFromArduino, dard)));
            thread_v03.Start();

            Thread thread_v04 = new Thread(new ThreadStart(() => v04(dataFromArduino, dard)));
            thread_v04.Start();

            Thread thread_v05 = new Thread(new ThreadStart(() => v05(dataFromArduino, dard)));
            thread_v05.Start();

            Thread thread_v06 = new Thread(new ThreadStart(() => v06(dataFromArduino, dard)));
            thread_v06.Start();

            Thread thread_v07 = new Thread(new ThreadStart(() => v07(dataFromArduino, dard)));
            thread_v07.Start();

            Thread thread_v08 = new Thread(new ThreadStart(() => v08(dataFromArduino, dard)));
            thread_v08.Start();

            Thread thread_v09 = new Thread(new ThreadStart(() => v09(dataFromArduino, dard)));
            thread_v09.Start();

            Thread thread_v10 = new Thread(new ThreadStart(() => v10(dataFromArduino, dard)));
            thread_v10.Start();

            Thread thread_v11 = new Thread(new ThreadStart(() => v11(dataFromArduino, dard)));
            thread_v11.Start();

            Thread thread_v12 = new Thread(new ThreadStart(() => v12(dataFromArduino, dard)));
            thread_v12.Start();

            Thread thread_v13 = new Thread(new ThreadStart(() => v13(dataFromArduino, dard)));
            thread_v13.Start();

            Thread thread_v14 = new Thread(new ThreadStart(() => v14(dataFromArduino, dard)));
            thread_v14.Start();


        }

        public void arus(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                if (dard.ToString().Contains("0x"+identifyID(dard)))
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
                int valid = 168;
                if (dataFromArduino.Contains(valid.ToString()))
                {
                    while (true)
                    {

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
                if (dard == 0x1014359)
                {
                    while (true)
                    {
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

        public void v02(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                int valid = 0x102;
                if (dard.ToString().Contains(valid.ToString()))
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_v02.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void v03(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                int valid = 0x103;
                if (dard.ToString().Contains(valid.ToString()))
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_v03.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void v04(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                int valid = 0x104;
                if (dard.ToString().Contains(valid.ToString()))
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_v03.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void v05(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                int valid = 0x105;
                if (dard.ToString().Contains(valid.ToString()))
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_v05.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void v06(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                int valid = 0x106;
                if (dard.ToString().Contains(valid.ToString()))
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_v06.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void v07(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                int valid = 0x107;
                if (dard.ToString().Contains(valid.ToString()))
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_v07.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void v08(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                int valid = 0x108;
                if (dard.ToString().Contains(valid.ToString()))
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_v08.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void v09(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                int valid = 0x109;
                if (dard.ToString().Contains(valid.ToString()))
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_v09.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void v10(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                int valid = 0x110;
                if (dard.ToString().Contains(valid.ToString()))
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_v10.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void v11(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                int valid = 0x111;
                if (dard.ToString().Contains(valid.ToString()))
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_v11.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void v12(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                int valid = 0x112;
                if (dard.ToString().Contains(valid.ToString()))
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_v12.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void v13(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                int valid = 0x113;
                if (dard.ToString().Contains(valid.ToString()))
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_v13.Text = result;
                        }));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void v14(string dataFromArduino, int dard)
        {
            if (int.TryParse(dataFromArduino, out dard))
            {
                int valid = 0x114;
                if (dard.ToString().Contains(valid.ToString()))
                {
                    while (true)
                    {
                        dard += 1;
                        string result = DecimalToHexadecimal(dard);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            tb_v14.Text = result;
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
                if (dec != dec % 4096)
                {
                    if (hex < 10)
                    {
                        hexStr = hexStr.Insert(0, Convert.ToChar(hex + 48).ToString());
                    }
                    else
                    {
                        hexStr = hexStr.Insert(0, Convert.ToChar(hex + 55).ToString());
                    }
                }
                dec /= 16;
            }
            return hexStr;
        }

        public static string identifyID(int dec)
        {
            if (dec < 1) return "0";

            int hex = dec;
            string hexStr = string.Empty;

            while (dec > 0)
            {
                hex = dec % 16;
                if (dec == dec % 4096)
                {
                    if (hex < 10)
                    {
                        hexStr = hexStr.Insert(0, Convert.ToChar(hex + 48).ToString());
                    }
                    else
                    {
                        hexStr = hexStr.Insert(0, Convert.ToChar(hex + 55).ToString());
                    }
                }
                dec /= 16;
            }
            return hexStr;
        }


    }
}
