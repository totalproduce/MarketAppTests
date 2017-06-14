using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace MarketAppTests.Libraries.Screens
{
    class NewTicketCreationScreen
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private string DefaultEmail = "hcampos@totalproduce.com";

        private WindowsElement DefaultCustomerCode => windowsDriver.FindElementByName("18686");
        private WindowsElement NewLineButton => windowsDriver.FindElementByName("New Line");
        private WindowsElement CommitButton => windowsDriver.FindElementByName("Commit");
        private WindowsElement TypeComboBox => windowsDriver.FindElementByAccessibilityId("cbDeliveryType");
        private WindowsElement DefaultType => windowsDriver.FindElementByName("BOX");
        private WindowsElement EmailCheckBox => windowsDriver.FindElementByAccessibilityId("chkCanEmail");
        private WindowsElement EmailText => windowsDriver.FindElementByAccessibilityId("txtEmailAddress");
        private WindowsElement CodeTicketLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][1]");
        private WindowsElement QtyTicketLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][3]");
        private WindowsElement UomTicketLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][4]");
        private WindowsElement PriceTicketLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][5]");


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
            TypeComboBox.Click();
            DefaultType.Click();
        }

        public void AddDefaultEmail()
        {
            EmailText.SendKeys(DefaultEmail);
            EmailCheckBox.Click();
        }

        public void ClickOnButton(string buttonName)
        {
            if (buttonName == "New Line") { NewLineButton.Click(); }
            else if (buttonName == "Commit") { CommitButton.Click(); }
            else throw new Exception("Element not found. Please check the name and try again.");
        }

        public string GetCodeTicketLine()
        {
            return CodeTicketLine(1).Text;
        }

        public string GetQtyTicketLine()
        {
            return QtyTicketLine(1).Text;
        }

        public string GetUomTicketLine()
        {
            return UomTicketLine(1).Text;
        }

        public string GetPriceTicketLine()
        {
            return PriceTicketLine(1).Text;
        }
    }
}
