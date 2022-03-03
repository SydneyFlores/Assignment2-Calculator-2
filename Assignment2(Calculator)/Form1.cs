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
        string[] output;


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
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                answer = 0;
            }
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
                case "-":
                    secondnumber = Convert.ToDouble(textBox1.Text);
                    answer = firstnumber - secondnumber;
                    textBox1.Text = answer.ToString();
                    break;
                case "x":
                    secondnumber = Convert.ToDouble(textBox1.Text);
                    answer = firstnumber * secondnumber;
                    textBox1.Text = answer.ToString();
                    break;
                case "/":
                    secondnumber = Convert.ToDouble(textBox1.Text);
                    answer = firstnumber / secondnumber;
                    textBox1.Text = answer.ToString();
                    break;
                case "^2":
                    output = textBox1.Text.Split("^2");
                    firstnumber = Convert.ToDouble(output[0]);
                    answer = Math.Pow(firstnumber, 2);
                    textBox1.Text = answer.ToString();
                    break;
                case "1/":
                    output = textBox1.Text.Split("1/");
                    firstnumber = Convert.ToDouble(output[1]);
                    answer = 1/ firstnumber;
                    textBox1.Text = answer.ToString();
                    break;
                case "2sqrt":
                    output = textBox1.Text.Split("2sqrt");
                    firstnumber = Convert.ToDouble(output[1]);
                    answer = Math.Sqrt(firstnumber);
                    textBox1.Text = answer.ToString();
                    break;
                case "10^":
                    output = textBox1.Text.Split("10^");
                    firstnumber = Convert.ToDouble(output[1]);
                    answer = Math.Pow(10, firstnumber);
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
            operation = "10^";

            textBox1.Text = textBox1.Text + "10^";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                answer = 0;
            }
            textBox1.AppendText("1");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                answer = 0;
            }
            textBox1.AppendText("2");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                answer = 0;
            }
            textBox1.AppendText("3");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                answer = 0;
            }
            textBox1.AppendText("4");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                answer = 0;
            }
            textBox1.AppendText("5");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                answer = 0;
            }
            textBox1.AppendText("6");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                answer = 0;
            }
            textBox1.AppendText("8");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                answer = 0;
            }
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

        private void buttonmin_Click(object sender, EventArgs e)
        {
            operation = "-";
            firstnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
        }

        private void buttonmulti_Click(object sender, EventArgs e)
        {
            operation = "x";
            firstnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
        }

        private void buttondvd_Click(object sender, EventArgs e)
        {
            operation = "/";
            firstnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
        }

        private void buttonx2_Click(object sender, EventArgs e)
        {
            operation = "^2";
            
            textBox1.Text =textBox1.Text+"^2";
        }

        private void button1ox_Click(object sender, EventArgs e)
        {
            operation = "1/";

            textBox1.Text = "1/" + textBox1.Text;
        }

        private void button2sx_Click(object sender, EventArgs e)
        {
            operation = "2sqrt";

            textBox1.Text = "2sqrt" + textBox1.Text;
        }

        private void buttondot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text + ".";
            }

        }

        private void buttonpam_Click(object sender, EventArgs e)
        {

        }

        private void buttonxy_Click(object sender, EventArgs e)
        {

        }

        private void buttonpi_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void buttonexp_Click(object sender, EventArgs e)
        {

        }

        private void buttone_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.E.ToString();
        }
    }
}
