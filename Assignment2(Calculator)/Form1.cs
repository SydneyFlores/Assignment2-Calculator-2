using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_Calculator_
{
    public partial class Form1 : Form
    {

        string operation;
        double firstnumber;
        double secondnumber;
        double answer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Sydney");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    secondnumber = Convert.ToDouble(textBox1.Text);
                    answer = firstnumber + secondnumber;
                    textBox1.Text = answer.ToString();
                    break;
                default:
                    break;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox1.Text = "0";

        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            operation = "+";
            firstnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
        }
    }
}
