using System.Collections.Generic;

namespace RetailCalculator.Framework.Domain.Taxing
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

        public IEnumerable<string> GetTaxStates() => Taxes.Keys;
    }
}
