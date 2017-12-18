using homework;
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
    public partial class Frtransparencykeym : Form
    {
        public Frtransparencykeym()
        {
            InitializeComponent();
            this.pictureBox1.Image = this.pictureBox1.ErrorImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            g = this.CreateGraphics();
             
        }
        List<paint> lis = new List<paint>();
        paint y = new paint();
        Graphics g;
        private void Frtransparencykeym_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //bool star_down;
        //int star_X;
        //int star_Y;
        bool star_down;
        int star_X;
        int star_Y;
        private void Frtransparencykeym_MouseDown(object sender, MouseEventArgs e)
        {
            //star_down=true;
            //star_X = e.X;
            //star_Y = e.Y;

            star_down = true;
            star_X = e.X;
            star_Y = e.Y;

        }
        
        Pen x1 = new Pen(Color.Red, 1);
        Color x2 = Color.Red;
        private void Frtransparencykeym_MouseMove(object sender, MouseEventArgs e)
        {
            //if(star_down ==true)
            //{

            //    this.Top += e.Y- star_Y;
            //    this.Left+= e.X - star_X;

            //}
             
            if (star_down == true)
            {

                g.DrawLine(new Pen(x2, int.Parse(textBox1.Text)), star_X, star_Y, e.X, e.Y);
                star_X = e.X;
                star_Y = e.Y;
                y.star_X = e.X;
                y.star_X= e.Y;
                lis.Add(y);
            }

        }

        private void Frtransparencykeym_MouseUp(object sender, MouseEventArgs e)
        {
            //star_down = false;
            star_down = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            x2 = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x2 = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             x2 = Color.Green;
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            star_down = true;
            star_X = e.X;
            star_Y = e.Y;

        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            if (star_down == true)
            {

                this.Top += e.Y - star_Y;
                this.Left += e.X - star_X;

            }

        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            star_down = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i =0 ; i <= lis.Count - 1; i++)
            {

                for (int k = 0; k <= i-1; k++)
                  
                    g.DrawLine(new Pen(x2, int.Parse(textBox1.Text)), lis[i].star_X, lis[i].star_Y, lis[k].star_X, lis[k].star_X);
                    
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frtransparencykeym fr = new Frtransparencykeym();
            fr.Show();
            this.Close();
            
        }
    }
}
