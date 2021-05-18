using NUnit.Framework;

namespace Oware.Tests
{
    public class Mocking : IScoreHouse
    {
        private string v;
        private IScoreHouse h1;

        public Mocking(string v, IScoreHouse h1)
        {
            this.v = v;
            this.h1 = h1;
        }

        public void AddSeed(Seed seed)
        {
            throw new System.NotImplementedException();
        }

        public int GetCount()
        {
            return 2;
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            //Assert
            House p = new House(5, 0);
            p.ResetHouse();
            Assert.AreEqual(4, p.GetCount(), "4 Seeds are Expected");
            //Act
        }
        [Test]
        public void Test2()
        {
            IScoreHouse h1 = new ScoreHouse();
            Player p1 = new Player("Ron", h1);
            p1.AddSeedToScoreHouse(new Seed());
            Assert.AreEqual(1, p1.GetScore(), "1 Scores are expected");
        }
    }
}