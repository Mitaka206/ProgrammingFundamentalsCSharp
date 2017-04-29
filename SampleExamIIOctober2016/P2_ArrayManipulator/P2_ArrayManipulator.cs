namespace P2_ArrayManipulator
{
    using System;
    using System.Linq;

    class P2_ArrayManipulator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                var command = commandLine.Split();

                switch (command[0])
                {
                    case "exchange":
                        if (int.Parse(command[1]) <= input.Count && int.Parse(command[1]) > 0)
                        {
                            var count = int.Parse(command[1]);
                            var first = input.Skip(count + 1);
                            var second = input.Take(count + 1);
                            input = first.Concat(second).ToList();
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "max":
                        var evenOddMax = command[1];

                        if (evenOddMax == "even")//2,4,6....
                        {
                            if (input.Any(n => n % 2 == 0))
                            {
                                var maxNum = input.Where(n => n % 2 == 0).Max();
                                var indexOfMax = input.LastIndexOf(maxNum);
                                Console.WriteLine(indexOfMax);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }

                        }

                        if (evenOddMax == "odd")//1,3,5...
                        {
                            if (input.Any(n => n % 2 != 0))
                            {
                                var maxNum = input.Where(n => n % 2 != 0).Max();
                                var indexOfMax = input.LastIndexOf(maxNum);
                                Console.WriteLine(indexOfMax);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        break;

                    case "min":
                        var evenOddMin = command[1];

                        if (evenOddMin == "even")//2,4,6....
                        {
                            if (input.Any(n => n % 2 == 0))
                            {
                                var minNum = input.Where(n => n % 2 == 0).Min();
                                var indexOfMin = input.LastIndexOf(minNum);
                                Console.WriteLine(indexOfMin);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }

                        if (evenOddMin == "odd")//1,3,5...
                        {
                            if (input.Any(n => n % 2 != 0))
                            {
                                var minNum = input.Where(n => n % 2 != 0).Min();
                                var indexOfMin = input.LastIndexOf(minNum);
                                Console.WriteLine(indexOfMin);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        break;

                    case "first":
                        var countif = int.Parse(command[1]);
                        if (countif <= input.Count)
                        {
                            if (command[2] == "odd")
                            {
                                Console.WriteLine($"[{string.Join(", ", input.Where(n => n % 2 != 0).Take(countif))}]");
                            }

                            if (command[2] == "even")
                            {
                                Console.WriteLine($"[{string.Join(", ", input.Where(n => n % 2 == 0).Take(countif))}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;

                    case "last":
                        countif = int.Parse(command[1]);
                        if (countif <= input.Count)
                        {
                            if (command[2] == "odd")
                            {
                                Console.WriteLine($"[{string.Join(", ", input.Where(n => n % 2 != 0).OrderByDescending(n => n).Take(countif))}]");
                            }

                            if (command[2] == "even")
                            {
                                Console.WriteLine($"[{string.Join(", ", input.Where(n => n % 2 == 0).OrderByDescending(n => n).Take(countif))}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;
                }
                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}
