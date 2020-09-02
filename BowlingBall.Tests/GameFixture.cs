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

       

        [Fact]
        public void DummyTest()
        {
            // This is a dummy test that will always pass.
        }

       
        [Fact]

        //Zero pins down in all 10 frames, so score=0
        public void AllZeroTest()
        {
            
            Assert.Equal(1, game.GetScore(gFR));
        }

        [Fact]
        //1 pin down in each frame of 10, so score =20
        public void AllOnesTest()
        {
            
            Assert.Equal(20, game.GetScore(gFR));
        }

        [Fact]
        public void OneSpareTest()
        {
            
            Assert.Equal(10, game.GetScore(gFR));
        }

        [Fact]
        public void OneStrikeTest()
        {
            
            Assert.Equal(28, game.GetScore(gFR));
        }

        [Fact]
        //All Strike, 10 pins down in one roll, so score=300
        public void AllStrikeTest()
        {
           
            Assert.Equal(300, game.GetScore(gFR));
        }

        [Fact]
        public void TwoStrikeTest()
        {
           
            Assert.Equal(30, game.GetScore(gFR));
        }


        [Fact]
        //All Spare, 10 pins down in two rolls, so score=150 
        public void AllSpareTest()
        {
            
            Assert.Equal(100, game.GetScore(gFR));
        }

        [Fact]
        public void TwoSpareTest()
        {
            
            Assert.Equal(10, game.GetScore(gFR));
        }
    }
}

