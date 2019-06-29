using System;

namespace RetailCalculator.Core.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine("Welcome to retail calculator");
            Console.WriteLine($"Item price {calculator.Price}");
            Console.WriteLine($"Tax is {calculator.BeatyfyTax(calculator.Tax)}");
            Console.WriteLine($"Total: {calculator.CalculcateTotal()}");
            Console.ReadLine();
        }
    }
}
