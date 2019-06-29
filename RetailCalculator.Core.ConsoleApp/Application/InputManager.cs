using System;

namespace RetailCalculator.Core.ConsoleApp.Application
{
    public class InputManager
    {
        public float GetPrice()
        {
            Console.WriteLine("Insert item price");
            float price = GetInput("price");
            Console.WriteLine($"Item price is {price}");
            return price;
        }

        public float GetItemCount()
        {
            Console.WriteLine("Insert item count");
            var count = GetInput("item count");
            Console.WriteLine($"Item count is {count}");
            return count;
        }

        public float GetInput(string inputConcept)
        {
            float input = -1f;
            bool isValid = float.TryParse(Console.ReadLine(), out input);
            while (!isValid)
            {
                Console.WriteLine($"invalid {inputConcept} try again \n");
                isValid = float.TryParse(Console.ReadLine(), out input);
            }
            return input;
        }
    }
}
