Feature: Login

Background:
	Given User goes to Login Page

Scenario: Use wrong credentials
	When Submit login form
		| UserName  | Password |
		| wrongUser | qwerty   |
	Then Form errors should appear

Scenario: Login Successfully
	When Submit login form
		| UserName          | Password  |
		| test@webdriver.io | Test1234! |
	Then the user should be logged in successfully