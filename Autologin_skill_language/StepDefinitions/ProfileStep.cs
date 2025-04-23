using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using Autologin_skill_language.Pages;
using NUnit.Framework;
using Reqnroll;

namespace Autologin_skill_language.Steps
{
    [Binding]
    public class ProfilePageSteps
    {
        private readonly IWebDriver _driver;
        private readonly ProfilePage _profilePage;

        public ProfilePageSteps(IWebDriver driver)
        {
            _driver = driver;
            _profilePage = new ProfilePage(driver);
        }

        [Given(@"I am logged in and on the profile page")]
        public void GivenIAmLoggedInAndOnTheProfilePage()
        {
            // Here you can implement login or just navigate to the profile page
            _profilePage.NavigateToProfile();
        }

        [Given(@"I navigate to the profile page")]
        public void GivenINavigateToTheProfilePage()
        {
            _profilePage.NavigateToProfile();
        }

        [When(@"I add the following languages to my profile:")]
        public void WhenIAddTheFollowingLanguagesToMyProfile(Table table)
        {
            var languages = new List<(string Name, string Level)>();

            foreach (var row in table.Rows)
            {
                var name = row["Language"];
                var level = row["Level"];
                languages.Add((name, level));
            }

            _profilePage.AddLanguages(languages);
        }

        [When(@"I add the following skills to my profile:")]
        public void WhenIAddTheFollowingSkillsToMyProfile(Table table)
        {
            var skills = new List<(string Name, string Level)>();

            foreach (var row in table.Rows)
            {
                var name = row["Skill"];
                var level = row["Level"];
                skills.Add((name, level));
            }

            _profilePage.AddSkills(skills);
        }

        [Then(@"the languages should be added successfully")]
        public void ThenTheLanguagesShouldBeAddedSuccessfully()
        {
            // You can verify that the languages were successfully added by checking some page element
            string bodyText = _driver.FindElement(By.TagName("body")).Text;
            Assert.That(bodyText, Does.Contain("Languages added"));
        }

        [Then(@"the skills should be added successfully")]
        public void ThenTheSkillsShouldBeAddedSuccessfully()
        {
            // You can verify that the skills were successfully added by checking some page element
            string bodyText = _driver.FindElement(By.TagName("body")).Text;
            Assert.That(bodyText, Does.Contain("Skills added"));
        }
    }
}
