using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using A1;

namespace Assignment2_tester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ParticleMovement particleMovement = new ParticleMovement();
            

            particleMovement.CalculateDistance();

            particleMovement.MagneticField = true;
            Assert.AreEqual(true,particleMovement.MagneticField);
            particleMovement.GravitationalField = true;
            Assert.AreEqual(true, particleMovement.GravitationalField);
            particleMovement.MovementRange = 2;
            Assert.AreEqual(2, particleMovement.MovementRange);
            Assert.AreEqual(6, particleMovement.DistanceMoved);


            particleMovement.MagneticField = false;
            Assert.AreEqual(2, particleMovement.MovementRange);
            Assert.AreEqual(4, particleMovement.DistanceMoved);


            particleMovement.MovementRange = 5;
            particleMovement.MagneticField = true;
            Assert.AreEqual(5, particleMovement.MovementRange);
            Assert.AreEqual(9, particleMovement.DistanceMoved);


        }
    }
}
