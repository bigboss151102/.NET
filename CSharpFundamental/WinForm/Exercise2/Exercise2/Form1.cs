using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            string password = "1511";


            if(check_input_code(password))
            {
                textBox2.Text = now + "    " + "Scientist" + Environment.NewLine;
            }else
            {
                textBox2.Text = now + "    " + "Restricted Access !";
            }
        }

        bool check_input_code(string code)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please input your password !", "Warning");
                textBox1.Focus();
                return false;
            }
            if(textBox1.Text == code)
            {
                return true;
            }else
            {
                return false;
            }

            return true;
        }
    }
}
