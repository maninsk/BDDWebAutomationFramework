Feature: Myaccount
	

@mytag
Scenario Outline: Personal information should be updated successfully
	Given the user successfully logged in with valid <username> and <password>
	When the user update <firstname>
	Then the <firstname> should be updated in myaccount

	Examples:
		| Username  | Password | firstname |
		| manikgnbr | Test@123 | Mani      |