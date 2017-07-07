Feature: CreditNotes

@CreditNotes-PriceOnlyCreditNote
Scenario: Credit Notes - Price Only Credit Note
Given I am a Registered User
When I click on "Ticket Search" button from SideBar
And I enter "960829" as Ticket Number on Ticket Search Screen
And I click on "Search" button on Ticket Search Screen
And I select the ticket from the Search Results on Ticket Search Screen
And I click on "Credit" button from New Ticket Creation Screen