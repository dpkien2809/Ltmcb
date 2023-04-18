using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        [Serializable]
        public class SinhVien1
        {
            public string HoTen { get; set; }
            public string MSSV { get; set; }
            public string SoDienThoai { get; set; }
            public float DiemToan { get; set; }
            public float DiemVan { get; set; }
            public float DiemAnh { get; set; }
            public float DiemTB { get; set; }
            public override string ToString()
            {
                return $"{HoTen}\n{MSSV}\n{SoDienThoai}\n{DiemToan.ToString("N1")}\n{DiemVan.ToString("N1")}\n{DiemAnh.ToString("N1")}";
            }
        }
        List<SinhVien1> dssv = new List<SinhVien1>();
        private void bt_Add_Click(object sender, EventArgs e)
        {
            SinhVien1 sv = new SinhVien1();
            sv.MSSV = tb_ID.Text;
            sv.HoTen = tb_Name.Text;
            sv.SoDienThoai = tb_Phone.Text;
            sv.DiemToan = float.Parse(tb_Math.Text);
            sv.DiemVan = float.Parse(tb_Lite.Text);
            sv.DiemAnh = float.Parse(tb_Eng.Text);
            showfile.AppendText(sv.ToString() + "\n");
            dssv.Add(sv);
        }

        private void bt_Input_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn nơi lưu File input");
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string path = fbd.SelectedPath + "\\input4.text";
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dssv);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_Output_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn file cần ghi");
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<SinhVien1> sv = (List<SinhVien1>)bf.Deserialize(fs);
            showfile.Clear();
            int index = 0;
            foreach (SinhVien1 svv in sv)
            {
                sv[index++].DiemTB = svv.DiemTB;
                svv.DiemTB = (svv.DiemToan + svv.DiemVan + svv.DiemAnh) / 3;
                showfile.AppendText(svv.ToString() + "\n" + svv.DiemTB.ToString("N1") + "\n\n");
            }
            fs.Close();
            MessageBox.Show("Chọn nơi lưu file output");
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string path = fbd.SelectedPath + "\\output4.text";
            try
            {
                FileStream fsa = new FileStream(path, FileMode.Create);
                BinaryFormatter bfa = new BinaryFormatter();
                bf.Serialize(fsa, sv);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            showfile.Clear();
        }
    }
}
