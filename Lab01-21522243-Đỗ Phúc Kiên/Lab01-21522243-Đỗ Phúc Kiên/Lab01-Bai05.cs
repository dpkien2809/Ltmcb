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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        int a;
        int b;
        private void bt_Tinh_Click(object sender, EventArgs e)
        {
            try
            {
                string SoA = tb_NhapA.Text;
                string SoB = tb_NhapB.Text;
                a = Int32.Parse(SoA);
                b = Int32.Parse(SoB);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng kiểu số!");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Bạn cần nhập đủ giá trị!");
            }
            int KQGTA = 1;
            int KQGTB = 1;
            int S1 = 0;
            int S2 = 0;
            double S3 = 0;
            for(int i = 1; i <= a; i++)
            {
                KQGTA *= i;
            }
            for(int j = 1; j <= b; j++)
            {
                KQGTB *= j;
            }
            for(int k = 1; k <= a; k++)
            {    
                S1 += k;
            }
            for(int l = 1; l <= b; l++)
            {
                S2 += l;
            }
            for(int m = 1; m <= b; m++)
            {
                S3 += Math.Pow(a,m);
            }
            tb_KQA.Text = KQGTA.ToString();
            tb_KQB.Text = KQGTB.ToString();
            tb_KQS1.Text = S1.ToString();
            tb_KQS2.Text = S2.ToString();
            tb_KQS3.Text = S3.ToString();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            tb_NhapA.Text = "";
            tb_NhapB.Text = "";
            tb_KQA.Text = "";
            tb_KQB.Text = "";
            tb_KQS1.Text = "";
            tb_KQS2.Text = "";
            tb_KQS3.Text = "";
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
