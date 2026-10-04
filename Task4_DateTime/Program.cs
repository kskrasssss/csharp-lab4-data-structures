using System;
using System.Globalization;

namespace Lab4Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime eventDate;

            // Просимо ввести дату у фіксованому форматі, поки не буде введено правильно
            while (true)
            {
                Console.Write("Введіть дату і час події (дд.мм.рррр гг:хх), наприклад 24.08.1991 12:30: ");
                string input = Console.ReadLine();

                if (DateTime.TryParseExact(input, "dd.MM.yyyy HH:mm",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out eventDate))
                {
                    break;
                }
                Console.WriteLine("Неправильний формат, спробуйте ще раз.\n");
            }

            long minutes = EventAnalyzer.MinutesFromYearStart(eventDate);
            string dayOfWeek = EventAnalyzer.GetDayOfWeekName(eventDate);

            Console.WriteLine();
            Console.WriteLine("Подія: " + eventDate.ToString("dd.MM.yyyy HH:mm"));
            Console.WriteLine("Від початку року минуло хвилин: " + minutes);
            Console.WriteLine("Тобто це була " + (minutes + 1) + "-а хвилина року");
            Console.WriteLine("День тижня: " + dayOfWeek);
        }
    }
}
