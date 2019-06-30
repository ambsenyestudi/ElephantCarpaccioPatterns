using RetailCalculator.Domain.Calculation;
using System.Collections.Generic;

namespace RetailCalculator.Core.ConsoleApp.Composition
{
    public static class DiscountCalculationServiceFactory
    {
        public static DiscountCalculationService Create()
        {
            return new DiscountCalculationService(CreateDiscountRangeList());
        }

        private static List<DiscountRange> CreateDiscountRangeList()
        {
            return new List<DiscountRange>
            {
                new DiscountRange {Amount = 1000f, Discount =0.03f},
                new DiscountRange {Amount = 5000f, Discount =0.05f},
                new DiscountRange {Amount = 7000f, Discount =0.07f},
                new DiscountRange {Amount = 10000f, Discount =0.10f},
                new DiscountRange {Amount = 50000f, Discount =0.15f}
            };
        }
    }
}
