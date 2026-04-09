/********************************************
Name: AppServices.cs
Purpose: Dependency container for Dependencies Injection
Notes: WIP. 
References: https://medium.com/@bhargavkoya56/crafting-your-own-dependency-injection-container-in-c-a-developers-journey-bd255633dd5f
********************************************/

using BudgetPlanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public enum ServiceLifetime
    {
        Singleton,
        Transient,
        Scoped
    }

    public class ServiceDescriptor
    {
        public ServiceLifetime Lifetime;
        public Type Type;
        public object Instance; 
    }

    // Creates and manages lifetimes for all app services/ dependencies 
    public class ServiceContainer
    {
        // List of service descriptions used to create them when requested
        private readonly Dictionary<Type, ServiceDescriptor> m_Descriptors 
            = new Dictionary<Type, ServiceDescriptor>();
   
        // Scope
        public void AddScoped<TService>()
        {
            AddScoped(typeof(TService));
        }

        public void AddScoped(Type InService)
        {
            m_Descriptors[InService] = new ServiceDescriptor
            {
                Lifetime = ServiceLifetime.Scoped,
                Type = InService,
            };
        }

        // Singleton
        public void AddSingleton<TService>()
        {
            AddSingleton(typeof(TService));
        }

        public void AddSingleton(Type InService)
        {
            m_Descriptors[InService] = new ServiceDescriptor
            {
                Lifetime = ServiceLifetime.Singleton,
                Type = InService,
            };
        }

        // Transient 
        public void AddTransient<TService>()
        {
            AddTransient(typeof(TService));
        }

        public void AddTransient(Type InService)
        {
            m_Descriptors[InService] = new ServiceDescriptor
            {
                Lifetime = ServiceLifetime.Transient,
                Type = InService,
            };
        }

        // Builds the service provide which is used for getting services
        public ServiceProvider BuildProvider()
        {
            return new ServiceProvider(m_Descriptors);
        }
    }
}
