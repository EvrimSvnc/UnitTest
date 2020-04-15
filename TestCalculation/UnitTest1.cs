using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add()
        {
            Calculation.Calculate _result = new Calculation.Calculate();
            int result = _result.Add(20, 10);

            Assert.AreEqual(30, result);

        }
        [TestMethod]
        public void Subtract()
        {
            Calculation.Calculate _result = new Calculation.Calculate();
            int result = _result.Subtract(20, 10);

            Assert.AreEqual(10, result);

        }
        [TestMethod]
        public void Multiply()
        {
            Calculation.Calculate _result = new Calculation.Calculate();
            int result = _result.Multiply(20, 10);

            Assert.AreEqual(200, result);

        }
        [TestMethod]
        public void Divide()
        {
            Calculation.Calculate _result = new Calculation.Calculate();
            int result = _result.Divide(20, 10);

            Assert.AreEqual(2, result);

        }
    }
}
