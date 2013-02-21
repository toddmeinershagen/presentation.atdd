using System;
using System.Linq;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Bowling.Domain.AcceptanceTests.Specs
{
    [Binding]
    public class BowlingGame_ScoreCalculationSteps
    {
        private BowlingGame _game;

        [Given]
        public void Given_a_new_bowling_game()
        {
            _game = new BowlingGame();
        }
        
        [When]
        public void When_all_of_my_balls_are_landing_in_the_gutter()
        {
            RollMany(20, 0);
        }
        
        [Then]
        public void Then_my_total_score_should_be_SCORE(int score)
        {
            _game.Score.Should().Be(score);
        }

        [When]
        public void When_all_of_my_rolls_are_PINS(int pins)
        {
            RollMany(20, pins);
        }

        [When]
        public void When_I_roll_pins(Table table)
        {
            foreach (var row in table.Rows)
            {
                _game.Roll(Convert.ToInt32(row["pins"]));
            }
        }


        private void RollMany(int times, int pins)
        {
            Enumerable.Range(1, times).ToList().ForEach(x => _game.Roll(pins));
        }
    }
}
