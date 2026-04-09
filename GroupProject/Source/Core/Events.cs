using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public class ScreenChangedEvent
    {
        public ScreenChangedEvent(UserControl InScreen) { Screen = InScreen; }

        public UserControl Screen;
    }

    public class LogInEvent
    {
        public string Username = "";
        public string Password = "";
        public bool RememberMe = false;

        public LogInEvent(string InUsername, string InPassword, bool InRememberMe)
        {
            Username = InUsername;
            Password = InPassword;
            RememberMe = InRememberMe;
        }
    }

    public class LogOutEvent
    {
        public LogOutEvent() { }
    }

    public class ThemeChangedEvent
    {
        public Theme NewTheme;

        public ThemeChangedEvent(Theme InTheme)
        {
            NewTheme = InTheme;
        }
    }
}
