using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearningUnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UtilitiesTests
    {
        #region Multiply Tests
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

        [TestMethod]
        public void MultiplyTest5()
        {
            Assert.AreNotEqual(1, Utilities.Multiply(0, 1));
        }

        [TestMethod]
        public void MultiplyTest6()
        {
            double result = Utilities.Multiply(0, 1);
            // Assert.AreEqual(0, Utilities.Multiply(0, 1));
            Assert.AreEqual(0, result);

        }
        #endregion

        #region Divide Tests
        [TestMethod]
        public void Divide10by5()
        {
            double a = 10;
            double b = 5;
            double expected = 2;
            double result = Utilities.Divide(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide10by0()
        {
            double result = Utilities.Divide(10, 0);
            Assert.AreEqual(double.NaN, result);
        }

        [TestMethod]
        public void Divide0by10()
        {
            double expected = 0 / 10;
            double result = Utilities.Divide(0, 10);
            Assert.AreEqual(expected, result);
        }
        #endregion

        [TestMethod]
        public void convertString()
        {
            string a = "10";
            double b = 5;
            double expected = 15;
            double result = Utilities.Convert(a, b);
            Assert.AreEqual(expected, result);
        }
    }
}
