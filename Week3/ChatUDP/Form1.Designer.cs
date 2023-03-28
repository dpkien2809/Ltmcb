namespace ChatUDP
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
            this.components = new System.ComponentModel.Container();
            this.tb_Send = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bt_Gui = new System.Windows.Forms.Button();
            this.bt_Ketnoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.tb_IpAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_LocalPort = new System.Windows.Forms.TextBox();
            this.lstReceived = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstSent = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Send
            // 
            this.tb_Send.Location = new System.Drawing.Point(10, 95);
            this.tb_Send.Multiline = true;
            this.tb_Send.Name = "tb_Send";
            this.tb_Send.Size = new System.Drawing.Size(613, 43);
            this.tb_Send.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bt_Gui
            // 
            this.bt_Gui.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Gui.Location = new System.Drawing.Point(663, 95);
            this.bt_Gui.Name = "bt_Gui";
            this.bt_Gui.Size = new System.Drawing.Size(89, 43);
            this.bt_Gui.TabIndex = 2;
            this.bt_Gui.Text = "Gửi";
            this.bt_Gui.UseVisualStyleBackColor = true;
            this.bt_Gui.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // bt_Ketnoi
            // 
            this.bt_Ketnoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Ketnoi.Location = new System.Drawing.Point(654, 37);
            this.bt_Ketnoi.Name = "bt_Ketnoi";
            this.bt_Ketnoi.Size = new System.Drawing.Size(108, 43);
            this.bt_Ketnoi.TabIndex = 3;
            this.bt_Ketnoi.Text = "Kết nối";
            this.bt_Ketnoi.UseVisualStyleBackColor = true;
            this.bt_Ketnoi.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cổng để truyền thông của A (ứng dụng 1): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thông số của máy B (ứng dụng 2):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Port);
            this.groupBox1.Controls.Add(this.tb_IpAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(513, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(90, 62);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(78, 20);
            this.tb_Port.TabIndex = 10;
            // 
            // tb_IpAddress
            // 
            this.tb_IpAddress.Location = new System.Drawing.Point(90, 27);
            this.tb_IpAddress.Name = "tb_IpAddress";
            this.tb_IpAddress.Size = new System.Drawing.Size(142, 20);
            this.tb_IpAddress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cổng (Port):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ IP:";
            // 
            // tb_LocalPort
            // 
            this.tb_LocalPort.Location = new System.Drawing.Point(512, 193);
            this.tb_LocalPort.Name = "tb_LocalPort";
            this.tb_LocalPort.Size = new System.Drawing.Size(113, 20);
            this.tb_LocalPort.TabIndex = 7;
            // 
            // lstReceived
            // 
            this.lstReceived.FormattingEnabled = true;
            this.lstReceived.Location = new System.Drawing.Point(10, 162);
            this.lstReceived.Name = "lstReceived";
            this.lstReceived.Size = new System.Drawing.Size(408, 173);
            this.lstReceived.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhập tin cần gửi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thông tin nhận về:";
            // 
            // lstSent
            // 
            this.lstSent.FormattingEnabled = true;
            this.lstSent.Location = new System.Drawing.Point(10, 356);
            this.lstSent.Name = "lstSent";
            this.lstSent.Size = new System.Drawing.Size(742, 82);
            this.lstSent.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(333, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "Client";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstSent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstReceived);
            this.Controls.Add(this.tb_LocalPort);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Ketnoi);
            this.Controls.Add(this.bt_Gui);
            this.Controls.Add(this.tb_Send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Send;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bt_Gui;
        private System.Windows.Forms.Button bt_Ketnoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_LocalPort;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.TextBox tb_IpAddress;
        private System.Windows.Forms.ListBox lstReceived;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstSent;
        private System.Windows.Forms.Label label7;
    }
}

