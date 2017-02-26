using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_ArrayManipulator
{
    class p02_ArrayManipulator
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToList();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var command = line.Split().ToList();
                switch (command[0])
                {
                    case "exchange":
                        if (int.Parse(command[1]) >= array.Count || int.Parse(command[1]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            array = Exchange(array, command);
                        }
                        break;

                    case "max":
                        if (!array.Any(d => d % 2 != 0) && !array.Any(d => d % 2 == 0))
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            var result = 0;
                            if (command[1] == "odd")
                            {
                                result = array.LastIndexOf(array.Where(d => d % 2 != 0).Max());

                            }
                            if (command[1] == "even")
                            {
                                result = array.LastIndexOf(array.Where(d => d % 2 == 0).Max());
                            }
                            Console.WriteLine(result);
                        }
                        break;

                    case "min":
                        if (!array.Any(d => d % 2 != 0) || !array.Any(d => d % 2 == 0))
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            var result = 0;
                            if (command[1] == "odd")
                            {
                                result = array.LastIndexOf(array.Where(d => d % 2 != 0).Min());
                            }
                            if (command[1] == "even")
                            {
                                result = array.LastIndexOf(array.Where(d => d % 2 == 0).Min());
                            }
                            Console.WriteLine(result);
                        }
                        break;

                    case "first":
                        if (int.Parse(command[1]) > array.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (command[2] == "odd")
                            {
                                var result = array.Where(d => d % 2 != 0).Take(int.Parse(command[1])).ToList();
                                Console.WriteLine($"[{string.Join(", ", result)}]");
                            }
                            if (command[2] == "even")
                            {
                                var result = array.Where(d => d % 2 == 0).Take(int.Parse(command[1])).ToList();
                                Console.WriteLine($"[{string.Join(", ", result)}]");
                            }
                        }
                        break;

                    case "last":
                        if (int.Parse(command[1]) > array.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {   
                            if (command[2] == "odd")
                            {
                                var result = array.Where(d => d % 2 != 0).Reverse().Take(int.Parse(command[1])).ToList();
                                Console.WriteLine($"[{string.Join(", ", result)}]");
                            }
                            if (command[2] == "even")
                            {
                                var result = array.Where(d => d % 2 == 0).Reverse().Take(int.Parse(command[1])).ToList();
                                Console.WriteLine($"[{string.Join(", ", result)}]");
                            }
                        }
                        break;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static List<int> Exchange(List<int> array, List<string> command)
        {
            var take = array.Skip(int.Parse(command[1]) + 1).ToList();
            array = take.Concat(array.Take(int.Parse(command[1]) + 1).ToArray()).ToList();
            return array;
        }
    }
}
