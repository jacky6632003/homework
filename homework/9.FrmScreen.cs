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
    public partial class FrmScreen : Form
    {
        public FrmScreen()
        {

            InitializeComponent();
            this.MouseMove += FrmScreen_MouseMove;
            Random a = new Random();
            this.Font = new Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label1.ForeColor = Color.Yellow;
            
            this.Click += FrmScreen_Click;

            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void FrmScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int star_X;
        int star_Y;
        private void FrmScreen_MouseMove(object sender, MouseEventArgs e)
        {
            star_X = e.X;
            star_Y = e.Y;
       

            //this.label1.Text = e.X + "," + e.Y;
        }

        private void FrmScreen_Load(object sender, EventArgs e)
        {

        }
        int c = 5;
        int b = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random a = new Random();
            this.label1.Text = DateTime.Now.ToString();
            this.label1.Left += c;
            this.label1.Top += b;
            
            if (this.label1.Left > this.Width || this.label1.Top> this.Height|| this.label1.Top<0|| this.label1.Left<0)
            {

                //label1.Left = 0;
                label1.Left= a.Next(this.Width - label1.Width);
                label1.Top = a.Next(this.Height - label1.Height);
                c= a.Next(-5,5);
                b= a.Next(-5, 5);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = !this.timer1.Enabled;
        }
        int a=0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            a++;
            if (a > 5)
            {

                a = 0;
            }
             this.pictureBox1.Image = this.imageList1.Images[a];
           
        }
        double i=100;
        private void timer3_Tick(object sender, EventArgs e)
        {

            this.pictureBox1.Height += 10;
            this.pictureBox1.Width += 15;

            //if (this.pictureBox1.Height >= 800)
            //{
            //    this.timer3.Enabled = false;
            //    this.timer4.Enabled = true;

            //}
            this.Opacity = i / 100.0;
            i++;
            if (i > 100)
            {
                this.timer3.Enabled = false;
                this.timer4.Enabled = true;

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            this.pictureBox1.Height -= 10;
            this.pictureBox1.Width -= 15;

            //if (this.pictureBox1.Height <= 200)
            //{
            //    this.timer6.Enabled = false;
            //    this.timer5.Enabled = true;

            //}
           
            this.Opacity = i / 100.0;
            i--;
            if (i <= 50)
            {
                this.timer4.Enabled = false;
                this.timer3.Enabled = true;

            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer5_Tick_1(object sender, EventArgs e)
        {
            Random a = new Random();
            int d = a.Next(this.Height);
            int X1 = a.Next(this.Width - d);
            int Y1 = a.Next(this.Height - d);
            Bitmap b = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(b);
            
            Color c=Color.FromArgb(a.Next(256), a.Next(256), a.Next(256));
            //g.FillEllipse(Brushes.Orange, X, Y, d, d);
            
            SolidBrush S = new SolidBrush(c);
            g.FillEllipse(S, X1, Y1, d, d);
            g.DrawLine(Pens.Red, 0, star_Y, this.Width, star_Y);
            g.DrawLine(Pens.Red,  star_X, 0, star_X, this.Width);
            this.BackgroundImage = b;
        }
    }
}
