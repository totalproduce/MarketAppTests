using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;


namespace MarketAppTests.Libraries.Screens
{
    class SideBar
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement CreateTicketButton => windowsDriver.FindElementByAccessibilityId("mnuTicket");
        private WindowsElement TicketSearchButton => windowsDriver.FindElementByAccessibilityId("mnuTicketSearch");
        private WindowsElement CreatePurchaseOrderButton => windowsDriver.FindElementByAccessibilityId("mnuPurchaseOrder");
        private WindowsElement PurchaseOrderSearchButton => windowsDriver.FindElementByAccessibilityId("mnuPurchaseOrderSearch");
        private WindowsElement StockListButton => windowsDriver.FindElementByAccessibilityId("mnuStockList");
        private WindowsElement SalesReceiptsButton => windowsDriver.FindElementByAccessibilityId("mnuSalesReceipts");
        private WindowsElement ProcessingButton => windowsDriver.FindElementByAccessibilityId("mnuAwaitingUpload");
        private WindowsElement SettingsButton => windowsDriver.FindElementByAccessibilityId("mnuSettings");
        private WindowsElement OfficeDevicesButton => windowsDriver.FindElementByAccessibilityId("mnuOfficeDevices");
        private WindowsElement SignOutButton => windowsDriver.FindElementByAccessibilityId("mnuSignOff");

        public SideBar(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void ClickOnButton(string buttonName)
        {
            if (buttonName == "Create Ticket") { CreateTicketButton.Click(); }
            else if (buttonName == "Ticket Search") { TicketSearchButton.Click(); }
            else if (buttonName == "Create Purchase Order") { CreatePurchaseOrderButton.Click(); }
            else if (buttonName == "Purchase Order Search") { PurchaseOrderSearchButton.Click(); }
            else if (buttonName == "Stock List") { StockListButton.Click(); }
            else if (buttonName == "Sales Receipts") { SalesReceiptsButton.Click(); }
            else if (buttonName == "Processing") { ProcessingButton.Click(); }
            else if (buttonName == "Settings") { SettingsButton.Click(); }
            else if (buttonName == "Office Devices") { OfficeDevicesButton.Click(); }
            else if (buttonName == "Sign Out") { SignOutButton.Click(); }
            else throw new Exception("Element not found. Please check the name and try again.");
        }
    }
}
