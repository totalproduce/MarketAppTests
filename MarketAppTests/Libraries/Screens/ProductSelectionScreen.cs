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
        private WindowsElement AddMoreButton => windowsDriver.FindElementByName("Add More");
        private WindowsElement ContinueButton => windowsDriver.FindElementByName("Continue");
        private WindowsElement DefaultProductId => windowsDriver.FindElementByName("APG");
        private WindowsElement EachRButton => windowsDriver.FindElementByName("Each");
        private WindowsElement LineStockLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstStocklines\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][1]");
        private WindowsElement ProductText => windowsDriver.FindElementByXPath("//*[@AutomationId=\'txtProductCodeSearch\']/*[@AutomationId=\'TextBox\'][1]");
        private WindowsElement ProductByCode(string productCode) => windowsDriver.FindElementByXPath($"//*[@Name=\'TotalProduce.MarketApp.Models.HH_ProductCodeSearchItem\']/*[@Name=\'{productCode}\']");
        //private WindowsElement ProductByCode(string productCode) => windowsDriver.FindElementByName(productCode);
        private WindowsElement SellPriceStockLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstStocklines\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBox\'][2]");
        private WindowsElement StockStockLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstStocklines\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][7]");

        private int CurrentStockLine;

        public ProductSelectionScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void ClickOnButton(string buttonName)
        {
            if (buttonName == "Add More") { AddMoreButton.Click(); }
            else if (buttonName == "Continue") { ContinueButton.Click(); }
            else throw new Exception($"{buttonName} button not found. Please check the button name and try again.");
        }

        public void SelectDefaultProductId()
        {
            DefaultProductId.Click();
        }

        public void SelectProductCode(string productCode)
        {
            ProductByCode(productCode).Click();
        }

        public void SelectUnit(string unit)
        {
            if (unit == "Each") { EachRButton.Click(); }
            else throw new Exception($"{unit} not found. Please check the unit name and try again.");
        }

        public void EnterProductCodeText (string productCode)
        {
            ProductText.SendKeys(productCode);
        }

        public void EnterAllocQty(int quantity)
        {
            do { System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1)); } while (StockStockLine(1).Displayed is false);
            CurrentStockLine = LineWithStockGreaterThan(quantity);
            AllocQtyStockLine(CurrentStockLine).SendKeys(quantity.ToString());
        }

        public void EnterSellPrice(double sellPrice)
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
