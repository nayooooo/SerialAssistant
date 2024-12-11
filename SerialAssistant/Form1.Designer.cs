namespace Serial
{
    partial class SerialAssistant
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.rx_buff_rtb = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rx_config_show_text_rbtn = new System.Windows.Forms.RadioButton();
            this.rx_config_save_path_tb = new System.Windows.Forms.TextBox();
            this.rx_config_select_path_btn = new System.Windows.Forms.Button();
            this.rx_config_show_hex_rbtn = new System.Windows.Forms.RadioButton();
            this.rx_config_save_buff_btn = new System.Windows.Forms.Button();
            this.rx_config_clear_buff_btn = new System.Windows.Forms.Button();
            this.rx_config_stop_receive_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tx_config_show_hex_rbtn = new System.Windows.Forms.RadioButton();
            this.tx_config_clear_buff_btn = new System.Windows.Forms.Button();
            this.tx_config_show_text_rbtn = new System.Windows.Forms.RadioButton();
            this.tx_config_stop_transmit_btn = new System.Windows.Forms.Button();
            this.tx_config_start_transmit_btn = new System.Windows.Forms.Button();
            this.tx_config_auto_send_ckb = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_config_auto_send_cycle_tb = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serial_config_open_btn = new System.Windows.Forms.Button();
            this.serial_config_port_cbb = new System.Windows.Forms.ComboBox();
            this.serial_config_baud_cbb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_buff_rtb = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tx_status_transmit_counter = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tx_status_receive_counter = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.serial_config_encode_cbb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rx_buff_rtb
            // 
            this.rx_buff_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rx_buff_rtb.Location = new System.Drawing.Point(3, 17);
            this.rx_buff_rtb.Name = "rx_buff_rtb";
            this.rx_buff_rtb.Size = new System.Drawing.Size(443, 270);
            this.rx_buff_rtb.TabIndex = 3;
            this.rx_buff_rtb.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rx_buff_rtb);
            this.groupBox4.Location = new System.Drawing.Point(218, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 290);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // rx_config_show_text_rbtn
            // 
            this.rx_config_show_text_rbtn.AutoSize = true;
            this.rx_config_show_text_rbtn.Location = new System.Drawing.Point(18, 25);
            this.rx_config_show_text_rbtn.Name = "rx_config_show_text_rbtn";
            this.rx_config_show_text_rbtn.Size = new System.Drawing.Size(71, 16);
            this.rx_config_show_text_rbtn.TabIndex = 6;
            this.rx_config_show_text_rbtn.TabStop = true;
            this.rx_config_show_text_rbtn.Text = "文本显示";
            this.rx_config_show_text_rbtn.UseVisualStyleBackColor = true;
            // 
            // rx_config_save_path_tb
            // 
            this.rx_config_save_path_tb.Location = new System.Drawing.Point(18, 109);
            this.rx_config_save_path_tb.Name = "rx_config_save_path_tb";
            this.rx_config_save_path_tb.Size = new System.Drawing.Size(166, 21);
            this.rx_config_save_path_tb.TabIndex = 6;
            // 
            // rx_config_select_path_btn
            // 
            this.rx_config_select_path_btn.Location = new System.Drawing.Point(18, 80);
            this.rx_config_select_path_btn.Name = "rx_config_select_path_btn";
            this.rx_config_select_path_btn.Size = new System.Drawing.Size(75, 23);
            this.rx_config_select_path_btn.TabIndex = 6;
            this.rx_config_select_path_btn.Text = "选择路径";
            this.rx_config_select_path_btn.UseVisualStyleBackColor = true;
            // 
            // rx_config_show_hex_rbtn
            // 
            this.rx_config_show_hex_rbtn.AutoSize = true;
            this.rx_config_show_hex_rbtn.Location = new System.Drawing.Point(18, 54);
            this.rx_config_show_hex_rbtn.Name = "rx_config_show_hex_rbtn";
            this.rx_config_show_hex_rbtn.Size = new System.Drawing.Size(71, 16);
            this.rx_config_show_hex_rbtn.TabIndex = 7;
            this.rx_config_show_hex_rbtn.TabStop = true;
            this.rx_config_show_hex_rbtn.Text = "十六进制";
            this.rx_config_show_hex_rbtn.UseVisualStyleBackColor = true;
            // 
            // rx_config_save_buff_btn
            // 
            this.rx_config_save_buff_btn.Location = new System.Drawing.Point(109, 80);
            this.rx_config_save_buff_btn.Name = "rx_config_save_buff_btn";
            this.rx_config_save_buff_btn.Size = new System.Drawing.Size(75, 23);
            this.rx_config_save_buff_btn.TabIndex = 6;
            this.rx_config_save_buff_btn.Text = "保存数据";
            this.rx_config_save_buff_btn.UseVisualStyleBackColor = true;
            // 
            // rx_config_clear_buff_btn
            // 
            this.rx_config_clear_buff_btn.Location = new System.Drawing.Point(109, 22);
            this.rx_config_clear_buff_btn.Name = "rx_config_clear_buff_btn";
            this.rx_config_clear_buff_btn.Size = new System.Drawing.Size(75, 23);
            this.rx_config_clear_buff_btn.TabIndex = 6;
            this.rx_config_clear_buff_btn.Text = "清空缓冲区";
            this.rx_config_clear_buff_btn.UseVisualStyleBackColor = true;
            // 
            // rx_config_stop_receive_btn
            // 
            this.rx_config_stop_receive_btn.Location = new System.Drawing.Point(109, 51);
            this.rx_config_stop_receive_btn.Name = "rx_config_stop_receive_btn";
            this.rx_config_stop_receive_btn.Size = new System.Drawing.Size(75, 23);
            this.rx_config_stop_receive_btn.TabIndex = 6;
            this.rx_config_stop_receive_btn.Text = "暂停接收";
            this.rx_config_stop_receive_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rx_config_stop_receive_btn);
            this.groupBox2.Controls.Add(this.rx_config_clear_buff_btn);
            this.groupBox2.Controls.Add(this.rx_config_save_buff_btn);
            this.groupBox2.Controls.Add(this.rx_config_show_hex_rbtn);
            this.groupBox2.Controls.Add(this.rx_config_select_path_btn);
            this.groupBox2.Controls.Add(this.rx_config_save_path_tb);
            this.groupBox2.Controls.Add(this.rx_config_show_text_rbtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 139);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // tx_config_show_hex_rbtn
            // 
            this.tx_config_show_hex_rbtn.AutoSize = true;
            this.tx_config_show_hex_rbtn.Location = new System.Drawing.Point(18, 56);
            this.tx_config_show_hex_rbtn.Name = "tx_config_show_hex_rbtn";
            this.tx_config_show_hex_rbtn.Size = new System.Drawing.Size(71, 16);
            this.tx_config_show_hex_rbtn.TabIndex = 7;
            this.tx_config_show_hex_rbtn.TabStop = true;
            this.tx_config_show_hex_rbtn.Text = "十六进制";
            this.tx_config_show_hex_rbtn.UseVisualStyleBackColor = true;
            // 
            // tx_config_clear_buff_btn
            // 
            this.tx_config_clear_buff_btn.Location = new System.Drawing.Point(109, 24);
            this.tx_config_clear_buff_btn.Name = "tx_config_clear_buff_btn";
            this.tx_config_clear_buff_btn.Size = new System.Drawing.Size(75, 23);
            this.tx_config_clear_buff_btn.TabIndex = 6;
            this.tx_config_clear_buff_btn.Text = "清空缓冲区";
            this.tx_config_clear_buff_btn.UseVisualStyleBackColor = true;
            // 
            // tx_config_show_text_rbtn
            // 
            this.tx_config_show_text_rbtn.AutoSize = true;
            this.tx_config_show_text_rbtn.Location = new System.Drawing.Point(18, 27);
            this.tx_config_show_text_rbtn.Name = "tx_config_show_text_rbtn";
            this.tx_config_show_text_rbtn.Size = new System.Drawing.Size(71, 16);
            this.tx_config_show_text_rbtn.TabIndex = 6;
            this.tx_config_show_text_rbtn.TabStop = true;
            this.tx_config_show_text_rbtn.Text = "文本显示";
            this.tx_config_show_text_rbtn.UseVisualStyleBackColor = true;
            // 
            // tx_config_stop_transmit_btn
            // 
            this.tx_config_stop_transmit_btn.Location = new System.Drawing.Point(109, 53);
            this.tx_config_stop_transmit_btn.Name = "tx_config_stop_transmit_btn";
            this.tx_config_stop_transmit_btn.Size = new System.Drawing.Size(75, 23);
            this.tx_config_stop_transmit_btn.TabIndex = 6;
            this.tx_config_stop_transmit_btn.Text = "暂停发送";
            this.tx_config_stop_transmit_btn.UseVisualStyleBackColor = true;
            // 
            // tx_config_start_transmit_btn
            // 
            this.tx_config_start_transmit_btn.Location = new System.Drawing.Point(109, 82);
            this.tx_config_start_transmit_btn.Name = "tx_config_start_transmit_btn";
            this.tx_config_start_transmit_btn.Size = new System.Drawing.Size(75, 23);
            this.tx_config_start_transmit_btn.TabIndex = 6;
            this.tx_config_start_transmit_btn.Text = "开始发送";
            this.tx_config_start_transmit_btn.UseVisualStyleBackColor = true;
            this.tx_config_start_transmit_btn.Click += new System.EventHandler(this.TxConfig_btn_Click);
            // 
            // tx_config_auto_send_ckb
            // 
            this.tx_config_auto_send_ckb.AutoSize = true;
            this.tx_config_auto_send_ckb.Location = new System.Drawing.Point(18, 86);
            this.tx_config_auto_send_ckb.Name = "tx_config_auto_send_ckb";
            this.tx_config_auto_send_ckb.Size = new System.Drawing.Size(72, 16);
            this.tx_config_auto_send_ckb.TabIndex = 6;
            this.tx_config_auto_send_ckb.Text = "自动发送";
            this.tx_config_auto_send_ckb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "自动发送周期（ms）";
            // 
            // tx_config_auto_send_cycle_tb
            // 
            this.tx_config_auto_send_cycle_tb.Location = new System.Drawing.Point(135, 113);
            this.tx_config_auto_send_cycle_tb.Name = "tx_config_auto_send_cycle_tb";
            this.tx_config_auto_send_cycle_tb.Size = new System.Drawing.Size(49, 21);
            this.tx_config_auto_send_cycle_tb.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tx_config_auto_send_cycle_tb);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tx_config_auto_send_ckb);
            this.groupBox3.Controls.Add(this.tx_config_start_transmit_btn);
            this.groupBox3.Controls.Add(this.tx_config_stop_transmit_btn);
            this.groupBox3.Controls.Add(this.tx_config_show_text_rbtn);
            this.groupBox3.Controls.Add(this.tx_config_clear_buff_btn);
            this.groupBox3.Controls.Add(this.tx_config_show_hex_rbtn);
            this.groupBox3.Location = new System.Drawing.Point(12, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 145);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serial_config_open_btn
            // 
            this.serial_config_open_btn.BackColor = System.Drawing.SystemColors.Control;
            this.serial_config_open_btn.Location = new System.Drawing.Point(18, 107);
            this.serial_config_open_btn.Name = "serial_config_open_btn";
            this.serial_config_open_btn.Size = new System.Drawing.Size(166, 32);
            this.serial_config_open_btn.TabIndex = 1;
            this.serial_config_open_btn.Text = "打开串口";
            this.serial_config_open_btn.UseVisualStyleBackColor = false;
            this.serial_config_open_btn.Click += new System.EventHandler(this.SerialConfig_btn_Click);
            // 
            // serial_config_port_cbb
            // 
            this.serial_config_port_cbb.FormattingEnabled = true;
            this.serial_config_port_cbb.Location = new System.Drawing.Point(63, 29);
            this.serial_config_port_cbb.Name = "serial_config_port_cbb";
            this.serial_config_port_cbb.Size = new System.Drawing.Size(121, 20);
            this.serial_config_port_cbb.TabIndex = 2;
            this.serial_config_port_cbb.DropDown += new System.EventHandler(this.SerialConfig_cbb_DropDown);
            this.serial_config_port_cbb.SelectedIndexChanged += new System.EventHandler(this.SerialConfig_cbb_SelectedIndexChanged);
            // 
            // serial_config_baud_cbb
            // 
            this.serial_config_baud_cbb.FormattingEnabled = true;
            this.serial_config_baud_cbb.Location = new System.Drawing.Point(63, 55);
            this.serial_config_baud_cbb.Name = "serial_config_baud_cbb";
            this.serial_config_baud_cbb.Size = new System.Drawing.Size(121, 20);
            this.serial_config_baud_cbb.TabIndex = 2;
            this.serial_config_baud_cbb.SelectedIndexChanged += new System.EventHandler(this.SerialConfig_cbb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.serial_config_encode_cbb);
            this.groupBox1.Controls.Add(this.serial_config_baud_cbb);
            this.groupBox1.Controls.Add(this.serial_config_port_cbb);
            this.groupBox1.Controls.Add(this.serial_config_open_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // tx_buff_rtb
            // 
            this.tx_buff_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tx_buff_rtb.Location = new System.Drawing.Point(3, 17);
            this.tx_buff_rtb.Name = "tx_buff_rtb";
            this.tx_buff_rtb.Size = new System.Drawing.Size(440, 119);
            this.tx_buff_rtb.TabIndex = 0;
            this.tx_buff_rtb.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tx_buff_rtb);
            this.groupBox5.Location = new System.Drawing.Point(218, 313);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(446, 139);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "状态：";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.AutoSize = false;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel2.Text = "发送计数：";
            // 
            // tx_status_transmit_counter
            // 
            this.tx_status_transmit_counter.AutoSize = false;
            this.tx_status_transmit_counter.Name = "tx_status_transmit_counter";
            this.tx_status_transmit_counter.Size = new System.Drawing.Size(80, 17);
            this.tx_status_transmit_counter.Text = "0";
            this.tx_status_transmit_counter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel4.Text = "接收计数：";
            // 
            // tx_status_receive_counter
            // 
            this.tx_status_receive_counter.AutoSize = false;
            this.tx_status_receive_counter.Name = "tx_status_receive_counter";
            this.tx_status_receive_counter.Size = new System.Drawing.Size(80, 17);
            this.tx_status_receive_counter.Text = "0";
            this.tx_status_receive_counter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel2,
            this.tx_status_transmit_counter,
            this.toolStripStatusLabel4,
            this.tx_status_receive_counter});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(680, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // serial_config_encode_cbb
            // 
            this.serial_config_encode_cbb.FormattingEnabled = true;
            this.serial_config_encode_cbb.Location = new System.Drawing.Point(63, 81);
            this.serial_config_encode_cbb.Name = "serial_config_encode_cbb";
            this.serial_config_encode_cbb.Size = new System.Drawing.Size(121, 20);
            this.serial_config_encode_cbb.TabIndex = 3;
            this.serial_config_encode_cbb.SelectedIndexChanged += new System.EventHandler(this.SerialConfig_cbb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "编码";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SerialAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 482);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "SerialAssistant";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox rx_buff_rtb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rx_config_show_text_rbtn;
        private System.Windows.Forms.TextBox rx_config_save_path_tb;
        private System.Windows.Forms.Button rx_config_select_path_btn;
        private System.Windows.Forms.RadioButton rx_config_show_hex_rbtn;
        private System.Windows.Forms.Button rx_config_save_buff_btn;
        private System.Windows.Forms.Button rx_config_clear_buff_btn;
        private System.Windows.Forms.Button rx_config_stop_receive_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton tx_config_show_hex_rbtn;
        private System.Windows.Forms.Button tx_config_clear_buff_btn;
        private System.Windows.Forms.RadioButton tx_config_show_text_rbtn;
        private System.Windows.Forms.Button tx_config_stop_transmit_btn;
        private System.Windows.Forms.Button tx_config_start_transmit_btn;
        private System.Windows.Forms.CheckBox tx_config_auto_send_ckb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_config_auto_send_cycle_tb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button serial_config_open_btn;
        private System.Windows.Forms.ComboBox serial_config_port_cbb;
        private System.Windows.Forms.ComboBox serial_config_baud_cbb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tx_buff_rtb;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tx_status_transmit_counter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tx_status_receive_counter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox serial_config_encode_cbb;
    }
}

