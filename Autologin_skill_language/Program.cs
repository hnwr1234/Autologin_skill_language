using System;
using System.Threading;
using Autologin_skill_language.Drivers;
using Autologin_skill_language.Pages;

namespace Autologin_skill_language
{
    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                // Start the browser session
                CommonDriver.StartBrowser();

                // Navigate to the home page
                CommonDriver.driver!.Navigate().GoToUrl("http://localhost:5003/");

                // Login actions
                var loginPage = new LoginPage(CommonDriver.driver);
                loginPage.ClickSignInButton();
                loginPage.EnterEmail("raphaeltwwong@hotmail.com");
                loginPage.EnterPassword("Fsdp8000121");
                loginPage.ClickLoginButton();

                Thread.Sleep(3000); // Wait for login to complete

                // Navigate and perform profile updates
                var profilePage = new ProfilePage(CommonDriver.driver);
                profilePage.NavigateToProfile();
                profilePage.AddLanguagesAndSkills();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Always ensure browser closes
                CommonDriver.CloseBrowser();
            }
        }
    }
}
