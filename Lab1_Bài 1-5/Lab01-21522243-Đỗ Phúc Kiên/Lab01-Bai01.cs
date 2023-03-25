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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bt_Tong_Click(object sender, EventArgs e)
        {
            try
            {
                string Sothunhat = tb_STN.Text;
                string Sothuhai = tb_STH.Text;
                int a = Int32.Parse(Sothunhat);
                int b = Int32.Parse(Sothuhai);
                int Ketqua = a + b;
                tb_KQ.Text = Ketqua.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Bạn cần nhập đủ giá trị!");
            }
        }
    }
}
