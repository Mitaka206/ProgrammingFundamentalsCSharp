using System;

namespace p05_CompareCharArrays
{
    class p05_CompareCharArrays
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string[] secondLine = Console.ReadLine().Split();

            char[] first = new char[firstLine.Length];
            char[] second = new char[firstLine.Length];

            for (int i = 0; i < firstLine.Length; i++)
            {
                first[i] = char.Parse(firstLine[i]);
            }

            for (int i = 0; i < secondLine.Length; i++)
            {
                second[i] = char.Parse(secondLine[i]);
            }
            
            if (second.Length > first.Length)
            {
                Console.WriteLine(string.Join("", second));
                Console.WriteLine(string.Join("", first));
            }
            else
            {
                Console.WriteLine(string.Join("", first));
                Console.WriteLine(string.Join("", second));
            }
        }
    }
}