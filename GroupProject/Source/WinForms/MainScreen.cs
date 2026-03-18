using BudgetPlanner;
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
    public partial class MainScreen : UserControl
    {
        private const string CREATE_ACCOUNT_OPTION_TEXT = "Create New Account";
        private const int ERROR_MESSAGE_VANISH_TIME = 5000; // 5 seconds

        private string m_SavedAccountsFilePath = "";

        // For error and success message system
        private System.Windows.Forms.Timer m_ErrorTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer m_SuccessTimer = new System.Windows.Forms.Timer();

        private decimal m_Amount;


        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object InSender, EventArgs InEvent)
        {
            UserLabel.Text = Session.ActiveProfile.GetUser().GetUsername();


            decimal tempBalance = Session.ActiveProfile.GetBalance(); //ensures balance is already displayed
            BalanceTxtBx.Text = tempBalance.ToString();

            UpdateUI();
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

        private void WithdrawAddSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AmountTxtBx_TextChanged(object sender, EventArgs e)
        {



        }

        private void ConfirmBttn_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(AmountTxtBx.Text, out decimal number)) //ensures the text box contains a valid number converts to int
            {
                m_Amount = number;

                if (WithdrawAddSelect.Text == "Withdraw") //Withdraws from Balance
                {
                    Session.ActiveProfile.Withdraw(number);

                    decimal tempBalance = Session.ActiveProfile.GetBalance();//edits balance textbox
                    BalanceTxtBx.Text = tempBalance.ToString();

                    //Creates a transactions object and adds it to history
                    Transactions temp = new Transactions(Session.ActiveProfile, m_Amount, "Withdrawal");
                    Session.ActiveProfile.AddTransaction(temp);
                    UpdateUI();
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
                    //   ShowErrorMessage("Please Select Deposit or Withdraw.");
                }
            }
            else
            {
                // ShowErrorMessage("Amount Box Must Contain a Number");
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
