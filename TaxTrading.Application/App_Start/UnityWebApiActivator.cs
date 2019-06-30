using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Http;
using TaxTrading.Application.Domain.Taxing;
using TaxTrading.Application.Models;
using Unity;
using Unity.AspNet.WebApi;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(TaxTrading.Application.UnityWebApiActivator), nameof(TaxTrading.Application.UnityWebApiActivator.Start))]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(TaxTrading.Application.UnityWebApiActivator), nameof(TaxTrading.Application.UnityWebApiActivator.Shutdown))]

namespace TaxTrading.Application
{
    /// <summary>
    /// Provides the bootstrapping for integrating Unity with WebApi when it is hosted in ASP.NET.
    /// </summary>
    public static class UnityWebApiActivator
    {
        /// <summary>
        /// Integrates Unity when the application starts.
        /// </summary>
        public static void Start() 
        {
            
            var container = new UnityContainer();
            //register options object
            container.RegisterInstance(new TaxOptions { Taxes = GetTaxesSection() });
            //register services
            container.RegisterType<ITaxCalculationService, TaxCalculationService>();
            container.RegisterType<IStateService, StateService>();
            var resolver = new UnityDependencyResolver(container);
            
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }

        private static Dictionary<string, float> GetTaxesSection()
        {
            var result = new Dictionary<string, float>();
            var section = ConfigurationManager.GetSection("TaxOptions") as TaxSection;
            foreach (var item in section.Taxes)
            {
                var tax = item as TaxState;
                if(tax!=null)
                {
                    result.Add(tax.State, tax.Tax);
                }
            }
            return result;
        }

        /// <summary>
        /// Disposes the Unity container when the application is shut down.
        /// </summary>
        public static void Shutdown()
        {
            UnityConfig.Container.Dispose();
        }
    }
}