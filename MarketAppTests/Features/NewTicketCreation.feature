Feature: NewTicketCreation

@newticketcreation
Scenario: Create a new ticket
Given I am a registered user
When I click on "Create Ticket" button
And I select a customer
And I click on "New Line" button