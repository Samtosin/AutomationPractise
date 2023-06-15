Feature: GreenKart

as a user, i want to be able to purchase item

@tag1
Scenario: verify user can purchase carrot
	Given that a user navigate to the website "https://rahulshettyacademy.com/seleniumPractise/#/"
	When i search for the item "carrot"
	And i click add to cart
	And i click the basket
	And i click proceed to checkout
	And i click place order
	And i select country "Nigeria"
	And i tick checkbox for terms and condition
	And i click proceed
	Then i should be able to place order