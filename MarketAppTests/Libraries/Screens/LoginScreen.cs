using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace MarketAppTests.Libraries.Screens
{
    public class LoginScreen
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private string DefaultPin = "1234";
        private string DefaultRollbackWeeks = "10";

        private WindowsElement SalesOffice => windowsDriver.FindElementByAccessibilityId("cbSalesOffice");
        private WindowsElement DefaultSalesOffice => windowsDriver.FindElementByName("02 TP Manchester");
        private WindowsElement Username => windowsDriver.FindElementByAccessibilityId("cbLogons");
        private WindowsElement DefaultUsername => windowsDriver.FindElementByName("HH_MANCH_BUY");
        private WindowsElement Salesman => windowsDriver.FindElementByAccessibilityId("cbSalesmen");
        private WindowsElement DefaultSalesman => windowsDriver.FindElementByName("HH Manch Buyer");
        private WindowsElement Pin => windowsDriver.FindElementByAccessibilityId("txtPassword");
        private WindowsElement RollbackWeeks => windowsDriver.FindElementByAccessibilityId("txtRollbackWeeks");
        private WindowsElement Login => windowsDriver.FindElementByName("Login");

        public LoginScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void LoginWithDefaultUser()
        {
            SalesOffice.Click();
            DefaultSalesOffice.Click();
            Username.Click();
            DefaultUsername.Click();
            Salesman.Click();
            DefaultSalesman.Click();
            Pin.SendKeys(DefaultPin);
            RollbackWeeks.SendKeys(DefaultRollbackWeeks);
            Login.Click();
        }
    }
}
