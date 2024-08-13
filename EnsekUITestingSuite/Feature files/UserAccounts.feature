Feature: UserAccounts

Account creation validation 
Password must be min 6 char
Must have 1 uppercase
Must have 1 lowercase
Must have 1 special char 
Must contain 1 number


@ignore 
Scenario: User can create an account successfully using valid details
	Given User navigates to site via Url
	When User selects register button from the home page
	Then Registration page is displayed successfully
	When User enters a 'valid email' email address 
	And  User enters a 'valid password' password
	And User confrims 'valid' password 
	And Selects register button
	Then User account is created successfully

	Scenario: User can not create an account successfully using invalid email
	Given User navigates to site via Url
	When User selects register button from the home page
	Then Registration page is displayed successfully
	When User enters a 'invalid username' email address 
	And  User enters a 'valid password' password
	And User confrims 'valid' password 
	And Selects register button
	Then 'Invalid username' error message is displayed 

	Scenario: User can not create an account successfully using password less than 6 chars
	Given User navigates to site via Url
	When User selects register button from the home page
	Then Registration page is displayed successfully
	When User enters a 'valid email' email address 
	And  User enters a 'invalid password length' password
	And User confrims 'valid' password 
	And Selects register button
	Then 'Invalid password length' error message is displayed 

	Scenario: User can not create an account successfully using password without lowercase
	Given User navigates to site via Url
	When User selects register button from the home page
	Then Registration page is displayed successfully
	When User enters a 'valid email' email address 
	And  User enters a 'invalid password lower' password
	And User confrims 'valid' password 
	And Selects register button
	Then 'Invalid password lower' error message is displayed 

	
	Scenario: User can not create an account successfully using password without uppercase
	Given User navigates to site via Url
	When User selects register button from the home page
	Then Registration page is displayed successfully
	When User enters a 'valid email' email address 
	And  User enters a 'invalid password upper' password
	And User confrims 'valid' password 
	And Selects register button
	Then 'Invalid password upper' error message is displayed 

		
	Scenario: User can not create an account successfully using password without special char
	Given User navigates to site via Url
	When User selects register button from the home page
	Then Registration page is displayed successfully
	When User enters a 'valid email' email address 
	And  User enters a 'invalid password special char' password
	And User confrims 'valid' password 
	And Selects register button
	Then 'Invalid password special char' error message is displayed 

	Scenario: User can not create an account successfully using password without a number
	Given User navigates to site via Url
	When User selects register button from the home page
	Then Registration page is displayed successfully
	When User enters a 'valid email' email address 
	And  User enters a 'invalid password number' password
	And User confrims 'valid' password 
	And Selects register button
	Then 'Invalid password number' error message is displayed 

	
	Scenario: User can not create an account successfully using null email
	Given User navigates to site via Url
	When User selects register button from the home page
	Then Registration page is displayed successfully
	When User enters a 'empty' email address 
	And  User enters a 'valid password' password
	And User confrims 'valid' password 
	And Selects register button
	Then 'Null email' error message is displayed 

	Scenario: User can not create an account successfully using null password
	Given User navigates to site via Url
	When User selects register button from the home page
	Then Registration page is displayed successfully
	When User enters a 'valid email' email address 
	And  User enters a 'empty' password
	And User confrims 'invalid' password 
	And Selects register button
	Then 'Null password' error message is displayed 