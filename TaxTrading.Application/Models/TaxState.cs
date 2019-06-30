using System.Configuration;

namespace TaxTrading.Application.Models
{
    public class TaxState : ConfigurationElement
    {        
        [ConfigurationProperty("State", IsKey = true, IsRequired = true)]
        public string State {
            get { return base["State"] as string; }
            set { base["State"] = value; }
        }
        [ConfigurationProperty("Tax", IsRequired = true, DefaultValue = -1f)]
        public float Tax {
            get { return (float)base["Tax"]; }
            set { base["Tax"] = value; }
        }

    }
}
