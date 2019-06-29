using RetailCalculator.Domain.Calculation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RetailCalculator.Core.ConsoleApp.Test.Calculation
{
    public class PriceCalculatorShould
    {
        [Fact]
        public void CalculatePrice()
        {
            
            var expected = 4f;
            var sut = new PriceCalculator();
            var purchase = new PurchaseEntity
            {
                Count = 2,
                Price = 2
            };
            Assert.Equal(expected, sut.CalculcateTotal(purchase));
        }
        [Fact]
        public void Discount()
        {

            var expected = 3f;
            var sut = new PriceCalculator();
            Assert.Equal(expected, sut.ApplyDiscount(4, 0.25f));
        }
    }
}
