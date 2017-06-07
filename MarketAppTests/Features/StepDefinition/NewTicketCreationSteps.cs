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
        private WindowsDriver<WindowsElement> windowsDriver;
        private LoginScreen loginScreen;
        private SideBar sideBar;
        private NewTicketCreationScreen newTicketCreationScreen;
        private ProductSelectionScreen productSelectionScreen;

        public NewTicketCreationSteps(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        [Given(@"I am a Registered User")]
        public void GivenIAmARegisteredUser()
        {
            loginScreen = new LoginScreen(this.windowsDriver);
            loginScreen.LoginWithDefaultUser();
        }

        [When(@"I click on ""(.*)"" button from SideBar")]
        public void WhenIClickOnButton(string buttonName)
        {
            sideBar = new SideBar(this.windowsDriver);
            sideBar.ClickOnButton(buttonName);
        }

        [When(@"I select a Customer")]
        public void WhenISelectACustomer()
        {
            newTicketCreationScreen = new NewTicketCreationScreen(this.windowsDriver);
            newTicketCreationScreen.SelectDefaultCustomerById();
            
        }

        [When(@"I select a Delivery Type")]
        public void WhenISelectADeliveryType()
        {
            newTicketCreationScreen.SelectDefaultDeliveryType();
        }

        [When(@"I add a Email Address")]
        public void WhenIAddAEmailAddress()
        {
            newTicketCreationScreen.AddDefaultEmail();
        }

        [When(@"I click on ""(.*)"" button from New Ticket Creation Screen")]
        public void WhenIClickOnButtonFromNewTicketScreen(string buttonName)
        {
            newTicketCreationScreen.ClickOnButton(buttonName);
        }

        [When(@"I allocate ""(.*)"" boxes of apples")]
        public void WhenIAllocateBoxesOfApples(int quantity)
        {
            productSelectionScreen = new ProductSelectionScreen(windowsDriver);
            productSelectionScreen.SelectDefaultProductId();
            productSelectionScreen.EnterAllocQty(quantity);
        }

        [When(@"I enter ""(.*)"" as new sell price")]
        public void WhenIEnterAsNewSellPrice(int sellPrice)
        {
            productSelectionScreen.EnterSellPrice(sellPrice);
        }


    }
}
