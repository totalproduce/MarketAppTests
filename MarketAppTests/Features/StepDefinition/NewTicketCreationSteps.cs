using MarketAppTests.Libraries.Screens;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            sideBar = new SideBar(this.windowsDriver);
        }

        [When(@"I click on ""(.*)"" button from SideBar")]
        public void WhenIClickOnButton(string buttonName)
        {
            sideBar.ClickOnButton(buttonName);
            newTicketCreationScreen = new NewTicketCreationScreen(this.windowsDriver);
        }

        [When(@"I select a Customer")]
        public void WhenISelectACustomer()
        {
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
            productSelectionScreen = new ProductSelectionScreen(windowsDriver);
        }

        [When(@"I allocate ""(.*)"" boxes of apples")]
        public void WhenIAllocateBoxesOfApples(int quantity)
        {
            productSelectionScreen.SelectDefaultProductId();
            productSelectionScreen.EnterAllocQty(quantity);
        }

        [When(@"I enter ""(.*)"" as new sell price")]
        public void WhenIEnterAsNewSellPrice(int sellPrice)
        {
            productSelectionScreen.EnterSellPrice(sellPrice);
        }

        [When(@"I click on ""(.*)"" button from Product Selection Screen")]
        public void WhenIClickOnButtonFromProductSelectionScreen(string buttonName)
        {
            productSelectionScreen.ClickOnButton(buttonName);
        }

        [Then(@"I should see ""(.*)"" as Code on New Ticket Creation Screen")]
        public void ThenIShouldSeeAsCodeOnNewTicketCreationScreen(string code)
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I should see ""(.*)"" as Quantity on New Ticket Creation Screen")]
        public void ThenIShouldSeeAsQuantityOnNewTicketCreationScreen(int quantity)
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I should see ""(.*)"" as Unit Of Measurement on Ticket Creation Screen")]
        public void ThenIShouldSeeAsUnitOfMeasurementOnTicketCreationScreen(string unit)
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I should see ""(.*)"" as Price on Ticket Creation Screen")]
        public void ThenIShouldSeeAsPriceOnTicketCreationScreen(int price)
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
