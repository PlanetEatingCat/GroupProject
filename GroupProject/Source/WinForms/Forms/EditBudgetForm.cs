/********************************************
Name: EditBudgetForm.cs
Purpose: Editing budget
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
    public partial class EditBudgetForm : ModernForm
    {
        private readonly SessionManager m_SessionManager;
        private readonly BudgetEdit m_BudgetEdit;
        private readonly DashboardScreen m_DashboardScreen;
        private readonly EventDispatcher m_EventDispatcher;

        public EditBudgetForm(SessionManager InSessionManager, BudgetEdit InBudgetEdit, 
            DashboardScreen InDashboardScreen, EventDispatcher InEventDispatcher, ThemeManager InThemeManager)
        {
            InitializeComponent();
            m_SessionManager = InSessionManager;
            m_BudgetEdit = InBudgetEdit;
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

            m_SessionManager.GetActiveProfile().EditBudget(m_BudgetEdit.GetName(), NameInput.Text, CategoryInput.Text, maxSpentAmount);
            m_DashboardScreen.UpdateBudgetPanel();
            m_DashboardScreen.UpdateTransactionPanel();


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

            Title.BackColor = InTheme.Surface;
            Title.ForeColor = InTheme.Text;

            label3.BackColor = InTheme.Background;
            label3.ForeColor = InTheme.Text;

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
