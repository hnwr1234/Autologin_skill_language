using OpenQA.Selenium;
using Autologin_skill_language.Drivers;
using NUnit.Framework;

namespace Autologin_skill_language.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        // Constructor
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToHomePage()
        {
            _driver.Navigate().GoToUrl("http://localhost:5003/");
        }

        public void ClickSignIn()
        {
            _driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a")).Click();
        }

        // ✅ Add this method to check if the home page is displayed
        public bool IsDisplayed()
        {
            // You can improve this logic by checking for a specific element that's only on the home page
            return _driver.Url.Contains("/home") || _driver.Title.Contains("Home");
        }
    }
}
