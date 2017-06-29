using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace MarketAppTests.Libraries.Screens
{
    class PurchaseOrderLineEntryScreen
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement ProductText => windowsDriver.FindElementByAccessibilityId("txtProductCodeSearch");
        private WindowsElement ProductByCode(string code) => windowsDriver.FindElementByName(code);

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
    }
}
