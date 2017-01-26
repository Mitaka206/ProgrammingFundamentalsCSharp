using System;
using System.Linq;

namespace p09_ExtractMiddleElements
{
    class p09_ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int middle = numbers.Length / 2;

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else if (numbers.Length % 2 == 0)
            {
                Console.WriteLine($"{numbers[middle - 1]} {numbers[middle]}");
            }
            else
            {
                Console.WriteLine($"{numbers[middle - 1]} {numbers[middle]} {numbers[middle + 1]}");
            }
        }
    }
}
