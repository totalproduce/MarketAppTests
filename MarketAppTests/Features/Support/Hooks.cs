using BoDi;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Configuration;

namespace MarketAppTests.Features.Support
{
    [Binding]
    class Hooks
    {
        private WindowsDriver<WindowsElement> windowsDriver;
        private readonly ObjectContainer objectContainer;

        static DesiredCapabilities desiredCapabilities;
        private const string MarketApp = "TotalProduce.MarketApp_8dg1msznrwxhg!App";

        public Hooks(ObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.SetCapability("platformName", "Windows");
            desiredCapabilities.SetCapability("deviceName", "WindowsPC");
            desiredCapabilities.SetCapability("app", MarketApp);
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            windowsDriver = new WindowsDriver<WindowsElement>(desiredCapabilities);
            windowsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            objectContainer.RegisterInstanceAs(windowsDriver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if(windowsDriver != null)
            {
                windowsDriver.Dispose();
            }
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            // code that runs after the test run
        }
    }
}
