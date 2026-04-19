/********************************************
Name: IncomeSource.cs
Purpose: 
Notes: Authored by Ella 
********************************************/

using BudgetPlanner;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Windows.Management;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BudgetPlanner
{
	//EP Start

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
	
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

		private TimelineCalculator m_TimelineCalculator;

		public IncomeFrequency GetFrequency() { return m_Frequency; }
        public decimal GetAmount() { return m_Amount; }
        public string GetName() { return m_Name; }
        public DateTime GetStartDate() { return StartDate; }
        public DateTime GetEndDate() { return EndDate; }

	
		public IncomeSource()
		{
		}

		public IncomeSource(decimal InAmount, IncomeFrequency InFrequency, string InName, DateTime InStartDate, DateTime InEndDate)
		{

			m_Amount = InAmount;
			m_Frequency = InFrequency;
			m_Name = InName;
			StartDate = InStartDate;
			CalendarRepeatType repeatType = GetCalendarRepeatType(InFrequency);
			m_TimelineCalculator = new TimelineCalculator(InName, StartDate, repeatType);
			{
				EndDate = EndDate;
			};
		}
		public void ApplyInitialDeposit(SessionManager InSessionManager)
		{
		

			var activeProfile = InSessionManager.GetActiveProfile();
			if (activeProfile != null)
			{

				{
					activeProfile.Deposit(m_Amount);

					// DC
                    Transactions temp = new Transactions(m_Amount, "Deposit", "Income");
                    activeProfile.AddTransaction(temp);
					//
                }
			}
			else
			{
				MessageBox.Show("No Active Profile"); 


			}
		}

	
		private CalendarRepeatType GetCalendarRepeatType(IncomeFrequency frequency)
		{
			switch (frequency)
			{
				case IncomeFrequency.Daily:
					return CalendarRepeatType.Day;
				case IncomeFrequency.Monthly:
					return CalendarRepeatType.Month;
				case IncomeFrequency.Yearly:
					return CalendarRepeatType.Year;
				default:
					return CalendarRepeatType.None;
			}

		}
		public void CheckAndApplyDeposit(SessionManager InSessionManager)
		{
			var activeProfile = InSessionManager.GetActiveProfile();
			if (activeProfile == null)
			{

				MessageBox.Show("No Active Profile");
				return;
			}
			if (m_TimelineCalculator.OccursToday(DateTime.Now))
			{
				activeProfile.Deposit(m_Amount);

				// DC
                Transactions temp = new Transactions(m_Amount, "Deposit", "Income");
                activeProfile.AddTransaction(temp);
				//
            }


		



		}
	}

}
//EP end