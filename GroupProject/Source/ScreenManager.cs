using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public static class ScreenManager
    {
        private static Panel m_Host;

        public static void Initialize(Panel InHostPanel)
        {
            m_Host = InHostPanel;
        }

        public static void SwitchScreens(UserControl page)
        {
            if (m_Host == null)
                throw new Exception("ScreenManager not initialized.");

            m_Host.Controls.Clear();
            page.Dock = DockStyle.Fill;
            m_Host.Controls.Add(page);
        }


    }
}
