using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void bt_DocTinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader rs = new StreamReader(fs);
            showfile.Text = rs.ReadToEnd();
            string data = showfile.Text.ToString();
            string[] lines = data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string subtoken in lines)
            {
                string[] tokens = subtoken.Split(new[] { "+", "-", "*", "/", "(", ")" }, StringSplitOptions.RemoveEmptyEntries);
                Stack<double> n = new Stack<double>();
                Stack<char> o = new Stack<char>();
                foreach (string token in tokens)
                {
                    if (double.TryParse(token, out double number))
                    {
                        n.Push(number);
                    }
                    else if (token == "(")
                    {
                        o.Push(token[0]);
                    }
                    else if (token == ")" && o.Count > 0)
                    {
                        while (o.Peek() != '(')
                        {
                            char op = o.Pop();
                            double num2 = n.Pop();
                            double num1 = n.Pop();
                            double result = PerformOperation(op, num1, num2);
                            n.Push(result);
                        }

                        o.Pop();
                    }
                    else if (IsOperator(token))
                    {
                        while (o.Count > 0 && IsOperator(o.Peek().ToString()) && GetPrecedence(token) <= GetPrecedence(o.Peek().ToString()))
                        {
                            char operators = o.Pop();
                            double num2 = n.Pop();
                            double num1 = n.Pop();
                            double result = PerformOperation(operators, num1, num2);
                            n.Push(result);
                        }

                        o.Push(token[0]);
                    }
                }

                while (o.Count > 0)
                {
                    char operators = o.Pop();
                    double num1 = n.Pop();
                    double num2 = n.Pop();
                    double result = PerformOperation(operators, num1, num2);
                    n.Push(result);
                }

                if (n.Count > 0)
                {
                    double finalResult = n.Pop();
                    showfile.Text += " = " + finalResult.ToString() + "\r\n";
                }
            }
        }
        bool IsOperator(string tokens)
        {
            return tokens == "+" || tokens == "-" || tokens == "*" || tokens == "/";
        }

        int GetPrecedence(string token)
        {
            switch (token)
            {
                case "+":
                    return 1;
                case "-":
                    return 1;
                case "*":
                    return 2;
                case "/":
                    return 2;
                default:
                    return 0;
            }
        }

        double PerformOperation(char op, double num1, double num2)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                default:
                    return 0;
            }
        }
        private void bt_Ghi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".txt";
            sfd.ShowDialog();
            try
            {
                using (StreamWriter writer = new StreamWriter(sfd.FileName))
                {
                    string a = showfile.Text;
                    writer.WriteLine(a);
                }
                MessageBox.Show("Create Output file successful!", "Notice");
            }
            catch
            {
                MessageBox.Show("Have not input name of file yet!", "Notice");
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            showfile.Clear();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}