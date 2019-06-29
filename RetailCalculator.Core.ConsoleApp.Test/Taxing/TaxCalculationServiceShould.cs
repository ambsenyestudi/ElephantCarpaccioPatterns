using RetailCalculator.Domain.Taxing;
using System.Collections.Generic;
using Xunit;

namespace RetailCalculator.Core.ConsoleApp.Test.Taxing
{
    public class TaxCalculationServiceShould
    {
        [Fact]
        public void Calculatetax()
        {
            var price = 2f;
            var state = "AA";
            var expected = 2.2f;
            var options = new TaxOptions
            {
                Taxes = new Dictionary<string, float> { [state] = 0.1f }
            };
            var sut = new TaxCalculationService(options);
           
            Assert.Equal(expected, sut.CalculateTaxes(price, state));
        }
    }
}
