using appium_demo.Config;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Service;
using System;

namespace appium_demo.Base
{
    public class DriverFactory
    {
        public static AppiumDriver AppiumDriver { get; set; } = null!;

        public static void InitializeAppiumDriver<T>() where T : AppiumDriver
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalAppiumOption(AndroidMobileCapabilityType.AppWaitActivity, AppiumSettings.AppWaitActivity);
            driverOptions.PlatformName = AppiumSettings.PlatformName;
            driverOptions.DeviceName = AppiumSettings.DeviceName;
            driverOptions.PlatformVersion = AppiumSettings.PlatformVersion;
            driverOptions.AutomationName = AppiumSettings.AutomationName;
            driverOptions.App = AppiumSettings.App;

            AppiumLocalService builder = StartAppiumLocalService();

            if (AppiumSettings.PlatformName == "Android")
            {
                AppiumDriver = new AndroidDriver(builder, driverOptions);
            }

            if (AppiumSettings.PlatformName == "iOS")
            {
                AppiumDriver = new IOSDriver(builder, driverOptions);
            }
            AppiumDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        private static AppiumLocalService StartAppiumLocalService()
        {
            AppiumLocalService _appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            if (!_appiumLocalService.IsRunning)
            {
                _appiumLocalService.Start();
            }

            return _appiumLocalService;
        }

        public static void CloseAppiumContext()
        {
            AppiumDriver.CloseApp();
        }
    }
}
