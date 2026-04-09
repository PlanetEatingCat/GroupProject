/********************************************
Name: IncomeSource.cs
Purpose: 
Notes: WIP. 
********************************************/

using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Management;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

    public class IncomeSource //: Profile
    {
        IncomeFrequency m_Frequency = IncomeFrequency.None;
        decimal m_Amount;

        string m_Name;
        private readonly SessionManager m_SessionManager;

        public IncomeSource(SessionManager sessionManager)
        {
            m_SessionManager = sessionManager;
        }

        public IncomeSource(decimal InAmount, IncomeFrequency InFrequency, string InName, SessionManager sessionManager)
        {

            m_Amount = InAmount;
            m_Frequency = InFrequency;
            m_Name = InName;
            m_SessionManager = sessionManager;
            var activeProfile = m_SessionManager.GetActiveProfile();
            if (activeProfile != null)
            {
                activeProfile.Deposit(InAmount);
            }
            else
            {
                MessageBox.Show("No Active Profile"); //


            }


            //m_SessionManager.GetActiveProfile().Deposit(InAmount);



        }
    }

}
