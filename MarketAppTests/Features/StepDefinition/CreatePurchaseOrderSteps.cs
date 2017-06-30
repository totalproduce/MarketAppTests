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
        private PurchaseOrderLineEntryScreen purchaseOrderLineEntryScreen;

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
        public void WhenISelectTheSupplierWithIdCreatePurchaseOrderScreen(string text)
        {
            newPurchaseOrderScreen.EnterSupplierText(text);
            newPurchaseOrderScreen.SelectSupplierByCode(text);
        }

        [When(@"I click on ""(.*)"" button from Create Purchase Order Screen")]
        public void WhenIClickOnButtonFromCreatePurchaseOrderScreen(string buttonName)
        {
            newPurchaseOrderScreen.ClickOnButton(buttonName);
            if (buttonName == "New Line") { purchaseOrderLineEntryScreen = new PurchaseOrderLineEntryScreen(windowsDriver); }
        }

        [When(@"I search for Product with code ""(.*)"" from Purchase Order Line Entry Screen")]
        public void WhenISearchForProductWithCodeFromPurchaseOrderLineEntryScreen(string text)
        {
            purchaseOrderLineEntryScreen.EnterProductText(text);
            purchaseOrderLineEntryScreen.SelectProductByCode(text);
        }

        [When(@"I select ""(.*)"" as Weight from Purchase Order Line Entry Screen")]
        public void WhenISelectAsWeightFromPurchaseOrderLineEntryScreen(string weight)
        {
            purchaseOrderLineEntryScreen.SelectWeightByText(weight);
        }

        [When(@"I click on ""(.*)"" button from Purchase Order Line Entry Screen")]
        public void WhenIClickOnButtonFromPurchaseOrderLineEntryScreen(string buttonName)
        {
            purchaseOrderLineEntryScreen.ClickOnButton(buttonName);
        }

        [When(@"I enter ""(.*)"" as Expected amount from Purchase Order Line Entry Screen")]
        public void WhenIEnterAsExpectedAmountFromPurchaseOrderLineEntryScreen(string amount)
        {
            purchaseOrderLineEntryScreen.EnterExpectedText(amount);
        }

        [When(@"I enter ""(.*)"" as Buy Price from Purchase Order Line Entry Screen")]
        public void WhenIEnterAsBuyPriceFromPurchaseOrderLineEntryScreen(string buyPrice)
        {
            purchaseOrderLineEntryScreen.EnterBuyPriceText(buyPrice);
        }

        [When(@"I select ""(.*)"" as Department from Purchase Order Line Entry Screen")]
        public void WhenISelectAsDepartmentFromPurchaseOrderLineEntryScreen(string deptName)
        {
            purchaseOrderLineEntryScreen.SelectDepartmentByName(deptName);
        }

        [Then(@"I should see ""(.*)"" as Short Code on line ""(.*)"" on Create Purchase Order Screen")]
        public void ThenIShouldSeeAsShortCodeOnLineOnCreatePurchaseOrderScreen(string shortCode, int line)
        {
            Assert.AreEqual(shortCode, newPurchaseOrderScreen.GetShortCodeLineText(line));
        }

        [Then(@"I should see ""(.*)"" as Short Description on line ""(.*)"" on Create Purchase Order Screen")]
        public void ThenIShouldSeeAsShortDescriptionOnLineOnCreatePurchaseOrderScreen(string shortDescription, int line)
        {
            Assert.AreEqual(shortDescription, newPurchaseOrderScreen.GetShortDescriptionLineText(line));
        }

        [Then(@"I should see ""(.*)"" as Product Code on line ""(.*)"" on Create Purchase Order Screen")]
        public void ThenIShouldSeeAsProductCodeOnLineOnCreatePurchaseOrderScreen(string productCode, int line)
        {
            Assert.AreEqual(productCode, newPurchaseOrderScreen.GetProductCodeLineText(line));
        }

        [Then(@"I should see ""(.*)"" as Expected Quantity on line ""(.*)"" on Create Purchase Order Screen")]
        public void ThenIShouldSeeAsExpectedQuantityOnLineOnCreatePurchaseOrderScreen(string expectedQuantity, int line)
        {
            Assert.AreEqual(expectedQuantity, newPurchaseOrderScreen.GetExpectedQuantityLineText(line));
        }

        [Then(@"I should see ""(.*)"" as Buy Price on line ""(.*)"" on Create Purchase Order Screen")]
        public void ThenIShouldSeeAsBuyPriceOnLineOnCreatePurchaseOrderScreen(string buyPrice, int line)
        {
            Assert.AreEqual(buyPrice, newPurchaseOrderScreen.GetBuyPriceLineText(line));
        }

        [Then(@"I should see ""(.*)"" as Type on line ""(.*)"" on Create Purchase Order Screen")]
        public void ThenIShouldSeeAsTypeOnLineOnCreatePurchaseOrderScreen(string type, int line)
        {
            Assert.AreEqual(type, newPurchaseOrderScreen.GetTypeLineText(line));
        }

        [Then(@"I should see ""(.*)"" as Department on line ""(.*)"" on Create Purchase Order Screen")]
        public void ThenIShouldSeeAsDepartmentOnLineOnCreatePurchaseOrderScreen(string department, int line)
        {
            Assert.AreEqual(department, newPurchaseOrderScreen.GetDepartmentLine(line));
        }
    }
}
