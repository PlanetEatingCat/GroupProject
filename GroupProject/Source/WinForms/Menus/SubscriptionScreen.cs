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
        private readonly EventDispatcher m_EventDispatcher;
        private readonly ThemeManager m_ThemeManager;

        public static SubscriptionScreen instance;

        //-----------------------------------------------------------------------------------------------
        // Screen
        //-----------------------------------------------------------------------------------------------

        public SubscriptionScreen(SessionManager InSessionManager, MainForm InMainForm,
            AccountTitle InAccountTitle, ScreenTitle InScreenTitle, EventDispatcher InEventDispatcher,
            ThemeManager InThemeManager)
        {
            instance = this;

            InitializeComponent();
            instance = this;

            m_SessionManager = InSessionManager;
            m_EventDispatcher = InEventDispatcher;
            m_ThemeManager = InThemeManager;

            ApplyTheme(InThemeManager.GetCurrentTheme());
            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);



            FixList();

            if (ListOfSubscriptions.Items.Count != 0)
            {
                SubscriptionRemover.Enabled = true;
                EditSubscription.Enabled = true;
            }
            else
            {
                SubscriptionRemover.Enabled = false;
                EditSubscription.Enabled = false;
            }

            InMainForm.SetRightMenuBar(InAccountTitle);
            InMainForm.SetLeftMenuBar(InScreenTitle);

            InScreenTitle.SetIcon(MenuIcons.Subscriptions);
            InScreenTitle.SetText("Subscriptions");
        }

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
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

            Subscription newSub = new Subscription(frequency, amountOwed, SubscriptionName.Text, TypeComboBox.Text);
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
            SubscriptionRemover.Enabled = false;
            EditSubscription.Enabled = false;
        }

        private void EditSubscription_Click(object sender, EventArgs e)
        {
            EditSubscriptionForm editForm = new EditSubscriptionForm(m_SessionManager);
            editForm.Show();
            EditSubscription.Enabled = false;
            SubscriptionRemover.Enabled = false;
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

        public int GetListCount()
        {
            EditSubscriptionForm editForm = new EditSubscriptionForm(m_SessionManager, m_EventDispatcher, m_ThemeManager);
            editForm.Show();
            return ListOfSubscriptions.Items.Count;
        }

        public Button GetSubscriptionRemover()
        {
            return SubscriptionRemover;
        }

        public Button GetEditSubscription()
        {
            return EditSubscription;
        }

        public void ApplyTheme(Theme InTheme)
        {
            this.BackColor = InTheme.Background;

            SubscriptionName.BackColor = InTheme.Box;
            SubscriptionName.ForeColor = Color.White;

            SubscriptionAmount.BackColor = InTheme.Box;
            SubscriptionAmount.ForeColor = Color.White;

            FrequencyDropDown.BackColor = InTheme.Box;
            FrequencyDropDown.ForeColor = Color.White;

            SubscriptionRemover.BackColor = InTheme.Accent;
            SubscriptionRemover.ForeColor = Color.White;

            EditSubscription.BackColor = InTheme.Accent;
            EditSubscription.ForeColor = Color.White;

            AddSubscription.BackColor = InTheme.Accent;
            AddSubscription.ForeColor = Color.White;

            ListOfSubscriptions.BackColor = InTheme.Box;
            ListOfSubscriptions.ForeColor = Color.White;

            ToolsPanel.BackColor = InTheme.Surface;
            TitlePanel.BackColor = InTheme.Surface;

            SubNameLabel.ForeColor = Color.White;
            PayAmount.ForeColor = Color.White;
            PaymentFrequency.ForeColor = Color.White;

            Title.ForeColor = Color.White;

        }

        private void ListOfSubscriptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
