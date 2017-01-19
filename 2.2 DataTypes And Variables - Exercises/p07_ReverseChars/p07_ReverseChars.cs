using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_ReverseChars
{
    class p07_ReverseChars
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());


            Console.WriteLine($"{thirdChar}{secondChar}{firstChar}");

        }
    }
}
