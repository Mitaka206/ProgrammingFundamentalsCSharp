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

            CompareCharArrays(first, second);
        }

        private static void CompareCharArrays(char[] first, char[] second)
        {
            int minChars = Math.Min(first.Length, second.Length);

            int countFirst = 0;
            int countSecond = 0;

            bool areDiferent = false;
            for (int i = 0; i < minChars; i++)
            {
                if (first[i] > second[i])
                {
                    countFirst++;
                    Console.WriteLine(string.Join("", second));
                    Console.WriteLine(string.Join("", first));
                    areDiferent = true;
                    break;
                }
                else if (first[i] < second[i])
                {
                    countSecond++;
                    Console.WriteLine(string.Join("", first));
                    Console.WriteLine(string.Join("", second));
                    areDiferent = true;
                    break;
                }
            }

            if (!areDiferent)
            {
                if (countFirst <= countSecond)
                {
                    Console.WriteLine(string.Join("", first));
                    Console.WriteLine(string.Join("", second));
                }
                else
                {
                    Console.WriteLine(string.Join("", second));
                    Console.WriteLine(string.Join("", first));

                }
            }
        }
    }
}