Autologin Skill Language - 

Project Overview

This project is a UI automation testing suite built using:

- C# with NUnit
- Reqnrollfor BDD-style test writing
- Selenium WebDriver Chrome for browser automation
- The Page Object Model (POM) design pattern for scalable and maintainable test code.

The test suite covers login functionality, homepage interactions, and profile updates including adding languages and skills.


  Implementation Approach

- BDD + Reqnroll: Test cases are written in Gherkin syntax using `.feature` files.
- POM Structure: Each page (LoginPage, HomePage, ProfilePage) has its own class under the `Pages` folder to encapsulate element locators and actions.
- Step Definitions: Reside in the `StepDefinitions` folder, each file maps the steps to page actions.
- Hooks: The Hooks/Hook.cs file handles the WebDriver lifecycle. It initializes the browser before each scenario using CommonDriver.StartBrowser() and closes it after each scenario with 
  CommonDriver.CloseBrowser(). This ensures test isolation and consistent browser behavior across tests.
- Test Execution Framework: Built with `Reqnroll` and `NUnit`, running on `net8.0`.
- Driver Setup: Managed by a shared `CommonDriver.cs` and initialized/terminated in `Hook.cs`.

Page Object Model (POM) Structure

Here's how the project follows the POM pattern:
folder structure : 

Automation_skill_language    
                         File. 
Folders - Drivers - CommonDriver.cs
          

        -Features-  Homepage.feature
                   -LoginPage.feature 
                    -ProfilePage.feature 


         - Hooks -  Hook.cs 

        Pages -     HomePage.cs
              -     LoginPage.cs
                    -ProfilePage.cs

    StepDefinitions- HomeSteps.cs
                    -LoginSteps.cs
                    -ProfileStep.cs

                     Program.cs


