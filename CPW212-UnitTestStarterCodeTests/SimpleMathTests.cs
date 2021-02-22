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
            // Use the DataRow values to test the Add method
            double sum = num1 + num2;
            double sum2 = simpleMath.Add(num1, num2);
            Assert.AreEqual(sum, sum2);
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
            // Use a few pairs of values to test the Multiply method
            double product = num1 * num2;
            double product2 = simpleMath.Multiply(num1, num2);
            Assert.AreEqual(product, product2);
        }

        [TestMethod]
        [DataRow(10, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            double divideByZero = num1 / num2;
            Assert.ThrowsException<DivideByZeroException>(() => simpleMath.Divide(num1, num2));
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(10, -5)]
        [DataRow(-5, -2.2)]
        [DataRow(-2.4, 7.8)]
        public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2)
        {
            double quotient = num1 / num2;
            double quotient2 = simpleMath.Divide(num1, num2);
            Assert.AreEqual(quotient, quotient2);
        }

        // TODO: Test subtract method with two valid numbers
    }
}