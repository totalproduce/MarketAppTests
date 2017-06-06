using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace MarketAppTests.Libraries.Screens
{
    class ProductSelectionScreen
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement DefaultProductId => windowsDriver.FindElementByName("APG");
        private WindowsElement StockLinesList => windowsDriver.FindElementByXPath("//List[@AutomationId=\'lstStocklines\']/ListItem[@ClassName=\'ListViewItem\'][1]/*[@ClassName=\'TextBox\'][1]");

        public ProductSelectionScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void SelectDefaultProductId()
        {
            DefaultProductId.Click();
            StockLinesList.SendKeys("1234");
        }
    }
}
