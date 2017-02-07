using System;
using System.Linq;

namespace p02_CommandInputer
{
    class p02_CommandInputer
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var arrayForChange = input.Split().ToArray();
                var commandLine = Console.ReadLine().Split().ToArray();

                string command = commandLine[0];
                int start = int.Parse(commandLine[2]);
                int count = int.Parse(commandLine[4]);

                if (start >= 0 && count >= 0 && start <= 20 && count <= 20)
                {
                    if (command == "reverse")
                    {
                        var part = arrayForChange.Skip(start).Take(count).Reverse().ToArray();
                        string[] output = ConcatMethod(arrayForChange, start, count, part);

                        Console.WriteLine($"[{string.Join(", ", output)}]");
                    }
                    if (command == "sort")
                    {
                        var part = arrayForChange.Skip(start).Take(count).OrderBy(x => x).ToArray();
                        string[] output = ConcatMethod(arrayForChange, start, count, part);

                        Console.WriteLine($"[{string.Join(", ", output)}]");
                    }
                    if (command == "rollLeft")
                    {

                    }
                    if (command == "rollRigh")
                    {

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                input = Console.ReadLine();
            }
        }

        private static string[] ConcatMethod(string[] arrayForChange, int start, int count, string[] part)
        {
            var outputLeft = arrayForChange.Take(start).ToArray();
            var outputRight = arrayForChange.Skip(start + count).ToArray();
            var outputFirst = outputLeft.Concat(part).ToArray();
            var output = outputFirst.Concat(outputRight).ToArray();
            return output;
        }
    }
}
