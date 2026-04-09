/********************************************
Name: LeftMenuBar.cs
Purpose: Menu bar in the left of the title bar
Notes: Work in Progress.
********************************************/
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Management;

namespace BudgetPlanner
{
    public partial class ScreenTitle : UserControl
    {
        private readonly EventDispatcher m_EventDispatcher;

        public ScreenTitle(EventDispatcher InEventDispatcher, ThemeManager InThemeManager)
        {
            InitializeComponent();

            HomeMenuButton.FlatAppearance.MouseOverBackColor = HomeMenuButton.BackColor;
            HomeMenuButton.FlatAppearance.MouseDownBackColor = HomeMenuButton.BackColor;

            ApplyTheme(InThemeManager.GetCurrentTheme());

            m_EventDispatcher = InEventDispatcher;

            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);
        }

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
        }

        public void SetIcon(IconChar InChar)
        {
            HomeMenuButton.IconChar = InChar;
        }

        public void SetText(string InText)
        {
            HomeMenuButton.Text = InText;
        }

        private void HomeMenuButton_Click(object sender, EventArgs e)
        {

        }

        public void ApplyTheme(Theme InTheme)
        {
            HomeMenuButton.IconColor = ColorUtils.GetContrastColor(InTheme.Background);
            HomeMenuButton.ForeColor = ColorUtils.GetContrastColor(InTheme.Background);
        }
    }
}
