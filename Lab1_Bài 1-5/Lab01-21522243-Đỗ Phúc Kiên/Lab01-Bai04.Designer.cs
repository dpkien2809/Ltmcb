namespace Lab01_21522243_Đỗ_Phúc_Kiên
{
    partial class Form5
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_STCD = new System.Windows.Forms.TextBox();
            this.tb_STDD = new System.Windows.Forms.TextBox();
            this.bt_Chuyendoi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tb_TGQD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyển đổi tiền tệ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền cần đổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiền đã đổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tỷ giá quy đổi:";
            // 
            // tb_STCD
            // 
            this.tb_STCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_STCD.Location = new System.Drawing.Point(196, 97);
            this.tb_STCD.Name = "tb_STCD";
            this.tb_STCD.Size = new System.Drawing.Size(204, 26);
            this.tb_STCD.TabIndex = 4;
            // 
            // tb_STDD
            // 
            this.tb_STDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_STDD.Location = new System.Drawing.Point(196, 249);
            this.tb_STDD.Name = "tb_STDD";
            this.tb_STDD.Size = new System.Drawing.Size(204, 26);
            this.tb_STDD.TabIndex = 5;
            // 
            // bt_Chuyendoi
            // 
            this.bt_Chuyendoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Chuyendoi.Location = new System.Drawing.Point(45, 169);
            this.bt_Chuyendoi.Name = "bt_Chuyendoi";
            this.bt_Chuyendoi.Size = new System.Drawing.Size(355, 37);
            this.bt_Chuyendoi.TabIndex = 7;
            this.bt_Chuyendoi.Text = "Chuyển đổi";
            this.bt_Chuyendoi.UseVisualStyleBackColor = true;
            this.bt_Chuyendoi.Click += new System.EventHandler(this.bt_Chuyendoi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "USD (Đô-la Mỹ)",
            "EUR (Đồng ơ-rô)",
            "GBP (Bảng Anh)",
            "SGD (Đô-la Singapore)",
            "JPY (Yên Nhật)"});
            this.comboBox1.Location = new System.Drawing.Point(467, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // tb_TGQD
            // 
            this.tb_TGQD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TGQD.Location = new System.Drawing.Point(196, 332);
            this.tb_TGQD.Name = "tb_TGQD";
            this.tb_TGQD.Size = new System.Drawing.Size(204, 26);
            this.tb_TGQD.TabIndex = 9;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_TGQD);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_Chuyendoi);
            this.Controls.Add(this.tb_STDD);
            this.Controls.Add(this.tb_STCD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Lab01-Bai04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_STCD;
        private System.Windows.Forms.TextBox tb_STDD;
        private System.Windows.Forms.Button bt_Chuyendoi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tb_TGQD;
    }
}