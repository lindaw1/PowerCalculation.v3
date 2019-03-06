using System;
using PowerCalculation;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace PowerCalculationTest
{
    [TestClass]
    public class Calculations
    {
        [TestMethod]
        public void ResidentialLargeKilowatts()
        {
            //arrange
            int kilowatts = 5000;
            decimal expectedCost = 266;
            decimal actualCost;

            // act
            actualCost = CalculateResidential(kilowatts);  //hmmm

            //assert
            Assert.AreEqual(expectedCost, actualCost);

        }
    }
}
