
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public class Transactions
    {
        public Profile m_Account { get; protected set; }
        public decimal m_Amount;
        public string m_Type;

        public Transactions (Profile Account, decimal Amount, string Type)
        {
            this.m_Account = Account;
            this.m_Amount = Amount;
            this.m_Type = Type;
        }

        public string Statement(string type)
        {
            if (type == "Withdrawal")
            {
                return $"{m_Type} from {m_Account.GetUser().GetUsername()}'s account. Amount: ${m_Amount}.";
            }
            else if (type == "Deposit")
            {
                return $"{m_Type} to {m_Account.GetUser().GetUsername()}'s account. Amount: ${m_Amount}.";
            }
            else
            {
                return "ERROR";
            }
        }
    }
}
