using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class FrmStandardpractice : Form
    {
        public FrmStandardpractice()
        {
            InitializeComponent();
        }

        private void FrmStandardpractice_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] i = { 1, 5, 9, 20, 30 };
            int a = 0;//偶數幾個
            int b = 0;//奇數幾個
            for (int j = 0; j <= i.Length - 1; j++)
            {

                if (i[j] % 2 == 1)
                {
                    b += 1;

                }
                else {

                    a += 1;
                }


            }
            MessageBox.Show($"偶數{a}個奇數{b}個");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string[] name = { "jackt", "jack", "ma", "jacky6632003", "qq" };
            int max = 0;
            string maxname = "";
            for (int j = 0; j <= name.Length - 1; j++)
            {
                if (name[j].Length > max)
                {
                    max = name[j].Length;
                    maxname = name[j];

                }
                
            }
            MessageBox.Show($"的名的個數是:{max}名子是{maxname}個");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] name = { "jccaccckt", "jcakC", "ma", "jakcy6632003" };
            
            int a =0;
            for (int j = 0; j <= name.Length - 1; j++)
            {
               
               
                a += Regex.Matches(name[j], "c").Count;
                a += Regex.Matches(name[j], "C").Count;
                
            }

            MessageBox.Show($"名子裡面有c跟C共有{a}個");



        }

        private void button16_Click(object sender, EventArgs e)
        {
            int no;
            if (int.TryParse(textBox5.Text, out no))
            {
                lblResult.Text = "";
                for (int i = 1; i <= no; i++)
                {
                    
                    for (int j = 1; j <= i; j++)
                    {
                        if(i== no)
                        lblResult.Text += "*";
                    }
                    lblResult.Text += "\n";
                }



            }
            else
            {

                MessageBox.Show("enter number");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no;
            if (int.TryParse(textBox5.Text, out no))
            {
                lblResult.Text = "";
                for (int i = no; i>= 1; i--)
                {

                    for (int j = 1; j <= i; j++)
                    {

                        lblResult.Text += "*";
                    }
                    lblResult.Text += "\n";
                }



            }
            else
            {

                MessageBox.Show("enter number");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int no;
            if (int.TryParse(textBox5.Text, out no))
            {
                lblResult.Text = "";
                for (int i = 1; i <=no; i++)
                {

                    for (int j = 1; j <= no; j++)
                    {
                        if (j >= i)
                        {
                            lblResult.Text += "*";
                        }

                        
                        lblResult.Text += " ";
                    }
                    lblResult.Text += "\n";
                }



            }
            else
            {

                MessageBox.Show("enter number");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int no;
            if (int.TryParse(textBox5.Text, out no))
            {
                lblResult.Text = "";
                for (int i = 1; i <= no; i++)
                {

                    for (int j = 1; j <= no; j++)
                    {
                        if (j <= (no - i))
                        {
                            lblResult.Text += " ";

                        }
                        else
                        {

                            lblResult.Text += "* ";
                        }
                    }
                    
                    lblResult.Text += "\n";
                }




            }
            else
            {

                MessageBox.Show("enter number");

            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int no;
            if (int.TryParse(textBox5.Text, out no))
            {
                
                //轉換資料
                string str = Convert.ToString(no, 2);
                //補足四碼
                str = str.PadLeft(4, '0');
                lblResult.Text = str;
            }
            else
            {

                MessageBox.Show("enter number");

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                   
                    lblResult.Text += $"{j}{"*"}{i}{"=",-3}{j * i,-5}";
                }
                lblResult.Text += $"{"\n"}";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int no;
            lblResult.Text = "";
            if (int.TryParse(textBox5.Text, out no))
            {
                
                for (int i = 1;  i <= no; i++)
                {
                    for (int j = 1; j <= no; j++)
                    {
                        if (j >= i)
                        {
                            lblResult.Text += "*";
                        }
                        else
                        {
                            lblResult.Text += " ";
                        }
                    }

                    lblResult.Text += " \n";
                }




            }
            else
            {

                MessageBox.Show("enter number");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int no;
            lblResult.Text = "";
            if (int.TryParse(textBox5.Text, out no))
            {

                for (int i = 1; i <= no; i++)
                {
                    for (int j = 1; j <= no; j++)
                    {
                        if (j <= (no - i))
                        {
                            lblResult.Text += " ";
                        }
                        else
                        {
                            
                            lblResult.Text += "*";
                        }
                    }

                    lblResult.Text += " \n";
                }




            }
            else
            {

                MessageBox.Show("enter number");

            }
        }
    }
    
}
