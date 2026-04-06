/********************************************
Name: IncomeSource.cs
Purpose: 
Notes: WIP. 
********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public enum IncomeFrequency
    {
        None = 1,
        Daily,
        Monthly,
        EveryTwoMonths,
        Yearly,
    }

    public class IncomeSource
    {
        IncomeFrequency m_Frequency = IncomeFrequency.None;
        decimal m_Amount;

        string m_Name;

        public IncomeSource(decimal InAmount, IncomeFrequency InFrequency, string InName) 
        {
            m_Amount = InAmount;
            m_Frequency = InFrequency;
            m_Name = InName;
        }
    }
}
