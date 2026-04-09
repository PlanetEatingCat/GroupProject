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
    public partial class EditSubscriptionForm : Form
    {
        private readonly SessionManager m_SessionManager;

        public EditSubscriptionForm(SessionManager InSessionManager)
        {
            InitializeComponent();

            m_SessionManager = InSessionManager;
        }

        private void EditConfirm_Click(object sender, EventArgs e)
        {
            if (SubName.Text == "")
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }

            if (FreqDropDown.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid frequency from the drop down.");
                return;
            }

            string tempFrequency = FreqDropDown.SelectedItem.ToString();
            var frequency = Profile.CheckFrequency(tempFrequency);

            int amountOwed = 0;

            if (int.TryParse(OwedAmount.Text, out var amount) && amount > 0)
            {
                amountOwed = amount;
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            bool found = m_SessionManager.GetActiveProfile().EditSubscription(SubName.Text.ToString(), frequency, amountOwed);

            if (found)
            {
                MessageBox.Show("Subscription edited successfully.");
                SubscriptionManagerForm.instance.FixList();
            }
            else
            {
                MessageBox.Show("No subscription with that name on profile.");
            }

            this.Close();
        }
    }
}
