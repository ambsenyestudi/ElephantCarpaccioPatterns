using System;
using System.Collections.Generic;
using System.Text;

namespace RetailCalculator.Core.ConsoleApp
{
    public class Calculator
    {
        public float Price { get; set; }
        public float Tax { get; set; }

        public Calculator()
        {
            Price = 1;
            Tax = 0.04f;
        }
        public string BeatyfyTax(float tax)
        {
            var taxPercent = tax * 100;
            return $"{taxPercent} %";
        }
        public float CalculcateTotal()
        {
            return Price * (1f+Tax);
        }
    }
}
