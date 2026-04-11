using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public class Budget
    {
        string m_Name = "Unnamed Budget";
        string m_Category = "Unnamed Category";
        private decimal m_MaxSpentAmount = 100;
        private decimal m_CurrentSpentAmount = 0;

        public Budget(string InName, string InCategory, decimal InMaxSpentAmount, decimal InCurrentSpentAmount)
        {
            SetName(InName);
            SetCategory(InCategory);
            SetMaxSpentAmount(InMaxSpentAmount);
            SetCurrentSpentAmount(InCurrentSpentAmount);
        }

        public string GetName() { return m_Name; } 

        public void SetName(string InName) 
        {
            if (InName == "")
                throw new ArgumentException();

            m_Name = InName;
        }

        public string GetCategory() { return m_Category; }

        public void SetCategory(string InCategory)
        {
            if (InCategory == "")
                throw new ArgumentException();

            m_Category = InCategory;
        }

        public decimal GetMaxSpentAmount() { return m_MaxSpentAmount; } 

        public void SetMaxSpentAmount(decimal InMaxSpentAmount) 
        {
            if(InMaxSpentAmount < 0) throw new ArgumentException();

            m_MaxSpentAmount = InMaxSpentAmount;

        } 

        public decimal GetCurrentSpentAmount() { return m_CurrentSpentAmount; } 

        public void SetCurrentSpentAmount(decimal InCurrentSpentAmount) 
        {
            if (InCurrentSpentAmount < 0) throw new ArgumentException();

            m_CurrentSpentAmount = InCurrentSpentAmount;
        }
    }
}
