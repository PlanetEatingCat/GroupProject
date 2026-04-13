/********************************************
Name: class BankAccount
Purpose: to encapsulate functionality of a bank account
Notes: Everything that we need to save in a database or serialize can live here; 
This is where the user data is stored at runtime
Notes: Authored by everyone
********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Windows.Management;


namespace BudgetPlanner
{
    public class Profile
    {
        User m_User;
        public decimal m_Balance;
        private List<Subscription> m_Subscriptions = new List<Subscription>();
        private List<IncomeSource> m_IncomeSources = new List<IncomeSource>();
        private List<Budget> m_Budgets = new List<Budget>();

        private List<Transactions> m_Transactions = new List<Transactions>();
        private int m_TransactionCount = 0;

        private float m_GoalAmount = 0;
        private float m_ProgToGoal = 0;
        private int m_ProgBarValue = 0;

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

        public List<Subscription> GetSubscriptions() { return m_Subscriptions; }

        public List<Budget> GetBudgets() { return m_Budgets; }

        public List<IncomeSource> GetIncomeSources() { return m_IncomeSources; }

        public bool TryGetBudgetByName(string InName, out Budget OutBudget)
        {
            foreach (var budget in m_Budgets)
            {
                if (budget.GetName() == InName)
                {
                    OutBudget = budget;
                    return true;
                }
            }

            OutBudget = null;
            return false;
        }

        public Dictionary<string, List<Budget>> GetBudgetsByCategory()
        {
            var result = new Dictionary<string, List<Budget>>();
            foreach (var budget in m_Budgets)
            {
                string category = budget.GetCategory();
                if (!result.ContainsKey(category)) 
                {
                    result[category] = new List<Budget>();
                }

                result[category].Add(budget);
            }

            return result;
        }

        public void AddSubscription(Subscription InSubscription) { m_Subscriptions.Add(InSubscription); }

        public void AddBudget(Budget InBudget) { m_Budgets.Add(InBudget); }

        public void AddIncomeSource(IncomeSource InIncomeSource) { m_IncomeSources.Add(InIncomeSource); }

        //Getters and setters for goals screen
        public float GetGoalAmount() { return m_GoalAmount; }

        public float GetProgToGoal() { return m_ProgToGoal; }

        public int GetProgBarValue() { return m_ProgBarValue; }

        public void SetGoalAmount(float numAdd) { m_GoalAmount = numAdd; }

        public void SetProgToGoal(float numAdd) { m_ProgToGoal = numAdd; }

        public void SetProgBarValue(int numAdd) { m_ProgBarValue = numAdd; }

        public void AddTransaction(Transactions transaction)
        {
            m_Transactions.Add(transaction);

            if (TryGetBudgetByName(transaction.GetExpenseType(), out var OutBudget))
            {
                OutBudget.SetCurrentSpentAmount(transaction.GetAmount());
            }
        }


        public List<Transactions> GetTransactions()
        {
            return m_Transactions;
        }

        /* Deposit money into account */
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
        public void AddSubscription(string subName, string InType, DeductionFrequency frequency, decimal amount)
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
        public bool EditSubscription(string subName, string InType, DeductionFrequency frequency, decimal amount)
        {
            bool isFound = false;

            foreach (var subscription in GetSubscriptions())
            {
                if (subName.ToLower().TrimEnd() == subscription.GetName().ToLower().TrimEnd())
                {
                    GetSubscriptions().Remove(subscription);
                    GetSubscriptions().Add(new Subscription(frequency, amount, subName));
                    isFound = true;
                    return isFound;
                }
            }

            return isFound;
        }

        public bool EditBudget(string InOldName, string InNewName, string InCategory, decimal InMaxAmount)
        {
            if(TryGetBudgetByName(InOldName, out var OutBudget))
            {
                OutBudget.SetName(InNewName);
                OutBudget.SetCategory(InCategory);
                OutBudget.SetMaxSpentAmount(InMaxAmount);

                foreach(var transaction in m_Transactions)
                {
                    if(transaction.GetExpenseType() == InOldName)
                    {
                        transaction.ExpenseType = InNewName;
                    }
                }

                return true;
            }

            return false;
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

        public void UpdateTransactions()
        {
        /*    DateTime today = new DateTime(2026, 4, 1);

            foreach(var subscription in m_Subscriptions)
            {
                var calculator = new TimelineCalculator(subscription.GetName(), new DateTime(2026, 1, 1), CalendarRepeatType.Month);
                if(calculator.OccursToday(today))
                {
                    Transactions transaction = new Transactions(this, subscription.GetChargeAmount(), "Withdrawal", subscription.GetType());
                    AddTransaction(transaction);
                }
            }*/
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
