using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactorSpecialNumbers
{
    class p09_refactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int sum = 0;
            int digits = 0;
            bool isSecial = false;

            for (int num = 1; num <= numbers; num++)
            {
                digits = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }

                isSecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{digits} -> {isSecial}");

                sum = 0;
                num = digits;
            }
        }
    }
}
