namespace ProgPC_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_port = new System.Windows.Forms.Button();
            this.listBox_ports = new System.Windows.Forms.ListBox();
            this.button_port_close = new System.Windows.Forms.Button();
            this.button_test = new System.Windows.Forms.Button();
            this.label_port_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_suspend = new System.Windows.Forms.Button();
            this.button_resume = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.textBox_adr = new System.Windows.Forms.TextBox();
            this.label_adr = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.button_port_write = new System.Windows.Forms.Button();
            this.button_port_read = new System.Windows.Forms.Button();
            this.textBox_debug = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_byte_write = new System.Windows.Forms.Button();
            this.button_byte_read = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_read_resuolt = new System.Windows.Forms.Label();
            this.textBox_read_result = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_port
            // 
            this.button_port.Location = new System.Drawing.Point(93, 8);
            this.button_port.Margin = new System.Windows.Forms.Padding(2);
            this.button_port.Name = "button_port";
            this.button_port.Size = new System.Drawing.Size(59, 29);
            this.button_port.TabIndex = 0;
            this.button_port.Text = "Open";
            this.button_port.UseVisualStyleBackColor = true;
            this.button_port.Click += new System.EventHandler(this.button_open_Click);
            // 
            // listBox_ports
            // 
            this.listBox_ports.FormattingEnabled = true;
            this.listBox_ports.Location = new System.Drawing.Point(9, 8);
            this.listBox_ports.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_ports.Name = "listBox_ports";
            this.listBox_ports.Size = new System.Drawing.Size(81, 108);
            this.listBox_ports.TabIndex = 1;
            // 
            // button_port_close
            // 
            this.button_port_close.Location = new System.Drawing.Point(93, 40);
            this.button_port_close.Margin = new System.Windows.Forms.Padding(2);
            this.button_port_close.Name = "button_port_close";
            this.button_port_close.Size = new System.Drawing.Size(59, 29);
            this.button_port_close.TabIndex = 2;
            this.button_port_close.Text = "Close";
            this.button_port_close.UseVisualStyleBackColor = true;
            this.button_port_close.Click += new System.EventHandler(this.button_port_close_Click);
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(179, 8);
            this.button_test.Margin = new System.Windows.Forms.Padding(2);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(59, 29);
            this.button_test.TabIndex = 3;
            this.button_test.Text = "Send test";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // label_port_status
            // 
            this.label_port_status.AutoSize = true;
            this.label_port_status.Location = new System.Drawing.Point(104, 86);
            this.label_port_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_port_status.Name = "label_port_status";
            this.label_port_status.Size = new System.Drawing.Size(35, 13);
            this.label_port_status.TabIndex = 4;
            this.label_port_status.Text = "label1";
            this.label_port_status.Click += new System.EventHandler(this.label_port_status_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_suspend
            // 
            this.button_suspend.Location = new System.Drawing.Point(9, 124);
            this.button_suspend.Margin = new System.Windows.Forms.Padding(2);
            this.button_suspend.Name = "button_suspend";
            this.button_suspend.Size = new System.Drawing.Size(86, 29);
            this.button_suspend.TabIndex = 6;
            this.button_suspend.Text = "Z80 suspend";
            this.button_suspend.UseVisualStyleBackColor = true;
            this.button_suspend.Click += new System.EventHandler(this.button_suspend_Click);
            // 
            // button_resume
            // 
            this.button_resume.Location = new System.Drawing.Point(9, 157);
            this.button_resume.Margin = new System.Windows.Forms.Padding(2);
            this.button_resume.Name = "button_resume";
            this.button_resume.Size = new System.Drawing.Size(86, 29);
            this.button_resume.TabIndex = 7;
            this.button_resume.Text = "Z80 resume";
            this.button_resume.UseVisualStyleBackColor = true;
            this.button_resume.Click += new System.EventHandler(this.button_resume_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(9, 190);
            this.button_reset.Margin = new System.Windows.Forms.Padding(2);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(86, 29);
            this.button_reset.TabIndex = 8;
            this.button_reset.Text = "Z80 reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // textBox_adr
            // 
            this.textBox_adr.Location = new System.Drawing.Point(63, 25);
            this.textBox_adr.Name = "textBox_adr";
            this.textBox_adr.Size = new System.Drawing.Size(43, 20);
            this.textBox_adr.TabIndex = 9;
            this.textBox_adr.TextChanged += new System.EventHandler(this.textBox_adr_TextChanged);
            // 
            // label_adr
            // 
            this.label_adr.AutoSize = true;
            this.label_adr.Location = new System.Drawing.Point(13, 28);
            this.label_adr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_adr.Name = "label_adr";
            this.label_adr.Size = new System.Drawing.Size(45, 13);
            this.label_adr.TabIndex = 10;
            this.label_adr.Text = "Address";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Location = new System.Drawing.Point(13, 53);
            this.label_data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(30, 13);
            this.label_data.TabIndex = 12;
            this.label_data.Text = "Data";
            // 
            // textBox_data
            // 
            this.textBox_data.Location = new System.Drawing.Point(63, 50);
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(43, 20);
            this.textBox_data.TabIndex = 11;
            this.textBox_data.TextChanged += new System.EventHandler(this.textBox_data_TextChanged);
            // 
            // button_port_write
            // 
            this.button_port_write.Location = new System.Drawing.Point(21, 98);
            this.button_port_write.Margin = new System.Windows.Forms.Padding(2);
            this.button_port_write.Name = "button_port_write";
            this.button_port_write.Size = new System.Drawing.Size(85, 27);
            this.button_port_write.TabIndex = 13;
            this.button_port_write.Text = "Port write";
            this.button_port_write.UseVisualStyleBackColor = true;
            this.button_port_write.Click += new System.EventHandler(this.button_port_write_Click);
            // 
            // button_port_read
            // 
            this.button_port_read.Location = new System.Drawing.Point(21, 130);
            this.button_port_read.Margin = new System.Windows.Forms.Padding(2);
            this.button_port_read.Name = "button_port_read";
            this.button_port_read.Size = new System.Drawing.Size(85, 27);
            this.button_port_read.TabIndex = 14;
            this.button_port_read.Text = "Port read";
            this.button_port_read.UseVisualStyleBackColor = true;
            this.button_port_read.Click += new System.EventHandler(this.button_port_read_Click);
            // 
            // textBox_debug
            // 
            this.textBox_debug.Location = new System.Drawing.Point(107, 140);
            this.textBox_debug.Name = "textBox_debug";
            this.textBox_debug.Size = new System.Drawing.Size(43, 20);
            this.textBox_debug.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // button_byte_write
            // 
            this.button_byte_write.Location = new System.Drawing.Point(110, 98);
            this.button_byte_write.Margin = new System.Windows.Forms.Padding(2);
            this.button_byte_write.Name = "button_byte_write";
            this.button_byte_write.Size = new System.Drawing.Size(85, 27);
            this.button_byte_write.TabIndex = 17;
            this.button_byte_write.Text = "Byte write";
            this.button_byte_write.UseVisualStyleBackColor = true;
            this.button_byte_write.Click += new System.EventHandler(this.button_byte_write_Click);
            // 
            // button_byte_read
            // 
            this.button_byte_read.Location = new System.Drawing.Point(110, 129);
            this.button_byte_read.Margin = new System.Windows.Forms.Padding(2);
            this.button_byte_read.Name = "button_byte_read";
            this.button_byte_read.Size = new System.Drawing.Size(85, 27);
            this.button_byte_read.TabIndex = 18;
            this.button_byte_read.Text = "Byte read";
            this.button_byte_read.UseVisualStyleBackColor = true;
            this.button_byte_read.Click += new System.EventHandler(this.button_byte_read_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_read_result);
            this.groupBox1.Controls.Add(this.label_read_resuolt);
            this.groupBox1.Controls.Add(this.button_port_write);
            this.groupBox1.Controls.Add(this.button_byte_read);
            this.groupBox1.Controls.Add(this.textBox_adr);
            this.groupBox1.Controls.Add(this.button_byte_write);
            this.groupBox1.Controls.Add(this.label_adr);
            this.groupBox1.Controls.Add(this.textBox_data);
            this.groupBox1.Controls.Add(this.label_data);
            this.groupBox1.Controls.Add(this.button_port_read);
            this.groupBox1.Location = new System.Drawing.Point(9, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 177);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read/Write";
            // 
            // label_read_resuolt
            // 
            this.label_read_resuolt.AutoSize = true;
            this.label_read_resuolt.Location = new System.Drawing.Point(121, 25);
            this.label_read_resuolt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_read_resuolt.Name = "label_read_resuolt";
            this.label_read_resuolt.Size = new System.Drawing.Size(61, 13);
            this.label_read_resuolt.TabIndex = 20;
            this.label_read_resuolt.Text = "Read result";
            // 
            // textBox_read_result
            // 
            this.textBox_read_result.Location = new System.Drawing.Point(124, 50);
            this.textBox_read_result.Name = "textBox_read_result";
            this.textBox_read_result.Size = new System.Drawing.Size(43, 20);
            this.textBox_read_result.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_debug);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_resume);
            this.Controls.Add(this.button_suspend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_port_status);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.button_port_close);
            this.Controls.Add(this.listBox_ports);
            this.Controls.Add(this.button_port);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "PCProg_GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_port;
        private System.Windows.Forms.ListBox listBox_ports;
        private System.Windows.Forms.Button button_port_close;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Label label_port_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_suspend;
        private System.Windows.Forms.Button button_resume;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.TextBox textBox_adr;
        private System.Windows.Forms.Label label_adr;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.TextBox textBox_data;
        private System.Windows.Forms.Button button_port_write;
        private System.Windows.Forms.Button button_port_read;
        private System.Windows.Forms.TextBox textBox_debug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_byte_write;
        private System.Windows.Forms.Button button_byte_read;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_read_result;
        private System.Windows.Forms.Label label_read_resuolt;
    }
}

