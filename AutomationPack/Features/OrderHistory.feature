Feature: OrderHistory
	
@mytag
Scenario Outline: The order should be successful for registered users
	Given the user sucessfully logged in with valid <username> and <password>
	When the product <item> order placed sucessfully
	Then the oder <item> should be available in orderhistory and details
	
	Examples:
		| Username   | Password | item    |
		| manikgnbr  | Test@123 | t-shirt | 