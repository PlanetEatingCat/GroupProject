/********************************************
Name: RightMenuBar.cs
Purpose: Menu bar in the right of the title bar
Notes: Work in Progress. 
********************************************/
using GroupProject.Source.WinForms.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetPlanner
{
    public partial class AccountTitle : UserControl
    {
        //-----------------------------------------------------------------------------------------------
        // Dependencies
        //-----------------------------------------------------------------------------------------------
        private readonly NavigationManager m_Navigator;
        private readonly SessionManager m_SessionManager;
        private readonly EventDispatcher m_EventDispatcher;

        //-----------------------------------------------------------------------------------------------
        // Title
        //-----------------------------------------------------------------------------------------------

        public AccountTitle(EventDispatcher InEventDispatcher, ThemeManager InThemeManager, NavigationManager InNavigator, SessionManager InSessionManager)
        {
            InitializeComponent();

            ApplyTheme(InThemeManager.GetCurrentTheme());

            m_Navigator = InNavigator;
            m_SessionManager = InSessionManager;
            m_EventDispatcher = InEventDispatcher;

            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);
        }

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
        }

        //-----------------------------------------------------------------------------------------------
        // Controls
        //-----------------------------------------------------------------------------------------------

        private void RightMenuBar_Load(object InSender, EventArgs InEventArgs)
        {
            AccountOptionsButton.Text = m_SessionManager.GetActiveProfile().GetUser().GetUsername();
        }

        private void AccountOptionsButton_Click(object InSender, EventArgs InEventArgs)
        {
            AccountOptionsMenu.Show(AccountOptionsButton, new Point(0, AccountOptionsButton.Height));
        }

        private void signOutToolStripMenuItem_Click(object InSender, EventArgs InEventArgs)
        {
            m_Navigator.GoTo<SignInScreen>();
        }
        private void settingsToolStripMenuItem_Click(object InSender, EventArgs InEventArgs)
        {
            m_Navigator.GoTo<AccountScreen>();
        }

        //-----------------------------------------------------------------------------------------------
        // Utils
        //-----------------------------------------------------------------------------------------------

        public void ApplyTheme(Theme InTheme)
        {
            AccountIcon.IconColor = InTheme.Accent;
        }

        private void AccountOptionsMenu_Opening(object sender, CancelEventArgs e)
        {

        }

    }
}
