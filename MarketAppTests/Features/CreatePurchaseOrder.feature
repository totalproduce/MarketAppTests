Feature: CreatePurchaseOrder

@NewPO-MultipleLines-Expected
Scenario: New PO - Multiple Line - Expected
Given I am a Registered User
When I click on "Create Purchase Order" button from SideBar
And I select "Expected" as Status from Create Purchase Order Screen
And I select the Supplier with Id "18046" from Create Purchase Order Screen
And I click on "New Line" button from Create Purchase Order Screen
And I search for Product with code "CABSAV" from Purchase Order Line Entry Screen
And I select "2KG" as Weight from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I enter "160" as Expected amount from Purchase Order Line Entry Screen
And I enter "8.00" as Buy Price from Purchase Order Line Entry Screen
And I select "VEGETABLES" as Department from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
Then I should see "CABSAV" as Short Code on line "1" on Create Purchase Order Screen
And I should see "SAVOY CABBAGE" as Short Description on line "1" on Create Purchase Order Screen
And I should see "25546" as Product Code on line "1" on Create Purchase Order Screen
And I should see "160" as Expected Quantity on line "1" on Create Purchase Order Screen
And I should see "8.00" as Buy Price on line "1" on Create Purchase Order Screen
And I should see "Goods Invoice" as Type on line "1" on Create Purchase Order Screen
And I should see "VEGETABLES" as Department on line "1" on Create Purchase Order Screen
When I change the Supplier for the one with Id "10128" from Create Purchase Order Screen
And I click on line "1" Short Code from Create Purchase Order Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I enter "200" as Expected amount from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
Then I should see "200" as Expected Quantity on line "1" on Create Purchase Order Screen
When I click on "New Line" button from Create Purchase Order Screen
And I search for Product with code "AVO" from Purchase Order Line Entry Screen
And I select "12KG" as Weight from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I enter "250" as Expected amount from Purchase Order Line Entry Screen
And I enter "8.50" as Buy Price from Purchase Order Line Entry Screen
And I select "FRUIT" as Department from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I click on "New Line" button from Create Purchase Order Screen
And I search for Product with code "ORA" from Purchase Order Line Entry Screen
And I select "20KG" as Weight from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I enter "300" as Expected amount from Purchase Order Line Entry Screen
And I enter "3.00" as Buy Price from Purchase Order Line Entry Screen
And I select "CITRUS" as Department from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I click on "New Line" button from Create Purchase Order Screen
And I search for Product with code "CAPR" from Purchase Order Line Entry Screen
And I select "3KG" as Weight from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I enter "275" as Expected amount from Purchase Order Line Entry Screen
And I enter "3.55" as Buy Price from Purchase Order Line Entry Screen
And I select "VEGETABLES" as Department from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I click on "Mark Received" button from Create Purchase Order Screen
And I click on "Yes" button from Create Purchase Order Screen
Then I should see "AVO" as Short Code on line "2" on Create Purchase Order Screen
And I should see "AVOCADO" as Short Description on line "2" on Create Purchase Order Screen
And I should see "1233" as Product Code on line "2" on Create Purchase Order Screen
And I should see "250" as Expected Quantity on line "2" on Create Purchase Order Screen
And I should see "8.50" as Buy Price on line "2" on Create Purchase Order Screen
And I should see "Goods Invoice" as Type on line "2" on Create Purchase Order Screen
And I should see "FRUIT" as Department on line "2" on Create Purchase Order Screen
And I should see "ORA" as Short Code on line "3" on Create Purchase Order Screen
And I should see "ORANGE" as Short Description on line "3" on Create Purchase Order Screen
And I should see "11534" as Product Code on line "3" on Create Purchase Order Screen
And I should see "300" as Expected Quantity on line "3" on Create Purchase Order Screen
And I should see "3.00" as Buy Price on line "3" on Create Purchase Order Screen
And I should see "Goods Invoice" as Type on line "3" on Create Purchase Order Screen
And I should see "CITRUS" as Department on line "3" on Create Purchase Order Screen
Then I should see "CAPR" as Short Code on line "4" on Create Purchase Order Screen
And I should see "RED CAPSICUM" as Short Description on line "4" on Create Purchase Order Screen
And I should see "16260" as Product Code on line "4" on Create Purchase Order Screen
And I should see "275" as Expected Quantity on line "4" on Create Purchase Order Screen
And I should see "3.55" as Buy Price on line "4" on Create Purchase Order Screen
And I should see "Goods Invoice" as Type on line "4" on Create Purchase Order Screen
And I should see "VEGETABLES" as Department on line "4" on Create Purchase Order Screen
When I click on "Commit" button from Create Purchase Order Screen

@NewPO-MultipleLine-Received
Scenario: New PO - Multiple Line - Received
Given I am a Registered User
When I click on "Create Purchase Order" button from SideBar
And I select "Received" as Status from Create Purchase Order Screen
And I select the Supplier with Id "18046" from Create Purchase Order Screen
And I click on "New Line" button from Create Purchase Order Screen
And I search for Product with code "CAPM" from Purchase Order Line Entry Screen
And I select "ISRAEL" as Country from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I enter "100" as Received Amount from Purchase Order Line Entry Screen
And I enter "8.00" as Buy Price from Purchase Order Line Entry Screen
And I select "VEGETABLES" as Department from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
Then I should see "CAPM" as Short Code on line "1" on Create Purchase Order Screen
And I should see "MIXED CAPSICUM" as Short Description on line "1" on Create Purchase Order Screen
And I should see "1541" as Product Code on line "1" on Create Purchase Order Screen
And I should see "100" as Expected Quantity on line "1" on Create Purchase Order Screen
And I should see "8.00" as Buy Price on line "1" on Create Purchase Order Screen
And I should see "Goods Invoice" as Type on line "1" on Create Purchase Order Screen
And I should see "VEGETABLES" as Department on line "1" on Create Purchase Order Screen
When I change the Supplier for the one with Id "22091" from Create Purchase Order Screen
And I click on line "1" Short Code from Create Purchase Order Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I enter "120" as Expected amount from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
Then I should see "100" as Expected Quantity on line "1" on Create Purchase Order Screen
And I should see "120" as Received Quantity on line "1" on Create Purchase Order Screen
When I click on "New Line" button from Create Purchase Order Screen
And I search for Product with code "AVO" from Purchase Order Line Entry Screen
And I select "12KG" as Weight from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I enter "250" as Expected amount from Purchase Order Line Entry Screen
And I enter "8.50" as Buy Price from Purchase Order Line Entry Screen
And I select "FRUIT" as Department from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I click on "New Line" button from Create Purchase Order Screen
And I search for Product with code "ORA" from Purchase Order Line Entry Screen
And I select "20KG" as Weight from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I enter "300" as Expected amount from Purchase Order Line Entry Screen
And I enter "3.00" as Buy Price from Purchase Order Line Entry Screen
And I select "CITRUS" as Department from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I click on "New Line" button from Create Purchase Order Screen
And I search for Product with code "CABSAV" from Purchase Order Line Entry Screen
And I select "2KG" as Weight from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
And I enter "275" as Expected amount from Purchase Order Line Entry Screen
And I enter "8" as Buy Price from Purchase Order Line Entry Screen
And I select "VEGETABLES" as Department from Purchase Order Line Entry Screen
And I click on "Continue" button from Purchase Order Line Entry Screen
Then I should see "AVO" as Short Code on line "2" on Create Purchase Order Screen
And I should see "AVOCADO" as Short Description on line "2" on Create Purchase Order Screen
And I should see "1233" as Product Code on line "2" on Create Purchase Order Screen
And I should see "250" as Expected Quantity on line "2" on Create Purchase Order Screen
And I should see "250" as Received Quantity on line "2" on Create Purchase Order Screen
And I should see "8.50" as Buy Price on line "2" on Create Purchase Order Screen
And I should see "Goods Invoice" as Type on line "2" on Create Purchase Order Screen
And I should see "FRUIT" as Department on line "2" on Create Purchase Order Screen
And I should see "ORA" as Short Code on line "3" on Create Purchase Order Screen
And I should see "ORANGE" as Short Description on line "3" on Create Purchase Order Screen
And I should see "11534" as Product Code on line "3" on Create Purchase Order Screen
And I should see "300" as Expected Quantity on line "3" on Create Purchase Order Screen
And I should see "300" as Received Quantity on line "3" on Create Purchase Order Screen
And I should see "3.00" as Buy Price on line "3" on Create Purchase Order Screen
And I should see "Goods Invoice" as Type on line "3" on Create Purchase Order Screen
And I should see "CITRUS" as Department on line "3" on Create Purchase Order Screen
Then I should see "CABSAV" as Short Code on line "4" on Create Purchase Order Screen
And I should see "SAVOY CABBAGE" as Short Description on line "4" on Create Purchase Order Screen
And I should see "25546" as Product Code on line "4" on Create Purchase Order Screen
And I should see "275" as Expected Quantity on line "4" on Create Purchase Order Screen
And I should see "275" as Received Quantity on line "4" on Create Purchase Order Screen
And I should see "8.00" as Buy Price on line "4" on Create Purchase Order Screen
And I should see "Goods Invoice" as Type on line "4" on Create Purchase Order Screen
And I should see "VEGETABLES" as Department on line "4" on Create Purchase Order Screen
When I click on "Commit" button from Create Purchase Order Screen