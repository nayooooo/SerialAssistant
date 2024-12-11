using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Serial
{
    public partial class SerialAssistant : System.Windows.Forms.Form
    {
        private string[] _Serial_Baud_List = new string[]
        {
            "9600", "19200", "38400", "57600", "748800", "115200"
        };
        private string[] _Serial_Encode_List = new string[]
        {
            "ASCII", "utf-8", "gb2312"
        };

        private bool _SerialPortOpened = false;
        private bool SerialPortOpened
        {
            get { return _SerialPortOpened; }
            set { _SerialPortOpened = value; }
        }

        public SerialAssistant()
        {
            InitializeComponent();
        }

        private void SerialPorts_Load(ComboBox cbb)
        {
            try
            {
                cbb.Items.Clear();
                string[] ports = SerialPort.GetPortNames();
                if (ports.Length == 0)
                {
                    return;
                }
                foreach (string port in ports)
                {
                    cbb.Items.Add(port);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "串口列表加载到组合框失败");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM1";
            serialPort1.BaudRate = 115200;
            serialPort1.Encoding = Encoding.UTF8;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;

            SerialPorts_Load(serial_config_port_cbb);
            serial_config_port_cbb.SelectedIndex = serial_config_port_cbb.Items.Count > 0 ? 0 : -1;
            serial_config_port_cbb.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (string baud in _Serial_Baud_List)
            {
                serial_config_baud_cbb.Items.Add(baud);
            }
            serial_config_baud_cbb.SelectedIndex = Array.IndexOf(_Serial_Baud_List, "115200");
            serial_config_baud_cbb.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (string baud in _Serial_Encode_List)
            {
                serial_config_encode_cbb.Items.Add(baud);
            }
            serial_config_encode_cbb.SelectedIndex = Array.IndexOf(_Serial_Encode_List, "utf-8");
            serial_config_encode_cbb.DropDownStyle = ComboBoxStyle.DropDownList;

            rx_config_show_text_rbtn.Checked = true;
            rx_config_save_path_tb.Text = "";

            tx_config_show_text_rbtn.Checked = true;
            tx_config_auto_send_ckb.Checked = false;
            tx_config_auto_send_cycle_tb.Text = "1000";

            rx_buff_rtb.Text = "";

            tx_buff_rtb.Text  = "如果您在使用过程中发现任何BUG，欢迎向我提供反馈\n";
            tx_buff_rtb.Text += "反馈渠道：https://github.com/nayooooo/SerialAssistant\n";
        }

        private void SerialConfig_cbb_DropDown(object sender, EventArgs e)
        {
            if (sender == serial_config_port_cbb)
            {
                int index = -1;
                string last = "";
                if (serial_config_port_cbb.SelectedIndex >= 0)
                {
                    last = serial_config_port_cbb.SelectedItem.ToString();
                }
                SerialPorts_Load(serial_config_port_cbb);
                for (int i = 0; i < serial_config_port_cbb.Items.Count; i++)
                {
                    if (serial_config_port_cbb.Items[i].ToString() == last)
                    {
                        index = i;
                        break;
                    }
                }
                serial_config_port_cbb.SelectedIndex = index;
            }
        }

        private void SerialConfig_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == serial_config_port_cbb)
            {
                serialPort1.PortName = serial_config_port_cbb.SelectedItem.ToString();
            }
            else if (sender == serial_config_baud_cbb)
            {
                try
                {
                    serialPort1.BaudRate = int.Parse(serial_config_baud_cbb.SelectedItem.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "错误波特率(" + serial_config_baud_cbb.SelectedItem.ToString() + ")");
                }
            }
            else if (sender == serial_config_encode_cbb)
            {
                serialPort1.Encoding = Encoding.GetEncoding(serial_config_encode_cbb.SelectedItem.ToString());
            }
        }

        private void SerialConfig_btn_Click(object sender, EventArgs e)
        {
            if (sender == serial_config_open_btn)
            {
                try
                {
                    if (SerialPortOpened)
                    {  // to close
                        serialPort1.Close();

                        SerialPortOpened = false;
                        serial_config_open_btn.BackColor = SystemColors.Control;
                        serial_config_port_cbb.Enabled = true;
                    }
                    else if (serial_config_port_cbb.SelectedIndex >= 0)
                    {  // to open
                        serialPort1.Open();

                        SerialPortOpened = true;
                        serial_config_open_btn.BackColor = SystemColors.HotTrack;
                        serial_config_port_cbb.Enabled = false;
                    }
                    else
                    {  // not select
                        MessageBox.Show("必须选择端口才可以打开串口！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + serialPort1.PortName.ToString());
                }
            }
        }

        private void TxConfig_btn_Click(object sender, EventArgs e)
        {
            if (sender == tx_config_start_transmit_btn)
            {
                try
                {
                    if (SerialPortOpened && serialPort1.IsOpen)
                    {
                        byte[] text = serialPort1.Encoding.GetBytes(tx_buff_rtb.Text);
                        serialPort1.Write(text, 0, text.Length);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + serialPort1.PortName.ToString());
                }
            }
        }
    }
}
