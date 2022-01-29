using MathUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class MathUtilsTests
    {
        [TestMethod]
        public void OperatorPrecedence()
        {
            var average = MathUtils.MathUtils.Average(2, 1);
            Assert.AreEqual(1.5d, average);            
        }
    }
}
