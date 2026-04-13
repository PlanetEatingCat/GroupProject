/********************************************
Name: ClientApplication.cs
Purpose: Default themes for the most exquisite app
Notes: Authored by Daniel
********************************************/

using BudgetPlanner;
using GroupProject.Source.WinForms.Menus;
using ScottPlot.Colormaps;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Bluetooth;
using Windows.Networking.NetworkOperators;

namespace BudgetPlanner
{
    //----------------------------------------------------------------------------------------
    // Core Functionality
    //----------------------------------------------------------------------------------------
    public static class App
    {
        public static void Start()
        {
            // 1. Set up app dependencies
            // 2. Singletons: Created once and always alive until the end of the application

            ServiceContainer serviceContainer = new ServiceContainer();

            serviceContainer.AddSingleton<MainForm>();
            serviceContainer.AddSingleton<LoginForm>();
            serviceContainer.AddSingleton<AppContext>();
            serviceContainer.AddSingleton<SessionManager>();
            serviceContainer.AddSingleton<ThemeManager>();
            serviceContainer.AddSingleton<NavigationManager>();
            serviceContainer.AddSingleton<EventDispatcher>();

            // 3. Scoped: Created once and always alive until the end of its scope
            serviceContainer.AddScoped<ExpenseScreen>();
            serviceContainer.AddScoped<LoginForm>();
            serviceContainer.AddScoped<DashboardScreen>();
            serviceContainer.AddScoped<GoalsScreen>();
            serviceContainer.AddScoped<IncomeScreen>();
            serviceContainer.AddScoped<ExpenseScreen>();
            serviceContainer.AddScoped<SubscriptionScreen>();
            serviceContainer.AddScoped<ThemeScreen>();
            serviceContainer.AddScoped<AccountScreen>();
            serviceContainer.AddScoped<AccountTitle>();
            serviceContainer.AddScoped<ScreenTitle>();

            serviceContainer.AddTransient<BudgetEdit>();

            var provider = serviceContainer.BuildProvider();

            // Initialize themes
            Themes.Initialize();
            var themeManager = provider.GetService<ThemeManager>();
            themeManager.SetTheme("SnhuBlue");

            // Winforms initialization
            ApplicationConfiguration.Initialize();

            // Switch to the dashboard/home screen
            var navigator = provider.GetService<NavigationManager>();
            navigator.GoTo<DashboardScreen>();

            // Show debug console
            var debugConsoleForm = new DebugConsoleForm();
            debugConsoleForm.Show();

            // Create and run the app context
            AppContext context = provider.GetService<AppContext>();
            Application.Run(context);

        }   
    }
}
