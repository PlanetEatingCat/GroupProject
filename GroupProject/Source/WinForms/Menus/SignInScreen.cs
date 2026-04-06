/********************************************
Name: SignInScreen.cs
Purpose: to sign in and set profile
Notes: Work in Progress. 
********************************************/

using BudgetPlanner;
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
    public partial class SignInScreen : UserControl
    {
        //-----------------------------------------------------------------------------------------------
        // Dependencies
        //-----------------------------------------------------------------------------------------------

        private readonly MainForm m_MainForm;
        private readonly NavigationManager m_Navigator;
        private readonly SessionManager m_SessionManager;
        private readonly EventDispatcher m_EventDispatcher;

        //-----------------------------------------------------------------------------------------------
        // Screen
        //-----------------------------------------------------------------------------------------------

        public SignInScreen(EventDispatcher InEventDispatcher, MainForm InMainForm, NavigationManager InNavigator,
            SessionManager InSessionManager, ThemeManager InThemeManager)
        {
            InitializeComponent();

            ApplyTheme(InThemeManager.GetCurrentTheme());

            m_MainForm = InMainForm;
            m_Navigator = InNavigator;
            m_SessionManager = InSessionManager;
            m_EventDispatcher = InEventDispatcher;

            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);
        }

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
        }

        private void SignInScreen_Load(object sender, EventArgs e)
        {
            m_MainForm.SetMenuBarActive(false);
            m_MainForm.ClearRightMenuBar();
            m_MainForm.ClearLeftMenuBar();
            SignInPanel.Location = new Point(Size.Width / 2, Size.Height / 2);
        }

        //-----------------------------------------------------------------------------------------------
        // Controls
        //-----------------------------------------------------------------------------------------------

        private void SignInButton_Click(object sender, EventArgs e)
        {
            User user = new User(UsernameInput.Text, PasswordInput.Text, 90);

            Profile profile = new Profile(user, 0);
            m_SessionManager.Login(profile);


            UsernameInput.Text = PasswordInput.Text = "";

            Logger.Info($"Sign in as '{user.GetUsername()}' successful!");

            m_Navigator.GoTo<DashboardScreen>();
        }

        private void SignInScreen_Resize(object sender, EventArgs e)
        {
            SignInPanel.Left = (this.Width - SignInPanel.Width) / 2;
            SignInPanel.Top = (this.Height - SignInPanel.Height) / 2;
        }

        private void SignInScreen_SizeChanged(object sender, EventArgs e)
        {
            SignInPanel.Left = (this.Width - SignInPanel.Width) / 2;
            SignInPanel.Top = (this.Height - SignInPanel.Height) / 2;
        }

        //-----------------------------------------------------------------------------------------------
        // Utils
        //-----------------------------------------------------------------------------------------------

        public void OnSwitch()
        {
            m_MainForm.SetMenuBarActive(false);
            m_MainForm.ClearRightMenuBar();
            m_MainForm.ClearLeftMenuBar();
        }

        public void ApplyTheme(Theme InTheme)
        {

            WelcomeLabel.BackColor = InTheme.Surface;

            UsernameInput.BackColor = InTheme.Sibling;
            UsernameInput.ForeColor = Color.White;
            PasswordInput.BackColor = InTheme.Sibling;
            PasswordInput.ForeColor = Color.White;

            SignInButton.BackColor = InTheme.Accent;

            UsernameInputLabel.BackColor = InTheme.Surface;
            UsernameInputLabel.ForeColor = Color.White;

            PasswordInputLabel.BackColor = InTheme.Surface;
            PasswordInputLabel.ForeColor = Color.White;

            SignInPanel.BackColor = InTheme.Surface;

            iconPictureBox1.IconColor = InTheme.Accent;
            iconPictureBox1.BackColor = InTheme.Surface;
            iconButton1.IconColor = InTheme.Accent;
            iconButton1.BackColor = InTheme.Surface;
        }
    }
}
