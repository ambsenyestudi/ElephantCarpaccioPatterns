using System.Collections.Generic;

namespace TaxTrading.Application.Domain.Taxing
{
    public class TaxCalculationService : ITaxCalculationService
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
