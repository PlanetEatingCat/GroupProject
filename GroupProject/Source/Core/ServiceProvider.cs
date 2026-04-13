/********************************************
Name: ServiceProvider.cs
Purpose: Dependency container for Dependencies Injection
Notes: Authored by Daniel
References: C#'s system & https://medium.com/@bhargavkoya56/crafting-your-own-dependency-injection-container-in-c-a-developers-journey-bd255633dd5f
********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    // Used to access and create services
    public class ServiceProvider
    {
        private readonly Dictionary<Type, ServiceDescriptor> m_Descriptors;
        private Dictionary<Type, object> m_ScopedInstances = new();

        private readonly ServiceScopeFactory m_ScopeFactory;
   
        public ServiceProvider(Dictionary<Type, ServiceDescriptor> InDescriptors)
        {
            m_ScopeFactory = new ServiceScopeFactory(this);
            m_Descriptors = InDescriptors;
        }

        public Dictionary<Type, ServiceDescriptor> GetDescriptors() { return m_Descriptors; }

        public ServiceScope CreateScope()
        {
            return new ServiceScope(this);
        }
        public TService GetService<TService>()
        {
            return (TService)Get(typeof(TService));
        }

        public object Get(Type InServiceType)
        {

            if (InServiceType == typeof(ServiceScopeFactory))
                return m_ScopeFactory;

            var descriptor = m_Descriptors[InServiceType];

            // Get or add instance in scope
            if (descriptor.Lifetime == ServiceLifetime.Scoped)
            {
                if (m_ScopedInstances.TryGetValue(InServiceType, out var instance))
                {
                    return instance;
                }

                instance = CreateInstance(InServiceType);
                m_ScopedInstances.Add(InServiceType, instance);
                return instance;
            }
            // Get singleton instance
            else if (descriptor.Lifetime == ServiceLifetime.Singleton)
            {
                if (descriptor.Instance == null)
                {
                    descriptor.Instance = CreateInstance(descriptor.Type);
                }

                return descriptor.Instance;
            }

            // Create new instance (Transient)
            return CreateInstance(descriptor.Type);
        }

        // Uses reflection to automatically pass dependencies into constructor
        private object CreateInstance(Type type)
        {
            var constructors = type.GetConstructors();
            var constructor = constructors[0];

            var parameters = constructor.GetParameters();
            var args = new object[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                args[i] = Get(parameters[i].ParameterType);
            }

            return Activator.CreateInstance(type, args);

        }
    }
}
