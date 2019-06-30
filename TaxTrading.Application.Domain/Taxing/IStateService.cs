using System.Collections.Generic;

namespace TaxTrading.Application.Domain.Taxing
{
    public interface IStateService
    {
        IEnumerable<string> GetAvailableStates();
    }
}
