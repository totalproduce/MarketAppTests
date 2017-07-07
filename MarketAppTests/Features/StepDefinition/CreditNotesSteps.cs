using MarketAppTests.Libraries.Screens;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace MarketAppTests.Features.StepDefinition
{
    [Binding]
    public sealed class CreditNotesSteps
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private TicketSearchScreen ticketSearchScreen;
        private NewTicketCreationScreen newTicketCreationScreen;

        public CreditNotesSteps(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
            ticketSearchScreen = new TicketSearchScreen(this.windowsDriver);
        }

        [When(@"I enter ""(.*)"" as Ticket Number on Ticket Search Screen")]
        public void WhenIEnterAsTicketNumberOnTicketSearchScreen(string text)
        {
            ticketSearchScreen.EnterTicketNumberText(text);
        }

        [When(@"I click on ""(.*)"" button on Ticket Search Screen")]
        public void WhenIClickOnButtonFromTicketSearchScreen(string buttonName)
        {
            ticketSearchScreen.ClickOnButton(buttonName);
        }

        [When(@"I select the ticket from the Search Results on Ticket Search Screen")]
        public void WhenISelectTheTicketFromTheSearchResultsOnTicketSearchScreen()
        {
            ticketSearchScreen.SelectTicketNumberFromSearchResults();
            newTicketCreationScreen = new NewTicketCreationScreen(this.windowsDriver);
        }
    }
}
