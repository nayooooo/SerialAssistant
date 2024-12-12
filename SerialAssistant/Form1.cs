using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;

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

        public enum Text_Show_Method
        {
            Text,
            Hex
        }

        private struct Rx_Config_Context
        {
            public Text_Show_Method show_Method;
            public bool is_receiving;
            public string save_path;
        }

        private struct Tx_Config_Context
        {
            public Text_Show_Method show_Method;
            public bool auto_Send;
            public bool is_Sending;
            public int auto_Send_Cycle;
            public string text;
            public string hex;
        }

        private Rx_Config_Context _rx_Config_Context = new Rx_Config_Context
        {
            show_Method = Text_Show_Method.Text,
            is_receiving = false,
            save_path = ""
        };

        private Tx_Config_Context _tx_Config_Context = new Tx_Config_Context
        {
            show_Method = Text_Show_Method.Text,
            auto_Send  = false,
            is_Sending = false,
            auto_Send_Cycle = 1000,
            text = "",
            hex = ""
        };

        private Thread _Transmit_Thread = null;

        public SerialAssistant()
        {
            InitializeComponent();
        }

        private static string ConvertStringToHexString(string text, Encoding encoding)
        {
            byte[] bytes = encoding.GetBytes(text);

            StringBuilder hex = new StringBuilder();

            foreach (byte b in bytes)
            {
                hex.Append(b.ToString("X2"));
            }

            return hex.ToString();
        }

        private static string ConvertHexStringToString(string text, Encoding encoding)
        {
            if (text.Length % 2 != 0)
            {
                MessageBox.Show("转换失败，十六进制字符串的长度必须是偶数");
                return text;
            }

            byte[] bytes = new byte[text.Length / 2];

            for (int i = 0; i < text.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(text.Substring(i, 2), 16);
            }

            return encoding.GetString(bytes);
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

        private void Receive_Handler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            if (!_rx_Config_Context.is_receiving)
            {
                return;
            }
            if (indata != null && indata.Length != 0)
            {
                rx_buff_rtb.Text += indata;
                tx_status_receive_counter.Text = (int.Parse(tx_status_receive_counter.Text) + indata.Length).ToString();
            }
        }

        private void Transmit_String(string str)
        {
            byte[] text = serialPort1.Encoding.GetBytes(str);
            serialPort1.Write(text, 0, text.Length);
            tx_status_transmit_counter.Text = (int.Parse(tx_status_transmit_counter.Text) + text.Length).ToString();
        }

        private void Transmit_Thread_Enter()
        {
            while (true)
            {
                if (_tx_Config_Context.auto_Send && _tx_Config_Context.is_Sending)
                {
                    Transmit_String(tx_buff_rtb.Text);
                }
                Thread.Sleep(_tx_Config_Context.auto_Send_Cycle);
            }
        }

        private void SerialAssistant_Load(object sender, EventArgs e)
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

            rx_config_show_text_rbtn.Checked = _rx_Config_Context.show_Method == Text_Show_Method.Text;
            rx_config_show_hex_rbtn.Checked  = _rx_Config_Context.show_Method != Text_Show_Method.Text;
            rx_config_stop_receive_btn.Enabled = false;
            rx_config_save_path_tb.Text = _rx_Config_Context.save_path;
            rx_config_save_path_tb.ReadOnly = true;

            tx_config_show_text_rbtn.Checked = _tx_Config_Context.show_Method == Text_Show_Method.Text;
            tx_config_show_hex_rbtn.Checked  = _tx_Config_Context.show_Method != Text_Show_Method.Text;
            tx_config_auto_send_ckb.Checked = _tx_Config_Context.auto_Send;
            tx_config_auto_send_cycle_tb.Text = _tx_Config_Context.auto_Send_Cycle.ToString();
            tx_config_stop_transmit_btn.Enabled = false;

            rx_buff_rtb.Text = "";
            rx_buff_rtb.ReadOnly = true;

            tx_buff_rtb.Text  = "如果您在使用过程中发现任何BUG，欢迎向我提供反馈\n";
            tx_buff_rtb.Text += "反馈渠道：https://github.com/nayooooo/SerialAssistant\n";

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(Receive_Handler);
        }

        private void SerialAssistant_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_Transmit_Thread != null && _Transmit_Thread.IsAlive)
            {
                _Transmit_Thread.Abort();
            }
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
                        rx_config_stop_receive_btn.Enabled = false;
                        rx_config_stop_receive_btn.BackColor = SystemColors.Control;
                        _rx_Config_Context.is_receiving = false;

                        if (_Transmit_Thread != null && _Transmit_Thread.IsAlive)
                        {
                            _Transmit_Thread.Abort();
                        }
                        tx_config_stop_transmit_btn.Enabled = false;
                        tx_config_start_transmit_btn.Enabled = true;
                    }
                    else if (serial_config_port_cbb.SelectedIndex >= 0)
                    {  // to open
                        serialPort1.Open();

                        SerialPortOpened = true;
                        serial_config_open_btn.BackColor = SystemColors.HotTrack;
                        serial_config_port_cbb.Enabled = false;
                        rx_config_stop_receive_btn.Enabled = true;
                        _rx_Config_Context.is_receiving = true;
                    }
                    else
                    {  // not select
                        MessageBox.Show("必须先选择端口才可以打开串口！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + serialPort1.PortName.ToString());
                }
            }
        }

        private void RxConfig_btn_Click(object sender, EventArgs e)
        {
            if (sender == rx_config_clear_buff_btn)
            {
                rx_buff_rtb.Text = "";
            }
            else if (sender == rx_config_stop_receive_btn)
            {
                if (_rx_Config_Context.is_receiving)
                {  // stop receive
                    _rx_Config_Context.is_receiving = false;
                    rx_config_stop_receive_btn.BackColor = SystemColors.HotTrack;
                }
                else
                {  // continue receive
                    _rx_Config_Context.is_receiving = true;
                    rx_config_stop_receive_btn.BackColor = SystemColors.Control;
                }
            }
            else if (sender == rx_config_select_path_btn)
            {
                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog1.Title  = "选择保存路径";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rx_config_save_path_tb.Text = saveFileDialog1.FileName;
                    try
                    {
                        File.WriteAllText(rx_config_save_path_tb.Text, rx_buff_rtb.Text);
                        MessageBox.Show("文件保存成功");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString() + "文件保存失败");
                    }
                }
            }
            else if (sender == rx_config_save_buff_btn)
            {
                try
                {
                    File.WriteAllText(rx_config_save_path_tb.Text, rx_buff_rtb.Text);
                    MessageBox.Show("文件保存成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "文件保存失败");
                }
            }
        }

        private void RxConfig_rbtn_Click(object sender, EventArgs e)
        {
            if (sender == rx_config_show_text_rbtn)
            {
                if (_rx_Config_Context.show_Method == Text_Show_Method.Text)
                {
                    return;
                }
                _rx_Config_Context.show_Method = Text_Show_Method.Text;
                string temp = ConvertHexStringToString(rx_buff_rtb.Text, serialPort1.Encoding);
                if (temp != rx_buff_rtb.Text)
                {
                    rx_buff_rtb.Text = temp;
                }
            }
            else if (sender == rx_config_show_hex_rbtn)
            {
                if (_rx_Config_Context.show_Method == Text_Show_Method.Hex)
                {
                    return;
                }
                _rx_Config_Context.show_Method = Text_Show_Method.Hex;
                rx_buff_rtb.Text = ConvertStringToHexString(rx_buff_rtb.Text, serialPort1.Encoding);
            }
        }

        private void TxConfig_btn_Click(object sender, EventArgs e)
        {
            if (sender == tx_config_clear_buff_btn)
            {
                tx_buff_rtb.Text = "";
            }
            else if (sender == tx_config_stop_transmit_btn)
            {
                _tx_Config_Context.is_Sending = false;
                tx_config_stop_transmit_btn.Enabled = false;
                tx_config_start_transmit_btn.Enabled = true;
                if (_Transmit_Thread.IsAlive)
                {
                    _Transmit_Thread.Abort();
                    _Transmit_Thread.Join();
                }
            }
            else if (sender == tx_config_start_transmit_btn)
            {
                if (!(SerialPortOpened && serialPort1.IsOpen))
                {
                    MessageBox.Show("请先打开串口");
                    return;
                }
                if (!_tx_Config_Context.auto_Send)
                {  // 手动发送一次
                    Transmit_String(tx_buff_rtb.Text);
                }
                else
                {  // 自动发送
                    tx_config_start_transmit_btn.Enabled = false;
                    tx_config_stop_transmit_btn.Enabled = true;
                    _tx_Config_Context.is_Sending = true;
                    _Transmit_Thread = new Thread(new ThreadStart(Transmit_Thread_Enter));
                    _Transmit_Thread.Start();
                }
            }
        }

        private void TxConfig_rbtn_Click(object sender, EventArgs e)
        {
            if (sender == tx_config_show_text_rbtn)
            {
                if (_tx_Config_Context.show_Method == Text_Show_Method.Text)
                {
                    return;
                }
                _tx_Config_Context.show_Method = Text_Show_Method.Text;
                string temp = ConvertHexStringToString(_tx_Config_Context.hex, serialPort1.Encoding);
                if (temp != _tx_Config_Context.hex)
                {
                    tx_buff_rtb.Text = temp;
                }
            }
            else if (sender == tx_config_show_hex_rbtn)
            {
                if (_tx_Config_Context.show_Method == Text_Show_Method.Hex)
                {
                    return;
                }
                _tx_Config_Context.show_Method = Text_Show_Method.Hex;
                tx_buff_rtb.Text = ConvertStringToHexString(_tx_Config_Context.text, serialPort1.Encoding);
            }
        }

        private void TxConfig_ckb_Click(object sender, EventArgs e)
        {
            if (sender == tx_config_auto_send_ckb)
            {
                _tx_Config_Context.auto_Send = tx_config_auto_send_ckb.Checked;
            }
        }

        private void TxConfig_tb_TextChanged(object sender, EventArgs e)
        {
            if (sender == tx_config_auto_send_cycle_tb)
            {
                int value;

                if (!int.TryParse(tx_config_auto_send_cycle_tb.Text, out value) || value <= 0)
                {
                    tx_config_auto_send_cycle_tb.Text = "";
                    System.Media.SystemSounds.Beep.Play();
                }
            }
        }

        private void TxConfig_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender == tx_config_auto_send_cycle_tb)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    _tx_Config_Context.auto_Send_Cycle = int.Parse(tx_config_auto_send_cycle_tb.Text);
                }
            }
        }

        private void Buff_rtb_TextChanged(object sender, EventArgs e)
        {
            if (sender == tx_buff_rtb)
            {
                if (_tx_Config_Context.show_Method == Text_Show_Method.Text)
                {
                    _tx_Config_Context.text = tx_buff_rtb.Text;
                }
                else if (_tx_Config_Context.show_Method == Text_Show_Method.Hex)
                {
                    _tx_Config_Context.hex = tx_buff_rtb.Text;
                }
            }
        }
    }
}
