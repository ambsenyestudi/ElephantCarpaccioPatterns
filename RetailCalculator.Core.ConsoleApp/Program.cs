using RetailCalculator.Core.ConsoleApp.Application;
using RetailCalculator.Domain.Calculation;
using System;

namespace RetailCalculator.Core.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = ServiceLocator.RetailCalculatorService;
            Console.WriteLine("Welcome to retail calculator");

            var purchase = new PurchaseEntity();
            Console.WriteLine("Insert item price");
            purchase.Price = float.Parse(Console.ReadLine());
            Console.WriteLine($"Item price {purchase.Price}");

            Console.WriteLine("Insert item count");
            purchase.Count = int.Parse(Console.ReadLine());
            Console.WriteLine($"Item count {purchase.Count}");


            Console.WriteLine("Insert state");
            var state = Console.ReadLine();
            Console.WriteLine($"Taxes for state {state} are {calculator.GetTaxCharge(state).ToTaxPercentage()}");
            Console.WriteLine($"Total: {calculator.CalculateTotal(purchase, state)}");
            var discount = 0.03f;
            Console.WriteLine($"Applying a dicount of {discount.ToTaxPercentage()}");
            Console.WriteLine($"Total: {calculator.CalculateTotal(purchase, state, discount)}");
            Console.ReadLine();
        }
    }
}
