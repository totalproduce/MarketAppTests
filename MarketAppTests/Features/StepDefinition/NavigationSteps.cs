using MarketAppTests.Libraries.Screens;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;
using TechTalk.SpecFlow;


namespace MarketAppTests.Features.StepDefinition
{
    [Binding]
    public class NavigationSteps
    {
        private readonly WindowsDriver<WindowsElement> windowsDriver;
        private SideBar sideBar;

        public NavigationSteps(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        [When(@"I click on ""(.*)"" button from SideBar")]
        public void WhenIClickOnButton(string buttonName)
        {
            sideBar = new SideBar(this.windowsDriver);
            sideBar.ClickOnButton(buttonName);
        }
    }
}
