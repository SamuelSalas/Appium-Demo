using appium_demo.Base;
using appium_demo.Config;
using OpenQA.Selenium.Appium;
using TechTalk.SpecFlow;

namespace appium_demo.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void InitializeTest()
        {
            ConfigReader.InitializeSettings();
            DriverFactory.InitializeAppiumDriver<AppiumDriver>();
        }

        [AfterTestRun]
        public static void CleanUp()
        {
            DriverFactory.CloseAppiumContext();
        }
    }
}
