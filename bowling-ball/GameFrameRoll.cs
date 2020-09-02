using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingBall
{
    public class GameFrameRoll
    {
        public readonly int[] rolls = new int[21];
        public readonly int[] frame = new int[10];
        int currentRoll = 0;
        
        /// <summary>
        /// Checks if Spare is there
        /// </summary>
        /// <param name="frameIndex"></param>
        /// <returns></returns>
        public bool IsSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        /// <summary>
        /// Checks if Strike is there
        /// </summary>
        /// <param name="frameIndex"></param>
        /// <returns></returns>
        public bool IsStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        /// <summary>
        /// Assign pins per roll
        /// </summary>
        /// <param name="pins"></param>
        public void Roll(int[] pins)
        {
            for (int i = 0; i < pins.Length; i++)
            {
                rolls[currentRoll++] = pins[i];
            }
        }
    }
}
