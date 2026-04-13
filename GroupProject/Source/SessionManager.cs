/********************************************
Name: SessionManager.cs
Purpose: Access current user
Notes: Authored by Daniel.
********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public class SessionManager
    {
        private Profile m_ActiveProfile;

        public void Login(Profile InProfile)
        {
            m_ActiveProfile = InProfile;
        }
        public Profile GetActiveProfile()
        {
            return m_ActiveProfile;
        }

        public void Logout()
        {
            m_ActiveProfile = null;
        }
    }
}
