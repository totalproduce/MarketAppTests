using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace MarketAppTests.Libraries.Screens
{
    class PurchaseOrderLineEntryScreen
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement ContinueButton => windowsDriver.FindElementByName("Continue");
        private WindowsElement ProductByCode(string code) => windowsDriver.FindElementByName(code);
        private WindowsElement ProductText => windowsDriver.FindElementByAccessibilityId("txtProductCodeSearch");
        private WindowsElement WeightByText(string weight) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstField5\']/ListItem[@Name=\'{weight}\']");

        public PurchaseOrderLineEntryScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void EnterProductText(string text)
        {
            ProductText.SendKeys(text);
        }

        public void SelectProductByCode(string code)
        {
            do { System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1)); } while (ProductByCode(code).Displayed is false);
            ProductByCode(code).Click();
        }

        public void SelectWeightByText(string weight)
        {
            WeightByText(weight).Click();
        }

        public void ClickOnButton(string buttonName)
        {
            if (buttonName == "Continue") { ContinueButton.Click(); }
            else throw new Exception($"{buttonName} Button not found. Please check Button Name and try again.");
        }
    }
}
