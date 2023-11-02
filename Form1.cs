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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox1.Checked;
        }

        double num1;
        string oper;

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(calculate.Text);
            calculate.Clear();
            oper = ((Button)sender).Text;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (calculate.Text != "0")
                calculate.Text += "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            calculate.Text += ((Button)sender).Text;
        }


        private void Eqal_Click(object sender, EventArgs e)
        {
            switch(oper)
            {
                case "+":
                    calculate.Text = (num1 + Convert.ToDouble(calculate.Text)).ToString();
                    break;
                case "-":
                    calculate.Text = (num1 - Convert.ToDouble(calculate.Text)).ToString();
                    break;
                case "*":
                    calculate.Text = (num1 * Convert.ToDouble(calculate.Text)).ToString();
                    break;
                case "/":
                    calculate.Text = (num1 / Convert.ToDouble(calculate.Text)).ToString();
                    break;
                case "%":
                    calculate.Text = (num1 % Convert.ToDouble(calculate.Text)).ToString();
                    break;
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            calculate.Text = "";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (calculate.Text == "")
                calculate.Text += "0.";
            else if (!calculate.Text.Contains("."))
                calculate.Text += ".";
        }
    }
}
