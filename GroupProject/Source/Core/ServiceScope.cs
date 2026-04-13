/********************************************
Name: ServiceScope.cs
Purpose: Dependency container for Dependencies Injection
Notes: Authored by Daniel
References: C#'s system & https://medium.com/@bhargavkoya56/crafting-your-own-dependency-injection-container-in-c-a-developers-journey-bd255633dd5f
********************************************/

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public class ServiceScope
    {
        private ServiceProvider m_Provider;

        public ServiceScope(ServiceProvider InRoot)
        {
            m_Provider = new ServiceProvider(InRoot.GetDescriptors());
        }

        public ServiceProvider GetProvider() { return m_Provider; }

    }

    public class ServiceScopeFactory
    {
        private ServiceProvider m_ServiceProvider;

        public ServiceScopeFactory(ServiceProvider InRoot) 
        {
            m_ServiceProvider = InRoot;
        }

        public ServiceScope CreateScope()
        {
            return new ServiceScope(m_ServiceProvider);
        }
    }

}
