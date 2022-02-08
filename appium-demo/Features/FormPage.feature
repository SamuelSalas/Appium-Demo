Feature: FormPage
	
Scenario: Fill Form Page
	Given goes to Form Page
	When enter "Appium" into Input field
	Then Input text result should be also "Appium"
	When clicks switch
	Then the switch should turn ON
	When dropdown option "Appium is awesome" is selected
	Then "Appium is awesome" option should be displayed
