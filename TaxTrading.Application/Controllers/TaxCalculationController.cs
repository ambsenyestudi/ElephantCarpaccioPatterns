using System.Web.Http;
using TaxTrading.Application.Domain.Taxing;
using TaxTrading.Application.Models;

namespace TaxTrading.Application.Controllers
{
    public class TaxCalculationController : ApiController
    {
        private ITaxCalculationService taxCalculationService;

        public TaxCalculationController(ITaxCalculationService taxCalculationService)
        {
            this.taxCalculationService = taxCalculationService;
        }
        public IHttpActionResult Post([FromBody]TaxCalculationViewModel model)
        {
            var result = taxCalculationService.CalculateTaxes(model.Price, model.State);
            return Ok(new TaxCalculationResponse { Result = result});
        }
    }
}