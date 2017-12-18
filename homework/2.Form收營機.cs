using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myhomework20170623
{
    public partial class frmpos : Form
    {

        int times , times1 , times2 ,times3,times4,times5= 0;
        int tatol1, tatol2  , tatol, tatol3, tatol4, tatol5= 0;
        int i = 100;
        int a = 200;
        int j = 300;
        int b = 50;
        int q,w;
        
        
        //public string oaa { get; private set; }
        string oaa = "";

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            
            TatolBox1.Text = tatol.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            q = int.Parse(textBox1.Text);
            w = q - tatol;
            label5.Text =  w.ToString();
            int e1;
            e1 = w / 1000;
            label6.Text = "$1000:"+e1.ToString()+"張";
            int e2;
            e2 = (w-e1*1000)/500;
            label7.Text = "$500:" + e2.ToString() + "張";
            int e3;
            e3 = (w - e1 * 1000-500*e2)/100;
            label8.Text = "$100:" + e3.ToString() + "張";
            int e4;
            e4 = (w - e1 * 1000 - 500 * e2-100*e3) / 50;
            label9.Text = "$50:" + e4.ToString() + "張";
            int e5;
            e5 = (w - e1 * 1000 - 500 * e2 - 100 * e3-50*e4) / 10;
            label10.Text = "$10:" + e5.ToString() + "張";
            




        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            times5++;
            if (times5==1)
            label1.Text = "";
            TatolBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            times4++;
            if (times4==1)
            tatol /= 2;
            TatolBox1.Text = tatol.ToString();
            
        }

        public frmpos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oaa += b + "元\t" + "三明治\n";

            times3++;
            tatol4 = times3 * b;
            tatol = tatol1 + tatol2 + tatol3+ tatol4;
            
            TatolBox1.Text = tatol.ToString();
            label1.Text = "tatol\n" + oaa;
            label2.Text = "Tatol:" + tatol;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = oaa;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oaa += j + "元\t" + "蛋餅\n";

            times2++;
            tatol3 = times2 * j;
            tatol = tatol1 + tatol2+ tatol3 + tatol4;
            TatolBox1.Text = tatol.ToString();
            label1.Text = "tatol\n" + oaa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
             
             
            oaa += i+"元\t"+"三明治\n";
            
            times++;
            tatol1 = times *i;
            tatol = tatol1 + tatol2 + tatol3 + tatol4;
            TatolBox1.Text = tatol.ToString();
            label1.Text = "tatol\n" + oaa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oaa += a + "元\t" + "漢堡\n";
            times1++;
            tatol2 = times1 *a;
            tatol = tatol1 + tatol2 + tatol3 + tatol4;
            TatolBox1.Text = tatol.ToString();
            label1.Text = "tatol\n" + oaa;
        }

        private void TatolBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
