using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class frmcomputer1 : Form
    {
        public frmcomputer1()
        {
            InitializeComponent();
        }
        double temp = 0; 
        double temp2 = 0;
        string Num1 = "0";
        string Num2 = "0";
        bool b = true;
        string s;
        private void button1_Click(object sender, EventArgs e)
        {
           
            string Num = "1";
            if (sumBox.Text == "0" || b ||sumBox.Text == "*" ||
                sumBox.Text == "+" || sumBox.Text == "-" 
                || sumBox.Text == "/")
            {
                sumBox.Clear();
            }
            b = false;
            sumBox.Text += Num;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Num = "2";
            if (sumBox.Text == "0" || b || sumBox.Text == "*" ||
                sumBox.Text == "+" || sumBox.Text == "-"
                || sumBox.Text == "/")
            {
                sumBox.Clear();
            }
            b = false;
            sumBox.Text += Num;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Num = "3";
            if (sumBox.Text == "0" || b || sumBox.Text == "*" ||
                sumBox.Text == "+" || sumBox.Text == "-"
                || sumBox.Text == "/")
            {
                sumBox.Clear();
            }
            b = false;
            sumBox.Text += Num;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Num = "4";
            if (sumBox.Text == "0" || b || sumBox.Text == "*" ||
                sumBox.Text == "+" || sumBox.Text == "-"
                || sumBox.Text == "/")
            {
                sumBox.Clear();
            }
            b = false;
            sumBox.Text += Num;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Num = "5";
            if (sumBox.Text == "0" || b || sumBox.Text == "*" ||
                sumBox.Text == "+" || sumBox.Text == "-"
                || sumBox.Text == "/")
            {
                sumBox.Clear();
            }
            b = false;
            sumBox.Text += Num;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Num = "6";
            if (sumBox.Text == "0" || b || sumBox.Text == "*" ||
                sumBox.Text == "+" || sumBox.Text == "-"
                || sumBox.Text == "/")
            {
                sumBox.Clear();
            }
            b = false;
            sumBox.Text += Num;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            string Num = "7";
            if (sumBox.Text == "0" || b || sumBox.Text == "*" ||
                sumBox.Text == "+" || sumBox.Text == "-"
                || sumBox.Text == "/")
            {
                sumBox.Clear();
            }
            b = false;
            sumBox.Text += Num;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            string Num = "8";
            if (sumBox.Text == "0" || b || sumBox.Text == "*" ||
                sumBox.Text == "+" || sumBox.Text == "-"
                || sumBox.Text == "/")
            {
                sumBox.Clear();
            }
            b = false;
            sumBox.Text += Num;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string Num = "9";
            if (sumBox.Text == "0" || b || sumBox.Text == "*" ||
                sumBox.Text == "+" || sumBox.Text == "-"
                || sumBox.Text == "/")
            {
                sumBox.Clear();
            }
            b = false;
            sumBox.Text += Num;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string Num = "0";
            if (sumBox.Text == "0" || b || sumBox.Text == "*" ||
                sumBox.Text == "+" || sumBox.Text == "-"
                || sumBox.Text == "/")
            {
                sumBox.Clear();
            }
            b = false;
            sumBox.Text += Num;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (s)
            {
                case "+":
                    temp = double.Parse(sumBox.Text);
                    temp2 += temp;
                    break;
                case "-":
                    temp = double.Parse(sumBox.Text);
                    temp2 -= temp;
                    break;
                case "*":
                    temp = double.Parse(sumBox.Text);
                    temp2 *= temp;
                    break;
                case "/":
                    temp = double.Parse(sumBox.Text);
                    temp2 /= temp;
                    break;
            }
            sumBox.Text = temp2.ToString() ;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sumBox.Text = "";
            b = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                temp = double.Parse(sumBox.Text);
                temp2 = temp;
                sumBox.Text = "-";
                s = "-";
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                temp = double.Parse(sumBox.Text);
                temp2 = temp;
                sumBox.Text = "*";
                s = "*";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                temp = double.Parse(sumBox.Text);
                temp2 = temp;
                sumBox.Text = "/";
                s = "/";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                temp = double.Parse(sumBox.Text);
                temp2 = temp;
                sumBox.Text = "+";
               s= "+";
            }
        }
    }
}
