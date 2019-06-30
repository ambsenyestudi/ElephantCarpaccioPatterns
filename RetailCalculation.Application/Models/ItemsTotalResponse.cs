namespace RetailCalculation.Application.Models
{
    public class ItemsTotalResponse: ItemsTotalRequest
    {
        public float Total { get; set; }
        public ItemsTotalResponse(ItemsTotalRequest req)
        {
            Count = req.Count;
            Price = req.Price;
        }
        public ItemsTotalResponse(ItemsTotalRequest req, float total):this(req)
        {
            Total = total;
        }
    }
}