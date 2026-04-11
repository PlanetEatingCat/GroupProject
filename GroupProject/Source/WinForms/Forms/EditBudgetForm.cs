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

        public EditBudgetForm(SessionManager InSessionManager, BudgetEdit InBudgetEdit, DashboardScreen InDashboardScreen)
        {
            InitializeComponent();
            m_SessionManager = InSessionManager;
            m_BudgetEdit = InBudgetEdit;
            m_DashboardScreen = InDashboardScreen;
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


            this.Close();
        }
    }
}
