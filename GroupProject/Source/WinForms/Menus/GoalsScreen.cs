/********************************************
Name: GoalsScreen.cs
Purpose: The goals
Notes: WIP by Kiefer.
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
using static SkiaSharp.HarfBuzz.SKShaper;

namespace BudgetPlanner
{
    public partial class GoalsScreen : UserControl
    {
        public GoalsScreen(MainForm InMainForm, AccountTitle InAccountTitle, ScreenTitle InScreenTitle)
        {
            InitializeComponent();

            InMainForm.SetRightMenuBar(InAccountTitle);
            InMainForm.SetLeftMenuBar(InScreenTitle);

            InScreenTitle.SetIcon(MenuIcons.Goals);
            InScreenTitle.SetText("Goals");
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            float result;

            //Checks input to make sure it is a valid number to save up to 
            if (float.TryParse(GoalAmountEntry.Text, out result) == false)
            {
                MessageBox.Show("Must input a valid amount.");
                return;
            }

            ProgressAmount.Text = $"Progress Amount: 0";
            SavingsGoalAmount.Text = $"Goal Amount: {result}";
            ConfirmButton.Enabled = false;
            GoalAmountEntry.Text = "";
            GoalAmountEntry.Enabled = false;
        }

        /*
         * Updating the progress bar:
         * 1.) If amount is less than goal amount, divide input amount by goal amount, multiply by 100, and then call progressbar.increment(result of math)
         * 2.) If amount is more than goal amount, immediately set progress bar to full and congratulate the user on their progress.
         * 3.) If amount is invalid (Not a number, negative number, etc.), display message box informing user of problem.
         * 
         * This code would be attached to a confirm button from the user, or could be integrated with income in some way to automatically handle this.
         */

        //Added by mistake, ignore
        private void GoalAmount_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
