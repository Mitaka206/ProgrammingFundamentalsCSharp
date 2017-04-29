using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace p3
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var hornets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var hornetsPower = hornets.Sum();

            var total = new List<int>();

            for (int i = 0; i < beehives.Length; i++)
            {
                if (hornetsPower < beehives[i])
                {
                    var diff = hornetsPower - hornets[0];
                    total.Add(Math.Abs(hornetsPower - beehives[i]));
                    hornetsPower -= hornets[0];
                }

                if (hornetsPower == beehives[i])
                {
                    var diff = hornetsPower - hornets[0];

                    hornets = hornets.Skip(1).ToArray();
                }
            }

            if (total.Count != 0)
            {
                Console.WriteLine(string.Join(" ", total));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}
