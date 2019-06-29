using System;
using System.Collections.Generic;
using System.Linq;

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
        public string GetState(IEnumerable<string> states)
        {
            var comparedStates = states.Select(x => x.ToUpper());
            var allowedStates = string.Join(", ", states);
            Console.WriteLine($"Insert on of these states {allowedStates}");
            var input = Console.ReadLine().ToUpper();
            var isValid = comparedStates.Contains(input);
            while(!isValid)
            {
                
                Console.WriteLine($"invalid state {input} try on of the followin {allowedStates} \n");
                input = Console.ReadLine().ToUpper();
                isValid = comparedStates.Contains(input);
            }
            return input;
        }
    }
}
