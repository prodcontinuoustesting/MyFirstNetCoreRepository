using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OnePlusOneEqualsTwo()
        {
            bool IsThisTrue = (1 + 1 == 2);

            Assert.AreEqual(true, IsThisTrue);
        }

        [Test]
        public void TwoPlusTwoEqualsFour()
        {
            bool IsThisTrue = (2 + 2 == 4);

            Assert.AreEqual(true, IsThisTrue);
        }

        [Test]
        public void ThreePlusThreeEqualsSix()
        {
            bool IsThisTrue = (3 + 3 == 6);

            Assert.AreEqual(true, IsThisTrue);
        }
    }
}