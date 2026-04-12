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

namespace BudgetPlanner { 
    public partial class BudgetEdit : UserControl
    {
        private readonly SessionManager m_SessionManager;
        private readonly DashboardScreen m_DashboardScreen;
        private readonly EventDispatcher m_EventDispatcher;
        private readonly ThemeManager m_ThemeManager;

        private decimal m_CurrentValue = 0;
        private decimal m_MaxValue = 100;


        public decimal CurrentValue 
        {
            get { return m_CurrentValue; }
            set { SetValue(value);  }
        
        }

        public BudgetEdit(SessionManager InSessionManager, DashboardScreen InDashboardScreen, EventDispatcher InEventDispatcher, ThemeManager InThemeManager)
        {
            InitializeComponent();

            m_SessionManager = InSessionManager;
            m_DashboardScreen = InDashboardScreen;
            m_ThemeManager = InThemeManager;
            m_EventDispatcher = InEventDispatcher;
        }



        public void SetValue(decimal InValue)
        {
            decimal fillRatio = InValue / m_MaxValue;
            int fillPanelWidth = (int)(fillRatio * SpentPanelBackground.Width);

            SpentPanelFill.Dock = DockStyle.None;
            SpentPanelFill.Width = fillPanelWidth;
            SpentPanelFill.Dock = DockStyle.Left;

            m_CurrentValue = InValue;

            decimal diff = m_MaxValue - m_CurrentValue;

            if(diff > 0)
            {
                AmountInfoLabel.Text = $"${diff} Left";
            }
            else if(diff == 0)
            {
                AmountInfoLabel.Text = $"Spent";
            }
            else 
            {
                AmountInfoLabel.Text = $"-${Math.Abs(diff)} Over";
            }

            ProgressLabel.Text = $"{m_CurrentValue} / {m_MaxValue}";
        }

        public void SetMaxValue(decimal InMaxValue)
        {
            m_MaxValue = InMaxValue;
            SetValue(m_CurrentValue);
        }

        public void SetName(string InName)
        {
            NameLabel.Text = InName;
        }

        public string GetName()
        {
            return NameLabel.Text;
        }

        public void UpdateTheme(Theme InTheme)
        {
            SpentPanelBackground.BackColor = InTheme.Box;
            SpentPanelFill.BackColor = InTheme.Accent;
            HeaderPanel.BackColor = InTheme.Surface;

            AmountInfoLabel.BackColor = InTheme.Surface;
            AmountInfoLabel.ForeColor = Color.White;

            ProgressLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            ProgressLabel.ForeColor = Color.White;

            NameLabel.BackColor = InTheme.Surface;
            NameLabel.ForeColor = Color.White;

            EditButton.BackColor = InTheme.Surface;
            EditButton.IconColor = Color.White;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var editForm = new EditBudgetForm(m_SessionManager, this, m_DashboardScreen, m_EventDispatcher, m_ThemeManager);
            editForm.ShowDialog();
        }
    }
}
