Feature: NewTicketCreation

@CreateNewTicket
Scenario: Create New ticket
Given I am a Registered User
When I click on "Create New Ticket" button from SideBar
And I select a Customer
And I select a Delivery Type
And I add a Email Address
And I click on "New Line" button from New Ticket Creation Screen
And I allocate "3" boxes of apples
And I enter "15" as new sell price
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
And I enter "CABSA" into the Product field and click on the Product Name
#Then I should see "CABBAGE SAVOY . . 2KG VAC PAC SHREDDED" as Product Name
#When I enter "3" as Quantity
#And I enter "10" as New Sell Price
#And I click on "Add More" button from Product Selection Screen
#And I enter "xxxxx" into the Product field and click on the Product Name
#Then I should see "xxxxx" as Product Name
#When I enter "3" as Quantity
#And I enter "10" as New Sell Price
#And I click on "Add More" button from Product Selection Screen
#And I enter "ORA" into the Product field and click on the Product Name
#And I select "Each" from Product Selection Screen
#Then I should see "xxxxx" as Product Name
#When I enter "30" as Quantity
#And I enter "0.50" as New Sell Price
#And I click on "Add More" button from Product Selection Screen
#And I enter "CAPR" into the Product field and click on the Product Name
#Then I should see "xxxxx" as Product Name
#When I enter "20" as Quantity
#And I enter "0.65" as New Sell Price
#And I click on "Continue" button from Product Selection Screen
#And I click on "Commit" button from New Ticket Creation Screen
#Then I should see "CABSA" as Code on line "1" on New Ticket Creation Screen
#And  I should see "3" as Quantity on line "1" on New Ticket Creation Screen
#And I should see "Box" as Unit Of Measurement on line "1" on Ticket Creation Screen
#And I should see "10" as Price on line "1" on Ticket Creation Screen