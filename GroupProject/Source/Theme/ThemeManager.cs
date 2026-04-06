/********************************************
Name: ThemeManager.cs
Purpose: ThemeManager for the most exquisite app
Notes: WIP
********************************************/

using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BudgetPlanner 
{
    // Theme Changed Event
    public class ThemeChangedEvent
    {
        public Theme NewTheme;

        public ThemeChangedEvent(Theme InTheme)
        {
            NewTheme = InTheme;
        }
    }

    // Theme Manager
    public class ThemeManager
    {
        private readonly EventDispatcher m_EventDispatcher;

        private List<Theme> m_Themes = new List<Theme>();
        private Theme m_CurrentTheme = Themes.Dark;

        public ThemeManager(EventDispatcher InEventDispatcher)
        {
            m_EventDispatcher = InEventDispatcher;  

            m_Themes.Add(Themes.Dark);
            m_Themes.Add(Themes.SnhuBlue);

        }

        public Theme GetCurrentTheme() { return m_CurrentTheme; }

        public List<Theme> GetThemes() { return m_Themes; }

        public void SetTheme(string name)
        {
            var theme = m_Themes.FirstOrDefault(t => t.Name == name);
            if (theme != null) 
            {
                m_CurrentTheme = theme;
                m_EventDispatcher.Publish(new ThemeChangedEvent(m_CurrentTheme));
            }
        }

        public void ApplyTheme()
        {
            if (m_CurrentTheme != null)
            {
                m_EventDispatcher.Publish(new ThemeChangedEvent(m_CurrentTheme));
            }
        }

        public bool ThemeExist(string InName)
        {
            var theme = m_Themes.FirstOrDefault(t => t.Name == InName);
            if (theme != null)
                return true;

            return false;
        }

        public void AddTheme(Theme theme)
        {
            m_Themes.Add(theme);
        }
    }

}
