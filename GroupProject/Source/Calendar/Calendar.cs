/********************************************
Name: Calendar.cs
Purpose: 
Notes: WIP.
********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalendarEventID = System.Guid;

namespace BudgetPlanner
{
    public class Calendar
    {
        private Dictionary<CalendarEventID, CalendarEvent> m_Events = new Dictionary<CalendarEventID, CalendarEvent>();

        public void Plan(CalendarEvent InEvent)
        {
            m_Events.Add(InEvent.ID, InEvent);  
        }

        public void Cancel(CalendarEventID InEventID)
        {
            m_Events.Remove(InEventID);
        }

        public List<CalendarEvent> GetEventsAtDate(DateTime InDateTime)
        {
            List<CalendarEvent> result = new List<CalendarEvent>();

            foreach(var e in m_Events.Values) 
                if(e.OccursToday(InDateTime))
                    result.Add(e);

            return result;
        }

        public Dictionary<DayOfWeek, List<CalendarEvent>> GetEventsThisWeek(DateTime InDateTime)
        {
           var result = new Dictionary<DayOfWeek, List<CalendarEvent>>();

            foreach (var e in m_Events.Values)
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
            DateTime monthStart = CalendarUtils.GetMonthStart(InDateTime);
            DateTime monthEnd = CalendarUtils.GetMonthEnd(InDateTime);

            return GetEventsInRange(monthStart, monthEnd);
        }

        public Dictionary<DateTime, List<CalendarEvent>> GetEventThisYear(DateTime InDateTime)
        {
            DateTime yearStart = CalendarUtils.GetYearStart(InDateTime);
            DateTime yearEnd = CalendarUtils.GetYearEnd(InDateTime);

            return GetEventsInRange(yearStart, yearEnd);
        }

        public Dictionary<DateTime, List<CalendarEvent>> GetEventsInRange(DateTime InStartDate, DateTime InEndDate)
        {
            var result = new Dictionary<DateTime, List<CalendarEvent>>();

            foreach (var e in m_Events.Values)
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
