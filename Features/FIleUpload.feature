Feature: FIleUpload

i want to be able to upload file

@tag1
Scenario: verify a user can upload
	Given that i navigate to the website "https://the-internet.herokuapp.com/upload"
	When i click chose file
	And i click upload
	Then i should be able to upload file
