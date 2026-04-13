/********************************************
Name: CalendarEvent.cs
Purpose: 
Notes: Authored by Daniel
********************************************/

using BudgetPlanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetPlanner
{
    internal static class CalendarUtils
    {
        public static DateTime GetWeekStart(DateTime InDateTime)
        {
            int diff = (int)InDateTime.DayOfWeek; // Sunday = 0
            return InDateTime.Date.AddDays(-diff);
        }

        public static DateTime GetWeekEnd(DateTime InDateTime)
        {
            return InDateTime.Date.AddDays(7);
        }

        public static DateTime GetMonthStart(DateTime InDateTime)
        {
            return new DateTime(InDateTime.Year, InDateTime.Month, 1);
        }
        public static DateTime GetMonthEnd(DateTime InDateTime)
        {
            DateTime monthStart = new DateTime(InDateTime.Year, InDateTime.Month, 1);
            return monthStart.AddMonths(1).AddDays(-1);
        }
        public static DateTime GetYearStart(DateTime InDateTime)
        {
            return new DateTime(InDateTime.Year, 1, 1);
        }
        public static DateTime GetYearEnd(DateTime InDateTime)
        {
            return new DateTime(InDateTime.Year, 12, 31);
        }

    }

    public enum CalendarRepeatType
    {
        None = 0,
        Day,
        Week,
        Month,
        Year
    }

    public class TimelineCalculator
    {
        public string Name;
        public string Description;

        public DateTime StartDate;
        public DateTime EndDate;

        public uint RepeatFrequency = 1; // Repeat every [ex. 1] ...
        public CalendarRepeatType RepeatType; // ... [ex. Week]

        public CalendarWeekMask WeekMask;

        public TimelineCalculator(string InName, DateTime InStartDate, CalendarRepeatType InRepeatType) 
        {
            Name = InName;
            StartDate = InStartDate;
            RepeatType = InRepeatType;
        }

        public List<DateTime> GetOccurrencesInRange(DateTime InStartTime, DateTime InEndTime)
        {
            var result = new List<DateTime>();

            for (DateTime day = InStartTime; day <= InEndTime; day = day.AddDays(1))
            {
                if (OccursToday(day))
                {
                    result.Add(day);
                }
            }

            return result;
        }

        public List<DateTime> GetOccurrencesInYear(int InYear)
        {
            DateTime dateTime = new DateTime(InYear, 1, 1);

            DateTime yearStart = CalendarUtils.GetYearStart(dateTime);
            DateTime yearEnd = CalendarUtils.GetYearEnd(dateTime);

            return GetOccurrencesInRange(yearStart, yearEnd);
        }

        public List<DateTime> GetOccurrencesInMonth(int InYear, int InMonth)
        {
            DateTime dateTime = new DateTime(InYear, InMonth, 1);

            DateTime monthStart = CalendarUtils.GetMonthStart(dateTime);
            DateTime monthEnd = CalendarUtils.GetMonthEnd(dateTime);

            return GetOccurrencesInRange(monthStart, monthEnd);
        }

        public List<DateTime> GetOccurrencesInWeek(int InYear, int InMonth, int InDay)
        {
            DateTime dateTime = new DateTime(InYear, InMonth, 1);

            DateTime weekStart = CalendarUtils.GetWeekStart(dateTime);
            DateTime weekEnd = CalendarUtils.GetWeekEnd(dateTime);

            return GetOccurrencesInRange(weekStart, weekEnd);
        }

        public bool OccursToday(DateTime today)
        {
            if (today < StartDate)
                return false;

            if (EndDate != DateTime.MinValue && today > EndDate)
                return false;

            switch (RepeatType)
            {
                case CalendarRepeatType.Day:
                    return OccursTodayDaily(today);

                case CalendarRepeatType.Week:
                    return OccursTodayWeekly(today);

                case CalendarRepeatType.Month:
                    return OccursTodayMonthly(today);

                case CalendarRepeatType.Year:
                    return OccursTodayYearly(today);
            }

            return false;
        }

        bool OccursTodayYearly(DateTime InToday)
        {
            if (InToday.Month != StartDate.Month || InToday.Day != StartDate.Day)
                return false;

            int years = InToday.Year - StartDate.Year;

            return years % RepeatFrequency == 0;
        }

        bool OccursTodayMonthly(DateTime InToday)
        {
            // Must match the day number
            if (InToday.Day != StartDate.Day)
                return false;

            int months =
                (InToday.Year - StartDate.Year) * 12 +
                (InToday.Month - StartDate.Month);

            return months % RepeatFrequency == 0;
        }

        bool OccursTodayWeekly(DateTime InToday)
        {
            // Check if today is one of the allowed days
            if (!WeekMask.Contains(InToday.DayOfWeek))
                return false;

            // How many weeks since the start?
            int weeks = (int)((InToday - StartDate).TotalDays / 7);

            return weeks % RepeatFrequency == 0;
        }
        bool OccursTodayDaily(DateTime InToday)
        {
            int days = (InToday - StartDate).Days;
            return days % RepeatFrequency == 0;
        }
    }
}
