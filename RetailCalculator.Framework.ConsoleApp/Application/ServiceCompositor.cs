using GalaSoft.MvvmLight.Ioc;
using RetailCalculator.Framework.Domain.Calculation;
using RetailCalculator.Framework.Domain.Taxing;
using System.Collections;
using System.Configuration;
using System.Globalization;
using System.Linq;

namespace RetailCalculator.Framework.ConsoleApp.Application
{
    public class ServiceCompositor
    {
        public RetailCalculatorService RetailCalculatorService { get => SimpleIoc.Default.GetInstance<RetailCalculatorService>(); }
        public InputManager InputManager { get => SimpleIoc.Default.GetInstance<InputManager>(); }

        public ServiceCompositor()
        {
            SimpleIoc.Default.Register(GetTaxOptions);
            SimpleIoc.Default.Register<TaxCalculationService>();

            SimpleIoc.Default.Register(GetDiscountOptions);
            SimpleIoc.Default.Register<DiscountCalculationService>();

            SimpleIoc.Default.Register<PriceCalculationService>();
            SimpleIoc.Default.Register<RetailCalculatorService>();
            SimpleIoc.Default.Register<InputManager>();
        }

        private TaxOptions GetTaxOptions()
        {
            var taxSettings = ConfigurationManager.GetSection("TaxSettings") as IDictionary;
            var taxes = taxSettings.Keys.Cast<object>().ToDictionary(k => k.ToString(), v => float.Parse(taxSettings[v].ToString(), CultureInfo.InvariantCulture));
            return new TaxOptions { Taxes = taxes };
        }
        private DiscountOptions GetDiscountOptions()
        {
            var discountSettings = ConfigurationManager.GetSection("DiscountSettings") as IDictionary;
            return new DiscountOptions
            {
                DiscountRangeList = discountSettings.Keys.Cast<object>()
                    .Select(k =>
                        new DiscountRange
                        {
                        Amount = float.Parse(k.ToString()),
                        Discount = float.Parse(discountSettings[k].ToString(), CultureInfo.InvariantCulture)
                    })
            };
        }
    }
}
