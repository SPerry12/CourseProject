Feature: User accounts
Allow users to create accounts
Scenario: A user needs an accounts (Functional)
		  Given the user has an email address
		  Then the user uses his/her email to start account creation
		  Then the user chooses a unique user name
		  Then the user creates a unique password no less than 8 characters long.
		  Then send authentication email to user's email address
		  

Feature: Admin Accounts
Allow staff members to create admin accounts
Scenario: A staff memember needs an account (Functional)
		  Given the staff member has an employee ID 
		  Given the staff member has a company email
		  Then staff member uses employee ID to create account
		  Then staff member is able to create a password
		  Then staff member links admin account to company email
		  Then email is sent to company email for authentication
		  

Feature: Site moderation throught Admin Accounts 
Allow Admin Accounts to moderate comments and recipes
Scenario: Inappropriate comments and/or recipes are made
		  Given user creates inappropriate content
		  Given site has flagged content or user has reported content
		  Then admin has the ability to delete said inappropriate content


Feature: Users can flag inappropriate content.
Allow users to flag inappropriate content to be deleted by admins.
Scenario: User sees inappropriate content
		  Given user sees inappropriate content
		  Then user flags content 
		  And content is marked as inappropriate


Feature: Comment Section
Allow users to have the ability to comment on recipes
Scenario: User wishes to comment on recipes
		  Given user with a valid account wishes to comment on recipes
		  Then user is able to comment on recipes
		  And the comments will be stored/permanent 
		  But comments can only be 100 characters in length


Feature: Recipe Creation
Allow users to create recipes
Scenario: User creates a recipe
		  Given the user has a vaild account 
		  Given the user is signed in
		  Given the user has selected new recipe
		  Then the user may enter recipe name
		  Then the user may enter the user may enter recipe instructions
		  Then the user may enter nutritional information
		  Then the user may provide a picture of the recipe
		  Then the user may mark the recipe with premade descriptor tags


Feature: Ability to store recipes 
Allow recipes to be stored.
Scenario: User creates recipe and needs to have it saves
		  Given user has created a completed recipe
		  When user saves recipe the recipe is saved for later viewing
		  Then user can come back later and view their created recipe


Feature: Recipe Display: Public/Private
The user may set the view settings of their recipe to public or private
Scenario: User wishes to view their stored recipes
		  Given the user has created and saved a recipe
		  Then the user may make the recipe public or private
		  But the user may go back and change this view setting at any time
		  
		  
Feature: Search function
Allow users to search for other user's recipes
Scenario: A user wishes to search for a recipe
		  Given the user has a valid account
		  Given there are other recipes created
		  Given that there are recipes with a public view setting
		  Then the user may search for recipes with premade descriptor tags or a custom search 


Feature: Recipe Comparison
The ability to compare recipes side by side
Scenario: User wishes to compare two recipes
		  Given the user has a valid account
		  Given there are recipes created
		  Given there are recipes set to public
		  Then the user may select two recipes
		  Then both recipes appear side by side
		  Then the user may compare recipe instructions
		  Then the user may compare nutritional information
		  Then the user may compare premade descriptor tags


Feature: Rating System
Rating system for Chefs "user accounts" and recipes
Scenario: User wishes to rate a recipe and/or chef
		  Given the user that is rating has a valid account
		  Given the user that is the ratee has a valid account
		  Given the recipe is set to public
		  Then the user may rate the chef or recipe on a 5 star scale.
		  






