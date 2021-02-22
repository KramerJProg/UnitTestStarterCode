using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW212_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        private SimpleMath simpleMath;

        [TestInitialize]
        public void Object()
        {
            simpleMath = new SimpleMath();
        }

        [TestMethod()]
        [TestCategory("Add")]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            double sum = num1 + num2;
            double sumSimpleMath = simpleMath.Add(num1, num2);
            Assert.AreEqual(sum, sumSimpleMath);
        }

        [TestMethod]
        [TestCategory("Multiply")]
        [DataRow(5, 10)]
        [DataRow(10, -5)]
        [DataRow(-5, -2.2)]
        [DataRow(0, -0)]
        [DataRow(-2.4, 7.8)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double product = num1 * num2;
            double productSimpleMath = simpleMath.Multiply(num1, num2);
            Assert.AreEqual(product, productSimpleMath);
        }

        [TestMethod]
        [TestCategory("Divide By Zero")]
        [DataRow(10, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            double divideByZero = num1 / num2;
            Assert.ThrowsException<DivideByZeroException>(() => simpleMath.Divide(num1, num2));
        }

        [TestMethod]
        [TestCategory("Divide")]
        [DataRow(5, 10)]
        [DataRow(10, -5)]
        [DataRow(0, -2.2)]
        [DataRow(-2.4, 7.8)]
        public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2)
        {
            double quotient = num1 / num2;
            double quotientSimpleMath = simpleMath.Divide(num1, num2);
            Assert.AreEqual(quotient, quotientSimpleMath);
        }

        [TestMethod]
        [TestCategory("Subtract")]
        [DataRow(5, 10)]
        [DataRow(10, -5)]
        [DataRow(-5, -2.2)]
        [DataRow(0, -0)]
        [DataRow(-2.4, 7.8)]
        public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2)
        {
            double difference = num1 - num2;
            double differenceSimpleMath = simpleMath.Subtract(num1, num2);
            Assert.AreEqual(difference, differenceSimpleMath);
        }
    }
}