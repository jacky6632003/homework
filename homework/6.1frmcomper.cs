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
    public partial class frmcomper : Form
    {
        public frmcomper()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2 = 0, num3 = 0;
            if (double.TryParse(NameBox.Text, out num1) && double.TryParse(textBox1.Text, out num2) == false)
            {
                MessageBox.Show("enter number");
            }
            else
            {
                string a = comboBox.Text;
                if (a == "+") num3 = num1 + num2;
                if (a == "-") num3 = num1 - num2;
                if (a == "*") num3 = num1 * num2;
                if (a == "/") num3 = num1 / num2;
                textBox2.Text = "" + num3;
            }
        }
    }
}
