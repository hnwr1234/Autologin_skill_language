using NUnit.Framework;
using OpenQA.Selenium;
using Autologin_skill_language.Pages;
using Reqnroll;

namespace Autologin_skill_language.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;

        public LoginSteps(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver);
        }

        [Given(@"I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [Given(@"I click the ""(.*)"" link")]
        public void GivenIClickTheLink(string linkText)
        {
            if (linkText == "Sign In")
            {
                _loginPage.ClickSignInButton();
            }
        }

        [When(@"I enter a valid email and password")]
        public void WhenIEnterAValidEmailAndPassword()
        {
            _loginPage.EnterEmail("valid@example.com"); // Replace with actual valid test email
            _loginPage.EnterPassword("validpassword");   // Replace with actual valid test password
        }

        [When(@"I enter an invalid email and password")]
        public void WhenIEnterAnInvalidEmailAndPassword()
        {
            _loginPage.EnterEmail("invalid@example.com");
            _loginPage.EnterPassword("wrongpassword");
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then(@"I should be redirected to the homepage")]
        public void ThenIShouldBeRedirectedToTheHomepage()
        {
            Assert.That(_driver.Url.ToLower(), Does.Contain("/home"), "Expected to be redirected to the home page.");
        }

        [Then(@"I should see an error message on the login page")]
        public void ThenIShouldSeeAnErrorMessageOnTheLoginPage()
        {
            string bodyText = _driver.FindElement(By.TagName("body")).Text.ToLower();
            Assert.That(bodyText, Does.Contain("invalid").Or.Contain("error"), $"Actual text: {bodyText}");
        }
    }
}
