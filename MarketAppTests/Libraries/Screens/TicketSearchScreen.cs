using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace MarketAppTests.Libraries.Screens
{
    class TicketSearchScreen
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement TicketNumberText => windowsDriver.FindElementByAccessibilityId("txtTicketNumber");
        private WindowsElement SearchButton => windowsDriver.FindElementByXPath("//Text[@Name=\'Search\']");
        private WindowsElement TicketNumberByLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'Hyperlink\']");

        public TicketSearchScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void ClickOnButton(string buttonName)
        {
            if (buttonName == "Search") { SearchButton.Click(); }
            else throw new Exception($"{buttonName} Button not found. Please check Button Name and try again.");
        }

        public void EnterTicketNumberText(string text)
        {
            TicketNumberText.SendKeys(text);
        }

        public void SelectTicketNumberFromSearchResults()
        {
            do { System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1)); } while (TicketNumberByLine(1).Enabled is false);
            TicketNumberByLine(1).Click();
        }
    }
}
