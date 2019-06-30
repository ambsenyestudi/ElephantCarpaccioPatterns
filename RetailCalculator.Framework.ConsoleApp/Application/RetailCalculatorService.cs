using RetailCalculator.Framework.Domain.Calculation;
using RetailCalculator.Framework.Domain.Taxing;
using System.Collections.Generic;

namespace RetailCalculator.Framework.ConsoleApp.Application
{
    public class RetailCalculatorService
    {
        public PriceCalculationService Calculator { get; set; }
        public DiscountCalculationService DiscountCalculator { get; set; }
        public TaxCalculationService TaxCalculator { get; set; }

        public RetailCalculatorService(
            PriceCalculationService calculator,
            DiscountCalculationService discountCalculator,
            TaxCalculationService taxCalculator)
        {
            Calculator = calculator;
            DiscountCalculator = discountCalculator;
            TaxCalculator = taxCalculator;
        }
        public string BeatyfyTax(float tax)
        {
            var taxPercent = tax * 100;
            return $"{taxPercent} %";
        }
        public float CalculateTotal(PurchaseEntity purchase, string state, bool applyDiscount = false)
        {
            var partial = Calculator.CalculcateTotal(purchase);
            var total = TaxCalculator.CalculateTaxes(partial, state);
            if (applyDiscount)
            {
                total = DiscountCalculator.ApplyDescount(total);
            }
            return total;
        }

        public IEnumerable<string> GetTaxStates()
        {
            return TaxCalculator.GetTaxStates();
        }

        public float FigureDiscount(float price) => DiscountCalculator.FigureDiscount(price);
        public float GetTaxCharge(string state) => TaxCalculator.Taxes[state];
    }
}
