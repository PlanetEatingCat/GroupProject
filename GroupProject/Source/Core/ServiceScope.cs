using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public class ServiceScope : IDisposable
    {
        private ServiceProvider m_Provider;

        public ServiceScope(ServiceProvider InRoot)
        {
            m_Provider = new ServiceProvider(InRoot.GetDescriptors());
        }

        public ServiceProvider GetProvider() { return m_Provider; }

        public void Dispose()
        {
        }
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
