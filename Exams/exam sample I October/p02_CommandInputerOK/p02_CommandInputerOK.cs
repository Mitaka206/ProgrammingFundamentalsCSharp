using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace p02_CommandInputerOK
{
    class p02_CommandInputerOK
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine() // 1 2 5 8 7 3 10 6 4 9
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = Console.ReadLine() // reverse from 2 count 4
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "end")
            {
                int start = 0;
                int count = 0;
                int rollCount = 0;
                var currentList = new List<string>();

                switch (command[0])
                {
                    case "reverse":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);

                        if (start < 0
                            || count < 0
                            || start >= input.Count
                            || (count + start) > input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        currentList = input
                        .Skip(start)
                        .Take(count)
                        .Reverse()
                        .ToList();

                        input.RemoveRange(start, count);//remove edited part from input
                        input.InsertRange(start, currentList);//insert cuurentLis in input from start to next count
                        break;

                    case "sort":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);
                        if (start < 0
                            || count < 0
                            || start >= input.Count
                            || (count + start) > input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        currentList = input
                        .Skip(start)
                        .Take(count)
                        .OrderBy(s => s)
                        .ToList();

                        input.RemoveRange(start, count);
                        input.InsertRange(start, currentList);
                        break;

                    case "rollLeft":
                        rollCount = int.Parse(command[1]);

                        if (rollCount < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                                                //reduct count
                        for (int i = 0; i < rollCount % input.Count; i++)//loop rollCount times
                        {
                            string element = input[0];//save first element

                            input.RemoveAt(0);//remove from index[0]
                            input.Add(element);//add element in last position
                        }
                        break;

                    case "rollRight":
                        rollCount = int.Parse(command[1]);

                        if (rollCount < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                                                 //reduct count
                        for (int i = 0; i < rollCount % input.Count; i++)//loop rollCount times
                        {
                            string element = input[input.Count - 1];//save last element

                            input.RemoveAt(input.Count - 1);//remove from last index
                            input.Insert(0, element);//add element in first position
                        }

                        break;

                    default:
                        break;
                }

                command = Console.ReadLine() // command or "end"
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            string output = string.Join(", ", input);

            Console.WriteLine($"[{output}]");
        }
    }
}
