Feature: CreatePurchaseOrder

@NewPO-MultipleLines-Expected
Scenario: New PO - Multiple Line - Expected
Given I am a Registered User
When I click on "Create Purchase Order" button from SideBar
And I select "Expected" as Status from Create Purchase Order Screen
And I select the Supplier with Id "18046" Create Purchase Order Screen
And I click on "New Line" button from Create Purchase Order Screen
And I search for Product with code "CABSAV" from Purchase Order Line Entry Screen
And I select "2KG" as Weight from Purchase Order Line Entry Screen
#And I click on "Continue" button from Purchase Order Line Entry Screen
#And I enter "160" as Expected amount from Purchase Order Line Entry Screen
#And I enter "8.00" as Buy Price from Purchase Order Line Entry Screen
#And I select "VEGETABLES" as Department from Purchase Order Line Entry Screen
#And I click on "Continue" button from Purchase Order Line Entry Screen