/********************************************
Name: LoginForm.cs
Purpose: logging in
Notes: Authored by Daniel.
********************************************/

using BudgetPlanner;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetPlanner
{
    public partial class LoginForm : ModernForm
    {
        //-----------------------------------------------------------------------------------------------
        // Dependencies
        //-----------------------------------------------------------------------------------------------

        private readonly MainForm m_MainForm;
        private readonly NavigationManager m_Navigator;
        private readonly SessionManager m_SessionManager;
        private readonly EventDispatcher m_EventDispatcher;
        private readonly ThemeManager m_ThemeManager;

        //-----------------------------------------------------------------------------------------------
        // Screen
        //-----------------------------------------------------------------------------------------------




        public LoginForm(EventDispatcher InEventDispatcher, MainForm InMainForm, NavigationManager InNavigator,
            SessionManager InSessionManager, ThemeManager InThemeManager)
        {
            InitializeComponent();

            ApplyTheme(InThemeManager.GetCurrentTheme());

            m_MainForm = InMainForm;
            m_Navigator = InNavigator;
            m_SessionManager = InSessionManager;
            m_EventDispatcher = InEventDispatcher;
            m_ThemeManager = InThemeManager;

            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);

            foreach (var theme in InThemeManager.GetThemes())
            {
                ThemeComboBox.Items.Add(theme.Name);
            }

            ThemeComboBox.SelectedIndex = ThemeComboBox.FindString(InThemeManager.GetCurrentTheme().Name);

        }

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
        }

        private void SignInScreen_Load(object sender, EventArgs e)
        {
            //  m_MainForm.SetMenuBarActive(false);
            //  m_MainForm.ClearRightMenuBar();
            //   m_MainForm.ClearLeftMenuBar();
            //SignInPanel.Location = new Point(Size.Width / 2, Size.Height / 2);

            SetTitleButtonTint(Color.Gray);
        }

        //-----------------------------------------------------------------------------------------------
        // Controls
        //-----------------------------------------------------------------------------------------------

        private void SignInButton_Click(object sender, EventArgs e)
        {
            m_EventDispatcher.Publish(new LogInEvent(UsernameInput.Text, PasswordInput.Text, true));

            UsernameInput.Text = PasswordInput.Text = "";

            // Logger.Info($"Sign in as '{user.GetUsername()}' successful!");

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

        public void ApplyTheme(Theme InTheme)
        {

            //WelcomeLabel.BackColor = InTheme.Surface;

            UsernameInput.BackColor = Color.White;
            UsernameInput.ForeColor = Color.Black;
            PasswordInput.BackColor = Color.White;
            PasswordInput.ForeColor = Color.Black;

            SignInButton.BackColor = InTheme.Accent;

            UsernameInputLabel.BackColor = Color.White;
            UsernameInputLabel.ForeColor = Color.Black;

            PasswordInputLabel.BackColor = Color.White;
            PasswordInputLabel.ForeColor = Color.Black;

            SignInPanel.BackColor = Color.White;

            DevelopersLabel.ForeColor = InTheme.Accent;
            DeveloperIcon.IconColor = InTheme.Accent;

            iconPictureBox1.IconColor = InTheme.Accent;
            iconPictureBox1.BackColor = InTheme.Surface;
            SidePanel.BackColor = InTheme.Surface;

            TitleLabel.ForeColor = InTheme.Surface;
            SubtitleLabel.ForeColor = InTheme.Surface;

            this.BackColor = Color.Gray;
            //  SidePanel.IconColor = InTheme.Accent;
            //   iconButton1.BackColor = InTheme.Surface;
        }

        private void DevelopersLabel_Click(object sender, EventArgs e)
        {
             
        }

        private void ThemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_ThemeManager.SetTheme(ThemeComboBox.Text);
        }
    }
}
