Feature: Score Calculation
	As a bowling player
	I want the system to calculate my total score
	So that I can know my performance

Scenario:  Bowling a Gutter Game
	Given a new bowling game
	When all of my balls are landing in the gutter
	Then my total score should be 0

Scenario:  Bowling All Ones
	Given a new bowling game
	When all of my rolls are 1
	Then my total score should be 20

Scenario:  Bowling Various Pins
	Given a new bowling game
	When roll various pins
	| pins |
	| 1    |
	| 3    |
	| 3    |
	| 6    |
	| 1    |
	Then my total score should be 14

Scenario:  Bowling A Spare
	Given a new bowling game
	When I roll a spare
	And the rest of my 18 rolls are 2
	Then my total score should be 48

Scenario:  Bowling A Strike
	Given a new bowling game
	When I roll a strike
	And the rest of my 18 rolls are 2
	Then my total score should be 50