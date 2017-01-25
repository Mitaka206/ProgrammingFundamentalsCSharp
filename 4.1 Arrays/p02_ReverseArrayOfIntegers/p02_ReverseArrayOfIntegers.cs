using System;
using System.Linq;

namespace p02_ReverseArrayOfIntegers
{
    class p02_ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                numbers[i] = num;
            }
            
            Console.WriteLine(string.Join(" ", numbers.Reverse()));
        }
    }
}
