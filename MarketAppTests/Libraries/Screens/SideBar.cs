using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;


namespace MarketAppTests.Libraries.Screens
{
    class SideBar
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement CreateNewTicketButton => windowsDriver.FindElementByAccessibilityId("mnuTicket");

        public SideBar(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void ClickOnButton(string buttonName)
        {
            if (buttonName == "Create New Ticket") { CreateNewTicketButton.Click(); }
            else throw new Exception("Element not found. Please check the name and try again.");
        }
    }
}
