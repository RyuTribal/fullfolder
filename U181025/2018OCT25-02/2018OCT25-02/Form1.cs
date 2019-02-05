using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018OCT25_02
{
    public partial class Form1 : Form
    {
        //Constructor, kod som körs automatiskt vid NEW
        public Form1()
        {
            InitializeComponent();

            button2.Click += new EventHandler(DoSomething);

            button2.Text = "Try me";
            button1.Text = "Add";
        }

        private void DoSomething(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Du skrev: " + textBox1.Text;
            listBox1.Items.Add(DateTime.Now.ToShortTimeString() + ": " + textBox1.Text);
            textBox1.Text = string.Empty;
            textBox1.Focus();


        }


    }
}
