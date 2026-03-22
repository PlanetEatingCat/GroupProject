using BudgetPlanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    internal static class Utils
    {
        public static DateTime GetWeekStart(DateTime InDateTime)
        {
            int diff = (int)InDateTime.DayOfWeek; // Sunday = 0
            return InDateTime.Date.AddDays(-diff);
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

    public struct CalendarEvent
    {
        public string Name;
        public string Description;

        public DateTime StartDate;
        public DateTime EndDate;

        public uint RepeatFrequency; // Repeat every [ex. 1] ...
        public CalendarRepeatType RepeatType; // ... [ex. Week]

        public CalendarWeekMask WeekMask;

        public bool OccursInRange(DateTime InStartTime, DateTime InEndTime, out List<DateTime> OutDays)
        {
            OutDays = new List<DateTime>();

            for (DateTime day = InStartTime; day <= InEndTime; day = day.AddDays(1))
            {
                if (OccursToday(day))
                {
                    OutDays.Add(day);
                    return true;
                }
            }

            return false;
        }

        public bool OccursThisYear(DateTime InDateTime, out List<DateTime> OutDays)
        {
            DateTime yearStart = Utils.GetYearStart(InDateTime);
            DateTime yearEnd = Utils.GetYearEnd(InDateTime);

            return OccursInRange(yearStart, yearEnd, out OutDays);
        }

        public bool OccursThisMonth(DateTime InDateTime, out List<DateTime> OutDays)
        {
            OutDays = new List<DateTime>();
            DateTime monthStart = Utils.GetMonthStart(InDateTime);
            DateTime monthEnd = Utils.GetMonthEnd(InDateTime);

            return OccursInRange(monthStart, monthEnd, out OutDays);
        }

        public bool OccursThisWeek(DateTime InDateTime, out List<DayOfWeek> OutDays)
        {
            OutDays = new List<DayOfWeek>();
            DateTime weekStart = Utils.GetWeekStart(InDateTime);

            for (int i = 0; i < 7; i++)
            {
                DateTime day = weekStart.AddDays(i);

                if (OccursToday(day))
                {
                    OutDays.Add(day.DayOfWeek);
                    return true;
                }
            }

            return false;
        }

        public bool OccursToday(DateTime today)
        {
            if (today < StartDate)
                return false;

            if (today > EndDate)
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
