using RetailCalculator.Domain.Calculation;
using RetailCalculator.Domain.Taxing;
using System.Collections.Generic;

namespace RetailCalculator.Core.ConsoleApp.Application
{
    public static class ServiceLocator
    {
        private static RetailCalculatorService retailCalculatorService;
        public static RetailCalculatorService RetailCalculatorService
        {
            get
            {
                if (retailCalculatorService == null)
                {
                    retailCalculatorService = CreateRetailCalculatorService();
                }
                return retailCalculatorService;
            }
        }

        private static RetailCalculatorService CreateRetailCalculatorService()
        {
            var taxOptions = new TaxOptions
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
            var taxCalculationService = new TaxCalculationService(taxOptions);
            return new RetailCalculatorService
            {
                Calculator = new PriceCalculator(),
                TaxCalculationService = taxCalculationService
            };
            
        }
    }
}
