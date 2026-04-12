/********************************************
Name: GoalsScreen.cs
Purpose: The goals
Notes: WIP by Kiefer.
********************************************/

using ScottPlot.TickGenerators.TimeUnits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SkiaSharp.HarfBuzz.SKShaper;

namespace BudgetPlanner
{
    public partial class GoalsScreen : UserControl
    {
        private readonly SessionManager m_SessionManager;
        private readonly EventDispatcher m_EventDispatcher;

        protected float goal;
        protected float progToGoal;
        public GoalsScreen(MainForm InMainForm, AccountTitle InAccountTitle, ScreenTitle InScreenTitle, SessionManager InSessionManager,
               ThemeManager InThemeManager, EventDispatcher InEventDispatcher)
        {
            InitializeComponent();
            m_SessionManager = InSessionManager;

            ApplyTheme(InThemeManager.GetCurrentTheme());

            m_EventDispatcher = InEventDispatcher;
            m_SessionManager = InSessionManager;

            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);


            goal = m_SessionManager.GetActiveProfile().GetGoalAmount();
            progToGoal = m_SessionManager.GetActiveProfile().GetProgToGoal();

            if (goal != 0)
            {
                AmountToAdd.Enabled = true;
                ConfirmAddBtn.Enabled = true;

                GoalAmountEntry.Enabled = false;
                ConfirmButton.Enabled = false;

                SavingsGoalAmount.Text = $"Goal Amount: {goal}";
                ProgressAmount.Text = $"Progress Amount: {progToGoal}";

                if (m_SessionManager.GetActiveProfile().GetProgBarValue() > 0)
                {
                    SavingsGoalBar.Value = m_SessionManager.GetActiveProfile().GetProgBarValue();
                }
            }
            else
            {
                AmountToAdd.Enabled = false;
                ConfirmAddBtn.Enabled = false;

                GoalAmountEntry.Enabled = true;
                ConfirmButton.Enabled = true;
            }

            InMainForm.SetRightMenuBar(InAccountTitle);
            InMainForm.SetLeftMenuBar(InScreenTitle);

            InScreenTitle.SetIcon(MenuIcons.Goals);
            InScreenTitle.SetText("Goals");
        }

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            float result;

            //Checks input to make sure it is a valid number to save up to 
            if (float.TryParse(GoalAmountEntry.Text, out result) == false)
            {
                MessageBox.Show("Must input a valid amount.");
                GoalAmountEntry.Text = "";
                return;
            }

            if (result <= 0)
            {
                MessageBox.Show("Must input a valid amount.");
                GoalAmountEntry.Text = "";
                return;
            }

            ProgressAmount.Text = $"Progress Amount: 0";
            SavingsGoalAmount.Text = $"Goal Amount: {result}";
            ConfirmButton.Enabled = false;
            GoalAmountEntry.Text = "";
            GoalAmountEntry.Enabled = false;
            AmountToAdd.Enabled = true;
            ConfirmAddBtn.Enabled = true;
            goal = result;

            m_SessionManager.GetActiveProfile().SetGoalAmount(goal);
            m_SessionManager.GetActiveProfile().SetProgToGoal(0);
        }

        //Added by mistake, ignore
        private void GoalAmount_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmAddBtn_Click(object sender, EventArgs e)
        {
            //Amount user is contributing to goal
            float addResult;
            //Amount to increment bar
            float amountToAdd;

            //Input validation
            if (AmountToAdd.Text == "")
            {
                MessageBox.Show("Must input a valid number.");
                return;
            }

            while (float.TryParse(AmountToAdd.Text.ToString(), out addResult) == false)
            {
                MessageBox.Show("Must input a valid number.");
                AmountToAdd.Text = "";
                return;
            }

            if (addResult <= 0)
            {
                MessageBox.Show("Cannot contribute 0/negative amount towards goal.");
                AmountToAdd.Text = "";
                return;
            }

            //Math to increment progress bar
            amountToAdd = (addResult / goal) * 100;
            progToGoal += addResult;
            ProgressAmount.Text = $"Progress Amount: ${progToGoal}";

            m_SessionManager.GetActiveProfile().SetProgToGoal(progToGoal);

            if (amountToAdd >= 100)
            {
                GoalReached();
            }
            else if (amountToAdd < 100)
            {
                if (SavingsGoalBar.Value + amountToAdd >= 100)
                {
                    GoalReached();
                }
                else
                {
                    SavingsGoalBar.Value += (int)amountToAdd;
                    m_SessionManager.GetActiveProfile().SetProgBarValue(SavingsGoalBar.Value);
                }
            }
        }

        //Handles what should happen when goal is reached by the user
        public void GoalReached()
        {
            SavingsGoalBar.Value = 100;
            MessageBox.Show("Congratulations! Goal Reached!");
            SavingsGoalBar.Value = 0;
            ConfirmButton.Enabled = true;
            GoalAmountEntry.Enabled = true;
            ProgressAmount.Text = $"Progress Amount: $0";
            SavingsGoalAmount.Text = $"Goal Amount: ";
            AmountToAdd.Text = "";
            AmountToAdd.Enabled = false;
            ConfirmAddBtn.Enabled = false;
            progToGoal = 0;

            m_SessionManager.GetActiveProfile().SetProgBarValue(0);
            m_SessionManager.GetActiveProfile().SetProgToGoal(0);
            m_SessionManager.GetActiveProfile().SetGoalAmount(0);
        }

        public void ApplyTheme(Theme InTheme)
        {
            SavingsGoalBar.BackColor = InTheme.Background;
            this.BackColor = InTheme.Background;

            ProgressTitle.BackColor = InTheme.Background;
            ProgressTitle.ForeColor = InTheme.Text;

            SavingsList.BackColor = InTheme.Box;
            SavingsList.ForeColor = InTheme.Text;

            GoalAmount.BackColor = InTheme.Background;
            GoalAmount.ForeColor = InTheme.Text;

            GoalAmountEntry.BackColor = InTheme.Box;
            GoalAmountEntry.ForeColor = InTheme.Text;

            ConfirmButton.BackColor = InTheme.Accent;
            ConfirmButton.ForeColor = Color.White;


            ProgressAmount.BackColor = InTheme.Background;
            ProgressAmount.ForeColor = InTheme.Text;

            SavingsGoalAmount.BackColor = InTheme.Background;
            SavingsGoalAmount.ForeColor = InTheme.Text;

            ConfirmAddBtn.BackColor = InTheme.Accent;
            ConfirmAddBtn.ForeColor = Color.White;

            AmountLabel.BackColor = InTheme.Background;
            AmountLabel.ForeColor = InTheme.Text;
            AmountToAdd.BackColor = InTheme.Box;
            AmountToAdd.ForeColor = InTheme.Text;
        }
    }
}