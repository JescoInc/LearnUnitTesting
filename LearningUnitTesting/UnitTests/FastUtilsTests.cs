using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearningUnitTesting;

namespace UnitTests
{
    [TestClass]
    public class FastUtilsTests
    {
        #region Multiply Tests
        [TestMethod]
        public void Multiply_5x10e50()
        {
            double expected = 50;
            FastUtils utils = new FastUtils(5, 10);
            double result = utils.Multiply();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Multiply_1x0e0()
        {
            double expected = 0;
            FastUtils utils = new FastUtils(1, 0);
            double result = utils.Multiply();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Multiply_10x10n0()
        {
            FastUtils utils = new FastUtils(10, 10);
            double result = utils.Multiply();

            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void Multiply_1x10n1000()
        {
            FastUtils utils = new FastUtils(1, 10);
            Assert.AreNotEqual(1000, utils.Multiply());
        }

        [TestMethod]
        public void Multiply_0x1n1()
        {
            FastUtils utils = new FastUtils(0, 1);
            Assert.AreNotEqual(1, utils.Multiply());
        }

        [TestMethod]
        public void Multiply_0x1e0()
        {
            FastUtils utils = new FastUtils(0, 1);

            double result = utils.Multiply();
            // Assert.AreEqual(0, Utilities.Multiply(0, 1));
            Assert.AreEqual(0, result);
        }
        #endregion
    }
}
