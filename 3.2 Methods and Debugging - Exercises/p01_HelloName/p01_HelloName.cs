using System;

namespace p01_HelloName
{
    class p01_HelloName
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            OutpuName(input);
        }

        private static void OutpuName(string input)
        {
            Console.WriteLine($"Hello, {input}!");
        }
    }
}
