using System;
using System.Collections.Generic;
using System.Globalization;

namespace p01_CountWorkDays
{
    class p01_CountWorkDays
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);

            List<DateTime> holidays = new List<DateTime>() {
                DateTime.ParseExact("01-01-2016", "d-M-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-01-2016", "d-M-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-2016", "d-M-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-2016", "d-M-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-2016", "d-M-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-2016", "d-M-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-2016", "d-M-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-2016", "d-M-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-2016", "d-M-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-2016", "d-M-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-2016", "d-M-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-2016", "d-M-yyyy", CultureInfo.InvariantCulture),
            };

            int days = 0;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                DateTime check = new DateTime(2016, i.Month, i.Day);
                if (i.DayOfWeek != DayOfWeek.Saturday
                    && i.DayOfWeek != DayOfWeek.Sunday
                    && !holidays.Contains(check))
                {
                    days++;
                }
            }

            Console.WriteLine(days);
        }
    }
}
