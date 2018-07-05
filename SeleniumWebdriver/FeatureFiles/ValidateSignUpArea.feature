Feature: _TS4_Validate Sign Up Area

Background: 
	Given User is at anjularjs Home Page with url "https://angularjs.realworld.io/#/"
Scenario:_TS4_Validate Sign Up Area
	Given a user is not logged in
	When a user tries to like an article
	Then the user is directed to the Sign up area
