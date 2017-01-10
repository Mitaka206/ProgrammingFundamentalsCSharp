using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exatSumOfReal_numbers
{
    class exatSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal ok = 0;

            for (int i = 0; i < n; i++)
            {
               decimal num = decimal.Parse(Console.ReadLine());
                ok += num;
            }

            Console.WriteLine(ok);
        }
    }
}
