using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res = 0;

            int date = 0;

            int bet = 15;

            label2.ForeColor = Color.Blue;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label2.Text = "Дозоповніть всі поля";
            }
            else if (!int.TryParse(textBox1.Text, out res) || !int.TryParse(textBox2.Text, out date))
            {
                label2.Text = "Будь-ласка введіть правильні значення";
            }
            else if (res < 1000 || res > 1000000)
            {
                label2.Text = "Значення суми є некоректним";
            }
            else if (date < 1 || date > 50)
            {
                label2.Text = "Значення строку є некоректним!";
            }
            else
            {
                label2.ForeColor = Color.OrangeRed;

                if (res > 40000 || date > 10)
                {
                    label2.Text = "Проведіть узгодження в найблищому офісі чи відділенні";
                }
                else
                {
                    if (res >= 20000)
                    {
                        bet -= 2;
                    }
                    else if (res >= 10000)
                    {
                        bet -= 1;
                    }

                    if (date >= 5)
                    {
                        bet += 2;
                    }
                    else if (date >= 3)
                    {
                        bet += 1;
                    }

                    label2.Text = bet.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
