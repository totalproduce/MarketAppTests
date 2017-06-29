using MarketAppTests.Libraries.Screens;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace MarketAppTests.Features.StepDefinition
{
    [Binding]
    public sealed class CreatePurchaseOrderSteps
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private NewPurchaseOrderScreen newPurchaseOrderScreen;

        public CreatePurchaseOrderSteps(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
            newPurchaseOrderScreen = new NewPurchaseOrderScreen(this.windowsDriver);
        }

        [When(@"I select ""(.*)"" as Status from Create Purchase Order Screen")]
        public void WhenISelectAsStatusFromCreatePurchaseOrderScreen(string status)
        {
            newPurchaseOrderScreen.SelectStatus(status);
        }

        [When(@"I select the Supplier with Id ""(.*)"" Create Purchase Order Screen")]
        public void WhenISelectTheSupplierWithIdCreatePurchaseOrderScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on ""(.*)"" button from Create Purchase Order Screen")]
        public void WhenIClickOnButtonFromCreatePurchaseOrderScreen(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I search for Product with code ""(.*)"" from Purchase Order Line Entry Screen")]
        public void WhenISearchForProductWithCodeFromPurchaseOrderLineEntryScreen(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select ""(.*)"" as Weight from Purchase Order Line Entry Screen")]
        public void WhenISelectAsWeightFromPurchaseOrderLineEntryScreen(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on ""(.*)"" button from Purchase Order Line Entry Screen")]
        public void WhenIClickOnButtonFromPurchaseOrderLineEntryScreen(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter ""(.*)"" as Expected amount from Purchase Order Line Entry Screen")]
        public void WhenIEnterAsExpectedAmountFromPurchaseOrderLineEntryScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter ""(.*)"" as Buy Price from Purchase Order Line Entry Screen")]
        public void WhenIEnterAsBuyPriceFromPurchaseOrderLineEntryScreen(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select ""(.*)"" as Department from Purchase Order Line Entry Screen")]
        public void WhenISelectAsDepartmentFromPurchaseOrderLineEntryScreen(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
