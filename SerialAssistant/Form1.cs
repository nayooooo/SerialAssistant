using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Serial
{
    public partial class SerialAssistant : System.Windows.Forms.Form
    {
        public SerialAssistant()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serial_config_port_cbb.Items.Add("COM3");
            serial_config_port_cbb.SelectedIndex = 0;
            serial_config_port_cbb.DropDownStyle = ComboBoxStyle.DropDownList;
            serial_config_baud_cbb.Items.Add("9600");
            serial_config_baud_cbb.Items.Add("19200");
            serial_config_baud_cbb.Items.Add("38400");
            serial_config_baud_cbb.Items.Add("57600");
            serial_config_baud_cbb.Items.Add("748800");
            serial_config_baud_cbb.Items.Add("115200");
            serial_config_baud_cbb.SelectedIndex = 5;
            serial_config_baud_cbb.DropDownStyle = ComboBoxStyle.DropDownList;

            rx_config_show_text_rbtn.Checked = true;
            rx_config_save_path_tb.Text = "";

            tx_config_show_text_rbtn.Checked = true;
            tx_config_auto_send_ckb.Checked = false;
            tx_config_auto_send_cycle_tb.Text = "1000";

            rx_buff_rtb.Text = "";

            tx_buff_rtb.Text  = "如果您在使用过程中发现任何BUG，欢迎向我提供反馈\n";
            tx_buff_rtb.Text += "反馈渠道：https://github.com/nayooooo/SerialAssistant";
        }

        private void serial_config_open_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SerialPortOpened)
                {
                    SerialPortOpened = false;
                    serial_config_open_btn.BackColor = SystemColors.Control;
                    serial_config_port_cbb.Enabled = true;
                    serial_config_baud_cbb.Enabled = true;
                }
                else
                {
                    SerialPortOpened = true;
                    serial_config_open_btn.BackColor = SystemColors.HotTrack;
                    serial_config_port_cbb.Enabled = false;
                    serial_config_baud_cbb.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private bool _SerialPortOpened = false;
        private bool SerialPortOpened
        {
            get { return _SerialPortOpened; }
            set { _SerialPortOpened = value; }
        }
    }
}
