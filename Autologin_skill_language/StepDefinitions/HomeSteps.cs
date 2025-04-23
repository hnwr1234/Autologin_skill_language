using Reqnroll;
using NUnit.Framework;
using Autologin_skill_language.Pages;
using Autologin_skill_language.Drivers;
using OpenQA.Selenium;

[Binding]
public class HomeSteps
{
    private readonly IWebDriver _driver;
    private readonly LoginPage _loginPage;
    private readonly HomePage _homePage;

    public HomeSteps()
    {
        _driver = CommonDriver.driver!;
        _loginPage = new LoginPage(_driver);
        _homePage = new HomePage(_driver);
    }

    [Given("the user launches the application")]
    public void GivenTheUserLaunchesTheApplication()
    {
        _loginPage.NavigateToLoginPage();
    }

    [When("the user logs in with valid credentials")]
    public void WhenTheUserLogsInWithValidCredentials()
    {
        _loginPage.Login("testuser", "password123");
    }

    [Then("the home page is displayed")]
    public void ThenTheHomePageIsDisplayed()
    {
        Assert.That(_homePage.IsDisplayed(), Is.True, "Home page is not displayed.");

    }
}
