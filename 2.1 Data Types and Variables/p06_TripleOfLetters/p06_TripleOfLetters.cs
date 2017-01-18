using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_TripleOfLetters
{
    class p06_TripleOfLetters
    {
        static void Main(string[] args)
        {
            int charNums = int.Parse(Console.ReadLine());

            for (int i1 = 0; i1 < charNums; i1++)
            {
                for (int i2 = 0; i2 < charNums; i2++)
                {
                    for (int i3 = 0; i3 < charNums; i3++)
                    {
                        char leter1 = (char)('a' + i1);
                        char leter2 = (char)('a' + i2);
                        char leter3 = (char)('a' + i3);

                        Console.WriteLine("{0}{1}{2}", leter1, leter2, leter3);

                    }
                }
            }
        }
    }
}
