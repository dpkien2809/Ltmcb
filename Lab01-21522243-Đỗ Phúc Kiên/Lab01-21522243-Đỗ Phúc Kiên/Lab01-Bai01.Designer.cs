namespace Lab01_21522243_Đỗ_Phúc_Kiên
{
    partial class Form2
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
            this.tb_KQ = new System.Windows.Forms.TextBox();
            this.tb_STH = new System.Windows.Forms.TextBox();
            this.tb_STN = new System.Windows.Forms.TextBox();
            this.bt_Tong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // tb_KQ
            // 
            this.tb_KQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_KQ.Location = new System.Drawing.Point(224, 285);
            this.tb_KQ.Name = "tb_KQ";
            this.tb_KQ.Size = new System.Drawing.Size(242, 38);
            this.tb_KQ.TabIndex = 4;
            // 
            // tb_STH
            // 
            this.tb_STH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_STH.Location = new System.Drawing.Point(224, 203);
            this.tb_STH.Name = "tb_STH";
            this.tb_STH.Size = new System.Drawing.Size(242, 38);
            this.tb_STH.TabIndex = 5;
            // 
            // tb_STN
            // 
            this.tb_STN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_STN.Location = new System.Drawing.Point(224, 123);
            this.tb_STN.Name = "tb_STN";
            this.tb_STN.Size = new System.Drawing.Size(242, 38);
            this.tb_STN.TabIndex = 6;
            // 
            // bt_Tong
            // 
            this.bt_Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Tong.Location = new System.Drawing.Point(543, 195);
            this.bt_Tong.Name = "bt_Tong";
            this.bt_Tong.Size = new System.Drawing.Size(205, 59);
            this.bt_Tong.TabIndex = 7;
            this.bt_Tong.Text = "Tổng";
            this.bt_Tong.UseVisualStyleBackColor = true;
            this.bt_Tong.Click += new System.EventHandler(this.bt_Tong_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Tong);
            this.Controls.Add(this.tb_STN);
            this.Controls.Add(this.tb_STH);
            this.Controls.Add(this.tb_KQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Lab01-Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_KQ;
        private System.Windows.Forms.TextBox tb_STH;
        private System.Windows.Forms.TextBox tb_STN;
        private System.Windows.Forms.Button bt_Tong;
    }
}