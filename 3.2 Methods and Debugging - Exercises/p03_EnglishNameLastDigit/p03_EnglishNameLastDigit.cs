using System;
using System.Linq;

namespace p03_EnglishNameLastDigit
{
    class p03_EnglishNameLastDigit
    {
        static void Main(string[] args)
        {
            var input = long.Parse(Console.ReadLine());

            DigitName(input);
        }

        public static void DigitName(long input)
        {
            var last = Convert.ToInt32(input.ToString() 
                                        .AsEnumerable()
                                        .Last()
                                        .ToString());

            string[] englNames = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

            for (int i = 0; i < englNames.Length; i++)
            {
                if (last == i)
                {
                    Console.WriteLine(englNames[i]);
                    break;
                }
            }
        }
    }
}
