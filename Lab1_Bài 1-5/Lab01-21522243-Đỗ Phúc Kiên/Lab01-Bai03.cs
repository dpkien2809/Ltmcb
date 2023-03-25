using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_21522243_Đỗ_Phúc_Kiên
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int a;
        private void bt_Doc_Click(object sender, EventArgs e)
        {
            try
            {
                string Sotunhien = tb_NSN.Text;
                a = Int32.Parse(Sotunhien);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng kiểu số!");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Bạn cần nhập đủ giá trị!");
            }
            if (a == 0)
            {
                tb_KQ.Text = "Không";
            }
            else if (a == 1) 
            {
                tb_KQ.Text = "Một";
            }
            else if (a == 2)
            {
                tb_KQ.Text = "Hai";
            }
            else if (a == 3)
            {
                tb_KQ.Text = "Ba";
            }
            else if (a == 4)
            {
                tb_KQ.Text = "Bốn";
            }
            else if (a == 5)
            {
                tb_KQ.Text = "Năm";
            }
            else if (a == 6)
            {
                tb_KQ.Text = "Sáu";
            }
            else if (a == 7)
            {
                tb_KQ.Text = "Bảy";
            }
            else if (a == 8)
            {
                tb_KQ.Text = "Tám";
            }
            else if (a == 9)
            {
                tb_KQ.Text = "Chín";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số!");
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            tb_NSN.Text = "";
            tb_KQ.Text = "";
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}