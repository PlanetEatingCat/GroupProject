/********************************************
Name: class BankAccount
Purpose: to encapsulate functionality of a bank account
Notes: Everything that we need to save in a database or serialize can live here; 
This is where the user data is stored at runtime
********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetPlanner
{
    public class Profile
    {
        User m_User;
        public decimal m_Balance;
        private List<Subscription> m_Subscriptions = new List<Subscription>();
        private List<IncomeSource> m_IncomeSources = new List<IncomeSource>();

        private Transactions[] m_TransactionHistory = new Transactions[100];
        private int m_TransactionCount = 0;

        private Calendar m_Calendar; 
        public Profile() 
        {
            m_User = new User(); 
            m_Balance = 0;
        }

        public Profile(string InUsername, string InPassword) 
        {
            m_User = new User();
            m_User.SetUsername(InUsername);
            m_User.SetPassword(InPassword);

            m_Balance = 0;
        }

        public Profile(string InUsername, string InPassword, decimal InBalance) 
        {
            m_User = new User();
            m_User.SetUsername(InUsername);
            m_User.SetPassword(InPassword);

            SetBalance(InBalance);
        }

        public Profile(User InUser, decimal InBalance) 
        {
            m_User = InUser;
            SetBalance(InBalance);
        }

        public void SetBalance(decimal InBalance) 
        {
            if (InBalance < 0)
                throw new ArgumentOutOfRangeException(nameof(InBalance), "Balance cannot be negative.");

            m_Balance = InBalance; 
        }

        public decimal GetBalance() { return m_Balance; }

        public User GetUser() { return m_User; }

        public Calendar GetCalendar() { return m_Calendar; }

        public List<Subscription> GetSubscriptions() { return m_Subscriptions; }

        public List<IncomeSource> GetIncomeSources() { return m_IncomeSources; }

        public void AddSubscription(Subscription InSubscription) { m_Subscriptions.Add(InSubscription); }

        public void AddIncomeSource(IncomeSource InIncomeSource) { m_IncomeSources.Add(InIncomeSource); }

        public void AddTransaction(Transactions transaction)
        {
            if (m_TransactionCount < 100)
            {
                m_TransactionHistory[m_TransactionCount] = transaction;
                m_TransactionCount++;
            }
            else
            {
                // Shift everything left by 1 to make room for the new transaction
                for (int i = 1; i < 100; i++)
                {
                    m_TransactionHistory[i - 1] = m_TransactionHistory[i];
                }
                m_TransactionHistory[99] = transaction;
            }
        }

        public Transactions[] GetTransactions()
        {
            Transactions[] currentTransactions = new Transactions[m_TransactionCount];
            Array.Copy(m_TransactionHistory, currentTransactions, m_TransactionCount);
            return currentTransactions;
        }

        /* Deposite money into account */
        public void Deposit(decimal InAmount) 
        {
            //add to the balance, check for negative, limit

            if (InAmount <= 0)
                throw new ArgumentOutOfRangeException(nameof(InAmount), "Deposit amount must be positive.");

            if (InAmount > int.MaxValue)
                throw new ArgumentOutOfRangeException(nameof(InAmount), "Profile cannot hold such a large amount of money");

            m_Balance += InAmount;
          

		}

        /* Withdraw money from account */
        public void Withdraw(decimal InAmount) 
        {
            //take away amount if balance is enough

            if (InAmount <= 0)
                throw new ArgumentOutOfRangeException(nameof(InAmount), "Withdrawal amount must be positive.");

            if (InAmount > m_Balance)
                throw new InvalidOperationException("Insufficient funds.");


            m_Balance -= InAmount;
        }

        /* Print the current account balance */
        public void Inquiry() 
        {
            Console.WriteLine("Balance: " + m_Balance);
        }

        /* Prints the account holder and current balance */
        public void Print() 
        {
            m_User.Print();
            Console.WriteLine("Balance: " + m_Balance);
        }

        //Adds a subscription to the dictionary
        public void AddSubscription(string subName, DeductionFrequency frequency, decimal amount)
        {
            Subscription newSub = new Subscription(frequency, amount, subName);
            AddSubscription(newSub);
            //this.count++;
        }

        //Removes a subscription from the list
        public bool DeleteSubscription(string subName)
        {
            bool isFound = false;

            foreach (var subscription in GetSubscriptions())
            {
                if (subName.ToLower().TrimEnd() == subscription.GetName().ToLower().TrimEnd())
                { 
                    GetSubscriptions().Remove(subscription);
                    isFound = true;
                    return isFound;
                }
            }

            return isFound;
        }

        //Allows users to pass in information to edit subscriptions already in the list
        public bool EditSubscription(string subName, DeductionFrequency frequency, decimal amount)
        {
            bool isFound = false;

            foreach (var subscription in GetSubscriptions())
            {
                if (subName == subscription.GetName())
                {
                    GetSubscriptions().Remove(subscription);
                    GetSubscriptions().Add(new Subscription(frequency, amount, subName));
                    isFound = true;
                }
            }

            return isFound;
        }

        //Gets total value of subscriptions
        public decimal GetValueOfSubs()
        {
            decimal total = 0;
            foreach (var subscription in GetSubscriptions())
            {
                total += subscription.GetChargeAmount();
            }

            return total;
        }

        //Function returns a string informing users when they are overbudget or on track with budget goals
        public string OverUnderBudget()
        {
            decimal total = GetValueOfSubs();
            decimal budget = GetBalance();

            if (total > budget)
            {
                return $"User is overbudget by ${total - budget}. Consider cancelling some subscriptions to meet budget goals!";
            }
            else if (total <= budget)
            {
                return $"You're on track with your budget goals! You are under budget by ${budget - total}.";
            }
            else
            {
                return "ERROR";
            }
        }

        public static DeductionFrequency CheckFrequency(string frequency)
        {
            if (Enum.TryParse<DeductionFrequency>(frequency, true, out var result))
            {
                return result;
            }

            throw new ArgumentException("Invalid frequency");
        }

        public static string DisplayInfo(Subscription sub)
        {
            return $"{sub.GetName()}: ${sub.GetChargeAmount()} {sub.GetFrequency()}";
        }
    }

}
