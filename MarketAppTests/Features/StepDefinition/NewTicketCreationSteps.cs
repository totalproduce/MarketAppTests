using MarketAppTests.Libraries.Screens;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace MarketAppTests.Features.StepDefinition
{
    [Binding]
    public sealed class NewTicketCreationSteps
    {
        private readonly WindowsDriver<WindowsElement> windowsDriver;
        private LoginScreen loginScreen;

        public NewTicketCreationSteps(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        [Given(@"I am a registered user")]
        public void GivenIAmARegisteredUser()
        {
            loginScreen = new LoginScreen(this.windowsDriver);
            loginScreen.LoginWithDefaultUser();
        }
        
        [When(@"I select a customer")]
        public void WhenISelectACustomer()
        {
            // add screen methods here
        }

        [When(@"I click on ""(.*)"" button from NewTicketScreen")]
        public void WhenIClickOnButtonFromNewTicketScreen(string p0)
        {
            
        }
    }
}
