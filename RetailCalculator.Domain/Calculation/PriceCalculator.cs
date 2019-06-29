namespace RetailCalculator.Domain.Calculation
{
    public class PriceCalculator
    {
        public float CalculcateTotal(PurchaseEntity purchase)=>
            purchase.Price * purchase.Count;
    }
}
