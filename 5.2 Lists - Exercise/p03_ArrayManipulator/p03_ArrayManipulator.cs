using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_ArrayManipulator
{
    class p03_ArrayManipulator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var commandLine = Console.ReadLine().Split().ToList();

            string command = commandLine[0];
            var actions = commandLine.Skip(1).Select(int.Parse).ToArray();

            int index = 0;
            int element = 0;
            int position = 0;
            int contains = 0;

            while (!command.Equals("print"))
            {
                switch (command)
                {
                    case "add":
                        index = actions[0];
                        element = actions[1];
                        input.Insert(index, element);
                        break;

                    //case "contains":
                    //    index = actions[0];
                    //    if (input.Contains(index))
                    //    {
                    //        contains = input.IndexOf(index);
                    //    }
                    //    else
                    //    {
                    //        contains = -1;
                    //    }
                        
                    //    break;

                    case "addMany":
                        index = actions[0];
                        for (int i = 1; i < actions.Length; i++)
                        {
                            element = actions[i];
                            input.Insert(index, element);
                        }
                        break;

                    case "remove":
                        index = actions[0];
                        break;

                    case "shift":
                        position = actions[0];
                        break;

                    case "sumPairs":
                        input.Sum();
                        break;

                }

                command = Console.ReadLine();
            }

            Console.WriteLine(contains);
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}
