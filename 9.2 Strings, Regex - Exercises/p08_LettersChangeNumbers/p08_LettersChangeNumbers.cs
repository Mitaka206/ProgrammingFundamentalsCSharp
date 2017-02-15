using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08_LettersChangeNumbers
{
    class p08_LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            var input = "A12b";

            var number = int.Parse(input.ToLower().Trim(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }));

            int sum = 0;

            var letterNumsUpper = new Dictionary<char, int>();
            int num = 1;
            for (char j = 'a'; j <= 'z'; j++)
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
                sum = number * letterNumsUpper[input[0]];
            }

            input.Reverse();
            if (letterNumsUpper.ContainsKey(input[0]))
            {
                sum = sum - letterNumsUpper[input[0]];
            }

            if (letterNumsLow.ContainsKey(input[0]))
            {
                sum = sum + letterNumsUpper[input[0]];
            }

            Console.WriteLine(sum);
        }
    }
}
