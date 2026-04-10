/********************************************
Name: BudgetPlannerForm.cs
Purpose: The main form for the application. Manages the menu and title bar.
Notes: Needs some more utils for less repetition. Authored by Daniel.
********************************************/

using GroupProject.Properties;
using GroupProject.Source.WinForms.Menus;
using System.Windows.Threading;

namespace BudgetPlanner
{
    public partial class MainForm : ModernForm
    {
        //-----------------------------------------------------------------------------------------------
        // Dependencies
        //-----------------------------------------------------------------------------------------------

        private readonly EventDispatcher m_EventDispatcher;
        private readonly ThemeManager m_ThemeManager;
        private readonly NavigationManager m_NavigationManager;

        //-----------------------------------------------------------------------------------------------
        // Variables
        //-----------------------------------------------------------------------------------------------

        private const int MESSAGE_VANISH_TIME = 5000; // 5 seconds
        private System.Windows.Forms.Timer m_MessageTimer = new System.Windows.Forms.Timer();

        private MenuButton m_ActiveMenuButton;

        private int m_InitialMenuWidth = -1;
        private bool m_MenuCollapsed = false;
        private bool m_MenuBarActive = true;

       
        // ---------------------------------------------------------------------------------------
        // [1] Dependencies: Passed in automatically through constructor
        // ---------------------------------------------------------------------------------------
        public MainForm(EventDispatcher InEventDispatcher, ThemeManager InThemeManager, NavigationManager InNavigationManager)
        {
            ArgumentNullException.ThrowIfNull(InEventDispatcher);
            ArgumentNullException.ThrowIfNull(InThemeManager);
            ArgumentNullException.ThrowIfNull(InNavigationManager);

            InitializeComponent();

            m_EventDispatcher = InEventDispatcher;
            m_ThemeManager = InThemeManager;
            m_NavigationManager = InNavigationManager;

            // ---------------------------------------------------------------------------------------
            // [2] Event Dispatcher: for updating themes at the momement
            // ---------------------------------------------------------------------------------------
            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);
            m_EventDispatcher.Subscribe<ScreenChangedEvent>(OnScreenChanged);

            ApplyTheme(InThemeManager.GetCurrentTheme());

            Logger.OnLogToGUI += Logger_OnLog;

            this.FormBorderStyle = FormBorderStyle.None;
            m_ActiveMenuButton = HomeMenuButton;
            m_InitialMenuWidth = MenuPanel.Width;
        }

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
        }
        private void OnScreenChanged(ScreenChangedEvent InEvent)
        {
            SetScreen(InEvent.Screen);
        }

        private void BudgetPlannerForm_Load(object InSender, EventArgs InEvent)
        {
            // This creates the border around the window for resizing
            this.Padding = new Padding(2);

            // Creates error timer. Used to hide error message after five seconds
            m_MessageTimer = new System.Windows.Forms.Timer();
            m_MessageTimer.Interval = MESSAGE_VANISH_TIME; // 5 seconds
            m_MessageTimer.Tick += (s, e) =>
            {
                MessagePanel.Visible = false;
                m_MessageTimer.Stop();
            };


            // Initialize state of panels
            MessagePanel.Visible = false;

            // Test messages
            Logger.ConsoleError("This is an error test");
            Logger.ConsoleInfo("This is a Message test");
            Logger.ConsoleWarn("This is a warning test");
        }

        // --------------------------------------------------------------------------------------------------
        // Logging
        // --------------------------------------------------------------------------------------------------

        private void Logger_OnLog(string InMessage, MessageType InType)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Logger_OnLog(InMessage, InType)));
                return;
            }

            switch (InType)
            {
                case MessageType.Error:
                    MessagePanel.BackColor = Color.IndianRed;
                    MessageIcon.Image = Resources.ErrorIcon;
                    break;
                case MessageType.Warn:
                    MessagePanel.BackColor = Color.Moccasin;
                    MessageIcon.Image = Resources.WarnIcon;
                    break;
                case MessageType.Info:
                    MessagePanel.BackColor = Color.LightSkyBlue;
                    MessageIcon.Image = Resources.InfoIcon;
                    break;

            }

            Message.Text = InMessage;
            MessagePanel.Visible = true;

            m_MessageTimer.Stop();
            m_MessageTimer.Start();
        }


        // --------------------------------------------------------------------------------------------------
        // Menu bar items
        // --------------------------------------------------------------------------------------------------

        public void SetActiveMenuItem(MenuButton InMenuButton)
        {
            m_ActiveMenuButton.SetActive(false);
            InMenuButton.SetActive(true);
            m_ActiveMenuButton = InMenuButton;
        }

        private void IncomeMenuButton_Click(object InSender, EventArgs InEventArgs)
        {
            // ----------------------------------------------------------------------------------------
            // [3] Switching Screens
            // ----------------------------------------------------------------------------------------

            SetActiveMenuItem(IncomeMenuButton);
            m_NavigationManager.GoTo<IncomeScreen>();

        }

        private void SubscriptionMenuButton_Click(object InSender, EventArgs InEventArgs)
        {
            SetActiveMenuItem(SubscriptionMenuButton);
            m_NavigationManager.GoTo<SubscriptionScreen>();
        }

        private void HomeMenuButton_Click(object InSender, EventArgs InEventArgs)
        {
            SetActiveMenuItem(HomeMenuButton);
            m_NavigationManager.GoTo<DashboardScreen>();
        }

        private void GoalsMenuButton_Click(object InSender, EventArgs InEventArgs)
        {
            SetActiveMenuItem(GoalsMenuButton);
            m_NavigationManager.GoTo<GoalsScreen>();
        }

        private void CardMenuButton_Click(object InSender, EventArgs InEventArgs)
        {
            SetActiveMenuItem(CardMenuButton);
            m_NavigationManager.GoTo<CardsScreen>();
        }

        private void CalendarMenuButton_Click(object InSender, EventArgs InEventArgs)
        {
            SetActiveMenuItem(CalendarMenuButton);
            m_NavigationManager.GoTo<CalendarScreen>();
        }

        private void ThemeMenuButton_Click(object InSender, EventArgs InEventArgs)
        {
            SetActiveMenuItem(ThemeMenuButton);
            m_NavigationManager.GoTo<ThemeScreen>();
        }

        private void ExpensesMenuButton_Click(object InSender, EventArgs InEventArgs)
        {
            SetActiveMenuItem(ExpensesMenuButton);
            m_NavigationManager.GoTo<ExpensesScreen>();
        }

        // --------------------------------------------------------------------------------------------------
        // Menu bar
        // --------------------------------------------------------------------------------------------------

        private void MenuButton_Click(object sender, EventArgs e)
        {

            if (m_MenuCollapsed)
            {
                ExpandMenu();
            }
            else
            {
                CollapseMenu();
            }
        }

        // --------------------------------------------------------------------------------------------------
        // Host Panel Utils
        // --------------------------------------------------------------------------------------------------

        public void SetScreen(UserControl InScreen)
        {
            BaseMainPanel.Controls.Clear();
            InScreen.Dock = DockStyle.Fill;
            BaseMainPanel.Controls.Add(InScreen);
        }

        public void ClearRightMenuBar()
        {
            RightMenuBarPanel.Controls.Clear();
            RightMenuBarPanel.Hide();
        }
        public void ClearLeftMenuBar()
        {
            LeftMenuBarPanel.Controls.Clear();
            LeftMenuBarPanel.Hide();
        }

        public void SetRightMenuBar(UserControl InMenuBar)
        {
            RightMenuBarPanel.Show();
            RightMenuBarPanel.Controls.Clear();

            RightMenuBarPanel.Dock = DockStyle.None;
            RightMenuBarPanel.Width = InMenuBar.Width;
            RightMenuBarPanel.Dock = DockStyle.Right;
            InMenuBar.Top = (RightMenuBarPanel.Height - InMenuBar.Height) / 2;

            RightMenuBarPanel.Controls.Add(InMenuBar);
        }

        public void SetLeftMenuBar(UserControl InMenuBar)
        {
            LeftMenuBarPanel.Show();
            LeftMenuBarPanel.Controls.Clear();

            LeftMenuBarPanel.Dock = DockStyle.None;
            LeftMenuBarPanel.Width = InMenuBar.Width;
            LeftMenuBarPanel.Dock = DockStyle.Left;
            InMenuBar.Top = (LeftMenuBarPanel.Height - InMenuBar.Height) / 2;

            LeftMenuBarPanel.Controls.Add(InMenuBar);
        }

        // --------------------------------------------------------------------------------------------------
        // Menu Bar Utils
        // --------------------------------------------------------------------------------------------------

        public void SetMenuBarActive(bool InActive)
        {
            if (!InActive && m_MenuBarActive)
            {
                MenuPanel.Visible = false;
                CollapseMenu();

                foreach (Control control in MenuPanel.Controls)
                {
                    control.Visible = false;
                }

                m_MenuBarActive = false;
            }
            else if (!m_MenuBarActive)
            {
                MenuPanel.Visible = true;
                
                foreach (Control control in MenuPanel.Controls)
                {
                    control.Visible = true;
                }

                m_MenuBarActive = true;
                CollapseMenu();
            }
        }

        public void CollapseMenu()
        {
            MenuPanel.Width = 100;
            LogoLable.Visible = false;
            MenuButton.Dock = DockStyle.Top;
            foreach (MenuButton menuButton in MenuPanel.Controls.OfType<MenuButton>())
            {
                if (menuButton.Equals(MenuButton)) continue;

                menuButton.Collapse();
            }

            m_MenuCollapsed = true;
        }

        public void ExpandMenu()
        {
            MenuPanel.Width = m_InitialMenuWidth;
            LogoLable.Visible = true;
            MenuButton.Dock = DockStyle.None;
            foreach (MenuButton menuButton in MenuPanel.Controls.OfType<MenuButton>())
            {
                if (menuButton.Equals(MenuButton)) continue;

                menuButton.Expand();
            }

            m_MenuCollapsed = false;
        }

        // --------------------------------------------------------------------------------------------------
        // Theme
        // --------------------------------------------------------------------------------------------------

        public override void ApplyTheme(Theme InTheme)
        {
            base.ApplyTheme(InTheme);

            this.BackColor = InTheme.Border;
            MenuButton.BackColor = InTheme.Surface;
            LogoLable.BackColor = InTheme.Surface;

            HomeMenuButton.NormalColor = InTheme.Surface;
            HomeMenuButton.IconColor = InTheme.SoulAccent;
            HomeMenuButton.ForeColor = InTheme.SoulAccent;
            HomeMenuButton.ActiveIndicatorColor = InTheme.SoulAccent;
            HomeMenuButton.ActiveColor = InTheme.Active;

            CalendarMenuButton.NormalColor = InTheme.Surface; ;
            CalendarMenuButton.IconColor = InTheme.Compliment;
            CalendarMenuButton.ForeColor = InTheme.Compliment;
            CalendarMenuButton.ActiveIndicatorColor = InTheme.Compliment;
            CalendarMenuButton.ActiveColor = InTheme.Active;

            SubscriptionMenuButton.NormalColor = InTheme.Surface;
            SubscriptionMenuButton.IconColor = InTheme.Sibling;
            SubscriptionMenuButton.ForeColor = InTheme.Sibling;
            SubscriptionMenuButton.ActiveIndicatorColor = InTheme.Sibling;
            SubscriptionMenuButton.ActiveColor = InTheme.Active;

            GoalsMenuButton.NormalColor = InTheme.Surface;
            GoalsMenuButton.IconColor = InTheme.Accent;
            GoalsMenuButton.ForeColor = InTheme.Accent;
            GoalsMenuButton.ActiveIndicatorColor = InTheme.Accent;
            GoalsMenuButton.ActiveColor = InTheme.Active;

            IncomeMenuButton.NormalColor = InTheme.Surface;
            IncomeMenuButton.IconColor = InTheme.TwinCompliment;
            IncomeMenuButton.ForeColor = InTheme.TwinCompliment;
            IncomeMenuButton.ActiveIndicatorColor = InTheme.TwinCompliment;
            IncomeMenuButton.ActiveColor = InTheme.Active;

            CardMenuButton.NormalColor = InTheme.Surface;
            CardMenuButton.IconColor = InTheme.Extra;
            CardMenuButton.ForeColor = InTheme.Extra;
            CardMenuButton.ActiveIndicatorColor = InTheme.Extra;
            CardMenuButton.ActiveColor = InTheme.Active;

            ExpensesMenuButton.NormalColor = InTheme.Surface;
            ExpensesMenuButton.IconColor = InTheme.Accent;
            ExpensesMenuButton.ForeColor = InTheme.Accent;
            ExpensesMenuButton.ActiveIndicatorColor = InTheme.Accent;
            ExpensesMenuButton.ActiveColor = InTheme.Active;

            ThemeMenuButton.NormalColor = InTheme.Surface;
            ThemeMenuButton.IconColor = InTheme.TwinCompliment;
            ThemeMenuButton.ForeColor = InTheme.TwinCompliment;
            ThemeMenuButton.ActiveIndicatorColor = InTheme.TwinCompliment;
            ThemeMenuButton.ActiveColor = InTheme.Active;

            MenuPanel.BackColor = InTheme.Surface;
            TitleBarPanel.BackColor = InTheme.Background;


            SetTitleButtonTint(ColorUtils.GetContrastColor(InTheme.Background));
        }
    }
}
