using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SkiaSharp.HarfBuzz.SKShaper;

namespace BudgetPlanner
{

    public class Calendar
    {
        private List<CalendarEvent> m_Events = new List<CalendarEvent>();

        public void Plan(CalendarEvent InEvent)
        {
            m_Events.Add(InEvent);  
        }

        public List<CalendarEvent> GetEventsAtDate(DateTime InDateTime)
        {
            List<CalendarEvent> result = new List<CalendarEvent>();

            foreach(var e in m_Events) 
                if(e.OccursToday(InDateTime))
                    result.Add(e);

            return result;
        }

        public Dictionary<DayOfWeek, List<CalendarEvent>> GetEventsThisWeek(DateTime InDateTime)
        {
           var result = new Dictionary<DayOfWeek, List<CalendarEvent>>();

            foreach (var e in m_Events)
            {
                if(e.OccursThisWeek(InDateTime, out var days))
                {
                    foreach (var day in days) 
                    {
                        if (!result.ContainsKey(day))
                            result.Add(day, new List<CalendarEvent>());

                        result[day].Add(e);
                    }
                }
            }

            return result;
        }

        public Dictionary<DateTime, List<CalendarEvent>> GetEventThisMonth(DateTime InDateTime)
        {
            DateTime monthStart = Utils.GetMonthStart(InDateTime);
            DateTime monthEnd = Utils.GetMonthEnd(InDateTime);

            return GetEventsInRange(monthStart, monthEnd);
        }

        public Dictionary<DateTime, List<CalendarEvent>> GetEventThisYear(DateTime InDateTime)
        {
            DateTime yearStart = Utils.GetYearStart(InDateTime);
            DateTime yearEnd = Utils.GetYearEnd(InDateTime);

            return GetEventsInRange(yearStart, yearEnd);
        }

        public Dictionary<DateTime, List<CalendarEvent>> GetEventsInRange(DateTime InStartDate, DateTime InEndDate)
        {
            var result = new Dictionary<DateTime, List<CalendarEvent>>();

            foreach (var e in m_Events)
            {
                if (e.OccursInRange(InStartDate, InEndDate, out var days))
                {
                    foreach (var day in days)
                    {
                        if (!result.ContainsKey(day))
                            result.Add(day, new List<CalendarEvent>());

                        result[day].Add(e);
                    }
                }
            }

            return result;
        }
    }
}
