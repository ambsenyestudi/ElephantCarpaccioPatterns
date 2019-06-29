using RetailCalculator.Core.ConsoleApp.Application;
using RetailCalculator.Core.ConsoleApp.Composition;
using RetailCalculator.Domain.Calculation;
using RetailCalculator.Domain.Taxing;
using System;

namespace RetailCalculator.Core.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputManager = Compositor.Resolve<InputManager>(typeof(InputManager));

            var dependencies = new Type[]
            {
                typeof(PriceCalculationService),
                typeof(DiscountCalculationService),
                typeof(TaxCalculationService),
            };

            var calculator = Compositor.Resolve<RetailCalculatorService>(typeof(RetailCalculatorService), dependencies);
            Console.WriteLine("Welcome to retail calculator");

            var purchase = new PurchaseEntity();
            purchase.Price = inputManager.GetPrice();
            purchase.Count = (int)inputManager.GetItemCount();




            var state = inputManager.GetState(calculator.GetTaxStates());
            Console.WriteLine($"Taxes for state {state} are {calculator.GetTaxCharge(state).ToTaxPercentage()}");
            var partial = calculator.CalculateTotal(purchase, state);
            Console.WriteLine($"Total: {partial}");

            var discount = calculator.FigureDiscount(partial);
            Console.WriteLine($"Applying a discount of {discount.ToTaxPercentage()}");
            Console.WriteLine($"Total: {calculator.CalculateTotal(purchase, state, true)}");
            Console.ReadLine();
        }
    }
}
