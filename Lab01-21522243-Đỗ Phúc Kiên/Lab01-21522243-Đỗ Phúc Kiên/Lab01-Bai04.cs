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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        double a;
        private void bt_Chuyendoi_Click(object sender, EventArgs e)
        {
            try
            {
                string Sotiencandoi = tb_STCD.Text;
                 a = double.Parse(Sotiencandoi);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng kiểu số!");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Bạn cần nhập đủ giá trị!");
            }
            if (comboBox1.Text == "USD (Đô-la Mỹ)")
            {
                double Ketqua = a * 22772;
                tb_STDD.Text = Ketqua.ToString();
                tb_TGQD.Text = "1 USD = 22,772 VNĐ";
            }
            else if (comboBox1.Text == "EUR (Đồng ơ-rô)")
            {
                double Ketqua = a * 28132;
                tb_STDD.Text = Ketqua.ToString();
                tb_TGQD.Text = "1 EUR = 28,132 VNĐ";
            }
            else if (comboBox1.Text == "GBP (Bảng Anh)")
            {
                double Ketqua = a * 31538;
                tb_STDD.Text = Ketqua.ToString();
                tb_TGQD.Text = "1 GBP = 31,538 VNĐ";
            }
            else if (comboBox1.Text == "SGD (Đô-la Singapore)")
            {
                double Ketqua = a * 17286;
                tb_STDD.Text = Ketqua.ToString();
                tb_TGQD.Text = "1 SGD = 17,286 VNĐ";
            }
            else if (comboBox1.Text == "JPY (Yên Nhật)")
            {
                double Ketqua = a * 214;
                tb_STDD.Text = Ketqua.ToString();
                tb_TGQD.Text = "1 USD = 214 VNĐ";
            }
        }
    }
}
