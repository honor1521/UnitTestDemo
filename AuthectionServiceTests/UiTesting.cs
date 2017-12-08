using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Selenium.WebDriver.Extensions.JQuery;
using By = Selenium.WebDriver.Extensions.JQuery.By;

namespace AuthectionServiceTests
{
    [TestClass]
    public class UiTesting
    {
        [TestMethod]
        public void Rakuten_Login_Test()
        {
            IWebDriver driver = new ChromeDriver(@"C:\ChromeDriver");

            // go to main page
            driver.Navigate().GoToUrl("https://www.rakuten.com.tw/");
            Thread.Sleep(1000);

            // find the login icon on main page
            var goToLoginPageSelector = By.JQuerySelector("a[href='https://secure.rakuten.com.tw/member/signin']");
            driver.FindElement(goToLoginPageSelector).Click();
            Thread.Sleep(1000);

            // enter user name on login page
            var userNameSelector = By.JQuerySelector("input[name$=userId]");
            driver.FindElement(userNameSelector).SendKeys("honor0804@gmail.com");

            // enter password on login page
            var passwordSelector = By.JQuerySelector("input[name$=password]");
            driver.FindElement(passwordSelector).SendKeys("passion0612");

            // click login button
            var loginSelector = By.JQuerySelector("button[name$=loginBtn]");
            driver.FindElement(loginSelector).Click();
            Thread.Sleep(1000);

            Assert.AreEqual("https://www.rakuten.com.tw/", driver.Url);            
            driver.Dispose();
        }
    }
}
