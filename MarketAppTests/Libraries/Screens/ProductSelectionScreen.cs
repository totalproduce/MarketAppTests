using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace MarketAppTests.Libraries.Screens
{
    class ProductSelectionScreen
    {
        private readonly WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement DefaultProductId => windowsDriver.FindElementByName("APG");
        private WindowsElement StockLinesList => windowsDriver.FindElementByName("TotalProduce.MarketApp.Models.HH_StockLine");

        public ProductSelectionScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void SelectDefaultProductId()
        {
            DefaultProductId.Click();
        }
    }
}
