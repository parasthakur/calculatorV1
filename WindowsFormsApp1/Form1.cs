using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1, num2,total;
        const double expo = 2.71828182846;
        double expototal;
        string choice;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
            label1.Text += Convert.ToString(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
            label1.Text += Convert.ToString(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
            label1.Text += Convert.ToString(3);

        }
        

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
            label1.Text += Convert.ToString(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
            label1.Text += Convert.ToString(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
            label1.Text += Convert.ToString(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            choice = "subtract";
            textBox1.Text = "";
            label1.Text += " - ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
            label1.Text += Convert.ToString(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
            label1.Text += Convert.ToString(8);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
            label1.Text += Convert.ToString(9);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            choice = "multiply";
            textBox1.Text = "";
            label1.Text += " * ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            choice = "add";
            textBox1.Text = "";
            label1.Text += " + ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case "add":
                    num2 = Convert.ToDouble(textBox1.Text);
                    total = num1 + num2;
                    textBox1.Text = Convert.ToString(total);
                    break;
                case "subtract":
                    num2 = Convert.ToDouble(textBox1.Text);
                    total = num1 - num2;
                    textBox1.Text = Convert.ToString(total);
                    break;
                case "multiply":
                    num2 = Convert.ToDouble(textBox1.Text);
                    total = num1 * num2;
                    textBox1.Text = Convert.ToString(total);
                    break;
                case "divide":
                    num2 = Convert.ToDouble(textBox1.Text);
                    total = num1 / num2;
                    textBox1.Text = Convert.ToString(total);
                    break;
                case "expoany":
                    num2 = Convert.ToDouble(textBox1.Text);
                    expototal = Math.Pow(num1, num2);
                    textBox1.Text = Convert.ToString(expototal);
                    break;
            }
           // label1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            total = num1 * num1;
            textBox1.Text = "";
            textBox1.Text = Convert.ToString(total);
          //  label1.Text = "";
        }

        
        private void button19_Click_1(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            expototal = Math.Pow(expo,num1);
            textBox1.Text = "";
            textBox1.Text = Convert.ToString(expototal);
            label1.Text = "e^" + num1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            choice = "expoany";
            textBox1.Text = "";
            label1.Text += " ^ ";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            label1.Text += ".";
        }

        

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            choice = "divide";
            textBox1.Text = "";
            label1.Text += " / ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
