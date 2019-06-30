using RetailCalculator.Domain.Taxing;
using System.Collections.Generic;

namespace RetailCalculator.Core.ConsoleApp.Composition
{
    public static class TaxOptionsFactory
    {
        public static TaxOptions Create()
        {
            return new TaxOptions
            {
                Taxes = new Dictionary<string, float>
                {
                    ["UT"] = 0.0685f,
                    ["NV"] = 0.08f,
                    ["TX"] = 0.0625f,
                    ["AL"] = 0.04f,
                    ["CA"] = 0.0825f,
                }
            };
        }
    }
}
