/********************************************
Name: IncomeSource.cs
Purpose: 
Notes: Authored by Ella 
********************************************/

using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetPlanner;
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
		private readonly SessionManager m_SessionManager;
	
		private TimelineCalculator m_TimelineCalculator;
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }


	
		public IncomeSource(SessionManager sessionManager)
		{
			m_SessionManager = sessionManager;
		}

		public IncomeSource(decimal InAmount, IncomeFrequency InFrequency, string InName, SessionManager sessionManager, DateTime InStartDate, DateTime InEndDate)
		{

			m_Amount = InAmount;
			m_Frequency = InFrequency;
			m_Name = InName;
			m_SessionManager = sessionManager;
			StartDate = InStartDate;
			CalendarRepeatType repeatType = GetCalendarRepeatType(InFrequency);
			m_TimelineCalculator = new TimelineCalculator(InName, StartDate, repeatType);
			{
				EndDate = EndDate;
			}
			;
			ApplyInitialDeposit();
		}
		private void ApplyInitialDeposit()
		{
		

			var activeProfile = m_SessionManager.GetActiveProfile();
			if (activeProfile != null)
			{

				{
					activeProfile.Deposit(m_Amount);
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
		public void CheckAndApplyDeposit()
		{
			var activeProfile = m_SessionManager.GetActiveProfile();
			if (activeProfile == null)
			{

				MessageBox.Show("No Active Profile");
				return;
			}
			if (m_TimelineCalculator.OccursToday(DateTime.Now))
			{
				activeProfile.Deposit(m_Amount);



			}


		



		}
	}

}
//EP end