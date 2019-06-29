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
            //So you can see the app
            Console.ReadLine();
        }
    }
}
