namespace TaxTrading.Application.Domain.Taxing
{
    public interface ITaxCalculationService
    {
        float CalculateTaxes(float price, string state);
    }
}
