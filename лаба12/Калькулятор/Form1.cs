using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Калькулятор: Form
    {
        float numder1, numder2;
        int count;
        bool operations = true;
    
        public Калькулятор()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            numder1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = numder1.ToString() + "+";
            operations = true;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            numder1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = numder1.ToString() + "-";
            operations = true;
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            numder1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = numder1.ToString() + "*";
            operations = true;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            numder1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = numder1.ToString() + "/";
            operations = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            Calculate();
            label1.Text = "";
            switch (count) {
                case 1:
                    numder2 = numder1 + float.Parse(textBox1.Text);
                    textBox1.Text = numder2.ToString();
                    break;
                case 2:
                    numder2 = numder1 - float.Parse(textBox1.Text);
                    textBox1.Text = numder2.ToString();
                    break;
                case 3:
                    numder2 = numder1 * float.Parse(textBox1.Text);
                    textBox1.Text = numder2.ToString();
                    break;
                case 4:
                    numder2 = numder1 / float.Parse(textBox1.Text);
                    textBox1.Text = numder2.ToString();
                    break;
                    default: break;
            }
        }

        private void Calculate()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
    }
}
