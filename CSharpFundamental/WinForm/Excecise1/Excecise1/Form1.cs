using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excecise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.domainUpDown1.Items;
            collection.Add("0");
            collection.Add("1");
            collection.Add("2");
            collection.Add("3");
            collection.Add("4");
            collection.Add("5");

            this.domainUpDown1.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you Exit !","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        /*
        private float checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            float scalingValue = 100.00f;
            return scalingValue;
        }

        private float checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            float whiteningValue = 1200000f;
            return whiteningValue;
        }

        private float checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            float toothPhotographyValue = 200.00f;
            return toothPhotographyValue;
        }

        private float domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            float priceTooth = 0;
            if(domainUpDown1.SelectedIndex == 1) 
            {
                return priceTooth * 1;
            }else if (domainUpDown1.SelectedIndex == 2)
            {
                return priceTooth * 2;
            }else if(domainUpDown1.SelectedIndex == 3)
            {
                return priceTooth * 3;
            }else if(domainUpDown1.SelectedIndex == 4)
            {
                return priceTooth * 4;
            }else
            {
                return priceTooth *5;
            }
        }
        */
         float CaculatePrice()
        {
            float scaling = 0;
            float whitening = 0;
            float toothPhotograhpy = 0;
            float priceTooth = 80000f;

            float totalPrice = 0f;
            if(checkBox1.Checked && checkBox3.Checked && checkBox4.Checked && domainUpDown1.SelectedIndex == 1)
            {
                scaling = 100000f;
                whitening = 1200000f;
                toothPhotograhpy = 200000f;
                priceTooth = 80000f * 1;
                return totalPrice = scaling + whitening + toothPhotograhpy + priceTooth;
            }else if(checkBox1.Checked && checkBox3.Checked && checkBox4.Checked && domainUpDown1.SelectedIndex == 2)
            {
                scaling = 10000f;
                whitening = 1200000f;
                toothPhotograhpy = 20000f;
                priceTooth = 80000f * 2;
                return totalPrice = scaling + whitening + toothPhotograhpy + priceTooth;
            }
            else if (checkBox1.Checked && checkBox3.Checked && checkBox4.Checked && domainUpDown1.SelectedIndex == 3)
            {
                scaling = 10000f;
                whitening = 1200000f;
                toothPhotograhpy = 20000f;
                priceTooth = 80000f * 3;
                return totalPrice = scaling + whitening + toothPhotograhpy + priceTooth;
            }
            else if (checkBox1.Checked && checkBox3.Checked && checkBox4.Checked && domainUpDown1.SelectedIndex == 4)
            {
                scaling = 10000f;
                whitening = 1200000f;
                toothPhotograhpy = 20000f;
                priceTooth = 80000f * 4;
                return totalPrice = scaling + whitening + toothPhotograhpy + priceTooth;
            }
            else if (checkBox1.Checked && checkBox3.Checked && checkBox4.Checked && domainUpDown1.SelectedIndex == 5)
            {
                scaling = 10000f;
                whitening = 1200000f;
                toothPhotograhpy = 20000f;
                priceTooth = 80000f * 5;
                return totalPrice = scaling + whitening + toothPhotograhpy + priceTooth;
            }
            else if (checkBox1.Checked )
            {
                scaling = 10000f;
                return totalPrice = scaling;
            }
            else if (checkBox3.Checked)
            {
                whitening = 1200000f;
                return totalPrice = whitening;
            }
            else if (checkBox4.Checked)
            {
                toothPhotograhpy = 10000f;
                return totalPrice = toothPhotograhpy;
            }else if(domainUpDown1.SelectedIndex == 1)
            {
                return totalPrice = 80000;
            }
            else if (domainUpDown1.SelectedIndex == 2)
            {
                return totalPrice = 80000 * 2;
            }
            else if (domainUpDown1.SelectedIndex == 3)
            {
                return totalPrice = 80000 * 3;
            }
            else if (domainUpDown1.SelectedIndex == 4)
            {
                return totalPrice = 80000 * 4;
            }
            else if (domainUpDown1.SelectedIndex == 5)
            {
                return totalPrice = 80000 * 5;
            }

            return totalPrice;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var totalPrice1 = CaculatePrice();
            textBox2.Text = totalPrice1.ToString();
        }
    }
}
