using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;

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
            _driver.FindElement(By.XPath("//a[contains(text(),'Profile')]"))?.Click();
            Thread.Sleep(2000); // Wait for profile page to load
        }

        public void AddLanguages(List<(string Name, string Level)> languages)
        {
            foreach (var (name, level) in languages)
            {
                _driver.FindElement(By.XPath("//button[contains(text(),'Add New Language')]"))?.Click();
                Thread.Sleep(1000);

                var languageInput = _driver.FindElement(By.Name("name"));
                languageInput.Clear();
                languageInput.SendKeys(name);

                var levelDropdown = _driver.FindElement(By.Name("level"));
                levelDropdown.Click();
                Thread.Sleep(500);
                levelDropdown.FindElement(By.XPath($"//option[text()='{level}']"))?.Click();

                _driver.FindElement(By.XPath("//input[@value='Add']"))?.Click();
                Thread.Sleep(1000);
            }
        }

        public void SwitchToSkillsTab()
        {
            _driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"))?.Click();
            Thread.Sleep(1000);
        }

        public void AddSkills(List<(string Name, string Level)> skills)
        {
            foreach (var (name, level) in skills)
            {
                _driver.FindElement(By.XPath("//button[contains(text(),'Add New Skill')]"))?.Click();
                Thread.Sleep(1000);

                var skillInput = _driver.FindElement(By.Name("name"));
                skillInput.Clear();
                skillInput.SendKeys(name);

                var levelDropdown = _driver.FindElement(By.Name("level"));
                levelDropdown.Click();
                Thread.Sleep(500);
                levelDropdown.FindElement(By.XPath($"//option[text()='{level}']"))?.Click();

                _driver.FindElement(By.XPath("//input[@value='Add']"))?.Click();
                Thread.Sleep(1000);
            }
        }

        public void AddLanguagesAndSkills()
        {
            var languages = new List<(string Name, string Level)>
            {
                ("English", "Fluent"),
                ("Mandarin", "Fluent"),
                ("Cantonese", "Native/Bilingual"),
                ("Japanese", "Fluent")
            };
            AddLanguages(languages);

            SwitchToSkillsTab();

            var skills = new List<(string Name, string Level)>
            {
                ("Python", "Beginner"),
                ("Java", "Beginner"),
                ("JavaScript", "Beginner"),
                ("HTML", "Beginner"),
                ("CSS", "Beginner")
            };
            AddSkills(skills);
        }
    }
}
