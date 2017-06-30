using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace MarketAppTests.Libraries.Screens
{
    class NewPurchaseOrderScreen
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement CommitButton => windowsDriver.FindElementByName("Commit");
        private WindowsElement NewLineButton => windowsDriver.FindElementByName("New Line");
        private WindowsElement ExpectedRdButton => windowsDriver.FindElementByName("Expected");
        private WindowsElement ReceivedRdButton => windowsDriver.FindElementByName("Received");
        private WindowsElement SupplierByCode(string code) => windowsDriver.FindElementByName(code);
        private WindowsElement SupplierText => windowsDriver.FindElementByAccessibilityId("txtAccountSearch");

        public NewPurchaseOrderScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void SelectStatus(string status)
        {
            if (status == "Expected") { ExpectedRdButton.Click(); }
            else if (status == "Received") { ReceivedRdButton.Click(); }
            else throw new Exception($"{status} status not found. Please check the Status and try again.");
        }

        public void EnterSupplierText(string text)
        {
            SupplierText.SendKeys(text);
        }

        public void SelectSupplierByCode(string code)
        {
            do { System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1)); } while (SupplierByCode(code).Displayed is false);
            SupplierByCode(code).Click();
        }

        public void ClickOnButton(string buttonName)
        {
            if (buttonName == "New Line") { NewLineButton.Click(); }
            else if (buttonName == "Commit") { CommitButton.Click(); }
            else throw new Exception($"{buttonName} Button not found. Please check Button Name and try again.");
        }
    }
}
