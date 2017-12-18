using _20170706視窗.lab_01_0_2_ui;
using myhomework20170623;
using myhomework2017622;
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
    public partial class frmtatol : Form
    {
        public frmtatol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPMT frm1 = new frmPMT();
            frm1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmpos frm2 = new frmpos();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmnumsize frm3 = new Frmnumsize();
            frm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormStudent frm4 = new FormStudent();
            frm4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormStudentGeneric frm5 = new FormStudentGeneric();
            frm5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmStandardpractice practice = new FrmStandardpractice();
            practice.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frmcomputer1 frm6 = new frmcomputer1();
            frm6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmLotto frm7 = new FrmLotto();
            frm7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmcomper frm8 = new frmcomper();
                frm8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmGame frm8 = new FrmGame();
            frm8.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmScreen frm8 = new FrmScreen();
            frm8.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
           Frtransparencykeym frm8 = new Frtransparencykeym();
            frm8.Show(); 
        }
    }
}
