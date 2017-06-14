using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace MarketAppTests.Libraries.Screens
{
    class ProductSelectionScreen
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement AllocQtyStockLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstStocklines\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBox\'][1]");
        private WindowsElement BuyPriceStockLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstStocklines\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][8]");
        private WindowsElement ContinueButton => windowsDriver.FindElementByName("Continue");
        private WindowsElement DefaultProductId => windowsDriver.FindElementByName("APG");
        private WindowsElement LineStockLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstStocklines\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][1]");
        private WindowsElement SellPriceStockLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstStocklines\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBox\'][2]");
        private WindowsElement StockStockLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstStocklines\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][7]");

        private int CurrentStockLine;

        public ProductSelectionScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void ClickOnButton(string buttonName)
        {
            if (buttonName == "Continue") { ContinueButton.Click(); }
            else throw new Exception("Element not found. Please check the name and try again.");
        }

        public void SelectDefaultProductId()
        {
            DefaultProductId.Click();
        }

        public void EnterAllocQty(int quantity)
        {
            do { System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1)); } while (StockStockLine(1).Displayed is false);
            CurrentStockLine = LineWithStockGreaterThan(quantity);
            AllocQtyStockLine(CurrentStockLine).SendKeys(quantity.ToString());
        }

        public void EnterSellPrice(int sellPrice)
        {
            SellPriceStockLine(CurrentStockLine).SendKeys(sellPrice.ToString());
        }

        private int LineWithStockGreaterThan(int quantity)
        {
            int line = 0;
            do { line++; } while (Int32.Parse(StockStockLine(line).Text) < quantity);
            return line;
        }

        private int TotalStockLines()
        {
            int totalStockLines = 0;
            do { totalStockLines++; } while (LineStockLine(totalStockLines).Text != "-1");
            return totalStockLines;
        }
    }
}
