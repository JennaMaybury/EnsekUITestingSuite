Feature: BuyEnergy

A short summary of the feature


Scenario: Api call to buy energy is successful 
	When  A call is made to the buy energy end point using 'Post' with 'valid' values
	Then '200' status code is returned 
	And 'Success' message is returned within the body
