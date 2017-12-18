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
    public partial class Frmnumsize : Form
    {
        public Frmnumsize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student than1;
            than1.num1 = int.Parse(textBox1.Text);
            than1.num2 = int.Parse(textBox2.Text);
            than1.num3 = int.Parse(textBox3.Text);
            than1.tatol = than1.num1 + than1.num2 + than1.num3;
            label1.Text = than1.tatol.ToString();
            than1.average = than1.tatol / 3;
            label4.Text = than1.average.ToString();
            if (than1.num1 > than1.num2)
            {
                than1.max = than1.num1;
            }
            else {
                than1.max = than1.num2;
            }
            if(than1.max< than1.num3)
            {
                than1.max = than1.num3;

            }

            label2.Text = "big NUMBER:" + than1.max;
            if (than1.num1 < than1.num2) {

                than1.min = than1.num1;
            }
            else
            {
                than1.min = than1.num2;
            }
            if (than1.min > than1.num3)
            {

                than1.min = than1.num3;
            }
            label3.Text = "SMALL NUMBER:" + than1.min;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
