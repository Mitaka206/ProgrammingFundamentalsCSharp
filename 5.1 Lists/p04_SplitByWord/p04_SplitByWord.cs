using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_SplitByWord
{
    class p04_SplitByWord
    {
        static void Main(string[] args)
        {
            char[] delimiters = ",;:.!()\"\'\\/[] ".ToCharArray();

            List<string> input = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();

            foreach (var word in input)
            {
                if (word.Any(x => !char.IsLetter(x)))
                {
                    mixedCaseWords.Add(word);
                }
                else if (word.ToUpper().Equals(word))
                {
                    upperCaseWords.Add(word);
                }
                else if (word.ToLower().Equals(word))
                {
                    lowerCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }
    }
}

