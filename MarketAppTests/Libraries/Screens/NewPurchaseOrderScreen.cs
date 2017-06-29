using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace MarketAppTests.Libraries.Screens
{
    public class NewPurchaseOrderScreen
    {
        public WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement ExpectedRdButton => windowsDriver.FindElementByName("Expected");
        private WindowsElement ReceivedRdButton => windowsDriver.FindElementByName("Received");

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
    }
}
