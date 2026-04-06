/********************************************
Name: PaymentScreen.cs
Purpose: Add, remove, and edit expenses
Notes: Should be in the epenses tab. WIP by Ella.
********************************************/

using BudgetPlanner;
using GroupProject;
using Microsoft.Toolkit.Uwp.Notifications;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;


namespace BudgetPlanner
{
    public partial class CardsScreen : UserControl
    {
        //-----------------------------------------------------------------------------------------------
        // Dependencies
        //-----------------------------------------------------------------------------------------------

        private readonly MainForm m_MainForm;
        private readonly NavigationManager m_Navigator;
        private readonly SessionManager m_SessionManager;

        //-----------------------------------------------------------------------------------------------
        // Variables
        //-----------------------------------------------------------------------------------------------

        private const string CREATE_ACCOUNT_OPTION_TEXT = "Create New Account";
        private const int ERROR_MESSAGE_VANISH_TIME = 5000; // 5 seconds

        private decimal m_Amount;
        public string ExpenseType;

        //-----------------------------------------------------------------------------------------------
        // Screen
        //-----------------------------------------------------------------------------------------------

        public CardsScreen(MainForm InMainForm, NavigationManager InNavigator, SessionManager InSessionManager,
                          AccountTitle InAccountTitle, ScreenTitle InScreenTitle)
        {
            InitializeComponent();

            m_MainForm = InMainForm;
            m_Navigator = InNavigator;
            m_SessionManager = InSessionManager;

            var rightMenuBar = InAccountTitle;
            var leftMenuBar = InScreenTitle;

            var mainForm = InMainForm;
            mainForm.SetRightMenuBar(rightMenuBar);
            mainForm.SetLeftMenuBar(leftMenuBar);

            leftMenuBar.SetIcon(MenuIcons.Card);
            leftMenuBar.SetText("Card");
        }

        private void MainScreen_Load(object InSender, EventArgs InEvent)
        {
            m_MainForm.SetMenuBarActive(true);

            /*var rightMenuBar = ServiceContainer.Get<AccountTitle>();
            var leftMenuBar = ServiceContainer.Get<ScreenTitle>();
            m_MainForm.SetRightMenuBar(rightMenuBar);
            m_MainForm.SetLeftMenuBar(leftMenuBar);*/

            //  UserLabel.Text = ClientApplication.ActiveProfile.GetUser().GetUsername();


            decimal tempBalance = m_SessionManager.GetActiveProfile().GetBalance(); //ensures balance is already displayed
            BalanceTxtBx.Text = tempBalance.ToString();
            ExpenseTypeTxtBox.Visible = false;
            ExpenseTypeLbl.Visible = false;
        }

        //-----------------------------------------------------------------------------------------------
        // Controls
        //-----------------------------------------------------------------------------------------------

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
                            m_SessionManager.GetActiveProfile().Withdraw(number);
                            decimal tempBalance = m_SessionManager.GetActiveProfile().GetBalance();//edits balance textbox
                            BalanceTxtBx.Text = tempBalance.ToString();
                            ExpenseType = ExpenseTypeTxtBox.Text;

                            //Creates a transactions object and adds it to history
                            Transactions temp = new Transactions(m_SessionManager.GetActiveProfile(), m_Amount, "Withdrawal", ExpenseType);
                            m_SessionManager.GetActiveProfile().AddTransaction(temp);
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

                    m_SessionManager.GetActiveProfile().Deposit(number);

                    decimal tempBalance = m_SessionManager.GetActiveProfile().GetBalance();
                    BalanceTxtBx.Text = tempBalance.ToString();

                    //Creates a transactions object and adds it to history
                    Transactions temp = new Transactions(m_SessionManager.GetActiveProfile(), m_Amount, "Deposit");
                    m_SessionManager.GetActiveProfile().AddTransaction(temp);
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
            decimal tempBalance = m_SessionManager.GetActiveProfile().GetBalance(); //prevents user from editing balance text box
            BalanceTxtBx.Text = tempBalance.ToString();
        }

        private void BackToSignInButton_Click(object sender, EventArgs e)
        {
            m_Navigator.GoTo<SignInScreen>();
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

        //-----------------------------------------------------------------------------------------------
        // Private Utils
        //-----------------------------------------------------------------------------------------------

        private void UpdateUI()
        {
            // Update Progress Bar
            decimal currentBalance = m_SessionManager.GetActiveProfile().GetBalance();
            int progressValue = (int)currentBalance;
            if (progressValue < 0) progressValue = 0;
            if (progressValue > SavingsProgressBar.Maximum) progressValue = SavingsProgressBar.Maximum;
            SavingsProgressBar.Value = progressValue;

            // Update Transaction History ListBox
            Transactions.Items.Clear();
            foreach (var t in m_SessionManager.GetActiveProfile().GetTransactions())
            {
                Transactions.Items.Add(t.Statement(t.m_Type));
            }
        }

    }
}
