﻿Feature: Home
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

#@mytag
#Scenario: Add two numbers
#	Given I have entered 50 into the calculator
#	And I have entered 70 into the calculator
#	When I press add
#	Then the result should be 120 on the screen


Scenario: See the menu and order lunch
	Given I have opened browser to lunch system
	And I have entered "Unadon" into the page 
	When I press ok
	Then the result should show "Unadon" on the screen