using KnowledgeSharing.CleanCode.SOLID;
using KnowledgeSharing.CleanCode.SOLID.Accounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace KnowledgeSharing.CleanCode.Test.SOLID
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
            var order = new Order();
            order.TotalAmount = 100M;

            var account = new NotRegisteredAccount();

            // Act
            var result = calculator.Calculate(order, account);

            // Assert
            result.ShouldEqual(100M);
        }

        [TestMethod]
        public void TestSimpleCustomer()
        {
            // Arrange
            var order = new Order();
            order.TotalAmount = 100M;

            var account = new SimpleCustomerAccount();

            // Act
            var result = calculator.Calculate(order, account);

            // Assert
            result.ShouldEqual(85.5M);
        }

        [TestMethod]
        public void TestValuableCustomer()
        {
            // Arrange
            var order = new Order();
            order.TotalAmount = 100M;

            var account = new ValuableCustomerAccount();

            // Act
            var result = calculator.Calculate(order, account);

            // Assert
            result.ShouldEqual(66.5M);
        }

        [TestMethod]
        public void TestMostValuableCustomer()
        {
            // Arrange
            var order = new Order();
            order.TotalAmount = 100M;

            var account = new MostValuableCustomerAccount();

            // Act
            var result = calculator.Calculate(order, account);

            // Assert
            result.ShouldEqual(47.5M);
        }
    }
}