/********************************************
Name: class Profile
Purpose: Entry point
Notes: Authored by Microsoft, edited by Daniel
********************************************/


using System.Windows.Forms;

namespace BudgetPlanner
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // Create the MyApplicationContext, that derives from ApplicationContext,
            // that manages when the application should exit.

            App.Start();
        }
    }
}