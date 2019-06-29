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
            var discountCalculaton = new DiscountCalculationService(new List<DiscountRange>
            {
                new DiscountRange {Amount = 1000f, Discount =0.03f},
                new DiscountRange {Amount = 5000f, Discount =0.05f},
                new DiscountRange {Amount = 7000f, Discount =0.07f},
                new DiscountRange {Amount = 10000f, Discount =0.10f},
                new DiscountRange {Amount = 50000f, Discount =0.15f}
            });
            return new RetailCalculatorService
            {
                Calculator = new PriceCalculationService(),
                DiscountCalculator = discountCalculaton,
                TaxCalculator = taxCalculationService
            };
            
        }
    }
}
