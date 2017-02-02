using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_SumMinMaxAverage
{
    class p03_SumMinMaxAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<double> output = new List<double>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                output.Add(input);
            }

            Console.WriteLine("Sum = " + output.Sum());
            Console.WriteLine("Min = " + output.Min());
            Console.WriteLine("Max = " + output.Max());
            Console.WriteLine("Average = " + output.Average());
        }
    }
}
