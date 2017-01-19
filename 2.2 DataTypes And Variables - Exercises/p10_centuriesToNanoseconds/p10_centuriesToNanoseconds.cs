using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace p10_centuriesToNanoseconds
{
    class p10_centuriesToNanoseconds
    {
        static void Main(string[] args)
        {
            byte centuresInput = byte.Parse(Console.ReadLine());
            short years = (short)(centuresInput * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliSeconds = seconds * 1000;
            long microSeconds = milliSeconds * 1000;
            BigInteger nanoSeconds = BigInteger.Multiply(microSeconds, 1000);
            //long dasdas = (long)nanoSeconds;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
               centuresInput, years, days, hours, minutes, seconds, milliSeconds, microSeconds, nanoSeconds);
        }
    }
    }
}
