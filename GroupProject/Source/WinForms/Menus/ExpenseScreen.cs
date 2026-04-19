/********************************************
Name: PaymentScreen.cs
Purpose: Add, remove, and edit expenses
Notes:Authored by Ella.
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
    public partial class ExpenseScreen : UserControl
    {
        //-----------------------------------------------------------------------------------------------
        // Dependencies
        //-----------------------------------------------------------------------------------------------

        private readonly MainForm m_MainForm;
        private readonly NavigationManager m_Navigator;
        private readonly SessionManager m_SessionManager;
        private readonly EventDispatcher m_EventDispatcher;
        private readonly ThemeManager m_ThemeManager;

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

        public ExpenseScreen(MainForm InMainForm, NavigationManager InNavigator, SessionManager InSessionManager,
                          AccountTitle InAccountTitle, ScreenTitle InScreenTitle, EventDispatcher InEventDispatcher,
            ThemeManager InThemeManager)
        {
            InitializeComponent();

            m_MainForm = InMainForm;
            m_Navigator = InNavigator;
            m_SessionManager = InSessionManager;
            m_EventDispatcher = InEventDispatcher;
            m_ThemeManager = InThemeManager;

            ApplyTheme(InThemeManager.GetCurrentTheme());
            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);

            var rightMenuBar = InAccountTitle;
            var leftMenuBar = InScreenTitle;

            var mainForm = InMainForm;
            mainForm.SetRightMenuBar(rightMenuBar);
            mainForm.SetLeftMenuBar(leftMenuBar);

            leftMenuBar.SetIcon(MenuIcons.Card);
            leftMenuBar.SetText("Card");
        }

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
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
            ExpenseTypeComboBox.Visible = false;
            ExpenseTypeLbl.Visible = false;

            foreach (var budget in m_SessionManager.GetActiveProfile().GetBudgets())
            {
                ExpenseTypeComboBox.Items.Add(budget.GetName());
            }
            UpdateUI();
        }



        private void UpdateUI()
        {
            // Update Progress Bar

            // Update Transaction History ListBox
            Transactions.Items.Clear();
            foreach (var t in m_SessionManager.GetActiveProfile().GetTransactions())
            {
                Transactions.Items.Add(t.Statement(m_SessionManager.GetActiveProfile(), t.m_Type));
            }
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
                    if (ExpenseTypeComboBox.Text == "")
                    {
                        Logger.Warn("Please Enter an Expense Type");
                    }
                    else
                        try
                        {
                            m_SessionManager.GetActiveProfile().Withdraw(number);
                            decimal tempBalance = m_SessionManager.GetActiveProfile().GetBalance();//edits balance textbox
                            BalanceTxtBx.Text = tempBalance.ToString();
                            ExpenseType = ExpenseTypeComboBox.Text;

                            //Creates a transactions object and adds it to history
                            Transactions temp = new Transactions(m_Amount, "Withdrawal", ExpenseType);
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
                    Transactions temp = new Transactions(m_Amount, "Deposit");
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
            //   m_Navigator.GoTo<LoginForm>();
        }

        private void WithdrawAddSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WithdrawAddSelect.Text == "Add Expense")

            {
                ExpenseTypeComboBox.Visible = true;
                ExpenseTypeLbl.Visible = true;
            }
            else
            {
                ExpenseTypeComboBox.Visible = false;
                ExpenseTypeLbl.Visible = false;
            }
        }

        private void ExpenseTypeTxtBox_TextChanged(object sender, EventArgs e)
        {
            string ExpenseType;
            ExpenseType = ExpenseTypeComboBox.Text;

        }

        private void ExpenseTypeLbl_Click(object sender, EventArgs e)
        {

        }

        private void BalanceLbl_Click(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------
        // Private Utils
        //-----------------------------------------------------------------------------------------------

        public void ApplyTheme(Theme InTheme)
        {
            this.BackColor = InTheme.Background;

            ExpenseTypeLbl.BackColor = InTheme.Background;
            ExpenseTypeLbl.ForeColor = InTheme.Text;

            WithdrawAddSelect.BackColor = InTheme.Box;
            WithdrawAddSelect.ForeColor = InTheme.Text;

            EditBalanceLbl.BackColor = InTheme.Background;
            EditBalanceLbl.ForeColor = InTheme.Text;

            BalanceTxtBx.BackColor = InTheme.Box;
            BalanceTxtBx.ForeColor = InTheme.Text;

            AmountLbl.BackColor = InTheme.Background;
            AmountLbl.ForeColor = InTheme.Text;

            AmountTxtBx.BackColor = InTheme.Box;
            AmountTxtBx.ForeColor = InTheme.Text;

            ConfirmBttn.BackColor = InTheme.Accent;
            ConfirmBttn.ForeColor = System.Drawing.Color.White;

            Transactions.BackColor = InTheme.Box;
            Transactions.ForeColor = InTheme.Text;

            BalanceLbl.BackColor = InTheme.Background;
            BalanceLbl.ForeColor = InTheme.Text;

            ExpenseTypeComboBox.BackColor = InTheme.Box;
            ExpenseTypeComboBox.ForeColor = InTheme.Text;

            Title.BackColor = InTheme.Background;
            Title.ForeColor = InTheme.Text;
        }
    }
}
