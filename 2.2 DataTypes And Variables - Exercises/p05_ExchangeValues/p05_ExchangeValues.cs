using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05_ExchangeValues
{
    class p05_ExchangeValues
    {
        static void Main(string[] args)
        {

            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstDigit}");
            Console.WriteLine($"b = {secondDigit}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {secondDigit}");
            Console.WriteLine($"b = {firstDigit}");

            //What's the problem???!?!?!?
            //Console.Write($"Before:\n\ra = {firstDigit}\n\rb = {secondDigit}\n\r");
            //Console.Write($"After:\n\ra = {secondDigit}\n\rb = {firstDigit}\n\r");
        }
    }
}
