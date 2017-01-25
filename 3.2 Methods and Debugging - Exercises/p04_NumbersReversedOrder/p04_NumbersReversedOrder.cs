using System;
using System.Linq;

namespace p04_NumbersReversedOrder
{
    class p04_NumbersReversedOrder
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            
            Console.WriteLine(number.ToCharArray().Reverse().ToArray());
        }
    }
}
