/********************************************
Name: DashboardScreen.cs
Purpose: The darshboard to display important stats and info
Notes: WIP. 
********************************************/

using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Management;
using static SkiaSharp.HarfBuzz.SKShaper;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace BudgetPlanner
{
    public partial class DashboardScreen : UserControl
    {
        //-----------------------------------------------------------------------------------------------
        // Dependencies
        //-----------------------------------------------------------------------------------------------

        private readonly MainForm m_MainForm;
        private readonly EventDispatcher m_EventDispatcher;
        private readonly SessionManager m_SessionManager;

        //-----------------------------------------------------------------------------------------------
        // Form
        //-----------------------------------------------------------------------------------------------

        //-----------------------------------------------------------------------------------------------
        // [1] Pass in Dependencies by constructor using DI Container
        //-----------------------------------------------------------------------------------------------

        public DashboardScreen(EventDispatcher InEventDispatcher, MainForm InMainForm,
            ThemeManager InThemeManager, AccountTitle InAccountTitle, ScreenTitle InScreenTitle,
            SessionManager InSessionManager)
        {
            InitializeComponent();

            ApplyTheme(InThemeManager.GetCurrentTheme());

            m_MainForm = InMainForm;
            m_EventDispatcher = InEventDispatcher;
            m_SessionManager = InSessionManager;
            
            //------------------------------------------------------------------------------------------------
            // [2] Subscribe to Events to communicate across services and screens 
            //------------------------------------------------------------------------------------------------
            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);


            var rightMenuBar = InAccountTitle;
            var leftMenuBar = InScreenTitle;
            m_MainForm.SetRightMenuBar(rightMenuBar);
            m_MainForm.SetLeftMenuBar(leftMenuBar);
        }

        //-----------------------------------------------------------------------------------------------
        // Utils
        //-----------------------------------------------------------------------------------------------

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
        }

        public void ApplyTheme(Theme InTheme)
        {
            // Nothing here yet
        }




        // ------------------------------------------------------------------------------------------------
        // WIP
        // ------------------------------------------------------------------------------------------------
        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            var subscriptions = m_SessionManager.GetActiveProfile().GetSubscriptions();
            foreach (var subscription in subscriptions)
            {
                var calculator = new TimelineCalculator(subscription.GetName(), new DateTime(2026, 1, 1), CalendarRepeatType.Month);
                var result = calculator.GetOccurrencesInYear(2026);

                foreach (var date in result)
                {
                    Logger.ConsoleInfo($"Subscription: {subscription.GetName()}; Amount: {subscription.GetChargeAmount()}, Date: {date}");
                }
            }


        }
    }
}
