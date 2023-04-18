using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Bai1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void bt_Bai2_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
        }

        private void bt_Bai3_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            f2.Show();
        }

        private void bt_Bai4_Click(object sender, EventArgs e)
        {
            Form5 f3 = new Form5();
            f3.Show();
        }

        private void bt_Bai5_Click(object sender, EventArgs e)
        {
            Form6 f4 = new Form6();
            f4.Show();
        }

        private void bt_Bai6_Click(object sender, EventArgs e)
        {
            Form7 f5 = new Form7();
            f5.Show();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
