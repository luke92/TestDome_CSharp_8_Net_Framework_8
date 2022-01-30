using ChallengeWinSystem.Q4_OrderChars;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MathUtils
{
    [TestClass]
    public class OrderCharsTests
    {
        [TestMethod]
        public void OrderCharsTest1()
        {
            var chars = Q4OrderChars.OrderChars("a", "b").ToArray();
            Assert.AreEqual('a', chars[0]);
            Assert.AreEqual('b', chars[1]);
        }

        [TestMethod]
        public void OrderCharsTest2()
        {
            var chars = Q4OrderChars.OrderChars("ab", "ab").ToArray();
            Assert.AreEqual('a', chars[0]);
            Assert.AreEqual('a', chars[1]);
        }

        [TestMethod]
        public void OrderCharsTest3()
        {
            var chars = Q4OrderChars.OrderChars("b1", "a0").ToArray();
            Assert.AreEqual('a', chars[0]);
            Assert.AreEqual('b', chars[1]);
        }
    }
}
