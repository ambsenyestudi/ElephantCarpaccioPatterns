using System.Collections.Generic;
using System.Linq;

namespace RetailCalculator.Framework.Domain.Calculation
{
    public class DiscountCalculationService
    {
        private readonly List<DiscountRange> discounts;

        public DiscountCalculationService(DiscountOptions discountOptions)
        {
            this.discounts = discountOptions.DiscountRangeList.OrderByDescending(x => x.Amount).ToList();
        }
        public float FigureDiscount(float price)
        {
            bool biggerThanRange = false;
            var count = 0;
            var result = -1f;
            while (!biggerThanRange && count < discounts.Count)
            {
                var currDiscountRange = discounts[count];
                biggerThanRange = price > currDiscountRange.Amount;
                if (biggerThanRange)
                {
                    result = currDiscountRange.Discount;
                }
                count++;
            }
            return result;
        }
        public float ApplyDescount(float price)
        {
            var discount = FigureDiscount(price);
            return price * (1 - discount);
        }
    }
}
