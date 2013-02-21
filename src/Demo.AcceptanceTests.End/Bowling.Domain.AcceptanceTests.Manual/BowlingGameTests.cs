using System.Linq;
using Bowling.Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Demo.Acceptance.Manual
{
    [TestFixture]
    public class given_a_new_bowling_game
    {
        private BowlingGame _game;

        [SetUp]
        public void SetUp()
        {
            _game = new BowlingGame();
        }

        [Test]
        public void when_all_of_my_balls_are_landing_in_the_gutter_then_my_total_score_should_be_0()
        {
            RollMany(20, 0);
            _game.TotalScore.Should().Be(0);
        }

        [Test]
        public void when_all_of_my_rolls_are_1_then_my_total_score_should_be_20()
        {
            RollMany(20, 1);
            _game.TotalScore.Should().Be(20);
        }

        [Test]
        public void when_i_roll_a_spare_and_the_rest_of_my_18_rolls_are_2_then_my_total_score_should_be_48()
        {
            _game.Roll(3);
            _game.Roll(7);
            RollMany(18, 2);
            _game.TotalScore.Should().Be(48);
        }

        [Test]
        public void when_i_roll_a_strike_and_the_rest_of_my_18_rolls_are_2_then_my_total_score_should_be_50()
        {
            _game.Roll(10);
            RollMany(18, 2);
            _game.TotalScore.Should().Be(50);
        }

        private void RollMany(int times, int pins)
        {
            Enumerable.Range(0, times).ToList().ForEach(x => _game.Roll(pins));
        }
    }
}