using appium_demo.Base;
using appium_demo.Pages;
using FluentAssertions;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace appium_demo.Steps
{
    [Binding]
    public class FormPageSteps
    {
        private FormsPage formsPage = null!;

        [Given(@"goes to Form Page")]
        public void GivenGoesToFormPage()
        {
            formsPage = new FormsPage();
            formsPage.ClickFormsButton();
        }

        [When(@"enter ""([^""]*)"" into Input field")]
        public void WhenEnterIntoInputField(string value)
        {
            formsPage.SetInputFieldValue(value);
        }

        [Then(@"Input text result should be also ""([^""]*)""")]
        public void ThenInputTextResultShouldBeAlso(string value)
        {
            formsPage.GetInputTextResult().Should().Be(value);
        }

        [When(@"clicks switch")]
        public void WhenClicksSwitch()
        {
            formsPage.ClickSwitch();
        }

        [Then(@"the switch should turn ON")]
        public void ThenThewSwitchShouldTurnOn()
        {
            formsPage.IsSwitchON().Should().BeTrue();
        }

        [Then(@"switch text should contain ""([^""]*)""")]
        public void ThenSwitchTextShouldContain(string value)
        {
            formsPage.GetSwitchText().Should().Contain(value);
        }


        [When(@"dropdown option ""([^""]*)"" is selected")]
        public void WhenDropdownOptionIsSelected(string option)
        {
            formsPage.SelectDropdownValue(option);
        }

        [Then(@"""([^""]*)"" option should be displayed")]
        public void ThenOptionShouldBeDisplayed(string option)
        {
            formsPage.GetDropdownText().Should().Be(option);
        }

    }
}
