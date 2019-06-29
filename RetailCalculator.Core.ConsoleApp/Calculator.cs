using System.Collections.Generic;
using System.Linq;

namespace RetailCalculator.Core.ConsoleApp
{
    public class Calculator
    {
        public float Price { get; set; }
        public float Tax { get; set; }
        public int Count { get; set; }
        public Dictionary<string, float> StateTax { get; private set; }

        public Calculator()
        {
            Price = 1;
            InitTaxes();
            Tax = StateTax[StateTax.Keys.First()];
        }

        private void InitTaxes()
        {
            StateTax = new Dictionary<string, float>()
            {
                ["UT"] = 0.0685f,
                ["NV"] = 0.08f,
                ["TX"] = 0.0625f,
                ["AL"] = 0.04f,
                ["TX"] = 0.0825f
            };
        }

        public string BeatyfyTax(float tax)
        {
            var taxPercent = tax * 100;
            return $"{taxPercent} %";
        }
        public float CalculcateTotal()
        {
            return Price * Count *(1f+Tax);
        }
    }
}
