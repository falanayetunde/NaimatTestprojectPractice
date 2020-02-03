Feature: SelectedItem
a user must be able to choose an item,
a user must be able to add an item to basket
a user must be able to create an account via checkout
a user must be able to purchase via wire

Scenario: verify that a user can Choose an Item
	Given that automation application has been successfully loaded
	When a user click on Woman tab
	And a user click on Top
	And a user click on Tshirt
	Then 'Faded Short Sleeve T-shirts' is displayed


	Scenario: verify that a user can add an item to the basket 
	Given that automation application has been successfully loaded
	When a user clicks on Tshirt tab
	And a user clicks on Faded Short Sleeve Tshirts
	And a user enters 1 on the quantity field
	And a user select 'M' on the size field
	And a user clicks on colour blue
	And a user clicks on add to cart
	Then the 'Product successfully added to your shopping cart' message is displayed


	Scenario: a user create an account via checkout
	Given that automation application has been successfully loaded
	When a user clicks on Tshirt tab
	And a user clicks on Faded Short Sleeve Tshirts
	And a user enters 1 on the quantity field
	And a user select 'M' on the size field
	And a user clicks on colour blue
	And a user clicks on add to cart
	And a user clicks on proceed to checkout
	And a user clicks on proceed To checkout
	And a user fill-in email field addres 'kudiratfalana554@yahoo.co.uk'
	And a user clicks on create an account
	Then Your Personel Information is displayed

	

	Scenario: verify that a user can purchase using wire
	Given that automation application has been successfully loaded
	When a user clicks on sign in
	And a user fill-in email field addres 'naimatfalana@gmail.com'
	And a user fill-in password field with Ismot123
	And a user click on sign in button
	And a user clicks on return home button
	And a user clicks on Faded short Sleeve Tshirts
	And a user select size to be L
	And a user select colour to be blue
	And a user click on Add to cart


