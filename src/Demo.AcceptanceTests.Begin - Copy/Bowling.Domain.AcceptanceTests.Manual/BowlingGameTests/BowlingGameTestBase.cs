using System.Linq;

namespace Bowling.Domain.AcceptanceTests.Manual.BowlingGameTests
{
    public class BowlingGameTestBase
    {
        protected BowlingGame _game;

        protected void RollMany(int times, int pins)
        {
            Enumerable.Range(1, times).ToList().ForEach(x => _game.Roll(pins));
        }
    }
}