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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
            richTextBox1.Text = "Name:\tEnglish:\tMath:\tChinese:\tTatol:\taverage:\t Man:\tMin:\t";
        }

        private void Namelabel_Click(object sender, EventArgs e)
        {

        }

        StudentTatol x = new StudentTatol();//東西在tool的計算
        Student[] y = new Student[1];//東西在tool正列
        string oaa = "";
        

        
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Student[] y = new Student[100];
            int idnum = y.Length - 1;


            y[idnum].name = NameBox.Text;//抓名子
            //y[idnum].num1 = int.Parse(EnglishBox.Text);
            //y[idnum].num2 = int.Parse(MathBox.Text);
            //y[idnum].num3 = int.Parse(ChineseBox.Text);
            //y[idnum].tatol = y[idnum].num1 + y[idnum].num2 + y[idnum].num3;
            //y[idnum].average = y[idnum].tatol / 3;
            
            bool a = int.TryParse(EnglishBox.Text, out y[idnum].num1);//抓英文數字
            if (a != true)//英文不等於數字的話
            {
                MessageBox.Show("Enter English Number");
            }
            bool b = int.TryParse(MathBox.Text, out y[idnum].num2);//抓數學數字數字
            if (b != true)//數學不等於數字的話
            {
                MessageBox.Show("Enter Math Number");
            }

            bool c = int.TryParse(ChineseBox.Text, out y[idnum].num3);//抓中文數字
            if (c != true)//中文不等於數字的話
            {
                MessageBox.Show("Enter Chinese Number");
            }
            y[idnum].tatol = y[idnum].num1 + y[idnum].num2 + y[idnum].num3;
            //成績總和
            y[idnum].average = y[idnum].tatol / 3;
            //成績平均
            if (a && b && c==true)
            {// 英文.數學.中文.都是數字的化做
                if (y[idnum].num1 > y[idnum].num2)
            {    
                y[idnum].max = y[idnum].num1;
            }
            else
            {
                y[idnum].max = y[idnum].num2;
            }
            if (y[idnum].max < y[idnum].num3)
            {
                y[idnum].max = y[idnum].num3;

            }
              //三個數字抓最大

            if (y[idnum].num1 < y[idnum].num2)
            {

                y[idnum].min = y[idnum].num1;
            }
            else
            {
                y[idnum].min = y[idnum].num2;
            }
            if (y[idnum].min > y[idnum].num3)
            {

                y[idnum].min = y[idnum].num3;
            }
                //三個數字抓最小
                oaa = "\n" +
                    y[idnum].name + 
                    "\t" +
                    y[idnum].num1.ToString() +
                    "\t\t" + 
                    y[idnum].num2.ToString() +
                    "\t\t" + 
                    y[idnum].num3.ToString() +
                    "\t\t"
                    + y[idnum].tatol +
                    "\t\t" +
                    y[idnum].average +
                    "\t\t" + 
                    y[idnum].max.ToString() +
                    "\t\t" + 
                    y[idnum].min;
                    richTextBox1.Text += oaa;
            Array.Resize(ref y, y.Length + 1);
                //陣列長度+1
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        private void AddRandombutton_Click(object sender, EventArgs e)
        {
            
            //Student[] y = new Student[100];
                int j = y.Length - 1;//陣列長度
                Random a = new Random();//亂數

                y[j].name = x.times.ToString();//把name設成按鈕次數如1.2.3.4.6
                y[j].num1 = a.Next(0, 101);//亂數英文
                y[j].num2 = a.Next(0, 101);//亂數數學
                y[j].num3 = a.Next(0, 101);//亂數中文
                y[j].tatol = y[j].num1 + y[j].num2 + y[j].num3;//亂數的總和
                y[j].average = y[j].tatol / 3;//亂數的平均
                if (y[j].num1 > y[j].num2)
                {
                    y[j].max = y[j].num1;
                }
                else
                {
                    y[j].max = y[j].num2;
                }
                if (y[j].max < y[j].num3)
                {
                    y[j].max = y[j].num3;
                }
                 //三個數字抓最大

            if (y[j].num1 < y[j].num2)
                {

                    y[j].min = y[j].num1;
                }
                else
                {
                    y[j].min = y[j].num2;
                }
                if (y[j].min > y[j].num3)
                {

                    y[j].min = y[j].num3;
                }
            //三個數字抓最小
            oaa = "\n" + 
                y[j].name +
                "\t\t" + 
                y[j].num1.ToString() +
                 "\t\t" +
                 y[j].num2.ToString() +
                 "\t\t" + 
                 y[j].num3.ToString() +
                 "\t\t"
                 + y[j].tatol +
                 "\t\t" +
                 y[j].average +
                 "\t\t" +
                 y[j].max.ToString() +
                 "\t\t" +
                 y[j].min+
                 "\t\t";
                 richTextBox1.Text += oaa;
            x.times++;//按鈕次數+1
            Array.Resize(ref y, y.Length + 1);// 陣列+1

        }
       
        

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Name:\tEnglish:\tMath\tChinese:\tTatol\taverage:\tMan\tMin";
            Array.Resize(ref  y, 1);//陣列初始
        }

        private void AddRandom20button_Click(object sender, EventArgs e)
        {

            //Student[] y = new Student[100];
            Random a = new Random();//亂數
            for (int j = 0; j <= 20; j++)//一次增加20個亂數
            {
                y[j].name = x.times.ToString();//把name設成按鈕次數如1.2.3.4.6
                y[j].num1 = a.Next(0, 101);//亂數英文
                y[j].num2 = a.Next(0, 101);//亂數數學
                y[j].num3 = a.Next(0, 101);//亂數中文
                y[j].tatol = y[j].num1 + y[j].num2 + y[j].num3;//段數的總和
                y[j].average = y[j].tatol / 3;//亂數平均
                if (y[j].num1 > y[j].num2)
                {
                    y[j].max = y[j].num1;
                }
                else
                {
                    y[j].max = y[j].num2;
                }
                if (y[j].max < y[j].num3)
                {
                    y[j].max = y[j].num3;
                }
                //比大小抓最大
                if (y[j].num1 < y[j].num2)
                {

                    y[j].min = y[j].num1;
                }
                else
                {
                    y[j].min = y[j].num2;
                }
                if (y[j].min > y[j].num3)
                {

                    y[j].min = y[j].num3;
                }
                //比大小抓最小
                oaa = "\n" +
                    y[j].name +
                    "\t\t" + 
                    y[j].num1.ToString() +
                    "\t\t" + 
                    y[j].num2.ToString() +
                    "\t\t" + 
                    y[j].num3.ToString() +
                    "\t\t" + 
                    y[j].tatol +
                    "\t\t" + 
                    y[j].average +
                    "\t\t" + 
                    y[j].max.ToString() +
                    "\t\t" + 
                    y[j].min;
                richTextBox1.Text += oaa;
                x.times++;//按鈕次數+1
                Array.Resize(ref y, y.Length + 1);// 陣列+1


            }
            

        }
        //int temp = 0;
        private void TatolSumbutton_Click(object sender, EventArgs e)
        {
            int c = y.Length - 1;//陣列長度
            //StudentTatol x = new StudentTatol();

            for (int j = 0; j <=c; j++)//陣列大小的次數
            {
                x.num1tatol += y[j].num1;//計算英文陣列總和
                x.num2tatol += y[j].num2;//計算數學陣列總和
                x.num3tatol += y[j].num3;//計算中文陣列總和
                for (int i = 0; i <= c - 1; i++)
                {//跑 lenth-1 的次數
                    if (y[i].num1> y[i + 1].num1)//全部英文排列
                    {//只要是前一格大於後一個，就把他的位置做更換，再塞入陣列
                        int temp = y[i].num1;
                        y[i].num1 = y[i + 1].num1;
                        y[i + 1].num1 = temp;
                    }
                    if (y[i].num2 > y[i + 1].num2)//全部數學排列
                    {//只要是前一格大於後一個，就把他的位置做更換，再塞入陣列
                        int temp = y[i].num2;
                        y[i].num2 = y[i + 1].num2;
                        y[i + 1].num2 = temp;
                    }
                    if (y[i].num3 > y[i + 1].num3)//全部中文排列
                    {//只要是前一格大於後一個，就把他的位置做更換，再塞入陣列
                        int temp = y[i].num3;
                        y[i].num3 = y[i + 1].num3;
                        y[i + 1].num3 = temp;
                    }



                }

            }
            richTextBox1.Text += "\n======================\n" +
                "總分\t\t" +
                x.num1tatol + 
                "\t\t" +
                x.num2tatol + 
                "\t\t" +
                x.num3tatol +
                "\n平均\t\t" +
                x.num1tatol/c +
                "\t\t" +
                x.num2tatol/c +
                "\t\t" +
                x.num3tatol /c+ 
                "\n最低\t\t"+//抓排序後的第一個數字為最小
                y[1].num1.ToString()+
                "\t\t" +
                y[1].num2.ToString() +
                "\t\t" +
                y[1].num3.ToString()+
                "\n最高\t\t" +//抓排序後的最後數字為最大
                y[y.Length-1].num1.ToString() +
                "\t\t" +
                y[y.Length-1].num2.ToString() +
                "\t\t" +
                y[y.Length-1].num3.ToString()
                ;
            //TatolSum.Text = x.num1.ToString();

        }
    }
}
