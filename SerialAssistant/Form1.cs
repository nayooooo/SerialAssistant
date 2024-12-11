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
            serial_config_baud_cbb.Items.Add("9600");
            serial_config_baud_cbb.Items.Add("19200");
            serial_config_baud_cbb.Items.Add("38400");
            serial_config_baud_cbb.Items.Add("57600");
            serial_config_baud_cbb.Items.Add("748800");
            serial_config_baud_cbb.Items.Add("115200");
            serial_config_baud_cbb.SelectedIndex = 5;

            rx_config_show_text_rbtn.Checked = true;

            tx_config_show_text_rbtn.Checked = true;
            tx_config_auto_send_cycle_tb.Text = "1000";
        }
    }
}
