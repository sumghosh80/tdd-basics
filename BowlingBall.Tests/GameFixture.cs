using System;
using Xunit;

namespace BowlingBall.Tests
{
    public class GameFixture
    {
        private GameFrameRoll gFR;
        private Game game;

        public GameFixture()
        {
            gFR = new GameFrameRoll();
            game = new Game();
        }

        private void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                gFR.Roll(pins);
            }
        }

        [Fact]
        public void DummyTest()
        {
            // This is a dummy test that will always pass.
        }

        private void RollSpare()
        {
            gFR.Roll(6);
            gFR.Roll(4);
        }

        [Fact]

        //Zero pins down in all 10 frames, so score=0
        public void AllZeroTest()
        {
            RollMany(20, 0);
            Assert.Equal(0, game.GetScore(gFR));
        }

        [Fact]
        //1 pin down in each frame of 10, so score =20
        public void AllOnesTest()
        {
            RollMany(20, 1);
            Assert.Equal(20, game.GetScore(gFR));
        }

        [Fact]
        public void OneSpareTest()
        {
            RollSpare();
            gFR.Roll(4);
            RollMany(17, 0);
            Assert.Equal(18, game.GetScore(gFR));
        }

        [Fact]
        public void OneStrikeTest()
        {
            gFR.Roll(10);
            gFR.Roll(4);
            gFR.Roll(5);
            RollMany(17, 0);
            Assert.Equal(28, game.GetScore(gFR));
        }

        [Fact]
        //All Strike, 10 pins down in one roll, so score=300
        public void AllStrikeTest()
        {
            RollMany(12, 10);
            Assert.Equal(300, game.GetScore(gFR));
        }

        [Fact]
        public void TwoStrikeTest()
        {
            gFR.Roll(10);
            gFR.Roll(10);
            Assert.Equal(30, game.GetScore(gFR));
        }


        [Fact]
        //All Spare, 10 pins down in two rolls, so score=150 
        public void AllSpareTest()
        {
            RollMany(21, 5);
            Assert.Equal(150, game.GetScore(gFR));
        }

        [Fact]
        public void TwoSpareTest()
        {
            RollSpare();
            RollSpare();
            Assert.Equal(26, game.GetScore(gFR));
        }
    }
}

