using RetailCalculator.Domain.Calculation;
using RetailCalculator.Domain.Taxing;
using System;

namespace RetailCalculator.Core.ConsoleApp.Application
{
    public class RetailCalculatorService
    {
        public PriceCalculator Calculator { get; set; }
        public TaxCalculationService TaxCalculationService { get; set; }

        public string BeatyfyTax(float tax)
        {
            var taxPercent = tax * 100;
            return $"{taxPercent} %";
        }
        public float CalculateTotal(PurchaseEntity purchase, string state)
        {
            var partial = Calculator.CalculcateTotal(purchase);
            return TaxCalculationService.CalculateTaxes(partial, state);
        }

        public float GetTaxCharge(string state) => TaxCalculationService.Taxes[state];
    }
}
