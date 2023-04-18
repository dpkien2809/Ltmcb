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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Init()
        {
            string[] drives = Directory.GetLogicalDrives();  
            foreach(string drv in drives)
            {
                TreeNode node = new TreeNode(drv);
                treeView1.Nodes.Add(node);
                node.Nodes.Add("Temp");
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            foreach(string dir in Directory.GetDirectories(node.FullPath))
            {
                TreeNode n = node.Nodes.Add(Path.GetFileName(dir));
                n.Nodes.Add("Temp");
            }
        }

        private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                picView.Image = null;
                string[] arrFiles = Directory.GetFiles(e.Node.FullPath);
                picturechoosen.Controls.Clear();
                foreach(string file in arrFiles)
                {
                    if(file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".png") || file.ToLower().EndsWith(".jpeg"))
                    {
                        PictureBox picture = new PictureBox();
                        picture.SizeMode = PictureBoxSizeMode.StretchImage;
                        picture.Image = Image.FromFile(file);
                        picture.Height = picturechoosen.Height - 8;
                        picture.Width = picture.Height * 3 / 4;
                        picture.Cursor = Cursors.Hand;
                        picturechoosen.Controls.Add(picture);
                        picture.Click += new EventHandler(pictureBox_Click);
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            picView.Image = pic.Image;
        }
    }
}
