/********************************************
Name: Transactions
Purpose: Transactions 
Notes: Authored by Kiefer
********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public class Transactions
    {
   //     public Profile m_Account { get; protected set; }
        public decimal m_Amount;
        public string m_Type;
        public string ExpenseType = "Deposit"; //****

        public Transactions(decimal Amount, string Type)
        {
            this.m_Amount = Amount;
            this.m_Type = Type;

        }
        public Transactions(decimal Amount, string Type, string EType)
        {
            this.m_Amount = Amount;
            this.m_Type = Type;
            this.ExpenseType = EType;

        }

        public string GetExpenseType()
        {
            return ExpenseType;
        }

        public string GetType()
        {
            return m_Type;
        }

        public decimal GetAmount()
        {
            return m_Amount;
        }

        public string Statement(Profile InProfile, string type)
        {
            if (type == "Withdrawal")
            {
                return $"Withdraw {ExpenseType} expense from {InProfile.GetUser().GetUsername()}'s account. Amount: ${m_Amount}.";
            }
            else if (type == "Deposit")
            {
                return $"{m_Type} to {InProfile.GetUser().GetUsername()}'s account. Amount: ${m_Amount}.";
            }
            else
            {
                return "ERROR";
            }
        }
    }
}
