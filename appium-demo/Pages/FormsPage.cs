using System;
using System.Threading;
using appium_demo.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace appium_demo.Pages
{
    class FormsPage : BasePage
    {
        public AppiumElement InputFieldTitle => AppiumDriver.FindElement(By.XPath("//XCUIElementTypeStaticText[@name='Input field:']"));

        public AppiumElement InputField => AppiumDriver.FindElement("accessibility id", "text-input");

        public AppiumElement InputTextResult => AppiumDriver.FindElement("accessibility id", "input-text-result");

        public AppiumElement Switch => AppiumDriver.FindElement("accessibility id", "switch");

        public AppiumElement SwitchText => AppiumDriver.FindElement("accessibility id", "switch-text");

        public AppiumElement Dropdown => AppiumDriver.FindElement("accessibility id", "Dropdown");

        public AppiumElement iOSDropdownPicker => AppiumDriver.FindElement(By.XPath("//XCUIElementTypePicker[@name='Dropdown picker']/XCUIElementTypePickerWheel"));

        public AppiumElement iOSDropdownPickerDoneButton => AppiumDriver.FindElement("accessibility id", "done_button");

        public AppiumElement AndroidDropdownOptionModal(string value)
        {
            return AppiumDriver.FindElement(By.XPath(string.Format("//android.widget.ListView/*[@text='{0}']", value)));
        }

        public AppiumElement DropdownText()
        {
            if (AppiumDriver.PlatformName.Equals("Android"))
            {
                return AppiumDriver.FindElement(By.XPath("//android.view.ViewGroup[@content-desc='Dropdown']/android.view.ViewGroup/android.widget.EditText"));
            }
            else
            {
                return AppiumDriver.FindElement("accessibility id", "text_input");
            }
        }

        public void ClickDropdownValue(string value)
        {
            if (AppiumDriver.PlatformName.Equals("Android"))
            {
                AndroidDropdownOptionModal(value).Click();
            }
            else
            {
                iOSDropdownPicker.SendKeys(value);
                iOSDropdownPickerDoneButton.Click();
            }
        }

        public void SetInputFieldValue(string value)
        {
            InputField.SendKeys(value);

            if (AppiumDriver.IsKeyboardShown())
            {
                InputFieldTitle.Click();
            }
        }

        public string GetInputTextResult()
        {
            return InputTextResult.Text;
        }

        public void ClickSwitch()
        {
            Switch.Click();
        }

        public bool IsSwitchON()
        {
            if (AppiumDriver.PlatformName.Equals("Android"))
            {
                return Switch.Text == "ON";
            }
            else
            {
                return Switch.Text == "1";
            }
        }

        public string GetSwitchText()
        {
            return SwitchText.Text;
        }

        public void SelectDropdownValue(string value)
        {
            Dropdown.Click();
            ClickDropdownValue(value);
        }

        public string GetDropdownText()
        {
            return DropdownText().Text;
        }
    }
}
