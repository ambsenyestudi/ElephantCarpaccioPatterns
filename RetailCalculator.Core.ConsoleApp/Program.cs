using System;
using System.Linq;

namespace RetailCalculator.Core.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine("Welcome to retail calculator");

            Console.WriteLine("Insert item price");
            calculator.Price = float.Parse(Console.ReadLine());
            Console.WriteLine($"Item price {calculator.Price}");

            Console.WriteLine("Insert item count");
            calculator.Count = int.Parse(Console.ReadLine());
            Console.WriteLine($"Item count {calculator.Count}");


            var state = calculator.StateTax.Keys.First();
            Console.WriteLine($"Taxes for state {state}");
            Console.WriteLine($"Tax is {calculator.BeatyfyTax(calculator.Tax)}");
            Console.WriteLine($"Total: {calculator.CalculcateTotal()}");
            Console.ReadLine();
        }
    }
}
