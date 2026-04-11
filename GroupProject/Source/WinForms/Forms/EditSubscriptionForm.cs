using BudgetPlanner;
using LiveChartsCore.Themes;
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
    public partial class EditSubscriptionForm : ModernForm
    {
        private readonly SessionManager m_SessionManager;
        private readonly EventDispatcher m_EventDispatcher;

        public EditSubscriptionForm(SessionManager InSessionManager, EventDispatcher InEventDispatcher, ThemeManager InThemeManager)
        {
            InitializeComponent();

            m_SessionManager = InSessionManager;

            ApplyTheme(InThemeManager.GetCurrentTheme());

            m_EventDispatcher = InEventDispatcher;
            m_SessionManager = InSessionManager;

            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);
        }

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
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

            bool found = m_SessionManager.GetActiveProfile().EditSubscription(SubName.Text.ToString(), "Type", frequency, amountOwed);

            if (found)
            {
                MessageBox.Show("Subscription edited successfully.");
                SubscriptionScreen.instance.FixList();
            }
            else
            {
                MessageBox.Show("No subscription with that name on profile.");
            }

            this.Close();
        }

        private void EditSubscriptionForm_Load(object sender, EventArgs e)
        {

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

            Name.BackColor = InTheme.Background;
            Name.ForeColor = Color.White;
            Amount.BackColor = InTheme.Background;
            Amount.ForeColor = Color.White;
            Freq.BackColor = InTheme.Background;
            Freq.ForeColor = Color.White;
            TitleLabel.ForeColor = Color.White;

            SubName.BackColor = InTheme.Box;
            SubName.ForeColor = Color.White;

            OwedAmount.BackColor = InTheme.Box;
            OwedAmount.ForeColor = Color.White;

            FreqDropDown.BackColor = InTheme.Box;
            FreqDropDown.ForeColor = Color.White;

            EditConfirm.BackColor = InTheme.Accent;
            EditConfirm.ForeColor = Color.White;
        }

        private void EditSubscriptionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
