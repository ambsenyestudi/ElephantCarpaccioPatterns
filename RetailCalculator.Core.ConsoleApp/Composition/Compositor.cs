using RetailCalculator.Domain.Calculation;
using RetailCalculator.Domain.Taxing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RetailCalculator.Core.ConsoleApp.Composition
{
    public static class Compositor
    {
        private static Dictionary<Type, object> dependiencies;
        private static void InitDependiencies()
        {
            dependiencies = new Dictionary<Type, object>();
            dependiencies.Add(typeof(TaxOptions), CreateTaxOptions());
            dependiencies.Add(typeof(DiscountCalculationService), CreateDiscountCalculationService());
            dependiencies.Add(typeof(PriceCalculationService), Resolve<PriceCalculationService>(typeof(PriceCalculationService)));
            dependiencies.Add(typeof(TaxCalculationService),
                Resolve<TaxCalculationService>(typeof(TaxCalculationService), new Type[] { typeof(TaxOptions) }));
        }

        public static T Resolve<T>(Type classType, Type[] constructorParams = null) where T : class
        {
            if (dependiencies == null)
            {
                InitDependiencies();
            }
            if (constructorParams != null)
            {
                var currDependencies = constructorParams.Select(x => dependiencies[x]).ToArray<object>();
                return (T)Activator.CreateInstance(classType, currDependencies);
            }
            return (T)Activator.CreateInstance(classType);
        }

        private static TaxOptions CreateTaxOptions()
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

        private static DiscountCalculationService CreateDiscountCalculationService()
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
