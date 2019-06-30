using System.Collections.Generic;

namespace RetailCalculator.Framework.Domain.Calculation
{
    public class DiscountOptions
    {
        public IEnumerable<DiscountRange> DiscountRangeList { get; set; }
    }
}
