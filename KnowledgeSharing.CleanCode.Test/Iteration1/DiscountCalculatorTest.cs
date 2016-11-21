using KnowledgeSharing.CleanCode.Iteration1;
using KnowledgeSharing.CleanCode.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace KnowledgeSharing.CleanCode.Test.Iteration1
{
    [TestClass]
    public class DiscountCalculatorTest
    {
        private DiscountCalculator calculator;

        [TestInitialize]
        public void Setup()
        {
            this.calculator = new DiscountCalculator();
        }

        [TestMethod]
        public void TestNotRegistered()
        {
            // Arrange
            var amount = 100M;
            var type = (int)AccountStatus.NotRegistered;
            var years = 6;

            // Act
            var result = calculator.Calculate(amount, type, years);

            // Assert
            result.ShouldEqual(100M);
        }

        [TestMethod]
        public void TestSimpleCustomer()
        {
            // Arrange
            var amount = 100M;
            var type = (int)AccountStatus.SimpleCustomer;
            var years = 6;

            // Act
            var result = calculator.Calculate(amount, type, years);

            // Assert
            result.ShouldEqual(85.5M);
        }

        [TestMethod]
        public void TestValuableCustomer()
        {
            // Arrange
            var amount = 100M;
            var type = (int)AccountStatus.ValuableCustomer;
            var years = 6;

            // Act
            var result = calculator.Calculate(amount, type, years);

            // Assert
            result.ShouldEqual(66.5M);
        }

        [TestMethod]
        public void TestMostValuableCustomer()
        {
            // Arrange
            var amount = 100M;
            var type = (int)AccountStatus.MostValuableCustomer;
            var years = 6;

            // Act
            var result = calculator.Calculate(amount, type, years);

            // Assert
            result.ShouldEqual(47.5M);
        }
    }
}