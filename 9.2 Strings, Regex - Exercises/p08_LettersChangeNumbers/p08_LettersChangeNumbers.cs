using System;
using System.Collections.Generic;
using System.Linq;

namespace p08_LettersChangeNumbers
{
    class p08_LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            decimal sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += ReesultOfstring(input[i]);
            }
            Console.WriteLine("{0:f2}", sum);
        }

        private static decimal ReesultOfstring(string input)
        {
            var number = decimal.Parse(input.ToLower().Trim(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }));

            decimal sum = 0;

            var letterNumsUpper = new Dictionary<char, int>();
            int num = 1;
            for (char j = 'A'; j <= 'Z'; j++)
            {
                letterNumsUpper[j] = num;
                num++;
            }
            var letterNumsLow = new Dictionary<char, int>();
            int numL = 1;

            for (char j = 'a'; j <= 'z'; j++)
            {
                letterNumsLow[j] = numL;
                numL++;
            }

            if (letterNumsUpper.ContainsKey(input[0]))
            {
                sum = number / letterNumsUpper[input[0]];
            }

            if (letterNumsLow.ContainsKey(input[0]))
            {
                sum = number * letterNumsLow[input[0]];
            }

            if (letterNumsUpper.ContainsKey(input.Last()))
            {
                sum -= letterNumsUpper[input.Last()];
            }
            else
            {
                sum += letterNumsLow[input.Last()];
            }

            return sum;
        }
    }
}
