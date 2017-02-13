using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Palindromes
{
    class p04_Palindromes
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ', '.', ',', '?', '!'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> output = new List<string>();

            foreach (var item in input)
            {
                if (IsPalindrome(item))
                {
                    output.Add(item);
                }
            }

            Console.WriteLine(string.Join(", ", output.Distinct().OrderBy(x => x)));
        }

        private static bool IsPalindrome(string word)
        {
            bool result = true;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
