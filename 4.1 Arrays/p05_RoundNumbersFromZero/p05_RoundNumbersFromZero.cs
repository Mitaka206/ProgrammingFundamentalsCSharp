using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05_RoundNumbersFromZero
{
    class p05_RoundNumbersFromZero
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            double[] numbers = new double[input.Length];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(input[i]);

                Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i], 0, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
