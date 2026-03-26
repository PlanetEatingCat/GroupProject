using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetPlanner;
using GroupProject;
using GroupProject.Source.WinForms;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Toolkit.Uwp.Notifications;
using SkiaSharp;

namespace BudgetPlanner
{
    // THIS IS CURRENTLY THE MAIN PAGE OF THE APP
    public partial class MainScreen : UserControl
    {
        private const string CREATE_ACCOUNT_OPTION_TEXT = "Create New Account";
        private const int ERROR_MESSAGE_VANISH_TIME = 5000; // 5 seconds

        private string m_SavedAccountsFilePath = "";

        // For error and success message system
        private System.Windows.Forms.Timer m_ErrorTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer m_SuccessTimer = new System.Windows.Forms.Timer();

        private decimal m_Amount;
        public string ExpenseType;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object InSender, EventArgs InEvent)
        {
            UserLabel.Text = Session.ActiveProfile.GetUser().GetUsername();


            decimal tempBalance = Session.ActiveProfile.GetBalance(); //ensures balance is already displayed
            BalanceTxtBx.Text = tempBalance.ToString();
            ExpenseTypeTxtBox.Visible = false;
            ExpenseTypeLbl.Visible = false;

        }


        private void UpdateUI()
        {
            // Update Progress Bar
            decimal currentBalance = Session.ActiveProfile.GetBalance();
            int progressValue = (int)currentBalance;
            if (progressValue < 0) progressValue = 0;
            if (progressValue > SavingsProgressBar.Maximum) progressValue = SavingsProgressBar.Maximum;
            SavingsProgressBar.Value = progressValue;

            // Update Transaction History ListBox
            Transactions.Items.Clear();
            foreach (var t in Session.ActiveProfile.GetTransactions())
            {
                Transactions.Items.Add(t.Statement(t.m_Type));
            }
        }


        private void ConfirmBttn_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(AmountTxtBx.Text, out decimal number)) //ensures the text box contains a valid number converts to int
            {
                m_Amount = number;

                if (WithdrawAddSelect.Text == "Add Expense") //Withdraws from Balance
                {
                    if (ExpenseTypeTxtBox.Text == "")
                    { Logger.Warn("Please Enter an Expense Type"); }
                    else
                        try
                        {
                            Session.ActiveProfile.Withdraw(number);
                            decimal tempBalance = Session.ActiveProfile.GetBalance();//edits balance textbox
                            BalanceTxtBx.Text = tempBalance.ToString();
                            ExpenseType = ExpenseTypeTxtBox.Text;

                            //Creates a transactions object and adds it to history
                            Transactions temp = new Transactions(Session.ActiveProfile, m_Amount, "Withdrawal", ExpenseType);
                            Session.ActiveProfile.AddTransaction(temp);
                            UpdateUI();
                        }
                        catch (Exception ex)
                        {
                            Logger.Warn("Cannot overdraw");
                            Notifications.Notification("Insufficent Funds", "You're over the spending limit!");
                        }

                }
                else if (WithdrawAddSelect.Text == "Deposit") // Adds to Balance
                {

                    Session.ActiveProfile.Deposit(number);

                    decimal tempBalance = Session.ActiveProfile.GetBalance();
                    BalanceTxtBx.Text = tempBalance.ToString();

                    //Creates a transactions object and adds it to history
                    Transactions temp = new Transactions(Session.ActiveProfile, m_Amount, "Deposit");
                    Session.ActiveProfile.AddTransaction(temp);
                    UpdateUI();
                }
                else //Ensures Withdraw or Deposit is Selected
                {
                    Logger.Warn("Please Select Deposit or Add Expense.");

                }
            }
            else
            {
                Logger.Warn("Amount Box Must Contain a Number");
            }

        }

        private void BalanceTxtBx_TextChanged(object sender, EventArgs e)
        {
            decimal tempBalance = Session.ActiveProfile.GetBalance(); //prevents user from editing balance text box
            BalanceTxtBx.Text = tempBalance.ToString();
        }

        private void BackToSignInButton_Click(object sender, EventArgs e)
        {
            ScreenManager.SwitchScreens(new SignInScreen());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScreenManager.SwitchScreens(new CalendarScreen());
        }

        private void BankPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WithdrawAddSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WithdrawAddSelect.Text == "Add Expense")

            {
                ExpenseTypeTxtBox.Visible = true;
                ExpenseTypeLbl.Visible = true;
            }
            else
            {
                ExpenseTypeTxtBox.Visible = false;
                ExpenseTypeLbl.Visible = false;
            }
        }

        private void ExpenseTypeTxtBox_TextChanged(object sender, EventArgs e)
        {
            string ExpenseType;
            ExpenseType = ExpenseTypeTxtBox.Text;

        }

        private void ExpenseTypeLbl_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubManagerButton_Click(object sender, EventArgs e)
        {
            ScreenManager.SwitchScreens(new SubscriptionManagerForm());
        }
    }
}
