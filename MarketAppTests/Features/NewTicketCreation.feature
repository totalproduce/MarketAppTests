﻿Feature: NewTicketCreation

@CreateNewTicket
Scenario: Create New ticket
Given I am a Registered User
When I click on "Create New Ticket" button from SideBar
And I select a Customer
And I select a Delivery Type
And I add a Email Address
And I click on "New Line" button from New Ticket Creation Screen
And I allocate "3" boxes of apples
And I enter "15" as new Sell Price
And I click on "Continue" button from Product Selection Screen
And I click on "Commit" button from New Ticket Creation Screen
Then I should see "APG" as Code on New Ticket Creation Screen
And  I should see "3" as Quantity on New Ticket Creation Screen
And I should see "Box" as Unit Of Measurement on Ticket Creation Screen
And I should see "15.00" as Price on Ticket Creation Screen

@CreateNewTicket-MultipleLines-CashSale
Scenario: Create New Ticket - Multiple Lines - Cash Sale
Given I am a Registered User
When I click on "Create New Ticket" button from SideBar
And I select the Customer with Id "15999"
And I add "Test Cash" as a Comment
And I select "Box" as Type
And I click on "New Line" button from New Ticket Creation Screen
And I search for Product with code "CABSAV" and select the Product from the list
And I enter "3" as Quantity
And I enter "10" as new Sell Price
And I click on "Add More" button from Product Selection Screen
And I search for Product with code "AVO" and select the Product from the list
And I enter "3" as Quantity
And I enter "10" as new Sell Price
And I click on "Add More" button from Product Selection Screen
And I search for Product with code "ORA" and select the Product from the list
And I select "Each" from Product Selection Screen
And I enter "30" as Quantity
And I enter "0.50" as new Sell Price
And I click on "Add More" button from Product Selection Screen
And I search for Product with code "CAPR" and select the Product from the list
And I enter "20" as Quantity
And I enter "0.65" as new Sell Price
And I click on "Continue" button from Product Selection Screen
And I click on "Commit" button from New Ticket Creation Screen
#Then I should see "CABSA" as Code on line "1" on New Ticket Creation Screen
#And  I should see "3" as Quantity on line "1" on New Ticket Creation Screen
#And I should see "Box" as Unit Of Measurement on line "1" on Ticket Creation Screen
#And I should see "10" as Price on line "1" on Ticket Creation Screen