using RetailCalculation.Application.Models;
using RetailCalculation.Domain.PriceCalculation;
using System.Web.Http;

namespace RetailCalculation.Application.Controllers
{
    public class ItemsTotalController : ApiController
    {
        private readonly IPriceCalculationService priceCalculationService;

        public ItemsTotalController(IPriceCalculationService priceCalculationService)
        {
            this.priceCalculationService = priceCalculationService;
        }
        // POST: api/ItemTotal
        public IHttpActionResult Post([FromBody]ItemsTotalRequest request)
        {
            var puchase = new PurchaseEntity
            {
                Count = request.Count,
                Price = request.Price
            };
            var result = priceCalculationService.CalculcateTotal(puchase);
            var response = new ItemsTotalResponse(request, result);
            return Ok(response);
        }

    }
}
