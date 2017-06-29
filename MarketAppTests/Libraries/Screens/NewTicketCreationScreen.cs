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
        private WindowsElement CustomerText => windowsDriver.FindElementByAccessibilityId("TextBox");
        private WindowsElement CustomerCode(string code) => windowsDriver.FindElementByName(code);
        private WindowsElement TypeBox => windowsDriver.FindElementByName("BOX");
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

        public string GetCodeTicketLine(int linenumber)
        {
            return CodeTicketLine(linenumber).Text;
        }

        public string GetQtyTicketLine(int linenumber)
        {
            return QtyTicketLine(linenumber).Text;
        }

        public string GetUomTicketLine(int linenumber)
        {
            return UomTicketLine(linenumber).Text;
        }

        public string GetPriceTicketLine(int linenumber)
        {
            return PriceTicketLine(linenumber).Text;
        }
    }
}
