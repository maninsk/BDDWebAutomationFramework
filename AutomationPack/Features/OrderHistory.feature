Feature: OrderHistory
	
@mytag
Scenario Outline: The order should be successful for registered users
	Given the user successfully logged in with valid <username> and <password>
	When the product <item> order placed successfully
	Then the order <item> should be available in order history and details
	
	Examples:
		| Username   | Password | item    |
		| manikgnbr  | Test@123 | t-shirt | 