using System.Collections.Generic;

namespace RetailCalculator.Domain.Calculation
{
    public class PriceCalculator
    {
        
        public float CalculcateTotal(PurchaseEntity purchase)=>
            purchase.Price * purchase.Count;

        public float ApplyDiscount(float price, float discount) =>
            price * (1f - discount);
    }
}
