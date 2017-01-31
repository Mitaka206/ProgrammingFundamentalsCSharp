using System;
using System.Linq;

namespace p04_SumReversedNumbers
{
    class p04_SumReversedNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            for (int i = 0; i < input.Count; i++)
            {
                input[i] = RevString(input[i]);
            }
            int sum = input.Select(int.Parse).Sum();

            Console.WriteLine(sum);
        }

        private static string RevString(string v)
        {
            char[] cArray = v.ToCharArray();
            string reverse = String.Empty;

            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }

            return reverse;
        }
    }
}
