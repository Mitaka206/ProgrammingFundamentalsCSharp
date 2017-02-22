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

            var output = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                var filesAndSize = input.Split(new char[] { ' ', ';', '\\', '\t' }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

                long size = long.Parse(filesAndSize[0]);
                string fileName = filesAndSize[1];
                string root = filesAndSize.Last();

                if (!output.ContainsKey(root))
                {
                    output[root] = new Dictionary<string, long>();
                    output[root][fileName] = 0;
                }
                output[root][fileName] = size;
            }

            var commandLine = Console.ReadLine().Split().Select(c => c.Trim()).ToArray();

            string type = commandLine[0];
            string place = commandLine[2];

            bool areResult = false;

            if (output.ContainsKey(place))
            {
                foreach (var item in output)
                {
                    if (item.Key == place)
                    {
                        foreach (var fileSize in item.Value.OrderByDescending(x => x.Value).ThenBy(i => i.Key))
                        {
                            if (fileSize.Key.EndsWith(type))
                            {
                                areResult = true;
                                Console.WriteLine($"{fileSize.Key} - {fileSize.Value} KB");
                            }
                        }
                    }
                }
            }

            if (!areResult)
            {
                Console.WriteLine("No");
            }
        }
    }
}
