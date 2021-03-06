﻿using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace MarketAppTests.Libraries.Screens
{
    class PurchaseOrderLineEntryScreen
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement BuyPriceText => windowsDriver.FindElementByAccessibilityId("txtPurchasePrice");
        private WindowsElement ContinueButton => windowsDriver.FindElementByName("Continue");
        private WindowsElement Department => windowsDriver.FindElementByAccessibilityId("cbDepartments");
        private WindowsElement DepartmentByName(string name) => windowsDriver.FindElementByXPath($"//ComboBox[@AutomationId=\'cbDepartments\']/ListItem[@Name=\'{name}\']");
        private WindowsElement ExpectedText => windowsDriver.FindElementByAccessibilityId("txtExpected");
        private WindowsElement ReceivedText => windowsDriver.FindElementByAccessibilityId("txtReceived");
        private WindowsElement ProductByCode(string code) => windowsDriver.FindElementByName(code);
        private WindowsElement ProductText => windowsDriver.FindElementByAccessibilityId("txtProductCodeSearch");
        private WindowsElement WeightByText(string weight) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstField5\']/ListItem[@Name=\'{weight}\']");
        private WindowsElement CountryByText(string country) => windowsDriver.FindElementByXPath($"//List[@AutomationId=\'lstField3\']/ListItem[@Name=\'{country}\']");

        public PurchaseOrderLineEntryScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void EnterProductText(string text)
        {
            ProductText.SendKeys(text);
        }

        public void SelectProductByCode(string code)
        {
            do { System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1)); } while (ProductByCode(code).Displayed is false);
            ProductByCode(code).Click();
        }

        public void SelectWeightByText(string weight)
        {
            WeightByText(weight).Click();
        }

        public void SelectCountryByText(string country)
        {
            CountryByText(country).Click();
        }

        public void ClickOnButton(string buttonName)
        {
            if (buttonName == "Continue")
            {
                do { System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1)); } while (ContinueButton.Displayed is false);
                ContinueButton.Click();
            }
            else throw new Exception($"{buttonName} Button not found. Please check Button Name and try again.");
        }

        public void EnterExpectedText(string text)
        {
            ExpectedText.SendKeys(text);
        }

        public void EnterReceivedText(string text)
        {
            ReceivedText.SendKeys(text);
        }

        public void EnterBuyPriceText(string text)
        {
            BuyPriceText.SendKeys(text);
        }

        public void SelectDepartmentByName(string name)
        {
            Department.Click();
            DepartmentByName(name).Click();
        }
    }
}
