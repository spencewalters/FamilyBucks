# FamilyBucks
Getting those kids to do the chores!

It's a work in progress.

Working features:

 - Math program (subtraction/addition)
 - Free Family Buck
 - Chores

To-do:

* Game configuration - set math parameters (difficulty)
* Admin menu
	-> Chores (Add/Edit/Remove)
	-> Rewards(Add/Edit/Remove)
	-> Programs(Add/Edit/Remove)
		What appears in the menu
		- set limits

* User preferences
	- Set theme song
	- Set customized avatar
* Rewards purchase & cash-out
* User files import/export
	- Requires parental signoff for both
* Add MSMQ or some other messaging
	- Allow remote admin of another installation
		- Update chores, rewards, program configurations remotely

		
Done:
	Add logging
	Add unit testing
	Replace Register button with 1-time "Initial Setup"
		-> Create folders
		-> Add administrator	
		
	Admin
		-> Users(Add/Edit/Remove)	
		+ set as Admin or not
