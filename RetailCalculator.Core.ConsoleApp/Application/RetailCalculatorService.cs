using RetailCalculator.Domain.Calculation;
using RetailCalculator.Domain.Taxing;

namespace RetailCalculator.Core.ConsoleApp.Application
{
    public class RetailCalculatorService
    {
        public PriceCalculationService Calculator { get; set; }
        public DiscountCalculationService DiscountCalculator { get; set; }
        public TaxCalculationService TaxCalculator { get; set; }

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
        public float FigureDiscount(float price) => DiscountCalculator.FigureDiscount(price);
        public float GetTaxCharge(string state) => TaxCalculator.Taxes[state];
    }
}
