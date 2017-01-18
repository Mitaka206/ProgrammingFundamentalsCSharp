using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ceturies= ");
            int cenure = int.Parse(Console.ReadLine());

            int years = cenure * 100;
            int days = (int)(years*365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{cenure} cenuturies = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
