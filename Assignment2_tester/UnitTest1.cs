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


            /// <summary>
			///DistanceMoved = (int)(movementRange * Convert.ToInt32(magneticField)) + BASE_MOVEMENT + Convert.ToInt32(gravitationalField);
			/// Base on this formula MagneticField and GravitationalField are 1 and MovementRange = 2 and BASE_MOVEMENT = 3
            /// DistanceMoved = (2*1 + 3 + 1) = 6
            /// </summary>
            particleMovement.MagneticField = true;
            Assert.AreEqual(true,particleMovement.MagneticField);
            particleMovement.GravitationalField = true;
            Assert.AreEqual(true, particleMovement.GravitationalField);
            particleMovement.MovementRange = 2;
            Assert.AreEqual(2, particleMovement.MovementRange);
            Assert.AreEqual(6, particleMovement.DistanceMoved);

            /// <summary>
			///DistanceMoved = (int)(movementRange * Convert.ToInt32(magneticField)) + BASE_MOVEMENT + Convert.ToInt32(gravitationalField);
			/// Base on this formula MagneticField is false(0)  and GravitationalField is 1 and MovementRange = 2 and BASE_MOVEMENT = 3
            /// DistanceMoved = (2*0 + 3 + 1) = 4
            /// </summary>
            particleMovement.MagneticField = false;
            Assert.AreEqual(2, particleMovement.MovementRange);
            Assert.AreEqual(4, particleMovement.DistanceMoved);

            /// <summary>
            ///DistanceMoved = (int)(movementRange * Convert.ToInt32(magneticField)) + BASE_MOVEMENT + Convert.ToInt32(gravitationalField);
            /// Base on this formula MagneticField is true(1)  and GravitationalField is true(1)and MovementRange = 5 and BASE_MOVEMENT = 3
            /// DistanceMoved = (5*1 + 3 + 1) = 9
            /// </summary>
            particleMovement.MovementRange = 5;
            particleMovement.MagneticField = true;
            Assert.AreEqual(5, particleMovement.MovementRange);
            Assert.AreEqual(9, particleMovement.DistanceMoved);


        }
    }
}
