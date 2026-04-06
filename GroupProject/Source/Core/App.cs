/********************************************
Name: ClientApplication.cs
Purpose: Default themes for the most exquisite app
Notes: WIP.
********************************************/

using BudgetPlanner;
using GroupProject.Source.WinForms.Menus;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.NetworkOperators;

namespace BudgetPlanner
{
    public static class App
    {
        public static void Start()
        {
            // 1. Set up app dependencies

            // 2. Singletons: Created once and always alive until the end of the application

            ServiceContainer serviceContainer = new ServiceContainer();

            serviceContainer.AddSingleton<MainForm>();
            serviceContainer.AddSingleton<SessionManager>();
            serviceContainer.AddSingleton<ThemeManager>();
            serviceContainer.AddSingleton<NavigationManager>();
            serviceContainer.AddSingleton<EventDispatcher>();

            // 3. Scoped: Created once and always alive until the end of its scope
            serviceContainer.AddScoped<ExpensesScreen>();
            serviceContainer.AddScoped<SignInScreen>();
            serviceContainer.AddScoped<DashboardScreen>();
            serviceContainer.AddScoped<CalendarScreen>();
            serviceContainer.AddScoped<GoalsScreen>();
            serviceContainer.AddScoped<IncomeScreen>();
            serviceContainer.AddScoped<CardsScreen>();
            serviceContainer.AddScoped<SubscriptionScreen>();
            serviceContainer.AddScoped<SubscriptionManagerForm>();
            serviceContainer.AddScoped<ThemeScreen>();
            serviceContainer.AddScoped<AccountScreen>();
            serviceContainer.AddScoped<AccountTitle>();
            serviceContainer.AddScoped<ScreenTitle>();

            // 4. Transient: Created new everytime its asked for
           // serviceContainer.AddTransient<RemoveSubscriptionForm>();

            var provider = serviceContainer.BuildProvider();

            Themes.Initialize();
            var themeManager = provider.GetService<ThemeManager>();
            themeManager.SetTheme("SnhuBlue");

            // Winforms initialization
            ApplicationConfiguration.Initialize();


            // 5. Get MainForm singleton from container
            var mainForm = provider.GetService<MainForm>();
            var navigator = provider.GetService<NavigationManager>();

            navigator.GoTo<SignInScreen>();

            var debugConsoleForm = new DebugConsoleForm();
            debugConsoleForm.Show();

            // 7. Run the application
            Application.Run(mainForm);
        }
    }
}
