using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.Threading;
using System.Reflection;
using Timer = System.Windows.Forms.Timer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace ProgPC_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static SerialPort port;
        static Timer myTimer;


        internal enum Prog_cmd : int
        {
            version = 0,
            answer,
            read_buf,
            write_buf,
            erase_all,
            cpu_suspend,
            cpu_resume,
            cpu_reset,
            cpu_start,
            reset_low,
            reset_high,
            dbg_print,
            write_port,
            read_port,
            write_byte,
            read_byte
        };


        private void Form1_Load(object sender, EventArgs e)
        {
            label_port_status_Click(sender, e);
            label_port_status.Text = "update";

            myTimer = new Timer();
            myTimer.Interval = 1000; // Таймер срабатывает каждую секунду
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Start();

            textBox_adr.Text = "0x7ffd";
            textBox_data.Text = "0x00";

        }



        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            // Этот код будет выполняться при каждом срабатывании таймера
            if(port != null)
            {
                if (port.IsOpen)
                {
                    label_port_status.Text = "Open";
                } else
                {
                    label_port_status.Text = "Close";
                }
            }
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            string selected_port = listBox_ports.SelectedItem.ToString();

            if (selected_port == null) return;
            port = new SerialPort(
            selected_port,
            115200,
            Parity.None,
            8,
            StopBits.One);

            port.Encoding = Encoding.UTF8;

            if (port.IsOpen == true)
            {
                port.Close();
            }
                

            try
            {
                port.DataReceived += new SerialDataReceivedEventHandler(mySerialPort_DataReceived);
                port.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error on open port");
            }
        }

        private  void mySerialPort_DataReceived(
                    object sender,
                    SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            byte[] byteArray = new byte[8];
            int bytesRead = sp.Read(byteArray, 0, 8);
            string data_hex = BitConverter.ToString(byteArray).Replace("-", " ");
            label1.Invoke(new Action(() => { label1.Text = "empty"; }));
            label2.Invoke(new Action(() => { label2.Text = data_hex; }));


            if (byteArray[5] == 'm' || byteArray[5] == 'p')
            {
                int result = byteArray[4];
                string result_str = result.ToString("X2");
                label1.Invoke(new Action(() => { textBox_read_result.Text = "0x"+result_str; }));
            }
        }
/*
        private void UpdateLabel(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { UpdateLabel(text); }));
            }
            else
            {
                label1.Text = text;
            }
        }
*/

        private void button_port_close_Click(object sender, EventArgs e)
        {
            port.Close();
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            //send_command_to_z80db((byte)Prog_cmd.cpu_resume);
        }

        private void label_port_status_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            listBox_ports.Items.Clear();
            listBox_ports.Items.AddRange(ports);
            listBox_ports.SetSelected(0, true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }







        //  Отправка команды управления
        static void send_command_to_z80db(int cmd, int adr = 0, int data = 0)
        {
            byte[] data2send = new byte[8];
            data2send[0] = 0x55; // header
            data2send[1] = (byte)cmd;
            data2send[2] = (byte)(adr >> 0);
            data2send[3] = (byte)(adr >> 8);
            data2send[4] = (byte)(data); 
            data2send[5] = 0x00;
            data2send[6] = 0x00;
            data2send[7] = 0x00;

            //MessageBox.Show($"send_command_to_z80db {data2send[2].ToString()}, {data2send[3].ToString()}, {data2send[4].ToString()}");

            if (port == null) return;

            try
            {
                port.Write(data2send, 0, 8);
            }
            catch (Exception)
            {
                MessageBox.Show("Error on open port");
            }
        }





        private void button_resume_Click(object sender, EventArgs e)
        {
            send_command_to_z80db((byte)Prog_cmd.cpu_resume);
        }

        private void button_suspend_Click(object sender, EventArgs e)
        {
            send_command_to_z80db((byte)Prog_cmd.cpu_suspend);
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            send_command_to_z80db((byte)Prog_cmd.cpu_reset);
        }

        private void button_port_write_Click(object sender, EventArgs e)
        {
            int adr;
            try
            {
                adr = Convert.ToInt32(textBox_adr.Text, 16);
            }
            catch { return; }

            int data;
            try
            {
                data = Convert.ToInt32(textBox_data.Text, 16);
            }
            catch { return; }
            //send_command_to_z80db((byte)Prog_cmd.cpu_suspend);
            send_command_to_z80db((byte)Prog_cmd.write_port, adr, data);
            //send_command_to_z80db((byte)Prog_cmd.cpu_resume);
        }

        private void button_port_read_Click(object sender, EventArgs e)
        {
            int adr;
            try
            {
                adr = Convert.ToInt32(textBox_adr.Text, 16);
            }
            catch { return; }
            send_command_to_z80db((byte)Prog_cmd.read_port, adr);
        }

        private void textBox_adr_TextChanged(object sender, EventArgs e)
        {
            int adr = 0;
            try
            {
                adr = Convert.ToInt32(textBox_adr.Text, 16);

            } catch { }
            textBox_debug.Text = adr.ToString();
        }

        private void textBox_data_TextChanged(object sender, EventArgs e)
        {
            int data = 0;
            try {
                data = Convert.ToInt32(textBox_data.Text, 16);
            } catch { }
            textBox_debug.Text = data.ToString();
        }

        private void button_byte_write_Click(object sender, EventArgs e)
        {
            int adr;
            try
            {
                adr = Convert.ToInt32(textBox_adr.Text, 16);
            }
            catch { return; }

            int data;
            try
            {
                data = Convert.ToInt32(textBox_data.Text, 16);
            }
            catch { return; }
            send_command_to_z80db((byte)Prog_cmd.write_byte, adr, data);
        }

        private void button_byte_read_Click(object sender, EventArgs e)
        {
            int adr;
            try
            {
                adr = Convert.ToInt32(textBox_adr.Text, 16);
            }
            catch { return; }
            send_command_to_z80db((byte)Prog_cmd.read_byte, adr);
        }
    }
}
