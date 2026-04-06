using BudgetPlanner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetPlanner
{
    public partial class RemoveSubscription : Form
    {
        private readonly SessionManager m_SessionManager; 

        public RemoveSubscription(SessionManager InSessionManager)
        {
            InitializeComponent();

            m_SessionManager = InSessionManager;
        }

        private void ConfirmRemove_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(SubRemoveText.Text.ToString().ToLower().TrimEnd());
            bool found = m_SessionManager.GetActiveProfile().DeleteSubscription(SubRemoveText.Text.ToString().ToLower().TrimEnd());

            if (found)
            {
                MessageBox.Show("Subscription removed successfully.");
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
