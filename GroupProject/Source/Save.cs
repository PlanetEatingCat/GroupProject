using BudgetPlanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Transactions;

namespace BudgetPlanner
{
    internal class Save
    {
        private readonly SessionManager m_SessionManager;

        public Save(SessionManager inSessionManager)
        {
            m_SessionManager = inSessionManager;
        }

        //Class to hold all information to save to user profile
        //class SaveFile(User inUser, decimal inBalance, List<Subscription> inSubscriptions, 
        //    List<IncomeSource> inIncomeSources, List<Budget> inBudgets, List<Transactions> inTransactions,
        //    int inTransactionCount, float inGoalAmount, float inProgToGoal, int inProgBarValue) 
        //{
        //    public User user = inUser;
        //    public decimal balance = inBalance;
        //    public List<Subscription> subscriptions = inSubscriptions;
        //    public List<IncomeSource > incomeSources = inIncomeSources;
        //    public List <Budget> budgets = inBudgets;
        //    public List<Transactions> transactions = inTransactions;
        //    public int transactionCount = inTransactionCount;
        //    public float goalAmount = inGoalAmount;
        //    public float progToGoal = inProgToGoal;
        //    public int progBarValue = inProgBarValue;
        //}

        public class SaveSubscription
        {
            public DeductionFrequency Frequency { get; set; }
            public decimal ChargeAmount { get; set; }
            public string Name { get; set; }
        }

        public class SaveIncome
        {
            [JsonConverter(typeof(JsonStringEnumConverter))]
            public IncomeFrequency Frequency { get; set; }
            public decimal Amount { get; set; }
            public string Name { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
        }

        public class SaveTransaction
        {
            public decimal Amount { get; set; }
            public string Type { get; set; }
            public string ExpenseType { get; set; }
        }

        public class SaveBudget
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public decimal MaxSpentAmount { get; set; }
            public decimal CurrentSpentAmount { get; set; }
        }

        public class SaveUser
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public uint Age { get; set; }
            public Guid ID { get; set; }
        }

        public class SaveFile
        {
            public SaveUser User { get; set; }
            public decimal Balance { get; set; }
            public List<SaveSubscription> Subscriptions { get; set; }
            public List<SaveIncome> IncomeSources { get; set; }
            public List<SaveBudget> Budgets { get; set; }
            public List<SaveTransaction> Transactions { get; set; }
            public int TransactionCount { get; set; }
            public float GoalAmount { get; set; }
            public float ProgToGoal { get; set; }
            public int ProgBarValue { get; set; }

            public SaveFile() { }

            public SaveFile(
                User user,
                decimal balance,
                List<Subscription> subscriptions,
                List<IncomeSource> incomeSources,
                List<Budget> budgets,
                List<Transactions> transactions,
                int transactionCount,
                float goalAmount,
                float progToGoal,
                int progBarValue)
            {
                User = new SaveUser();
                User.Username = user.GetUsername();
                User.Password = user.GetPassword();
                User.Age = user.GetAge();
                User.ID = user.GetID();

                Balance = balance;
                GoalAmount = goalAmount;
                ProgToGoal = progToGoal;
                TransactionCount = transactionCount;
                ProgBarValue = progBarValue;

                Subscriptions = new List<SaveSubscription>();
                foreach (var sub in subscriptions)
                {
                    var saveSub = new SaveSubscription();
                    saveSub.Frequency = sub.GetFrequency();
                    saveSub.Name = sub.GetName();
                    saveSub.ChargeAmount = sub.GetChargeAmount();
                    Subscriptions.Add(saveSub);
                }

                IncomeSources = new List<SaveIncome>();
                foreach (var income in incomeSources)
                {
                    var saveIncome = new SaveIncome();
                    saveIncome.Frequency = income.GetFrequency();
                    saveIncome.Name = income.GetName();
                    saveIncome.Amount = income.GetAmount();
                    saveIncome.StartDate = income.GetStartDate();
                    saveIncome.EndDate = income.GetEndDate();
                    IncomeSources.Add(saveIncome);
                }

                Transactions = new List<SaveTransaction>();
                foreach (var transaction in transactions)
                {
                    var saveTransaction = new SaveTransaction();
                    saveTransaction.ExpenseType = transaction.GetExpenseType();
                    saveTransaction.Type = transaction.GetType();
                    saveTransaction.Amount = transaction.GetAmount();
                    Transactions.Add(saveTransaction);
                }

                Budgets = new List<SaveBudget>();
                foreach (var budget in budgets)
                {
                    var saveBudget = new SaveBudget();
                    saveBudget.Name = budget.GetName();
                    saveBudget.Category = budget.GetCategory();
                    saveBudget.MaxSpentAmount = budget.GetMaxSpentAmount();
                    saveBudget.CurrentSpentAmount = budget.GetCurrentSpentAmount();
                    Budgets.Add(saveBudget);
                }
            }

            public SaveFile(
               SaveUser user,
               decimal balance,
               List<SaveSubscription> subscriptions,
               List<SaveIncome> incomeSources,
               List<SaveBudget> budgets,
               List<SaveTransaction> transactions,
               int transactionCount,
               float goalAmount,
               float progToGoal,
               int progBarValue)
            {
                User = user;
                Balance = balance;
                GoalAmount = goalAmount;
                ProgToGoal = progToGoal;
                TransactionCount = transactionCount;
                ProgBarValue = progBarValue;
                Subscriptions = subscriptions;
                IncomeSources = incomeSources;
                Budgets = budgets;
                Transactions = transactions;
            }

            public User ConvertUser()
            {
                var user = new User(User.Username, User.Password, User.Age, User.ID);
                return user;
            }

            public List<Subscription> ConvertSubscriptions()
            {
                var result = new List<Subscription>();
                foreach (var saveSub in Subscriptions)
                {
                    var sub = new Subscription(saveSub.Frequency, saveSub.ChargeAmount, saveSub.Name);
                    result.Add(sub);
                }

                return result;
            }

            public List<IncomeSource> ConvertIncome()
            {
                var result = new List<IncomeSource>();
                foreach (var saveIncome in IncomeSources)
                {
                    var income = new IncomeSource(saveIncome.Amount, saveIncome.Frequency, saveIncome.Name, saveIncome.StartDate, saveIncome.EndDate);
                    result.Add(income);
                }

                return result;
            }

            public List<Transactions> ConvertTransactions()
            {
                var result = new List<Transactions>();
                foreach (var saveTransaction in Transactions)
                {
                    var transaction = new Transactions(saveTransaction.Amount, saveTransaction.Type, saveTransaction.ExpenseType);
                    result.Add(transaction);
                }

                return result;
            }

            public List<Budget> ConvertBudgets()
            {
                var result = new List<Budget>();
                foreach (var saveBudget in Budgets)
                {
                    var budget = new Budget(saveBudget.Name, saveBudget.Category, saveBudget.MaxSpentAmount, saveBudget.CurrentSpentAmount);
                    result.Add(budget);
                }

                return result;
            }
        }

        //public void SaveProfile()
        //{
        //    string FileName = $"{m_SessionManager.GetActiveProfile().GetUser().GetUsername()}.json";

        //    SaveFile m_Profile = new SaveFile(m_SessionManager.GetActiveProfile().GetUser(), m_SessionManager.GetActiveProfile().GetBalance(),
        //        m_SessionManager.GetActiveProfile().GetSubscriptions(), m_SessionManager.GetActiveProfile().GetIncomeSources(),
        //        m_SessionManager.GetActiveProfile().GetBudgets(), m_SessionManager.GetActiveProfile().GetTransactions(),
        //        m_SessionManager.GetActiveProfile().GetTransactionCount(), m_SessionManager.GetActiveProfile().GetGoalAmount(),
        //        m_SessionManager.GetActiveProfile().GetProgToGoal(), m_SessionManager.GetActiveProfile().GetProgBarValue());

        //    string JsonOutput = JsonSerializer.Serialize(m_Profile, new JsonSerializerOptions { WriteIndented = true });

        //    MessageBox.Show(JsonOutput);

        //    File.WriteAllText($"{FileName}", JsonOutput);

        //    MessageBox.Show("Profile Saved");
        //}

        public void SaveProfile()
        {
            var profile = m_SessionManager.GetActiveProfile();
            if (profile == null) return;

            string fileName = $"{profile.GetUser().GetUsername()}.json";

            var saveFile = new SaveFile(
                profile.GetUser(),
                profile.GetBalance(),
                profile.GetSubscriptions(),
                profile.GetIncomeSources(),
                profile.GetBudgets(),
                profile.GetTransactions(),
                profile.GetTransactionCount(),
                profile.GetGoalAmount(),
                profile.GetProgToGoal(),
                profile.GetProgBarValue());

            string jsonOutput = JsonSerializer.Serialize(saveFile, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(fileName, jsonOutput);
            MessageBox.Show("Profile Saved");
        }
        public static void LoadProfile(SessionManager sessionManager, string Username)
        {
            try
            {
                string FileName = $"{Username}.json";
                string jsonString = File.ReadAllText(FileName);
                MessageBox.Show(jsonString);
                SaveFile mySave = JsonSerializer.Deserialize<SaveFile>(jsonString)!;

                Profile activeProfile = sessionManager.GetActiveProfile();

                activeProfile.SetUser(mySave.ConvertUser());
                activeProfile.SetBalance(mySave.Balance);
                activeProfile.SetSubscriptions(mySave.ConvertSubscriptions());
                activeProfile.SetIncomeSources(mySave.ConvertIncome());
                activeProfile.SetBudget(mySave.ConvertBudgets());
                activeProfile.SetTransactions(mySave.ConvertTransactions());
                activeProfile.SetTransactionCount(mySave.TransactionCount);
                activeProfile.SetGoalAmount(mySave.GoalAmount);
                activeProfile.SetProgToGoal(mySave.ProgToGoal);
                activeProfile.SetProgBarValue(mySave.ProgBarValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
