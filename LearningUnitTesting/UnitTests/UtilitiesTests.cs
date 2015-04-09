using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearningUnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UtilitiesTests
    {
        [TestMethod]
        public void MultiplyTest1()
        {
            double a = 5;
            double b = 10;
            double expected = 50;
            double result = Utilities.Multiply(a, b);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MultiplyTest2()
        {
            double a = 1;
            double b = 0;
            double expected = 0;
            double result = Utilities.Multiply(a, b);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MultiplyTest3()
        {
            double result = Utilities.Multiply(10, 10);

            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void MultiplyTest4()
        {
            Assert.AreNotEqual(1000, Utilities.Multiply(1, 10));
        }
    }
}
