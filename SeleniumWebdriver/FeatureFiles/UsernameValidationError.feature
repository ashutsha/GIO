Feature: _TS5_Validate already exist username

Background: 
	Given User is at anjularjs Home Page with url "https://angularjs.realworld.io/#/register"
@user
Scenario:_TS5_Validate already exists username
	Given a user is not logged in
	When the user tries to sign up with a username that already exists
	Then a validation error is displayed

