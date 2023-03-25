using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1_Bài_6
{
    public partial class Bai6_QLD : Form
    {
        public Bai6_QLD()
        {
            InitializeComponent();
        }
        private bool check_gioi(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (float.Parse(a[i]) < 6.5) return false;
            }
            return true;
        }

        private bool check_kha(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (float.Parse(a[i]) < 5) return false;
            }
            return true;
        }

        private bool check_tb(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (float.Parse(a[i]) < 3.5) return false;
            }
            return true;
        }

        private bool check_yeu(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (float.Parse(a[i]) < 2) return false;
            }
            return true;
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Xuat_Click(object sender, EventArgs e)
        {
            string a = tb_DSD.Text;
            string[] b = a.Split(' ');
            float num;
            try
            {
                if (b.Length < 12)
                {
                    throw new FormatException("Số lượng phần tử không đủ 12");
                }
                else if (b.Length > 12)
                {
                    throw new FormatException("Số lượng phần tử quá 12");

                }

                for (int i = 0; i < b.Length; i++)
                {
                    if (!float.TryParse(b[i], out num))
                    {
                        throw new FormatException("Vui lòng nhập đúng kiểu dữ liệu!");
                        break;
                    }
                    if (Convert.ToDouble(b[i]) > 10 || Convert.ToDouble(b[i]) < 0)
                    {
                        throw new FormatException("Vui lòng nhập điểm từ 0 đến 10!");
                        break;
                    }

                }
                tb_M1.Text = b[0] + "đ";
                tb_M2.Text = b[1] + "đ";
                tb_M3.Text = b[2] + "đ";
                tb_M4.Text = b[3] + "đ";
                tb_M5.Text = b[4] + "đ";
                tb_M6.Text = b[5] + "đ";
                tb_M7.Text = b[6] + "đ";
                tb_M8.Text = b[7] + "đ";
                tb_M9.Text = b[8] + "đ";
                tb_M10.Text = b[9] + "đ";
                tb_M11.Text = b[10] + "đ";
                tb_M12.Text = b[11] + "đ";
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Tính trung bình
            float avg = 0;
            for (int i = 0; i < b.Length; i++)
            {
                avg += float.Parse(b[i]);
            }
            tb_DTB.Text = (Math.Round(avg / 12, 2)).ToString() + "đ";

            //Tìm điểm max, min
            float max = float.Parse(b[0]);
            float min = float.Parse(b[0]);
            for (int i = 1; i < b.Length; i++)
            {
                if (max < float.Parse(b[i]))
                {
                    max = float.Parse(b[i]);
                }
                if (min > float.Parse(b[i]))
                {
                    min = float.Parse(b[i]);
                }

            }
            tb_DCN.Text = max.ToString() + "đ";
            tb_DTN.Text = min.ToString() + "đ";

            //Tìm số môn đậu, số môn không đậu
            int count = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (float.Parse(b[i]) >= 5)
                    count++;
            }
            tb_SMD.Text = count.ToString();
            tb_SMKD.Text = (b.Length - count).ToString();

            //Xếp loại học lực
            if (avg >= 8 && check_gioi(b))
                tb_XLHL.Text = "Giỏi";
            else if (avg >= 6.5 && check_kha(b))
                tb_XLHL.Text = "Khá";
            else if (avg >= 5 && check_tb(b))
                tb_XLHL.Text = "Trung bình";
            else if (avg >= 3.5 && check_yeu(b))
                tb_XLHL.Text = "Yếu";
            else
                tb_XLHL.Text = "Kém";
        }
    }
}
