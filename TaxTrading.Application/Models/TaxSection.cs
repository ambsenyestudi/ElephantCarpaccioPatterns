using System.Configuration;

namespace TaxTrading.Application.Models
{
    public class TaxSection : ConfigurationSection
    {
        public TaxSection()
        {
            Taxes = new TaxGroup();
        }
        [ConfigurationProperty("Taxes", IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(TaxGroup))]
        public TaxGroup Taxes
        {
            get => (TaxGroup)this["Taxes"];
            set => this["Taxes"] = value;
        }
    }
}