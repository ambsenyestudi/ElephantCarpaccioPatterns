using System.Collections.Generic;
using System.Web.Http;
using TaxTrading.Application.Domain.Taxing;

namespace TaxTrading.Application.Controllers
{
    public class StatesController : ApiController
    {
        private IStateService stateService;

        public StatesController(IStateService stateService)
        {
            this.stateService = stateService;
        }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return stateService.GetAvailableStates();
        }

    }
}