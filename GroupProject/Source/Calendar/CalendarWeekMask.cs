using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public enum CalendarBits
    {
        None = 0,
        Sunday = 1 << 0,
        Monday = 1 << 1,
        Tuesday = 1 << 2,
        Wednesday = 1 << 3,
        Thursday = 1 << 4,
        Friday = 1 << 5,
        Saturday = 1 << 6
    }

    public class CalendarWeekMask
    {
        public CalendarBits Mask { get; private set; }

        public CalendarWeekMask(CalendarBits mask = CalendarBits.None)
        {
            Mask = mask;
        }

        public void AddDay(CalendarBits day)
        {
            Mask |= day;
        }

        public void RemoveDay(CalendarBits day)
        {
            Mask &= ~day;
        }

        public bool Contains(DayOfWeek day)
        {
            return (Mask & ToCalendarWeek(day)) != 0;
        }

   

        private CalendarBits ToCalendarWeek(DayOfWeek day)
        {
            return day switch
            {
                DayOfWeek.Sunday => CalendarBits.Sunday,
                DayOfWeek.Monday => CalendarBits.Monday,
                DayOfWeek.Tuesday => CalendarBits.Tuesday,
                DayOfWeek.Wednesday => CalendarBits.Wednesday,
                DayOfWeek.Thursday => CalendarBits.Thursday,
                DayOfWeek.Friday => CalendarBits.Friday,
                DayOfWeek.Saturday => CalendarBits.Saturday,
                _ => CalendarBits.None
            };
        }
    }

}
