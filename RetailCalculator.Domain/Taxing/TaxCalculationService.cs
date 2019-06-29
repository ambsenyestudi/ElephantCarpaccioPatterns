using System.Collections.Generic;

namespace RetailCalculator.Domain.Taxing
{
    public class TaxCalculationService
    {
        public Dictionary<string, float> Taxes { get; private set; }
        public TaxCalculationService(TaxOptions options)
        {
            Taxes = options.Taxes;
        }
        public float CalculateTaxes(float price, string state)
        {
            return price * (1 + Taxes[state]);
        }
    }
}
