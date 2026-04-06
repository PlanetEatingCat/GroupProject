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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetPlanner
{
    public partial class DashboardScreen : UserControl
    {
        //-----------------------------------------------------------------------------------------------
        // Dependencies
        //-----------------------------------------------------------------------------------------------

        private readonly MainForm m_MainForm;
        private readonly EventDispatcher m_EventDispatcher;

        //-----------------------------------------------------------------------------------------------
        // Form
        //-----------------------------------------------------------------------------------------------

        public DashboardScreen(EventDispatcher InEventDispatcher, MainForm InMainForm,
            ThemeManager InThemeManager, AccountTitle InAccountTitle, ScreenTitle InScreenTitle)
        {
            InitializeComponent();

            ApplyTheme(InThemeManager.GetCurrentTheme());

            m_MainForm = InMainForm;
            m_EventDispatcher = InEventDispatcher;

            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);

            m_MainForm.SetMenuBarActive(true);
            //m_MainForm.ExpandMenu();

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
        }
    }
}
