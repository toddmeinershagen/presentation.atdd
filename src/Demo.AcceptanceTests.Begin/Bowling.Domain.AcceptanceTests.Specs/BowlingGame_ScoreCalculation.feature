Feature: Score Calculation
	As a bowling player
	I want the system to calculate my total score
	So that I can know my performance

Scenario:  Bowling a Gutter Game
	Given a new bowling game
	When all of my balls are landing in the gutter
	Then my total score should be 0