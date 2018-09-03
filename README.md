# FamilyBucks
Getting those kids to do the chores!

It's a work in progress.

What's fundamentally working as of 5/27/2018:
 - Login
 - Math program (subtraction/addition)
 - Free Family Buck
 - Chores Program (75% ready)

To-do:
(x) Add logging
* Add unit testing
* Game configuration - set math parameters (difficulty)
* Admin menu
	-> Chores (Add/Edit/Remove)
	-> Rewards(Add/Edit/Remove)
	-> Programs(Add/Edit/Remove)
		What appears in the menu
		- set limits
	-> Users(Add/Edit/Remove)
		set as Admin or not
* Replace Register button with 1-time "Initial Setup"
	-> Create folders
	-> Add administrator	
* User preferences
	- Set theme song
	- Set customized avatar
* Rewards purchase & cash-out
* User files import/export
	- Requires parental signoff for both
* Add MSMQ or some other messaging
	- Allow remote admin of another installation
		- Update chores, rewards, program configurations remotely
