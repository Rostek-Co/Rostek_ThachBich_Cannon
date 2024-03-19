namespace TestZebraRFIDReader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rfid_host = new System.Windows.Forms.TextBox();
            this.rfid_port = new System.Windows.Forms.TextBox();
            this.broker_port = new System.Windows.Forms.TextBox();
            this.broker_host = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP_ADDRESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP_PORT";
            // 
            // rfid_host
            // 
            this.rfid_host.Location = new System.Drawing.Point(129, 48);
            this.rfid_host.Name = "rfid_host";
            this.rfid_host.Size = new System.Drawing.Size(127, 20);
            this.rfid_host.TabIndex = 2;
            this.rfid_host.Text = "169.254.140.214 ";
            this.rfid_host.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rfid_port
            // 
            this.rfid_port.Location = new System.Drawing.Point(129, 95);
            this.rfid_port.Name = "rfid_port";
            this.rfid_port.Size = new System.Drawing.Size(126, 20);
            this.rfid_port.TabIndex = 3;
            this.rfid_port.Text = "5084";
            this.rfid_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // broker_port
            // 
            this.broker_port.Location = new System.Drawing.Point(435, 95);
            this.broker_port.Name = "broker_port";
            this.broker_port.Size = new System.Drawing.Size(126, 20);
            this.broker_port.TabIndex = 7;
            this.broker_port.Text = "1883";
            this.broker_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // broker_host
            // 
            this.broker_host.Location = new System.Drawing.Point(435, 48);
            this.broker_host.Name = "broker_host";
            this.broker_host.Size = new System.Drawing.Size(127, 20);
            this.broker_host.TabIndex = 6;
            this.broker_host.Text = "127.0.0.1";
            this.broker_host.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP_PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "IP_ADDRESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "READER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "BROKER";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(215, 151);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(126, 20);
            this.time.TabIndex = 11;
            this.time.Text = "1000";
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "TIME";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 67);
            this.button2.TabIndex = 13;
            this.button2.Text = "CONNECT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.broker_port);
            this.Controls.Add(this.broker_host);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rfid_port);
            this.Controls.Add(this.rfid_host);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rfid_host;
        private System.Windows.Forms.TextBox rfid_port;
        private System.Windows.Forms.TextBox broker_port;
        private System.Windows.Forms.TextBox broker_host;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}