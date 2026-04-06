/********************************************
Name: Logger.cs
Purpose: To log messages to the GUI
Notes: WIP. 
********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public enum MessageType
    {
        Info,
        Warn,
        Error
    }

    public static class Logger
    {
        public static event Action<string>? OnLogToConsole;
        public static event Action<string, MessageType>? OnLogToGUI;

        public static void ConsoleInfo(string message)
        {
            OnLogToConsole?.Invoke($"[Info] {message}");
        }

        public static void ConsoleError(string message)
        {
            OnLogToConsole?.Invoke($"[Error] {message}");
        }

        public static void ConsoleWarn(string message)
        {
            OnLogToConsole?.Invoke($"[Warn] {message}");
        }

        public static void Info(string message)
        {
            OnLogToGUI?.Invoke(message, MessageType.Info);
        }

        public static void Error(string message)
        {
            OnLogToGUI?.Invoke(message, MessageType.Error);
        }

        public static void Warn(string message)
        {
            OnLogToGUI?.Invoke(message, MessageType.Warn);
        }
    }

}
