using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace MarketAppTests.Libraries.Screens
{
    class TicketSearchScreen
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement SearchButton => windowsDriver.FindElementByName("Search");

        public TicketSearchScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void ClickOnButton(string buttonName)
        {
            if (buttonName == "Search") { SearchButton.Click(); }
            else throw new Exception($"{buttonName} Button not found. Please check Button Name and try again.");
        }
    }
}
