using RetailCalculator.Domain.Calculation;
using Xunit;

namespace RetailCalculator.Core.ConsoleApp.Test.Calculation
{
    public class PriceCalculatorShould
    {
        [Fact]
        public void CalculatePrice()
        {
            
            var expected = 4f;
            var sut = new PriceCalculationService();
            var purchase = new PurchaseEntity
            {
                Count = 2,
                Price = 2
            };
            Assert.Equal(expected, sut.CalculcateTotal(purchase));
        }
        
    }
}
