using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Net.Mail;
using System.Net;


namespace myhomework2017622
{
    public partial class frmPMT : Form
    {
        public frmPMT()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double money = double.Parse(MoneyBox.Text);
                double ytm = double.Parse(YTMBox.Text);
                double year = double.Parse(yearBox.Text);
                double tatol1;
                tatol1 = money * (ytm / 100) * year + money;
                tatol.Text = "tatol:" + tatol1.ToString("#,#.00");
            }
            catch {
                MessageBox.Show("ENTER NUMBER") ;
                MoneyBox.Text = null;
                YTMBox.Text = null;
                yearBox.Text = null;


            }
        }

        private void tatol_Click(object sender, EventArgs e)
        {
            tatol.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
            double money = double.Parse(MoneyBox.Text);
            double ytm = double.Parse(YTMBox.Text);
            double year = double.Parse(yearBox.Text);
            double tatol1;
            tatol1 = money * (ytm / 100) + money/ year;
            tatol.Text = "tatol:" + tatol1.ToString("#,#.00");
            }
            catch
            {
                MessageBox.Show("ENTER NUMBER");
                MoneyBox.Text = null;
                YTMBox.Text = null;
                yearBox.Text = null;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double money = double.Parse(MoneyBox.Text);
                double ytm = double.Parse(YTMBox.Text);
                double year = double.Parse(yearBox.Text);
                double tatol1;

                tatol1 = Financial.Pmt((ytm / 100), year, money, 0, DueDate.EndOfPeriod);
                double tatol2 = -tatol1;
                tatol.Text = "tatol:" + tatol2.ToString("#,#.00");
            }
            catch
            {
                MessageBox.Show("ENTER NUMBER");
                MoneyBox.Text = null;
                YTMBox.Text = null;
                yearBox.Text = null;


            }


        }

        public void Send_Gmail(string msg, string mysubject, string address)
        {
            address = EMAILBox1.Text;
            msg = tatol.Text;
            //tatol.Text = "" + address;
            
            MailMessage mmsg = new MailMessage("jacky6632003@yahoo.com.tw",address);
            mmsg.IsBodyHtml = true; //設定是否採用HTML格式
            mmsg.BodyEncoding = Encoding.UTF8; //設定mail內容的編碼
            mmsg.SubjectEncoding = Encoding.UTF8; //設定mail主旨的編碼
            mmsg.Priority = MailPriority.Normal; //設定優先權 1.High 2.Normail 3.Low
            mmsg.Subject = mysubject; // mail主旨
            mmsg.Body = msg; //mail內容

            SmtpClient MySmtp = new SmtpClient("smtp.mail.yahoo.com", 587); //允許程式使用smtp來發mail，並設定smtp server & port
            MySmtp.Credentials = new NetworkCredential("jacky6632003@yahoo.com", ""); //設定帳號與密碼 需要using system.net;
            MySmtp.EnableSsl = true; //開啟SSL連線 (gmail體系須使用SSL連線)
            MySmtp.Send(mmsg);

            MySmtp = null; //將MySmtp清空
            mmsg.Dispose(); //釋放資源
            
        }

        private void EMAILBTN_Click(object sender, EventArgs e)
        {/*
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;

            client.Credentials = new NetworkCredential("sf@iii.org.tw", "aspnet123aspnet");
            client.EnableSsl = true;*/

            //string email1 = EMAILBox1.Text;
            Send_Gmail(tatol.Text, "測試主題", "收件人地址");
        }

        private void EMAILBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
