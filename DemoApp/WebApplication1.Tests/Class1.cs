using FluentAssertions;
using NUnit.Framework;

namespace WebApplication1.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.Pass("This is a placeholder test.");
        }

    }

    // create test class for Calculator class
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenCalledWithTwoIntegers_ReturnsTheirSum()
        {
            // Arrange
            var a = 5;
            var b = 7;

            // Act
            var result = _calculator.Add(a, b);
            // Assert
            result.Should().Be(12);
        }
    }

}
