/********************************************
Name: ThemeScreen.cs
Purpose: Create, select, and edit themes
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
    public partial class ThemeScreen : UserControl
    {
        private readonly ThemeManager m_ThemeManager;
        //-----------------------------------------------------------------------------------------------
        // Variables
        //-----------------------------------------------------------------------------------------------

        private MenuButton m_ActiveThemeButton;

        //-----------------------------------------------------------------------------------------------
        // Screen
        //-----------------------------------------------------------------------------------------------

        public ThemeScreen(ThemeManager InThemeManager, MainForm InMainForm,
            AccountTitle InAccountTitle, ScreenTitle InScreenTitle)
        {
            InitializeComponent();

            m_ThemeManager = InThemeManager;

            InMainForm.SetRightMenuBar(InAccountTitle);
            InMainForm.SetLeftMenuBar(InScreenTitle);

            InScreenTitle.SetIcon(MenuIcons.Theme);
            InScreenTitle.SetText("Themes");

            foreach(var theme in m_ThemeManager.GetThemes())
            {
                var btn = new MenuButton();
                btn.Label = theme.Name;
                btn.Margin = new Padding(0);
              //  btn.Size = DarkThemeButton.Size;
                btn.NormalColor = SystemColors.ControlDark;
                btn.ActiveColor = SystemColors.ActiveBorder;
                btn.ActiveIndicatorColor = theme.Accent;
                btn.IconChar = FontAwesome.Sharp.IconChar.Pencil;
                btn.Click += (s, e) =>
                {
                    SetActiveTheme(btn);
                };

                flowLayoutPanel1.Controls.Add(btn);

                if(theme == m_ThemeManager.GetCurrentTheme())
                {
                    SetActiveTheme(btn);
                }
            }


            BackgroundEdit.OnUpdate += UpdateTheme;
            SurfaceEdit.OnUpdate += UpdateTheme;
            AccentEdit.OnUpdate += UpdateTheme;
            SiblingEdit.OnUpdate += UpdateTheme;
            TwinComplimentEdit.OnUpdate += UpdateTheme;
            SoulAccentEdit.OnUpdate += UpdateTheme;
            ExtraEdit.OnUpdate += UpdateTheme;
            ActiveEdit.OnUpdate += UpdateTheme;
            BorderEdit.OnUpdate += UpdateTheme;
        }

        //-----------------------------------------------------------------------------------------------
        // Controls: default themes & create new theme
        //-----------------------------------------------------------------------------------------------

        private void CreateThemeButton_Click(object sender, EventArgs e)
        {
            var btn = new MenuButton();
            btn.Label = "New Theme";
            btn.Margin = new Padding(0);
            btn.NormalColor = SystemColors.ControlDark;
            btn.ActiveColor = SystemColors.ActiveBorder;
            btn.ActiveIndicatorColor = Themes.Dark.Accent;
            btn.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btn.Click += (s, e) =>
            {
                SetActiveTheme(btn);
            };


            Theme theme = Themes.Dark.Clone();
            theme.Name = "New Theme";

            uint themeIndex = 1;
            while (m_ThemeManager.ThemeExist(theme.Name))
            {
                theme.Name = $"{btn.Label} {themeIndex}";
                themeIndex++;
            }

            m_ThemeManager.AddTheme(theme);
            btn.Label = theme.Name;

            flowLayoutPanel1.Controls.Add(btn);

        }

        //-----------------------------------------------------------------------------------------------
        // private Utils
        //-----------------------------------------------------------------------------------------------

        private void SetActiveTheme(MenuButton InMenuButton)
        {
            m_ActiveThemeButton?.SetActive(false);
            m_ActiveThemeButton = InMenuButton;
            InMenuButton.SetActive(true);

            m_ThemeManager.SetTheme(InMenuButton.Label);

            NameInput.Text = InMenuButton.Label;

            //ScreenManager.ApplyTheme();

            ResetThemeEditors();
        }

        private void UpdateTheme(ThemeEdit InThemeEdit)
        {
            Theme theme = m_ThemeManager.GetCurrentTheme();


            switch (InThemeEdit.DarkModeElement)
            {
                case ThemeColorElement.Background: theme.Background = InThemeEdit.GetColor(); break;
                case ThemeColorElement.Surface: theme.Surface = InThemeEdit.GetColor(); break;
                case ThemeColorElement.Accent: theme.Accent = InThemeEdit.GetColor(); break;
                case ThemeColorElement.Compliment: theme.Compliment = InThemeEdit.GetColor(); break;
                case ThemeColorElement.TwinCompliment: theme.TwinCompliment = InThemeEdit.GetColor(); break;
                case ThemeColorElement.Sibling: theme.Sibling = InThemeEdit.GetColor(); break;
                case ThemeColorElement.Extra: theme.Extra = InThemeEdit.GetColor(); break;
                case ThemeColorElement.SoulAccent: theme.SoulAccent = InThemeEdit.GetColor(); break;
                case ThemeColorElement.Border: theme.Border = InThemeEdit.GetColor(); break;
                case ThemeColorElement.Active: theme.Active = InThemeEdit.GetColor(); break;
            }

            m_ActiveThemeButton.ActiveIndicatorColor = theme.Accent;

            m_ThemeManager.ApplyTheme();
        }

        private void ResetThemeEditors()
        {
            Theme theme = m_ThemeManager.GetCurrentTheme();

            BackgroundEdit.SetColor(theme.Background);
            SurfaceEdit.SetColor(theme.Surface);
            AccentEdit.SetColor(theme.Accent);
            SiblingEdit.SetColor(theme.Sibling);
            TwinComplimentEdit.SetColor(theme.TwinCompliment);
            SoulAccentEdit.SetColor(theme.SoulAccent);
            ExtraEdit.SetColor(theme.Extra);
            ActiveEdit.SetColor(theme.Active);
            BorderEdit.SetColor(theme.Border);
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            Theme theme = m_ThemeManager.GetCurrentTheme();
            theme.Name = NameInput.Text;

            m_ActiveThemeButton.Label = theme.Name;
        }


    }
}
