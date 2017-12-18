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
    public partial class FormStudentGeneric : Form
    {
        const int tab = 12;
        
        
        List<Student> lis = new List<Student>();
        Student y = new Student();
        StudentTatol x = new StudentTatol();
        public FormStudentGeneric()
        {
            InitializeComponent();
    
            richTextBox1.Text = $"{"Name:",tab}{"English:",tab}{"Math:",tab}{"Chinese:",tab}{"Tatol:",tab}{"Average:",tab}{"Man:",tab}{"Min:",tab}\n";
        }

        private void Namelabel_Click(object sender, EventArgs e)
        {

        }
        


        private void AddButton_Click(object sender, EventArgs e)
        {

            y.name = NameBox.Text;
            bool a=int.TryParse(EnglishBox.Text,out y.num1);
            if (a != true)//英文不等於數字的話
            {
                MessageBox.Show("Enter English Number");
            }

            bool b = int.TryParse(MathBox.Text, out y.num2);
            if (b != true)//數學不等於數字的話
            {
                MessageBox.Show("Enter Math Number");
            }

            bool c = int.TryParse(ChineseBox.Text ,out y.num3);
            if (c != true)//中文不等於數字的話
            {
                MessageBox.Show("Enter Chinese Number");
            }
            if (a && b && c == true) { 
            y.tatol = y.num1 + y.num2 + y.num3;
            y.average = y.tatol / 3;
            y.max=std_generic.max(y.num1, y.num2, y.num3);
            y.min = std_generic.min(y.num1, y.num2, y.num3);
            richTextBox1.Text += $"{y.name,tab}\t{y.num1,tab}\t{y.num2,tab}\t{y.num3,tab}\t{y.tatol,tab}\t{y.average,tab}\t{y.max,tab}\t{y.min,tab}\t\n";
            lis.Add(y);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        private void AddRandombutton_Click(object sender, EventArgs e)
        {
            
            Random a = new Random();//亂數

            y.name = (lis.Count + 1).ToString();//把name設成按鈕次數如1.2.3.4.6
            y.num1 = a.Next(0, 101);//亂數英文
            y.num2 = a.Next(0, 101);//亂數數學
            y.num3 = a.Next(0, 101);//亂數中文
            y.tatol = y.num1 + y.num2 + y.num3;//亂數的總和
            y.average = y.tatol / 3;//亂數的平均
            y.max = std_generic.max(y.num1, y.num2, y.num3);
            y.min = std_generic.min(y.num1, y.num2, y.num3);
            richTextBox1.Text += $"{y.name,tab}\t{y.num1,tab}\t{y.num2,tab}\t{y.num3,tab}\t{y.tatol,tab}\t{y.average,tab}\t{y.max,tab}\t{y.min,tab}\t\n";
            lis.Add(y);
            x.times++;//按鈕次數+1
        }
       
        

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = $"{"Name:",tab}{"English:",tab}{"Math:",tab}{"Chinese:",tab}{"Tatol:",tab}{"Average:",tab}{"Man:",tab}{"Min:",tab}\n";
            lis.Clear();
        }

        private void AddRandom20button_Click(object sender, EventArgs e)
        {
            Random a = new Random();//亂數
            for (int j = 0; j < 20; j++)//一次增加20個亂數
            {
                y.name = (lis.Count + 1).ToString();//把name設成按鈕次數如1.2.3.4.6
                y.num1 = a.Next(0, 101);//亂數英文
                y.num2 = a.Next(0, 101);//亂數數學
                y.num3 = a.Next(0, 101);//亂數中文
                y.tatol = y.num1 + y.num2 + y.num3;//段數的總和
                y.average = y.tatol / 3;//亂數平均
                y.max = std_generic.max(y.num1, y.num2, y.num3);
                y.min = std_generic.min(y.num1, y.num2, y.num3);
                richTextBox1.Text += $"{y.name,tab}\t{y.num1,tab}\t{y.num2,tab}\t{y.num3,tab}\t{y.tatol,tab}\t{y.average,tab}\t{y.max,tab}\t{y.min,tab}\t\n";

                x.times++;//按鈕次數+1
                lis.Add(y);
            }
        }
        //int temp = 0;
        private void TatolSumbutton_Click(object sender, EventArgs e)
        {
            x.num1max = lis[0].num1;
            x.num2max = lis[0].num2;
            x.num3max = lis[0].num3;
            x.num1min = lis[0].num1;
            x.num2min = lis[0].num2;
            x.num3min = lis[0].num3;

            for (int i = 0; i < lis.Count; i++)
            {

                x.num1tatol += lis[i].num1;
                x.num2tatol += lis[i].num2;
                x.num3tatol += lis[i].num3;
                if (lis[i].num1 > x.num1max)
                {
                    x.num1max = lis[i].num1;
                }
                if (lis[i].num2 > x.num2max)
                {
                    x.num2max = lis[i].num2;
                }
                if (lis[i].num3 > x.num3max)
                {
                    x.num3max = lis[i].num3;
                }
                if (lis[i].num1 < x.num1min)
                {
                    x.num1min = lis[i].num1;
                }
                if (lis[i].num2 < x.num2min)
                {
                    x.num2min = lis[i].num2;
                }
                if (lis[i].num3 < x.num3min)
                {
                    x.num3min = lis[i].num3;
                }
            }
            //richTextBox1.Text += "\n======================\n" +
            //   "\t"+ "English\t" +"MATH\t"+"Chinese\n"+
            //   "總分\t\t" +
            //   x.num1tatol +
            //   "\t\t" +
            //   x.num2tatol +
            //   "\t\t" +
            //   x.num3tatol +
            //   "\n平均\t\t" +
            //   x.num1tatol / lis.Count +
            //   "\t\t" +
            //   x.num2tatol / lis.Count +
            //   "\t\t" +
            //   x.num3tatol / lis.Count +
            //   "\n最低\t\t" +//抓排序後的第一個數字為最小
            //   x.num1min +
            //   "\t\t" +
            //   x.num2min +
            //   "\t\t" +
            //   x.num3min +
            //   "\n最高\t\t" +//抓排序後的最後數字為最大
            //   x.num1max +
            //   "\t\t" +
            //   x.num2max +
            //   "\t\t" +
            //   x.num3max
            //   ;
            richTextBox1.Text += "=====================================\n";
            richTextBox1.Text +=$"{"科目",tab}{"English",tab}{"MATH",tab}" +
                $"{"Chinese",tab}{"\n"}{"總分",tab}{x.num1tatol,tab}{x.num2tatol,tab}" +
                $"{x.num3tatol,tab}{"\n"}{"平均",tab}{x.num1tatol / lis.Count,tab}" +
                $"{x.num2tatol / lis.Count,tab}{x.num3tatol / lis.Count,tab}{"\n"}{"最低",tab}" +
                $"{x.num1min,tab}{x.num2min,tab}{x.num3min,tab}{"\n"}{"最高",tab}{x.num1max,tab}" +
                $"{x.num2max,tab}{x.num3max,tab}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            y.name = NameBox.Text;
            bool a = int.TryParse(EnglishBox.Text, out y.num1);
            if (a != true)//英文不等於數字的話
            {
                MessageBox.Show("Enter English Number");
            }

            bool b = int.TryParse(MathBox.Text, out y.num2);
            if (b != true)//數學不等於數字的話
            {
                MessageBox.Show("Enter Math Number");
            }

            bool c = int.TryParse(ChineseBox.Text, out y.num3);
            if (c != true)//中文不等於數字的話
            {
                MessageBox.Show("Enter Chinese Number");
            }
            if (a && b && c == true)
            {
                int num;
               
                bool a1 = int.TryParse(InsertBox.Text, out num);
                if (a1 !=true) {
                    MessageBox.Show("Enter  Number");
                }
                
                y.tatol = y.num1 + y.num2 + y.num3;
                y.average = y.tatol / 3;
                y.max = std_generic.max(y.num1, y.num2, y.num3);
                y.min = std_generic.min(y.num1, y.num2, y.num3);
                richTextBox1.Text += $"{y.name,tab}\t{y.num1,tab}\t{y.num2,tab}\t{y.num3,tab}\t{y.tatol,tab}\t{y.average,tab}\t{y.max,tab}\t{y.min,tab}\t\n";
                if (num > lis.Count)
                {
                    MessageBox.Show("請輸入小一點的數字");
                }
                else {
                    int a2 = num - 1;
                    lis.Insert(a2, y);
                    richTextBox1.Text = $"{"Name:",tab}{"English:",tab}{"Math:",tab}{"Chinese:",tab}{"Tatol:",tab}{"Average:",tab}{"Man:",tab}{"Min:",tab}\n";
                    for (int i = 0; i < lis.Count; i++)
                    {

                        y = lis[i];

                        richTextBox1.Text += $"{y.name,tab}\t{y.num1,tab}\t{y.num2,tab}\t{y.num3,tab}\t{y.tatol,tab}\t{y.average,tab}\t{y.max,tab}\t{y.min,tab}\t\n";
                    }
                   
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num;
            bool a1 = int.TryParse(InsertBox.Text, out num);
            if (a1 != true)
            {
                MessageBox.Show("Enter  Number");
            }
            
            int a2 = num - 1;
            if (num>lis.Count)
            {
                MessageBox.Show("請輸入小一點的數字");
            }
            else { 
            lis.RemoveAt(a2);
            richTextBox1.Text = $"{"Name:",tab}{"English:",tab}{"Math:",tab}{"Chinese:",tab}{"Tatol:",tab}{"Average:",tab}{"Man:",tab}{"Min:",tab}\n";
            for (int i = 0; i < lis.Count; i++)
            {
                
                y = lis[i];

                richTextBox1.Text += $"{y.name,tab}\t{y.num1,tab}\t{y.num2,tab}\t{y.num3,tab}\t{y.tatol,tab}\t{y.average,tab}\t{y.max,tab}\t{y.min,tab}\t\n";
            }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int topmath,bottommath;
            bool a = int.TryParse(textBox1.Text, out topmath);
            if (a != true)//英文不等於數字的話
            {
                MessageBox.Show("Enter  Number");
            }

            bool b = int.TryParse(textBox2.Text, out bottommath);
            if (b != true)//數學不等於數字的話
            {
                MessageBox.Show("Enter  Number");
            }
            if (a && b && bottommath> topmath == true)
            {
                richTextBox1.Text += "================Math Search" + bottommath + "~" + topmath + "===================\n";
                richTextBox1.Text += $"{"Name:",tab}{"English:",tab}{"Math:",tab}{"Chinese:",tab}{"Tatol:",tab}{"Average:",tab}{"Man:",tab}{"Min:",tab}\n";
                for (int i = 0; i <= lis.Count-1; i++)
                {

                    if (bottommath >=lis[i].num2 && topmath <=lis[i].num2)
                   {

                        y = lis[i];
                   
                    richTextBox1.Text += $"{y.name,tab}\t{y.num1,tab}\t{y.num2,tab}\t{y.num3,tab}\t{y.tatol,tab}\t{y.average,tab}\t{y.max,tab}\t{y.min,tab}\t\n";

                    }

                }
            }
            else
            {

                MessageBox.Show("請輸入正確數字的數字");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int topmath, bottommath;
            bool a = int.TryParse(textBox1.Text, out topmath);
            if (a != true)//英文不等於數字的話
            {
                MessageBox.Show("Enter  Number");
            }

            bool b = int.TryParse(textBox2.Text, out bottommath);
            if (b != true)//數學不等於數字的話
            {
                MessageBox.Show("Enter  Number");
            }
            if (a && b && bottommath > topmath == true)
            {
                richTextBox1.Text += "===============English Search" + bottommath + "~" + topmath + "===================\n";
                richTextBox1.Text += $"{"Name:",tab}{"English:",tab}{"Math:",tab}{"Chinese:",tab}{"Tatol:",tab}{"Average:",tab}{"Man:",tab}{"Min:",tab}\n";
                for (int i = 0; i <= lis.Count - 1; i++)
                {

                    if (bottommath >= lis[i].num1 && topmath <= lis[i].num1)
                    {

                        y = lis[i];

                        richTextBox1.Text += $"{y.name,tab}\t{y.num1,tab}\t{y.num2,tab}\t{y.num3,tab}\t{y.tatol,tab}\t{y.average,tab}\t{y.max,tab}\t{y.min,tab}\t\n";

                    }

                }


            }
            else
            {

                MessageBox.Show("請輸入正確數字的數字");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int topmath, bottommath;
            bool a = int.TryParse(textBox1.Text, out topmath);
            if (a != true)//英文不等於數字的話
            {
                MessageBox.Show("Enter  Number");
            }

            bool b = int.TryParse(textBox2.Text, out bottommath);
            if (b != true)//數學不等於數字的話
            {
                MessageBox.Show("Enter  Number");
            }
            if (a && b && bottommath > topmath == true)
            {
                richTextBox1.Text += "===============Chinese Search" + bottommath + "~" + topmath + "===================\n";
                richTextBox1.Text += $"{"Name:",tab}{"English:",tab}{"Math:",tab}{"Chinese:",tab}{"Tatol:",tab}{"Average:",tab}{"Man:",tab}{"Min:",tab}\n";
                for (int i = 0; i <= lis.Count - 1; i++)
                {

                    if (bottommath >= lis[i].num3 && topmath <= lis[i].num3)
                    {

                        y = lis[i];

                        richTextBox1.Text += $"{y.name,tab}\t{y.num1,tab}\t{y.num2,tab}\t{y.num3,tab}\t{y.tatol,tab}\t{y.average,tab}\t{y.max,tab}\t{y.min,tab}\t\n";

                    }

                }


            }
            else
            {

                MessageBox.Show("請輸入正確數字的數字");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Text += "===============Name Search:" + textBox3.Text + "===================\n";
            richTextBox1.Text += $"{"Name:",tab}{"English:",tab}{"Math:",tab}{"Chinese:",tab}{"Tatol:",tab}{"Average:",tab}{"Man:",tab}{"Min:",tab}\n";
            for (int i = 0; i <= lis.Count - 1; i++)
            {
                
                if (textBox3.Text == lis[i].name)
                {

                    y = lis[i];

                    richTextBox1.Text += $"{y.name,tab}\t{y.num1,tab}\t{y.num2,tab}\t{y.num3,tab}\t{y.tatol,tab}\t{y.average,tab}\t{y.max,tab}\t{y.min,tab}\t\n";

                }
            }
        }
    }
}
