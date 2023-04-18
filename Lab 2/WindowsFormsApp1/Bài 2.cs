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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bt_Doc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                FileInfo fileInfo = new FileInfo(filename);

                // Get file size
                long size = fileInfo.Length;

                // Get URL path
                string path = Path.GetFullPath(filename);

                // Get file name
                string name = Path.GetFileName(filename);

                // Count lines, words, and characters
                int lines = 0, words = 0, chars = 0;
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines++;
                        chars += line.Length;
                        string[] lineWords = line.Split(' ');
                        words += lineWords.Length;
                    }
                }

                // Print file info
                tb_Filename.Text = name;
                tb_Size.Text = size.ToString() + " bytes";
                tb_URL.Text = path;
                tb_Line.Text = lines.ToString();
                tb_Words.Text = words.ToString();
                tb_Character.Text = chars.ToString();

                // Print file contents
                using (StreamReader reader = new StreamReader(filename))
                {
                    showfile.Text = reader.ReadToEnd();
                }
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
