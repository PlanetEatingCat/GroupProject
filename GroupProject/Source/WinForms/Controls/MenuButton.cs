/********************************************
Name: MenuButton.cs
Purpose: A special button with an icon and active indicator 
Notes: 
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing.Drawing2D;


namespace BudgetPlanner
{
    public partial class MenuButton : UserControl
    {
        //-----------------------------------------------------------------------------------------------
        // Variables
        //-----------------------------------------------------------------------------------------------

        private bool m_Active = false;
        private bool m_Expanded = true;
        private Color m_ActiveIndicatorColor = Color.White;
        private Color m_ActiveColor = Color.Blue;
        private Color m_NormalColor = Color.Blue;
        private string m_Text = "";

        //-----------------------------------------------------------------------------------------------
        // Properties needed to work with WinForms
        //-----------------------------------------------------------------------------------------------

        public bool Active
        {
            get => m_Active;
            set => SetActive(value);
        }

        public IconChar IconChar
        {
            get => MenuIconButton.IconChar;
            set => MenuIconButton.IconChar = value;
        }

        public Color IconColor
        {
            get => MenuIconButton.IconColor;
            set => MenuIconButton.IconColor = value;
        }

        public Color ActiveIndicatorColor
        {
            get => m_ActiveIndicatorColor;
            set
            {
                m_ActiveIndicatorColor = value;
                if (m_Active)
                {
                    ActiveImageBox.BackColor = m_ActiveIndicatorColor;
                }
            }
        }

        public Color ActiveColor
        {
            get => m_ActiveColor;
            set
            {
                m_ActiveColor = value;
                if (m_Active)
                {
                    BackColor = m_ActiveColor;
                }
            }
        }

        public Color NormalColor
        {
            get => m_NormalColor;
            set
            {
                m_NormalColor = value;
                if (!m_Active)
                {
                    BackColor = m_NormalColor;
                }
            }
        }

        public string Label
        {
            get => m_Text;
            set
            {
                m_Text = value;
                if (m_Expanded)
                {
                    MenuIconButton.Text = m_Text;
                }
            }
        }

        //-----------------------------------------------------------------------------------------------
        // Main Control
        //-----------------------------------------------------------------------------------------------

        public MenuButton()
        {
            InitializeComponent();

            // Forward clicks from all child controls
            foreach (Control control in Controls)
            {
                WireClick(control);
            }

            m_Text = MenuIconButton.Text;
            SetActive(false);
        }

        //-----------------------------------------------------------------------------------------------
        // Utils
        //-----------------------------------------------------------------------------------------------

        public void SetActive(bool InActive)
        {
            m_Active = InActive;
            ActiveImageBox.BackColor = InActive ? m_ActiveIndicatorColor : Color.Transparent;
            BackColor = InActive ? m_ActiveColor : m_NormalColor;
        }

        public void Collapse()
        {
            MenuIconButton.Text = "";
            MenuIconButton.ImageAlign = ContentAlignment.MiddleCenter;
            MenuIconButton.Padding = new Padding(0);
        }

        public void Expand()
        {
            MenuIconButton.Text = "   " + m_Text;
            MenuIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            MenuIconButton.Padding = new Padding(10, 0, 0, 0);
        }

        private void WireClick(Control InControl)
        {
            InControl.Click += (s, e) => OnClick(e);

            foreach (Control child in InControl.Controls)
            {
                WireClick(child);
            }
        }

        //-----------------------------------------------------------------------------------------------
        // Events
        //-----------------------------------------------------------------------------------------------

        protected override void OnBackColorChanged(EventArgs InEventArgs)
        {
            base.OnBackColorChanged(InEventArgs);
            MenuIconButton.BackColor = this.BackColor;
        }

        private void MenuButton_Paint(object sender, PaintEventArgs e)
        {
           /* using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.LightBlue,
                Color.DarkBlue,
                0F))
                    {
                        e.Graphics.FillRectangle(brush, this.ClientRectangle);
                    }*/

        }
    }
}
