using System;

namespace BowlingBall
{
    public class Game:IGameScore
    {
        

        /// <summary>
        /// Calculation of score of frames 
        /// </summary>
        /// <returns></returns>
        public int GetScore(GameFrameRoll gameFR)
        {
            int score = 0;
            int frameIndex = 0;
            const int Max_Frame = 10;

            for (int frame = 0; frame < Max_Frame; frame++)
            {
                if (gameFR.IsSpare(frameIndex))
                {
                    score += 10 + gameFR.rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else if (gameFR.IsStrike(frameIndex))
                {
                    score += 10 + gameFR.rolls[frameIndex + 1] + gameFR.rolls[frameIndex + 2];
                    frameIndex++;
                }
                else
                {
                    score += gameFR.rolls[frameIndex] + gameFR.rolls[frameIndex + 1];
                    frameIndex += 2;
                }

            }
            return score;

        }

    }
}

