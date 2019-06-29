using System;
using Xunit;

namespace RetailCalculator.Core.ConsoleApp.Test
{
    public class CalculatorShould
    {
        [Fact]
        public void HavePrice()
        {
            var sut = new Calculator();
            Assert.True(sut.Price > 0);
        }
        [Fact]
        public void HaveTotal()
        {
            var sut = new Calculator
            {
                Count = 2,
                Price = 1f,
                Tax = 0.01f
            };
            Assert.True(sut.CalculcateTotal() > 0);
        }
        [Fact]
        public void HaveATaxTotal()
        {
            var sut = new Calculator();
            Assert.True(sut.Tax > 0);
        }
        [Fact]
        public void CalculateTotal()
        {
            var price = 1f;
            int count = 2;
            var tax = 0.01f;
            var expected = price * count * (1 + tax);
            var sut = new Calculator {
                Count = 2,
                Price = 1f,
                Tax = 0.01f
            };
            var actual = sut.CalculcateTotal();
            Assert.Equal(expected, actual,2);
        }
    }
}
