Feature: NewTicketCreation

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
Then I should see "CABSAV" as Code on line "1" on New Ticket Creation Screen
And  I should see "3" as Quantity on line "1" on New Ticket Creation Screen
And I should see "Box" as Unit Of Measurement on line "1" on Ticket Creation Screen
And I should see "10.00" as Price on line "1" on Ticket Creation Screen
And I should see "AVO" as Code on line "2" on New Ticket Creation Screen
And  I should see "3" as Quantity on line "2" on New Ticket Creation Screen
And I should see "Box" as Unit Of Measurement on line "2" on Ticket Creation Screen
And I should see "10.00" as Price on line "2" on Ticket Creation Screen
And I should see "ORA" as Code on line "3" on New Ticket Creation Screen
And  I should see "30" as Quantity on line "3" on New Ticket Creation Screen
And I should see "Each" as Unit Of Measurement on line "3" on Ticket Creation Screen
And I should see "0.50" as Price on line "3" on Ticket Creation Screen
And I should see "CAPR" as Code on line "4" on New Ticket Creation Screen
And  I should see "20" as Quantity on line "4" on New Ticket Creation Screen
And I should see "Each" as Unit Of Measurement on line "4" on Ticket Creation Screen
And I should see "0.65" as Price on line "4" on Ticket Creation Screen

@NewTicket-MultipleLine-CreditCustomerSale
Scenario: New Ticket - Multiple Line - Credit Customer Sale
Given I am a Registered User
When I click on "Create New Ticket" button from SideBar
And I select the Customer with Id "15358"
And I select "Box" as Type
And I click on "New Line" button from New Ticket Creation Screen
And I search for Product with code "AVO" and select the Product from the list
And I enter "3" as Quantity
And I enter "10" as new Sell Price
And I click on "Add More" button from Product Selection Screen
And I search for Product with code "CUE" and select the Product from the list
And I select "Each" from Product Selection Screen
And I enter "100" as Quantity
And I enter "0.30" as new Sell Price
And I click on "Add More" button from Product Selection Screen
And I search for Product with code "CAPM" and select the Product from the list
And I enter "20" as Quantity
And I enter "0.55" as new Sell Price
And I click on "Continue" button from Product Selection Screen
And I click on "Commit" button from New Ticket Creation Screen
Then I should see "AVO" as Code on line "1" on New Ticket Creation Screen
And  I should see "3" as Quantity on line "1" on New Ticket Creation Screen
And I should see "Box" as Unit Of Measurement on line "1" on Ticket Creation Screen
And I should see "10.00" as Price on line "1" on Ticket Creation Screen
And I should see "CUE" as Code on line "2" on New Ticket Creation Screen
And  I should see "100" as Quantity on line "2" on New Ticket Creation Screen
And I should see "Each" as Unit Of Measurement on line "2" on Ticket Creation Screen
And I should see "0.30" as Price on line "2" on Ticket Creation Screen
And I should see "CAPM" as Code on line "3" on New Ticket Creation Screen
And  I should see "20" as Quantity on line "3" on New Ticket Creation Screen
And I should see "Each" as Unit Of Measurement on line "3" on Ticket Creation Screen
And I should see "0.55" as Price on line "3" on Ticket Creation Screen