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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bt_Doc_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("input.txt");
            string content = reader.ReadToEnd();
            reader.Close();
            showfile.Text = content;
        }

        private void bt_Ghi_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("output.txt");
            writer.Write(showfile.Text.ToUpper());
            writer.Close();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
