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
            newTicketCreationScreen = new NewTicketCreationScreen(this.windowsDriver);
        }

        [Then(@"I should see ""(.*)"" as Code on New Ticket Creation Screen")]
        public void ThenIShouldSeeAsCodeOnNewTicketCreationScreen(string code)
        {
            Assert.AreEqual(code, newTicketCreationScreen.GetCodeTicketLine());
        }

        [Then(@"I should see ""(.*)"" as Quantity on New Ticket Creation Screen")]
        public void ThenIShouldSeeAsQuantityOnNewTicketCreationScreen(string quantity)
        {
            Assert.AreEqual(quantity, newTicketCreationScreen.GetQtyTicketLine());
        }

        [Then(@"I should see ""(.*)"" as Unit Of Measurement on Ticket Creation Screen")]
        public void ThenIShouldSeeAsUnitOfMeasurementOnTicketCreationScreen(string unit)
        {
            Assert.AreEqual(unit, newTicketCreationScreen.GetUomTicketLine());
        }

        [Then(@"I should see ""(.*)"" as Price on Ticket Creation Screen")]
        public void ThenIShouldSeeAsPriceOnTicketCreationScreen(string price)
        {
            Assert.AreEqual(price, newTicketCreationScreen.GetPriceTicketLine());
        }

        [When(@"I select the Customer with Id ""(.*)""")]
        public void WhenISelectTheCustomerWithId(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I add ""(.*)"" as a Comment")]
        public void WhenIAddAsAComment(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter ""(.*)"" into the Product field and click on the Product Name")]
        public void WhenIEnterIntoTheProductFieldAndClickOnTheProductName(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see ""(.*)"" as Product Name")]
        public void ThenIShouldSeeAsProductName(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter ""(.*)"" as Quantity")]
        public void WhenIEnterAsQuantity(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select ""(.*)"" from Product Selection Screen")]
        public void WhenISelectFromProductSelectionScreen(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter ""(.*)"" as New Sell Price")]
        public void WhenIEnterAsNewSellPrice(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see ""(.*)"" as Code on line ""(.*)"" on New Ticket Creation Screen")]
        public void ThenIShouldSeeAsCodeOnLineOnNewTicketCreationScreen(string p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see ""(.*)"" as Quantity on line ""(.*)"" on New Ticket Creation Screen")]
        public void ThenIShouldSeeAsQuantityOnLineOnNewTicketCreationScreen(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see ""(.*)"" as Unit Of Measurement on line ""(.*)"" on Ticket Creation Screen")]
        public void ThenIShouldSeeAsUnitOfMeasurementOnLineOnTicketCreationScreen(string p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see ""(.*)"" as Price on line ""(.*)"" on Ticket Creation Screen")]
        public void ThenIShouldSeeAsPriceOnLineOnTicketCreationScreen(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
