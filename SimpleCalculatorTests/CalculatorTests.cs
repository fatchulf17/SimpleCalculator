using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace SimpleCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(6, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(6, 0));
        }
    }
}