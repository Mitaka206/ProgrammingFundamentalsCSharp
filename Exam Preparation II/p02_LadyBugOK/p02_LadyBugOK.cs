using System;
using System.Linq;

namespace p02_LadyBugOK
{
    class p02_LadyBugOK
    {
        static void Main()
        {
            int sizeField = int.Parse(Console.ReadLine());
            int[] indexesToPlantBugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] commandInput = Console.ReadLine().Split();

            int[] field = PlantBugsOnField(sizeField, indexesToPlantBugs);

            while (commandInput[0] != "end")
            {
                int bugIndex = int.Parse(commandInput[0]);
                string flightDirection = commandInput[1];
                int flightLength = int.Parse(commandInput[2]);

                flightDirection = FlightDirectionCorrection(flightDirection, flightLength);
                
                if (bugIndex >= 0 && bugIndex < sizeField)
                {
                    if (field[bugIndex] == 1)
                    {
                        field[bugIndex] = 0;
                
                        if (flightDirection == "left")
                        {
                            field = NewFieldLeft(field, bugIndex, flightLength);
                        }  
                        if (flightDirection == "right")
                        {
                            field = NewFieldRight(field, bugIndex, flightLength);
                        }
                    }
                }

                commandInput = Console.ReadLine().Split();

            }
            Console.WriteLine(string.Join(" ", field));
        }
        
        static int[] NewFieldLeft(int[] field, int bugIndex, int flightLength)
        {
            flightLength = Math.Abs(flightLength);
            for (int i = bugIndex - flightLength; i >= 0; i = i - flightLength)
            {
                if (field[i] == 0)
                {
                    field[i] = 1;
                    break;
                }
            }
            return field;
        }
        private static int[] NewFieldRight(int[] field, int bugIndex, int flightLength)
        {
            flightLength = Math.Abs(flightLength);
            for (int i = bugIndex + flightLength; i < field.Length; i = i + flightLength)
            {
                if (field[i] == 0)
                {
                    field[i] = 1;
                    break;
                }
            }

            return field;
        }
        static string FlightDirectionCorrection(string flightDirection, int flightLength)
        {
            string correctedDirection = flightDirection;
            if (flightLength < 0)
            {
                switch (flightDirection)
                {
                    case "left": correctedDirection = "right"; break;
                    case "right": correctedDirection = "left"; break;
                }
            }
            return correctedDirection;
        }
        static int[] PlantBugsOnField(int sizeField, int[] indexToPlantBugs)
        {
            int[] field = new int[sizeField];
            for (int i = 0; i < indexToPlantBugs.Length; i++)
            {
                if (indexToPlantBugs[i] >= 0 && indexToPlantBugs[i] < sizeField)
                {
                    field[indexToPlantBugs[i]] = 1;
                }
            }
            return field;
        }
    }
}
