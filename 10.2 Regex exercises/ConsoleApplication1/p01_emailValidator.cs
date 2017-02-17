using System;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class p01_emailValidator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var output = Regex.Matches(input, @"([\w\.\-]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)");

            foreach (Match item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
