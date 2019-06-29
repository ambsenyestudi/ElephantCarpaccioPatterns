using System;

namespace RetailCalculator.Core.ConsoleApp.Application
{
    public class InputManager
    {
        public float GetPrice()
        {
            Console.WriteLine("Insert item price");
            float price = -1f;
            bool isValid = float.TryParse(Console.ReadLine(), out price);
            while(!isValid)
            {
                Console.WriteLine("invalid price try again \n");
                isValid = float.TryParse(Console.ReadLine(), out price);
            }
            Console.WriteLine($"Item price {price}");
            return price;
        }
    }
}
