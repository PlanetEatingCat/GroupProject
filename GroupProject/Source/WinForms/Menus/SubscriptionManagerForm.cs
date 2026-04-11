using GroupProject.Source.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Management;

/********************************************
Name: SubscriptionManagerForm.cs
Purpose: Form to display a users subscriptions. Adds subscriptions to a list box and shows users.
Notes: Work in Progress. Authored by Kiefer.
********************************************/
namespace BudgetPlanner
{
    public partial class SubscriptionManagerForm : UserControl
    {

        private readonly SessionManager m_SessionManager;

        public static SubscriptionManagerForm instance { get; private set; }

        public SubscriptionManagerForm(SessionManager InSessionManager)
        {
            InitializeComponent();

            m_SessionManager = InSessionManager;

            FixList();

            //Check list box != null to enable buttons for edit/remove

            SubscriptionRemover.Enabled = false;
            EditSubscription.Enabled = false;
            instance = this;
        }

        //Checks to make sure all values are valid, then creates the subscription object and displays it to the listbox
        private void AddSubscription_Click(object sender, EventArgs e)
        {
            if (SubscriptionName.Text == "")
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }

            if (FrequencyDropDown.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid frequency from the drop down.");
                return;
            }

            string tempFrequency = FrequencyDropDown.SelectedItem.ToString();
            var frequency = Profile.CheckFrequency(tempFrequency);

            int amountOwed = 0;

            if (int.TryParse(SubscriptionAmount.Text, out var amount) && amount > 0)
            {
                amountOwed = amount;
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            Subscription newSub = new Subscription(frequency, amountOwed, SubscriptionName.Text);
            ListOfSubscriptions.Items.Add(Profile.DisplayInfo(newSub));
            m_SessionManager.GetActiveProfile().AddSubscription(newSub);

            if (ListOfSubscriptions.Items.Count > 0)
            {
                SubscriptionRemover.Enabled = true;
                EditSubscription.Enabled = true;
            }
            else
            {
                SubscriptionRemover.Enabled = false;
                EditSubscription.Enabled = false;
            }

            SubscriptionName.Text = "";
            SubscriptionAmount.Text = "";
            FrequencyDropDown.SelectedIndex = -1;
        }

        //Clicked on this by accident, but can't remove it without breaking the code
        private void ListOfSubscriptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubscriptionRemover_Click(object sender, EventArgs e)
        {
            RemoveSubscription removeForm = new RemoveSubscription(m_SessionManager);
            removeForm.Show();
        }

        public void FixList()
        {
            ListOfSubscriptions.Items.Clear();
            foreach (var subscription in m_SessionManager.GetActiveProfile().GetSubscriptions())
            {
                ListOfSubscriptions.Items.Add(Profile.DisplayInfo(subscription));
            }
        }

        private void EditSubscription_Click(object sender, EventArgs e)
        {
            EditSubscriptionForm editForm = new EditSubscriptionForm(m_SessionManager);
            editForm.Show();
        }
    }
}
