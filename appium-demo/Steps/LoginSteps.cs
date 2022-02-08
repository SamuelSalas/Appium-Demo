using appium_demo.Base;
using appium_demo.Pages;
using FluentAssertions;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace appium_demo.Steps
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage loginPage = null!;

        [Given(@"User goes to Login Page")]
        public void GivenUserGoesToLoginPage()
        {
            loginPage = new LoginPage();
            loginPage.ClickLoginButton();
        }

        [When(@"Submit login form")]
        public void WhenSubmitLoginForm(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.SubmitLogin((string)data.UserName, (string)data.Password);
        }

        [Then(@"the user should be logged in successfully$")]
        public void ThenTheUserShouldBeLoggedInSuccessfully()
        {
            loginPage.IsLogin().Should().BeTrue();
            loginPage.ClickSuccessOkBtn();
        }

        [Then(@"Form errors should appear")]
        public void ThenFormErrorsShouldAppear()
        {
            loginPage.IsErrorEmailInputDisplayed().Should().BeTrue();
            loginPage.IsErrorPasswordInputDisplayed().Should().BeTrue();
        }

    }
}
