using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace MarketAppTests.Libraries.Screens
{
    class NewTicketCreationScreen
    {
        private readonly WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement DefaultCustomerCode => windowsDriver.FindElementByName("18686");
        private WindowsElement NewLineBtn => windowsDriver.FindElementByName("New Line");
        private WindowsElement TypeCb => windowsDriver.FindElementByAccessibilityId("cbDeliveryType");
        private WindowsElement DefaultType => windowsDriver.FindElementByName("BOX");

        public NewTicketCreationScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void SelectDefaultCustomerById()
        {
            DefaultCustomerCode.Click();
        }

        public void SelectDefaultDeliveryType()
        {
            TypeCb.Click();
            DefaultType.Click();
        }

        public void ClickOnButton(string buttonName)
        {
            if (buttonName == "New Line") { NewLineBtn.Click(); }
            else throw new Exception("Element not found. Please check the name and try again.");
        }
    }
}
