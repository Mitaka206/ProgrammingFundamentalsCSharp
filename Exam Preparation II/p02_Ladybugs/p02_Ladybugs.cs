using System;
using System.Linq;

namespace p02_Ladybugs
{
    class p02_Ladybugs
    {
        static void Main(string[] args)
        {
            int sizeField = int.Parse(Console.ReadLine());

            var ladybugs = new int[sizeField];

            var ladybugIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(b => b >= 0 && b < sizeField)
                .ToArray();

            for (int i = 0; i < ladybugIndexes.Length; i++)
            {
                ladybugs[ladybugs[i]] = 1;
            }
            var line = Console.ReadLine();

            while (line != "end")
            {
                var tokens = line.Split().ToArray();

                var ladybugIndex = int.Parse(tokens[0]);
                var lefOrRight = tokens[1];
                var flyLen = int.Parse(tokens[2]);

                if (ladybugIndex < 0 || ladybugIndex >= ladybugs.Length)
                {
                    line = Console.ReadLine();
                    continue;
                }
                if (ladybugs[ladybugIndex] == 0)
                {
                    line = Console.ReadLine();
                    continue;
                }

                MoveLadybugs(ladybugs, ladybugIndex, flyLen, lefOrRight);

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladybugs));
        }

        public static void MoveLadybugs(int[] ladybugs, int ladybugIndex, int flyLen, string lefOrRight)
        {

            ladybugs[ladybugIndex] = 0;

            var foundPlace = false;

            while (!foundPlace)
            {
                switch (lefOrRight)
                {
                    case "right":
                        ladybugIndex += flyLen;
                        break;
                    case "left":
                        ladybugIndex -= flyLen;
                        break;
                }

                if (ladybugIndex >= ladybugs.Length || ladybugIndex < 0)
                {
                    foundPlace = true;
                    continue;
                }

                if (ladybugs[ladybugIndex] == 1)
                {
                    continue;
                }

                if (ladybugs[ladybugIndex] == 0)
                {
                    ladybugs[ladybugIndex] = 1;
                    foundPlace = true;
                    continue;
                }
            }
        }

    }
        
}

