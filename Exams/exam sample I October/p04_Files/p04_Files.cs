using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Files
{
    class p04_Files
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var output = new Dictionary<string, SortedDictionary<string, string>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                var filesAndSize = input.Split(new char[] { ' ', ';', '\\' }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

                string size = filesAndSize[0];
                string fileName = filesAndSize[1];
                string isPlace = filesAndSize.Last();

                var fileType = input.Split(new char[] { '.', ';' }, StringSplitOptions.RemoveEmptyEntries).Take(2);

                if (!output.ContainsKey(isPlace))
                {
                    output[isPlace] = new SortedDictionary<string, string>();
                    output[isPlace][fileName] = string.Empty;
                }
                output[isPlace][fileName] = size;
            }

            var commandLine = Console.ReadLine().Split();

            string type = commandLine[0];
            string place = commandLine[2];
            //-------------------------------------------------------------

            foreach (var item in output)
            {
                if (item.Key == place)
                {
                    foreach (var fileSize in item.Value)
                    {
                        Console.WriteLine($"{fileSize.Key} - {fileSize.Value} KB");
                    }
                }
            }
        }

    }
}
