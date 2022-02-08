using System.IO;
using Microsoft.Extensions.Configuration;

namespace appium_demo.Config
{
    public class ConfigReader
    {
        public static void InitializeSettings()
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName)
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();

            AppiumSettings.PlatformName = configuration["platformName"];
            AppiumSettings.DeviceName = configuration["deviceName"];
            AppiumSettings.PlatformVersion = configuration["platformVersion"];
            AppiumSettings.AutomationName = configuration["automationName"];
            AppiumSettings.App = configuration["app"];
            AppiumSettings.AppWaitActivity = configuration["appWaitActivity"];
        }
    }
}
