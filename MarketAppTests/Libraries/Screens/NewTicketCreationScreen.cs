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
        private WindowsElement CommentText => windowsDriver.FindElementByAccessibilityId("txtComment");
        private WindowsElement CommitButton => windowsDriver.FindElementByName("Commit");
        private WindowsElement CreditButton => windowsDriver.FindElementByName("Credit");
        private WindowsElement CustomerText => windowsDriver.FindElementByAccessibilityId("TextBox");
        private WindowsElement CustomerCode(string code) => windowsDriver.FindElementByName(code);
        private WindowsElement TypeBox => windowsDriver.FindElementByName("BOX");
        private WindowsElement TypeComboBox => windowsDriver.FindElementByAccessibilityId("cbDeliveryType");
        private WindowsElement EmailCheckBox => windowsDriver.FindElementByAccessibilityId("chkCanEmail");
        private WindowsElement EmailText => windowsDriver.FindElementByAccessibilityId("txtEmailAddress");
        private WindowsElement CodeTicketLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][1]");
        private WindowsElement QtyTicketLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][3]");
        private WindowsElement UomTicketLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][4]");
        private WindowsElement PriceTicketLine(int line) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstSearchResults\']/ListItem[@ClassName=\'ListViewItem\'][{line}]/*[@ClassName=\'TextBlock\'][5]");
        private WindowsElement CreditQtyByCreditLine(int line) => windowsDriver.FindElementByXPath("");
        private WindowsElement CreditPriceByCreditLine(int line) => windowsDriver.FindElementByXPath("");
        private WindowsElement RTSByCreditLine(int line) => windowsDriver.FindElementByXPath("");
        private WindowsElement ReasonByCreditLine(int line) => windowsDriver.FindElementByXPath("");

        public NewTicketCreationScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void EnterCustomerText(string text)
        {
            CustomerText.SendKeys(text);
        }

        public void SelectCustomerById(string code)
        {
            CustomerCode(code).Click();
        }

        public void EnterCommentText(string text)
        {
            CommentText.SendKeys(text);
        }

        public void SelectType(string type)
        {
            TypeComboBox.Click();
            if (type == "Box") { TypeBox.Click(); }
            else throw new Exception($"{type} Type not found. Please check the Type and try again.");
        }

        public void SelectDefaultCustomerById()
        {
            DefaultCustomerCode.Click();
        }

        public void SelectDefaultDeliveryType()
        {
            TypeComboBox.Click();
            TypeBox.Click();
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
            else if (buttonName == "Credit") { CreditButton.Click(); }
            else throw new Exception($"{buttonName} Button not found. Please check Button Name and try again.");
        }

        public string GetCodeTicketLineText(int linenumber)
        {
            return CodeTicketLine(linenumber).Text;
        }

        public string GetQtyTicketLineText(int linenumber)
        {
            return QtyTicketLine(linenumber).Text;
        }

        public string GetUomTicketLineText(int linenumber)
        {
            return UomTicketLine(linenumber).Text;
        }

        public string GetPriceTicketLineText(int linenumber)
        {
            return PriceTicketLine(linenumber).Text;
        }
    }
}
