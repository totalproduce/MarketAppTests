Feature: NewTicketCreation

@newticketcreation
Scenario: Create a new ticket
Given I am a Registered User
When I click on "Create New Ticket" button from SideBar
And I select a Customer
And I select a Delivery Type
And I add a Email Address
And I click on "New Line" button from New Ticket Creation Screen
And I select a random Product