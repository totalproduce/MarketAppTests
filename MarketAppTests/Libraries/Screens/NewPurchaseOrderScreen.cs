using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace MarketAppTests.Libraries.Screens
{
    class NewPurchaseOrderScreen
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement CommitButton => windowsDriver.FindElementByName("Commit");
        private WindowsElement NewLineButton => windowsDriver.FindElementByName("New Line");
        private WindowsElement ExpectedRdButton => windowsDriver.FindElementByName("Expected");
        private WindowsElement ReceivedRdButton => windowsDriver.FindElementByName("Received");
        private WindowsElement MarkReceivedButton => windowsDriver.FindElementByName("Mark Received");
        private WindowsElement YesButton => windowsDriver.FindElementByName("Yes");
        private WindowsElement DeleteButton => windowsDriver.FindElementByAccessibilityId("DeleteButton");
        private WindowsElement SupplierByCode(string code) => windowsDriver.FindElementByName(code);
        private WindowsElement SupplierText => windowsDriver.FindElementByAccessibilityId("txtAccountSearch");
        private WindowsElement ShortCodeByLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'Hyperlink\'][1]");
        private WindowsElement ShortDescriptionByLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][1]");
        private WindowsElement ProductCodeByLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][2]");
        private WindowsElement ExpectedQuantityByLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][4]");
        private WindowsElement ReceivedQuantityByLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][5]");
        private WindowsElement BuyPriceByLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][9]");
        private WindowsElement TypeByLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][13]");
        private WindowsElement DepartmentByLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][14]");

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

        public void EnterSupplierText(string text)
        {
            SupplierText.SendKeys(text);
        }

        public void ClearSupplierText()
        {
            SupplierText.Click();
            DeleteButton.Click();
        }

        public void SelectSupplierByCode(string code)
        {
            do { System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1)); } while (SupplierByCode(code).Displayed is false);
            SupplierByCode(code).Click();
        }

        public void ClickOnButton(string buttonName)
        {
            if (buttonName == "New Line") { NewLineButton.Click(); }
            else if (buttonName == "Commit") { CommitButton.Click(); }
            else if (buttonName == "Mark Received") { MarkReceivedButton.Click(); }
            else if (buttonName == "Yes") { YesButton.Click(); }
            else throw new Exception($"{buttonName} Button not found. Please check Button Name and try again.");
        }

        public void ClickOnShortCodeLine(int line )
        {
            ShortCodeByLine(line).Click();
        }

        public string GetShortCodeLineText(int line)
        {
            do { System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1)); } while (ShortCodeByLine(line).Displayed is false);
            return ShortCodeByLine(line).Text;
        }

        public string GetShortDescriptionLineText(int line)
        {
            return ShortDescriptionByLine(line).Text;
        }

        public string GetProductCodeLineText(int line)
        {
            return ProductCodeByLine(line).Text;
        }

        public string GetExpectedQuantityLineText(int line)
        {
            return ExpectedQuantityByLine(line).Text;
        }

        public string GetReceivedQuantityLineText(int line)
        {
            return ReceivedQuantityByLine(line).Text;
        }

        public string GetBuyPriceLineText(int line)
        {
            return BuyPriceByLine(line).Text;
        }

        public string GetTypeLineText(int line)
        {
            return TypeByLine(line).Text;
        }

        public string GetDepartmentLine(int line)
        {
            return DepartmentByLine(line).Text;
        }
    }
}
