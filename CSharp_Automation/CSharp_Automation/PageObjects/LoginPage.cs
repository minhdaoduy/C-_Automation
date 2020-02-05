using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace CSharp_Automation.PageObjects
{
    class LoginPage
    {
        //private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "log")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "pwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement Submit { get; set; }
    }
}
