using MarketAppTests.Libraries.Screens;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TechTalk.SpecFlow;


namespace MarketAppTests.Features.StepDefinition
{
    [Binding]
    public class NavigationSteps
    {

        [When(@"I click on ""(.*)"" button")]
        public void WhenIClickOnButton(string buttonName)
        {
            // add screen methods here
        }
    }
}
