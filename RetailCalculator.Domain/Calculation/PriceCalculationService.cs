namespace RetailCalculator.Domain.Calculation
{
    public class PriceCalculationService
    {
        
        public float CalculcateTotal(PurchaseEntity purchase)=>
            purchase.Price * purchase.Count;

    }
}
