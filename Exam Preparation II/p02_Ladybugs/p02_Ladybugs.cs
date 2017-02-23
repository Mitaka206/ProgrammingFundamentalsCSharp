using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_Ladybugs
{
    class p02_Ladybugs
    {
        static void Main(string[] args)
        {
            int sizeField = int.Parse(Console.ReadLine());

            var field = new int[sizeField];

            var bugPlace = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(b => b >= 0 && b <= sizeField)
                .ToList();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var command = line.Split().ToArray();

                var fromPosition = int.Parse(command[0]);
                var lefOrRight = command[1];
                var jump = int.Parse(command[2]);

                field = FullField(field, bugPlace);// 1 0 1 pr
                //---- for change==============================================
                while (field[fromPosition] > 0 && field[fromPosition] < field.Length)
                {
                    if (lefOrRight == "right")
                    {
                        if (field[fromPosition + jump] > field.Length || field[fromPosition + jump] == 1)
                        {
                            field[fromPosition] = 0;
                        }
                        else
                        {
                            field[fromPosition] = 1;
                        }
                    }

                    if (lefOrRight == "left")
                    {
                        if (field[fromPosition - jump] < 0 || field[fromPosition - jump] == 1)
                        {
                            field[fromPosition] = 0;
                        }
                        else
                        {
                            field[fromPosition] = 1;
                        }
                    }
                    break;
                }
                //---- for change================================================

                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));
        }

        private static int[] FullField(int[] field, List<int> bugPlace)
        {
            var isBug = 1;
            for (int i = 0; i < bugPlace.Count; i++)
            {
                field[bugPlace[i]] = isBug;
            }
            return field;
        }
    }
}

