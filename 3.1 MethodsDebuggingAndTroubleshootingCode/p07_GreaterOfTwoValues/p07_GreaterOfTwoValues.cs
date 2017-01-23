using System;

namespace p07_GreaterOfTwoValues
{
    class p07_GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();

            Console.WriteLine(GetMax(Console.ReadLine(), Console.ReadLine()));

        }

        public static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        public static char GetMax(char first, char second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        public static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }
    }
}
