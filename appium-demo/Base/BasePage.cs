using OpenQA.Selenium.Appium;
using System;

namespace appium_demo.Base
{
    public class BasePage : DriverFactory
    {
        public AppiumElement BtnHomePage => AppiumDriver.FindElement("accessibility id", "Home");

        public AppiumElement BtnWebViewPage => AppiumDriver.FindElement("accessibility id", "Webview");

        public AppiumElement BtnLoginPage => AppiumDriver.FindElement("accessibility id", "Login");

        public AppiumElement BtnFormsPage => AppiumDriver.FindElement("accessibility id", "Forms");

        public AppiumElement BtnSwipePage => AppiumDriver.FindElement("accessibility id", "Swipe");

        public AppiumElement BtnDragPage => AppiumDriver.FindElement("accessibility id", "Drag");

        public void ClickHomeButton()
        {
            BtnHomePage.Click();
        }

        public void ClickWebviewButton()
        {
            BtnWebViewPage.Click();
        }

        public void ClickLoginButton()
        {
            BtnLoginPage.Click();
        }

        public void ClickFormsButton()
        {
            BtnFormsPage.Click();
        }

        public void ClickSwipeButton()
        {
            BtnSwipePage.Click();
        }

        public void ClickDragButton()
        {
            BtnDragPage.Click();
        }
    }
}
