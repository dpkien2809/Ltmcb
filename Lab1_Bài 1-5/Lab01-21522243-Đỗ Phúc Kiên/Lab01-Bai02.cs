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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bt_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                string Sothunhat = tb_STN.Text;
                string Sothuhai = tb_STH.Text;
                string Sothuba = tb_STB.Text;
                double a = Double.Parse(Sothunhat);
                double b = Double.Parse(Sothuhai);
                double c = Double.Parse(Sothuba);   
                double Solonnhat = 0;
                if (a > Solonnhat)
                    Solonnhat = a;
                if (b > Solonnhat)
                    Solonnhat = b;  
                if (c > Solonnhat)  
                    Solonnhat = c;
                tb_SLN.Text = Solonnhat.ToString();
                double Sonhonhat = 0;
                if (Sonhonhat > a)
                    Sonhonhat = a;
                if (Sonhonhat > b)
                    Sonhonhat = b;
                if (Sonhonhat > c)
                    Sonhonhat = c;
                tb_SNN.Text = Sonhonhat.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số thực!");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Bạn cần nhập đủ giá trị!");
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            tb_STN.Text = "";
            tb_STH.Text = "";
            tb_STB.Text = "";
            tb_SLN.Text = "";
            tb_SNN.Text = "";
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
