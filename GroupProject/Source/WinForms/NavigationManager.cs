using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public class NavigationManager
    {
        // Dependencies
        private readonly ServiceScopeFactory m_ServiceScopeFactory;
        private readonly EventDispatcher m_EventDispatcher;

        private UserControl m_CurrentScreen;
        private ServiceScope m_CurrentScope;

        public NavigationManager(EventDispatcher InEventDispatcher, ServiceScopeFactory InServiceScopeFactory)
        {
            m_EventDispatcher = InEventDispatcher;
            m_ServiceScopeFactory = InServiceScopeFactory;
        }

        public void GoTo<TScreen>() where TScreen : UserControl
        {
            m_CurrentScope = m_ServiceScopeFactory.CreateScope();

            var screen = m_CurrentScope.GetProvider().GetService<TScreen>();
            m_EventDispatcher.Publish(new ScreenChangedEvent(screen));
        }

        public T GetActive<T>() where T : UserControl
        {
            return m_CurrentScreen as T;
        }

    }
}
