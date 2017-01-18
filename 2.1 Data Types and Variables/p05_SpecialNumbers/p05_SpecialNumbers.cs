using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05_SpecialNumbers
{
    class p05_SpecialNumbers
    {

        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 1; i <= range; i++)
            {
                int firstDigit = 0;
                int secondDigit = 0;

                if (i >= 10)
                {
                    firstDigit = i / 10;
                    secondDigit = i % 10;

                }

                bool result = (i < 10 && (i == 5 || i == 7)) || (firstDigit + secondDigit == 5) || (firstDigit + secondDigit == 7) || (firstDigit + secondDigit == 11);

                Console.WriteLine($"{i} -> {result}");

            }
        }
    }
}
