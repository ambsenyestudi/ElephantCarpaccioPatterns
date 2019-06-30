using System.Collections.Generic;
using System.Linq;

namespace TaxTrading.Application.Domain.Taxing
{
    public class StateService : IStateService
    {
        private readonly IEnumerable<string> states;

        public StateService(TaxOptions options)
        {
            this.states = options.Taxes.Keys.AsEnumerable();
        }
        public IEnumerable<string> GetAvailableStates() =>
            states;
    }
}
