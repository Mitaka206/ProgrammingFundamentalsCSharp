using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_EnduranceRally
{
    class p03_EnduranceRally
    {
        static void Main(string[] args)
        {
            var racers = Console.ReadLine().Split().ToArray();
            var forFuel = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var index = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int fuel = (int)racers[0].ToCharArray().First();

            if (true)
            {
                //get from forfuel
            }


            Console.WriteLine(fuel);
            
        }
    }
}
