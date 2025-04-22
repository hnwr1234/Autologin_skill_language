using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
namespace Autologin_skill_language.Pages
{
    public class ProfilePage
    {
        private readonly IWebDriver _driver;

        public ProfilePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToProfile()
        {
            _driver.Navigate().GoToUrl("http://localhost:5003/Account/Profile");
            Thread.Sleep(2000); // Optional wait
        }

        public void AddLanguagesAndSkills()
        {
            AddLanguages();
            SwitchToSkillsTab();
            AddSkills();
        }

        private void AddLanguages()
        {
            var languages = new List<(string Name, string Level)>
            {
                ("English", "Fluent"),
                ("Mandarin", "Fluent"),
                ("Cantonese", "Native/Bilingual"),
                ("Japanese", "Fluent")
            };

            foreach (var (name, level) in languages)
            {
                AddLanguage(name, level);
                Thread.Sleep(1000); // Optional delay
            }
        }

        private void AddLanguage(string languageName, string languageLevel)
        {
            _driver.FindElement(By.XPath("//div[@data-tab='first']//table//div[text()='Add New']")).Click();
            _driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys(languageName);
            var dropdown = new SelectElement(_driver.FindElement(By.Name("level")));
            dropdown.SelectByText(languageLevel);
            _driver.FindElement(By.XPath("//input[@value='Add']")).Click();
        }

        private void SwitchToSkillsTab()
        {
            _driver.FindElement(By.XPath("//a[text()='Skills']")).Click();
            Thread.Sleep(2000); // Optional wait
        }

        private void AddSkills()
        {
            var skills = new List<(string Name, string Level)>
            {
                ("Python", "Beginner"),
                ("Java", "Beginner"),
                ("JavaScript", "Beginner"),
                ("HTML", "Beginner"),
                ("CSS", "Beginner")
            };

            foreach (var (name, level) in skills)
            {
                AddSkill(name, level);
                Thread.Sleep(1000); // Optional delay
            }
        }

        private void AddSkill(string skillName, string skillLevel)
        {
            _driver.FindElement(By.XPath("//div[@data-tab='second']//table//div[text()='Add New']")).Click();
            _driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys(skillName);
            var dropdown = new SelectElement(_driver.FindElement(By.Name("level")));
            dropdown.SelectByText(skillLevel);
            _driver.FindElement(By.XPath("//input[@value='Add']")).Click();
        }
    }
}



