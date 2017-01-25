﻿using System;
using System.Globalization;

namespace p09_DebugCodeHolidays
{
    class p09_DebugCodeHolidays
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd.m.yyyy", CultureInfo.InvariantCulture);

            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd.m.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;

            for (var date = startDate; date <= endDate; date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday && date.DayOfWeek == DayOfWeek.Sunday)
                    holidaysCount++;
            }
            
            Console.WriteLine(holidaysCount);
        }
    }// for more debuging
}
