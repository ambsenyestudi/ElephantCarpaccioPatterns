using System.Collections.Generic;
using System.Configuration;

namespace TaxTrading.Application.Models
{
    public class TaxGroup: ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement() =>
            new TaxState();
        
        protected override object GetElementKey(ConfigurationElement element) =>
            ((TaxState)element).State;
        
    }
}