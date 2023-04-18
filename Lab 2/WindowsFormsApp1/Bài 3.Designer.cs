namespace WindowsFormsApp1
{
    partial class Form4
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
            this.showfile = new System.Windows.Forms.RichTextBox();
            this.bt_DocTinh = new System.Windows.Forms.Button();
            this.bt_TinhGhi = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showfile
            // 
            this.showfile.Location = new System.Drawing.Point(74, 123);
            this.showfile.Name = "showfile";
            this.showfile.Size = new System.Drawing.Size(624, 315);
            this.showfile.TabIndex = 3;
            this.showfile.Text = "";
            // 
            // bt_DocTinh
            // 
            this.bt_DocTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DocTinh.Location = new System.Drawing.Point(45, 52);
            this.bt_DocTinh.Name = "bt_DocTinh";
            this.bt_DocTinh.Size = new System.Drawing.Size(142, 50);
            this.bt_DocTinh.TabIndex = 4;
            this.bt_DocTinh.Text = "Đọc + tính file";
            this.bt_DocTinh.UseVisualStyleBackColor = true;
            this.bt_DocTinh.Click += new System.EventHandler(this.bt_DocTinh_Click);
            // 
            // bt_TinhGhi
            // 
            this.bt_TinhGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TinhGhi.Location = new System.Drawing.Point(230, 52);
            this.bt_TinhGhi.Name = "bt_TinhGhi";
            this.bt_TinhGhi.Size = new System.Drawing.Size(125, 50);
            this.bt_TinhGhi.TabIndex = 5;
            this.bt_TinhGhi.Text = "Ghi file";
            this.bt_TinhGhi.UseVisualStyleBackColor = true;
            this.bt_TinhGhi.Click += new System.EventHandler(this.bt_Ghi_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(593, 52);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(105, 50);
            this.bt_Exit.TabIndex = 8;
            this.bt_Exit.Text = "Thoát";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.Location = new System.Drawing.Point(403, 52);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(150, 50);
            this.bt_Xoa.TabIndex = 9;
            this.bt_Xoa.Text = "Xóa màn hình";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_TinhGhi);
            this.Controls.Add(this.bt_DocTinh);
            this.Controls.Add(this.showfile);
            this.Name = "Form4";
            this.Text = "Bài 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox showfile;
        private System.Windows.Forms.Button bt_DocTinh;
        private System.Windows.Forms.Button bt_TinhGhi;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_Xoa;
    }
}