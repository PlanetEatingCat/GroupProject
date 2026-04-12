/********************************************
Name: RemoveSubscription.cs
Purpose: Removal of user subscriptions
Notes: WIP by Kiefer.
********************************************/

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
    public partial class RemoveSubscription : ModernForm
    {
        private readonly SessionManager m_SessionManager;
        private readonly EventDispatcher m_EventDispatcher;


        public RemoveSubscription(SessionManager InSessionManager, EventDispatcher InEventDispatcher, ThemeManager InThemeManager)
        {
            InitializeComponent();

            m_SessionManager = InSessionManager;
            ApplyTheme(InThemeManager.GetCurrentTheme());

            m_EventDispatcher = InEventDispatcher;

            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);
        }

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
        }


        private void ConfirmRemove_Click(object sender, EventArgs e)
        {
            bool found = m_SessionManager.GetActiveProfile().DeleteSubscription(SubRemoveText.Text.ToString().ToLower().TrimEnd());

            if (found)
            {
                MessageBox.Show("Subscription removed successfully.");
                SubscriptionScreen.instance.FixList();
            }
            else
            {
                MessageBox.Show("No subscription with that name on profile.");
            }

            this.Close();
        }

        private void RemoveSubscription_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SubscriptionScreen.instance.GetListCount() == 0)
            {
                SubscriptionScreen.instance.GetSubscriptionRemover().Enabled = false;
                SubscriptionScreen.instance.GetEditSubscription().Enabled = false;
            }
            else
            {
                SubscriptionScreen.instance.GetSubscriptionRemover().Enabled = true;
                SubscriptionScreen.instance.GetEditSubscription().Enabled = true;
            }
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

            SubRemoveText.BackColor = InTheme.Box; 
            SubRemoveText.ForeColor = InTheme.Text;  
            ConfirmRemove.BackColor = InTheme.Accent; 
            ConfirmRemove.ForeColor = Color.White; 
            label1.BackColor = InTheme.Surface; 
            label1.ForeColor = InTheme.Text;

       }

    }
}
