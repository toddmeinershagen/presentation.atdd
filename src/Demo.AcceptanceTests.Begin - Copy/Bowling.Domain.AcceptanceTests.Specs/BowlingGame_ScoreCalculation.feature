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
	When I roll @pins

	| pins |
	| 1    |
	| 3    |
	| 4    |
	| 3    |

	Then my total score should be 11

Scenario:  Bowling Various Pins 2
	Given a new bowling game
	When I roll @pins

	| pins | score |
	| 6    | 6     |
	| 3    | 9     |
	| 4    | 13    |
	| 5    | 18    |

	Then my total score should be 18