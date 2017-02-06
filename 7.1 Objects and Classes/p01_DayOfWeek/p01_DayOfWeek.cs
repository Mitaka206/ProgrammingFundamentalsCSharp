using System;
using System.Globalization;

namespace p01_DayOfWeek
{
    class p01_DayOfWeek
    {
        static void Main(string[] args)
        {
            var inputDate = Console.ReadLine();

            var date = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
