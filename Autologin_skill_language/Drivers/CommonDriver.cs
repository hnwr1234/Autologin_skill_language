using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Autologin_skill_language.Drivers
{
    public static class CommonDriver
    {
        public static IWebDriver? driver;

        public static void StartBrowser()
        {
            if (driver == null)
            {
                ChromeOptions options = new ChromeOptions();

                // Recommended browser options
                options.AddUserProfilePreference("credentials_enable_service", false);
                options.AddUserProfilePreference("profile.password_manager_enabled", false);
                options.AddExcludedArgument("enable-automation");
                options.AddAdditionalOption("useAutomationExtension", false);
                options.AddArgument("--disable-infobars");
                options.AddArgument("--disable-notifications");
                options.AddArgument("--disable-popup-blocking");
                options.AddArgument("--disable-extensions");
                options.AddArgument("--disable-blink-features=AutomationControlled");
                options.AddArgument("--incognito");

                try
                {
                    driver = new ChromeDriver(options);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // Optional implicit wait
                    driver.Manage().Window.Maximize();
                }
                catch (WebDriverException ex)
                {
                    Console.WriteLine("Failed to start the ChromeDriver. Error: " + ex.Message);
                    throw;
                }
            }
        }

        public static void CloseBrowser()
        {
            if (driver != null)
            {
                try
                {
                    driver.Quit();
                    driver = null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while closing browser: " + ex.Message);
                }
            }
        }
    }
}

