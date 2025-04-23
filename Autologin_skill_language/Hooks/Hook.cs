using Reqnroll;
using Autologin_skill_language.Drivers;

[Binding]
public class Hooks
{
    [BeforeScenario]
    public void BeforeScenario()
    {
        CommonDriver.StartBrowser();
    }

    [AfterScenario]
    public void AfterScenario()
    {
        CommonDriver.CloseBrowser();
    }
}
