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
            this.SuspendLayout();
            // 
            // button_port
            // 
            this.button_port.Location = new System.Drawing.Point(140, 12);
            this.button_port.Name = "button_port";
            this.button_port.Size = new System.Drawing.Size(88, 44);
            this.button_port.TabIndex = 0;
            this.button_port.Text = "Open";
            this.button_port.UseVisualStyleBackColor = true;
            this.button_port.Click += new System.EventHandler(this.button_open_Click);
            // 
            // listBox_ports
            // 
            this.listBox_ports.FormattingEnabled = true;
            this.listBox_ports.ItemHeight = 20;
            this.listBox_ports.Location = new System.Drawing.Point(14, 12);
            this.listBox_ports.Name = "listBox_ports";
            this.listBox_ports.Size = new System.Drawing.Size(120, 164);
            this.listBox_ports.TabIndex = 1;
            // 
            // button_port_close
            // 
            this.button_port_close.Location = new System.Drawing.Point(140, 62);
            this.button_port_close.Name = "button_port_close";
            this.button_port_close.Size = new System.Drawing.Size(88, 44);
            this.button_port_close.TabIndex = 2;
            this.button_port_close.Text = "Close";
            this.button_port_close.UseVisualStyleBackColor = true;
            this.button_port_close.Click += new System.EventHandler(this.button_port_close_Click);
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(528, 80);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(88, 44);
            this.button_test.TabIndex = 3;
            this.button_test.Text = "Send test";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // label_port_status
            // 
            this.label_port_status.AutoSize = true;
            this.label_port_status.Location = new System.Drawing.Point(156, 133);
            this.label_port_status.Name = "label_port_status";
            this.label_port_status.Size = new System.Drawing.Size(51, 20);
            this.label_port_status.TabIndex = 4;
            this.label_port_status.Text = "label1";
            this.label_port_status.Click += new System.EventHandler(this.label_port_status_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_port_status);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.button_port_close);
            this.Controls.Add(this.listBox_ports);
            this.Controls.Add(this.button_port);
            this.Name = "Form1";
            this.Text = "PCProg_GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_port;
        private System.Windows.Forms.ListBox listBox_ports;
        private System.Windows.Forms.Button button_port_close;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Label label_port_status;
    }
}

