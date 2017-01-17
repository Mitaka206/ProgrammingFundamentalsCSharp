using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo date = System.Globalization.CultureInfo.InvariantCulture;

            String format = "dd/MM/yyyy";

            DateTime dat = DateTime.ParseExact(Console.ReadLine(), format, date);

            Console.WriteLine(dat);
        }
    }
}
