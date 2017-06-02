Feature: NewTicketCreation

@newticketcreation
Scenario: Create a new ticket
Given I am a registered user
When I click on "Create New Ticket" button from SideBar
And I select a customer
And I click on "New Line" button from NewTicketScreen