Feature: SpartaGlobalForm
	In order to register an account
	As a user
	I want to see the completion page

@mytag
Scenario: Enter Details Happy Path
	Given I am on the form page
	And I enter the valid details in all the required fields
	When I press sign in 
	Then I should be on the correct page
