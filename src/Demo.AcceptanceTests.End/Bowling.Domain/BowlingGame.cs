﻿using System;

namespace Bowling.Domain
{
    public class BowlingGame
    {
        private int _currentRollIndex = 0;
        private readonly int[] _rolls = new int[21];

        public void Roll(int pins)
        {
            _rolls[_currentRollIndex] = pins;
            _currentRollIndex++;
        }

        public int TotalScore
        {
            get
            {
                var score = 0;
                var frameIndex = 0;

                for (int frame = 0; frame < 10; frame++)
                {
                    if (IsStrike(frameIndex))
                    {
                        score += 10 + GetStrikeBonus(frameIndex);
                        frameIndex++;
                    }
                    else
                    {

                        if (IsSpare(frameIndex))
                            score += 10 + GetSpareBonus(frameIndex);
                        else
                            score += _rolls[frameIndex] + _rolls[frameIndex + 1];

                        frameIndex += 2;
                    }
                }

                return score;
            }
        }

        private int GetStrikeBonus(int frameIndex)
        {
            return _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
        }

        private bool IsStrike(int frameIndex)
        {
            return _rolls[frameIndex] == 10;
        }

        private int GetSpareBonus(int frameIndex)
        {
            return _rolls[frameIndex + 2];
        }

        private bool IsSpare(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;
        }
    }
}
