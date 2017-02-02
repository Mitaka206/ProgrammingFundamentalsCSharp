using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_ShortWordsSorted
{
    class p05_ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] delimiters = ",;:.!()\"\'\\/[] ".ToCharArray();

            List<string> input = Console.ReadLine()
                .ToLower()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var output = input.Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .ToArray();
            
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
