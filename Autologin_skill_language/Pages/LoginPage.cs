using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Autologin_skill_language.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // NEW: Navigate to Login Page
        public void NavigateToLoginPage()
        {
            driver.Navigate().GoToUrl("http://localhost:5003/login");  // Adjust URL as needed
        }

        // Locators
        private By signInButton => By.LinkText("Sign In");
        private By emailField => By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input");
        private By passwordField => By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input");
        private By loginButton => By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button");

        // Actions
        public void ClickSignInButton() => driver.FindElement(signInButton).Click();

        public void EnterEmail(string email) => driver.FindElement(emailField).SendKeys(email);

        public void EnterPassword(string password) => driver.FindElement(passwordField).SendKeys(password);

        public void ClickLoginButton() => driver.FindElement(loginButton).Click();

        public void Login(string email, string password)
        {
            EnterEmail(email);
            EnterPassword(password);
            ClickLoginButton();
        }
    }
}
