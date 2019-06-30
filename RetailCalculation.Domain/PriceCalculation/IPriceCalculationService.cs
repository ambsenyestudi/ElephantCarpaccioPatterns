namespace RetailCalculation.Domain.PriceCalculation
{
    public interface IPriceCalculationService
    {
        float CalculcateTotal(PurchaseEntity purchase);
    }
}
