/********************************************
Name: RemoveSubscription.cs
Purpose: Interface for removing subscriptions
Notes: Authored by Kiefer.
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
    public partial class RemoveSubscriptionForm : ModernForm
    {
        private readonly SessionManager m_SessionManager;

        //-----------------------------------------------------------------------------------------------
        // Form
        //-----------------------------------------------------------------------------------------------

        public RemoveSubscriptionForm(SessionManager InSessionManager)
        {
            InitializeComponent();
            m_SessionManager = InSessionManager;
        }

        //-----------------------------------------------------------------------------------------------
        // Controls
        //-----------------------------------------------------------------------------------------------

        private void ConfirmRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SubRemoveText.Text.ToString().ToLower().TrimEnd());
            bool found = m_SessionManager.GetActiveProfile().DeleteSubscription(SubRemoveText.Text.ToString().ToLower().TrimEnd());

            if (found)
            {
                MessageBox.Show("Subscription removed successfully.");
                SubscriptionScreen.Instance.FixList();
            }
            else
            {
                MessageBox.Show("No subscription with that name on profile.");
            }
        }
    }
}
