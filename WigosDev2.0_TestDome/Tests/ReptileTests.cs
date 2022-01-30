using ChallengeWinSystem.Q3_Reptile;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class ReptileTests
    {
        [TestMethod]
        public void FireDragonLayAndEggHatchOK()
        {
            var fireDragon = new FireDragon();
            var egg = fireDragon.Lay();
            var childFireDragon = egg.Hatch();
            Assert.IsTrue(true);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CannotHatchTwice()
        {
            var fireDragon = new FireDragon();
            var egg = fireDragon.Lay();
            var childFireDragon = egg.Hatch();
            egg.Hatch();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void OtherSpeciesEggsDontMakeFireDragons()
        {
            var alligator = new Alligator();
            var egg = alligator.Lay();
            var childFireDragon = egg.Hatch();
        }
    }
}
