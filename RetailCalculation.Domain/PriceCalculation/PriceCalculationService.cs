namespace RetailCalculation.Domain.PriceCalculation
{
    public class PriceCalculationService: IPriceCalculationService
    {
        public float CalculcateTotal(PurchaseEntity purchase) =>
            purchase.Price * purchase.Count;
    }
}
