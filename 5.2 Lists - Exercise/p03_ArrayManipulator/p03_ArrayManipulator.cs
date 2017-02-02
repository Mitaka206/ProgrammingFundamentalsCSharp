using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_ArrayManipulator
{
    class p03_ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] commandLine = Console.ReadLine().Split().ToArray();
            
            while (!commandLine[0].Equals("print"))
            {
                switch (commandLine[0])
                {
                    case "add":
                        int index = int.Parse(commandLine[1]);
                        int element = int.Parse(commandLine[2]);
                        input.Insert(index, element);
                        break;

                    case "contains":
                        index = int.Parse(commandLine[1]);
                        if (input.Contains(index))
                        {
                            var output = input.ToArray();
                            Console.WriteLine(Array.IndexOf(output, index));
                        }
                        else
                        {
                            Console.WriteLine(-1);
                        }
                        break;

                    case "addMany":
                        int fromPosition = int.Parse(commandLine[1]);
                        if (fromPosition > input.Count)
                        {
                            break;
                        }
                        for (int i = commandLine.Length - 1; i >= 2; i--)
                        {
                            input.Insert(fromPosition, (int.Parse)(commandLine[i]));
                        }
                        break;

                    case "remove":
                        index = int.Parse(commandLine[1]);
                        input.RemoveAt(index);
                        break;

                    case "shift":
                        fromPosition = int.Parse(commandLine[1]);
                        RotateLeft(input, fromPosition);

                        break;

                    case "sumPairs":
                        for (int i = 0; i < input.Count; i++)
                        {
                            input[i] += input[i + 1];
                            input.RemoveAt(i + 1);
                        }
                        break;
                }

                commandLine = Console.ReadLine().Split().ToArray();
            }
            
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
        public static void RotateLeftOnce(List<int> input)
        {
            int numToSwitch = input[0];
            for (int i = 0; i < input.Count; i += 1)
            {
                if (i + 1 < input.Count)
                {
                    int switcher = input[i];
                    input[i] = input[i + 1];
                    input[i + 1] = switcher;
                }
            }
        }
        public static void RotateLeft(List<int> input, int positions)
        {
            for (var i = 0; i < positions; i += 1)
            {
                RotateLeftOnce(input);
            }
        }
    }
}
