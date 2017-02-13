using System;

namespace p02_CountSubstringOccurrences
{
    class p02_CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();

            var checkString = Console.ReadLine().ToLower();

            int counter = 0;

            int index = input.IndexOf(checkString);

            while (index != -1)
            {
                counter++;
                index = input.IndexOf(checkString, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
