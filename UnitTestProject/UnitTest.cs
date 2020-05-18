using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void OnePlusOneEqualsTwo()
        {
            bool IsThisTrue = (1 + 1 == 2);

            Assert.AreEqual(true, IsThisTrue);
        }

        [TestMethod]
        public void TwoPlusTwoEqualsFour()
        {
            bool IsThisTrue = (2 + 2 == 4);

            Assert.AreEqual(true, IsThisTrue);
        }

        [TestMethod]
        public void ThreePlusThreeNotEqualsSix()
        {
            bool IsThisTrue = (3 + 3 == 6);

            Assert.AreEqual(true, IsThisTrue);
        }
    }
}
