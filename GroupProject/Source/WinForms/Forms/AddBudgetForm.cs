/********************************************
Name: AddBudgetForm.cs
Purpose: Add Budgets
Notes: Authored by Daniel.
********************************************/

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
    public partial class AddBudgetForm : ModernForm
    {
        private readonly SessionManager m_SessionManager;
        private readonly DashboardScreen m_DashboardScreen;
        private readonly EventDispatcher m_EventDispatcher;


        public AddBudgetForm(SessionManager InSessionManager, DashboardScreen InDashboardScreen, EventDispatcher InEventDispatcher, ThemeManager InThemeManager)
        {
            InitializeComponent();
            m_SessionManager = InSessionManager;
            m_DashboardScreen = InDashboardScreen;

            ApplyTheme(InThemeManager.GetCurrentTheme());

            m_EventDispatcher = InEventDispatcher;

            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);
        }

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(NameInput.Text == "") 
            {
                MessageBox.Show("Please enter a name");
                return;
            }

            if (CategoryInput.Text == "")
            {
                MessageBox.Show("Please enter a category");
                return;
            }

            decimal maxSpentAmount = 0;
            if (decimal.TryParse(LimitInput.Text, out var OutAmount) && OutAmount > 0)
            {
                maxSpentAmount = OutAmount;
            }
            else
            {
                MessageBox.Show("Please enter a valid spending amount.");
                return;
            }

            var budget = new Budget(NameInput.Text, CategoryInput.Text, maxSpentAmount, 0);
            m_SessionManager.GetActiveProfile().AddBudget(budget);

            m_DashboardScreen.UpdateBudgetPanel();

            this.Close();
        }

        public override void ApplyTheme(Theme InTheme)
        {
            this.BackColor = InTheme.Background;

            BaseMainPanel.BackColor = InTheme.Background;
            TitleBarPanel.BackColor = InTheme.Surface;
            RightMenuBarPanel.BackColor = InTheme.Surface;
            MinButton.BackColor = InTheme.Surface;
            MaxButton.BackColor = InTheme.Surface;
            CloseButton.BackColor = InTheme.Surface;

            NameInput.BackColor = InTheme.Box;
            NameInput.ForeColor = InTheme.Text;

            DoneButton.BackColor = InTheme.Accent;
            DoneButton.ForeColor = Color.White;

            label3.BackColor = InTheme.Background;
            label3.ForeColor = InTheme.Text;

            Title.BackColor = InTheme.Surface;
            Title.ForeColor = InTheme.Text;

            LimitInput.BackColor = InTheme.Box;
            LimitInput.ForeColor = InTheme.Text;

            label2.BackColor = InTheme.Background;
            label2.ForeColor = InTheme.Text;

            CategoryInput.BackColor = InTheme.Box;
            CategoryInput.ForeColor = InTheme.Text;

            label1.BackColor = InTheme.Background;
            label1.ForeColor = InTheme.Text;

        }
    }
 }
