using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculador_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Visible = false;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            label1.Text = $"+";
            label2.Text = textBox1.Text;
            label1.Visible = true;
            textBox1.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            label1.Text = $"-";
            label2.Text = textBox1.Text;
            label1.Visible = true;
            textBox1.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            label1.Text = $"*";
            label2.Text = textBox1.Text;
            label1.Visible = true;
            textBox1.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            label1.Text = $"/";
            label2.Text = textBox1.Text;
            label1.Visible = true;
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double resu = 0;
            if (label1.Text == "+")
            {
                resu = double.Parse(label2.Text) + double.Parse(textBox1.Text);
                textBox1.Text = resu.ToString();
            }
            if (label1.Text == "-")
            {
                resu = double.Parse(label2.Text) - double.Parse(textBox1.Text);
                textBox1.Text = resu.ToString();
            }
            if (label1.Text == "*")
            {
                resu = double.Parse(label2.Text) * double.Parse(textBox1.Text);
                textBox1.Text = resu.ToString();
            }
            if (label1.Text == "/")
            {
                resu = double.Parse(label2.Text) / double.Parse(textBox1.Text);
                textBox1.Text = resu.ToString();
            }

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }
    }
}
