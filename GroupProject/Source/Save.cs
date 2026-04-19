using BudgetPlanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        public class SaveFile
        {
            public User User { get; set; }
            public decimal Balance { get; set; }
            public List<Subscription> Subscriptions { get; set; }
            public List<IncomeSource> IncomeSources { get; set; }
            public List<Budget> Budgets { get; set; }
            public List<Transactions> Transactions { get; set; }
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
                User = user;
                Balance = balance;
                Subscriptions = subscriptions;
                IncomeSources = incomeSources;
                Budgets = budgets;
                Transactions = transactions;
                TransactionCount = transactionCount;
                GoalAmount = goalAmount;
                ProgToGoal = progToGoal;
                ProgBarValue = progBarValue;
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

                activeProfile.SetUser(mySave.User);
                activeProfile.SetBalance(mySave.Balance);
                activeProfile.SetSubscriptions(mySave.Subscriptions);
                activeProfile.SetIncomeSources(mySave.IncomeSources);
                activeProfile.SetBudget(mySave.Budgets);
                activeProfile.SetTransactions(mySave.Transactions);
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
