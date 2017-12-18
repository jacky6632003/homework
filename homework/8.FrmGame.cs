using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20170706視窗.lab_01_0_2_ui
{
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();
            button10.Text = "reset";
            label1.Text = "OO先下";
            label1.Font= new Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            foreach (Control x in this.panel1.Controls)
            {
                x.Text = "";
                x.BackColor = Color.Yellow;
                x.ForeColor = Color.Black;
                x.Click += btn_Click;
                x.Font=new Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                x.MouseEnter += X_MouseEnter;
                x.MouseLeave += X_MouseLeave;
            }

           



        }

        private void X_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Yellow;
        }

        private void X_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Orange;
        }

        
        bool fag=true;
        private void btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (fag == true)
            {
                ((Button)sender).Text = "O";
                ((Button)sender).Enabled = false;
                label1.Text = "該XX下";
            }
            else
            {
                ((Button)sender).Text = "X";
                ((Button)sender).Enabled = false;
                label1.Text = "該OO下";
            }
          

            fag = !fag;


            if (button5.Text != "" && 
                ((button5.Text == button9.Text && button5.Text == button1.Text)
                || (button5.Text == button7.Text && button5.Text == button3.Text)
                || (button5.Text == button2.Text && button5.Text == button8.Text) 
                || (button5.Text == button4.Text && button5.Text == button6.Text)))
            {
                MessageBox.Show(button5.Text + "win");
                foreach (Control x in this.panel1.Controls)
                { 
                    x.Enabled = false;
                }
            }
            else if (button1.Text != "" && 
                ((button1.Text == button2.Text && button1.Text == button3.Text) 
                || (button1.Text == button4.Text && button1.Text == button7.Text)))
            {
                MessageBox.Show(button1.Text + "win");
                foreach (Control x in this.panel1.Controls)
                {
                    x.Enabled = false;
                }
            }
            else if (button9.Text != "" && 
                ((button9.Text == button8.Text && button9.Text == button7.Text) 
                || (button9.Text == button6.Text && button9.Text == button3.Text)))
            {
                MessageBox.Show(button1.Text + "win");
                foreach (Control x in this.panel1.Controls)
                {
                    x.Enabled = false;
                }
            }
            else if (button1.Text != "" && button2.Text != "" 
                && button3.Text != "" && button4.Text != "" 
                && button5.Text != "" && button6.Text != "" 
                && button7.Text != "" && button8.Text != "" 
                && button9.Text != "")
            {
                MessageBox.Show("平手");
            }


        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmGame_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X + "," + e.Y;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.panel1.Controls)
            {
                x.Text = "";
                x.Enabled = true;
            }
            label1.Text = "OO先下";

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
