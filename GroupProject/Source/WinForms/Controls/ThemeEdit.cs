/********************************************
Name: ThemeEdit.cs
Purpose: A special control for editing the theme
Notes:
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
    public partial class ThemeEdit : UserControl
    {
        //-----------------------------------------------------------------------------------------------
        // Callbacks & Variables
        //-----------------------------------------------------------------------------------------------
        public Action<ThemeEdit> OnUpdate;
        private ThemeColorElement m_DarkmodeElement;

        //-----------------------------------------------------------------------------------------------
        // Properties for Winforms
        //-----------------------------------------------------------------------------------------------
        public string ThemeLabel
        {
            get => ThemeColorLabel.Text;
            set => ThemeColorLabel.Text = value;
        }

        public ThemeColorElement DarkModeElement
        {
            get => m_DarkmodeElement;
            set
            {
                m_DarkmodeElement = value;

                if (!DesignMode)
                {
                    Reset();
                }
            }
        }

        //-----------------------------------------------------------------------------------------------
        // Main Control
        //-----------------------------------------------------------------------------------------------

        public ThemeEdit()
        {
            InitializeComponent();

            foreach (Control control in Controls)
                WireClick(control);
        }

        //-----------------------------------------------------------------------------------------------
        // Sub Controls
        //-----------------------------------------------------------------------------------------------

        private void ColorSelectButton_Click(object InSender, EventArgs InEventArgs)
        {
            if (ColorSelect.ShowDialog() == DialogResult.OK)
            {
                // Set current color
                CurrentColorPanel.BackColor = ColorSelect.Color;

                // Update button color and numeric slider values
                ColorSelectButton.BackColor = ColorSelect.Color;
                ThemeColorLabel.ForeColor = GetContrastColor(ColorSelect.Color);
                ColorSelectButton.IconColor = GetContrastColor(ColorSelect.Color);

                OnUpdate?.Invoke(this);
            }
        }

        //-----------------------------------------------------------------------------------------------
        // Utils
        //-----------------------------------------------------------------------------------------------

        public void Reset()
        {
            DarkModeColorPanel.BackColor = DarkModeColorFromElement(m_DarkmodeElement);
            DarkModeLabel.ForeColor = GetContrastColor(DarkModeColorPanel.BackColor);

            SetColor(DarkModeColorPanel.BackColor);
        }

        public void SetColor(Color InColor)
        {
            CurrentColorPanel.BackColor = InColor;
            ThemeColorLabel.ForeColor = GetContrastColor(InColor);
            ColorSelectButton.IconColor = GetContrastColor(InColor);
            ColorSelectButton.BackColor = InColor;
        }

        public Color GetColor()
        {
            return CurrentColorPanel.BackColor;
        }

        //-----------------------------------------------------------------------------------------------
        // Private Utils
        //-----------------------------------------------------------------------------------------------

        private static Color GetContrastColor(Color InBackground)
        {
            int brightness = (int)((InBackground.R * 0.299) + (InBackground.G * 0.587) + (InBackground.B * 0.114));

            return brightness > 128 ? Color.Black : Color.White;
        }

        private void WireClick(Control InControl)
        {
            InControl.Click += (s, e) => OnClick(e);

            foreach (Control child in InControl.Controls)
            {
                WireClick(child);
            }
        }

        private Color DarkModeColorFromElement(ThemeColorElement InElement)
        {
            switch (InElement)
            {
                case ThemeColorElement.Background: return Themes.Dark.Background;
                case ThemeColorElement.Surface: return Themes.Dark.Surface;
                case ThemeColorElement.Accent: return Themes.Dark.Accent;
                case ThemeColorElement.Compliment: return Themes.Dark.Compliment;
                case ThemeColorElement.TwinCompliment: return Themes.Dark.TwinCompliment;
                case ThemeColorElement.Sibling: return Themes.Dark.Sibling;
                case ThemeColorElement.Extra: return Themes.Dark.Extra;
                case ThemeColorElement.SoulAccent: return Themes.Dark.SoulAccent;
                case ThemeColorElement.Border: return Themes.Dark.Border;
                case ThemeColorElement.Active: return Themes.Dark.Active;
            }

            return Color.White;
        }
    }
}
