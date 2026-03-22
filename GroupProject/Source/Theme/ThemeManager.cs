using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public static class ThemeManager
    {
        private static Theme m_Current;

        public static Theme GetTheme()
        {
            return m_Current;
        }

        public static void SetTheme(Theme InTheme)
        {
            m_Current = InTheme;
        }

        public static void ApplyTheme(Control InRoot)
        {
            ApplyToControl(InRoot);
        }

        private static void ApplyToControl(Control InControl)
        {
            InControl.BackColor = m_Current.Background;
            InControl.ForeColor = m_Current.Foreground;

            foreach (Control child in InControl.Controls)
                ApplyToControl(child);
        }
    }

}
