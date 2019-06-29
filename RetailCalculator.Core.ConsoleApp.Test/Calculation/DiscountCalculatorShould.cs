using RetailCalculator.Domain.Calculation;
using System.Collections.Generic;
using Xunit;

namespace RetailCalculator.Core.ConsoleApp.Test.Calculation
{
    public class DiscountCalculatorShould
    {
        [Fact]
        public void Discount()
        {

            var expected = 0.03f;
            var dicountList = new List<DiscountRange>
            {
                new DiscountRange{Amount = 1, Discount=0.01f},
                new DiscountRange{Amount = 2, Discount=0.03f},
            };
            var sut = new DiscountCalculationService(dicountList);
            Assert.Equal(expected, sut.FigureDiscount(4));
        }
    }
}
