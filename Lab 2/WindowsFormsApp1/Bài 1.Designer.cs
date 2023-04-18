namespace WindowsFormsApp1
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
            this.bt_Doc = new System.Windows.Forms.Button();
            this.bt_Ghi = new System.Windows.Forms.Button();
            this.showfile = new System.Windows.Forms.RichTextBox();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Doc
            // 
            this.bt_Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Doc.Location = new System.Drawing.Point(125, 87);
            this.bt_Doc.Name = "bt_Doc";
            this.bt_Doc.Size = new System.Drawing.Size(125, 38);
            this.bt_Doc.TabIndex = 0;
            this.bt_Doc.Text = "Đọc file";
            this.bt_Doc.UseVisualStyleBackColor = true;
            this.bt_Doc.Click += new System.EventHandler(this.bt_Doc_Click);
            // 
            // bt_Ghi
            // 
            this.bt_Ghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Ghi.Location = new System.Drawing.Point(125, 191);
            this.bt_Ghi.Name = "bt_Ghi";
            this.bt_Ghi.Size = new System.Drawing.Size(125, 38);
            this.bt_Ghi.TabIndex = 1;
            this.bt_Ghi.Text = "Ghi file";
            this.bt_Ghi.UseVisualStyleBackColor = true;
            // 
            // showfile
            // 
            this.showfile.Location = new System.Drawing.Point(324, 42);
            this.showfile.Name = "showfile";
            this.showfile.Size = new System.Drawing.Size(421, 315);
            this.showfile.TabIndex = 2;
            this.showfile.Text = "";
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(134, 282);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(105, 41);
            this.bt_Exit.TabIndex = 7;
            this.bt_Exit.Text = "Thoát";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.showfile);
            this.Controls.Add(this.bt_Ghi);
            this.Controls.Add(this.bt_Doc);
            this.Name = "Form2";
            this.Text = "Bài 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Doc;
        private System.Windows.Forms.Button bt_Ghi;
        private System.Windows.Forms.RichTextBox showfile;
        private System.Windows.Forms.Button bt_Exit;
    }
}