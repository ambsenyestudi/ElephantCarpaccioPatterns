using RetailCalculator.Core.ConsoleApp.Application;
using RetailCalculator.Domain.Calculation;
using RetailCalculator.Domain.Taxing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RetailCalculator.Core.ConsoleApp.Composition
{
    public class ServiceCompositor
    {
        private IDictionary<object, object> services;

        internal ServiceCompositor()
        {
            services = new Dictionary<object, object>();

            //Factories hidding dependencies
            services.Add(typeof(TaxOptions), TaxOptionsFactory.Create());
            services.Add(typeof(DiscountCalculationService), DiscountCalculationServiceFactory.Create());
            //Poor man's di
            RegisterType<InputManager>();
            RegisterType<PriceCalculationService>();
            RegisterType<TaxCalculationService>(new Type[] { typeof(TaxOptions) });
            RegisterType<RetailCalculatorService>(
                new Type[]
                {
                    typeof(PriceCalculationService),
                    typeof(DiscountCalculationService),
                    typeof(TaxCalculationService),
            });
        }

        public void RegisterType<T>(Type[] constructorParams = null)
        {
            var currType = typeof(T);
            if (!services.Keys.Contains(currType))
            {
                var instance = default(object);

                if (constructorParams != null)
                {
                    var currDependencies = constructorParams.Select(x => services[x]).ToArray<object>();
                    instance = Activator.CreateInstance(currType, currDependencies);
                }
                else
                {
                    instance = Activator.CreateInstance(currType);
                }

                services.Add(currType, instance);
            }
        }

        public T GetService<T>()
        {
            if(!services.Keys.Contains(typeof(T)))
            {
                throw new ApplicationException("The requested service is not registered");
            }
            return (T)services[typeof(T)];
        }
        
    }
}
