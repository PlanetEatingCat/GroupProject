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
        private static Panel m_HostRightMenuBar;

        private static BudgetPlannerForm HostForm;
        private static DashboardScreen m_DashboardScreen;

        public static DashboardScreen GetDashboardScreen() { return m_DashboardScreen; }
       // public static DashboardScreen GetDashboardScreen() { return m_DashboardScreen; }

        public static void Initialize(BudgetPlannerForm InHostForm, Panel InHostPanel, Panel InHostRightMenuBarPanel)
        {
            m_Host = InHostPanel;
            m_HostRightMenuBar = InHostRightMenuBarPanel;
            HostForm = InHostForm;
            m_HostRightMenuBar.Hide();
        }

        public static void SwitchScreens(UserControl InPage)
        {
            if (m_Host == null)
                throw new Exception("ScreenManager not initialized.");

            m_Host.Controls.Clear();
            InPage.Dock = DockStyle.Fill;
            m_Host.Controls.Add(InPage);
        }

       
 
        public static void UnsetRightMenuBar()
        {
            m_HostRightMenuBar.Controls.Clear();
            m_HostRightMenuBar.Hide();
        }


        public static void SetRightMenuBar(UserControl InMenuBar)
        {
            m_HostRightMenuBar.Show();

            if (m_HostRightMenuBar == null)
                throw new Exception("ScreenManager not initialized.");

            m_HostRightMenuBar.Controls.Clear();

            m_HostRightMenuBar.Dock = DockStyle.None;
            m_HostRightMenuBar.Width = InMenuBar.Width;
            m_HostRightMenuBar.Dock = DockStyle.Right;
            
            InMenuBar.Top = (m_HostRightMenuBar.Height - m_HostRightMenuBar.Height) / 2;

            m_HostRightMenuBar.Controls.Add(InMenuBar);
        }
    }
}
