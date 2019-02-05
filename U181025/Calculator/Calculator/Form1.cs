using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "/";
            button4.Text = "*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double result = number1 + number2;
            listBox1.Items.Add(DateTime.Now.ToShortTimeString() + ": " + number1 + " + " + number2 + " = " + result);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double result = number1 - number2;
            listBox1.Items.Add(DateTime.Now.ToShortTimeString() + ": " + number1 + " - " + number2 + " = " + result);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            if (number2 == 0)
            {
                listBox1.Items.Add(DateTime.Now.ToShortTimeString() + ": Error, cannot divide by 0!");
            }
            else
            {
                double result = number1 / number2;
                listBox1.Items.Add(DateTime.Now.ToShortTimeString() + ": " + number1 + " / " + number2 + " = " + result);
            }
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double result = number1 * number2;
            listBox1.Items.Add(DateTime.Now.ToShortTimeString() + ": " + number1 + " * " + number2 + " = " + result);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Focus();
        }
    }
}
