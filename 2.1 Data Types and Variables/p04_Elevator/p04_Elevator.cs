using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_Elevator
{
    class p04_Elevator
    {
        static void Main(string[] args)
        {
            double persons = int.Parse(Console.ReadLine());

            int capacity = int.Parse(Console.ReadLine());

            int machElevate = (int)(Math.Ceiling(persons/capacity));

            Console.WriteLine(machElevate);
        }
    }
}
