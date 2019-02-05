using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorInterface
{
    public partial class Form1 : Form
    {
        private ICalculation calc;
        public Form1()
        {
            InitializeComponent();
            calc = new Calculation();
            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "/";
            button4.Text = "*";

            button1.Click += new EventHandler(DoCalculation);
            button2.Click += new EventHandler(DoCalculation);
            button3.Click += new EventHandler(DoCalculation);
            button4.Click += new EventHandler(DoCalculation);
        }

        private void DoCalculation(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            decimal n1 = decimal.Parse(textBox1.Text);
            decimal n2 = decimal.Parse(textBox2.Text);

            string result = "0";

            switch (b.Text)
            {
                case "+":
                    result = Convert.ToString(calc.Add(n1, n2));
                    break;
                case "-":
                    result = Convert.ToString(calc.Subtract(n1, n2));
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        result = "Error";
                        listBox1.Items.Add(string.Format("Cannot divide by 0!"));
                    }
                    else
                    {
                        result = Convert.ToString(calc.Divide(n1, n2));
                    }
                    break;
                case "*":
                    result = Convert.ToString(calc.Multiply(n1, n2));
                    break;

                default:
                    break;
            }

            if (result != "Error")
            {
                listBox1.Items.Add(string.Format("{0} {1} {2} = {3}", n1, b.Text, n2, result));
            }
            

        }
    }
}
