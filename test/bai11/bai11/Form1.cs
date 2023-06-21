using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using xNet;
using OtpNet;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace bai11
{
    public partial class tool : Form
    {
        int soluongdangchay = 0;
        public tool()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            String pathfile = textBoxfilepath.Text;

            string data = FileHelper.ReadFile(pathfile);

            string[] accounts = data.Split('\n');

            for (int i = 0; i < accounts.Length; i++)
            {
                string acc = accounts[i].Trim();
                string uid = acc.Split('|')[0];
                string pass = acc.Split('|')[1];
                string _2fa = acc.Split('|')[2];

                dataGridViewdata.Rows.Add();
                int row = dataGridViewdata.Rows.Count;
                dataGridViewdata.Rows[row - 1].Cells[0].Value = row.ToString();
                dataGridViewdata.Rows[row - 1].Cells[1].Value = uid;
                dataGridViewdata.Rows[row - 1].Cells[2].Value = pass;
                dataGridViewdata.Rows[row - 1].Cells[3].Value = _2fa;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = FileHelper.ReadFile(textBoxproxy.Text);

            string[] proxy = data.Split('\n');

            for (int i = 0 ; i < dataGridViewdata.Rows.Count; i++)
            {
                string prx = proxy[i %  proxy.Length];
                dataGridViewdata.Rows[i].Cells[4].Value = prx;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }



        //D:/Download/C#/test/taothufile.txt
        //D:/Download/C#/test/proxy.txt

        private void button3run_Click(object sender, EventArgs e)
        {

            Thread t = new Thread(() =>
            {
                int soluongtoida = (int)numericUpDownluong.Value;
                soluongdangchay = 0;

                for (int i = 0; i < dataGridViewdata.Rows.Count; i++)
                {
                    while (true)
                    {
                        if (soluongdangchay < soluongtoida)
                            break;
                        Thread.Sleep(500);
                    }
                    soluongdangchay++;
                    int index =  i;
                    Hamchaydaluong(index);
                }
            });
            t.IsBackground = true;
            t.Start();
        }



        void Hamchaydaluong(int i)
        {
            Thread t = new Thread(() =>
            {

                string uid = dataGridViewdata.Rows[i].Cells[1].Value.ToString();
                string pass = dataGridViewdata.Rows[i].Cells[2].Value.ToString();
                string _2fa = dataGridViewdata.Rows[i].Cells[3].Value.ToString();


                dataGridViewdata.Rows[i].Cells[7].Value = "Bắt đầu chạy...";

                // tắt cmd
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                //tắt cái đ gì đấy
                ChromeOptions options = new ChromeOptions();

                //options.AddArgument("--disable-blink-features=AutomationControlled");
                //options.AddExcludedArgument("enabel-automation");
                //options.AddAdditionalCapability("");
                options.AddArgument("--window-size=300,400");

                ChromeDriver chrome = new ChromeDriver(service, options);

                try
                {   
                    //vao fb
                    chrome.Url = "https://mbasic.facebook.com/";

                    //nhap acc
                    Thread.Sleep(1500);
                    dataGridViewdata.Rows[i].Cells[7].Value = "Nhập Uid";
                    chrome.FindElement(By.XPath("//input[@name=\"email\"]")).SendKeys(uid);
                    Thread.Sleep(1500);


                    //nhap pass
                    dataGridViewdata.Rows[i].Cells[7].Value = "Nhập pass";
                    chrome.FindElement(By.XPath("//input[@name=\"pass\"]")).SendKeys(pass);
                    Thread.Sleep(1500);
                    

                    //dang nhap
                    chrome.FindElement(By.XPath("//input[@name=\"login\"]")).Click();
                    Thread.Sleep(1500);

                    // nhap 2fa
                    dataGridViewdata.Rows[i].Cells[7].Value = "Nhập 2fa";
                    string otp = new Totp(Base32Encoding.ToBytes(_2fa)).ComputeTotp();
                    chrome.FindElement(By.XPath("//input[@name = \"approvals_code\"]")).SendKeys(otp);
                    Thread.Sleep(1500);
                    chrome.FindElement(By.XPath("//input[@name = \"submit[Submit Code]\"]")).Click();
                    Thread.Sleep(1500);

                    // dont save
                    chrome.FindElement(By.XPath("//input[@value=\"dont_save\"]")).Click();
                    Thread.Sleep(1500);
                    chrome.FindElement(By.XPath("//input[@name=\"submit[Continue]\"]")).Click();

                    Thread.Sleep(3000);

                    // Đóng chrome
                    //chrome.Quit();



                    dataGridViewdata.Rows[i].Cells[7].Value = "Chạy xong !";
                }
                catch(Exception ex)
                {
                    //dataGridViewdata.Rows[i].Cells[7].Value = ex.Message;
                    dataGridViewdata.Rows[i].Cells[7].Value = "Lỗi cmnr !!!";
                    chrome.Quit();
                }
                soluongdangchay--;
            });
            t.IsBackground = true;
            t.Start();
        }

        void HamChayMoiAccount(int i)
        {
            string uid = dataGridViewdata.Rows[i].Cells[1].Value.ToString();
            string pass = dataGridViewdata.Rows[i].Cells[2].Value.ToString();
            string _2fa = dataGridViewdata.Rows[i].Cells[3].Value.ToString();


            dataGridViewdata.Rows[i].Cells[7].Value = "Bắt đầu chạy...";

            ChromeDriver chrome = new ChromeDriver();
            chrome.Url = "https://mbasic.facebook.com/";


            //nhap acc
            Thread.Sleep(1500);
            chrome.FindElement(By.XPath("//input[@name=\"email\"]")).SendKeys(uid);
            Thread.Sleep(1500);

            //nhap pass
            chrome.FindElement(By.XPath("//input[@name=\"pass\"]")).SendKeys(pass);
            Thread.Sleep(1500);

            //dang nhap
            chrome.FindElement(By.XPath("//input[@name=\"login\"]")).Click();
            Thread.Sleep(1500);

            // nhap 2fa
            string otp = new Totp(Base32Encoding.ToBytes(_2fa)).ComputeTotp();
            chrome.FindElement(By.XPath("//input[@name = \"approvals_code\"]")).SendKeys(otp);
            Thread.Sleep(1500);
            chrome.FindElement(By.XPath("//input[@name = \"submit[Submit Code]\"]")).Click();
            Thread.Sleep(1500);

            // dont save
            chrome.FindElement(By.XPath("//input[@value=\"dont_save\"]")).Click();
            Thread.Sleep(1500);
            chrome.FindElement(By.XPath("//input[@name=\"submit[Continue]\"]")).Click();

            Thread.Sleep(3000);

            // Đóng chrome
            chrome.Quit();



            dataGridViewdata.Rows[i].Cells[7].Value = "Chạy xong...";
        }

        



    }  
}





