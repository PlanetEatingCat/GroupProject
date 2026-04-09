/********************************************
Name: SubscriptionManagerForm.cs
Purpose: Form to display a users subscriptions. Adds subscriptions to a list box and shows users.
Notes: Work in Progress. Authored by Kiefer.
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
using Windows.Media.Control;

namespace BudgetPlanner
{
    public partial class SubscriptionScreen : UserControl
    {
        private readonly SessionManager m_SessionManager;
        public static SubscriptionScreen Instance;

        //-----------------------------------------------------------------------------------------------
        // Screen
        //-----------------------------------------------------------------------------------------------

        public SubscriptionScreen(SessionManager InSessionManager, MainForm InMainForm, 
            AccountTitle InAccountTitle, ScreenTitle InScreenTitle)
        {
            Instance = this;

            InitializeComponent();
<<<<<<< HEAD:GroupProject/Source/WinForms/SubscriptionManagerForm.cs
            SubscriptionRemover.Enabled = false;
            EditSubscription.Enabled = false;
            instance = this;
=======

            m_SessionManager = InSessionManager;

            InMainForm.SetRightMenuBar(InAccountTitle);
            InMainForm.SetLeftMenuBar(InScreenTitle);

            InScreenTitle.SetIcon(MenuIcons.Subscriptions);
            InScreenTitle.SetText("Subscriptions");
>>>>>>> main:GroupProject/Source/WinForms/Menus/SubscriptionScreen.cs
        }

        //-----------------------------------------------------------------------------------------------
        // Controls
        //-----------------------------------------------------------------------------------------------

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

        private void SubscriptionRemover_Click(object sender, EventArgs e)
        {
            var form = new RemoveSubscription(m_SessionManager);
            form.Show();
        }

        //-----------------------------------------------------------------------------------------------
        // Utils
        //-----------------------------------------------------------------------------------------------

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
            EditSubscriptionForm editForm = new EditSubscriptionForm();
            editForm.Show();
        }
    }
}
