Feature: _TS6_Validate already exist email address

Background: 
	Given User is at anjularjs Home Page with url "https://angularjs.realworld.io/#/register"

Scenario:_TS6_Validate already exists email address
	Given a user is not logged in
	When the user tries to sign up with an email address that already exists
	Then a validation error is displayed


