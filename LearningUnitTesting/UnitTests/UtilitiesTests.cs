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
        public void Multiply_5x10e50()
        {
            double a = 5;
            double b = 10;
            double expected = 50;
            double result = Utilities.Multiply(a, b);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Multiply_1x0e0()
        {
            double a = 1;
            double b = 0;
            double expected = 0;
            double result = Utilities.Multiply(a, b);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Multiply_10x10n0()
        {
            double result = Utilities.Multiply(10, 10);

            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void Multiply_1x10n1000()
        {
            Assert.AreNotEqual(1000, Utilities.Multiply(1, 10));
        }

        [TestMethod]
        public void Multiply_0x1n1()
        {
            Assert.AreNotEqual(1, Utilities.Multiply(0, 1));
        }

        [TestMethod]
        public void Multiply_0x1e0()
        {
            double result = Utilities.Multiply(0, 1);
            // Assert.AreEqual(0, Utilities.Multiply(0, 1));
            Assert.AreEqual(0, result);

        }
        #endregion

        #region Divide Tests
        [TestMethod]
        public void Divide_10by5e2()
        {
            double a = 10;
            double b = 5;
            double expected = 2;
            double result = Utilities.Divide(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_10by0eNaN()
        {
            double result = Utilities.Divide(10, 0);
            Assert.AreEqual(double.NaN, result);
        }

        [TestMethod]
        public void Divide_0by10()
        {
            double expected = 0 / 10;
            double result = Utilities.Divide(0, 10);
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region Convert string to double
        [TestMethod]
        public void Convert_10()
        {
            string a = "10";
            double b = 10;
            double result = Utilities.Convert(a);
            Assert.AreEqual(result, b);
        }

        [TestMethod]

        public void Convert_Pencil()
        {
            string a = "pencil";
            Assert.AreEqual(double.NaN, Utilities.Convert(a));
        }

        [TestMethod]
        public void Convert_Negative12()
        {
            string a = "-12";
            double b = -12;

            Assert.AreEqual(Utilities.Convert(a), b);

        }

    [TestMethod]
        public void Convert_Decimal()
        {
            string a = "12.79";
            double b = 12.79;

            Assert.AreEqual(Utilities.Convert(a), b);
        }
        #endregion
    }
}
