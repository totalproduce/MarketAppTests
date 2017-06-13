Feature: NewTicketCreation

@newticketcreation
Scenario: Create a new ticket
Given I am a Registered User
When I click on "Create New Ticket" button from SideBar
And I select a Customer
And I select a Delivery Type
And I add a Email Address
And I click on "New Line" button from New Ticket Creation Screen
And I allocate "5" boxes of apples
And I enter "15" as new sell price
And I click on "Continue" button from Product Selection Screen
And I click on "Commit" button from New Ticket Creation Screen
Then I should see "APG" as Code on New Ticket Creation Screen
And  I should see "5" as Quantity on New Ticket Creation Screen
And I should see "Box" as Unit Of Measurement on Ticket Creation Screen
And I should see "15.00" as Price on Ticket Creation Screen