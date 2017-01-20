using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_DateTime
{
    class p01_DateTime
    {
        static void Main(string[] args)
        {
            string[] dayOfweek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int numOfday = int.Parse(Console.ReadLine());

            if (numOfday > 0 && numOfday <= 7)
            {
                Console.WriteLine(dayOfweek[numOfday - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
