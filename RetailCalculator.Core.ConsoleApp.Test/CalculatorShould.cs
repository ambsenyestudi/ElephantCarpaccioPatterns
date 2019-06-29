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
    }
}