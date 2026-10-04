using System;
using System.Globalization;

namespace Lab4Task4
{
    public static class EventAnalyzer
    {
        // Скільки повних хвилин минуло від 1 січня 00:00 до дати події
        public static long MinutesFromYearStart(DateTime eventDate)
        {
            // Початок того ж року
            DateTime yearStart = new DateTime(eventDate.Year, 1, 1);

            // Віднімання двох DateTime дає TimeSpan (проміжок часу)
            TimeSpan passed = eventDate - yearStart;

            return (long)passed.TotalMinutes;
        }

        // День тижня українською мовою
        public static string GetDayOfWeekName(DateTime eventDate)
        {
            return eventDate.ToString("dddd", new CultureInfo("uk-UA"));
        }
    }
}