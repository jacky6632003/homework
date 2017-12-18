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
    public partial class FrmLotto : Form
    {
        public FrmLotto()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            Random a = new Random();
            int[] num = new int[6];
            for(int i = 0; i <= num.Length - 1; i++)
            {
                num[i] = a.Next(1, 46);
                for (int j = 0; j <= i-1; j++)
                {
                    while (num[j] == num[i])
                    {
                        j = 0;
                        num[i] = a.Next(1, 46);
                    }
                }
            }
            textBox1.Text = num[0].ToString("00")  ;
            textBox2.Text = num[1].ToString("00") ;
            textBox3.Text = num[2].ToString("00")  ;
            textBox4.Text = num[3].ToString("00") ;
            textBox5.Text = num[4].ToString("00") ;
            textBox6.Text = num[5].ToString("00") ;
            Array.Sort(num);
            textBox12.Text = num[0].ToString("00");
            textBox11.Text = num[1].ToString("00");
            textBox10.Text = num[2].ToString("00");
            textBox9.Text = num[3].ToString("00");
            textBox8.Text = num[4].ToString("00");
            textBox7.Text = num[5].ToString("00");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int no;
            int num1, num2;
            
            if (int.TryParse(textBox13.Text, out no) &&
                int.TryParse(textBox14.Text, out num1) &&
                int.TryParse(textBox15.Text, out num2)&&num2>num1)
            {
                int rnd = num2 + 1;
                Random a = new Random();
                int[] num = new int[no];
                label6.Text = "";
               
                for (int i = 0; i <= no - 1; i++)
                {
                    num[i] = a.Next(num1, rnd);
                    for (int j = 0; j <= i -1; j++)
                    {
                        while (num[j] == num[i])
                        {
                            j = 0;
                            num[i] = a.Next(num1, rnd);
                        }
                    }
                    label6.Text += $"{num[i],5}";
                    




                }
                Array.Sort(num);
                label7.Text = "";
                for (int i = 0; i <= no - 1; i++)
                {
                    label7.Text += $"{num[i],5}";
                }
                   
                Array.Reverse(num);
                label8.Text = "";
                for (int i = 0; i <= no - 1; i++)
                {
                    label8.Text += $"{num[i],5}";
                }

            }
            else
            {
                MessageBox.Show("Please enter  number");

            }
        }
    }
}
