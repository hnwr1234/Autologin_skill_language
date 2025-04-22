using OpenQA.Selenium;
using System;

namespace Autologin_skill_language.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

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
    }
}
