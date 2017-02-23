using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02_ladybugsTrain
{
    class p02_ladybugsTrain
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

            field = FullField(field, bugPlace);

            var line = Console.ReadLine();

            while (line != "end")
            {
                var command = line.Split().ToArray();

                var fromPosition = int.Parse(command[0]);
                var lefOrRight = command[1];
                var jump = int.Parse(command[2]);

                var foundPlace = false;

                while (!foundPlace)
                {
                    field[fromPosition] = 0;
                    switch (lefOrRight)
                    {
                        case "right":
                            fromPosition += jump;// is new position for right
                            break;
                        case "left":
                            fromPosition -= jump;// is new position for left
                            break;
                    }

                    if (field[fromPosition] < 0 || field[fromPosition] >= field.Length)
                    {
                        foundPlace = true;
                    }

                    if (field[fromPosition] == 0)
                    {
                        field[fromPosition] = 1;
                        foundPlace = true;
                        continue;
                    }
                    if (field[fromPosition] == 1)
                    {
                        continue;
                    }

                }

                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));
        }

        private static int[] FullField(int[] field, List<int> bugPlace)
        {
            for (int i = 0; i < bugPlace.Count; i++)
            {
                field[bugPlace[i]] = 1;
            }
            return field;
        }
    }
}
