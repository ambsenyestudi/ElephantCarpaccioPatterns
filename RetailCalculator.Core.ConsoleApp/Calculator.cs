using System;
using System.Collections.Generic;
using System.Text;

namespace RetailCalculator.Core.ConsoleApp
{
    public class Calculator
    {
        public int Price { get; set; }
        public Calculator()
        {
            Price = 1;
        }

        public int CalculcateTotal()
        {
            return Price;
        }
    }
}
