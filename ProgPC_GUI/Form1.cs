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

        private void Form1_Load(object sender, EventArgs e)
        {
            label_port_status_Click(sender, e);
            label_port_status.Text = "update";

            myTimer = new Timer();
            myTimer.Interval = 1000; // Таймер срабатывает каждую секунду
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Start();
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

            if (port.IsOpen == true)
            {
                port.Close();
            }
                

            try
            {
                port.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error on open port");
            }
        }

        private void button_port_close_Click(object sender, EventArgs e)
        {
            port.Close();
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            port.Write("test\r\n");
        }

        private void label_port_status_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            listBox_ports.Items.Clear();
            listBox_ports.Items.AddRange(ports);
            listBox_ports.SetSelected(0, true);
        }
    }
}
