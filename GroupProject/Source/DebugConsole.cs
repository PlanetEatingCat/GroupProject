using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public static class DebugConsole
    {
        public static event Action<string>? OnLogToGui;

        public static void Info(string message)
        {
            OnLogToGui?.Invoke($"[Info] {message}");
        }

        public static void Error(string message)
        {
            OnLogToGui?.Invoke($"[Error] {message}");
        }

        public static void Warn(string message)
        {
            OnLogToGui?.Invoke($"[Warn] {message}");
        }
    }

}
