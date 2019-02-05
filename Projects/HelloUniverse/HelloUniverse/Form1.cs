using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloUniverse
{
    public partial class Form1 : Form
    {
        public int power = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello Universe!";

            if (power == 0)
            {
                label1.Text = "Hello Universe!";
                power = 1;

            }

            else
            {
                label1.Text = "label1";
                power = 0;
            }
        }
    }
}
