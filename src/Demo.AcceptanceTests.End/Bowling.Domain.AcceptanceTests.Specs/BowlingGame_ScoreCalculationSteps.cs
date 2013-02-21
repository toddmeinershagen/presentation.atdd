using System;
using System.Linq;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Bowling.Domain.AcceptanceTests.Specs
{
    [Binding]
    public class ScoreCalculationSteps
    {
        private BowlingGame game;

        [Given]
        public void Given_a_new_bowling_game()
        {
            game = new BowlingGame();
        }
        
        [When]
        public void When_all_of_my_balls_are_landing_in_the_gutter()
        {
            RollMany(20, 0);
        }
        
        [Then]
        public void Then_my_total_score_should_be_SCORE(int score)
        {
            game.TotalScore.Should().Be(score);
        }

        [When]
        public void When_all_of_my_rolls_are_PINS(int pins)
        {
            RollMany(20, pins);
        }

        [When]
        public void When_roll_various_pins(Table table)
        {
            foreach (var row in table.Rows)
            {
                game.Roll(Convert.ToInt32(row["pins"]));
            }
        }

        [When(@"I roll a spare")]
        public void WhenIRollASpare()
        {
            game.Roll(3);
            game.Roll(7);
        }

        [When(@"I roll a strike")]
        public void WhenIRollAStrike()
        {
            game.Roll(10);
        }

        [When(@"the rest of my (.*) rolls are (.*)")]
        public void WhenTheRestOfMyRollsAre(int times, int pins)
        {
            RollMany(times, pins);
        }

        private void RollMany(int times, int pins)
        {
            Enumerable.Range(0, times).ToList().ForEach(x => game.Roll(pins));
        }
    }
}
