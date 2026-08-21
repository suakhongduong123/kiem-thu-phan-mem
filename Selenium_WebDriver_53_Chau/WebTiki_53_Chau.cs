using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Selenium_WebDriver_53_Chau
{
    public partial class frmTestWeb_53_Chau : Form
    {
        public frmTestWeb_53_Chau()
        {
            InitializeComponent();
        }
        // hàm riêng để đăng nhập vào tiki 
        private void LoginTiki(IWebDriver driver_53_Chau)
        {

            //click nút đăng nhập bằng email trên website 
            driver_53_Chau.FindElement(By.ClassName("login-with-email")).Click();

            Thread.Sleep(2000);
            //nhập email vào
            driver_53_Chau.FindElement(By.Name("email")).SendKeys("nickchoco252@gmail.com");
            // nhập password vào
            driver_53_Chau.FindElement(By.XPath(
                "/html/body/div[6]/div/div/div/div[1]/div/form/div[2]/input"))
                .SendKeys("63@Emvbgeie");
            Thread.Sleep(2000);
            //click button đăng nhập
            driver_53_Chau.FindElement(By.XPath(
                "/html/body/div[6]/div/div/div/div[1]/div/form/button"
                )).Click();
        }
        private void btn_login_53_Chau_Click(object sender, EventArgs e)
        {
            // điều hướng trình duyệt web tiki
            IWebDriver driver_53_Chau = new ChromeDriver();
            // Ra lệnh cho trình duyệt đi đến địa chỉ đăng nhập của tiki
            driver_53_Chau.Navigate().GoToUrl("https://tiki.vn/customer/account/login");
            Thread.Sleep(3000);

            // Gọi hàm đăng nhập
            LoginTiki(driver_53_Chau);
            Thread.Sleep(10000);
            driver_53_Chau.Quit();
        }

        private void btn_filter_53_Chau_Click(object sender, EventArgs e)
        {
            // Khởi tạo trình duyệt
            IWebDriver driver_53_Chau = new ChromeDriver();
            // Mở Tiki
            driver_53_Chau.Navigate().GoToUrl("https://tiki.vn/");
            // Full màn hình
            driver_53_Chau.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // Ô tìm kiếm
            IWebElement searchBox_53_Chau = driver_53_Chau.FindElement(By.XPath(
                "//*[@id=\"main-header\"]/div/div/div[2]/div[1]/div[1]/div/div/input"));
            // nhập "gấu bông" để tìm kiế
            searchBox_53_Chau.SendKeys("gấu bông");
            Thread.Sleep(2000);
            // Nhấn Enter 
            searchBox_53_Chau.SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(5000);
            // Chọn "Tất cả"
            driver_53_Chau.FindElement(By.XPath(
                "//*[@id=\"__next\"]/div[2]/main/div/div[2]/div[1]/div[1]/div/div[1]/div[2]/button/div"))
                .Click();
            Thread.Sleep(2000);
            // Giao siêu tốc 2h
            driver_53_Chau.FindElement(By.XPath(
                "//*[@id=\"__next\"]/div[2]/main/div/div[2]/div[2]/div[2]/div[2]/div/div[1]/div/div[1]/span"))
                .Click();
            Thread.Sleep(1000);
            // Đánh giá 5 sao
            driver_53_Chau.FindElement(By.XPath(
                "//*[@id=\"__next\"]/div[2]/main/div/div[2]/div[2]/div[2]/div[4]/div/div[1]/div/div[1]/span"))
                .Click();
            Thread.Sleep(1000);
            // Giá dưới 120k
            driver_53_Chau.FindElement(By.XPath(
                "//*[@id=\"__next\"]/div[2]/main/div/div[2]/div[2]/div[2]/div[5]/div[1]/button[1]"))
                .Click();
            Thread.Sleep(1000);
            // Nút xem kết quả
            driver_53_Chau.FindElement(By.XPath(
                "//*[@id=\"__next\"]/div[2]/main/div/div[2]/div[2]/div[3]/div[2]"))
                .Click();
            Thread.Sleep(5000);
            driver_53_Chau.Quit();
        }

        private void btn_QuanLySp_53_Chau_Click(object sender, EventArgs e)
        {
            // Khởi tạo trình duyệt
            IWebDriver driver_53_Chau = new ChromeDriver();
            // Mở Tiki
            driver_53_Chau.Navigate().GoToUrl("https://tiki.vn/");
            // Full màn hình
            driver_53_Chau.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // Đóng popup quảng cáo nếu có
            try
            {
                driver_53_Chau.FindElement(By.XPath("//*[@id=\"VIP_BUNDLE\"]/div[2]/div/picture[1]")).Click();
                Thread.Sleep(2000);
            }
            catch
            {
            }
            //// nhấn vào thanh tìm kiếm 
            //driver_53_Chau.FindElement(By.XPath("//*[@id=\"main-header\"]/div/div/div[2]/div[1]/div[1]/div/div/input")).Click();
            //Thread.Sleep(2000);
            //// Chọn gợi ý đầu tiên
            //driver_53_Chau.FindElement(By.XPath("//*[@id=\"main-header\"]/div/div/div[2]/div[1]/div[1]/div/div/div/div[2]/a[1]/div")).Click();
            //Thread.Sleep(2000);
            //// chọn sản phẩm đầu tiên 
            //driver_53_Chau.FindElement(By.XPath(
            //    "//*[@id=\"__next\"]/div[2]/main/div/div[2]/div[1]/div[2]/div[1]/div[1]/div/div/div/a/span/div[2]/div[1]/div[2]/div[1]/h3"))
            //    .Click();
            //// chọn thêm vào giỏ hàng 
            //driver_53_Chau.FindElement(By.XPath(
            //    "//*[@id=\"__next\"]/div[2]/main/div/div[2]/div[1]/div[2]/div/div[1]/div[2]/div[3]/button[2]"))
            //    .Click();
            //Thread.Sleep(2000);
            //// đăng nhập vào tiki 
            //LoginTiki(driver_53_Chau);
            //Thread.Sleep(7000);
            ////xem sản phẩm được thêm vào giỏ hàng
            //driver_53_Chau.FindElement(By.XPath(
            //    "//*[@id=\"main-header\"]/div/div/div[2]/div[1]/div[2]/div[4]/div/a[2]"))
            //    .Click();
            Thread.Sleep(5000);
            driver_53_Chau.Quit();
        }
    }
}
