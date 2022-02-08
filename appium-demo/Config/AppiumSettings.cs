namespace appium_demo.Config
{
    class AppiumSettings
    {
        public static string PlatformName { get; set; } = "";
        public static string DeviceName { get; set; } = "";
        public static string PlatformVersion { get; set; } = "";
        public static string AutomationName { get; set; } = "";
        public static string App { get; set; } = "";
        public static string AppWaitActivity { get; set; } = "";
        public static bool NoReset { get; set; } = false;
    }
}
