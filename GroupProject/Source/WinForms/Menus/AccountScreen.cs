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

namespace GroupProject.Source.WinForms.Menus
{
    public partial class AccountScreen : UserControl
    {
        private readonly EventDispatcher m_EventDispatcher;
        private readonly MainForm m_MainForm;

        public AccountScreen(EventDispatcher InEventDispatcher, MainForm InMainForm, ThemeManager InThemeManager, 
            AccountTitle InAccountTitle, ScreenTitle InScreenTitle)
        {
            InitializeComponent();

            m_EventDispatcher = InEventDispatcher;
            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);
            ApplyTheme(InThemeManager.GetCurrentTheme());


            m_MainForm = InMainForm;
            m_MainForm.SetMenuBarActive(true);


            var rightMenuBar = InAccountTitle;
            var leftMenuBar = InScreenTitle;

            m_MainForm.SetRightMenuBar(rightMenuBar);
            m_MainForm.SetLeftMenuBar(leftMenuBar);

            leftMenuBar.SetIcon(MenuIcons.Account);
            leftMenuBar.SetText("Account Settings");
        }

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
        }

        public void ApplyTheme(Theme InTheme)
        {
            AccountIcon.IconColor = InTheme.Accent;
            AccountIcon.BackColor = InTheme.Surface;
            BackPanel.BackColor = InTheme.Surface;
        }
    }
}
