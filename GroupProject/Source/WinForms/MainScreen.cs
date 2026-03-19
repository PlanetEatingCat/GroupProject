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


        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object InSender, EventArgs InEvent)
        {
            UserLabel.Text = Session.ActiveProfile.GetUser().GetUsername();


            decimal tempBalance = Session.ActiveProfile.GetBalance(); //ensures balance is already displayed
            BalanceTxtBx.Text = tempBalance.ToString();

            // SOME USEFUL STUFF
            /*
            // Can print stuff to the DebugConsole form
            Logger.ConsoleError("Hello!");
            Logger.ConsoleWarn("Hello!");
            Logger.ConsoleInfo("Hello!");

            // Just like in the Bank program we can print messages in a gui banner
            Logger.Warn("GUI Warning");

            // If you want to creat another screen or page to the app 
            // You can use this to switch easily to it.
            // To create another screen/page you can right click on the Winforms folder -> Add -> UserControl
            // The below replace MyScreenName with the name of the UserControl.
            // You can edit the UserControl just like a form.
            
            ScreenManager.SwitchScreens(new MyScreenName());
             
            */
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

                if (WithdrawAddSelect.Text == "Withdraw") //Withdraws from Balance
                {
                    try
                    {
                        Session.ActiveProfile.Withdraw(number);
                        decimal tempBalance = Session.ActiveProfile.GetBalance();//edits balance textbox
                        BalanceTxtBx.Text = tempBalance.ToString();

                        //Creates a transactions object and adds it to history
                        Transactions temp = new Transactions(Session.ActiveProfile, m_Amount, "Withdrawal");
                        Session.ActiveProfile.AddTransaction(temp);
                        UpdateUI();
                    }
                    catch (Exception ex)
                    {
                        Logger.Warn("Cannot overdraw");
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
                    Logger.Warn("Please Select Deposit or Withdraw.");
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

    }
}
