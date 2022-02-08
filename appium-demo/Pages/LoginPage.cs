using appium_demo.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace appium_demo.Pages
{
    class LoginPage : BasePage
    {
        public AppiumElement InputEmail => AppiumDriver.FindElement("accessibility id", "input-email");

        public AppiumElement ErrorInputEmail()
        {
            if (AppiumDriver.PlatformName.Equals("Android"))
            {
                return AppiumDriver.FindElement(By.XPath("//android.widget.ScrollView[@content-desc='Login-screen']/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.widget.TextView[1]"));
            }
            else
            {
                return AppiumDriver.FindElement("accessibility id", "Please enter a valid email address");
            }
        }

        public AppiumElement InputPassword => AppiumDriver.FindElement("accessibility id", "input-password");

        public AppiumElement ErrorInputPassword()
        {
            if (AppiumDriver.PlatformName.Equals("Android"))
            {
                return AppiumDriver.FindElement(By.XPath("//android.widget.ScrollView[@content-desc='Login-screen']/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.widget.TextView[2]"));
            }
            else
            {
                return AppiumDriver.FindElement("accessibility id", "Please enter at least 8 characters");
            }
        }

        public AppiumElement BtnLoginForm => AppiumDriver.FindElement("accessibility id", "button-LOGIN");

        public AppiumElement BtnSuccessLogin()
        {
            if (AppiumDriver.PlatformName.Equals("Android"))
            {
                return AppiumDriver.FindElement(By.Id("android:id/button1"));
            }
            else
            {
                return AppiumDriver.FindElement("accessibility id", "OK");
            }
        }

        public AppiumElement FormText => AppiumDriver.FindElement("accessibility id", "When the device has Touch/FaceID (iOS) or FingerPrint enabled a biometrics button will be shown to use and test the login.");

        public void SetInputEmailText(string email)
        {
            InputEmail.SendKeys(email);

            if (AppiumDriver.IsKeyboardShown())
            {
                FormText.Click();
            }
        }

        public string GetInputEmailText()
        {
            return InputEmail.Text;
        }

        public string GetInputPasswordText()
        {
            return InputPassword.Text;
        }

        public void ClickLoginBtnForm()
        {
            BtnLoginForm.Click();
        }

        public void SetInputPasswordText(string password)
        {
            InputPassword.SendKeys(password);

            if (AppiumDriver.IsKeyboardShown())
            {
                FormText.Click();
            }
        }

        public void SubmitLogin(string email, string password)
        {
            SetInputEmailText(email);
            SetInputPasswordText(password);
            ClickLoginBtnForm();
        }

        public bool IsLogin()
        {
            return BtnSuccessLogin().Displayed;
        }

        public bool IsErrorEmailInputDisplayed()
        {
            return ErrorInputEmail().Displayed;
        }

        public bool IsErrorPasswordInputDisplayed()
        {
            return ErrorInputPassword().Displayed;
        }

        public void ClickSuccessOkBtn()
        {
            BtnSuccessLogin().Click();
        }
    }
}
