using FluentAssertions;
using NUnit.Framework;

namespace Bowling.Domain.AcceptanceTests.Manual.BowlingGameTests
{
    [TestFixture]
    public class given_a_new_bowling_game_and_player_name_is_todd_when_all_of_my_balls_are_landing_in_the_gutter
        : BowlingGameTestBase
    {
        [SetUp]
        public void SetUp()
        {
            _game = new BowlingGame {PlayerName = "Todd"};
        }

        [Test]
        public void then_my_total_score_should_be_0()
        {
            RollMany(20, 0);
            _game.Score.Should()
                 .Be(0);
        }

        [Test]
        public void then_my_player_name_should_be_todd()
        {
            RollMany(20, 0);
            _game.PlayerName.Should().Be("Todd");
        }

    }
}