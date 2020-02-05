using NUnit.Framework;
using CSharp_Automation.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace CSharp_Automation.TestCases
{

    class LogInTest
    {
        IWebDriver driver;

        [Test]
        public void Test()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.store.demoqa.com");
            //driver.Url = "http://www.store.demoqa.com";

            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.MyAccount.Click();

            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys("TestUser_1");
            loginPage.Password.SendKeys("Test@123");
            loginPage.Submit.Submit();
        }

    }
}